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
    /// Настройки цвета для форм приложения
    /// </summary>
    public class FormColorSettings
    {
        readonly MainForm mainForm;
        readonly Color defaultBackColor;
        readonly Color defaultBackgroundColor;
        readonly Color defaultForeColor;
        readonly string defaultBackgroundImagePath;
        
        public FormColorSettings(MainForm form)
        {
            mainForm = form ?? throw new ArgumentNullException("MainForm form не может быть null");

            defaultBackColor = Color.Gray;
            defaultForeColor = Color.White;
            defaultBackgroundColor = Color.LightGray;
            defaultBackgroundImagePath = string.Empty;
        }

        /// <summary>
        /// Установить настройки цвета приложения по умолчанию
        /// </summary>
        public void SetDefault(Form form)
        {
            SetBackgroundColor(defaultBackgroundColor, form);
            SetForeColor(defaultForeColor, form);
            SetBackColor(defaultBackColor, form);
        }

        /// <summary>
        /// Установить фоновое изображение для формы
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="form"></param>
        public void SetBackgroundImage(string imagePath, Form form)
        {
            if (form == null)
                return;

            try
            {
                form.BackgroundImage = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Settings.Default.Path_BackgroundImage = imagePath;
            Settings.Default.BackgroundColor = Color.Empty;
            Settings.Default.Save();
        }

        /// <summary>
        /// Установить цвет фона формы
        /// </summary>
        /// <param name="color"></param>
        /// <param name="form"></param>
        public void SetBackgroundColor(Color color, Form form)
        {
            if (color == Color.Empty)
                throw new ArgumentNullException("Color color is Empty");

            if (form == null)
                return;

            form.BackColor = color;
            form.BackgroundImage = null;

            Settings.Default.BackgroundColor = color;
            Settings.Default.Path_BackgroundImage = defaultBackgroundImagePath;
            Settings.Default.Save();
        }

        /// <summary>
        /// Установить цвет шрифта приложения
        /// </summary>
        /// <param name="color"></param>
        /// <param name="form"></param>
        public void SetForeColor(Color color, Form form)
        {
            if (color == Color.Empty)
                throw new ArgumentNullException("Color color is Empty");

            if (mainForm.menuStrip != null)
            {
                foreach (ToolStripItem item in mainForm.menuStrip.Items)
                {
                    item.ForeColor = color;
                }
            }

            if (form != null)
            {
                foreach (Control control in form.Controls)
                {
                    SetForeColor(control, color);
                }
            }

            Settings.Default.ForeColor = color;
            Settings.Default.Save();
        }

        /// <summary>
        /// Установить цвет шрифта для элемента управления 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="color"></param>
        private void SetForeColor(Control control, Color color)
        {
            if (color == Color.Empty)
                throw new ArgumentNullException("Color color is Empty");

            var types = new[] { "Button", "Panel", "GroupBox", "Label", "CheckBox", "StatusStrip", "DoubleBufferedPanel", "LearningPanel" };

            if (!types.Contains(control.GetType().Name)) return;

            control.ForeColor = color;

            if (control is Button)
            {
                (control as Button).FlatAppearance.BorderColor = color;
            }
            else if (control is StatusStrip)
            {
                foreach (ToolStripItem item in ((StatusStrip)control).Items)
                {
                    item.ForeColor = color;
                }
            }
            else if (control is Panel || control is GroupBox)
            {
                foreach (Control ctrl in control.Controls)
                {
                    SetForeColor(ctrl, color);
                }
            }
        }

        /// <summary>
        /// Установить цвет объектов приложения
        /// </summary>
        /// <param name="color"></param>
        /// <param name="form"></param>
        public void SetBackColor(Color color, Form form)
        {
            if (color == Color.Empty)
                throw new ArgumentNullException("Color color is Empty");

            if (mainForm.menuStrip != null)
                mainForm.menuStrip.BackColor = color;

            if (form != null)
            {
                foreach (Control control in form.Controls)
                {
                    SetBackColor(control, color);
                }
            }

            Settings.Default.BackColor = color;
            Settings.Default.Save();
        }

        /// <summary>
        /// Установить цвет для элемента управления  
        /// </summary>
        /// <param name="control"></param>
        /// <param name="color"></param>
        private void SetBackColor(Control control, Color color)
        {
            if (color == Color.Empty)
                throw new ArgumentNullException("Color color is Empty");

            var types = new[] { "Button", "Panel", "DoubleBufferedPanel", "LearningPanel"};

            if (!types.Contains(control.GetType().Name))
                return;

            if (control is Button)
            {
                ((Button)control).FlatAppearance.MouseOverBackColor = color;
            }
            else if (control is Panel)
            {
                foreach (Control panelControl in control.Controls)
                {
                    SetBackColor(panelControl, color);
                }
            }
        }

        /// <summary>
        /// Обновить настройки цвета приложения
        /// </summary>
        /// <param name="form"></param>
        public void Refresh(Form form)
        {
            try
            {
                SetBackgroundImage(Settings.Default.Path_BackgroundImage, form);
            }
            catch
            {
                try
                {
                    SetBackgroundColor(Settings.Default.BackgroundColor, form);
                }
                catch
                {
                    SetBackgroundColor(defaultBackgroundColor, form);
                }
            }
            try
            {
                SetForeColor(Settings.Default.ForeColor, form);
            }
            catch
            {
                SetForeColor(defaultForeColor,form);
            }
            try
            {
                SetBackColor(Settings.Default.BackColor, form);
            }
            catch
            {
                SetBackColor(defaultBackColor, form);
            }
        }

    }
}
