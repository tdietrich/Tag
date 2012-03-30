using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TagApp
{

    static class TemplateParser
    {
        /// <summary>
        /// Trzyma informacje o bieżąco przerabianym kawałku templejta
        /// </summary>
        static public string buffer;
        /// <summary>
        /// Czyści bufor - buffer
        /// </summary>
        static public void flush()
        { 
            buffer = "";
        }
        /// <summary>
        /// Parsuje templejt do podglądu, nie pobiera jako argument tagów - na sztywno wpisuje
        /// </summary>
        /// <param name="template">schemat templejta</param>
        /// <param name="definitions">definicje zmiennych/keywordów (struktura)</param>
        /// <returns>Zparsowany templejt wypełnionymi danymi z tags</returns>
        static public string parseTemplate(string template, varNames definitions)
        {
            string afterRepl = "";
            bool endOfString = false;
                    string tArtist = "David Bovie";
                    string tAlbum = "Beautifull story";
                    string tGuest = "Carter";
                    string tNum = "1";
                    string tTrack = "New Life";

                    string templejt = template;

                    //ustawienie enumeratorów - będą chodzić po stringu
                    CharEnumerator enumerator = templejt.GetEnumerator();
                    CharEnumerator drugiEnum = templejt.GetEnumerator();

                    //jezeli pusty nie zaczynaj
                    if (templejt.Equals("")) return afterRepl;
                    
                    //1 krok na 1 znak
                    enumerator.MoveNext();
                    

                    for (int i = 0; i < templejt.Length; i++)
                    {
                        while (i < templejt.Length)
                        {
                            if (enumerator.Current.Equals('$'))
                            {
                                while (!(enumerator.Current.Equals(' ')))
                                {
                                    //wpisano $ zliczaj dalsze znaki zeby skumac czy to keyword
                                    buffer += enumerator.Current;
                                    i++;
                                    if (i < templejt.Length)
                                    {
                                        enumerator.MoveNext();
                                    }
                                    else
                                    {
                                        endOfString = true;
                                        break;
                                    }
                                }

                                switch (buffer)
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
                                        afterRepl += buffer;

                                        break;
                                }
                                i++;
                                flush();
                            }
                            else
                            {
                                afterRepl += enumerator.Current;
                                
                                enumerator.MoveNext();
                                i++;
                            }
                        }
                    }

            return afterRepl;
        }
        /// <summary>
        /// Parsuje templejt.
        /// </summary>
        /// <param name="template">schemat templejta</param>
        /// <param name="definitions">definicje zmiennych/keywordów (struktura)</param>
        /// <param name="tags">tagi do podmiany za keywordsy</param>
        /// <returns>Pełny string z pozamienianymi keywordsami</returns>
        static public string parseTemplate(string template, varNames definitions, string[] tags)
        {
            string afterRepl = "";
            bool dollarFound = false;

                    string tArtist = "David Bovie";
                    string tAlbum = "Beautifull story";
                    string tGuest = "Carter";
                    string tNum = "1";
                    string tTrack = "New Life";

                    string templejt = template;

                    //ustawienie enumeratorów - będą chodzić po stringu
                    CharEnumerator enumerator = templejt.GetEnumerator();
                    CharEnumerator drugiEnum = templejt.GetEnumerator();

                    //jezeli pusty nie zaczynaj
                    if (templejt.Equals("")) return afterRepl;

                    //1 krok na 1 znak
                    enumerator.MoveNext();


                    for (int i = 0; i < templejt.Length; i++)
                    {
                        if (enumerator.Current.Equals('$') || buffer.Contains('$'))
                        {
                            dollarFound = true;
                            while (!(enumerator.Current.Equals(' ')))
                            {
                                //wpisano $ zliczaj dalsze znaki zeby skumac czy to keyword
                                buffer += enumerator.Current;
                                i++;
                                if (i < templejt.Length) enumerator.MoveNext();
                                else break;
                            }

                            switch (buffer)
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
                                    afterRepl += buffer;
                                    break;
                            }
                        }
                        else
                        {
                            dollarFound = false;
                            afterRepl += enumerator.Current;
                            enumerator.MoveNext();
                        }
       
            }

            return afterRepl;
        }
    }
}
