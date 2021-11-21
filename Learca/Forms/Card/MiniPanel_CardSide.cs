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
        private const int CARD_WIDTH = 437;
        private const int CARD_HEIGHT = 388;

        public CardSide Side { get; private set; }
        
        /// <summary>
        /// Обработчик двойного нажатия на Панель и ее компоненты
        /// </summary>
        private readonly EventHandler doubleClickEvent;
        private TextBox TextBox { get; set; }
        private PictureBox PictureBox { get; set; }

        public MiniPanel_CardSide(CardSide side, Point location, EventHandler doubleClickEvent)
        {
            Side = side ?? throw new ArgumentNullException("CardSide side не может быть null");
            this.doubleClickEvent = doubleClickEvent;

            Location = location;
            Size = new Size(495, 482);
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
                Width = CARD_WIDTH,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = true,
                TabStop = false,
                BorderStyle = BorderStyle.None,
                Text = Side.GetValuesInColumn()
            };

            if (string.IsNullOrWhiteSpace(Side.ImagePath))
            {
                TextBox.Height = CARD_HEIGHT;
                TextBox.Location = new Point(34, 38);
            }
            else
            {
                TextBox.Height = 219;
                TextBox.Location = new Point(34, 207);
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
                Width = CARD_WIDTH,
                Location = new Point(34, 38)
            };
            
            PictureBox.DoubleClick += doubleClickEvent;

            if (Side.ValueCount == 0)
                PictureBox.Height = CARD_HEIGHT;
            else
                PictureBox.Height = 165;

            ImageHandler.FillPictureBox(PictureBox, image);

            Controls.Add(PictureBox);
        }
    }
}
