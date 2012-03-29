using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public varNames(string initType="default") 
        {
            if (initType.Equals("default"))
            {
                vArtist = "$artist";
                vGuestArtist = "$guest";
                vAlbum = "$album";
                vNum = "$num";
                vTrack = "$track";
            }
            else
            {
                vArtist = "ERROR";
                vGuestArtist = "$ERROR";
                vAlbum = "ERROR";
                vNum = "ERROR";
                vTrack = "ERROR";

            }




        }
        public string vArtist;
        public string vGuestArtist;
        public string vAlbum;
        public string vTrack;
        public string vNum;
 
    }
    public partial class TemplatesManager : Form
    {
        /// <summary>
        /// stdowy konstruktor
        /// </summary>
        public TemplatesManager()
        {
            InitializeComponent();
            variableDefs = new varNames("default");
            lookUpTemplatePreProcess();
        }
        /// <summary>
        /// Obiekt typu varNames, trzyma nazwy/definicje zmiennych managera
        /// </summary>
        private varNames variableDefs;



        private string lookUpTemplatePreProcess()
        {
            string tArtist = "David Bovie";
            string tAlbum = "Beautifull story";
            string tGuest = "Carter";
            string tNum = "1";
            string tTrack = "New Life";

            string templejt = textBox1.Text;
            string help = "";
            string afterRepl ="";
            CharEnumerator enumerator= templejt.GetEnumerator();
            CharEnumerator drugiEnum = templejt.GetEnumerator();

            if (templejt.Equals("")) return afterRepl;
            enumerator.MoveNext();
            for (int i = 0; i < templejt.Length; i++)
            {
                if (enumerator.Current.Equals('$'))
                {
                    while (!(enumerator.Current.Equals(' ')))
                    {
                        help += enumerator.Current;
                        i++;
                        if (i < templejt.Length) enumerator.MoveNext();
                        else break;
                    }

                    switch(help)
                    {
                        case "$artist":
                            afterRepl += tArtist;
                        break;

                        case "$album":
                            afterRepl += tAlbum;
                        break;
                        case "$guest":
                            afterRepl += tGuest;
                        break;
                        case "$num":
                            afterRepl += tNum;
                        break;
                        case "$track":
                            afterRepl += tTrack;
                        break;
                        default:
                        afterRepl += help;
                        break;
                    }
                }
                else
                {
                    afterRepl += enumerator.Current;
                    enumerator.MoveNext();
                }
            }
            return afterRepl;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lookUpLabel.Text = lookUpTemplatePreProcess();
        }


    }
}
