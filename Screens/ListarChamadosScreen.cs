using Estoque.Models;
using Estoque.Repositories;

namespace Estoque.Screens
{
    public static class ListarChamadosScreen
    {
        public static void Iniciar(ChamadosRepository chamadosRepository, EquipamentosRepository equipamentosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Chamados");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - Listar Chamados");
            Console.WriteLine("0 - Voltar ao menu Chamados");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

            var opcao = short.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1: ListarChamados(chamadosRepository, equipamentosRepository); break;
                case 0: ChamadosScreen.Iniciar(chamadosRepository, equipamentosRepository); break;
                default: break;
            }

            static void ListarChamados(ChamadosRepository chamadosRepository, EquipamentosRepository equipamentosRepository)
            {
                Console.Clear();
                Console.WriteLine("Lista de Chamados Cadastrados");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(Environment.NewLine);

                if (chamadosRepository.ListaDeChamados.Count > 0)
                {
                    foreach (ChamadoModel chamado in chamadosRepository.ListaDeChamados)
                    {
                        Console.WriteLine(chamado.ObterChamado());
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum chamado cadastrado.");
                }
                var voltar = Console.ReadKey();
                switch(voltar)
                {
                    default: Iniciar(chamadosRepository, equipamentosRepository);break;
                }            
            
            }
        }
    }
}