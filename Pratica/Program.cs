using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica.Entities.Enum;
using Pratica.Entities;
using System.Globalization;

namespace Pratica
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe os seguintes dados");
            Console.Write("Nome do departamento: ");
            string departamento = Console.ReadLine();
            
            Departamento depart = new Departamento(departamento);
            Console.WriteLine();
            Console.WriteLine("Dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel(Junior,Pleno,Senior): ");
            NivelTrabalhador nivel = (NivelTrabalhador)System.Enum.Parse(typeof(NivelTrabalhador), Console.ReadLine());
            Console.Write("Salario Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, depart);
            Console.WriteLine();

            Console.Write("Quantos contratos para este trabalhador ? ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Entre com os dado do "+i+" contrato");
                Console.Write("Data: ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Valor Por hora: ");
                double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine();

                ContratoHora ch = new ContratoHora(date, valorhora, horas);

                trabalhador.AddContract(ch);
            }

            Console.WriteLine();
            Console.Write("Informe um mes e ano para ser calculado seu ganho (MM/yyyy): ");
            string mesano = Console.ReadLine();
            int ano = int.Parse(mesano.Substring(0, 2));
            int mes = int.Parse(mesano.Substring(3, 4));
            Console.WriteLine();

            Console.WriteLine(trabalhador);
            Console.WriteLine("Ganho para "+mesano+" foi: R$: "+trabalhador.Ganhos(mes, ano));

            Console.ReadKey();
        }
    }
}
