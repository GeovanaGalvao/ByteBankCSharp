using System.Text.RegularExpressions;

namespace ByteBank.Contas {
    internal class ContaCorrente {

        internal static int QuantidadeDeContas { get; private set; }
        internal Cliente Cliente { get; private set; }
        private string _conta, _nomeDaAgencia, _numeroDaAgencia;
        private double _saldo;

        internal ContaCorrente(Cliente cliente, string conta, string nomeDaAgencia, string numeroDaAgencia, double saldo) {
            Cliente = cliente;
            _conta = conta;
            _nomeDaAgencia = nomeDaAgencia;
            _numeroDaAgencia = numeroDaAgencia;
            _conta = conta;
            _nomeDaAgencia = nomeDaAgencia;
            _numeroDaAgencia = numeroDaAgencia;
            _saldo = saldo;
            QuantidadeDeContas++;
        }

        internal string Conta { 
            get => _conta;
            set {
                if (Regex.IsMatch(value, @"/^[0-9]{4}-[0-9a-zA-Z]{1}$/"))
                    _conta = value;
            }
        }

        internal string NomeDaAgencia { 
            get => _nomeDaAgencia;
            set {
                if (value.Length >= 3)
                    _nomeDaAgencia = value;
            }
        }

        internal string NumeroDaAgencia { 
            get => _numeroDaAgencia;
            set {
                if (Regex.IsMatch(value, @"/^[0-9]{4}$/"))
                    _numeroDaAgencia = value;
            }
        }

        internal double Saldo { 
            get => _saldo;
            set {
                if (value >= 0)
                    _saldo = value;
            }
        }

        internal bool VerificaPossiblidadeDeSaqueOuTransferencia(double valor) => _saldo > valor && valor > 0.0;

        internal double Saque(double valorDoSaque) {
            if (VerificaPossiblidadeDeSaqueOuTransferencia(valorDoSaque)) {
                _saldo -= valorDoSaque;
                Console.WriteLine("Saque realizado com sucesso.");
                return valorDoSaque;
            }
            else {
                Console.WriteLine("Não é possível sacar esse valor.");
                return 0.0;
            }
        }

        internal void Deposito(double valorInjetado) {
            if (valorInjetado > 0.0) {
                _saldo += valorInjetado;
                Console.WriteLine("Depósito realizado com sucesso.");
            }
            else 
                Console.WriteLine("Não é possível depositar esse valor.");   
        }

        internal void TransfereValor(ContaCorrente contaQueRecebeATransferencia, double valorDaTransferencia) {
            if (VerificaPossiblidadeDeSaqueOuTransferencia(valorDaTransferencia)) {
                Saque(valorDaTransferencia); // Remove o valor que deseja transferir do saldo
                contaQueRecebeATransferencia.Deposito(valorDaTransferencia);
                Console.WriteLine("Transferência realizada com sucesso.");
            }
            else 
                Console.WriteLine("Não foi possível fazer a transferência.");
        }

        public override string ToString() => "\n------------------------------\n\n" +
            "-----Informacoes da conta-----\n\nNome da Agencia: " + _nomeDaAgencia + 
            "\nNumero da Agencia: " + _numeroDaAgencia + "\nConta: " + _conta +
            "\nSaldo: " + _saldo + "\n\n----Informacoes do cliente----\n" + Cliente +
            "\n\n------------------------------";
    }
}
