namespace Learca
{
    partial class AbstractForm_Cards
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
            this.btnToDecks = new System.Windows.Forms.Button();
            this.btnDeleteCard = new System.Windows.Forms.Button();
            this.btnLookAtDeck = new System.Windows.Forms.Button();
            this.btnOpenCard = new System.Windows.Forms.Button();
            this.btnMoveOut = new System.Windows.Forms.Button();
            this.tBFilter = new System.Windows.Forms.TextBox();
            this.dataGridView_Cards = new System.Windows.Forms.DataGridView();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeftSideValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LeftSideImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnRighSideValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_RightSideImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelMenu = new Learca.DoubleBufferedPanel();
            this.btnOpenDeck = new System.Windows.Forms.Button();
            this.label_Loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cards)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToDecks
            // 
            this.btnToDecks.BackColor = System.Drawing.Color.Transparent;
            this.btnToDecks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToDecks.FlatAppearance.BorderSize = 0;
            this.btnToDecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToDecks.ForeColor = System.Drawing.Color.White;
            this.btnToDecks.Location = new System.Drawing.Point(3, 233);
            this.btnToDecks.Name = "btnToDecks";
            this.btnToDecks.Size = new System.Drawing.Size(160, 40);
            this.btnToDecks.TabIndex = 6;
            this.btnToDecks.Text = "DECKS";
            this.btnToDecks.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.FlatAppearance.BorderSize = 0;
            this.btnDeleteCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCard.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCard.Location = new System.Drawing.Point(3, 95);
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteCard.TabIndex = 3;
            this.btnDeleteCard.Text = "DELETE";
            this.btnDeleteCard.UseVisualStyleBackColor = true;
            // 
            // btnLookAtDeck
            // 
            this.btnLookAtDeck.BackColor = System.Drawing.Color.Transparent;
            this.btnLookAtDeck.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLookAtDeck.FlatAppearance.BorderSize = 0;
            this.btnLookAtDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookAtDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLookAtDeck.ForeColor = System.Drawing.Color.White;
            this.btnLookAtDeck.Location = new System.Drawing.Point(3, 141);
            this.btnLookAtDeck.Name = "btnLookAtDeck";
            this.btnLookAtDeck.Size = new System.Drawing.Size(160, 40);
            this.btnLookAtDeck.TabIndex = 4;
            this.btnLookAtDeck.Text = "LOOK AT DECK";
            this.btnLookAtDeck.UseVisualStyleBackColor = false;
            // 
            // btnOpenCard
            // 
            this.btnOpenCard.FlatAppearance.BorderSize = 0;
            this.btnOpenCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenCard.ForeColor = System.Drawing.Color.White;
            this.btnOpenCard.Location = new System.Drawing.Point(3, 3);
            this.btnOpenCard.Name = "btnOpenCard";
            this.btnOpenCard.Size = new System.Drawing.Size(160, 40);
            this.btnOpenCard.TabIndex = 1;
            this.btnOpenCard.Text = "OPEN";
            this.btnOpenCard.UseVisualStyleBackColor = true;
            // 
            // btnMoveOut
            // 
            this.btnMoveOut.FlatAppearance.BorderSize = 0;
            this.btnMoveOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMoveOut.ForeColor = System.Drawing.Color.White;
            this.btnMoveOut.Location = new System.Drawing.Point(3, 49);
            this.btnMoveOut.Name = "btnMoveOut";
            this.btnMoveOut.Size = new System.Drawing.Size(160, 40);
            this.btnMoveOut.TabIndex = 2;
            this.btnMoveOut.Text = "MOVE OUT";
            this.btnMoveOut.UseVisualStyleBackColor = true;
            // 
            // tBFilter
            // 
            this.tBFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tBFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBFilter.Location = new System.Drawing.Point(185, 40);
            this.tBFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tBFilter.Name = "tBFilter";
            this.tBFilter.Size = new System.Drawing.Size(1150, 26);
            this.tBFilter.TabIndex = 7;
            this.tBFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_Cards
            // 
            this.dataGridView_Cards.AllowUserToAddRows = false;
            this.dataGridView_Cards.AllowUserToDeleteRows = false;
            this.dataGridView_Cards.AllowUserToResizeColumns = false;
            this.dataGridView_Cards.AllowUserToResizeRows = false;
            this.dataGridView_Cards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView_Cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Number,
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
            this.dataGridView_Cards.Location = new System.Drawing.Point(185, 73);
            this.dataGridView_Cards.Name = "dataGridView_Cards";
            this.dataGridView_Cards.ReadOnly = true;
            this.dataGridView_Cards.RowHeadersVisible = false;
            this.dataGridView_Cards.RowHeadersWidth = 51;
            this.dataGridView_Cards.RowTemplate.Height = 50;
            this.dataGridView_Cards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cards.Size = new System.Drawing.Size(1150, 636);
            this.dataGridView_Cards.TabIndex = 8;
            // 
            // Column_Number
            // 
            this.Column_Number.Frozen = true;
            this.Column_Number.HeaderText = "№";
            this.Column_Number.MinimumWidth = 6;
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.ReadOnly = true;
            this.Column_Number.Width = 49;
            // 
            // ColumnLeftSideValues
            // 
            this.ColumnLeftSideValues.Frozen = true;
            this.ColumnLeftSideValues.HeaderText = "Left Side Values";
            this.ColumnLeftSideValues.MinimumWidth = 6;
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
            this.Column_LeftSideImage.MinimumWidth = 6;
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
            this.ColumnRighSideValues.MinimumWidth = 6;
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
            this.Column_RightSideImage.MinimumWidth = 6;
            this.Column_RightSideImage.Name = "Column_RightSideImage";
            this.Column_RightSideImage.ReadOnly = true;
            this.Column_RightSideImage.Width = 150;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnOpenDeck);
            this.panelMenu.Controls.Add(this.btnMoveOut);
            this.panelMenu.Controls.Add(this.btnToDecks);
            this.panelMenu.Controls.Add(this.btnDeleteCard);
            this.panelMenu.Controls.Add(this.btnLookAtDeck);
            this.panelMenu.Controls.Add(this.btnOpenCard);
            this.panelMenu.Location = new System.Drawing.Point(12, 64);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(166, 473);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOpenDeck
            // 
            this.btnOpenDeck.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenDeck.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOpenDeck.FlatAppearance.BorderSize = 0;
            this.btnOpenDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenDeck.ForeColor = System.Drawing.Color.White;
            this.btnOpenDeck.Location = new System.Drawing.Point(3, 187);
            this.btnOpenDeck.Name = "btnOpenDeck";
            this.btnOpenDeck.Size = new System.Drawing.Size(160, 40);
            this.btnOpenDeck.TabIndex = 5;
            this.btnOpenDeck.Text = "OPEN DECK";
            this.btnOpenDeck.UseVisualStyleBackColor = false;
            // 
            // label_Loading
            // 
            this.label_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Loading.AutoSize = true;
            this.label_Loading.BackColor = System.Drawing.Color.Transparent;
            this.label_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Loading.Location = new System.Drawing.Point(219, 122);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(92, 17);
            this.label_Loading.TabIndex = 9;
            this.label_Loading.Text = "LOADING...";
            // 
            // AbstractForm_Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 721);
            this.Controls.Add(this.label_Loading);
            this.Controls.Add(this.dataGridView_Cards);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.tBFilter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AbstractForm_Cards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARCA. Cards";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cards)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBFilter;
        protected internal System.Windows.Forms.Button btnToDecks;
        protected internal System.Windows.Forms.Button btnDeleteCard;
        protected internal System.Windows.Forms.Button btnLookAtDeck;
        protected internal System.Windows.Forms.Button btnOpenCard;
        protected internal System.Windows.Forms.Button btnMoveOut;
        protected internal System.Windows.Forms.DataGridView dataGridView_Cards;
        protected internal System.Windows.Forms.Button btnOpenDeck;
        private DoubleBufferedPanel panelMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLeftSideValues;
        private System.Windows.Forms.DataGridViewImageColumn Column_LeftSideImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRighSideValues;
        private System.Windows.Forms.DataGridViewImageColumn Column_RightSideImage;
        private System.Windows.Forms.Label label_Loading;
    }
}