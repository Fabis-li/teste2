using Estoque.Models;

namespace Estoque.Repositories
{
    public class EquipamentosRepository
    {
        public IList<EquipamentoModel> ListaDeEquipamentos;
        public EquipamentosRepository()
        {
            ListaDeEquipamentos = new List<EquipamentoModel>();
        }

        public void Listar()
        {
            foreach(var equipamento in ListaDeEquipamentos)
            {
                Console.WriteLine(equipamento.EquipamentoInfo());
            }
        }

        
    }
}