using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int i = 500;
        int a = 0;
        
        while(i != 0){
            a = a + i;
            Console.Write (i + " + ");
            i = i - 50; 
        }
            
        Console.WriteLine("0 = " + a);
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();

    }
}