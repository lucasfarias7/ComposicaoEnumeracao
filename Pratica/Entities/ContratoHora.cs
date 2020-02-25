using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica.Entities
{
    public class ContratoHora
    {
        public DateTime Data { get; set; }

        public double ValorHora { get; set; }

        public int HorasTrab { get; set; }

        public ContratoHora()
        {
        }

        /// <summary>
        /// Informeções sobre o contrato devem ser passadas
        /// </summary>
        /// <param name="data">Data</param>
        /// <param name="valorHora">Valor que recebe por hora nesse contrato</param>
        /// <param name="horas">horas trabalhadas</param>
        public ContratoHora(DateTime data, double valorHora, int horas)
        {
            this.Data = data;
            this.ValorHora = valorHora;
            this.HorasTrab = horas;
        }

        /// <summary>
        /// Fuñção que retorna o total de quannto o funcionário estara recebendo neste contrato
        /// </summary>
        /// <returns></returns>
        public double TotalValor()
        {
            return ValorHora * HorasTrab;
        }
    }
}
