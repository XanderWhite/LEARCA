namespace Learca
{
    partial class Form_Card
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBHint = new System.Windows.Forms.TextBox();
            this.btnClearLeft = new System.Windows.Forms.Button();
            this.btnClearRight = new System.Windows.Forms.Button();
            this.panel_RightSide = new System.Windows.Forms.Panel();
            this.panel3 = new Learca.DoubleBufferedPanel();
            this.panel_LeftSide = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditRight = new System.Windows.Forms.Button();
            this.btnEditLeft = new System.Windows.Forms.Button();
            this.panel_CardSettings = new Learca.DoubleBufferedPanel();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.checkBox_AskBoth = new System.Windows.Forms.CheckBox();
            this.checkBox_TypeAnswer = new System.Windows.Forms.CheckBox();
            this.panelMenu = new Learca.DoubleBufferedPanel();
            this.btnDeleteCard = new System.Windows.Forms.Button();
            this.btnLookAtDeck = new System.Windows.Forms.Button();
            this.panel_RightSide.SuspendLayout();
            this.panel_LeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_CardSettings.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBHint
            // 
            this.tBHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tBHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBHint.ForeColor = System.Drawing.Color.Gray;
            this.tBHint.Location = new System.Drawing.Point(267, 64);
            this.tBHint.Name = "tBHint";
            this.tBHint.Size = new System.Drawing.Size(1032, 22);
            this.tBHint.TabIndex = 8;
            this.tBHint.Text = "...ADD HINT...";
            this.tBHint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClearLeft
            // 
            this.btnClearLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnClearLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearLeft.FlatAppearance.BorderSize = 0;
            this.btnClearLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearLeft.ForeColor = System.Drawing.Color.White;
            this.btnClearLeft.Location = new System.Drawing.Point(517, 646);
            this.btnClearLeft.Name = "btnClearLeft";
            this.btnClearLeft.Size = new System.Drawing.Size(160, 40);
            this.btnClearLeft.TabIndex = 5;
            this.btnClearLeft.Text = "CLEAR";
            this.btnClearLeft.UseVisualStyleBackColor = false;
            // 
            // btnClearRight
            // 
            this.btnClearRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearRight.BackColor = System.Drawing.Color.Transparent;
            this.btnClearRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearRight.FlatAppearance.BorderSize = 0;
            this.btnClearRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearRight.ForeColor = System.Drawing.Color.White;
            this.btnClearRight.Location = new System.Drawing.Point(1059, 646);
            this.btnClearRight.Name = "btnClearRight";
            this.btnClearRight.Size = new System.Drawing.Size(160, 40);
            this.btnClearRight.TabIndex = 7;
            this.btnClearRight.Text = "CLEAR";
            this.btnClearRight.UseVisualStyleBackColor = false;
            // 
            // panel_RightSide
            // 
            this.panel_RightSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_RightSide.BackColor = System.Drawing.Color.Transparent;
            this.panel_RightSide.BackgroundImage = global::Learca.Properties.Resources.Card;
            this.panel_RightSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_RightSide.Controls.Add(this.panel3);
            this.panel_RightSide.Location = new System.Drawing.Point(804, 158);
            this.panel_RightSide.Name = "panel_RightSide";
            this.panel_RightSide.Size = new System.Drawing.Size(495, 482);
            this.panel_RightSide.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(34, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 388);
            this.panel3.TabIndex = 0;
            // 
            // panel_LeftSide
            // 
            this.panel_LeftSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_LeftSide.BackColor = System.Drawing.Color.Transparent;
            this.panel_LeftSide.BackgroundImage = global::Learca.Properties.Resources.Card;
            this.panel_LeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_LeftSide.Controls.Add(this.textBox1);
            this.panel_LeftSide.Controls.Add(this.pictureBox1);
            this.panel_LeftSide.Location = new System.Drawing.Point(267, 158);
            this.panel_LeftSide.Name = "panel_LeftSide";
            this.panel_LeftSide.Size = new System.Drawing.Size(495, 482);
            this.panel_LeftSide.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(36, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(437, 219);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(36, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 165);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditRight
            // 
            this.btnEditRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditRight.BackColor = System.Drawing.Color.Transparent;
            this.btnEditRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditRight.FlatAppearance.BorderSize = 0;
            this.btnEditRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditRight.ForeColor = System.Drawing.Color.White;
            this.btnEditRight.Location = new System.Drawing.Point(893, 646);
            this.btnEditRight.Name = "btnEditRight";
            this.btnEditRight.Size = new System.Drawing.Size(160, 40);
            this.btnEditRight.TabIndex = 6;
            this.btnEditRight.Text = "EDIT";
            this.btnEditRight.UseVisualStyleBackColor = false;
            // 
            // btnEditLeft
            // 
            this.btnEditLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnEditLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditLeft.FlatAppearance.BorderSize = 0;
            this.btnEditLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditLeft.ForeColor = System.Drawing.Color.White;
            this.btnEditLeft.Location = new System.Drawing.Point(351, 646);
            this.btnEditLeft.Name = "btnEditLeft";
            this.btnEditLeft.Size = new System.Drawing.Size(160, 40);
            this.btnEditLeft.TabIndex = 4;
            this.btnEditLeft.Text = "EDIT";
            this.btnEditLeft.UseVisualStyleBackColor = false;
            // 
            // panel_CardSettings
            // 
            this.panel_CardSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_CardSettings.BackColor = System.Drawing.Color.Transparent;
            this.panel_CardSettings.Controls.Add(this.labelAnswer);
            this.panel_CardSettings.Controls.Add(this.labelQuestion);
            this.panel_CardSettings.Controls.Add(this.checkBox_AskBoth);
            this.panel_CardSettings.Controls.Add(this.checkBox_TypeAnswer);
            this.panel_CardSettings.Location = new System.Drawing.Point(267, 92);
            this.panel_CardSettings.Name = "panel_CardSettings";
            this.panel_CardSettings.Size = new System.Drawing.Size(1032, 60);
            this.panel_CardSettings.TabIndex = 9;
            // 
            // labelAnswer
            // 
            this.labelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.ForeColor = System.Drawing.Color.White;
            this.labelAnswer.Location = new System.Drawing.Point(751, 36);
            this.labelAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(74, 17);
            this.labelAnswer.TabIndex = 29;
            this.labelAnswer.Text = "ANSWER";
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.ForeColor = System.Drawing.Color.White;
            this.labelQuestion.Location = new System.Drawing.Point(198, 36);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(88, 17);
            this.labelQuestion.TabIndex = 29;
            this.labelQuestion.Text = "QUESTION";
            // 
            // checkBox_AskBoth
            // 
            this.checkBox_AskBoth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_AskBoth.AutoSize = true;
            this.checkBox_AskBoth.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AskBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_AskBoth.ForeColor = System.Drawing.Color.White;
            this.checkBox_AskBoth.Location = new System.Drawing.Point(460, 35);
            this.checkBox_AskBoth.Name = "checkBox_AskBoth";
            this.checkBox_AskBoth.Size = new System.Drawing.Size(108, 21);
            this.checkBox_AskBoth.TabIndex = 11;
            this.checkBox_AskBoth.Text = "ASK BOTH";
            this.checkBox_AskBoth.UseVisualStyleBackColor = false;
            // 
            // checkBox_TypeAnswer
            // 
            this.checkBox_TypeAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_TypeAnswer.AutoSize = true;
            this.checkBox_TypeAnswer.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_TypeAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_TypeAnswer.ForeColor = System.Drawing.Color.White;
            this.checkBox_TypeAnswer.Location = new System.Drawing.Point(445, 5);
            this.checkBox_TypeAnswer.Name = "checkBox_TypeAnswer";
            this.checkBox_TypeAnswer.Size = new System.Drawing.Size(141, 21);
            this.checkBox_TypeAnswer.TabIndex = 10;
            this.checkBox_TypeAnswer.Text = "TYPE ANSWER";
            this.checkBox_TypeAnswer.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnDeleteCard);
            this.panelMenu.Controls.Add(this.btnLookAtDeck);
            this.panelMenu.Location = new System.Drawing.Point(12, 64);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(171, 390);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteCard.FlatAppearance.BorderSize = 0;
            this.btnDeleteCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCard.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCard.Location = new System.Drawing.Point(3, 49);
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteCard.TabIndex = 2;
            this.btnDeleteCard.Text = "DELETE CARD";
            this.btnDeleteCard.UseVisualStyleBackColor = false;
            // 
            // btnLookAtDeck
            // 
            this.btnLookAtDeck.BackColor = System.Drawing.Color.Transparent;
            this.btnLookAtDeck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLookAtDeck.FlatAppearance.BorderSize = 0;
            this.btnLookAtDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookAtDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLookAtDeck.ForeColor = System.Drawing.Color.White;
            this.btnLookAtDeck.Location = new System.Drawing.Point(3, 3);
            this.btnLookAtDeck.Name = "btnLookAtDeck";
            this.btnLookAtDeck.Size = new System.Drawing.Size(160, 40);
            this.btnLookAtDeck.TabIndex = 1;
            this.btnLookAtDeck.Text = "LOOK AT DECK";
            this.btnLookAtDeck.UseVisualStyleBackColor = false;
            // 
            // Form_Card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 721);
            this.Controls.Add(this.btnEditLeft);
            this.Controls.Add(this.btnEditRight);
            this.Controls.Add(this.panel_CardSettings);
            this.Controls.Add(this.btnClearLeft);
            this.Controls.Add(this.btnClearRight);
            this.Controls.Add(this.tBHint);
            this.Controls.Add(this.panel_RightSide);
            this.Controls.Add(this.panel_LeftSide);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARCA. Card";
            this.panel_RightSide.ResumeLayout(false);
            this.panel_LeftSide.ResumeLayout(false);
            this.panel_LeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_CardSettings.ResumeLayout(false);
            this.panel_CardSettings.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBHint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLookAtDeck;
        private System.Windows.Forms.Button btnClearLeft;
        private System.Windows.Forms.Button btnClearRight;
        private System.Windows.Forms.CheckBox checkBox_TypeAnswer;
        private System.Windows.Forms.CheckBox checkBox_AskBoth;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button btnDeleteCard;
        private DoubleBufferedPanel panelMenu;
        private DoubleBufferedPanel panel3;
        private System.Windows.Forms.Panel panel_RightSide;
        private System.Windows.Forms.Panel panel_LeftSide;
        private DoubleBufferedPanel panel_CardSettings;
        private System.Windows.Forms.Button btnEditRight;
        private System.Windows.Forms.Button btnEditLeft;
    }
}