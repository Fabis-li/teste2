using Estoque.Repositories;

namespace Estoque.Screens
{
    public static class ExcluirEquipamentosScreen
    {
        public static void Iniciar(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Equipamentos");
            Console.WriteLine("------------------------------------------------------");  
            Console.WriteLine("Digite o numero de serie do equipamento que deseja Excluir: ");  
            string numeroSerie = Console.ReadLine();
            var equipamento = equipamentosRepository.ListaDeEquipamentos.FirstOrDefault(e => e.NumeroSerie == numeroSerie);        
            
            if(equipamento != null)
            {
                equipamentosRepository.ListaDeEquipamentos.Remove(equipamento);
                Console.WriteLine("Equipamento excluido com sucesso!");
            }
            else
            {
                Console.WriteLine("Equipamento não encontrado!");
            }
            
            var voltar = Console.ReadKey();
            switch(voltar)
            {
                default: EquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
            }   
            
        }
    }
}