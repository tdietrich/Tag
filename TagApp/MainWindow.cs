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
    /*
     PLIK DOKUMENTACJI XML: bin\Debug\doc\TagApp.XML //generowany - updatowany za kazdym Buildem
     */
    public partial class MainWindow : Form
    {
        static List<TagLib.File> tablica;
        private AboutBox1 oProgramie;

        /*
         * Prototyp funkcji która dodawałaby do mainGrida kolejne mp3, np wybrane z folderu, a później
         * pojedynczą wybraną przez użytkownika
         */
        public bool appendIntoMainGrid(/*Mp3File plik*/) { return true; }

        public MainWindow()
        {
            tablica = new List<TagLib.File>();
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
        // Przycisk Dodaj Folder - prymitywne poczatkowe eventy dodane, wybieranie folderu, wypisywanie nazwy, zliczanie plikow mp3
        // i wypisywanie nizej w rich text boxie
        //
        //!!!!!!!Przypisac DO wyszukiwania nowy wątek, zeby nie lagowalo!!!!!
        //!!!!!!!Przypisac DO wyszukiwania progress bara z dolnego panelu
        //
        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;    //zlicza ilosc plikow - to mozna zalatwic chyba System.IO funkcja jakas
            string[] filePaths;

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)   // jezeli wybrano folder
            {
                directoryTextBox.Text = folderBrowserDialog1.SelectedPath;//wpissz do texboxa wybrany folder
                isFilePathGiven.Text = folderBrowserDialog1.SelectedPath;
                filesListingrichTextBox1.Text = "";

                //zdecyduj czy szukamy w subfolderach czy nie
                if (ifSubfolders.Checked)
                {
                    filePaths = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.mp3", SearchOption.AllDirectories);
                }
                else
                {
                    filePaths = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.mp3");
                }
                
                if (filePaths.Length > 0)
                {
                    foreach (string str in filePaths)
                    {
                        string[] info = new string[5];          // utworzenie tablicy stringów żeby dodawać wierszami

                        tablica.Add(TagLib.File.Create(str));   // dodanie pliku do tablicy obiektów

                        info[0] = tablica.First().Tag.FirstPerformer;
                        info[1] = tablica.First().Tag.Album;
                        info[2] = tablica.First().Tag.FirstGenre;
                        info[3] = tablica.First().Tag.Title;
                        info[4] = tablica.First().Tag.Year.ToString();

                        mainGrid.Rows.Add(info);
                    }
                }
                
                
                
                
                
                
                //RICH TEXT BOX POMOCNY TYLKO BEDZIE PODCZAS DEV. POZNIEJ CHYBA DO WYKASOWANIA
                //if (filePaths.GetLength(0) != 0)
                //{
                //    foreach (string element in filePaths)
                //    {
                //        counter++;
                //        filesListingrichTextBox1.AppendText(element + "\n");

                //    }

                //}
                //label1.Text = "Pliki mp3 w podanym folderze (" + counter.ToString() + ")";


            }


           // TagLib.File plik = TagLib.File.Create("I:\\abc.mp3");

           // this.filesListingrichTextBox1.AppendText(plik.Tag.Album);


        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * OBSLUGE KLIKNIECIA W O PROGRAMIE W PASKU MENU
             * Za kazdyym razem kiedy klikamy, tworzymy aboutbox. Nie pakujemy tego do konstruktora MainWindow, bo
             * po przycisnieciu na boxie o progr0amie, przycisku X,disposujemy ten obiekt, wiec za kazdym razem go musimy
             * tworzyc na nowo przy wyswietlaniu. To chyba nie problem.
             */
            oProgramie = new AboutBox1();//construct
            oProgramie.Show();//show
        }
        #endregion
        /*
         * Obsluga kliku wczytaj pojedynczy plik z menu na pasku
         */
        private void otwórzPlikToolStripMenuItem_Click(object sender, EventArgs e)//obsługa  kliknięcia w menu w otwórz plik
        {
            DialogResult result = openFileDialog1.ShowDialog();//przypisanie wyników wyboru z okna wyboru 1 pliku
            if (result == DialogResult.OK) // Test result.
            {


            }
        }
    }
}

