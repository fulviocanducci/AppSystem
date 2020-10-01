namespace AppSystem.Forms
{
    partial class FrmUfUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ButClose = new AppSystem.Components.Button();
            this.ButSalve = new AppSystem.Components.Button();
            this.button1 = new AppSystem.Components.Button();
            this.button2 = new AppSystem.Components.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidade Federativa:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(10, 25);
            this.TxtName.MaxLength = 2;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(256, 20);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButClose
            // 
            this.ButClose.Icon = AppSystem.Components.ButtonIcon.Close;
            this.ButClose.Label = "Fecha&r";
            this.ButClose.Location = new System.Drawing.Point(143, 59);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(121, 37);
            this.ButClose.TabIndex = 17;
            this.ButClose.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButClose_ButtonOnClick);
            // 
            // ButSalve
            // 
            this.ButSalve.Icon = AppSystem.Components.ButtonIcon.Save;
            this.ButSalve.Label = "Salvar";
            this.ButSalve.Location = new System.Drawing.Point(6, 59);
            this.ButSalve.Name = "ButSalve";
            this.ButSalve.Size = new System.Drawing.Size(121, 37);
            this.ButSalve.TabIndex = 18;
            this.ButSalve.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButSalve_ButtonOnClick);
            // 
            // button1
            // 
            this.button1.Icon = AppSystem.Components.ButtonIcon.Save;
            this.button1.Label = "Salvar";
            this.button1.Location = new System.Drawing.Point(10, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 22;
            this.button1.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButSalve_ButtonOnClick);
            // 
            // button2
            // 
            this.button2.Icon = AppSystem.Components.ButtonIcon.Close;
            this.button2.Label = "Fecha&r";
            this.button2.Location = new System.Drawing.Point(145, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 37);
            this.button2.TabIndex = 21;
            this.button2.ButtonOnClick += new AppSystem.Components.Button.ButtonClick(this.ButClose_ButtonOnClick);
            // 
            // FrmUfUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 104);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUfUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Unidade Federativa";
            this.Load += new System.EventHandler(this.FrmUfUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private Components.Button ButClose;
        private Components.Button ButSalve;
        private Components.Button button1;
        private Components.Button button2;
    }
}