using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Addition
    {
        public void AdditionTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"        _____       .___  .___.__  __  .__                ___________     ___.   .__          
       /  _  \    __| _/__| _/|__|/  |_|__| ____   ____   \__    ___/____ \_ |__ |  |   ____  
      /  /_\  \  / __ |/ __ | |  \   __\  |/  _ \ /    \    |    |  \__  \ | __ \|  | _/ __ \ 
     /    |    \/ /_/ / /_/ | |  ||  | |  (  <_> )   |  \   |    |   / __ \| \_\ \  |_\  ___/ 
     \____|__  /\____ \____ | |__||__| |__|\____/|___|  /   |____|  (____  /___  /____/\___  >
             \/      \/    \/                         \/                 \/    \/          \/";

            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending Number between 1 and 10");
            Console.WriteLine("Next you will see the bumbers between these selections be added");
            Console.WriteLine("to numbers 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 and 10");
        }

        public void AdditionTitle(int startNum, int endNum)
        {
            //TODO = build out the logic of the addition table
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(String.Format("{0, 6}", "n"));
                }
                else
                {
                    Console.Write(String.Format("{0,6}", i));
                }

            }

            Console.WriteLine("\n");


            for (int i = 1; i <= 10; i++)
            {
                Console.Write(String.Format("{0, 6}", i));
                for (int b = startNum; b <= endNum; b++)
                {
                    string output = String.Format("{0, 6}", i + b);
                    Console.Write(output);
                }
                Console.WriteLine("");
            }


        }
    }
}
