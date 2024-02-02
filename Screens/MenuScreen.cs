using Estoque.Repositories;

namespace Estoque.Screens
{
    public static class MenuScreen
    {
        public static void Iniciar(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
        {
            Console.Clear();
            Opcoes();

            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: EquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
                case 2: ChamadosScreen.Iniciar(chamadosRepository, equipamentosRepository); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Environment.Exit(0); break;      
            }
                
            static void Opcoes()
            {
                Console.WriteLine("Controle de Equipamentos e Manutenção - Menu Principal");
                Console.WriteLine("1 - Equipamentos");
                Console.WriteLine("2 - Chamados de Manutenção");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
                Console.Write("Digite uma opção: ");
            }
        }
    }
}
