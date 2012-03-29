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
        public Template(string temp) 
        {
            name = "Unknown";
            templateSchema = temp;
            usageFrequency = 0;
        }
        public Template() { }
        private string name;
        private string templateSchema; // rzeczywisty templejt tzn string o wygladzie np " $Artist - $SongName  $Number ";
        private int usageFrequency;
        
        
        public string TemplateSchema { get; set; }
        public string Name { get; set; }
        public int UsageFrequency { get; set; }
       


    }
}
