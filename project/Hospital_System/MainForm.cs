using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_System
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        Neurology obj1 = new Neurology();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (obj1.IsDisposed == true)
            {
                obj1 = new Neurology();
            }
            obj1.Show();
            NeurologyButton.Checked = false;
        }

        FacialPlasticSurgery obj2 = new FacialPlasticSurgery();

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (obj2.IsDisposed == true)
            {
                obj2 = new FacialPlasticSurgery();
            }
            obj2.Show();
            FacialPlasticSurgery.Checked = false;
        }
        Dermatology obj3 = new Dermatology();

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (obj3.IsDisposed == true)
            {
                obj3 = new Dermatology();
            }
            obj3.Show();
            Dermatology.Checked = false;
        }
        Neurosurgery obj4 = new Neurosurgery();

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (obj4.IsDisposed == true)
            {
                obj4 = new Neurosurgery();
            }
            obj4.Show();
            Neurosurgery.Checked = false;

        }
        Otology obj5 = new Otology();

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (obj5.IsDisposed == true)
            {
                obj5 = new Otology();
            }
            obj5.Show();
            Otology.Checked = false;
        }
        Ophthalmology obj6 = new Ophthalmology();

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (obj6.IsDisposed == true)
            {
                obj6 = new Ophthalmology();
            }
            obj6.Show();
            Ophthalmology.Checked = false;
        }
        Rhinology obj7 = new Rhinology();

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (obj7.IsDisposed == true)
            {
                obj7 = new Rhinology();
            }
            obj7.Show();
            Rhinology.Checked = false;
        }
        OralHealth obj8 = new OralHealth();

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (obj8.IsDisposed == true)
            {
                obj8 = new OralHealth();
            }
            obj8.Show();
            OralHealth.Checked = false;
        }
        Cardiology obj9 = new Cardiology();

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (obj9.IsDisposed == true)
            {
                obj9 = new Cardiology();
            }
            obj9.Show();
            Cardiology.Checked = false;
        }
        Hepatology obj10 = new Hepatology();

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (obj10.IsDisposed == true)
            {
                obj10 = new Hepatology();
            }
            obj10.Show();
            Hepatology.Checked = false;
        }
        Pulmonology obj11 = new Pulmonology();

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (obj11.IsDisposed == true)
            {
                obj11 = new Pulmonology();
            }
            obj11.Show();
            Pulmonology.Checked = false;
        }
        Gastroenterology obj12 = new Gastroenterology();

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (obj12.IsDisposed == true)
            {
                obj12 = new Gastroenterology();
            }
            obj12.Show();
            Gastroenterology.Checked = false;
        }
        Urology obj13 = new Urology();

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (obj13.IsDisposed == true)
            {
                obj13 = new Urology();
            }
            obj13.Show();
            Urology.Checked = false;
        }
        PlasticSurgery obj14 = new PlasticSurgery();

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (obj14.IsDisposed == true)
            {
                obj14 = new PlasticSurgery();
            }
            obj14.Show();
            PlasticSurgery.Checked = false;
        }
        Orthopedi obj15 = new Orthopedi();

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (obj15.IsDisposed == true)
            {
                obj15 = new Orthopedi();
            }
            obj15.Show();
            Orthopedi.Checked = false;
        }
        Gynecology obj16 = new Gynecology();

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (obj16.IsDisposed == true)
            {
                obj16 = new Gynecology();
            }
            obj16.Show();
            Gynecology.Checked = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           

        }
    }
}
