using Learca.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Панель отображающая сторону карточки находящейся в процессе изучения
    /// </summary>
    public class LearningCardSidePanel : Panel
    {
        private readonly MainForm mainForm;

        private readonly int tbLocation_X;
        private readonly int tbWidth;
        private readonly int tbMargin;
        private readonly int pBLocation_X;
        private readonly int pBLocation_Y;
        private readonly int pBWidth;


        private readonly int tBMaxHeight;
        private readonly int tBStartPosition_Y;
        private readonly int pBHeight;

        protected CardSide cardSide;

        /// <summary>
        /// Textbox'ы для отображения значений стороны карточки
        /// </summary>
        public TextBox[] TextBoxes { get; private set; }

        /// <summary>
        /// для отображения Изображения из cardSide
        /// </summary>
        protected PictureBox pictureBox;

        /// <summary>
        /// Изображение из cardSide;
        /// </summary>
        protected Image image;

        public LearningCardSidePanel(MainForm mainForm, CardSide cardSide)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            this.cardSide = cardSide ?? throw new ArgumentNullException("CardSide cardSide не может быть null");

            TextBoxes = new TextBox[0];

            tBMaxHeight = mainForm.ConvertHeight(!cardSide.HasImage ? 500 : 329);
            tBStartPosition_Y = mainForm.ConvertHeight(!cardSide.HasImage ? 35 : 206);
            pBHeight = mainForm.ConvertHeight((cardSide.ValueCount == 0) ? 500 : 165);
            tbLocation_X = mainForm.ConvertWidth(36);
            pBWidth = tbWidth = mainForm.ConvertWidth(600);
            tbMargin = mainForm.ConvertHeight(6);
            pBLocation_X = mainForm.ConvertWidth(36);
            pBLocation_Y = mainForm.ConvertHeight(35);
            

            DoubleBuffered = true;
            BackgroundImage = Resources.Card;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.Transparent;
            Size = new Size(mainForm.ConvertWidth(655), mainForm.ConvertHeight(590));
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        /// <summary>
        /// Заполнение панели данными из cardSide
        /// </summary>
        /// <param name="textBoxesIsReadOnly">свойство ReadOnly для textbox'ов</param>
        public virtual void Fill(bool textBoxesIsReadOnly)
        {
            var values = (cardSide.MixValues) ? cardSide.GetShuffledValues() : cardSide.GetValues();

            CreateTextBoxes(values, textBoxesIsReadOnly);

            AddPictureBox();
        }

        /// <summary>
        /// Создание textbox'ов по значениям
        /// </summary>
        /// <param name="values"></param>
        /// <param name="textBoxIsReadOnly"></param>
        protected void CreateTextBoxes(string[] values, bool textBoxIsReadOnly)
        {
            if (values == null || values.Length == 0)
                return;

            TextBoxes = new TextBox[values.Length];

            int nextPositionY = tBStartPosition_Y;

            int height = (tBMaxHeight - ((values.Length - 1) * tbMargin)) / values.Length;

            for (int i = 0; i < values.Length; i++)
            {
                TextBoxes[i] = CreateTextBox(height, nextPositionY, values[i], textBoxIsReadOnly, !textBoxIsReadOnly);

                nextPositionY += height + tbMargin;
            }

            Controls.AddRange(TextBoxes);
        }

        protected TextBox CreateTextBox(int height, int locationY, string text, bool readOnly, bool tabStop)
        {
            var tb = new TextBox
            {
                Location = new Point(tbLocation_X, locationY),
                Text = text,
                Height = height,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Microsoft Sans Serif", 12),
                BorderStyle = BorderStyle.None,
                Width = tbWidth,
                ReadOnly = readOnly,
                TabStop = tabStop
            };

            return tb;
        }

        /// <summary>
        /// Добавление PicureBox, если имеется изображение в cardSide
        /// </summary>
        protected virtual void AddPictureBox()
        {
            image = ImageHandler.GetImage(cardSide.ImagePath);

            if (image == null)
                return;

            pictureBox = CreatePictureBox(image);

            Controls.Add(pictureBox);
        }

        /// <summary>
        /// Создание PictureBox 
        /// </summary>
        /// <param name="image">Изображение для PictureBox</param>
        /// <returns></returns>
        protected virtual PictureBox CreatePictureBox(Image image)
        {
            var pb = new PictureBox
            {
                Location = new Point(pBLocation_X, pBLocation_Y),
                Size = new Size(pBWidth, pBHeight),
                BackColor = ColorTranslator.FromHtml("#e7e7e7")
        };

            if (image != null)
                ImageHandler.FillPictureBox(pb, image);

            return pb;
        }

        /// <summary>
        /// Получение текстовых значений из TextBox'ов
        /// </summary>
        /// <returns></returns>
        public string[] GetTextBoxValues()
        {
            var arr = new string[TextBoxes.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = TextBoxes[i].Text;
            }

            return arr;
        }

        protected override void Dispose(bool disposing)
        {
            if (image!=null)
                image.Dispose();

           base.Dispose(disposing);
        }
    }
}
