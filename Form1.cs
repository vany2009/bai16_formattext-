using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_formattext__
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formattext formatText = new Formattext();
            formatText.MdiParent = this;
            formatText.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblInfor_Click(object sender, EventArgs e)
        {
            string ten = "nguyễn văn ý:";
            lblInfor.Text = "Họ và tên thí sinh:" + ten + Environment.NewLine;
            lblInfor.Text += "ngày thực hành:" + System.DateTime.Now;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.MdiParent = this;
            aboutBox1.Show();


        }
    }
}

