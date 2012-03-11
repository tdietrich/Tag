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

    #region nasze klasy
    
    /// <summary>
    /// Obiekt klasy Mp3File byłby abstrakcyjną reprezentacją rzeczywistego pliku mp3 z dysku. Na nim odbywałyby się wszystkie
    /// operacje edycji tagów itp. Następnie zmiany zapisywane byłyby na dysk do pliku,
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
    /// plików w. Poza tym załatwiłyby rozróżnienie folderu obiektów Mp3File, a samego pliku. DO PRZEDYSKUTOWANIA
    /// </summary>
    public class Directory
        {
            public Directory(string Ppath) { }
            public Directory() { }

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
        private Template[] userTagTemplates; // do wczytania zapisanych wczesniej templejtów tagów użytkownika
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
    #endregion

}

