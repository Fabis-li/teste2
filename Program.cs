using System;
using Estoque.Models;
using Estoque.Repositories;
using Estoque.Screens;


namespace Estque.Models
{
    public static class Program
    {
        static void Main(string[] args)
        {
            EquipamentosRepository equipamentosRepository = new EquipamentosRepository();
            ChamadosRepository chamadosRepository = new ChamadosRepository();

            PopListaEquip(equipamentosRepository);
            PopListaChamado(chamadosRepository);
            MenuScreen.Iniciar(equipamentosRepository, chamadosRepository); 
            // MenuScreenCham.Iniciar(chamadosRepository);

        }

        static void PopListaEquip(EquipamentosRepository equipamentosRepository)
        {
            equipamentosRepository.ListaDeEquipamentos.Add(new EquipamentoModel("Notebook", 2500, "123456", DateTime.Now, "Dell"));
            equipamentosRepository.ListaDeEquipamentos.Add(new EquipamentoModel("Impressora", 1500, "654321", DateTime.Now, "HP"));
            equipamentosRepository.ListaDeEquipamentos.Add(new EquipamentoModel("Servidor", 5000, "789456", DateTime.Now, "IBM"));
            equipamentosRepository.ListaDeEquipamentos.Add(new EquipamentoModel("Roteador", 300, "456789", DateTime.Now, "Cisco"));
        }

        static void PopListaChamado(ChamadosRepository chamadosRepository)
        {
            chamadosRepository.ListaDeChamados.Add(new ChamadoModel("Problema na tela", "Tela não funciona", "Notebook", new DateTime(2024, 01, 12)));
            chamadosRepository.ListaDeChamados.Add(new ChamadoModel("Problema na impressão","Acabou a tinta azul", "Impressora",new DateTime(2024, 01, 10)));
            chamadosRepository.ListaDeChamados.Add(new ChamadoModel("Problema na rede", "não conecta na rede","Servidor",new DateTime(2024, 01, 05)));
            chamadosRepository.ListaDeChamados.Add(new ChamadoModel("Problema no cabo","cabo quebrado" ,"Roteador",new DateTime(2024, 02, 01)));
        }
    }
}