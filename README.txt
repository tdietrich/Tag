﻿****************README FILE*******************
v0.0.3 R \
////30.03.2012

+++++++++++++++++++++++++++BUGS++++++++++++++++++++++++++++++
+Brak wczytywania plików, jeśli prawa do pliku są "niejasne"+
+Tzn np. gdy przy przenoszeniu plików z innego systemu np XP+
+na Win 7 zmieniaja sie prawa i teoretycznie mozemy plik otw+
+ale formalnie system widzi ze nie mamy praw - DZIWNA SPRAWA+
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

MAIN UPDATES:
- Stworzone pliki "commons.txt" i "userTemplates.txt" przetrzymujące odpowiednio - czesto uzywane sciezki do wyszuk. i templejty nazewnictwa.
- Metody obsługi sprawdzania czy istnieją te pliki i tworzenia ich jeżeli ich nie ma.
- Metody zapisu wyszukiwanych ścieżek do pliku Commons przy kliknieciu dodaj folder.
- Dodane Okno TemplatesManager
- Interfejs TemplateManagera
- Dodana Klasa statyczna TemplatesParser
- Wstępna metoda parsowania lookup (zbugowana fchuj, praca nad tym w toku)
- Update klasy Template
- Mało istotne zmiany w kodzie - m.in wywalenie zmiennych lokalnych nieuzywanych, format kodu

MAIN DELETES:
- NONE


KNOWN BUGS:
Brak wczytywania plików, jeśli prawa do pliku są "niejasne" Tzn np. gdy przy przenoszeniu plików z innego systemu np XP + a Win 7 zmieniaja sie prawa i teoretycznie mozemy plik otw. ale formalnie system widzi ze nie mamy praw - DZIWNA SPRAWA


TODO:
- wyodrebnic szukanie do nowego watku
- Przypisac progres na progress barze do wyszukiwania - jak bedziemy juz umieli odczytac tagi, to  np.
(liczba_plikowmp3_z_ktorych_zczytalismy)/(wszystkie do zczytania)*100%


========================================================================================================================
v0.0.2 R \
////18.03.2012

+++++++++++++++++++++++++++BUGS++++++++++++++++++++++++++++++
+Brak wczytywania plików, jeśli prawa do pliku są "niejasne"+
+Tzn np. gdy przy przenoszeniu plików z innego systemu np XP+
+na Win 7 zmieniaja sie prawa i teoretycznie mozemy plik otw+
+ale formalnie system widzi ze nie mamy praw - DZIWNA SPRAWA+
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

MAIN UPDATES:
- Dodana obsługa ładowania tagów plików do mainGrida
- Obsługa ładowania folderów i pojedynczego pliku
- Dodane Okno O Programie,
- Nowe info w Assembly Info
- Toolbar test dodany
- Dodana obsługa opcji "Dodaj plik Ctrl+O" w menu strip górnym
- Ładowanie plików do listy zebrane w funkcje
- Usystematyzowane kolumny w mainGridzie

MAIN DELETES:
- Usuniety Rich Text Box wypisujacy zaladowane pliki

TODO:
- wyodrebnic szukanie do nowego watku
- Przypisac progres na progress barze do wyszukiwania - jak bedziemy juz umieli odczytac tagi, to  np.
(liczba_plikowmp3_z_ktorych_zczytalismy)/(wszystkie do zczytania)*100%

========================================================================================================================
v0.0.1 R \
////14.03.2012
- Dodana obsluga szukania w podfolderach
- Wyswietlanie liczby plikow mp3 znalezionych
TODO:
- wyodrebnic szukanie do nowego watku
- Przypisac progres na progress barze do wyszukiwania - jak bedziemy juz umieli odczytac tagi, to  np.
(liczba_plikowmp3_z_ktorych_zczytalismy)/(wszystkie do zczytania)*100%

