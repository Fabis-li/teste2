using Estoque.Repositories;
namespace Estoque.Screens
{
    public static class EquipamentosScreen
    {
        public static void Iniciar(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Equipamentos");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - Cadastrar Equipamento");
            Console.WriteLine("2 - Listar Equipamentos");
            Console.WriteLine("3 - Editar Equipamento");
            Console.WriteLine("4 - Excluir Equipamento");
            Console.WriteLine("0 - Voltar ao menu Iniciar");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: CadastrarEquipamentosScreen.Show(equipamentosRepository, chamadosRepository);break;
                case 2: ListarEquipamentosScreen.Iniciar(equipamentosRepository,chamadosRepository); break;
                case 3: EditarEquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
                case 4: ExcluirEquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
                case 0: MenuScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
            }
        }
    }
}
