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
        public DateTime DataFabricacao { get; set; }
        public string Fabricante { get; set; }

        public EquipamentoModel () {}

        public EquipamentoModel (string nomeEquipamento, decimal precoAquisicao, string numeroSerie, DateTime dataFabricacao, string fabricante)
        {
            this.NomeEquipamento = nomeEquipamento;
            this.PrecoAquisicao = precoAquisicao;
            this.NumeroSerie = numeroSerie;
            this.DataFabricacao = dataFabricacao;
            this.Fabricante = fabricante;
        }

        public virtual string EquipamentoInfo()
        {
            return $"Nome do Equipamento: {NomeEquipamento}, Preço de Aquisição: {PrecoAquisicao}, Número de Série: {NumeroSerie}, Data de Fabricação: {DataFabricacao}, Fabricante: {Fabricante}";
        }

        public void EditarEquipamento(string nomeEquipamento, decimal precoAquisicao, string numeroSerie, DateTime dataFabricacao, string fabricante)
        {
            this.NomeEquipamento = nomeEquipamento;
            this.PrecoAquisicao = precoAquisicao;
            this.NumeroSerie = numeroSerie;
            this.DataFabricacao = dataFabricacao;
            this.Fabricante = fabricante;
        }

        public void ExcluirEquipamento()
        {
            this.NomeEquipamento = null;
            this.PrecoAquisicao = 0;
            this.NumeroSerie = null;
            this.DataFabricacao = DateTime.MinValue;
            this.Fabricante = null;
        }
    }

}