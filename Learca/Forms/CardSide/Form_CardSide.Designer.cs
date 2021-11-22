namespace Learca
{
    partial class Form_CardSide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CardSide));
            this.btnToRightSide = new System.Windows.Forms.Button();
            this.btnToLeftSide = new System.Windows.Forms.Button();
            this.panel_Menu = new Learca.DoubleBufferedPanel();
            this.checkBox_MixValues = new System.Windows.Forms.CheckBox();
            this.btnAddEmptyValue = new System.Windows.Forms.Button();
            this.btnClearEmptyValues = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel_CardSide = new Learca.DoubleBufferedPanel();
            this.label_AddPicture = new System.Windows.Forms.Label();
            this.btnDeletePicture = new System.Windows.Forms.Button();
            this.panel_TextBoxes = new Learca.DoubleBufferedPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel_Menu.SuspendLayout();
            this.panel_CardSide.SuspendLayout();
            this.panel_TextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToRightSide
            // 
            this.btnToRightSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToRightSide.BackColor = System.Drawing.Color.Transparent;
            this.btnToRightSide.FlatAppearance.BorderSize = 0;
            this.btnToRightSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToRightSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToRightSide.ForeColor = System.Drawing.Color.White;
            this.btnToRightSide.Location = new System.Drawing.Point(1021, 651);
            this.btnToRightSide.Name = "btnToRightSide";
            this.btnToRightSide.Size = new System.Drawing.Size(160, 40);
            this.btnToRightSide.TabIndex = 41;
            this.btnToRightSide.Text = "RIGHT SIDE >";
            this.btnToRightSide.UseVisualStyleBackColor = false;
            // 
            // btnToLeftSide
            // 
            this.btnToLeftSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToLeftSide.BackColor = System.Drawing.Color.Transparent;
            this.btnToLeftSide.FlatAppearance.BorderSize = 0;
            this.btnToLeftSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLeftSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToLeftSide.ForeColor = System.Drawing.Color.White;
            this.btnToLeftSide.Location = new System.Drawing.Point(179, 651);
            this.btnToLeftSide.Name = "btnToLeftSide";
            this.btnToLeftSide.Size = new System.Drawing.Size(160, 40);
            this.btnToLeftSide.TabIndex = 42;
            this.btnToLeftSide.Text = "< LEFT SIDE";
            this.btnToLeftSide.UseVisualStyleBackColor = false;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu.Controls.Add(this.checkBox_MixValues);
            this.panel_Menu.Controls.Add(this.btnAddEmptyValue);
            this.panel_Menu.Controls.Add(this.btnClearEmptyValues);
            this.panel_Menu.Controls.Add(this.btnSave);
            this.panel_Menu.Location = new System.Drawing.Point(12, 64);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(166, 287);
            this.panel_Menu.TabIndex = 0;
            // 
            // checkBox_MixValues
            // 
            this.checkBox_MixValues.AutoSize = true;
            this.checkBox_MixValues.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_MixValues.Checked = true;
            this.checkBox_MixValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MixValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_MixValues.ForeColor = System.Drawing.Color.White;
            this.checkBox_MixValues.Location = new System.Drawing.Point(24, 154);
            this.checkBox_MixValues.Name = "checkBox_MixValues";
            this.checkBox_MixValues.Size = new System.Drawing.Size(121, 21);
            this.checkBox_MixValues.TabIndex = 4;
            this.checkBox_MixValues.Text = "MIX VALUES";
            this.checkBox_MixValues.UseVisualStyleBackColor = false;
            this.checkBox_MixValues.CheckedChanged += new System.EventHandler(this.CheckBox_MixValues_CheckedChanged);
            // 
            // btnAddEmptyValue
            // 
            this.btnAddEmptyValue.FlatAppearance.BorderSize = 0;
            this.btnAddEmptyValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmptyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmptyValue.ForeColor = System.Drawing.Color.White;
            this.btnAddEmptyValue.Location = new System.Drawing.Point(3, 3);
            this.btnAddEmptyValue.Name = "btnAddEmptyValue";
            this.btnAddEmptyValue.Size = new System.Drawing.Size(160, 40);
            this.btnAddEmptyValue.TabIndex = 1;
            this.btnAddEmptyValue.Text = "ADD VALUE";
            this.btnAddEmptyValue.UseVisualStyleBackColor = true;
            // 
            // btnClearEmptyValues
            // 
            this.btnClearEmptyValues.BackColor = System.Drawing.Color.Transparent;
            this.btnClearEmptyValues.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClearEmptyValues.FlatAppearance.BorderSize = 0;
            this.btnClearEmptyValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEmptyValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearEmptyValues.ForeColor = System.Drawing.Color.White;
            this.btnClearEmptyValues.Location = new System.Drawing.Point(3, 49);
            this.btnClearEmptyValues.Name = "btnClearEmptyValues";
            this.btnClearEmptyValues.Size = new System.Drawing.Size(160, 40);
            this.btnClearEmptyValues.TabIndex = 2;
            this.btnClearEmptyValues.Text = "CLEAR EMPTY";
            this.btnClearEmptyValues.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel_CardSide
            // 
            this.panel_CardSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_CardSide.BackColor = System.Drawing.Color.Transparent;
            this.panel_CardSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_CardSide.BackgroundImage")));
            this.panel_CardSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_CardSide.Controls.Add(this.label_AddPicture);
            this.panel_CardSide.Controls.Add(this.btnDeletePicture);
            this.panel_CardSide.Controls.Add(this.panel_TextBoxes);
            this.panel_CardSide.Controls.Add(this.pictureBox);
            this.panel_CardSide.Location = new System.Drawing.Point(345, 31);
            this.panel_CardSide.Name = "panel_CardSide";
            this.panel_CardSide.Size = new System.Drawing.Size(670, 678);
            this.panel_CardSide.TabIndex = 5;
            // 
            // label_AddPicture
            // 
            this.label_AddPicture.AutoSize = true;
            this.label_AddPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AddPicture.ForeColor = System.Drawing.Color.Gray;
            this.label_AddPicture.Location = new System.Drawing.Point(273, 136);
            this.label_AddPicture.Name = "label_AddPicture";
            this.label_AddPicture.Size = new System.Drawing.Size(111, 17);
            this.label_AddPicture.TabIndex = 17;
            this.label_AddPicture.Text = "ADD PICTURE";
            this.label_AddPicture.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // btnDeletePicture
            // 
            this.btnDeletePicture.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePicture.BackgroundImage = global::Learca.Properties.Resources.RedCross;
            this.btnDeletePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePicture.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletePicture.FlatAppearance.BorderSize = 0;
            this.btnDeletePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePicture.ForeColor = System.Drawing.Color.White;
            this.btnDeletePicture.Location = new System.Drawing.Point(628, 48);
            this.btnDeletePicture.Name = "btnDeletePicture";
            this.btnDeletePicture.Size = new System.Drawing.Size(20, 20);
            this.btnDeletePicture.TabIndex = 6;
            this.btnDeletePicture.UseVisualStyleBackColor = false;
            this.btnDeletePicture.Visible = false;
            this.btnDeletePicture.Click += new System.EventHandler(this.BtnDeletePicture_Click);
            // 
            // panel_TextBoxes
            // 
            this.panel_TextBoxes.Controls.Add(this.textBox2);
            this.panel_TextBoxes.Location = new System.Drawing.Point(41, 252);
            this.panel_TextBoxes.Name = "panel_TextBoxes";
            this.panel_TextBoxes.Size = new System.Drawing.Size(607, 362);
            this.panel_TextBoxes.TabIndex = 7;
            this.panel_TextBoxes.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(572, 354);
            this.textBox2.TabIndex = 8;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(44, 48);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(572, 198);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Form_CardSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 721);
            this.Controls.Add(this.btnToLeftSide);
            this.Controls.Add(this.btnToRightSide);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_CardSide);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_CardSide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARCA. Card Side";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel_CardSide.ResumeLayout(false);
            this.panel_CardSide.PerformLayout();
            this.panel_TextBoxes.ResumeLayout(false);
            this.panel_TextBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_AddPicture;
        private System.Windows.Forms.Button btnDeletePicture;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox checkBox_MixValues;
        private System.Windows.Forms.Button btnAddEmptyValue;
        private System.Windows.Forms.Button btnClearEmptyValues;
        private DoubleBufferedPanel panel_CardSide;
        private DoubleBufferedPanel panel_TextBoxes;
        private DoubleBufferedPanel panel_Menu;
        private System.Windows.Forms.Button btnToRightSide;
        private System.Windows.Forms.Button btnToLeftSide;
        internal System.Windows.Forms.Button btnSave;
    }
}