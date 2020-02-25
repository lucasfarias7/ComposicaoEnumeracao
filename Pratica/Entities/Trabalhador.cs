using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratica.Entities.Enum;
using System.Globalization;

namespace Pratica.Entities
{
    public class Trabalhador
    {
        public string Nome { get; set; }

        public NivelTrabalhador Nivel { get; set; }

        public double SalarioBase { get; set; }

        public Departamento departamento { get; set; }

        public List<ContratoHora> contratoHoras { get; set; } = new List<ContratoHora>();


        public Trabalhador()
        {
        }

        /// <summary>
        /// Informações do trabalhador
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="nivel">Nivel do trabalhador</param>
        /// <param name="salarioBase">Salario Base do trabalhador</param>
        /// <param name="departamento">Departamento do trabalhador</param>
        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            this.Nome = nome;
            this.Nivel = nivel;
            this.SalarioBase = salarioBase;
            this.departamento = departamento;
        }

        public void AddContract(ContratoHora contrato)
        {
            this.contratoHoras.Add(contrato);
        }

        public void RemoveContract(ContratoHora contrato)
        {
            this.contratoHoras.Remove(contrato);
        }


        public double Ganhos(int year, int month)
        {
            double salario = this.SalarioBase;

            foreach(ContratoHora contrato in contratoHoras)
            {
                if(contrato.Data.Date.Year == year && contrato.Data.Date.Month == month)
                {
                    salario += contrato.TotalValor();
                }
            }

            return salario; 
        }

        public override string ToString()
        {

            return ""
                + this.Nome
                + ", Departamento: "
                + this.departamento.NomeDepart;
        }
    }
}
