using System;

namespace alvin
{

	class calculadora{
		
		public static int  somar (int x, int y){
			return x + y;
		}
		public static int  subtrair (int x, int y){
			return x - y;
		}
		public static int multiplicar (int x, int y){
			return x * y;
		}
		public static int dividir (int x, int y){
			return x / y;
		}
		
	}
	
class Program
{
    public static void Main(string[] args)
    {
		
    	Console.WriteLine("escreva um numero");
    		int numero = int.Parse(Console.ReadLine());
    	
    	Console.WriteLine("escreva um numero");
    		int numero2 = int.Parse(Console.ReadLine());
	    
    	int resultadoSoma = calculadora.somar(numero, numero2);
    		int resultadoSubtracao = calculadora.subtrair(numero, numero2);
    			int resultadoMultiplicacao = calculadora.multiplicar(numero, numero2);
    				double resultadoDivisao = calculadora.dividir(numero, numero2);
    	
    	Console.WriteLine("a soma dos numeros é: {0} ",resultadoSoma);
    		Console.WriteLine("a subtração dos numeros é: {0} ",resultadoSubtracao);
    			Console.WriteLine("a multiplicação dos numeros é: {0} ",resultadoMultiplicacao);
    				Console.WriteLine("a divisao dos numeros é: {0} ",resultadoDivisao);
    	
    	Console.ReadKey();
    }
}

}
