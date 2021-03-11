using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sayilar = { " 2", " 3", " 5", "10", "20" };  // Kişi Sayıları      
            Random gen = new Random();           
            double[] cakisma = { 0, 0, 0, 0, 0 }; // Kişi Sayısı İçin Ortalama Tutan liste
            int[,] cakismalar = new int[5, 15];
            for (int i=0;i<5;i++)
            {               
                for (int j = 0; j < 15; j++)
                {                   
                    int monday = 0, tuesday = 0, wednesday = 0, thursday = 0, friday = 0, saturday = 0, sunday = 0;
                    int x = 0;
                    for (int k = 0; k < Convert.ToInt32(sayilar[i]); k++)
                    {
                        int randomgun = gen.Next(0, 7); //Günleri temsil eden random sayılar
                        if (randomgun == 0) monday++;
                        else if (randomgun == 1) tuesday++;
                        else if (randomgun == 2) wednesday++;
                        else if (randomgun == 3) thursday++;
                        else if (randomgun == 4) friday++;
                        else if (randomgun == 5) saturday++;
                        else sunday++;
                    }
                    
                    foreach (var item in new int[] { monday, tuesday, wednesday, thursday, friday, saturday, sunday }) if (item > 0) x += item - 1; //Çakışma Kontrolü
                    cakismalar[i, j] = x;
                 
                }                                                          
            }
            Console.WriteLine("Deney Sayısı  1---2---3---4---5---6---7---8---9---10--11--12--13--14--15--Ort");
            Console.WriteLine();
            for (int u = 0; u < 5; u++)
            {
                Console.Write(sayilar[u]+" kişi için: ");
                for (int y = 0; y < 15; y++)
                {                    
                    if (cakismalar[u,y]>9)
                    {
                        Console.Write(cakismalar[u, y] + "- ");
                    }
                    else
                    {
                        Console.Write(cakismalar[u, y] + " - ");
                    }
                    cakisma[u] += cakismalar[u, y];
                }
                cakisma[u] = cakisma[u] / 15; //Ortalama Hesabı
                Console.Write(Math.Round(cakisma[u],2));
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}