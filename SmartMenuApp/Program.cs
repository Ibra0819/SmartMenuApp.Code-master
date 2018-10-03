using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            menu.LoadMenu(@"C:\Users\PC\Documents\EAL\Programmering\Projekt\SmartMenuApp.Code-master\SmartMenuLibrary\MenuSpec.txt");
            menu.Activate();
            
        }
    }
}
