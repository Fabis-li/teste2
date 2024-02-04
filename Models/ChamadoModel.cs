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

        public int DiasEmAberto{
            get{
                TimeSpan diasAberto = DateTime.Now - DataAbertura;
                return (int)diasAberto.TotalDays;
            }
        }       

        public ChamadoModel() { } 

        public ChamadoModel(string tituloChamado, string descricaoChamado, string equipamentoRelacionado, DateTime dataAbertura)
        {
            this.TituloChamado = tituloChamado;
            this.DescricaoChamado = descricaoChamado;
            this.EquipamentoRelacionado = equipamentoRelacionado;
            this.DataAbertura = dataAbertura;
        }

        public virtual string ObterChamado()
        {
            return $"Título do chamado: {TituloChamado} - Equipamento relacionado: {EquipamentoRelacionado} - Data de abertura: {DataAbertura} - Dias em aberto: {DiasEmAberto} dias.";
        }

        public void EditarChamado(string tituloChamado, string descricaoChamado, string equipamentoRelacionado, DateTime dataAbertura)
        {
            this.TituloChamado = tituloChamado;
            this.DescricaoChamado = descricaoChamado;
            this.EquipamentoRelacionado = equipamentoRelacionado;
            this.DataAbertura = dataAbertura;            
        }

        public void ExcluirChamado()
        {
            this.TituloChamado = null;
            this.DescricaoChamado = null;
            this.EquipamentoRelacionado = null;
            this.DataAbertura = DateTime.MinValue;
        }
    }
}