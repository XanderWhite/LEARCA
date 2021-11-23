using Learca.Properties;
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
    /// Небольшая панель для описания стороны карточки
    /// </summary>
    class MiniPanel_CardSide : Panel
    {
        MainForm mainForm;

        private const int CARD_WIDTH = 437;
        private const int CARD_HEIGHT = 388;

        public CardSide Side { get; private set; }

        /// <summary>
        /// Обработчик двойного нажатия на Панель и ее компоненты
        /// </summary>
        private readonly EventHandler doubleClickEvent;
        private TextBox TextBox { get; set; }
        private PictureBox PictureBox { get; set; }

        public MiniPanel_CardSide(MainForm mainForm, CardSide side, Point location, Size size, EventHandler doubleClickEvent)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            Side = side ?? throw new ArgumentNullException("CardSide side не может быть null");
            this.doubleClickEvent = doubleClickEvent;            

            Location = location;
            Size = size;
            BackColor = Color.Transparent;
            BackgroundImage = Resources.Card;
            BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
            TabStop = false;
            DoubleClick += doubleClickEvent;
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            InitTextBox();
            InitPictureBox();
        }

        /// <summary>
        /// Очищение стороны Карточки
        /// </summary>
        public void ClearSide()
        {
            Controls.Remove(TextBox);
            Controls.Remove(PictureBox);

            DisposePictureBoxImage();

            Side.Clear();

            if (Side.ParentCard.GetOneFilledSide() == null)
                Side.ParentCard.RemoveCard();
        }

        /// <summary>
        ///  Освобождение ресурсов занимаемых Image в PicturesBox
        /// </summary>
        public void DisposePictureBoxImage()
        {
            if (PictureBox != null)
                PictureBox.Image.Dispose();
        }

        /// <summary>
        /// Инициализация Textbox на панели
        /// </summary>
        private void InitTextBox()
        {
            if (Side.ValueCount == 0)
                return;

            TextBox = new TextBox
            {
                Width = mainForm.ConvertWidth(CARD_WIDTH),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = true,
                TabStop = false,
                BorderStyle = BorderStyle.None,
                Text = Side.GetValuesInColumn()
            };

            if (string.IsNullOrWhiteSpace(Side.ImagePath))
            {
                TextBox.Height = mainForm.ConvertHeight(CARD_HEIGHT);
                TextBox.Location = new Point(mainForm.ConvertWidth(34), mainForm.ConvertHeight( 38));
            }
            else
            {
                TextBox.Height = mainForm.ConvertHeight(219);
                TextBox.Location = new Point(mainForm.ConvertWidth(34), mainForm.ConvertHeight(207));
            }

            TextBox.DoubleClick += doubleClickEvent;

            Controls.Add(TextBox);
        }

        /// <summary>
        ///  Инициализация PictureBox на панели
        /// </summary>
        private void InitPictureBox()
        {
            var image = ImageHandler.GetImage(Side.ImagePath);

            if (image == null) return;

            PictureBox = new PictureBox
            {
                Width = mainForm.ConvertWidth(CARD_WIDTH),
                Location = new Point(mainForm.ConvertWidth(34), mainForm.ConvertHeight(38))
            };

            PictureBox.DoubleClick += doubleClickEvent;

            if (Side.ValueCount == 0)
                PictureBox.Height = mainForm.ConvertHeight(CARD_HEIGHT);
            else
                PictureBox.Height = mainForm.ConvertHeight(165);

            ImageHandler.FillPictureBox(PictureBox, image);

            Controls.Add(PictureBox);
        }
    }
}
