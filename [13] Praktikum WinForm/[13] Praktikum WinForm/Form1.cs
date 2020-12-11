using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13__Praktikum_WinForm
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (labelProses.Text == "[EMPTY]")
            {
                labelProses.Text = textBoxInputData.Text;
            }
            if (labelProses.Text != "[EMPTY]" && textBoxInputData.Text == "DELETE")
            {
                labelProses.Text = "[EMPTY]";
            }
            if (labelProses.Text != "[EMPTY]" && textBoxInputData.Text == "SHOWN")
            {
                labelProses.Visible = true;
            }
            if (labelProses.Text != "[EMPTY]" && textBoxInputData.Text == "HIDE")
            {
                labelProses.Visible = false;
            }
            if (labelProses.Text != "[EMPTY]" && textBoxInputData.Text == "BLUE")
            {
                this.labelProses.ForeColor = Color.Blue;
            }
            if (labelProses.Text != "[EMPTY]" && textBoxInputData.Text == "RED")
            {
                this.labelProses.ForeColor = Color.Red;
            }
            if (labelProses.Text != "[EMPTY]" && textBoxInputData.Text == "GREEN")
            {
                this.labelProses.ForeColor = Color.Green;
            }
        }
    }
}
