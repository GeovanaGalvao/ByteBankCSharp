namespace ByteBank.Funcionarios {
    internal class Diretor : Funcionario{

        internal Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario) { }

        internal override double Bonificacao() => Salario;
    }
}
