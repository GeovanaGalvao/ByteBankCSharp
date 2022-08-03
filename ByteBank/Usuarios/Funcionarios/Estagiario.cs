namespace ByteBank.Funcionarios {
    internal class Estagiario : Funcionario {

        internal Estagiario(string nome, string cpf) : base(nome, cpf, 1500) { }

        internal override void AumentarSalario() { Salario *= 1.10; }

        internal override double Bonificacao() => Salario * 1.20;
    }
}
