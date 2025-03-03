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
    public partial class Formattext: Form
    {
        public Formattext()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Text = txtNhapten.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Green;
            txtNhapten.ForeColor = Color.Green;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size,
lbllaptrinh.Font.Style ^ FontStyle.Bold);

           txtNhapten.Font = new Font(txtNhapten.Font.Name, txtNhapten.Font.Size,
txtNhapten.Font.Style ^ FontStyle.Bold);
        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size,
lbllaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkgachchan_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size,
lbllaptrinh.Font.Style ^ FontStyle.Underline);
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Blue;
            txtNhapten.ForeColor = Color.Blue;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Black;
            txtNhapten.ForeColor = Color.Black;
        }
    }
}
