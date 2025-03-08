using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Conta_Corrente
    {
        public int Numero;
        public string Titular;
        public double Saldo;
        

        public Conta_Corrente(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public double ExibirSaldo()
        {
            return Saldo;

        }
        public double Depositar(double deposito)
        {
            return Saldo + deposito;
        }
        public string Sacar(double saque)
        {
            if (Saldo < saque)
            {
                return "Não é possível fazer a operação por falta de saldo";

            }
            Saldo = Saldo - saque;
            return $"O saque foi realizado com sucesso, o novo saldo é {Saldo}";



        }
        
        public string getDetailAccount()
        {
            return $"Número: {Numero}, Titular: {Titular}, Saldo: {Saldo}";
        }

    }
}
