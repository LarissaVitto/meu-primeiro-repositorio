using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int b = 0; //contador
        int a = 0; //quantidade de linhas
        int c = 0; // maior preço
        int d = 9999999; // menor preço
        
        
        while(a != 8){
            a = a + 1;
            Console.Write ("Escreva o preço: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(b > c ){
                c = c * 0 + b;
            } 
            if(b < d){
                d = d * 0 + b;
            }
        }
        Console.WriteLine("Maior preço:" + c);
        Console.WriteLine("Menor preço:" + d);
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();
    }
}