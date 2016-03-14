using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100to1
{
    public partial class AdminForm : Form
    {
        TextBox[] tbArray;
        int tbWdith = 400;
        int tbHeight = 30;
        int tbPadding = 15;
        public AdminForm()
        {
            InitializeComponent();
            ViewForm vf = new ViewForm();
            vf.Show();
            //tbCreate(6);
        }

        public void tbCreate(int num)
        {
            tbArray = new TextBox[num];
            for (int i = 0; i < num; i++)
            {
                tbArray[i] = new TextBox();
                tbArray[i].Width = tbWdith;
                tbArray[i].Height = tbHeight;
                tbArray[i].Top = tbPadding * i + tbPadding + tbHeight * i;
                tbArray[i].Left = AdminForm.ActiveForm.Width / 2 - tbWdith;
                tbArray[i].Parent = this;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
