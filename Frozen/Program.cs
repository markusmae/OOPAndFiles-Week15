using System;
using System.IO;
using System.Collections.Generic;


namespace Frozen
{
    class Program
    {
        class WishList
        {
            string id;
            string wish;

            public WishList(string _id, string _wish)
            {
                id = _id;
                wish = _wish;
            }

            public string Id
            {
                get { return id; }
            }

            public string Wish
            {
                get { return wish; }
            }

        }
        static void Main(string[] args)
        {
            List<WishList> Wishes = new List<WishList>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                WishList newWish = new WishList(tempArray[0], tempArray[1]);
                Wishes.Add(newWish);
            }

            foreach (WishList wishFromList in Wishes)
            {
                Console.WriteLine($"{wishFromList.Id} wants {wishFromList.Wish} for Chrsitmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\--\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

    }
}
