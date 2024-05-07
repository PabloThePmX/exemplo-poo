using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    //herança
    public class CarroTunado : Carro
    {
        //toda vez que pegar o valor, vai dizer que o carro tunado tem turbo
        public bool Turbo { get {  return true; } }

        //encapsulamento
        private int _velocidadeMaxima;

        public CarroTunado() 
        {
            _velocidadeMaxima = VelocidadeMaxima;
        }

        //declarando o construtor para quando vem o dono junto por parâmetro
        public CarroTunado(string dono)
        {
            if (dono == "prof vi")
                _velocidadeMaxima = 25;
        }

        //polimorfismo
        public override int Acelerar(int velocidadeAtual)
        {
            for (int i = velocidadeAtual; (i < 25 && velocidadeAtual <= _velocidadeMaxima); velocidadeAtual++)
            {
                Console.WriteLine($"A velocidade está em {velocidadeAtual}km/h no carro {Nome}");
            }
            return _velocidadeMaxima == velocidadeAtual
            ? 10
            : 3;
        }
    }
}
