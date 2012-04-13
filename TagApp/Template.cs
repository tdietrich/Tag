using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace TagApp
{
    /// <summary>
    /// każdy obiekt typu template <see cref="Template"/> Posiada w sobie(na razie):
    ///     - Format szablonu
    /// </summary>
    [Serializable]
    class Template
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="temp">schema</param>
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

        // Serialize and Save all Template list
        private void SerializeAndSave(string fileName, Template templejt)
        {
            System.IO.Stream stream = System.IO.File.Open(fileName, System.IO.FileMode.Truncate);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, templejt);
            stream.Close();
        }

        private Template DeserializeAndLoad(string filename)
        {
            Template templejt = new Template();
            System.IO.Stream stream = System.IO.File.Open(filename, System.IO.FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            if (stream.Length != 0) templejt = (Template)bFormatter.Deserialize(stream);
            stream.Close();
            return templejt;
        }
        public string TemplateSchema { get; set; }
        public string Name { get; set; }
        public int UsageFrequency { get; set; }
       


    }
}
