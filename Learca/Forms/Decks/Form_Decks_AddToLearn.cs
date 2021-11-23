using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма Добавления колод в список для изучения
    /// </summary>
    class Form_AbstractDeckSet_AddToLearn : AbstractForm_DeckSet
    {
        private readonly SelectedAbstractDecksToLearn selectedAbstractDecks;

        public Form_AbstractDeckSet_AddToLearn(MainForm mainForm, SelectedAbstractDecksToLearn selectedAbstractDecks) : base(mainForm, selectedAbstractDecks.AbstractDeckSet)
        {
            this.selectedAbstractDecks = selectedAbstractDecks ?? throw new ArgumentNullException("SelectedAbstractDecks decks не может быть null");
        }

        protected override void AbstractForm_DeckSet_Load(object sender, EventArgs e)
        {
            base.AbstractForm_DeckSet_Load(sender, e);

            btnCreateDeck.Visible = false;
            btnDeleteEmptyDecks.Visible = false;

            btnMoveInside.Text = "ADD TO LEARN";
            btnMoveInside.Location = btnCreateDeck.Location;
           btnMoveInside.Visible = true;
            btnMoveInside.Click += BtnMoveInside_Click;

            dataGridView_Decks.MultiSelect = true;

            btnOpenDeck.Text = "LOOK AT DECK";
        }

        private void BtnMoveInside_Click(object sender, EventArgs e)
        {
            if (dataGridView_Decks.SelectedRows.Count == 0)
                throw new ArgumentNullException("dataGridView_Decks.SelectedRows.Count не может быть == 0");

            string question = (dataGridView_Decks.SelectedRows.Count == 1) ? "Add Deck to Learn?" : "Add Decks to Learn?";

            if (MessageBox.Show(question, "Adding", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            foreach (DataGridViewRow row in dataGridView_Decks.SelectedRows)
            {
                var deck = row.Tag as AbstractDeck;
                selectedAbstractDecks.Add(deck);
            }

            RemoveSelectedRows();

            RefreshButtons();
        }

        /// <summary>
        /// Открытие формы для просмотра Колоды Form_LookAtDeck
        /// </summary>
        /// <param name="deck"></param>
        protected override void OpenDeck(AbstractDeck deck)
        {
            var form = new Form_LookAtDeck(mainForm, deck);
            form.ShowDialog();
        }

        /// <summary>
        /// Обновление кнопок на форме
        /// </summary>
        protected override void RefreshButtons()
        {
            base.RefreshButtons();

            btnMoveInside.Enabled = dataGridView_Decks.SelectedRows.Count > 0;
        }

        /// <summary>
        /// Создание строки для dataGridView_Decks
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="number">увеличивается на единицу, если возвращается не null</param>
        /// <returns></returns>
        protected override DataGridViewRow CreateRow(AbstractDeck deck, ref int number)
        {
            if (selectedAbstractDecks.Contains(deck))
                return null;

           return base.CreateRow(deck, ref number);
        }
    }

}
