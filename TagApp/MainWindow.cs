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
            toolStripProgressBar1.Minimum = 0;      // ustawienie wartości minimalnej progress bara
            toolStripProgressBar1.Maximum = filePaths.Length;       // ustawienie wartości maksymalnej progress bara
            toolStripProgressBar1.Value = 0;        // ustawienie wartości początkowej

            foreach (string str in filePaths)
            {
                tablica.Add(TagLib.File.Create(str));       // dodanie pliku do tablicy agregującej wszystkie pliki
                string[] info = new string[Enum.GetValues(typeof(TagFields)).Length];       // stworzenie tablicy jednowymiarowej o tylu komorkach ile jest w enumie (wszystkie ktore obslugujemy)

                info[(int) TagFields.Album]         = tablica.Last().Tag.Album;
                info[(int) TagFields.AlbumArtist]   = "DUPA";          // zaskoczę wszystkich, ale tu trzeba poprawić
                info[(int) TagFields.Artist]        = tablica.Last().Tag.FirstPerformer;
                info[(int) TagFields.Comment]       = tablica.Last().Tag.FirstGenre;
                info[(int) TagFields.Discnumber]    = tablica.Last().Tag.Disc.ToString(); ;
                info[(int) TagFields.Filename]      = tablica.Last().ToString();
                info[(int) TagFields.Genre]         = "DUPA2";

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

                addDirToCommonDirs(directoryTextBox.Text);
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
    }



}

