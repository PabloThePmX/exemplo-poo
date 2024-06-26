﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Carro
    {
        //abstração
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Nome { get; set; }
        public int VelocidadeMaxima { get => _velocidadeMaxima ; set => _velocidadeMaxima = value ; }

        //encapsulamento
        private int _velocidadeMaxima;

        public virtual int Acelerar(int velocidadeAtual)
        {
            for (int i = velocidadeAtual; (i < 10 && velocidadeAtual <= _velocidadeMaxima); velocidadeAtual++)
            {
                Console.WriteLine($"A velocidade está em {velocidadeAtual}km/h no carro {Nome}");
            }

            //usando if ternario para retornar 5 caso a velocidade atual seja igual a velocidade maxima
            return _velocidadeMaxima == velocidadeAtual 
                ? 5 
                : 1;
        }

        private int Frear(int velocidadeAtual)
        {
            return velocidadeAtual -= 20;
        }
    }
}
