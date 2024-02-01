using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.Models
{
    public class EquipamentoModel
    {
        public string NomeEquipamento { get; set; }
        public decimal PrecoAquisicao { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime DataAquisicao { get; set; }
        public string Fabricante { get; set; }

        public EquipamentoModel () {}

        public EquipamentoModel (string nomeEquipamento, decimal precoAquisicao, string numeroSerie, DateTime dataAquisicao, string fabricante)
        {
            this.NomeEquipamento = nomeEquipamento;
            this.PrecoAquisicao = precoAquisicao;
            this.NumeroSerie = numeroSerie;
            this.DataAquisicao = dataAquisicao;
            this.Fabricante = fabricante;
        }

        public virtual string EquipamentoInfo()
        {
            return $"Nome do Equipamento: {NomeEquipamento}\nNúmero de Série: {NumeroSerie}\nFabricante: {Fabricante}";
        }

        public void EditarEquipamento(string nomeEquipamento, decimal precoAquisicao, string numeroSerie, DateTime dataAquisicao, string fabricante)
        {
            this.NomeEquipamento = nomeEquipamento;
            this.PrecoAquisicao = precoAquisicao;
            this.NumeroSerie = numeroSerie;
            this.DataAquisicao = dataAquisicao;
            this.Fabricante = fabricante;
        }

        public void ExcluirEquipamento()
        {
            this.NomeEquipamento = null;
            this.PrecoAquisicao = 0;
            this.NumeroSerie = null;
            this.DataAquisicao = DateTime.MinValue;
            this.Fabricante = null;
        }
    }

}