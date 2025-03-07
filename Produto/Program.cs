using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Produto;

    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Refrigerante", 11, 9);
            Produto produto2 = new Produto("Suco", 15.10, 9);
            Produto produto3 = new Produto("Água", 2.50, 9);

            Console.WriteLine(produto1.getDetailProduct());
            Console.WriteLine(produto2.getDetailProduct());
            Console.WriteLine(produto3.getDetailProduct());

        Retangulo retangulo1= new Retangulo(3.00, 4.00);    
        
        Console.WriteLine(retangulo1.Area());
    }



    }











