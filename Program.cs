using Program.cs.Model;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var motor = new Motor();
            //var motor2 = new Motor();
            motor.modelo = "v8";
            motor.cabecote = "tambemnao";
            Console.WriteLine(motor.modelo);
            Console.WriteLine(motor.cabecote);


        }
    }
}