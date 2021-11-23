using Learca.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма с настройками для изучения карточек и переходом к изучению
    /// </summary>
    public partial class Form_SettingsToLearn : Form
    {
        private CancellationTokenSource cts;
        private readonly MainForm mainForm;
        private readonly LearningSettings learningSettings;

        public Form_SettingsToLearn(MainForm mainForm)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            learningSettings = new LearningSettings();

            InitializeComponent();

            MdiParent = mainForm;

            Load += Form_SettingsToLearn_Load;

            RefreshButtons();
        }

        private void Form_SettingsToLearn_Load(object sender, EventArgs e)
        {
            trackBar_Percent.ValueChanged += TrackBar_Percent_ValueChanged;

            FormClosed += Form_SettingsToLearn_FormClosed;
            VisibleChanged += Form_LearnSettings_VisibleChanged;

            checkBox_LearnOnlyOneSide.CheckedChanged += CheckBox_LearnOnlyOneSide_CheckedChanged;
            checkBox_LearnOnlyOneSide.KeyPress += CheckBox_LearnOnlyOneSide_KeyPress;

            checkBox_LearnQACards.CheckedChanged += CheckBox_LearnQACards_CheckedChanged;
            checkBox_LearnQACards.KeyPress += CheckBox_LearnQACards_KeyPress;

            checkBox_LearnBothSides.CheckedChanged += CheckBox_LearnBothSides_CheckedChanged;
            checkBox_LearnBothSides.KeyPress += CheckBox_LearnBothSides_KeyPress;

            checkBox_LearnInformationCards.CheckedChanged += CheckBox_LearnInformationCards_CheckedChanged;
            checkBox_LearnInformationCards.KeyPress += CheckBox_LearnInformationCards_KeyPress;

            checkBox_TypeAnswers.CheckedChanged += CheckBox_TypeAnswers_CheckedChanged;
            checkBox_TypeAnswers.KeyPress += CheckBox_TypeAnswers_KeyPress;

            dataGridView_Decks.SelectionChanged += DataGridView_Decks_SelectionChanged;
            dataGridView_Decks.DoubleClick += DataGridView_Decks_DoubleClick;
            dataGridView_Decks.KeyDown += DataGridView_Decks_KeyDown;

            btnDelete.Click += BtnDelete_Click;
            btnAddDecks.Click += BtnAddLearningDeck_Click;
            btnAddChosenDeck.Click += BtnAddChosenDeck_Click;
            btnOpen.Click += BtnOpen_Click;
            btnAddDecksAuto.Click += BtnAddDecksAuto_Click;
            btnAddChosenDecksAuto.Click += BtnAddChosenDecksAuto_Click;
            btnLearnCards.Click += BtnLearnCards_Click;

            radioButton_LeftSide.CheckedChanged += RadioButton_LeftSide_CheckedChanged;
            radioButton_RightSide.CheckedChanged += RadioButton_RightSide_CheckedChanged;
            radioButton_MixSides.CheckedChanged += RadioButton_MixSides_CheckedChanged;

            Dock = DockStyle.Fill;
            DoubleBuffered = true;

            foreach (DataGridViewColumn column in dataGridView_Decks.Columns)
            {
                column.Width = mainForm.ConvertWidth(column.Width);
            }
        }

        private void Form_SettingsToLearn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (learningSettings != null)
                learningSettings.RemoveAllDecks();
        }

        private void CheckBox_TypeAnswers_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkBox_TypeAnswers.Checked = !checkBox_TypeAnswers.Checked;
        }

        private void CheckBox_LearnInformationCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkBox_LearnInformationCards.Checked = !checkBox_LearnInformationCards.Checked;
        }

        private void CheckBox_LearnBothSides_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkBox_LearnBothSides.Checked = !checkBox_LearnBothSides.Checked;
        }

        private void CheckBox_LearnQACards_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkBox_LearnQACards.Checked = !checkBox_LearnQACards.Checked;
        }

        private void CheckBox_LearnOnlyOneSide_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkBox_LearnOnlyOneSide.Checked = !checkBox_LearnOnlyOneSide.Checked;
        }

        private void BtnLearnCards_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher(learningSettings);

            if (teacher.LearningCardsCount > 0)
            {
                mainForm.OpenNextForm(new Form_Learning(mainForm, teacher));
                mainForm.AddToLastForms(this);
            }
            else
                MessageBox.Show("No matching cards", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAddChosenDecksAuto_Click(object sender, EventArgs e)
        {
            learningSettings.AddToChosenDeckListAuto(dateTimePicker_ChosenDeckStartPoint.Value);
            FillDataGridView_Decks_Async();
        }

        private void BtnAddDecksAuto_Click(object sender, EventArgs e)
        {
            learningSettings.AddToDeckListAuto(dateTimePicker_DeckStartPoint.Value);
            FillDataGridView_Decks_Async();
        }

        private void RadioButton_MixSides_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_MixSides.Checked)
            {
                if (learningSettings.LearnOnlyOneSide)
                    throw new ArgumentException("value не может быть == BeginLearnWith.MixSides пока learnOnlyOneSide == true");

                learningSettings.StartingSide = BeginLearnWith.MixSides;
            }
        }

        private void RadioButton_RightSide_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_RightSide.Checked)
                learningSettings.StartingSide = BeginLearnWith.RightSide;
        }

        private void RadioButton_LeftSide_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_LeftSide.Checked)
                learningSettings.StartingSide = BeginLearnWith.LeftSide;
        }

        private void CheckBox_TypeAnswers_CheckedChanged(object sender, EventArgs e)
        {
            learningSettings.TypeAnswers = checkBox_TypeAnswers.Checked;
        }

        private void CheckBox_LearnQACards_CheckedChanged(object sender, EventArgs e)
        {
            learningSettings.LearnQACards = checkBox_LearnQACards.Checked;
        }

        private void CheckBox_LearnInformationCards_CheckedChanged(object sender, EventArgs e)
        {
            learningSettings.LearnInformationCards = checkBox_LearnInformationCards.Checked;
        }

        private void DataGridView_Decks_DoubleClick(object sender, EventArgs e)
        {
            if ((sender as DataGridView).CurrentRow == null)
                return;

            Open(dataGridView_Decks.CurrentRow.Tag as AbstractDeck);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView_Decks.SelectedRows.Count != 1)
                throw new Exception("dataGridView_Decks.SelectedRows.Count не может быть != 1");

            Open(dataGridView_Decks.CurrentRow.Tag as AbstractDeck);
        }

        /// <summary>
        /// Открыть форму для редактирования Колоды
        /// </summary>
        /// <param name="deck"></param>
        private void Open(AbstractDeck deck)
        {
            Form form = deck.CreateFormToEditDeck(mainForm);

            mainForm.OpenNextForm(form);
            mainForm.AddToLastForms(this);
        }

        private void BtnAddChosenDeck_Click(object sender, EventArgs e)
        {
            var form = new Form_AbstractDeckSet_AddToLearn(mainForm, learningSettings.SelectedChosenDecks)
            {
                Text = "LEARCA. Chosen Decks. Add to learn"
            };

            mainForm.OpenNextForm(form);
            mainForm.AddToLastForms(this);
        }

        private void BtnAddLearningDeck_Click(object sender, EventArgs e)
        {
            var form = new Form_AbstractDeckSet_AddToLearn(mainForm, learningSettings.SelectedDecks)
            {
                Text = "LEARCA. Decks. Add to learn"
            };

            mainForm.OpenNextForm(form);
            mainForm.AddToLastForms(this);
        }

        /// <summary>
        /// Заполнение dataGridView_Decks
        /// </summary>
        protected async void FillDataGridView_Decks_Async()
        {
            label_Loading.Visible = true;

            dataGridView_Decks.Rows.Clear();

            var rows = await Task.Run<DataGridViewRow[]>(() => GetRows(cts.Token));

            if (cts.IsCancellationRequested)
                return;

            dataGridView_Decks.Rows.AddRange(rows);
            dataGridView_Decks.ClearSelection();

            label_Loading.Visible = false;
        }

        /// <summary>
        /// Получить массив DataGridViewRow на основе имеющихся колод
        /// </summary>
        /// <returns></returns>
        public DataGridViewRow[] GetRows(CancellationToken token)
        {
            var rows = new List<DataGridViewRow>();

            int index = 0;

            foreach (var deck in learningSettings.GetAllDecks())
            {
                if (token.IsCancellationRequested)
                    break;

                var row = CreateRow(deck, ref index);

                if (row != null)
                    rows.Add(row);
            }

            return rows.ToArray();
        }

        /// <summary>
        /// Создание строки для dataGridView_Decks
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="index">Инкрементирует index при каждом выполнении</param>
        /// <returns></returns>
        protected virtual DataGridViewRow CreateRow(AbstractDeck deck, ref int index)
        {
            if (deck == null)
                throw new ArgumentNullException("AbstractDeck deck не может быть null");

            var row = new DataGridViewRow();

            var cell_number = new DataGridViewTextBoxCell();
            var cell_deckName = new DataGridViewTextBoxCell();
            var cell_cards = new DataGridViewTextBoxCell();
            var cell_startingPoint = new DataGridViewTextBoxCell();
            var cell_description = new DataGridViewTextBoxCell();

            cell_number.Value = ++index;
            cell_deckName.Value = string.IsNullOrWhiteSpace(deck.Name) ? "no name" : deck.Name;
            cell_cards.Value = deck.CardCount;
            cell_startingPoint.Value = deck.StartPoint.ToLongDateString();
            cell_description.Value = deck.Description;

            row.Cells.AddRange(cell_number, cell_deckName, cell_cards, cell_startingPoint, cell_description);

            row.Tag = deck;

            return row;
        }

        private void DataGridView_Decks_SelectionChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void CheckBox_LearnBothSides_CheckedChanged(object sender, EventArgs e)
        {
            learningSettings.LearnBothSidesCards =
                groupBox_AskBothSides.Visible = checkBox_LearnBothSides.Checked;
        }

        private void CheckBox_LearnOnlyOneSide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LearnOnlyOneSide.Checked)
            {
                groupBox_StartSide.Text = "LEARN";

                radioButton_MixSides.Visible = false;
                groupBox_Percent.Visible = false;

                if (radioButton_MixSides.Checked)
                    radioButton_LeftSide.Checked = true;
            }
            else
            {
                groupBox_StartSide.Text = "BEGIN WITH";

                radioButton_MixSides.Visible =
                    groupBox_Percent.Visible = true;
            }

            learningSettings.LearnOnlyOneSide = checkBox_LearnOnlyOneSide.Checked;
        }

        private void TrackBar_Percent_ValueChanged(object sender, EventArgs e)
        {
            learningSettings.Percent_LeftSide = trackBar_Percent.Value * 10;

            label_LeftPercent.Text = learningSettings.Percent_LeftSide + "%";
            label_RightPercent.Text = learningSettings.Percent_RightSide + "%";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            HandleDecksRemoval();
        }

        /// <summary>
        /// Обработать Удаление Колод
        /// </summary>
        private void HandleDecksRemoval()
        {
            string question = (dataGridView_Decks.SelectedRows.Count == 1) ? "Delete Deck?" : $"Delete {dataGridView_Decks.SelectedRows.Count} Decks?";

            if (MessageBox.Show(question, "Deleting", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            RemoveSelectedDecks();

            Database.WriteXml();

            RemoveSelectedRows();

            RefreshButtons();
        }

        /// <summary>
        /// Удаление выделенных строк
        /// </summary>
        private void RemoveSelectedRows()
        {
            int count = dataGridView_Decks.SelectedRows.Count;

            if (count == 0) return;

            while (count > 0)
            {
                dataGridView_Decks.Rows.RemoveAt(dataGridView_Decks.SelectedRows[0].Index);
                count--;
            }

            RefreshDataGridColumn_Number();
        }

        /// <summary>
        /// Обновление нумерации строк
        /// </summary>
        private void RefreshDataGridColumn_Number()
        {
            int n = 1;

            foreach (DataGridViewRow row in dataGridView_Decks.Rows)
            {
                row.Cells[0].Value = n++;
            }
        }

        /// <summary>
        /// Удаление выделенных Колод
        /// </summary>
        private void RemoveSelectedDecks()
        {
            foreach (DataGridViewRow row in dataGridView_Decks.SelectedRows)
            {
                var deck = row.Tag as AbstractDeck;

                learningSettings.RemoveDeck(deck);
            }
        }

        private void Form_LearnSettings_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                mainForm.Text = Text;

                cts = new CancellationTokenSource();
                FillDataGridView_Decks_Async();
                RefreshButtons();
            }
            else
            {
                if (cts != null)
                    cts.Cancel();
            }
        }

        private void DataGridView_Decks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView_Decks.SelectedRows.Count > 0)
                HandleDecksRemoval();
            else if (e.KeyCode == Keys.Enter && dataGridView_Decks.SelectedRows.Count == 1)
                Open(dataGridView_Decks.SelectedRows[0].Tag as AbstractDeck);
        }

        /// <summary>
        /// Обновление кнопок на форме
        /// </summary>
        private void RefreshButtons()
        {
            btnDelete.Enabled = dataGridView_Decks.SelectedRows.Count > 0;
            btnOpen.Enabled = dataGridView_Decks.SelectedRows.Count == 1;
            btnAddChosenDeck.Enabled = Database.ChosenDeckSet.Count - learningSettings.SelectedChosenDecks.Count > 0;
            btnAddDecks.Enabled = Database.DeckSet.Count - learningSettings.SelectedDecks.Count > 0;
            btnLearnCards.Enabled = learningSettings.SelectedDecks.Count > 0 || learningSettings.SelectedChosenDecks.Count > 0;
        }
    }
}
