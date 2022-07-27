using ByteBank.Usuarios;

namespace ByteBank.Funcionarios {
    internal class Funcionario : Pessoa {

        internal Funcionario(string nome, string cpf, double salario) : base(nome, cpf) { Salario = salario; }
        internal double Salario { get; set; }

        internal virtual double Bonificacao() => Salario * 0.1;

        public override string ToString() => base.ToString() + "\nSalario: " + Salario;
    }
}
