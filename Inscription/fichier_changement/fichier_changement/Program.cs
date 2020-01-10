using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
/*
namespace ConsoleApp64
{
   class Program
   {
       static void Main(string[] args)
       {
           // Création du chronomètre.
           Stopwatch stopwatch = new Stopwatch();
           Stopwatch stopwatch1 = new Stopwatch();
           // Démarrage du chronomètre.
           stopwatch.Start();

           string pathFile = @"C:\Users\Raphaël\source\repos\fichier_changement\fichierWriteV1.txt";

           Random aleatoire = new Random();
           stopwatch1.Start();
           string[] ligneSuivante = new[] { "résultat: \n" };
           // voici une  manière d'écrire dans un fichier qui a fonctionné ou pas'
           //comment le vérifier
           File.WriteAllLines(pathFile, ligneSuivante); //ecrase le contenu du fichier
           List<string> lignesAEcrire = new List<string>();
           for (int i=0; i < 1000; i++)
           {
               int entierUnChiffre1 = aleatoire.Next(1,6);
               int entierUnChiffre2 = aleatoire.Next(1000);
               int entierUnChiffre3 = aleatoire.Next(1000);
               int entierUnChiffre4 = aleatoire.Next(1000);
               string ligneAEcrire = "Produit" + entierUnChiffre1 + ";" + entierUnChiffre2 + ";" + entierUnChiffre3 + ";" + entierUnChiffre4;
               lignesAEcrire.Add(ligneAEcrire);
           }
           stopwatch1.Stop();
           File.AppendAllLines(pathFile, lignesAEcrire);
           // Arrêt du chronomètre.
           stopwatch.Stop();
           // IHM.
           double chrono1 = stopwatch1.Elapsed.TotalSeconds;
           double chrono = stopwatch.Elapsed.TotalSeconds;

           double pourcentage = chrono1*100 / (chrono);

           Console.WriteLine("Durée d'écriture: {0}", stopwatch1.Elapsed.TotalSeconds);
           Console.WriteLine("Durée d'exécution: {0}", stopwatch.Elapsed.TotalSeconds);
           Console.WriteLine(pourcentage+"%");
           Console.ReadLine();
       }
   }
}

*/
﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] produit = new string[] { "-", "-", "-", "-", "-" };
            int[] nombre = new int[] { 0, 0, 0, 0, 0 };
            string[] lines = File.ReadAllLines(@"C:\Users\Raphaël\source\repos\fichier_changement\fichierWriteV1.txt"); //affectation de la table par le contenu du fichier
            foreach (string line in lines) //parcours de chaque élements et la table
            {
                int x;
                string[] parts = line.Split(';'); //séparation de la chaine de caractere représentant la ligne en un tableau de chaine
                x = Array.IndexOf(produit, parts[0]); //recherche de l'indice du produit à l'emplacement 0 de ka table part
                if (x == -1)
                {//le produit n'existe pas dans la table produit car il n'a pas été mentionné dans aucune ligne 
                    x = Array.IndexOf(produit, "-"); //recherche de l'emplacement ou mettre le produit pas encore rencontré
                    if (x > -1)
                    {
                        produit[x] = parts[0]; //affectation du produit au premier indice
                        nombre[x] = 1; //affectation du nombre de fois ou le produit est présent
                    }
                } //le produit a déjà été rencontré,incrémentation ddu compteur correspondant
                else nombre[x]++;

            }
            Array.Sort(produit.ToArray(), nombre); //trie du tableau nombre en fonction des valeurs de la table produit (les valeurs de la table produits sont des clés d'un index remises dans l'ordre
            Array.Sort(produit); //tri du tableau produit
            for (int i = 0; i < 5; i++)
            { Console.WriteLine("Le {0} est présent {1} fois", produit[i], nombre[i]); }

            Console.ReadKey();

        }
    }
}
