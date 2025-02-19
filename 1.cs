namespace Santissimo
{
	public class operacoes 
	{
		public string Nome { get; set; }
        public int Cpf { get; set; }
        public double Preco { get; set; }
	}
    class Banco 
    {
        public void CriarConta (int x, int y)
        {
        	Random random = new Random();
        	
        }

        public static int Subtracao(int x, int y)
        {
            return x - y;
        }

        public static int Multiplicacao(int x, int y)
        {
            return x * y;
        }

        public static int Divisao(int x, int y)
        {
            // Verifica se y é 0 para evitar divisão por zero
            if (y == 0)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
                return 0;
            }
            return x / y;
        }
    }

    class Program
    {
        class Program
    {
        static Dictionary<string, ContaBancaria> contas = new Dictionary<string, ContaBancaria>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU BANCÁRIO ===");
                Console.WriteLine("1 - Criar Conta");
                Console.WriteLine("2 - Excluir Conta");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("4 - Sacar");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
               
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CriarConta();
                        break;
                    case "2":
                        ExcluirConta();
                        break;
                    case "3":
                        Depositar();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Console.WriteLine("Saindo do sistema. Até mais!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
            // Realizar as operações
            int somar = Calculador.Soma(x, y);
            int subtrair = Calculador.Subtracao(x, y);
            int multiplicar = Calculador.Multiplicacao(x, y);
            int dividir = Calculador.Divisao(x, y);

            // Exibir resultados
            Console.WriteLine($"Resultado da soma: {somar}");
            Console.WriteLine($"Resultado da subtração: {subtrair}");
            Console.WriteLine($"Resultado da multiplicação: {multiplicar}");
            Console.WriteLine($"Resultado da divisão: {dividir}");

            // Aguardar o usuário pressionar qualquer tecla
            Console.Write("Pressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}

