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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbUf = new System.Windows.Forms.ComboBox();
            this.ButSalve = new AppSystem.Components.Button();
            this.ButClose = new AppSystem.Components.Button();
            this.SuspendLayout();
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
            // ButSalve
            // 
            this.ButSalve.Icon = AppSystem.Components.ButtonIcon.Save;
            this.ButSalve.Label = "Salvar";
            this.ButSalve.Location = new System.Drawing.Point(11, 118);
            this.ButSalve.Name = "ButSalve";
            this.ButSalve.Size = new System.Drawing.Size(121, 37);
            this.ButSalve.TabIndex = 20;
            this.ButSalve.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButSalve_ButtonOnClick);            
            // 
            // ButClose
            // 
            this.ButClose.Icon = AppSystem.Components.ButtonIcon.Close;
            this.ButClose.Label = "Fecha&r";
            this.ButClose.Location = new System.Drawing.Point(366, 118);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(121, 37);
            this.ButClose.TabIndex = 19;
            this.ButClose.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButClose_ButtonOnClick);
            // 
            // FrmCityUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 166);
            this.Controls.Add(this.ButSalve);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.CmbUf);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbUf;
        private Components.Button ButSalve;
        private Components.Button ButClose;
    }
}