namespace AppSystem.Forms
{
    partial class FrmCityList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButNew = new System.Windows.Forms.Button();
            this.ButFind = new System.Windows.Forms.Button();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.ButEnd = new System.Windows.Forms.Button();
            this.DataGridViewCity = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCity)).BeginInit();
            this.SuspendLayout();
            // 
            // ButNew
            // 
            this.ButNew.Location = new System.Drawing.Point(13, 230);
            this.ButNew.Name = "ButNew";
            this.ButNew.Size = new System.Drawing.Size(75, 23);
            this.ButNew.TabIndex = 9;
            this.ButNew.Text = "&Novo";
            this.ButNew.UseVisualStyleBackColor = true;
            this.ButNew.Click += new System.EventHandler(this.ButNew_Click);
            // 
            // ButFind
            // 
            this.ButFind.Location = new System.Drawing.Point(448, 13);
            this.ButFind.Name = "ButFind";
            this.ButFind.Size = new System.Drawing.Size(30, 23);
            this.ButFind.TabIndex = 8;
            this.ButFind.Text = "...";
            this.ButFind.UseVisualStyleBackColor = true;
            this.ButFind.Click += new System.EventHandler(this.ButFind_Click);
            // 
            // TxtFind
            // 
            this.TxtFind.Location = new System.Drawing.Point(13, 14);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(429, 20);
            this.TxtFind.TabIndex = 7;
            // 
            // ButEnd
            // 
            this.ButEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButEnd.Location = new System.Drawing.Point(403, 230);
            this.ButEnd.Name = "ButEnd";
            this.ButEnd.Size = new System.Drawing.Size(75, 23);
            this.ButEnd.TabIndex = 6;
            this.ButEnd.Text = "Sai&r";
            this.ButEnd.UseVisualStyleBackColor = true;
            this.ButEnd.Click += new System.EventHandler(this.ButEnd_Click);
            // 
            // DataGridViewCity
            // 
            this.DataGridViewCity.AllowUserToAddRows = false;
            this.DataGridViewCity.AllowUserToDeleteRows = false;
            this.DataGridViewCity.AllowUserToResizeColumns = false;
            this.DataGridViewCity.AllowUserToResizeRows = false;
            this.DataGridViewCity.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cidade,
            this.Uf});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCity.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewCity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewCity.Location = new System.Drawing.Point(12, 41);
            this.DataGridViewCity.MultiSelect = false;
            this.DataGridViewCity.Name = "DataGridViewCity";
            this.DataGridViewCity.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCity.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewCity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewCity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCity.ShowCellErrors = false;
            this.DataGridViewCity.ShowCellToolTips = false;
            this.DataGridViewCity.ShowEditingIcon = false;
            this.DataGridViewCity.Size = new System.Drawing.Size(466, 180);
            this.DataGridViewCity.TabIndex = 5;
            this.DataGridViewCity.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCity_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Cidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 305;
            // 
            // Uf
            // 
            this.Uf.DataPropertyName = "Uf";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Uf.DefaultCellStyle = dataGridViewCellStyle3;
            this.Uf.HeaderText = "Uf";
            this.Uf.Name = "Uf";
            this.Uf.ReadOnly = true;
            this.Uf.Width = 50;
            // 
            // FrmCityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButEnd;
            this.ClientSize = new System.Drawing.Size(493, 265);
            this.Controls.Add(this.ButNew);
            this.Controls.Add(this.ButFind);
            this.Controls.Add(this.TxtFind);
            this.Controls.Add(this.ButEnd);
            this.Controls.Add(this.DataGridViewCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCityList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Cidades";
            this.Load += new System.EventHandler(this.FrmCityList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButNew;
        private System.Windows.Forms.Button ButFind;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.Button ButEnd;
        private System.Windows.Forms.DataGridView DataGridViewCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
    }
}