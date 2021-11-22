using System.Drawing;

namespace Learca
{
    partial class Form_Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new Learca.DoubleBufferedPanel();
            this.btnDecks = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnCards = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnDecks);
            this.panelMenu.Controls.Add(this.btnLearn);
            this.panelMenu.Controls.Add(this.btnCards);
            this.panelMenu.Controls.Add(this.btnRepeat);
            this.panelMenu.Location = new System.Drawing.Point(12, 64);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(166, 229);
            this.panelMenu.TabIndex = 20;
            // 
            // btnDecks
            // 
            this.btnDecks.BackColor = System.Drawing.Color.Transparent;
            this.btnDecks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDecks.FlatAppearance.BorderSize = 0;
            this.btnDecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecks.ForeColor = System.Drawing.Color.White;
            this.btnDecks.Location = new System.Drawing.Point(3, 3);
            this.btnDecks.Name = "btnDecks";
            this.btnDecks.Size = new System.Drawing.Size(160, 40);
            this.btnDecks.TabIndex = 1;
            this.btnDecks.Text = "DECKS";
            this.btnDecks.UseVisualStyleBackColor = false;
            // 
            // btnLearn
            // 
            this.btnLearn.FlatAppearance.BorderSize = 0;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLearn.ForeColor = System.Drawing.Color.White;
            this.btnLearn.Location = new System.Drawing.Point(3, 141);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(160, 40);
            this.btnLearn.TabIndex = 0;
            this.btnLearn.Text = "LEARN";
            this.btnLearn.UseVisualStyleBackColor = true;
            // 
            // btnCards
            // 
            this.btnCards.BackColor = System.Drawing.Color.Transparent;
            this.btnCards.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCards.FlatAppearance.BorderSize = 0;
            this.btnCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCards.ForeColor = System.Drawing.Color.White;
            this.btnCards.Location = new System.Drawing.Point(3, 49);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(160, 40);
            this.btnCards.TabIndex = 2;
            this.btnCards.Text = "CARDS";
            this.btnCards.UseVisualStyleBackColor = false;
            // 
            // btnRepeat
            // 
            this.btnRepeat.FlatAppearance.BorderSize = 0;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRepeat.ForeColor = System.Drawing.Color.White;
            this.btnRepeat.Location = new System.Drawing.Point(3, 95);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(160, 40);
            this.btnRepeat.TabIndex = 3;
            this.btnRepeat.Text = "REPEAT";
            this.btnRepeat.UseVisualStyleBackColor = true;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 721);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARCA";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecks;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnLearn;
        private DoubleBufferedPanel panelMenu;
    }
}

