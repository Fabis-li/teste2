using Estoque.Models;
using System.Globalization;
using Estoque.Repositories;

namespace  Estoque.Screens
{
    public static class CadastrarEquipamentosScreen
    {
        public static void Show(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
        {
            Console.Clear();
            Console.WriteLine("Controle de Equipamentos e Manutenção - Equipamentos");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("0 - Voltar ao menu Equipamentos");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");

            var opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: EquipamentoModel(equipamentosRepository, chamadosRepository); break;
                case 0: EquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
            }

            static void EquipamentoModel(EquipamentosRepository equipamentosRepository, ChamadosRepository chamadosRepository)
            {
                Console.Clear();
                var equipamento = new EquipamentoModel();
                Console.WriteLine();
                Console.WriteLine("Cadastrar Equipamento");
                Console.WriteLine("---------------------");
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
                equipamentosRepository.ListaDeEquipamentos.Add(new EquipamentoModel(equipamento.NomeEquipamento, equipamento.PrecoAquisicao, equipamento.NumeroSerie, equipamento.DataFabricacao, equipamento.Fabricante));
                Console.WriteLine("Equipamento cadastrado com sucesso!");

                var voltar = Console.ReadKey();
                switch(voltar)
                {
                    default: EquipamentosScreen.Iniciar(equipamentosRepository, chamadosRepository); break;
                }   
            }
        }
    }
}