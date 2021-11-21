namespace Learca
{
    partial class Form_Learning
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
            this.statusStrip_Statistic = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_TotalCards = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_PassedCards = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_RemainingCards = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_СardsForChosenDeckCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar_Statistic = new System.Windows.Forms.ProgressBar();
            this.panelRightSideCard = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLeftSideCard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.testPanel = new System.Windows.Forms.Panel();
            this.statusStrip_Statistic.SuspendLayout();
            this.panelRightSideCard.SuspendLayout();
            this.panelLeftSideCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.testPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Statistic
            // 
            this.statusStrip_Statistic.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip_Statistic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusStrip_Statistic.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Statistic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_TotalCards,
            this.toolStripStatusLabel_PassedCards,
            this.toolStripStatusLabel_RemainingCards,
            this.toolStripStatusLabel_СardsForChosenDeckCount});
            this.statusStrip_Statistic.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip_Statistic.Location = new System.Drawing.Point(0, 691);
            this.statusStrip_Statistic.Name = "statusStrip_Statistic";
            this.statusStrip_Statistic.Size = new System.Drawing.Size(1347, 30);
            this.statusStrip_Statistic.TabIndex = 44;
            this.statusStrip_Statistic.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_TotalCards
            // 
            this.toolStripStatusLabel_TotalCards.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel_TotalCards.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_TotalCards.Margin = new System.Windows.Forms.Padding(0, 3, 10, 7);
            this.toolStripStatusLabel_TotalCards.Name = "toolStripStatusLabel_TotalCards";
            this.toolStripStatusLabel_TotalCards.Size = new System.Drawing.Size(96, 20);
            this.toolStripStatusLabel_TotalCards.Text = "Total cards: 0";
            // 
            // toolStripStatusLabel_PassedCards
            // 
            this.toolStripStatusLabel_PassedCards.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel_PassedCards.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_PassedCards.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.toolStripStatusLabel_PassedCards.Name = "toolStripStatusLabel_PassedCards";
            this.toolStripStatusLabel_PassedCards.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatusLabel_PassedCards.Text = "Passed cards: 0";
            // 
            // toolStripStatusLabel_RemainingCards
            // 
            this.toolStripStatusLabel_RemainingCards.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel_RemainingCards.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_RemainingCards.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.toolStripStatusLabel_RemainingCards.Name = "toolStripStatusLabel_RemainingCards";
            this.toolStripStatusLabel_RemainingCards.Size = new System.Drawing.Size(134, 20);
            this.toolStripStatusLabel_RemainingCards.Text = "Remaining cards: 0";
            // 
            // toolStripStatusLabel_СardsForChosenDeckCount
            // 
            this.toolStripStatusLabel_СardsForChosenDeckCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabel_СardsForChosenDeckCount.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel_СardsForChosenDeckCount.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.toolStripStatusLabel_СardsForChosenDeckCount.Name = "toolStripStatusLabel_СardsForChosenDeckCount";
            this.toolStripStatusLabel_СardsForChosenDeckCount.Size = new System.Drawing.Size(191, 20);
            this.toolStripStatusLabel_СardsForChosenDeckCount.Text = "Number of Chosen Decks: 0";
            // 
            // progressBar_Statistic
            // 
            this.progressBar_Statistic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_Statistic.Location = new System.Drawing.Point(0, 718);
            this.progressBar_Statistic.Name = "progressBar_Statistic";
            this.progressBar_Statistic.Size = new System.Drawing.Size(1348, 3);
            this.progressBar_Statistic.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Statistic.TabIndex = 7;
            // 
            // panelRightSideCard
            // 
            this.panelRightSideCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRightSideCard.BackColor = System.Drawing.Color.Transparent;
            this.panelRightSideCard.BackgroundImage = global::Learca.Properties.Resources.Card;
            this.panelRightSideCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRightSideCard.Controls.Add(this.panel3);
            this.panelRightSideCard.Location = new System.Drawing.Point(665, 3);
            this.panelRightSideCard.Name = "panelRightSideCard";
            this.panelRightSideCard.Size = new System.Drawing.Size(655, 590);
            this.panelRightSideCard.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(36, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 500);
            this.panel3.TabIndex = 21;
            // 
            // panelLeftSideCard
            // 
            this.panelLeftSideCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeftSideCard.BackColor = System.Drawing.Color.Transparent;
            this.panelLeftSideCard.BackgroundImage = global::Learca.Properties.Resources.Card;
            this.panelLeftSideCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeftSideCard.Controls.Add(this.label1);
            this.panelLeftSideCard.Controls.Add(this.textBox1);
            this.panelLeftSideCard.Controls.Add(this.pictureBox1);
            this.panelLeftSideCard.Location = new System.Drawing.Point(3, 3);
            this.panelLeftSideCard.Name = "panelLeftSideCard";
            this.panelLeftSideCard.Size = new System.Drawing.Size(655, 590);
            this.panelLeftSideCard.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "SHOW PICTURE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 206);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(600, 329);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(36, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 165);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(580, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "BUTTON 2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(414, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "BUTTON 1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(746, 599);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "BUTTON 3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 599);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 40);
            this.button5.TabIndex = 46;
            this.button5.Text = "HINT";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1160, 599);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 40);
            this.button4.TabIndex = 47;
            this.button4.Text = "A";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // testPanel
            // 
            this.testPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testPanel.BackColor = System.Drawing.Color.Transparent;
            this.testPanel.Controls.Add(this.button4);
            this.testPanel.Controls.Add(this.button5);
            this.testPanel.Controls.Add(this.button3);
            this.testPanel.Controls.Add(this.button1);
            this.testPanel.Controls.Add(this.button2);
            this.testPanel.Controls.Add(this.panelLeftSideCard);
            this.testPanel.Controls.Add(this.panelRightSideCard);
            this.testPanel.Location = new System.Drawing.Point(12, 43);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(1323, 648);
            this.testPanel.TabIndex = 0;
            this.testPanel.Visible = false;
            // 
            // Form_Learning
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 721);
            this.Controls.Add(this.progressBar_Statistic);
            this.Controls.Add(this.statusStrip_Statistic);
            this.Controls.Add(this.testPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Learning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning";
            this.statusStrip_Statistic.ResumeLayout(false);
            this.statusStrip_Statistic.PerformLayout();
            this.panelRightSideCard.ResumeLayout(false);
            this.panelLeftSideCard.ResumeLayout(false);
            this.panelLeftSideCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.testPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip_Statistic;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_TotalCards;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_СardsForChosenDeckCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_PassedCards;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RemainingCards;
        private System.Windows.Forms.ProgressBar progressBar_Statistic;
        private System.Windows.Forms.Panel panelRightSideCard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLeftSideCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Panel testPanel;
        public System.Windows.Forms.Button button1;
    }
}