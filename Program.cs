using projetocarro;

//using Program.cs.Model;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var carro = new Carro();
            var motor = new Motor();
            carro.modelo = "HB20";
            carro.ano = 1990;
            carro.km = 1.9f;
            motor.modelo = "V8";
            motor.cabecote = "xxyz";

            var carro1 = new Carro();
            var motor1 = new Motor();

            carro1.modelo = "corsa";
            carro1.ano = 1978;
            carro1.km = 2.5f;
            motor1.modelo="v7";
            motor1.cabecote = " xyz";

            Console.WriteLine(carro.modelo+" | "+carro1.modelo);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(Convert.ToString(carro.ano+" | "+carro1.ano));

        }
    }
}