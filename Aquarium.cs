using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace Mukha.Aquarium
{
    class Aquarium
    {
        int maxCells { get; set; }
        static int width = Convert.ToInt32(ConfigurationManager.AppSettings.Get("width"));
        static int height = Convert.ToInt32(ConfigurationManager.AppSettings.Get("height"));
        static int countStones = Convert.ToInt32(ConfigurationManager.AppSettings.Get("countStones"));
        static int countHerbs = Convert.ToInt32(ConfigurationManager.AppSettings.Get("countHerbs"));
        static int countFishHerbs = Convert.ToInt32(ConfigurationManager.AppSettings.Get("countFishHerbs"));
        static int countFishPredators = Convert.ToInt32(ConfigurationManager.AppSettings.Get("countFishPredators"));
        Stone[] arrayStones = new Stone[countStones];
        Herb[] arrayHerbs = new Herb[countHerbs];
        FishHerb[] arrayFishHerbs = new FishHerb[countFishHerbs];
        FishPredator[] arrayFishPredators = new FishPredator[countFishPredators];
        public static string[,] arrayCells = new string[width, height];
        public static void AddHerb()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, width);
            int b = rnd.Next(0, height);
            if (Cell.IsEmpty(a,b))
            {
                Aquarium.arrayCells[a, b] = "G";
            }
            else
            {
                AddHerb();
            }
        }
        public static void AddFishHerb()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, width);
            int b = rnd.Next(0, height);
            if (Cell.IsEmpty(a, b))
            {
                Aquarium.arrayCells[a, b] = "HF1";
            }
            else
            {
                AddFishHerb();
            }
        }
        public static void AddFishPredator()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, width);
            int b = rnd.Next(0, height);
            if (Cell.IsEmpty(a, b))
            {
                Aquarium.arrayCells[a, b] = "PM2";
            }
            else
            {
                AddFishPredator();
            }
        }
        public static void AddStone()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, width);
            int b = rnd.Next(0, height);
            if (Cell.IsEmpty(a, b))
            {
                Aquarium.arrayCells[a, b] = "X";
            }
            else
            {
                AddStone();
            }
        }
        public static void ViewAquarium()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Aquarium.arrayCells[i, j]= "|";
                }
            }
            for (int i = 0; i <countHerbs; i++)
            {
                AddHerb();
            }
            for (int i = 0; i < countFishHerbs; i++)
            {
                AddFishHerb();
            }
            for (int i = 0; i < countFishPredators; i++)
            {
                AddFishPredator();
            }
            for (int i = 0; i < countStones; i++)
            {
                AddStone();
            }
            for (int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Console.Write($"{Aquarium.arrayCells[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
