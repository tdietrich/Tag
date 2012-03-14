using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TagApp
{
    /// <summary>
    /// Obiekt klasy Directory byłby abstrakcyjną reprezentacją folderu podanego do programu. Szczerze nie jestem pewien
    /// czy takie obiekty będą nam potrzebne. Mogłyby trzymać różne informację, które byłyby nam potrzebne z folderu jak np ilość
    /// plików w. Poza tym załatwiłyby rozróżnienie folderu obiektów Mp3File, a samego pliku.
    /// </summary>
    class OurDirectory
    {
        public OurDirectory(string Ppath) { }
        public OurDirectory() { }

        private int numberOfFilesIn;

    }
}
