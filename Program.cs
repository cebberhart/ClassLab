using System;

namespace StudentListLab10
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine();
            string[] studentNames = new string[11];
            studentNames[1] = "Ramone Lynch";
            studentNames[2] = "Antonio Manzari";
            studentNames[3] = "Huy Phan";
            studentNames[4] = "Marjorie Patton";
            studentNames[5] = "Calyn Greene";
            studentNames[6] = "Rick Magdaleno";
            studentNames[7] = "Cullin Flynn";
            studentNames[8] = "Jame Mitchell";
            studentNames[9] = "Richard Moss";
            studentNames[10] = "Cordero Ebberhart";

            string[] homeTowns = new string[11];
            homeTowns[1] = "Fort Lauderdale, FL";
            homeTowns[2] = "Beverly Hills, MI";
            homeTowns[3] = "Lansing, MI";
            homeTowns[4] = "Detroit, MI";
            homeTowns[5] = "Portage, MI";
            homeTowns[6] = "Gillbert, AZ";
            homeTowns[7] = "Fowlerville, MI";
            homeTowns[8] = "Yap, FSM";
            homeTowns[9] = "Canton, MI";
            homeTowns[10] = "Berkley, MI";

            string[] favoriteFoods = new string[11];
            favoriteFoods[1] = "Chicken Soup";
            favoriteFoods[2] = "Focaccia Barese";
            favoriteFoods[3] = "Korean BBQ";
            favoriteFoods[4] = "Lasagna";
            favoriteFoods[5] = "Mac and Cheese";
            favoriteFoods[6] = "Hamburger";
            favoriteFoods[7] = "Pad Thai";
            favoriteFoods[8] = "Katsu";
            favoriteFoods[9] = "Sushi";
            favoriteFoods[10] = "BBQ";


            Console.WriteLine("Welcome to the DevBuild App, Enter a number between 1 - 10");
            bool goOn = true;
            while (goOn)
            {
                //DisplayMainMenu();
                int answer = Convert.ToInt32(Console.ReadLine());


                if (answer >= 1 && answer <= 10)
                {
                    bool choiceOne = true;

                    Console.WriteLine($"Student {answer} is {studentNames[answer]}. Want to know about favorite food? Type in hometown or favorite food");
                    while (choiceOne)
                    {
                        string userChoice = Console.ReadLine().ToLower();

                        if (userChoice == "hometown")
                        {
                            Console.WriteLine($"is from {homeTowns[answer]}");
                            string foodChoice = Console.ReadLine().ToLower();
                            if (foodChoice == "y")
                            {
                                Console.WriteLine($"favorite is {favoriteFoods[answer]}");
                                choiceOne = false;
                            }
                            else if (foodChoice == "n")
                            {
                                choiceOne = false;
                            }
                            else
                            {
                                Console.WriteLine("I did not understand thst please try again");
                            }
                        }
                        else if (userChoice == "favorite food")
                        {
                            bool choiceTwo = true;

                            Console.WriteLine($"favorite food is {favoriteFoods[answer]}");
                            while (choiceTwo)
                            {
                                Console.WriteLine("Would you like to know this persons favorite food? just y/n?");
                                string hometown = Console.ReadLine().ToLower();
                                if (hometown == "y")
                                {
                                    Console.WriteLine($"homeTowns is {homeTowns[answer]}");
                                    choiceTwo = false;
                                }
                                else if (hometown == "n")
                                {
                                    Console.WriteLine("Have a good one");
                                    choiceTwo = false;
                                }
                                else
                                {
                                    Console.WriteLine("try again");
                                }
                            }
                            choiceOne = false;

                        }
                        else
                        {
                            Console.WriteLine("please try again.");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please try again.");
                }

                goOn = false;
            }

            Console.WriteLine("want to continue? y/n");
            bool goAgain = true;
            while (goAgain)
            {
                string keepGo = Console.ReadLine().ToLower();

                if (keepGo == "y")
                {
                    goAgain = false;
                }
                else if (keepGo == "n")
                {
                    goAgain = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }



    }
}
