using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class CarroTunado : Carro
    {
        //toda vez que pegar o valor, vai dizer que o carro tunado tem turbo
        public bool Turbo { get {  return true; } }

        public CarroTunado() { }

        //declarando o construtor para quando vem o dono junto por parâmetro
        public CarroTunado(string dono)
        {
            if (dono == "prof vi")
                VelocidadeMaxima = 25;
        }

        public override int Acelerar(int velocidadeAtual)
        {
            for (int i = velocidadeAtual; (i < 25 && velocidadeAtual <= VelocidadeMaxima); velocidadeAtual++)
            {
                Console.WriteLine($"A velocidade está em {velocidadeAtual}km/h no carro {Nome}");
            }
            return VelocidadeMaxima == velocidadeAtual
            ? 10
            : 3;
        }
    }
}
