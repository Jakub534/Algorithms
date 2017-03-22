using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List {

    class Lista {
        public int wartosc;
        public Lista next;
    }

    class Program {

        /*
         Zadanie 1
            -----------
            Dla listy jednokierunkowej przechowuj�cej elementy okre�lonego typu np. liczby ca�kowite napisz funkcje wykonuj�ce nast�puj�ce operacje:
            � dodawanie elementu na pocz�tek listy,
            � wy�wietlanie listy,
            � usuwanie elementu z przodu listy,
            - liczenie d�ugo�ci listy,
            - dodawanie elementu do listy z zachowaniem porz�dku
            - wyszukiwanie elementu listy
         */

        static void DodajElement(ref Lista l, int val) {

            Lista tmp = l;
            l = new Lista();
            l.wartosc = val;

            l.next = tmp;

        }

        static void Wy�wietlListe(Lista l) {

            Console.WriteLine(l.wartosc);

            if (l.next != null) {
                Wy�wietlListe(l.next);
            }
        }

        static void Usu�Prz�d(ref Lista l) {

            l = l.next;
            
        }

        static int D�ugo��Listy(Lista l) {
			if(l.next != null) {
                return 1 + D�ugo��Listy(l.next);
			}

            return 1;
		}

        static void DodajNaKo�cu(Lista l, int wartosc) {

            if (l.next != null) {
                DodajNaKo�cu(l.next, wartosc);
            } 
            else {
                l.next = new Lista();
                l.next.wartosc = wartosc;
            }

        }


        static bool SzukajElementu(Lista l, int szukana) {

            if (l.wartosc == szukana) {
                return true;
            }
            else {
                if (l.next != null) {
                    return SzukajElementu(l.next, szukana);
                }
            }

            return false;

        }





        static void Main(string[] args) {

            Lista lista = new Lista();
            lista.wartosc = 1;
            lista.next = new Lista();
            lista.next.wartosc = 3;

            Console.WriteLine("--------------");
            Wy�wietlListe(lista);

            Console.WriteLine("--------------");
            DodajElement(ref lista, 40);
            Wy�wietlListe(lista);

            Console.WriteLine("--------------");
            Usu�Prz�d(ref lista);
            Wy�wietlListe(lista);

            Console.WriteLine("--------------");
            Console.WriteLine("D�ugo�� listy: {0}", D�ugo��Listy(lista));

            Console.WriteLine("--------------");
            DodajNaKo�cu(lista, 230);
            Wy�wietlListe(lista);

            Console.WriteLine("--------------");
            Console.WriteLine("Szukaj 3: {0}", SzukajElementu(lista, 3));


            Console.ReadKey();



           
        }
    }
}
