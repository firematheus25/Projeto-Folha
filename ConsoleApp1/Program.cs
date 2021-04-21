using miscellaneous.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Horista Matheus = new Horista();

            Matheus.Nome = "Matheus";


            
            Console.WriteLine(Matheus.Nome);
            Console.ReadLine();
        }
    }
}
