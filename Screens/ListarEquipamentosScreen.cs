using Estoque.Models;
using Estoque.Repositories;
namespace Estoque.Screens
{
    public static class ListarEquipamentosScreen
    {
        public static void Iniciar(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Lista de Equipamentos");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - Listar Equipamentos Cadastrados");            
            Console.WriteLine("0 - Voltar ao menu Equipamentos");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: ListarEquipamentos(equipamentosRepository, chamadosRepository); break;                
                case 0: EquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
                default: break;
            }
            Console.ReadLine();


            static void ListarEquipamentos(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
            {
                Console.Clear();
                Console.WriteLine("Lista de Equipamentos Cadastrados");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(Environment.NewLine);

                if (equipamentosRepository.ListaDeEquipamentos.Count > 0)
                {
                    foreach (EquipamentoModel equipamento in equipamentosRepository.ListaDeEquipamentos)
                    {
                        Console.WriteLine(equipamento.EquipamentoInfo());                        
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum equipamento cadastrado.");
                }
                var voltar = Console.ReadKey();
                switch(voltar)
                {
                    default: Iniciar(equipamentosRepository, chamadosRepository);break;
                }
            }
        }
    }
}