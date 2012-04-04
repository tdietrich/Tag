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
using System.Xml;


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
       
        public static List<TagLib.File> tablica;
        public static Opcje OpcjeWin;
        public static TagAppFileNames FileNames;

        private AboutBox1 oProgramie;
        private TemplatesManager OknoTemplatesManager;
        private int lp;
       

        /// <summary>
        /// Standardowy konstruktor
        /// </summary>
        public MainWindow()
        {
            tablica = new List<TagLib.File>();
            FileNames = new TagAppFileNames("userTemplates.xml","commons.xml");
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
        }

        /// <summary>
        /// Przeciążona Funkcja przyjmuje za argument tablicę ścieżek do plików, Tworzy z nich obiekty TagLib.File
        /// Następnie wrzuca je do tablicy(listy)plików i przekazuje do mainGrida
        /// </summary>
        /// <param name="filePaths">Tablica plików do wczytania</param>
        public void loadTags(string[] filePaths)
        {
            if (filePaths.Length > 0)           // jeśli coś zostało wczytane
            {
                System.Threading.ThreadStart ts = delegate { appendIntoMainGrid(filePaths); };          // tworzenie delegata do funkcji jednoargumentowej
                System.Threading.Thread watek = new System.Threading.Thread(ts);                        // tworzenie wątku
                watek.Start();      // start wątku
            }
            else
            {  // jeśli tablica filePaths będzie pusta
                MessageBox.Show("Brak plików MP3 w folderze");
            }

            return;
        }

        /// <summary>
        /// Funkcja wczytująca pliki z podanej lokalizacji do głównej siatki
        /// </summary>
        /// <param name="filePaths">Tablica plików do wczytania</param>
        public void appendIntoMainGrid(string[] filePaths)
        {
            toolStripProgressBar1.Minimum = 0;                      // ustawienie wartości minimalnej progress bara
            toolStripProgressBar1.Maximum = filePaths.Length;       // ustawienie wartości maksymalnej progress bara
            toolStripProgressBar1.Value = 0;                        // ustawienie wartości początkowej

            foreach (string str in filePaths)
            {
                tablica.Add(TagLib.File.Create(str));       // dodanie pliku do tablicy agregującej wszystkie pliki
                string[] info = new string[Mp3File.numberOfFields + 1];       // stworzenie tablicy jednowymiarowej o tylu komorkach ile jest w enumie (wszystkie ktore obslugujemy)

                TagLib.Tag nowy = tablica.Last().Tag;

                info[0] = (++lp).ToString();                            // wpisanie liczby porządkowej
                info[(int) TagFields.Artist] = nowy.JoinedPerformers;
                info[(int) TagFields.Title] = nowy.Title;
                info[(int) TagFields.Album] = nowy.Album;
                info[(int) TagFields.Track] = nowy.Track.ToString();
                info[(int) TagFields.AlbumArtist] = nowy.JoinedAlbumArtists;
                info[(int) TagFields.Discnumber] = nowy.Disc.ToString();
                info[(int) TagFields.Year] = nowy.Year.ToString();
                info[(int) TagFields.Genre] = nowy.JoinedGenres;
                info[(int) TagFields.Comment] = nowy.Comment;
                info[(int) TagFields.Composer] = nowy.JoinedComposers;
                info[(int) TagFields.Cover] = nowy.Pictures.Length.ToString();
                info[(int) TagFields.Tag] = tablica.Last().Tag.GetType().ToString();
                info[(int) TagFields.BPM] = nowy.BeatsPerMinute.ToString();

                int j = str.LastIndexOf("\\");              // znalezienie indeksu ostatniego slasha
                string file = "";
                string path = "";

                for (int i = j + 1; i < str.Length; i++)    // wczytanie nazwy pliku (od ostatniego slasha do końca)
                    file += str[i];

                for (int i = 0; i < j; i++)                 // wczytanie ścieżki pliku (od początku do ostatniego slasha)
                    path += str[i];

                info[(int) TagFields.Path] = path;
                info[(int) TagFields.Filename] = file; 

                mainGrid.Rows.Add(info);        // dodanie do głównego grida wszystkich informacji

                toolStripProgressBar1.Value++;      // zwiększenie wartości wczytanych plików
            }

            toolStripProgressBar1.Value = 0;        // wyzerowanie progress bara
        }


  
        /// <summary>
        /// Przeciążona funkcja, która zamienia pojedynczy plik na tablicę, a następnie wywoływana jest podstawowa funkcja
        /// </summary>
        public void appendIntoMainGrid(string path) 
        {
            string[] temp = new string[1];      // brzydki trick zamieniający jednego stringa na tablicę jednego elementu
            temp[0] = path;

            appendIntoMainGrid(temp);           // wywołanie podstawowej funkcji

            return;
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
        public void addDirToCommonDirs(string path, bool subs)
        {
            //strumień
            //FileStream plik;
            XmlDocument doc = new XmlDocument();
            XmlNode node = doc.CreateNode(XmlNodeType.XmlDeclaration, "", "");

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

            if (result == DialogResult.OK)      // jezeli wybrano folder
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

                addDirToCommonDirs(directoryTextBox.Text, ifSubfolders.Checked);
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

        private void otwórzPlikToolStripMenuItem_Click(object sender, EventArgs e)  //obsługa  kliknięcia w menu w otwórz plik
        {
            DialogResult result = openFileDialog1.ShowDialog(); //przypisanie wyników wyboru z okna wyboru 1 pliku
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
        

        private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Akcja przycisku wywołującego okno opcji */
            OpcjeWin = new Opcje();     // tworzenie instacji okna opcji
            OpcjeWin.Show();
        }

        private void narzędziaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void clearTableBut_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ZAPISZ ZMIANY FRAJERZE");

            mainGrid.DataSource = null;
        }
    }



}

