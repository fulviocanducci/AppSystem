namespace AppSystem.Components
{
    partial class Button
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Button));
            this.ButtonGeneric = new System.Windows.Forms.Button();
            this.ImageListGeneric = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ButtonGeneric
            // 
            this.ButtonGeneric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGeneric.ImageIndex = 4;
            this.ButtonGeneric.ImageList = this.ImageListGeneric;
            this.ButtonGeneric.Location = new System.Drawing.Point(0, 0);
            this.ButtonGeneric.Name = "ButtonGeneric";
            this.ButtonGeneric.Size = new System.Drawing.Size(121, 37);
            this.ButtonGeneric.TabIndex = 0;
            this.ButtonGeneric.Text = "button1";
            this.ButtonGeneric.UseVisualStyleBackColor = true;
            this.ButtonGeneric.Click += new System.EventHandler(this.ButtonGeneric_Click);
            // 
            // ImageListGeneric
            // 
            this.ImageListGeneric.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListGeneric.ImageStream")));
            this.ImageListGeneric.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListGeneric.Images.SetKeyName(0, "plus.png");
            this.ImageListGeneric.Images.SetKeyName(1, "edit.png");
            this.ImageListGeneric.Images.SetKeyName(2, "delete.png");
            this.ImageListGeneric.Images.SetKeyName(3, "search.png");
            this.ImageListGeneric.Images.SetKeyName(4, "save.png");
            this.ImageListGeneric.Images.SetKeyName(5, "close.png");
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonGeneric);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(121, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGeneric;
        private System.Windows.Forms.ImageList ImageListGeneric;
    }
}
