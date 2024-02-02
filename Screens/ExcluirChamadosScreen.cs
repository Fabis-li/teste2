using Estoque.Repositories;

namespace Estoque.Screens
{
    public static class ExcluirChamadosScreen
    {
        public static void Iniciar(ChamadosRepository chamadosRepository, EquipamentosRepository equipamentosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Chamados");
            Console.WriteLine("------------------------------------------------------");  
            Console.WriteLine("Digite o Título do chamado que deseja Excluir: ");
            string tituloChamado = Console.ReadLine();
            var chamado = chamadosRepository.ListaDeChamados.FirstOrDefault(c => c.TituloChamado == tituloChamado);
            if(chamado != null)
            {
                chamadosRepository.ListaDeChamados.Remove(chamado);
                Console.WriteLine("Chamado excluido com sucesso!");
            }
            else
            {
                Console.WriteLine("Chamado não encontrado!");
            }

            var voltar = Console.ReadKey();
            switch(voltar)
            {
                default: EquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
            }   
        }
    }
}