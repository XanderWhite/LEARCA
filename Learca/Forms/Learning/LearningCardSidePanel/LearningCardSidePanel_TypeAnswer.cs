using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Панель отображающая сторону карточки находящейся в процессе изучения, на которой требуется напечатать ответ
    /// </summary>
    class LearningCardSidePanel_TypeAnswer : LearningCardSidePanel
    {
        public const int LABEL_LOCATION_X = 281;
        public const int LABEL_LOCATION_Y = 108;

        /// <summary>
        /// Показывать ли картинку в pictureBox при первой загрузке
        /// </summary>
        public readonly bool showPicture;
        public List<string> userAnswerValues;

        /// <summary>
        /// Метка отображающаяся вместо image в pictureBox
        /// </summary>
        Label label_ShowPicture;

        public LearningCardSidePanel_TypeAnswer(CardSide cardSide, bool showPicture, List<string> userAnswerValues) : base(cardSide)
        {
            this.showPicture = showPicture;
            this.userAnswerValues = userAnswerValues;
        }

        public LearningCardSidePanel_TypeAnswer(CardSide cardSide) : this(cardSide, false, new List<string>())
        {

        }

        /// <summary>
        /// Заполнение панели данными из cardSide
        /// </summary>
        /// <param name="textBoxesIsReadOnly">свойство ReadOnly для textbox'ов</param>
        public override void Fill(bool textBoxIsReadOnly)
        {
            if (cardSide.HasImage)
            {
                AddLabel_ShowPicture();
                AddPictureBox();
            }

            if (userAnswerValues.Count == 0)
                CreateTextBoxes(new string[cardSide.ValueCount], textBoxIsReadOnly);
            else
                CreateTextBoxes(userAnswerValues.ToArray(), textBoxIsReadOnly);
        }

        /// <summary>
        /// Добавление PicureBox, если имеется изображение в cardSide
        /// </summary>
        protected override void AddPictureBox()
        {
            base.AddPictureBox();

            if (pictureBox == null)
                return;

            RefreshImage(showPicture);

            pictureBox.DoubleClick += ShowPicture_DoubleClick;

            Controls.Add(pictureBox);
        }

        /// <summary>
        /// Создает и добавляет label_ShowPicture на panel
        /// </summary>
        private void AddLabel_ShowPicture()
        {
            label_ShowPicture = CreateLabel_ShowPicture(!showPicture);

            Controls.Add(label_ShowPicture);

            label_ShowPicture.BringToFront();
        }

        /// <summary>
        /// Создание lable_ShowPicture 
        /// </summary>
        /// <param name="visible"></param>
        /// <returns></returns>
        private Label CreateLabel_ShowPicture(bool visible)
        {
            var lbl = new Label
            {
                AutoSize = true,
                Text = "SHOW PICTURE",
                BackColor = ColorTranslator.FromHtml("#e7e7e7"),
                Location = new Point(LABEL_LOCATION_X, LABEL_LOCATION_Y),
                Visible = visible
            };

            lbl.Font = new Font(lbl.Font, FontStyle.Bold);

            lbl.DoubleClick += ShowPicture_DoubleClick;

            return lbl;
        }

        private void ShowPicture_DoubleClick(object sender, EventArgs e)
        {
            label_ShowPicture.Visible = !label_ShowPicture.Visible;

            RefreshImage(!label_ShowPicture.Visible);
        }

        /// <summary>
        /// Показать изображение или скрыть в зависимости от аргумента
        /// </summary>
        /// <param name="showImage"></param>
        private void RefreshImage(bool showImage)
        {
            pictureBox.Image = (showImage) ? image : null;

            pictureBox.BorderStyle = (pictureBox.Image == null) ? BorderStyle.FixedSingle : BorderStyle.None;
        }
    }
}
