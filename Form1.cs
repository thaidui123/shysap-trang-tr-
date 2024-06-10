using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shysap_trang_trí
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i <= 2050; i++)
                lbsketqua.Items.Add(i.ToString());
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string chi = "" ,can = "";
            switch(Convert.ToInt32(txtnam.Text)%12)
            {
                case 0:
                    chi = "Tý";
                    break;

                case 1:
                    chi = "sửu";
                    break;

                case 2:
                    chi = "dần";
                    break;


                case 3:
                    chi = "mẽo";
                    break;

                case 4:
                    chi = "thìn";
                    break;

                case 5:
                    chi = "Tỵ";
                    break;

                case 6:
                    chi = "ngọ";
                    break;

                case 7:
                    chi = "mùi";
                    break;

                case 8:
                    chi = "Thân";
                    break;


                case 9:
                    chi = "dậu";
                    break;

                case 10:
                    chi = "Tuất";
                    break;

                case 11:
                    chi = "hợi";
                    break;












            }
            switch(Convert.ToInt32(txtnam.Text)%10)
            {
                case 0:
                    can = "canh";
                    break;

                    case 1:
                    can = "tân";
                    break;

                case 2:
                    can = "nhâm";
                    break;

                case 3:
                    can = "quý";
                    break;

                case 4:
                    can = "giáp";
                    break;

                case 5:
                    can = "ất";
                    break;

                case 6:
                    can = "binh";
                    break;

                case 7:
                    can = "đinh";
                    break;

                case 8:
                    can = "mậu";
                    break;

                case 9:
                    can = "kỵ";
                    break;













            }
            txtketqua.Text = chi +" "+can;
            for (int i = 2000;i<=2050;i++)
            {
                int indexchi = i % 12;
                int indexcan = i % 10;
            }    
        }
    }
}
