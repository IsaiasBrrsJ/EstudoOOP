namespace EstudoOOP.@class
{
    public class Estagiario : Funcionario
    {
        public string TipoDeAcesso { get; private set; }
        public Estagiario(string tipoDeAcesso, string nomeFuncionaro, string cargoFuncionario,
        string setorFuncionario, decimal salarioFuncionario) : base(nomeFuncionaro, cargoFuncionario, setorFuncionario, salarioFuncionario)
        {
            TipoDeAcesso = tipoDeAcesso;
        }

        public override decimal SalarioFunc()
        {
            var salario = (base.SalarioFunc() * 1) / 100;
            return base.SalarioFunc() + salario;
        }
    }
}