namespace Learca
{
    partial class Form_LookAtDeck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Cards = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeftSideValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LeftSideImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnRighSideValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RightSideImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxDeckName = new System.Windows.Forms.TextBox();
            this.textBoxStartingPoint = new System.Windows.Forms.TextBox();
            this.label_Loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cards)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Cards
            // 
            this.dataGridView_Cards.AllowUserToAddRows = false;
            this.dataGridView_Cards.AllowUserToDeleteRows = false;
            this.dataGridView_Cards.AllowUserToResizeColumns = false;
            this.dataGridView_Cards.AllowUserToResizeRows = false;
            this.dataGridView_Cards.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Cards.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Cards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Cards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnLeftSideValues,
            this.Column_LeftSideImage,
            this.ColumnRighSideValues,
            this.Column_RightSideImage});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Cards.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Cards.Location = new System.Drawing.Point(0, 24);
            this.dataGridView_Cards.Name = "dataGridView_Cards";
            this.dataGridView_Cards.ReadOnly = true;
            this.dataGridView_Cards.RowHeadersVisible = false;
            this.dataGridView_Cards.RowTemplate.Height = 50;
            this.dataGridView_Cards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cards.Size = new System.Drawing.Size(1149, 506);
            this.dataGridView_Cards.TabIndex = 3;
            this.dataGridView_Cards.TabStop = false;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.Frozen = true;
            this.ColumnNumber.HeaderText = "№";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 49;
            // 
            // ColumnLeftSideValues
            // 
            this.ColumnLeftSideValues.Frozen = true;
            this.ColumnLeftSideValues.HeaderText = "Left Side Values";
            this.ColumnLeftSideValues.Name = "ColumnLeftSideValues";
            this.ColumnLeftSideValues.ReadOnly = true;
            this.ColumnLeftSideValues.Width = 400;
            // 
            // Column_LeftSideImage
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "System.Drawing.Bitmap";
            this.Column_LeftSideImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_LeftSideImage.Frozen = true;
            this.Column_LeftSideImage.HeaderText = "Left Side Image";
            this.Column_LeftSideImage.Name = "Column_LeftSideImage";
            this.Column_LeftSideImage.ReadOnly = true;
            this.Column_LeftSideImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_LeftSideImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_LeftSideImage.Width = 150;
            // 
            // ColumnRighSideValues
            // 
            this.ColumnRighSideValues.Frozen = true;
            this.ColumnRighSideValues.HeaderText = "Right Side Values";
            this.ColumnRighSideValues.Name = "ColumnRighSideValues";
            this.ColumnRighSideValues.ReadOnly = true;
            this.ColumnRighSideValues.Width = 400;
            // 
            // Column_RightSideImage
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "System.Drawing.Bitmap";
            this.Column_RightSideImage.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_RightSideImage.Frozen = true;
            this.Column_RightSideImage.HeaderText = "Right Side Image";
            this.Column_RightSideImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column_RightSideImage.Name = "Column_RightSideImage";
            this.Column_RightSideImage.ReadOnly = true;
            this.Column_RightSideImage.Width = 150;
            // 
            // textBoxDeckName
            // 
            this.textBoxDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDeckName.Location = new System.Drawing.Point(0, 0);
            this.textBoxDeckName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDeckName.Name = "textBoxDeckName";
            this.textBoxDeckName.ReadOnly = true;
            this.textBoxDeckName.Size = new System.Drawing.Size(926, 26);
            this.textBoxDeckName.TabIndex = 1;
            this.textBoxDeckName.TabStop = false;
            this.textBoxDeckName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStartingPoint
            // 
            this.textBoxStartingPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartingPoint.Location = new System.Drawing.Point(925, 0);
            this.textBoxStartingPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartingPoint.Name = "textBoxStartingPoint";
            this.textBoxStartingPoint.ReadOnly = true;
            this.textBoxStartingPoint.Size = new System.Drawing.Size(224, 26);
            this.textBoxStartingPoint.TabIndex = 2;
            this.textBoxStartingPoint.TabStop = false;
            this.textBoxStartingPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Loading
            // 
            this.label_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Loading.AutoSize = true;
            this.label_Loading.BackColor = System.Drawing.Color.Transparent;
            this.label_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Loading.Location = new System.Drawing.Point(29, 72);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(92, 17);
            this.label_Loading.TabIndex = 36;
            this.label_Loading.Text = "LOADING...";
            // 
            // Form_LookAtDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 530);
            this.Controls.Add(this.label_Loading);
            this.Controls.Add(this.textBoxStartingPoint);
            this.Controls.Add(this.textBoxDeckName);
            this.Controls.Add(this.dataGridView_Cards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_LookAtDeck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARCA. Deck";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Cards;
        private System.Windows.Forms.TextBox textBoxDeckName;
        private System.Windows.Forms.TextBox textBoxStartingPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLeftSideValues;
        private System.Windows.Forms.DataGridViewImageColumn Column_LeftSideImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRighSideValues;
        private System.Windows.Forms.DataGridViewImageColumn Column_RightSideImage;
        private System.Windows.Forms.Label label_Loading;
    }
}