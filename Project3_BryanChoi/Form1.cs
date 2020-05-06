using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_BryanChoi
{
    //BRYAN CHOI - Project #3
    public partial class Form1 : Form
    {
        private double oneScoop = 1.00;
        private double twoScoops = 2.00;
        private double threeScoops = 3.00;
        private double sprinkles = 0.50;
        private double oreos = 0.50;
        private double chocolateChips = 0.50;
        private double cherrySyrup = 0.50;
        private double gummyWorms = 0.50;

        private double scoopsTotal = 0.00;
        private double toppingsTotal = 0.00;
        private double finalTotal = 0.00;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbFlavors_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbFlavors.Focus();

            lbFlavors.SelectedIndex = 0;

            rbOneScoop.Checked = true;

            cbCherrySyrup.Checked = false;
            cbChocolateChips.Checked = false;
            cbGummyWorms.Checked = false;
            cbOreos.Checked = false;
            cbSprinkles.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbFlavors.Focus();
            lbFlavors.SelectedIndex = 0;

            if (rbOneScoop.Checked == true)
            {
                scoopsTotal += oneScoop;
            }
        }

        private void rbOneScoop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOneScoop.Checked == true)
            {
                scoopsTotal += oneScoop;
                finalTotal = scoopsTotal + toppingsTotal;
                txtTotal.Text = finalTotal.ToString();
            } else
            {
                scoopsTotal -= oneScoop;
                finalTotal = scoopsTotal + toppingsTotal;
                txtTotal.Text = finalTotal.ToString();
            }
        }

        private void rbTwoScoops_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTwoScoops.Checked == true)
            {
                scoopsTotal += twoScoops;
                finalTotal = scoopsTotal + toppingsTotal;
                txtTotal.Text = finalTotal.ToString();
            } else
            {
                scoopsTotal -= twoScoops;
                finalTotal = scoopsTotal + toppingsTotal;
                txtTotal.Text = finalTotal.ToString();
            }
        }

        private void rbThreeScoops_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThreeScoops.Checked == true)
            {
                scoopsTotal += threeScoops;
                finalTotal = scoopsTotal + toppingsTotal;
                txtTotal.Text = finalTotal.ToString();
            } else
            {
                scoopsTotal -= threeScoops;
                finalTotal = scoopsTotal + toppingsTotal;
                txtTotal.Text = finalTotal.ToString();
            }
        }

        private void cbSprinkles_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSprinkles.Checked == true)
            {
                toppingsTotal += sprinkles;
                finalTotal = toppingsTotal + scoopsTotal;
                txtTotal.Text = finalTotal.ToString();
            } else
            {
                toppingsTotal -= sprinkles;
                finalTotal = toppingsTotal + scoopsTotal;
                txtTotal.Text = finalTotal.ToString();
            }
        }

        private void cbOreos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOreos.Checked == true)
            {
                toppingsTotal += oreos;
                finalTotal = toppingsTotal + scoopsTotal;
                txtTotal.Text = finalTotal.ToString();
            } else
            {
                toppingsTotal -= oreos;
                finalTotal = toppingsTotal + scoopsTotal;
                txtTotal.Text = finalTotal.ToString();
            }
        }

        private void cbChocolateChips_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCherrySyrup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbGummyWorms_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
