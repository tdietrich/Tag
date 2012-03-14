using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TagApp
{
    /// <summary>
    /// każdy obiekt typu template <see cref="Template"/> Posiada w sobie(na razie):
    ///     - Format szablonu
    /// </summary>
    class Template
    {
        public Template(string temp) { }
        public Template() { }

        private string format; // rzeczywisty templejt tzn string o wygladzie np " $Artist - $SongName  $Number ";




    }
}
