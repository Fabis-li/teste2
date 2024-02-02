using Estoque.Repositories;
using Estoque.Models;

namespace Estoque.Screens
{
    public static class CadastrarChamadosScreen{
        public static void Show(ChamadosRepository chamadosRepository, EquipamentosRepository equipamentosRepository)
        {
           Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Chamados");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("0 - Voltar ao menu Equipamentos");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

             var opcao = short.Parse(Console.ReadLine());

             switch(opcao)
             {
                 case 1: ChamadoModel(chamadosRepository, equipamentosRepository); break;
                 case 0: ChamadosScreen.Iniciar(chamadosRepository,equipamentosRepository); break;
             }

             static void ChamadoModel(ChamadosRepository chamadosRepository, EquipamentosRepository equipamentosRepository)
             {
                Console.Clear();
                var chamado = new ChamadoModel();
                Console.WriteLine();
                Console.WriteLine("Cadastrar Chamado");
                Console.WriteLine("---------------------");
                Console.WriteLine("Título do Chamado: ");
                chamado.TituloChamado = Console.ReadLine();
                Console.WriteLine("Descrição do Chamado: ");
                chamado.DescricaoChamado = Console.ReadLine();
                Console.WriteLine("Equipamento: ");
                chamado.EquipamentoRelacionado = Console.ReadLine();
                Console.WriteLine("Data de Abertura: ");
                chamado.DataAbertura = DateTime.Parse(Console.ReadLine());
                chamadosRepository.ListaDeChamados.Add(new ChamadoModel(chamado.TituloChamado, chamado.DescricaoChamado, chamado.EquipamentoRelacionado, chamado.DataAbertura));
                Console.WriteLine("Chamado cadastrado com sucesso!");                

                var voltar = Console.ReadKey();
                switch(voltar)
                {
                    default: EquipamentosScreen.Iniciar(equipamentosRepository,chamadosRepository); break;
                }   
            }
        }
    }
}