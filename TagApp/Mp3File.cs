using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TagApp
{

    /// <summary>
    /// Obiekt klasy Mp3File byłby abstrakcyjną reprezentacją rzeczywistego pliku mp3 z dysku. Na nim odbywałyby się wszystkie
    /// operacje edycji tagów itp. Następnie zmiany zapisywane byłyby na dysk do pliku. Będzie agregowal obiekt Taglib (?) 
    /// Nie ogarnalem jeszcze tej biblio tak, zeby kumac jak działa
    /// 
    /// </summary>
    class Mp3File
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
    }
}
