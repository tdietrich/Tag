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
    /// Klasa dziedzicząca po Formie. Nowe okno, w którym zawarte będą wszystkie opcje. Pojawia się po 
    /// kliknięciu elementu Narzędzia -> Opcje w głównym menu.
    /// </summary>
   
    public partial class Opcje : Form
    {

        /// <sumary>
        /// Tablica wartości boolowskich określająca, które kolumny w głównej siatce są widoczne (true - widoczne, false - niewidoczne)
        /// </summary>
        public static bool[] tagVisible;
   
        public Opcje()
        {
            InitializeComponent();

            tagVisible = new bool[Enum.GetValues(typeof(TagFields)).Length;         // tworzenie tablicy o długości równej liczbie elementów w typie wyliczeniowym TagFields
        }
    }
}
