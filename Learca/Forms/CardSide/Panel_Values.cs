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
    /// Панель с textbox'ами отображаемыми на форме Form_CardSide
    /// </summary>
    class Panel_Values : Panel
    {
        private readonly Form_CardSide form;
        private readonly MainForm mainForm;

        /// <summary>
        /// Текстовые значения отображаемые в textbox'ах
        /// </summary>
        List<string> values;

        const int TB_START_POSITION_X = 3;
        const int TB_START_POSITION_Y = 3;
        const int TB_WIDTH = 572;
        const int TB_MAX_HEIGHT = 356;
        const int TB_MARGIN = 6;

        public Panel_Values(MainForm mainForm, Form_CardSide form, List<string> values)
        {
            this.form = form ?? throw new ArgumentNullException("Form_CardSide form не может быть null");
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            this.values = values ?? throw new ArgumentNullException("List<string> values не может быть null");

            DoubleBuffered = true;
            BackColor = ColorTranslator.FromHtml("#e7e7e7");
        }

        /// <summary>
        /// Обновить панель. Перерисовка textbox относительно values
        /// </summary>
        public void RefreshPanel()
        {
            int nextPositionY = mainForm.ConvertHeight(TB_START_POSITION_Y);

            if (values.Count == 0)
                values.Add(string.Empty);

            var controls = new Control[values.Count * 2];

            int tbHeight = (mainForm.ConvertHeight(TB_MAX_HEIGHT) - ((values.Count - 1) * mainForm.ConvertHeight(TB_MARGIN))) / values.Count;

            for (int i = 0; i < values.Count; i++)
            {
                var tb = CreateTBValue(tbHeight, nextPositionY, i);
                var btn = CreateBtnDelete(tb);

                controls[i] = tb;
                controls[i + values.Count] = btn;

                nextPositionY += tbHeight + TB_MARGIN;
            }

            Controls.Clear();
            Controls.AddRange(controls);
        }

        private void SideTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            values[(int)(tb.Tag)] = tb.Text;

            form.RefreshCheckBox_MixValues();
            form.RefreshButtons();
            form.CheckDataForButtonSave();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            values.RemoveAt((int)(btn.Tag));
            RefreshPanel();

            form.RefreshButtons();
            form.RefreshCheckBox_MixValues();
            form.CheckDataForButtonSave();
        }

        /// <summary>
        /// Создание TextBox для Panel_Values
        /// </summary>
        /// <param name="height"></param>
        /// <param name="locationY"></param>
        /// <param name="valueIndex">Индекс для получения значения из values для textBox.Text </param>
        /// <returns></returns>
        public TextBox CreateTBValue(int height, int locationY, int valueIndex)
        {
            if (valueIndex < 0 || valueIndex >= values.Count())
                throw new IndexOutOfRangeException("int index вне диапазона values");

            var tb = new TextBox
            {
                Text = values[valueIndex],
                Width = mainForm.ConvertWidth(TB_WIDTH),
                Height = height,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                BorderStyle = BorderStyle.None,
                Font = new Font("Microsoft Sans Serif", 12),
                Location = new Point(TB_START_POSITION_X, locationY),
                Tag = valueIndex
            };

            tb.TextChanged += SideTextBox_TextChanged;

            return tb;
        }

        /// <summary>
        /// Создание кнопки Delete для Textbox tb
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        private Button CreateBtnDelete(TextBox tb)
        {
            if (tb == null)
                throw new ArgumentNullException("TextBox tb не может быть null");

            var btn = new Button();

            btn.BackgroundImage = Resources.RedCross;
            btn.Width = mainForm.ConvertWidth(20);
            btn.Height = mainForm.ConvertHeight(20);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Location = new Point(tb.Location.X + mainForm.ConvertWidth(TB_WIDTH) + mainForm.ConvertWidth(TB_MARGIN) + 2, tb.Location.Y);

            btn.Click += BtnDelete_Click;

            btn.Tag = tb.Tag;

            return btn;
        }
    }

}
