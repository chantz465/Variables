using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fristName = "";
            int age = 0;
            bool isMale = false;
            char likesBacon = 'Y';
            double howManyMilesOnCar = 0;
            decimal dogeWallet = 0.00m;


            age = 25;
            fristName = "Chance";
            isMale = true;
            howManyMilesOnCar = 125987.9;
            dogeWallet = 5884747.324978m;

            Console.WriteLine("The man is " + age + ", his name is " + fristName + ", does he like bacon " + likesBacon + ", is he a he " + isMale + ", his car has " + howManyMilesOnCar + " on it, and last but not least his doge wallet has " + dogeWallet);


        }
    }
}
