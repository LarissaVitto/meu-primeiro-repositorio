using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int cont = 0; // contador
        int linhas = 0; // linhas
        char sexo; // sexo
        int m = 0; // mulher
        int ho = 0; // homem
        double me = 0; //resto pra media
        int h = 0; // media homem
        int m20 = 0; //qts mulher mais 20
        
        
        while(linhas != 5){
            linhas = linhas + 1;
            Console.Write ("Escreva a idade: ");
            cont = Convert.ToInt32(Console.ReadLine());
            Console.Write ("Escreva o sexo: ");
            sexo = Convert.ToChar(Console.ReadLine());
            if(sexo == 'm' ){
                m++;
            } else{
                ho++;
                h = cont + h;
            }
             if(cont > 18){
                ho++;
            }
             if(sexo == 'm' && cont >= 20){
                m20++;
            }
            if(cont != 0){
                me = cont + me;
            }
        }
        Console.WriteLine("\nHomens: \n" + ho);
        Console.WriteLine("\nMulheres: \n" + m);
        Console.WriteLine("\nMédia:\n" + me / 5);
        Console.WriteLine("\nMédia homens: \n" + h / ho);
        Console.WriteLine("\nMulheres com mais de 20 anos: \n" + m20 + "\n");
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();
    }
}