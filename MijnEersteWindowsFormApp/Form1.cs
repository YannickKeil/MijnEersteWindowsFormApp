using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MijnEersteWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            cbLeerlingen.Items.Add("Martijn");
            cbLeerlingen.Items.Add("Benjamin");
            cbLeerlingen.Items.Add("Koen");
            cbLeerlingen.Items.Add("Antal");
            cbLeerlingen.Items.Add("Yannick");
            cbLeerlingen.Items.Add("Latha");
            cbLeerlingen.Items.Add("Jonas");
            cbLeerlingen.Items.Add("Machiel");

            foreach (var item in cbLeerlingen.Items)
            {
                lbLeerlingen.Items.Add(item);
            }
        }

        private void btnMijnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void cbLeerlingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbLeerlingen.SelectedIndex.ToString());
            lblMijnLabel.Text = cbLeerlingen.SelectedItem.ToString();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            lbLeerlingen.Items.Add(txtMijnText.Text);
            //cbLeerlingen.Items.Add(txtMijnText.Text);
            txtMijnText.Enabled = false;
            btnVoegToe.Enabled = false;
        }

        private void txtMijnText_Resize(object sender, EventArgs e)
        {
            txtMijnText.BackColor = SystemColors.Window;
        }
    }
}
