using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int i = 6;
        int a = 0;
        
        while(i != 100){
            a = a + i;
            Console.Write (i + " + ");
            i = i + 2; 
        }
            a = a + 100;
            
        Console.WriteLine("100 = " + a);
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();

    }
}