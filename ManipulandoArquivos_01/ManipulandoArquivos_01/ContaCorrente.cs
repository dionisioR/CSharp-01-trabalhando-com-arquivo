﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoArquivos_01 {
    internal class ContaCorrente {
        public int Numero { get;}
        public int Agencia { get;}
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public ContaCorrente(int agencia, int numero) {
            Agencia = agencia;
            Numero = numero;
        }

        public void Depositar(double valor) {
            if(valor <= 0) {
                throw new ArgumentException("O valor de saque deve ser maior que zero.", nameof(valor));
            }
            Saldo += valor;
        }

        public void Sacar(double valor) {
            if (valor <= 0) {
                throw new ArgumentException("O valor deve ser maior que zero.", nameof(valor));
            }

            if (valor > Saldo) {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }
}
