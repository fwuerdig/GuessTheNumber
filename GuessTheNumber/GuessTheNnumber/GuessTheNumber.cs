using System;
using System.Security.Cryptography.X509Certificates;

namespace GuessTheNumber
{
    public class GuessTheNumber
    {
        int number;
        int max;

        public GuessTheNumber()
        {
            Random random = new Random();
            max = 100;
            number = Math.Abs(random.Next()) % (max + 1);
        }

        public void play()
        {
            while (true)
            {
                int move = Convert.ToInt32(Console.ReadLine());
                if (move > number)
                    Console.WriteLine("Your number is too big!");
                else if (move < number)
                    Console.WriteLine("Your number is too small!");
                else
                    Console.WriteLine("YOU GOT IT BRO!!!");                  
                    
            }               

        }
        static void Main(string[] args)
        {
            GuessTheNumber guessGame = new GuessTheNumber();
            Console.WriteLine("Welcome to my game. Try and guess the number. It´s between 0 and " 
                + guessGame.max + " inclusive. Just put a number to begin");
            guessGame.play();
        }
    }
}
