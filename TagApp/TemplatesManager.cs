using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace TagApp
{
    /// <summary>
    /// Struktura przechowująca nazwy obsługiwanych stringów jako zmienne przez Edytor Tagów.
    /// tzn np. vArtist musi być takim łańcuchem pod który TemplateManager będzie wrzucał w przyszlosci nazwy artystów
    /// np. vArtist = "$artist" - dosłownie
    /// </summary>
    public struct varNames
    {
        /// <summary>
        /// Konstruktor inicjujący pola w zależności od parametru init. W przyszłosci, w konstruktorze, będzie możliwa
        /// Obsługa wielu "setów" zmiennych. Teraz defaultowy to $artist, $album itp. Ale mogą być też inne
        /// </summary>
        /// <param name="initType">STD UŻYWAć atrybutu "default" Okresla według jakich ustawien zainicjalizować akceptowalne nazwy zmiennych.</param>
        public varNames(string initType = "default")
        {
            if (initType.Equals("default"))
            {
                vArtist = "$artist";
                vGuestArtist = "$guest";
                vAlbum = "$album";
                vNum = "$num";
                vTrack = "$track";
                vYear = "$year";
            }
            else
            {
                vArtist = "ERROR";
                vGuestArtist = "$ERROR";
                vAlbum = "ERROR";
                vNum = "ERROR";
                vTrack = "ERROR";
                vYear = "ERROR";

            }




        }
        public string vArtist;
        public string vGuestArtist;
        public string vAlbum;
        public string vTrack;
        public string vNum;
        public string vYear;

    }

    public partial class TemplatesManager : Form
    {
        /// <summary>
        /// Standardowy konstruktor, ale duzo sie dzieje
        /// </summary>
        public TemplatesManager()
        {

            Templates = new List<Template>();
            InitializeComponent();

            
            variableDefs = new varNames("default");
            TemplateParser.buffer = ""; //inicjalizacja pola kalsy statycznej
            //podwojone sprawdzenie właściwie bo MainWnd tez sprawdza
            if (MainWindow.searchForTagAppFile(MainWindow.FileNames.templatesFile))
            {
                UpdateTemplateList();
            }
        }

        /// <summary>
        /// Updates Data in listbox due to List Templates
        /// </summary>
        public void UpdateTemplateList()
        {
            foreach (Template tmp in Templates)
            {
                //dodajemy item do listboxa
                listBox1.Items.Add(tmp.Name);
            }

        }
        /// <summary>
        /// Lista wczytanych/posiadaych przez usera templejtów
        /// </summary>
        private List<Template> Templates;
        /// <summary>
        /// Obiekt typu varNames, trzyma nazwy/definicje zmiennych managera
        /// </summary>
        private varNames variableDefs;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lookUpLabel.Text = TemplateParser.parseTemplate(textBox1.Text, variableDefs);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aktywowanie taba edycja
            tabControl1.SelectTab(1);
            //zebranie indexu wybranego z listboxa
            int wybrany = this.listBox1.SelectedIndex;
            //wybranie po indeksie z listy templejtów załadowanych wczesniej z pliku
            Template wybranyTemplejt = Templates.ElementAt(wybrany);
            //wpisujemy do txtboxa name
            textBox3.Text = wybranyTemplejt.Name;
            //wpisujemy schemat
            textBox4.Text = wybranyTemplejt.TemplateSchema;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //na zmiane textu w boxie, parsujemy  templejt
            lookUpLabel2.Text = TemplateParser.parseTemplate(textBox4.Text, variableDefs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("") && !textBox3.Text.Equals(""))
            {
                Template doZapisu = new Template(textBox3.Text);
                doZapisu.Name = textBox2.Text;
                doZapisu.UsageFrequency = 0;

                Templates.Add(doZapisu);
                UpdateTemplateList();
            }

        }

        //Wykonaj Save jezeli zamykamy forme
        private void TemplatesManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SerializeAndSave(MainWindow.FileNames.templatesFile, Templates);

        }

   
    }
}
