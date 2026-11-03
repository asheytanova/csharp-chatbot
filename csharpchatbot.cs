using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpchatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Introduction + How is the users' day
            Console.WriteLine("Hello I am a chatbot, has your day been good or bad? \n");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            if (userInput == "good")
            {
                Console.WriteLine("That's great to hear! What made your day good? \n");
            }
            else if (userInput == "bad")
            {
                Console.WriteLine("I'm sorry to hear that, I hope the rest of your day gets better! \n");
            }
            else
            {
                Console.WriteLine("That isnt good or bad but I hope your day is going well! \n");
            }

            Console.WriteLine();

            //Users' name

            Console.WriteLine("What is your name? \n");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name + "!");

            Console.WriteLine();

            //Users' favourite colour
            Console.WriteLine("What is your favourite colour," + name + "? \n");
            string favColour = Console.ReadLine();
            favColour = favColour.ToLower();

            if (favColour == "purple")
            {
                Console.WriteLine("That's my favourite colour too!\n");
            }
            else
            {
                Console.WriteLine("Nice!");
            }

            Console.WriteLine();

            //Users' favourite food
            Console.WriteLine("What is your favourite food, " + name + "? \n");
            string favFood = Console.ReadLine();
            favFood = favFood.ToLower();

            if (favFood == "pizza")
            {
                Console.WriteLine("That's my favourite food too! \n");
            }
            else
            {
                Console.WriteLine("Sounds delicious! \n");
            }

            Console.WriteLine();

            //Users' favourite movie
            Console.WriteLine("What is your favourite movie, " + name + "? \n");
            string favMovie = Console.ReadLine();
            favMovie = favMovie.ToLower();

            if (favMovie == "ecanto")
            {
                Console.WriteLine("That's my favourite movie too! \n");
            }
            else
            {
                Console.WriteLine("That's a great movie too! \n");
            }

            Console.WriteLine();

            //Users' favourite season
            Console.WriteLine("What is your favourite season, " + name + "? \n");
            string favSeason = Console.ReadLine();
            favSeason = favSeason.ToLower();

            if (favSeason == "winter")
            {
                Console.WriteLine("That's my favourite season too! \n");
            }
            else if (favSeason == "spring")
            {
                Console.WriteLine("Spring is beautiful! \n");
            }
            else if(favSeason == "summer")
            {
                Console.WriteLine("Summer is great for the beach! \n");
            }
            else if (favSeason == "autumn")
            {
                Console.WriteLine("Autumn is a beautiful season! \n");
            }
            else
            {
                Console.WriteLine("That isn't a season! Try again! \n");
                bool x = false;
                while (x == false)
                {
                    Console.WriteLine("What is your favourite season, " + name + "? \n");
                    favSeason = Console.ReadLine();
                    favSeason = favSeason.ToLower();
                    if (favSeason == "winter")
                    {
                        Console.WriteLine("That's my favourite season too! \n");
                        x = true;
                    }
                    else if (favSeason == "spring")
                    {
                        Console.WriteLine("Spring is beautiful! \n");
                        x = true;
                    }
                    else if (favSeason == "summer")
                    {
                        Console.WriteLine("Summer is great for the beach! \n");
                        x = true;
                    }
                    else if (favSeason == "autumn")
                    {
                        Console.WriteLine("Autumn is a beautiful season! \n");
                        x = true;
                    }
                    else
                    {
                        Console.WriteLine("That isn't a season! Try again! \n");
                    }
                }
                Console.WriteLine("It was nice talking to you, " + name + ", these are all my questions! I hope you have a great day! \n");
            }          
        }   
    }
}
