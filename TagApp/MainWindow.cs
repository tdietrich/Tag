﻿using System;
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


    /// <summary>
    /// Struktura przechowująca nazwy plików z których korzysta program
    ///W tej strukturze będziemy trzymac wszystkie nazwy plików używanych w programie - tzn txt np itp
    /// Plików zewnętrznych
    /// </summary>
    /// 

    public struct TagAppFileNames
    {
        /// <summary>
        /// Co dodanie pola do struktury, dodawać argument do konstruktora i ustawiać w nim wartość
        /// Konstruktor struktury nie moze byc domyślny(pusty)- narzucone przez VS. \
        /// </summary>
        /// <param name="p">Opisuje templatesFile</param>
        /// <param name="s">Opisuje commonUsedDirs</param>
       
        public TagAppFileNames(string p,string s)
        {
            templatesFile = p;
            commonUsedDirs = s;
        }

        /// <summary>
        /// Plik z używanymi szablonami nazewnictwa
        /// </summary>
        public string templatesFile;

        /// <summary>
        /// Często używane ścieżki do wyszukiwania
        /// </summary>
        public string commonUsedDirs;
    }

    public partial class MainWindow : Form
    {
       
        static List<TagLib.File> tablica;
        private AboutBox1 oProgramie;
        public static Form OpcjeWin;
        private TemplatesManager OknoTemplatesManager;
        public static TagAppFileNames FileNames;
        /// <summary>
        /// Standardowy konstruktor
        /// </summary>
        public MainWindow()
        {
            tablica = new List<TagLib.File>();
            FileNames = new TagAppFileNames("userTemplates.txt","commons.txt");
            InitializeComponent();

            //Wyszukuje plik, templejtów, jeżeli nie ma, tworzy go
            if (!(searchForTagAppFile(FileNames.templatesFile)))
            {
                System.IO.File.Create(FileNames.templatesFile);
            }
            //Wyszukuje plik common used Dirs, jezeli nie ma - tworzy
            if (!(searchForTagAppFile(FileNames.commonUsedDirs)))
            {
                System.IO.File.Create(FileNames.commonUsedDirs);
            }

            OpcjeWin = new Opcje();     // tworzenie instacji okna opcji
        }



        /// <summary>
        /// Przeciążona Funkcja przyjmuje za argument tablicę ścieżek do plików, Tworzy z nich obiekty TagLib.File
        /// Następnie wrzuca je do tablicy(listy)plików i przekazuje do mainGrida
        /// </summary>
        /// <param name="filePaths"></param>
        /// <returns></returns>
        public bool appendIntoMainGrid(string[] filePaths)
        {


            int howMuchFiles = filePaths.Length; //zmienna trzymająca ile plikow jest do wczytania
            int counter = howMuchFiles - 1; //zmienna uzywana przy zlcizaniu ile plikow zaladowano
            double coIleStep = (howMuchFiles) / (toolStripProgressBar1.Width); //pojedynczy step progress bara, obliczanie co ile plikow stepnąć progress bar o 1
            int dummyCounter = 0; // glupi licznik sprawdzający czy juz osiagnelismy liczbe dodanych plików po ilu, stepujemy pasek
            coIleStep = Math.Ceiling(coIleStep);//zaokraglenie w gore
            toolStripProgressBar1.Step = (int)coIleStep; // przypisanie stepa

            


            if (filePaths.Length > 0)
            {
                foreach (string str in filePaths)
                {
                    
                    toolStripStatusLabel1.Text = "Załadowano " + (howMuchFiles - counter).ToString() + " z " + howMuchFiles.ToString();//wpisanie do info obok prog. bara na dole x plikow z x
                    string[] info = new string[7];          // utworzenie tablicy stringów żeby dodawać wierszami

                    tablica.Add(TagLib.File.Create(str));   // dodanie pliku do tablicy obiektów

                    /*
                     * Teraz Lista odczytuje z elementu LAST, poprawnie wyświetla nowo dodane pliki
                     * Poprzednio odcztywala ciagle ten sam.
                     */


                    info[0] = tablica.Count.ToString();
                    info[1] = tablica.Last().Tag.Title;
                    info[2] = tablica.Last().Tag.FirstPerformer;
                    info[3] = tablica.Last().Tag.Album;
                    info[4] = tablica.Last().Tag.DiscCount.ToString();
                    info[5] = tablica.Last().Tag.Year.ToString();
                    info[6] = str;
                    mainGrid.Rows.Add(info);



                    dummyCounter++;  // glupi licznik, zwiekszany czy juz zaladowalismy tyle plikow po ilu step progress bara
                    if (dummyCounter.Equals((int)coIleStep)) // czy counter == coIleStep
                    {
                        toolStripProgressBar1.PerformStep(); // jezeli tak, step progress bara
                        dummyCounter = 0; // wyzeruj licznik
                    }
                    counter--; // zmiejsz licznik - zaladowany zostal plik 
                }
            }

            toolStripProgressBar1.Value = 0;
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

        /// <summary>
        /// Funkcja szuka czy w Folderze programu jest plik o danej sciezce, zwraca tak lub nie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// 
        public static bool searchForTagAppFile(string name)
        {
            if (System.IO.File.Exists(name)) return true;
            else return false;
        }

        /// <summary>
        /// Funkcja dodaje do pliku commonDirs, ścieżkę podaną jako argument, w przyszłości, będzie zliczać,
        /// najbardziej popularne śceiżki
        /// </summary>
        /// <param name="path">Ścieżka do dodania do pliku txt</param>
        /// 
        public void addDirToCommonDirs(string path)
        {
            //strumień
            FileStream plik;

            //dodanie entera na koniec
            path = path + "\n";
            byte[] byteData = null;
            byteData = Encoding.UTF8.GetBytes(path);
            plik = new FileStream(FileNames.commonUsedDirs, FileMode.Append);
            plik.Write(byteData, 0, byteData.Length);
            plik.Close();

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

                addDirToCommonDirs(directoryTextBox.Text);
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

            oProgramie = new AboutBox1();   //construct
            oProgramie.Show();//show
        }

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
       
        /// <summary>
        /// Obsługa po zmianie komórki tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            


        }
        
        /// <summary>
        /// Obsluga kliku w Szablony Tagów, w menu stripie, Tworzy nowe okno TemplatesManager, i pokazuje je
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void szablonyTagówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoTemplatesManager = new TemplatesManager();
            OknoTemplatesManager.Show();
        }
        #endregion

        private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Akcja przycisku wywołującego okno opcji */

            OpcjeWin.Show();
        }

        private void narzędziaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }



}

