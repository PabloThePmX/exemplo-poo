// See https://aka.ms/new-console-template for more information

// A partir da versão X do .NET, não é mais necessário declarar a classe, vai pegar a classe a partir do nome do arquivo

using ExemploPOO;

do
{
    try
    {
        List<Carro> listaCarros = new List<Carro>();
        while (listaCarros.Count < 5)
        {
            Console.Clear();
            Console.WriteLine($"Escolha {5 - listaCarros.Count} carro(s)");
            Console.WriteLine("Digite (1) para carro normal, (2) para carro tunado ou (3) para carro da prof Vitória");
            switch (Console.ReadLine())
            {
                case "1":
                    Carro carroPadrao = new Carro(); // ou Carro carroPadrao = new();
                    carroPadrao.Nome = "padrao";
                    carroPadrao.VelocidadeMaxima = 100;
                    listaCarros.Add(carroPadrao);
                    break;

                case "2":
                    CarroTunado carroTunado = new CarroTunado();
                    carroTunado.Nome = "tunado";
                    carroTunado.VelocidadeMaxima = 130;
                    listaCarros.Add(carroTunado);
                    break;

                case "3":
                    //podemos usar "var" para que o tipo seja atribuido automaticamente
                    var carroProf = new CarroTunado("prof vi");
                    carroProf.Nome = "DA PROF";
                    listaCarros.Add(carroProf);
                    break;

                default:
                    Console.WriteLine("Valor inválido!");
                    Thread.Sleep(500);
                    break;
            }
        }
        int laps = 0;
        int numeroCarro = 0;
        Random rnd = new Random();
        while (laps <= 50)
        {
            numeroCarro = rnd.Next(1, 5);
            int velocidadeAtual = rnd.Next(1, 35);
            int lapsPercorridos = listaCarros[numeroCarro].Acelerar(velocidadeAtual);
            laps += lapsPercorridos;
        }
        Console.WriteLine($"\nO carro {listaCarros[numeroCarro].Nome} foi o grande vencedor!");
        Thread.Sleep(5000);
        Console.Clear();

        Console.WriteLine("Deseja tentar novamente? (S/N)");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
} while (Console.ReadLine().ToUpper() == "S");