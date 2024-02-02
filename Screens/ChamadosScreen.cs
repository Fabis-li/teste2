using Estoque.Repositories;
namespace Estoque.Screens
{
    public static class ChamadosScreen
    {
        public static void Iniciar(ChamadosRepository chamadosRepository, EquipamentosRepository equipamentosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Chamados");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - Cadastrar Chamado");
            Console.WriteLine("2 - Listar Chamados");
            Console.WriteLine("3 - Editar Chamado");
            Console.WriteLine("4 - Excluir Chamado");
            Console.WriteLine("0 - Voltar ao menu Iniciar");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: CadastrarChamadosScreen.Show(chamadosRepository, equipamentosRepository);break;
                case 2: ListarChamadosScreen.Iniciar(chamadosRepository, equipamentosRepository); break;
                case 3: EditarChamadosScreen.Iniciar(chamadosRepository, equipamentosRepository); break;
                case 4: ExcluirChamadosScreen.Iniciar(chamadosRepository, equipamentosRepository); break;
                case 0: MenuScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
            }
        }    
    }
}