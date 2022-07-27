using ByteBank.Contas;

namespace ByteBank {
    public class Programa{
        public static void Main(string[] args){

            Console.WriteLine("Bem vindo ao Bytebank.");
            Cliente laura = new ("Laura Souza", "F", "123.456.789-10", "Cabelereira", 36);
            ContaCorrente contaDaLaura = new (laura, "1234-X", "ByteBank", "1234", 1000.00);
            Console.WriteLine(contaDaLaura + "\n\nQuantidade de contas criadas: " 
                + ContaCorrente.QuantidadeDeContas);
        }
    }
}
