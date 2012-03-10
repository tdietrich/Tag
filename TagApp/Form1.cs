using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TagLib;

namespace TagApp
{
    #region nasze klasy
    namespace FileManagement
    {
        public class Mp3File
        {
            
            public Mp3File(string Ppath)
            { 
            
            }
            public Mp3File()
            {
            
            }

            private string path;
            private bool edited;
            private bool savedChanges;
           
        };
        public class Directory 
        {
            public Directory(string Ppath) { }
            public Directory() { }

            private int numberOfFilesIn;

        
        
        
        };

    }
    class AppUser
    {
        public AppUser() { }

        //loaded from file while opening app
        private string[] commonUsedDirs;
        private Template[] userTagTemplates;
    };
    class Template
    {


    };
    #endregion

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Events & Handlers To GUI
        ////
        // Przycisk Zamknij - Dodać w przyszłości obsługę "Czy chcesz zapisać zmiany przed zamknięciem?"
        //
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        ////
        // Przycisk Dodaj Folder - prymitywne poczatkowe eventy dodane
        //
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.directoryTextBox.TextLength != 0)
            {
                //Jeżeli podano jakis path to sproboj zaladować path
            }
            else //Jeżeli pole do wpisania jest puste to otwórz okno przeglądaj
            {
             
                folderBrowserDialog1.ShowDialog();
            }
            //END IFELSE
        }
        #endregion



    }
}

