using System;
using System.Windows.Forms;

namespace AppSystem.Components
{
    public partial class Button : UserControl
    {
        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick ButtonOnClick;
        
        public string Label
        {
            get
            {
                return ButtonGeneric.Text;
            }
            set
            {
                ButtonGeneric.Text = value;
            }
        }

        public ButtonIcon Icon
        {
            get
            {
                return (ButtonIcon)Enum
                    .Parse(typeof(ButtonIcon), 
                        ButtonGeneric.ImageIndex.ToString());
            }
            set
            {
                ButtonGeneric.ImageIndex = (int)value;
            }
        }
        
        public System.Windows.Forms.Button ButtonReference
        {
            get
            {
                return ButtonGeneric;
            }
        }

        public Button()
        {
            InitializeComponent();
        }

        private void ButtonGeneric_Click(object sender, EventArgs e)
        {
            ButtonOnClick(sender, e);
        }
    }
}
