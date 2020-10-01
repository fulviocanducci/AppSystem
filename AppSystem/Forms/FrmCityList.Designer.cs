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
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.DataGridViewCity = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ButFind = new AppSystem.Components.Button();
            this.ButClose = new AppSystem.Components.Button();
            this.ButNew = new AppSystem.Components.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCity)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFind
            // 
            this.TxtFind.Location = new System.Drawing.Point(11, 32);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(332, 20);
            this.TxtFind.TabIndex = 7;
            this.TxtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFind_KeyUp);
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
            this.DataGridViewCity.Location = new System.Drawing.Point(11, 58);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Digite o nome da cidade:";
            // 
            // ButFind
            // 
            this.ButFind.Icon = AppSystem.Components.ButtonIcon.Search;
            this.ButFind.Label = "Busca";
            this.ButFind.Location = new System.Drawing.Point(356, 15);
            this.ButFind.Name = "ButFind";
            this.ButFind.Size = new System.Drawing.Size(121, 37);
            this.ButFind.TabIndex = 12;
            this.ButFind.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButFind_ButtonOnClick);
            // 
            // ButClose
            // 
            this.ButClose.Icon = AppSystem.Components.ButtonIcon.Close;
            this.ButClose.Label = "Fecha&r";
            this.ButClose.Location = new System.Drawing.Point(356, 244);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(121, 37);
            this.ButClose.TabIndex = 11;
            this.ButClose.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButClose_ButtonOnClick);
            // 
            // ButNew
            // 
            this.ButNew.Icon = AppSystem.Components.ButtonIcon.Add;
            this.ButNew.Label = "&Novo";
            this.ButNew.Location = new System.Drawing.Point(10, 244);
            this.ButNew.Name = "ButNew";
            this.ButNew.Size = new System.Drawing.Size(121, 37);
            this.ButNew.TabIndex = 10;
            this.ButNew.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButNew_ButtonOnClick);
            // 
            // FrmCityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButFind);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.ButNew);
            this.Controls.Add(this.TxtFind);
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
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.DataGridView DataGridViewCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
        private Components.Button ButNew;
        private Components.Button ButClose;
        private Components.Button ButFind;
        private System.Windows.Forms.Label label1;
    }
}