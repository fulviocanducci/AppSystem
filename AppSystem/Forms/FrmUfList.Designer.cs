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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewUf = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButClose = new AppSystem.Components.Button();
            this.ButNew = new AppSystem.Components.Button();
            this.ButFind = new AppSystem.Components.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUf)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewUf
            // 
            this.DataGridViewUf.AllowUserToAddRows = false;
            this.DataGridViewUf.AllowUserToDeleteRows = false;
            this.DataGridViewUf.AllowUserToResizeColumns = false;
            this.DataGridViewUf.AllowUserToResizeRows = false;
            this.DataGridViewUf.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewUf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Uf});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUf.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewUf.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewUf.Location = new System.Drawing.Point(12, 67);
            this.DataGridViewUf.MultiSelect = false;
            this.DataGridViewUf.Name = "DataGridViewUf";
            this.DataGridViewUf.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUf.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewUf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewUf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewUf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUf.ShowCellErrors = false;
            this.DataGridViewUf.ShowCellToolTips = false;
            this.DataGridViewUf.ShowEditingIcon = false;
            this.DataGridViewUf.ShowRowErrors = false;
            this.DataGridViewUf.Size = new System.Drawing.Size(261, 180);
            this.DataGridViewUf.TabIndex = 0;
            this.DataGridViewUf.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUf_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Id.DefaultCellStyle = dataGridViewCellStyle5;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 52;
            // 
            // Uf
            // 
            this.Uf.DataPropertyName = "Name";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Uf.DefaultCellStyle = dataGridViewCellStyle6;
            this.Uf.HeaderText = "Uf";
            this.Uf.Name = "Uf";
            this.Uf.ReadOnly = true;
            this.Uf.Width = 147;
            // 
            // TxtFind
            // 
            this.TxtFind.Location = new System.Drawing.Point(13, 41);
            this.TxtFind.MaxLength = 2;
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(126, 20);
            this.TxtFind.TabIndex = 2;
            this.TxtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFind_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Digite a Uf:";
            // 
            // ButClose
            // 
            this.ButClose.Icon = AppSystem.Components.ButtonIcon.Close;
            this.ButClose.Label = "Fecha&r";
            this.ButClose.Location = new System.Drawing.Point(152, 253);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(121, 37);
            this.ButClose.TabIndex = 16;
            this.ButClose.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButClose_ButtonOnClick);
            // 
            // ButNew
            // 
            this.ButNew.Icon = AppSystem.Components.ButtonIcon.Add;
            this.ButNew.Label = "&Novo";
            this.ButNew.Location = new System.Drawing.Point(10, 253);
            this.ButNew.Name = "ButNew";
            this.ButNew.Size = new System.Drawing.Size(121, 37);
            this.ButNew.TabIndex = 15;
            this.ButNew.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButNew_ButtonOnClick);
            // 
            // ButFind
            // 
            this.ButFind.Icon = AppSystem.Components.ButtonIcon.Search;
            this.ButFind.Label = "Busca";
            this.ButFind.Location = new System.Drawing.Point(152, 24);
            this.ButFind.Name = "ButFind";
            this.ButFind.Size = new System.Drawing.Size(121, 37);
            this.ButFind.TabIndex = 13;
            this.ButFind.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButFind_ButtonOnClick);
            // 
            // FrmUfList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 301);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.ButNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButFind);
            this.Controls.Add(this.TxtFind);
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
        private System.Windows.Forms.TextBox TxtFind;
        private Components.Button ButFind;
        private System.Windows.Forms.Label label1;
        private Components.Button ButClose;
        private Components.Button ButNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
    }
}