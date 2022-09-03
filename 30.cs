using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int F1 = 0;
        int F2 = 1;
        int num = 0;
        int linhas = 0;
        int Fn = 0;
        
        Console.WriteLine("Digite quantos elementos da sequência de Fibonacci deseja visualizar: ");
        num = Convert.ToInt32(Console.ReadLine());

        if(num >= 1){
            Console.WriteLine("0");
        }
        if(num >= 2){
            Console.WriteLine("1");
        }

        while(linhas != num - 2){
            linhas++;
            Fn = F1 + F2;
            Console.WriteLine(Fn);
            F1 = F2;
            F2 = Fn;

        }

        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();

    }
}