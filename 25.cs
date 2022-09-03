using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int i = 0; // contador
        int a = 0; // qtd linhas
        int c = 0; // resultado
        
        
        while(a != 7){
            a = a + 1;
            Console.Write ("Escreva um número: ");
            i = Convert.ToInt32(Console.ReadLine());
             c = c + i;
        }
           
            
        Console.WriteLine("o resultado é " + c);
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();

    }
}