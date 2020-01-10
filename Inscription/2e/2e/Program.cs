/*using System;*/

/*namespace _2e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}*/
/*REPONSES AUX QUESTIONS SUR LES FONCTIONS FICHE ..*/
/*namespace ex401
{
    class Program
    {
        public static int plusgrandnombre(int invit1, int invit2)
        {
            int saisie1 = int.Parse(Console.ReadLine());
            int saisie2 = int.Parse(Console.ReadLine());
            if (saisie1 > saisie2)
            {
                return saisie1;
            }
            else
            {
                return saisie2;
            }
        }
        public void Main (int[] args)
        {
            int var1, var2;
            var1 = plusgrandnombre("premier nombre");
            var2 = plusgrandnombre("deuxième nombre");
        }
    }
}*/
/*public static void afficheplusgransnombre(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine("entier a est le plus grand" + a);
    }
    else { Console.WriteLine("entier b plus grand" + b)}
}

public static int plusgransnombre(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else { return b; }
}*/
/*namespace ex3triangleisocele
{
    class Program
    {
        public static void Triangleisocele(int tailletab)
        {
            for (int j=1;j<=tailletab;j++)
            {
                for (int i=1;i<=j;i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("taille tableau");
            int taille = int.Parse(Console.ReadLine());
            Triangleisocele(taille);
        }
    }
}*/
/*namespace ex2somme
{
    class Program
    {
        public static int somme(int[] tab)
        {
            int somme = 0;
            foreach (int element in tab)
            {
                somme += element;
            }
            return somme;
        }
        public static void Main(string[] args)
        {
            int [] tab = new int[] { 1, 30, 5, 7, 9 };
            int res;
            res = somme(tab);
            Console.WriteLine(somme(tab));
        }
    }
}*/
/*namespace ex4factorielle
{
    class Program
    {
        public static void factorielle(int nombre)
        {
            int fact = 1;
            while (nombre != -1)
            {
                for (int i = 0; i <= nombre; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine(fact);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("nombre");
            int taille = int.Parse(Console.ReadLine());
            factorielle(taille);
        }
    }
}*/
/*namespace ex6moyenne
{
    class Program
    {
        public static double moyenne(int[] tab)
        {
            double somme = 0;
            double moyenne = 0;
            double compteur = 0;
            foreach (int element in tab)
            {
                somme += element;
                compteur++;
            }
            moyenne = somme / compteur;
            return moyenne;
        }
        public static void Main(string[] args)
        {
            int[] tab = new int[] { 1, 30, 5, 7, 9 };
            double res;
            res = moyenne(tab);
            Console.WriteLine(res);
        }
    }
}*/
/*correction
 * public static int moyennetableau(int[]tab)
        {
            int compteur = 0;
            int res = 0;
            foreach (int chiffre in tab) 
            {
                res += chiffre;
                compteur++;
            }
            return res / compteur;
        }


        static void Main(string[] args)
        {
            int[] t1 = new int[] { 7, 77, 777, 7777 };
            double moy = moyennetableau(t1);
        }
*/

