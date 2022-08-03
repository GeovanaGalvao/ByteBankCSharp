namespace ByteBank.Funcionarios {
    internal class Diretor : Funcionario{

        internal Diretor(string nome, string cpf) : base(nome, cpf, 5000) {
        }

        internal override void AumentarSalario() { Salario *= 1.15 ; } 

        internal override double Bonificacao() => Salario;
    }
}
