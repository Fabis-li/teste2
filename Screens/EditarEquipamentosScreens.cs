using System.Globalization;
using Estoque.Repositories;

namespace Estoque.Screens
{
    public static class EditarEquipamentosScreen
    {
        public static void Iniciar(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Equipamentos");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - Editar");
            Console.WriteLine("0 - Voltar ao menu Equipamentos");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

            var opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: EditarEquipamento(equipamentosRepository, chamadosRepository); break;
                case 0: EquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
            }

            static void EditarEquipamento(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Editar Equipamento");
                Console.WriteLine("---------------------");
                Console.WriteLine("Digite o numero de serie do equipamento que deseja Editar: ");
                string numeroSerie = Console.ReadLine();
                var equipamento = equipamentosRepository.ListaDeEquipamentos.FirstOrDefault(e => e.NumeroSerie == numeroSerie);
                if(equipamento != null)
                {
                    Console.WriteLine("Nome do Equipamento: ");
                    equipamento.NomeEquipamento = Console.ReadLine();
                    Console.WriteLine("Preço de Aquisição: ");
                    equipamento.PrecoAquisicao = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Número de Série: ");
                    equipamento.NumeroSerie = Console.ReadLine();
                    Console.WriteLine("Data de Fabricação: ");
                    equipamento.DataFabricacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
                    Console.WriteLine("Fabricante: ");
                    equipamento.Fabricante = Console.ReadLine();                    

                    Console.WriteLine("Equipamento editado com sucesso!");
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
}