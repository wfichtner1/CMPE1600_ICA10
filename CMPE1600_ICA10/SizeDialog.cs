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
    public delegate void delVoidInt(int size);
    public delegate void delSizeVoidVoid();
    public partial class SizeDialog : Form
    {
        int trackSize = 0;

        public delVoidInt _dSizeChanged = null;
        public delSizeVoidVoid _dSizeFormClosing;
        public SizeDialog()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackSize = trackBar1.Value;
            _dSizeChanged.Invoke(trackSize);
        }

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
