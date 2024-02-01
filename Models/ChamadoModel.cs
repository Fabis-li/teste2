using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.Models
{
    public class ChamadoModel
    {
        public string TituloChamado { get; set; }
        public string DescricaoChamado { get; set; }
        public string EquipamentoRelacionado { get; set; }
        public DateTime DataAbertura { get; set; }

        public DateTime DataAtual { get; set; } = DateTime.Now;
       

        public ChamadoModel() { } 

        public ChamadoModel(string tituloChamado, string descricaoChamado, string equipamentoRelacionado, DateTime dataAbertura)
        {
            TituloChamado = tituloChamado;
            DescricaoChamado = descricaoChamado;
            EquipamentoRelacionado = equipamentoRelacionado;
            DataAbertura = dataAbertura;
            
        }

        public virtual string ObterChamado()
        {
            return $"Título do chamado: {TituloChamado} - Equipamento relacionado: {EquipamentoRelacionado} - Data de abertura: {DataAbertura} - Dias em aberto: {DataAtual.Subtract(DataAbertura).Days}";
        }

        public void EditarChamado(string tituloChamado, string descricaoChamado, string equipamentoRelacionado, DateTime dataAbertura, DateTime dataAtual)
        {
            TituloChamado = tituloChamado;
            DescricaoChamado = descricaoChamado;
            EquipamentoRelacionado = equipamentoRelacionado;
            DataAbertura = dataAbertura;            
        }

        public void ExcluirChamado()
        {
            TituloChamado = null;
            DescricaoChamado = null;
            EquipamentoRelacionado = null;
            DataAbertura = DateTime.MinValue;
        }
    }
}