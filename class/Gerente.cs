namespace EstudoOOP.@class
{
    public class Gerente : Funcionario
    {
        public int QuantidadeDeFuncionarios { get; private set; }
        public Gerente(int quantidadeDeFuncionarios, string nomeFuncionaro, string cargoFuncionario,
        string setorFuncionario, decimal salarioFuncionario) : base(nomeFuncionaro, cargoFuncionario, setorFuncionario, salarioFuncionario)
        {
            QuantidadeDeFuncionarios = quantidadeDeFuncionarios;
        }

        public override decimal SalarioFunc()
        {
            var salario = (base.SalarioFunc() * 15) / 100;

            return base.SalarioFunc() + salario;
        }
    }
}