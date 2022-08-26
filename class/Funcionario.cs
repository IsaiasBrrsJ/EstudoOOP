namespace EstudoOOP.@class
{
    public class Funcionario
    {
        public int IdFuncionario { get; private set; }
        public string NomeFuncionario { get; private set; }
        public string CargoFuncionario { get; private set; }
        public string SetorFuncionario { get; private set; }

        public decimal SalarioFuncionario { get; private set; }

        public Funcionario(string nomeFuncionaro, string cargoFuncionario, string setorFuncionario, decimal salarioFuncionario)
        {
            IdFuncionario = new Random().Next(0, 1000);
            NomeFuncionario = nomeFuncionaro;
            CargoFuncionario = cargoFuncionario;
            SetorFuncionario = setorFuncionario;
            SalarioFuncionario = salarioFuncionario;
        }

        public virtual decimal SalarioFunc() => SalarioFuncionario;

    }
}