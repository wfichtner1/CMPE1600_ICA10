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
    public partial class Form1 : Form
    {
        ColorDialog coldiag = null;
        SizeDialog sizediag = null;
        int circleSize = 10;
        
        //Callback method invoked by color dialog
        private void CallbackColor(int  red, int green, int blue)
        {
            UI_ColorLabel.BackColor = Color.FromArgb(red, green, blue);
        }

        private void CallBackSize(int size)
        {
            circleSize = size;
            UI_SizeLabel.Text = size.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }
                
        private void UI_ColorDialogCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ColorDialogCheck.Checked)
            {
                if (null == coldiag)
                {
                    coldiag = new ColorDialog();
                    coldiag._dColorChange = new delVoidIntIntInt(CallbackColor);
                }
                coldiag.Show();
            }
            else
                coldiag.Hide();
        }

        private void UI_SizeDialogCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SizeDialogCheck.Checked)
            {
                if (null == sizediag)
                {
                    sizediag = new SizeDialog();
                    sizediag._dSizeChanged = new delVoidInt(CallBackSize);
                }
                sizediag.Show();
            }
            else
                sizediag.Hide();
        }
    }
}
