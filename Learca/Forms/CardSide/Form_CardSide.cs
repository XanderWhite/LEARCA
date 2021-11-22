using Learca.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
   /// <summary>
   /// Форма для редактирования стороны карточки
   /// </summary>
    internal partial class Form_CardSide : Form
    {
        private const int MAX_VALUE_COUNT = 5;

        private readonly MainForm mainForm;
        private CardSide currentCardSide;
        public CardSide CurrentCardSide
        {
            get { return currentCardSide; }
            set
            {
                currentCardSide = value ?? throw new ArgumentNullException("value не может быть null");
            }
        }

        private readonly int pbHeight;
        private readonly int pbWidth;
        private readonly int pbLocationX;
        private readonly int pbLocationY;

        /// <summary>
        /// Текстовые значения отображаемые на форме
        /// </summary>
        private readonly List<string> values;
        
        /// <summary>
        /// Путь к изображению отображаемому на форме
        /// </summary>
        private string ImagePath { get; set; }

        private Panel_Values panel_Values;

        private int NotEptyValueCount { get => values.Where((value) => !(string.IsNullOrWhiteSpace(value))).Count(); }

        public Form_CardSide(MainForm mainForm, CardSide cardSide)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            CurrentCardSide = cardSide;
            values = new List<string>();

            InitializeComponent();

            MdiParent = mainForm;

            pbHeight = pictureBox.Height;
            pbWidth = pictureBox.Width;
            pbLocationX = pictureBox.Location.X;
            pbLocationY = pictureBox.Location.Y;

            InitPanel_Values();

            Load += Form_CardSide_Load;
        }

        private void Form_CardSide_Load(object sender, EventArgs e)
        {
            FormClosing += Form_CardSide_FormClosing;
            btnAddEmptyValue.Click += BtnAddEmptyValue_Click;
            btnClearEmptyValues.Click += BtnClearEmptyValues_Click;
            btnSave.Click += Btn_Save_Click;
            checkBox_MixValues.KeyPress += CheckBox_MixValues_KeyPress;
            btnToLeftSide.Click += BtnSwapSide_Click;
            btnToRightSide.Click += BtnSwapSide_Click;

            mainForm.Text = "LEARCA. Card side";
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            
            RefreshForm();
        }

        private void Form_CardSide_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled && !SaveToCardSide())
                e.Cancel = true;
        }

        /// <summary>
        /// Инициализация панели Panel_Values
        /// </summary>
        private void InitPanel_Values()
        {
            panel_Values = new Panel_Values(this, values)
            {
                Location = panel_TextBoxes.Location,
                Height = panel_TextBoxes.Height,
                Width = panel_TextBoxes.Width
            };

            panel_CardSide.Controls.Add(panel_Values);
        }

        private void BtnSwapSide_Click(object sender, EventArgs e)
        {
            if(btnSave.Enabled && !SaveToCardSide())
                return;

            CurrentCardSide = CurrentCardSide.OtherSide;

            RefreshForm();
        }

        /// <summary>
        /// Обновление формы. Заполнение данными из CardSide. Обновление кнопок и checkBox.
        /// </summary>
        private void RefreshForm()
        {
            values.Clear();
            values.AddRange(CurrentCardSide.GetValues());

            ImagePath = CurrentCardSide.ImagePath;

            checkBox_MixValues.Checked = CurrentCardSide.MixValues;

            panel_Values.RefreshPanel();

            RefreshPictureBoxImageFrom(ImagePath);

            RefreshButtons();

            RefreshCheckBox_MixValues();

            btnSave.Enabled = false;
        }

        /// <summary>
        /// Сфокусироваться на btnAddValue после загрузки формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = btnAddEmptyValue;
        }

        /// <summary>
        /// Обновить кнопки на форме
        /// </summary>
        public void RefreshButtons()
        {
            btnAddEmptyValue.Enabled = values.Count < MAX_VALUE_COUNT;
            btnClearEmptyValues.Enabled = values.Count > 1 && values.Contains(string.Empty);

            btnToLeftSide.Visible = CurrentCardSide.Side == Side.Right;
            btnToRightSide.Visible = !btnToLeftSide.Visible;
        }

        /// <summary>
        /// Обновление checkBox_MixValues
        /// </summary>
        internal void RefreshCheckBox_MixValues()
        {
            if (NotEptyValueCount <= 1)
                checkBox_MixValues.Enabled =
                    checkBox_MixValues.Checked = false;
            else
                checkBox_MixValues.Enabled = true;
        }

        private void BtnAddEmptyValue_Click(object sender, EventArgs e)
        {
            if (values.Count >= MAX_VALUE_COUNT)
                throw new Exception("values.Count должно быть меньше MAX_VALUE_COUNT");

            values.Add(string.Empty);

            panel_Values.RefreshPanel();
            RefreshButtons();
        }

        private void BtnClearEmptyValues_Click(object sender, EventArgs e)
        {
            values.RemoveAll(value => string.IsNullOrWhiteSpace(value));

            panel_Values.RefreshPanel();
            RefreshButtons();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveToCardSide();
        }

        /// <summary>
        /// Сохранить данные в CardSide.
        /// </summary>
        /// <returns>Если пользователь отменил сохранение, возвращается false</returns>
        private bool SaveToCardSide()
        {
            DialogResult dialogResult = MessageBox.Show("Save Changes?", "Saving", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Cancel)
                return false;

            if (dialogResult == DialogResult.No)
                return true;

            CurrentCardSide.ReplaceValues(values);

            CurrentCardSide.MixValues = checkBox_MixValues.Checked;

            SaveImage();

            if (CurrentCardSide.ParentCard.GetOneFilledSide() == null)
                CurrentCardSide.ParentCard.RemoveCard();
            else
                CurrentCardSide.ParentCard.SaveCard();

            btnSave.Enabled = false;

            Database.WriteXml();

            return true;
        }

        /// <summary>
        /// Проверка данных на форме для активации ButtonSave
        /// </summary>
        internal void CheckDataForButtonSave()
        {
            if (currentCardSide.ImagePath != ImagePath)
                btnSave.Enabled = true;
            else if (CurrentCardSide.MixValues != checkBox_MixValues.Checked)
                btnSave.Enabled = true;
            else if (!CurrentCardSide.Compare(values))
                    btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void CheckBox_MixValues_CheckedChanged(object sender, EventArgs e)
        {
            CheckDataForButtonSave();
        }

        private void CheckBox_MixValues_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkBox_MixValues.Checked = !checkBox_MixValues.Checked;
        }

        #region Picture

        /// <summary>
        /// Обновить изображение в pictureBox
        /// </summary>
        /// <param name="path"></param>
        private void RefreshPictureBoxImageFrom(string path)
        {
            if (pictureBox.Image != null)
                pictureBox.Image.Dispose();

            var image = ImageHandler.GetImage(path);

            if (image != null)
            {
                pictureBox.Visible = false;
                ImageHandler.FillPictureBox(pictureBox, image);
                pictureBox.Visible = true;

                btnDeletePicture.Visible = true;
                label_AddPicture.Visible = false;
            }
            else
            {
                pictureBox.Image = null;
                pictureBox.Height = pbHeight;
                pictureBox.Width = pbWidth;
                pictureBox.Location = new Point(pbLocationX, pbLocationY);

                btnDeletePicture.Visible = false;
                label_AddPicture.Visible = true;
            }
        }

        /// <summary>
        /// Сохранить изображение из ImagePath
        /// </summary>
        private void SaveImage()
        {
            if (CurrentCardSide.ImagePath == ImagePath)
                return;

            if (string.IsNullOrWhiteSpace(ImagePath))
            {
                CurrentCardSide.ImagePath = string.Empty;
            }
            else
            {
                Directory.CreateDirectory("Pictures");

                var fileName = $"Pictures\\{Guid.NewGuid()}.jpg";

                File.Copy(ImagePath, fileName);

                CurrentCardSide.ImagePath =
                    ImagePath = fileName;
            }
        }

        private void BtnDeletePicture_Click(object sender, EventArgs e)
        {
            ImagePath = string.Empty;

            RefreshPictureBoxImageFrom(ImagePath);

            CheckDataForButtonSave();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "Image files (*.jpg, *.jpeg) | *.jpg; *.jpeg;"
            };

            if (fd.ShowDialog() == DialogResult.OK)
            {
                ImagePath = fd.FileName;
                RefreshPictureBoxImageFrom(ImagePath);

                CheckDataForButtonSave();
            }
        }

        #endregion Picture  
    }
}
