using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_ACT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Choose();

        }

        private void Choose()
        {
            if (comboBox1.Text == "Asia")
            {
                Asia daigdig = new Asia();
                Clean();
                listBox1.Items.Add(daigdig.bansa);
                listBox1.Items.Add(daigdig.bansa1);
                listBox1.Items.Add(daigdig.bansa2);
                listBox1.Items.Add(daigdig.bansa3);
                listBox1.Items.Add(daigdig.bansa4);
                listBox1.Items.Add(daigdig.bansa5);
                listBox1.Items.Add(daigdig.bansa6);
                listBox1.Items.Add(daigdig.bansa7);
                listBox1.Items.Add(daigdig.bansa8);
                listBox1.Items.Add(daigdig.bansa9);
                listBox1.Items.Add(daigdig.bansa10);
            }
            else if (comboBox1.Text == "Australia")
            {
                Australia  daigdig = new Australia ();
                Clean();
                listBox1.Items.Add(daigdig.bansa);
                listBox1.Items.Add(daigdig.bansa1);
                listBox1.Items.Add(daigdig.bansa2);
                listBox1.Items.Add(daigdig.bansa3);
                listBox1.Items.Add(daigdig.bansa4);
                listBox1.Items.Add(daigdig.bansa5);
                listBox1.Items.Add(daigdig.bansa6);
                listBox1.Items.Add(daigdig.bansa7);
                listBox1.Items.Add(daigdig.bansa8);
                listBox1.Items.Add(daigdig.bansa9);
                listBox1.Items.Add(daigdig.bansa10);
            }
            else if (comboBox1.Text == "Africa")
            {
                Africa daigdig = new Africa();
                Clean();
                listBox1.Items.Add(daigdig.bansa);
                listBox1.Items.Add(daigdig.bansa1);
                listBox1.Items.Add(daigdig.bansa2);
                listBox1.Items.Add(daigdig.bansa3);
                listBox1.Items.Add(daigdig.bansa4);
                listBox1.Items.Add(daigdig.bansa5);
                listBox1.Items.Add(daigdig.bansa6);
                listBox1.Items.Add(daigdig.bansa7);
                listBox1.Items.Add(daigdig.bansa8);
                listBox1.Items.Add(daigdig.bansa9);
                listBox1.Items.Add(daigdig.bansa10);
            }
            else if (comboBox1.Text == "South America")
            {
                South_America  daigdig = new South_America ();
                Clean();
                listBox1.Items.Add(daigdig.bansa);
                listBox1.Items.Add(daigdig.bansa1);
                listBox1.Items.Add(daigdig.bansa2);
                listBox1.Items.Add(daigdig.bansa3);
                listBox1.Items.Add(daigdig.bansa4);
                listBox1.Items.Add(daigdig.bansa5);
                listBox1.Items.Add(daigdig.bansa6);
                listBox1.Items.Add(daigdig.bansa7);
                listBox1.Items.Add(daigdig.bansa8);
                listBox1.Items.Add(daigdig.bansa9);
                listBox1.Items.Add(daigdig.bansa10);
            }
            else if (comboBox1.Text == "North America")
            {
                Africa daigdig = new Africa();
                Clean();
                listBox1.Items.Add(daigdig.bansa);
                listBox1.Items.Add(daigdig.bansa1);
                listBox1.Items.Add(daigdig.bansa2);
                listBox1.Items.Add(daigdig.bansa3);
                listBox1.Items.Add(daigdig.bansa4);
                listBox1.Items.Add(daigdig.bansa5);
                listBox1.Items.Add(daigdig.bansa6);
                listBox1.Items.Add(daigdig.bansa7);
                listBox1.Items.Add(daigdig.bansa8);
                listBox1.Items.Add(daigdig.bansa9);
                listBox1.Items.Add(daigdig.bansa10);
            }
            else if (comboBox1.Text == "Europe")
            {
                Europe  daigdig = new Europe ();
                Clean();
                listBox1.Items.Add(daigdig.bansa);
                listBox1.Items.Add(daigdig.bansa1);
                listBox1.Items.Add(daigdig.bansa2);
                listBox1.Items.Add(daigdig.bansa3);
                listBox1.Items.Add(daigdig.bansa4);
                listBox1.Items.Add(daigdig.bansa5);
                listBox1.Items.Add(daigdig.bansa6);
                listBox1.Items.Add(daigdig.bansa7);
                listBox1.Items.Add(daigdig.bansa8);
                listBox1.Items.Add(daigdig.bansa9);
                listBox1.Items.Add(daigdig.bansa10);
            }
        
        }
        private void Clean()
        {
            listBox1.Items.Clear();
        }
    }
}
