namespace AppSystem.Forms
{
    partial class FrmUfList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewUf = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButEnd = new System.Windows.Forms.Button();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.ButFind = new System.Windows.Forms.Button();
            this.ButNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUf)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewUf
            // 
            this.DataGridViewUf.AllowUserToAddRows = false;
            this.DataGridViewUf.AllowUserToDeleteRows = false;
            this.DataGridViewUf.AllowUserToResizeColumns = false;
            this.DataGridViewUf.AllowUserToResizeRows = false;
            this.DataGridViewUf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DataGridViewUf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Uf});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUf.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewUf.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewUf.Location = new System.Drawing.Point(12, 46);
            this.DataGridViewUf.MultiSelect = false;
            this.DataGridViewUf.Name = "DataGridViewUf";
            this.DataGridViewUf.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUf.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewUf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewUf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewUf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUf.Size = new System.Drawing.Size(219, 180);
            this.DataGridViewUf.TabIndex = 0;
            this.DataGridViewUf.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUf_CellDoubleClick);
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
            // Uf
            // 
            this.Uf.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Uf.DefaultCellStyle = dataGridViewCellStyle2;
            this.Uf.HeaderText = "Uf";
            this.Uf.Name = "Uf";
            this.Uf.ReadOnly = true;
            // 
            // ButEnd
            // 
            this.ButEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButEnd.Location = new System.Drawing.Point(156, 235);
            this.ButEnd.Name = "ButEnd";
            this.ButEnd.Size = new System.Drawing.Size(75, 23);
            this.ButEnd.TabIndex = 1;
            this.ButEnd.Text = "Sai&r";
            this.ButEnd.UseVisualStyleBackColor = true;
            this.ButEnd.Click += new System.EventHandler(this.ButEnd_Click);
            // 
            // TxtFind
            // 
            this.TxtFind.Location = new System.Drawing.Point(13, 19);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(182, 20);
            this.TxtFind.TabIndex = 2;
            // 
            // ButFind
            // 
            this.ButFind.Location = new System.Drawing.Point(202, 17);
            this.ButFind.Name = "ButFind";
            this.ButFind.Size = new System.Drawing.Size(30, 23);
            this.ButFind.TabIndex = 3;
            this.ButFind.Text = "...";
            this.ButFind.UseVisualStyleBackColor = true;
            this.ButFind.Click += new System.EventHandler(this.ButFind_Click);
            // 
            // ButNew
            // 
            this.ButNew.Location = new System.Drawing.Point(13, 235);
            this.ButNew.Name = "ButNew";
            this.ButNew.Size = new System.Drawing.Size(75, 23);
            this.ButNew.TabIndex = 4;
            this.ButNew.Text = "&Novo";
            this.ButNew.UseVisualStyleBackColor = true;
            this.ButNew.Click += new System.EventHandler(this.ButNew_Click);
            // 
            // FrmUfList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButEnd;
            this.ClientSize = new System.Drawing.Size(244, 268);
            this.Controls.Add(this.ButNew);
            this.Controls.Add(this.ButFind);
            this.Controls.Add(this.TxtFind);
            this.Controls.Add(this.ButEnd);
            this.Controls.Add(this.DataGridViewUf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUfList";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Unidade Federativas";
            this.Load += new System.EventHandler(this.FrmUfList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
        private System.Windows.Forms.Button ButEnd;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.Button ButFind;
        private System.Windows.Forms.Button ButNew;
    }
}