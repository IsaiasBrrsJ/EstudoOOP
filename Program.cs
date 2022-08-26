using System;
using EstudoOOP.@class;
namespace EstudoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var estagiario = new Estagiario("Semi-Restrito", "Isaias", "Estagiario", "Dev", (decimal)1150);
            Console.WriteLine(estagiario.CargoFuncionario);
            Console.WriteLine(estagiario.IdFuncionario);
            Console.WriteLine(estagiario.NomeFuncionario);
            Console.WriteLine(estagiario.SalarioFunc().ToString("C"));
            Console.WriteLine(estagiario.SetorFuncionario);
            Console.WriteLine(estagiario.TipoDeAcesso);

            Console.WriteLine("==========================");
            var gerente = new Gerente(10, "Arnaldo", "Gerente de Infraestrutura", "Infraestrutura", 3000);
            Console.WriteLine(gerente.CargoFuncionario);
            Console.WriteLine(gerente.IdFuncionario);
            Console.WriteLine(gerente.NomeFuncionario);
            Console.WriteLine(gerente.SalarioFunc().ToString("C"));
            Console.WriteLine(gerente.SetorFuncionario);


        }
    }
}