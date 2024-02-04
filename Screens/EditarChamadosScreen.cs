using Estoque.Repositories;

namespace Estoque.Screens
{
    public static class EditarChamadosScreen
    {
        public static void Iniciar(ChamadosRepository chamadosRepository, EquipamentosRepository equipamentosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Chamados");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - Editar");
            Console.WriteLine("0 - Voltar ao menu Chamados");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

            var opcao = short.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1: EditarChamado(chamadosRepository, equipamentosRepository); break;
                case 0: ChamadosScreen.Iniciar(chamadosRepository, equipamentosRepository); break;
            }

            static void EditarChamado(ChamadosRepository chamadosRepository, EquipamentosRepository equipamentosRepository){
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Editar Chamado");
                Console.WriteLine("---------------------");
                Console.WriteLine("Digite o Título do chamado que deseja Editar: ");
                string tituloChamado = Console.ReadLine();
                var chamado = chamadosRepository.ListaDeChamados.FirstOrDefault(c => c.TituloChamado == tituloChamado);
                if(chamado != null)
                {
                    Console.WriteLine("Título do Chamado: ");
                    chamado.TituloChamado = Console.ReadLine();
                    Console.WriteLine("Descrição do Chamado: ");
                    chamado.DescricaoChamado = Console.ReadLine();
                    Console.WriteLine("Equipamento: ");
                    chamado.EquipamentoRelacionado = Console.ReadLine();
                    Console.WriteLine("Data de Abertura: ");
                    chamado.DataAbertura = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Chamado editado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Chamado não encontrado!");
                }

                var voltar = Console.ReadKey();
                switch(voltar)
                {
                    default: ChamadosScreen.Iniciar(chamadosRepository, equipamentosRepository); break;
                }   
            }
        }
    }
}