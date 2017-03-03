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
    //delegate that sends size to callback
    public delegate void delVoidInt(int trackSize);
    //delegate that informs main of closing event
    public delegate void delSizeVoidVoid();
    public partial class SizeDialog : Form
    {
        int trackSize = 0;

        //size delegate
        public delVoidInt _dSizeChanged = null;
        //close delegate
        public delSizeVoidVoid _dSizeFormClosing;
        public SizeDialog()
        {
            InitializeComponent();
        }
        
        //gets the value of the trackbar and sets
        //it as track size. invokes size delegate
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackSize = trackBar1.Value;
            _dSizeChanged.Invoke(trackSize);
        }

        //intercepts form closing and replaces with hide
        private void SizeDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (null != _dSizeFormClosing)
                {
                    _dSizeFormClosing();
                }
                e.Cancel = true;

                Hide();
            }
        }
    }
}
