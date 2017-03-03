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
    public delegate void delVoidIntIntInt(int red, int green, int blue);
    public delegate void delColVoidVoid();
    public partial class ColorDialog : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;

        public delVoidIntIntInt _dColorChange = null;
        public delColVoidVoid _dColFormClosing = null;

        public ColorDialog()
        {
            InitializeComponent();
        }

        private void UI_RedTrack_Scroll(object sender, EventArgs e)
        {
            red = UI_RedTrack.Value;
            UI_ColorBox.BackColor = Color.FromArgb(red, green, blue);
            _dColorChange.Invoke(red, green, blue);
        }

        private void UI_GreenTrack_Scroll(object sender, EventArgs e)
        {
            green = UI_GreenTrack.Value;
            UI_ColorBox.BackColor = Color.FromArgb(red, green, blue);
            _dColorChange.Invoke(red, green, blue);
        }

        private void UI_BlueTrack_Scroll(object sender, EventArgs e)
        {
            blue = UI_BlueTrack.Value;
            UI_ColorBox.BackColor = Color.FromArgb(red, green, blue);
            _dColorChange.Invoke(red, green, blue);
        }

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
