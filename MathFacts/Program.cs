using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiplication timesTable = new Multiplication();
            Subtraction minusTable = new Subtraction();
            Division divideTable = new Division();
            do
            {
                MainAppTitle();
                choice = MainMenu();
                //TODO = Handle addition choice
                if (choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    //TODO = title
                    do
                    {

                        addTable.AdditionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
          
                        }
                        finally
                        {
                            //TODO = validate startNum and endNum
                            if (startNum > 0 && endNum <=10)
                            {
                                addTable.AdditionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your addition Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                addTable.AdditionTitle(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more addition facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }

                        }
                    } while (continueChoice == true);
                    
                }

                if (choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        timesTable.MultiplicationTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                        }
                        finally
                        {
                            if (startNum > 0 & endNum <= 10)
                            {
                                timesTable.MultiplicationTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your addition Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                timesTable.MultiplicationTitle(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more addition facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Please enter a valid number");
                                    Console.ReadLine();
                                }


                            }
                        }

                    } while (continueChoice == true);
                }
                if (choice == 3)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    //TODO = title
                    do
                    {

                        minusTable.SubtractionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();

                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                minusTable.SubtractionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your addition Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                minusTable.SubtractionTitle(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more addition facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }

                        }
                    } while (continueChoice == true);
                }
                if (choice == 4)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    //TODO = title
                    do
                    {

                        divideTable.DivisonTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();

                        }
                        finally
                        {
                            //TODO = validate startNum and endNum
                            if (startNum > 0 && endNum <= 10)
                            {
                                divideTable.DivisonTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your division Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                divideTable.DivisionTitle(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more division facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }

                        }
                    } while (continueChoice == true);

                }
            } while (choice != 5);


        }

        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an option");
            Console.WriteLine("-----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Multiplication Facts");
            Console.WriteLine("Option 3: Subtraction Facts");
            Console.WriteLine("Option 4: Division Facts");
            Console.WriteLine("Option 5: Leave Math Facts");
            //TODO = handle wrong input, fix the exception handling
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }

        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"   _____          __  .__      ___________              __              _____                 
  /     \ _____ _/  |_|  |__   \_   _____/____    _____/  |_  ______   /  _  \ ______ ______  
 /  \ /  \\__  \\   __\  |  \   |    __) \__  \ _/ ___\   __\/  ___/  /  /_\  \\____ \\____ \ 
/    Y    \/ __ \|  | |   Y  \  |     \   / __ \\  \___|  |  \___ \  /    |    \  |_> >  |_> >
\____|__  (____  /__| |___|  /  \___  /  (____  /\___  >__| /____  > \____|__  /   __/|   __/ 
        \/     \/          \/       \/        \/     \/          \/          \/|__|   |__|  ";




            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
