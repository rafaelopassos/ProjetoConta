using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaC_
{
    public class Conta
    {
		private int numero;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		private string titular;

		public string Titular
		{
			get { return titular; }
			set { titular = value; }
		}

		private double saldo;

		public double Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

		public Conta(int numero,  string titular, double	saldo) 
		{
            this.numero = numero;
            this.titular = titular;
			this.saldo = saldo;	
		}

		public void depositar(double valor)
		{
			this.saldo += valor;
		}

		public bool sacar(double valor) 
		{
			if (valor <= this.saldo)
			{
                this.saldo -= valor;
				return true;
            }
			else
			{
				return false;
			}
		}

		public bool trasferir(Conta conta , double valor)
		{
			if (this.sacar(valor))
			{
				conta.depositar(valor);
				return true;
			}
			else
			{
				return false; 
			}
		}
	}
}
