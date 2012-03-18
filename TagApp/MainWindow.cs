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
using System.Threading;

namespace TagApp
{
    /*
     PLIK DOKUMENTACJI XML: bin\Debug\doc\TagApp.XML //generowany - updatowany za kazdym Buildem
     */
    public partial class MainWindow : Form
    {

        static List<TagLib.File> tablica;
        private AboutBox1 oProgramie;

        /// <summary>
        /// Standardowy konstruktor
        /// </summary>
        public MainWindow()
        {
            tablica = new List<TagLib.File>();
            InitializeComponent();
        }

        /// <summary>
        /// Przeciążona Funkcja przyjmuje za argument tablicę ścieżek do plików, Tworzy z nich obiekty TagLib.File
        /// Następnie wrzuca je do tablicy(listy)plików i przekazuje do mainGrida
        /// </summary>
        /// <param name="filePaths"></param>
        /// <returns></returns>
        public bool appendIntoMainGrid(string[] filePaths)
        {
            if (filePaths.Length > 0)
            {
                foreach (string str in filePaths)
                {
                    string[] info = new string[7];          // utworzenie tablicy stringów żeby dodawać wierszami

                    tablica.Add(TagLib.File.Create(str));   // dodanie pliku do tablicy obiektów

                    /*
                     * Teraz Lista odczytuje z elementu LAST, poprawnie wyświetla nowo dodane pliki
                     * Poprzednio odczytywala ciagle ten sam.
                    */
                    info[0] = tablica.Count.ToString();
                    info[1] = tablica.Last().Tag.Title;
                    info[2] = tablica.Last().Tag.FirstPerformer;
                    info[3] = tablica.Last().Tag.Album;
                    info[4] = tablica.Last().Tag.DiscCount.ToString();
                    info[5] = tablica.Last().Tag.Year.ToString();
                    info[6] = str;
                    mainGrid.Rows.Add(info);
                }
            }

            return true;
        }
        /// <summary>
        /// Przeciążona Funkcja przyjmuje za argument pojedynczą scieżke pliku, Tworzy z niej obiekt TagLib.File
        /// Następnie wrzuca do tablicy(listy)plików i przekazuje do mainGrida
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool appendIntoMainGrid(string path) 
        {
            tablica.Add(TagLib.File.Create(path)); // dodanie pliku do tablicy obiektów
            /*
            * Teraz Lista odczytuje z elementu LAST, poprawnie wyświetla nowo dodane pliki
            * Poprzednio odczytywala ciagle ten sam.
            */
            string[] info = new string[7];
            info[0] = tablica.Count.ToString();
            info[1] = tablica.Last().Tag.Title;
            info[2] = tablica.Last().Tag.FirstPerformer;
            info[3] = tablica.Last().Tag.Album;
            info[4] = tablica.Last().Tag.DiscCount.ToString();
            info[5] = tablica.Last().Tag.Year.ToString();
            info[6] = path;
            mainGrid.Rows.Add(info);
            return true; 
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

                //zdecyduj czy szukamy w subfolderach czy nie
                if (ifSubfolders.Checked)
                {
                    filePaths = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.mp3", SearchOption.AllDirectories);
                }
                else
                {
                    filePaths = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.mp3");
                }
                
                /*
                 Tu w poprzedniej wersji byla petla foreach - zamienione na funkcje.
                 */
                appendIntoMainGrid(filePaths);
            }
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
         * Obsluga kliku wczytaj pojedynczy plik z menu na pasku gornym(Ctrl + O)
         */
        private void otwórzPlikToolStripMenuItem_Click(object sender, EventArgs e)//obsługa  kliknięcia w menu w otwórz plik
        {
            DialogResult result = openFileDialog1.ShowDialog();//przypisanie wyników wyboru z okna wyboru 1 pliku
            if (result == DialogResult.OK) // Test result.
            {
                string fileSelected = openFileDialog1.FileName; //sciezka do pliku wybranego z okna

                directoryTextBox.Text = fileSelected;           //wpisanie do text boxa sciezki
                isFilePathGiven.Text = fileSelected;            //wypisanie ponizej sciezki

                appendIntoMainGrid(fileSelected);               //Dołożenie do tablicy pliku
            }
        }
    }
}

