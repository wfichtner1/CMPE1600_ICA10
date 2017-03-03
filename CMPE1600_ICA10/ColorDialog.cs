using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1600_ICA10
{
    //delegate to send color value
    public delegate void delVoidIntIntInt(int red, int green, int blue);
    //delegate to send close event
    public delegate void delColVoidVoid();
    public partial class ColorDialog : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        
        //color delegate
        public delVoidIntIntInt _dColorChange = null;
        //close delegate
        public delColVoidVoid _dColFormClosing = null;

        public ColorDialog()
        {
            InitializeComponent();
        }

        //Gets the red portion of an rgb color, and updates
        //the color of the box
        private void UI_RedTrack_Scroll(object sender, EventArgs e)
        {
            red = UI_RedTrack.Value;
            UI_ColorBox.BackColor = Color.FromArgb(red, green, blue);
            _dColorChange.Invoke(red, green, blue);
        }

        //Gets the green portion of an rgb color, and updates
        //the color of the box
        private void UI_GreenTrack_Scroll(object sender, EventArgs e)
        {
            green = UI_GreenTrack.Value;
            UI_ColorBox.BackColor = Color.FromArgb(red, green, blue);
            _dColorChange.Invoke(red, green, blue);
        }

        //Gets the blue portion of an rgb color, and updates
        //the color of the box.
        private void UI_BlueTrack_Scroll(object sender, EventArgs e)
        {
            blue = UI_BlueTrack.Value;
            UI_ColorBox.BackColor = Color.FromArgb(red, green, blue);
            _dColorChange.Invoke(red, green, blue);
        }

        //intercepts form closing and replaces with hide
        private void ColorDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (null != _dColFormClosing)
                {
                    _dColFormClosing();
                }
                e.Cancel = true;
                Hide();
            }
        }
    }
}