//une variable locale est déclarée dans une fonction ou un main et sont utilisés uniquement dans ce bloc
//une variable globale, par contre, sera déclarée en dehors d'un bloc
//elle pourra être utilisée dans tous les blocs du programme
/*namespace ex7
{
    class Program
    {
        public static bool rechercheNombre(int[] tab,int val)
        {
            int compteur = 0;
            bool trouve = false;
            while ((compteur < tab.Length) & (!trouve))
            {
                if (tab[compteur] == val) trouve = true;
                else compteur++;
            }
            return trouve;
        }
        public static void Main(string[] args)
        {
            int[] t1 = new int[] { 1, 30, 5, 7, 9 };
            int v1 = 8;
            if (rechercheNombre(t1, v1))
            {
                Console.WriteLine(v1 + " est dans le tableau");
            }
            else
            {
                Console.WriteLine(v1 + "n'est pas dans le tableau");
            }
        }
    }
}*/
/*namespace ex8
{
    class Program
    {
        public static void insererNombre(string[] tab, string val,int position)
        {
            tab[position] = val;
        }
        public static void Main(string[] args)
        {
            string[] t1 = new string[] {"aa","bb"};
            int indice = 1;
            string val = "chaine";
            insererNombre(t1, val, indice);
            foreach(string elt in t1)
            {
                Console.WriteLine(elt);
            }
        }
    }
}*/
/*namespace ex10
{
    class Program
    {
        public static void inversion(int[,] tab)
        {
            for(int i = 0; i<tab.Length; i++)
            {
                for (int j = 0; j < tab.Length; j++)
                {
                    int tabij = tab[i, j];
                    int tabji = tab[j, i];
                    tab[i, j] = tabji;
                    tab[j, i] = tabij;
                }
            }
        }
        public static void Main(string[] args)
        {
            int[,] tab1 = new int[,] { {1,2},
                                       {6,2}};
            inversion(tab1);
            for(int i = 0; i < tab1.Length; i++)
            {
                for(int j =0;j<tab1.Length;j++)
            }
        }
    }
}*/
/*namespace ex7
{
    class Program
    {
        struct Coordonee{
            public double x;
            public double y;
            public override string ToString()
            {
                return x+"(x"+y+"y)";
            }
        }
        public static void Main(string[] args)
        {
            Coordonee p1 = new Coordonee();
            Coordonee p2 = new Coordonee();
            p1.x = 0;
            p1.y = 0;
            p2.x = 99;
            p2.y = 1;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}*/

//position libre = variable globale
//les variables globales à éviter+dur à maintenir
//le struc Smateriel = type tparc
/*
namespace Synthese
{
    class Program
    {
        const int MAX = 512;
        static int posLibre = 0;
        struct SMatériel
        {
            public string noSerie;
            public string modèle;
            public int quantité;
            public double prixHT;
        }
        static void menu()
        {
            Console.WriteLine("1.Ajouter un matériel dans le tableau.");
            Console.WriteLine("2.Supprimer un matériel (saisie index).");
            Console.WriteLine("3.Supprimer un matériel (saisie n° série).");
            Console.WriteLine("4.Modifier le prix selon le N° de séries.");
            Console.WriteLine("5.Lister à l'écran tous les matériels.");
            Console.WriteLine("6.Quitter.");
        }
        static SMatériel saisirMatériel()
        {
            SMatériel MatSaisi = new SMatériel();
            Console.WriteLine("n° de série ?");
            MatSaisi.noSerie = Console.ReadLine();
            Console.WriteLine("Modèle ?");
            MatSaisi.modèle = Console.ReadLine();
            Console.WriteLine("Nombre ?");
            MatSaisi.quantité = int.Parse(Console.ReadLine());
            Console.WriteLine("Prix ?");
            MatSaisi.prixHT = int.Parse(Console.ReadLine());
            return MatSaisi;
        }
        static bool AjouterUnMatériel(SMatériel[] tparc, SMatériel unMat)
        {
            if (posLibre < 512)
            {
                tparc[posLibre] = unMat;
                posLibre++;
                return true;
            }
            else
                return false;
        }
        static void afficherUnMateriel(SMatériel unMat)
        {
            Console.WriteLine("NoSerie :" + unMat.noSerie);
            Console.WriteLine("Modèle  :" + unMat.modèle);
            Console.WriteLine("Quantité:" + unMat.quantité);
            Console.WriteLine("Prix    :" + unMat.prixHT);
        }
        static void afficherLesMateriels(SMatériel[] parc)
        {
            for (int i = 0; i < posLibre; i++)
            {
                Console.WriteLine(parc[i]);
            }
        }

        static int rechercherParNSerie(SMatériel[] tparc,string unNoSerie)
        {
            bool trouve = false;
            int compteur = 0;
            while(!trouve || compteur < 512)
            {
                if (tparc[compteur].noSerie == unNoSerie) {

                    trouve = true;
                }
                compteur++;
            }
            if (trouve){
                return compteur--;
            }
            else { return -1; }
        }

        static bool supprimerParIndex(SMatériel[] tparc, int index)
        {
            if (index >= posLibre || index >= MAX)
                return false;
            else
            {
                for (int i = index; i < posLibre; i++)
                {
                    tparc[i] = tparc[i + 1];
                }
                posLibre--;
                return true;
            }
        }
        static bool supprimerParNSerie(SMatériel[]parc,string noSerie)
            {
                int indiceSaisie = rechercherParNSerie(parc, noSerie);
                if (indiceSaisie != -1)
                {
                    return supprimerParIndex(parc, poseMat);
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            SMatériel[] parc = new SMatériel[MAX];
            int choix = 0;
            int index = 0;
            do
            {
                menu();
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        {
                            SMatériel unMatSaisi = saisirMatériel();
                            bool ajoutOK = AjouterUnMatériel(parc, unMatSaisi);
                            if (ajoutOK)
                                Console.WriteLine("Ajout effectué");
                            else
                                Console.WriteLine("Ajout Impossible");
                        }; break;
                    case 2:
                        {
                            Console.WriteLine("Quel est ke NSerie que vous voulez supprimer?");
                        string noCherche = Console.ReadLine();
                        bool supprime = supprimerNSerie(parc, noCherche);
                        if (supprime)
                        {
                            Console.WriteLine("Suppression réussie"0);
                        }
                        else
                        {
                            Console.WriteLine("ce NSerie n'existe pas");
                        }
                        };break;
                    case 3:
                        {
                            Console.WriteLine("indice du materiel à supprimer");
                            index = int.Parse(Console.ReadLine());
                            if (supprimerParIndex(parc, index))
                                Console.WriteLine("Suppression par index effectué");
                            bool supOk = supprimerParIndex(parc, index);
                        };break;
                    case 4:
                        {
                            Console.WriteLine("Saisir numero de serie");
                            string nSerieAtrouve = Console.ReadLine();
                            int indiceConcerne = rechercherParNSerie(parc,nSerieAtrouve);
                            if (indiceConcerne == -1) { Console.WriteLine("impossible de modifier le numero de serie"); }
                            else { Console.WriteLine("Saisir un nouveau prix pour le matériel"); }
                            int nouveauPrix = int.Parse(Console.ReadLine());
                            parc[indiceConcerne].prixHT = nouveauPrix;
                        };break;
                    case 5:
                        {
                            afficherLesMateriels(parc);
                        };break;
                }

            } while (choix < 6);
        }
    }
}*/

