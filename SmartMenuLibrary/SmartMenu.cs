using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            string txtfile = System.IO.File.ReadAllText(path);
            string[] MenuArray = txtfile.Split(';');
            foreach (string v in MenuArray)
            {
                string eal = System.Text.RegularExpressions.Regex.Replace(v, "[^A-Å a-å 0-9 \r\n]", "");
                Console.Write(eal + " ");
            }
            Console.WriteLine("");
        }
        public void Activate ()
        {
            Functions.Binding binding = new Functions.Binding();
            if (int.TryParse(Console.ReadLine(),out int number) == false)
            {
                Console.WriteLine("Error 1, Indtast venligst et guldigt tal!");
                return;
            }
            string res = "";
            if (number == 0)
            {
                binding.Exit();
            }
            else
            {
                binding.Call(number);
            }
        }
       
    }
}
