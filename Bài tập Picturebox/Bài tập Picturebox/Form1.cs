using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bài_tập_Picturebox
{
    public partial class Form1 : Form
    {
        private SoundPlayer nhac;
        private SoundPlayer nhacGigaChar;
        public Form1()
        {
            InitializeComponent();
            nhac = new SoundPlayer(@"E:\Code\C-sharp\Bài tập Picturebox\pic-nang-ta\nhactap.wav");
            nhacGigaChar = new SoundPlayer ("GigaChar.wav");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picNangTa.Visible = false;
            picHaTa.Visible = true;
            picGigaChar.Visible = false;
            btnClick.Text = " Nâng tạ đi";
        }
        int count = 1;
        private void btnTap_Click(object sender, EventArgs e)
        {
            count *= 2;
            lblSoLanTap.Text = count.ToString();
            if (count < 1 || count > 2000000000)
            {
                picGigaChar.Visible = true;
                picHaTa.Visible = false;
                picNangTa.Visible = false;
                lblSoLanTap.Text = "GiGa Char";
                nhacGigaChar.Play();
                chkNhac.Visible = false;    
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (picHaTa.Visible == true)
            {
                btnClick.Text = btnClick.Text.Replace("Nâng", "Hạ");
                picHaTa.Visible = false;
                picNangTa.Visible = true;
                lblSoLanTap.Text = count.ToString();
                count++;
            }
            else
            {
                btnClick.Text = btnClick.Text.Replace("Hạ", "Nâng");
                picHaTa.Visible = true;
                picNangTa.Visible = false;
                lblSoLanTap.Text = count.ToString();
                count++;
            }
            if (count < 1 || count > 2000000000)
            {
                picGigaChar.Visible = true;
                picHaTa.Visible = false;
                picNangTa.Visible = false;
                lblSoLanTap.Text = "GiGa Char";
                nhacGigaChar.Play();
                chkNhac.Visible = false;
            }
        }

        private void txtIntPut_TextChanged(object sender, EventArgs e)
        {
            if (picHaTa.Visible == true)
            {
                btnClick.Text = txtIntPut.Text + " Nâng tạ đi";
            }
            else
            {
                btnClick.Text = txtIntPut.Text + " Hạ tạ đi";
            }
        }

        private void chkNhac_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhac.Checked == true)
            {
                nhac.Play();
            }
            else
            {
                nhac.Stop();
            }
        }

        private void pĩcGigaChar_Click(object sender, EventArgs e)
        {

        }
    }
}
