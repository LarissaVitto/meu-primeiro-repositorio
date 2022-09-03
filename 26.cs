using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int b = 0; //contador
        int a = 0; //qtd linhas
        int c = 0; //num pares
        int d = 0; //num impares
        
        
        while(a != 6){
            a = a + 1;
            Console.Write ("Escreva um número: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(b % 2  == 0){
                c = c + 1;
            } else{
                d = d + 1;
            }
        }
           
            
         Console.WriteLine(c + " números são pares e " + d + " números são ímpares");
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();

    }
}