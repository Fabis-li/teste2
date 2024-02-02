using Estoque.Models;

namespace Estoque.Repositories
{
    public class ChamadosRepository
    {
        public IList<ChamadoModel> ListaDeChamados;
        public ChamadosRepository()
        {
            ListaDeChamados = new List<ChamadoModel>();
        }

        public void Listar()
        {
            foreach(var chamado in ListaDeChamados)
            {
                Console.WriteLine(chamado.ObterChamado());
            }
        }
    }
}