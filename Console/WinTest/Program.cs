using ConsoleGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTest
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i =-20; i<105; i++)
            {
                Display.RenderConsoleProgress(i, 
                  ConsoleColor.White, $"{i:D2}%");

                System.Threading.Thread.Sleep(50);
                
                }


        }
    }
}
