using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600_ICA10
{
    public partial class Form1 : Form
    {
        ColorDialog coldiag = null;
        SizeDialog sizediag = null;
        int circleSize = 10;
        CDrawer canvas = new CDrawer();
        Color customCol = new Color();
        
        
        //Callback method invoked by color dialog
        private void CallbackColor(int  red, int green, int blue)
        {
            customCol = Color.FromArgb(red, green, blue);
            UI_ColorLabel.BackColor = customCol;
        }
        //Callback method invoked by size dialog
        private void CallBackSize(int size)
        {
            circleSize = size;
            UI_SizeLabel.Text = size.ToString();
        }
        public Form1()
        {
            InitializeComponent();
            
           
        }
        //when box is checked, initializes color dialog and delegates
        private void UI_ColorDialogCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ColorDialogCheck.Checked)
            {
                if (null == coldiag)
                {
                    coldiag = new ColorDialog();
                    coldiag._dColorChange = new delVoidIntIntInt(CallbackColor);
                    coldiag._dColFormClosing = new delColVoidVoid(CallbackColClosing);
                }
                coldiag.Show();
            }
            else
                coldiag.Hide();
        }
        //when box is checked, initializes size dialog and delegates
        private void UI_SizeDialogCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SizeDialogCheck.Checked)
            {
                if (null == sizediag)
                {
                    sizediag = new SizeDialog();
                    sizediag._dSizeChanged = new delVoidInt(CallBackSize);
                    sizediag._dSizeFormClosing = new delSizeVoidVoid(CallbackSizeClosing);
                }
                sizediag.Show();
            }
            else
                sizediag.Hide();
        }
        //when color dialog closes, unchecks box
        private void CallbackColClosing()
        {
            UI_ColorDialogCheck.Checked = false;
        }
        //when size dialog closes, unchecks box
        private void CallbackSizeClosing()
        {
            UI_SizeDialogCheck.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point ptClick;
            if (canvas.GetLastMouseLeftClick(out ptClick))
            {
                canvas.AddCenteredEllipse(ptClick.X, ptClick.Y, circleSize, circleSize, customCol);
            }
        }
    }
}
