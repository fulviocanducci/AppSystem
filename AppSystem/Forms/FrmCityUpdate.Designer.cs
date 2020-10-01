namespace AppSystem.Forms
{
    partial class FrmCityUpdate
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
            this.ButEnd = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbUf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButEnd
            // 
            this.ButEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButEnd.Location = new System.Drawing.Point(411, 113);
            this.ButEnd.Name = "ButEnd";
            this.ButEnd.Size = new System.Drawing.Size(75, 23);
            this.ButEnd.TabIndex = 5;
            this.ButEnd.Text = "Sai&r";
            this.ButEnd.UseVisualStyleBackColor = true;
            this.ButEnd.Click += new System.EventHandler(this.ButEnd_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(13, 113);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "&Salvar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(14, 35);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(472, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UF:";
            // 
            // CmbUf
            // 
            this.CmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUf.FormattingEnabled = true;
            this.CmbUf.Location = new System.Drawing.Point(13, 83);
            this.CmbUf.Name = "CmbUf";
            this.CmbUf.Size = new System.Drawing.Size(473, 21);
            this.CmbUf.TabIndex = 3;
            // 
            // FrmCityUpdate
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButEnd;
            this.ClientSize = new System.Drawing.Size(498, 145);
            this.Controls.Add(this.CmbUf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButEnd);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCityUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidade";
            this.Load += new System.EventHandler(this.FrmCityUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButEnd;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbUf;
    }
}