using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int b = 0; // contador
        int a = 0; // linhas
        int c = 0; // maior idade
        int d = 0; // menor q 5
        int e = 0; // maior q 18
        double f = 0; //resto das pessoas
        
        
        while(a != 10){
            a = a + 1;
            Console.Write ("Escreva a idade: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(b > c ){
                c = c * 0 + b;
            } 
            if(b < 5){
                d++;
            }
             if(b > 18){
                e++;
            }
             if(b != 0){
                f = b + f;
            }
        }
        Console.WriteLine("\nMédia:\n" + f / 10);
        Console.WriteLine("\nMaior de 18:\n" + e);
        Console.WriteLine("\nMenor de 5:\n" + d);
        Console.WriteLine("\nMaior idade:\n" + c + "\n");
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();
    }
}