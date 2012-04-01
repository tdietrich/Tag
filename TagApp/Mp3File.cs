using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagLib;

namespace TagApp
{

    /// <summary>
    /// Obiekt klasy Mp3File byłby abstrakcyjną reprezentacją rzeczywistego pliku mp3 z dysku. Na nim odbywałyby się wszystkie
    /// operacje edycji tagów itp. Następnie zmiany zapisywane byłyby na dysk do pliku. Będzie agregowal obiekt Taglib (?) 
    /// Nie ogarnalem jeszcze tej biblio tak, zeby kumac jak działa
    /// 
    /// </summary>
    /// 

    /// <summary>Typ wyliczeniowy ułatwiający numerowanie wszelkich tablich związanych z tagami. Numeracja od zera. Jako ułatwienie pola posortowane alfabetycznie. </summary>

    enum TagFields : short
    {
        Album,
        AlbumArtist,
        Artist,
        Comment,
        Discnumber,
        Filename,
        Genre,
        Tag,
        Title,
        Track,
        Path,
        Year  
    }



    class Mp3File
    {
        public Mp3File(string Ppath) {
            TagLib.File plik = TagLib.File.Create(Ppath);

        }

        public Mp3File()
        {

        }

        private string path;
        private bool edited;
        private bool savedChanges;
    }
}