//using Systel : le compilateur va rechercher dans la bibliothèque System: la classe Console avec ses méthode WriteLine et ReadLine
/*namespace ConsoleApp3
{
    class Program
    {
        static void premiereligne()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\t 1\t 2 \t 3 \t 4 \t 5 \t 6 \t 7 \t 8 \t 9 \t 10");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            Console.WriteLine("Choix de la multiplication");
            int choix = int.Parse(Console.ReadLine());
            premiereligne();
            for (b = 1; b < 11; b++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(b + "\t");
                Console.BackgroundColor = ConsoleColor.Black;
                for (a = 1; a < 11; a++)
                {
                    int c = a * b;
                    if (b == choix)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(c + "\t");
                    }
                    else
                    {
                        Console.Write(c + "\t");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {

            string pathFile = @"C:\Users\Raphaël\source\repos\2e\2e.sln";


            string[] ligneSuivante = new[] { "la grnade méchante écriture" };
            // voici une  manière d'écrire dans un fichier qui a fonctionné ou pas'
            //comment le vérifier
            File.WriteAllLines(pathFile, ligneSuivante);

            string ligneAEcrire = "Ah bon, Sophia Arma était à Lannion le 18 décembre!!";
            List<string> lignesAEcrire = new List<string>();
            lignesAEcrire.Add(ligneAEcrire);
            ligneAEcrire = "Another look at memory";
            lignesAEcrire.Add(ligneAEcrire);
            // voici une  manière d'écrire dans un fichier qui a fonctionné ou pas'
            //comment le vérifier
            File.AppendAllLines(pathFile, lignesAEcrire);

        }
    }
}
