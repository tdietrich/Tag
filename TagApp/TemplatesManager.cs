using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TagApp
{
    public partial class TemplatesManager : Form
    {
        public TemplatesManager()
        {
            InitializeComponent();
        }

        private void lookUpTemplatePreProcess() { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lookUpLabel.Text = textBox1.Text;
        }


    }
}
