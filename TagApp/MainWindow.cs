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
        public MainWindow()
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
        // Przycisk Dodaj Folder - prymitywne poczatkowe eventy dodane, wybieranie folderu, wypisywanie nazwy, zliczanie plikow mp3
        // i wypisywanie nizej w rich text boxie
        //
        //!!!!!!!Przypisac DO wyszukiwania nowy wątek, zeby nie lagowalo!!!!!
        //!!!!!!!Przypisac DO wyszukiwania progress bara z dolnego panelu
        //
        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;//zlicza ilosc plikow - to mozna zalatwic chyba System.IO funkcja jakas
            string[] filePaths;
               DialogResult result = folderBrowserDialog1.ShowDialog();
               if (result == DialogResult.OK) // jezeli wybrano folder
               {
                   directoryTextBox.Text = folderBrowserDialog1.SelectedPath;//wpissz do texboxa wybrany folder
                   isFilePathGiven.Text = folderBrowserDialog1.SelectedPath;
                   filesListingrichTextBox1.Text = "";

                   //zdecyduj czy szukamy w subfolderach czy nie
                   if (ifSubfolders.Checked) filePaths = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.mp3", SearchOption.AllDirectories);
                   else filePaths = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.mp3");

                   //RICH TEXT BOX POMOCNY TYLKO BEDZIE PODCZAS DEV. POZNIEJ CHYBA DO WYKASOWANIA
                   if (filePaths.GetLength(0) != 0)
                   {
                       foreach (string element in filePaths)
                       {
                           counter++;
                          // filesListingrichTextBox1.AppendText(element + "\n");
                           
                       }
                      
                   }
                   label1.Text = "Pliki mp3 w podanym folderze (" + counter.ToString() + ")";

                   
               }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }

    #region nasze klasy
    
    /// <summary>
    /// Obiekt klasy Mp3File byłby abstrakcyjną reprezentacją rzeczywistego pliku mp3 z dysku. Na nim odbywałyby się wszystkie
    /// operacje edycji tagów itp. Następnie zmiany zapisywane byłyby na dysk do pliku. Będzie agregowal obiekt Taglib (?) 
    /// Nie ogarnalem jeszcze tej biblio tak, zeby kumac jak działa
    /// 
    /// </summary>
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



    /// <summary>
    /// Obiekt klasy Directory byłby abstrakcyjną reprezentacją folderu podanego do programu. Szczerze nie jestem pewien
    /// czy takie obiekty będą nam potrzebne. Mogłyby trzymać różne informację, które byłyby nam potrzebne z folderu jak np ilość
    /// plików w. Poza tym załatwiłyby rozróżnienie folderu obiektów Mp3File, a samego pliku.
    /// </summary>
    public class OurDirectory
        {
            public OurDirectory(string Ppath) { }
            public OurDirectory() { }

            private int numberOfFilesIn;
        };



    /// <summary>
    ///  Obiekt tej klasy reprezentowałby użytkownika aplikacji, do niego po pierwszym użyciu
    ///  wczytywało by się, używane często ścieżki plików, zapisane templejty <see cref=" Template"/> nazewnictwa tagów itp.
    ///  Ta klasa NIE oznacza stworzenia kilku "kont" userów w programie. Klasa posiada:
    ///     - Std konstruktory
    ///     - Tablica używanych często ścieżek
    ///     - Tablica stworzonych templejtów nazewnictwa
    /// </summary>
    class AppUser
    {
        public AppUser() { }

        //loaded from file while opening app
        private string[] commonUsedDirs; //do podpowiedzi ostatnio uzywanych sciezek
        private Template[] userTagTemplates; // do wczytania zapisanych wczesniej templejtów tagów użytkownika + tworzone podczas programu tu sie zapisza
    };



    /// <summary>
    /// Obiekt tej klasy byłby elementem tablicy obiektu klasy Appuser <see cref="AppUser"/> uzywanych templejtów, 
    /// każdy obiekt typu template <see cref="Template"/> Posiada w sobie(na razie):
    ///     - Format szablonu
    /// </summary>
    class Template
    {
        public Template(string temp) { }
        public Template() { }

        private string format; // rzeczywisty templejt tzn string o wygladzie np " $Artist - $SongName  $Number ";
    };



    /// <summary>
    /// Statyczna klasa normalizator, działałaby na plikach(Mp3File?) i ich nazwach/tagach takich jak artysta czy cos.
    /// Wykonywałaby sprawdzenie literówek/małych różnic w nazwach /tagach konkretnych i według zalecen użytkownika Normalizowała je.
    /// </summary>
    static class Normalizator 
    {
        public static void /*string[]*/ findDifferences(Mp3File[] fileToSearch) { }
        public static void normalize(Mp3File[] filesToNormalize) { }
    
    };

    #endregion

}

