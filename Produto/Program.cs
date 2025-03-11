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

        Conta_Corrente conta_corrente1 = new Conta_Corrente(123, "Jonas", 10);
        

        Console.WriteLine(conta_corrente1.getDetailAccount());
        double opcao;

        //do
        {
            Console.WriteLine("Insira a opção que deseja: \n1. Consultar saldo.\n2. Realizar depósito.\n3. Realizar saque.\n4. Encerrar atendimento");
            opcao = double.Parse(Console.ReadLine());

        }
        //while (opcao != 4);
        //Console.WriteLine("Atendimento encerrado, obrigado por utilizar nossos serviços");

        if (opcao == 1)
        {
            Console.WriteLine(conta_corrente1.ExibirSaldo());
            Console.WriteLine("Insira a opção que deseja: \n1. Consultar saldo.\n2. Realizar depósito.\n3. Realizar saque.\n4. Encerrar atendimento");
            opcao = double.Parse(Console.ReadLine());
        }


        if (opcao == 2)
        {
            Console.WriteLine("Insira o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            Console.WriteLine(conta_corrente1.Depositar(deposito));
            Console.WriteLine("Insira a opção que deseja: \n1. Consultar saldo.\n2. Realizar depósito.\n3. Realizar saque.\n4. Encerrar atendimento");
            opcao = double.Parse(Console.ReadLine());
        }
        if (opcao == 3);
        {
            Console.WriteLine("Insira o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());
            Console.WriteLine(conta_corrente1.Sacar(saque));
            Console.WriteLine("Insira a opção que deseja: \n1. Consultar saldo.\n2. Realizar depósito.\n3. Realizar saque.\n4. Encerrar atendimento");
            opcao = double.Parse(Console.ReadLine());
        }
        

    }
    
    

    
     
}











