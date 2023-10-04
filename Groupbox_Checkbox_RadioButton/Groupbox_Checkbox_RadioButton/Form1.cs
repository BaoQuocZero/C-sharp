using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupbox_Checkbox_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkNhac_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNhac.Checked == true)
            {
                chkKoNhac.Checked = false;
            }
        }

        private void chkGame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGame.Checked == true)
            {
                chkKoGame.Checked = false;
            }
        }

        private void chkPhim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhim.Checked == true)
            {
                chkKoPhim.Checked = false;
            }
        }

        private void chkKoNhac_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKoNhac.Checked == true)
            {
                chkNhac.Checked = false;
            }
        }

        private void chkKoGame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKoGame.Checked == true)
            {
                chkGame.Checked = false;
            }
        }

        private void chkKoPhim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKoPhim.Checked == true)
            {
                chkPhim.Checked = false;
            }
        }
    }
}
