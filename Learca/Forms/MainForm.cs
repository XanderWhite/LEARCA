using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Learca
{
    /// <summary>
    /// Главная форма для приложения. Mdi-контейнер для всех форм
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly FormColorSettings formColorSettings;
        
        /// <summary>
        /// Стек свернутых форм, для последующего возврата к ним
        /// </summary>
        private readonly Stack<Form> lastForms;
        private Form current;
        
        /// <summary>
        /// Форма для возврата, минуя(закрыв) все свернутые формы в lastForms 
        /// </summary>
        public Form Checkpoint { private get; set; }

       /// <summary>
       /// Конвертация числа относительно текущей ширины клиентской области
       /// </summary>
       /// <param name="width"></param>
       /// <returns></returns>
        public int ConvertWidth(int width)
        {
            return width * ClientSize.Width / 1347;
        }

        /// <summary>
        ///  Конвертация числа относительно текущей высоты клиентской области
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int ConvertHeight(int height)
        {
            return height * ClientSize.Height / 721;
        }

        public MainForm()
        {
            InitializeComponent();

            lastForms = new Stack<Form>();
            formColorSettings = new FormColorSettings(this);

            Load += MainForm_Load;

            OpenHomeForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormClosing += MainForm_FormClosing;
            backColor_ToolStripMenuItem.Click += BackColor_ToolStripMenuItem_Click;
            foreColor_ToolStripMenuItem.Click += ForeColor_ToolStripMenuItem_Click;
            backgroundColor_ToolStripMenuItem.Click += BackgroundColor_ToolStripMenuItem_Click;
            backgroundImage_ToolStripMenuItem.Click += BackgroundImage_ToolStripMenuItem_Click;
            defaultColors_ToolStripMenuItem.Click += DefaultColors_ToolStripMenuItem_Click;
            home_ToolStripMenuItem.Click += Home_ToolStripMenuItem_Click;
            back_ToolStripMenuItem.Click += Back_ToolStripMenuItem_Click;

            toolStripMenuItem_EndSession.Visible = false;
            toolStripMenuItem_ShowStatistic.Visible = false;

            DoubleBuffered = true;
        }

        /// <summary>
        /// Открывает переданную форму 
        /// </summary>
        /// <param name="form"></param>
        public void OpenNextForm(Form form)
        {
            current = form;

            back_ToolStripMenuItem.Visible = true;
            home_ToolStripMenuItem.Visible = true;

            RefreshColorSettings();

            current.Show();
        }

        /// <summary>
        /// Открывает форму HomeForm, закрывая все открытые формы
        /// </summary>
        private void OpenHomeForm()
        {
            if (current != null)
            {
                current.Close();

                if (!current.IsDisposed)
                    return;
            }

            back_ToolStripMenuItem.Visible = false;
            home_ToolStripMenuItem.Visible = false;

            current = new Form_Home(this);
            RefreshColorSettings();

            current.Show();

            while (lastForms.Count > 0)
            {
                lastForms.Pop().Close();
            }
        }

        /// <summary>
        /// Отображает предыдущую форму, закрыв текущую.
        /// </summary>
        public void OpenLastForm()
        {
            if (current != null)
            {
                current.Close();

                if (!current.IsDisposed)
                    return;
            }

            if (lastForms.Count == 0)
                OpenHomeForm();

            else
                OpenNextForm(lastForms.Pop());
        }

        /// <summary>
        /// Добавляет форму в список предыдущих форм, и скрывает ее. Для последующего возврата к ней
        /// </summary>
        /// <param name="form"></param>
        public void AddToLastForms(Form form)
        {
            if (form == null)
                throw new ArgumentNullException("Form form не может быть null");

            lastForms.Push(form);
            form.Hide();
        }

        /// <summary>
        /// Загрузка формы сохраненной в Checkpoint. Если форма не закрыта, но не найдена, открывается HomeForm
        /// </summary>
        public void LoadCheckpoint()
        {
            if (Checkpoint == null || Checkpoint.IsDisposed)
                throw new InvalidOperationException("checkpoint не может быть null или IsDisposed равным true");

            while (lastForms.Count > 0)
            {
                if (lastForms.Peek() == Checkpoint)
                {
                    OpenLastForm();
                    return;
                }
                else
                    lastForms.Pop();
            }

            Checkpoint.Dispose();
            Checkpoint = null;

            OpenHomeForm();
        }

        private void Back_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLastForm();
        }

        private void Home_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHomeForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Leave Learca?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        #region ColorSettings

        private void RefreshColorSettings()
        {
            formColorSettings.Refresh(current);
        }

        private void DefaultColors_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formColorSettings.SetDefault(current);
        }

        private void BackgroundImage_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Multiselect = false;
            fd.Filter = "Image files (*.jpg, *.jpeg) | *.jpg; *.jpeg; ";

            if (fd.ShowDialog() == DialogResult.OK)
                formColorSettings.SetBackgroundImage(fd.FileName, current);
        }

        private void BackgroundColor_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                formColorSettings.SetBackgroundColor(cd.Color, current);
        }

        private void ForeColor_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                formColorSettings.SetForeColor(cd.Color, current);
        }

        private void BackColor_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                formColorSettings.SetBackColor(cd.Color, current);
        }

        #endregion
    }
}
