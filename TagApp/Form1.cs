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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////
        // Przycisk Zamknij - Dodać w przyszłości obsługę "Czy chcesz zapisać zmiany przed zamknięciem?"
        //
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Close(); 
        }
        ////
        // Przycisk Dodaj Folder
        //
        private void button1_Click(object sender, EventArgs e)
        {
            //Jeżeli pole do wpisania jest puste to otwórz okno przeglądaj
            if (this.textBox1.TextLength != 0)
            {
                //sproboj zaladować path
                

            }
            else
            {


            }
            //END IFELSE
        }

    }
}
