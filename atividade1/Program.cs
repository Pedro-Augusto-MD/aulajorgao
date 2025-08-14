using System;

public class atividade1
{
    public static void Main(string[] args)
    {

        double n1, n2, trabalho1, trabalho2, prova1, prova2, provafinal, media, mediafinal;

        Console.WriteLine("qual a nota do seu primeiro trabalho? ");
        trabalho1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("qual a nota da sua primeira prova? ");
        prova1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("qual a nota do seu segundo trabalho? ");
        trabalho2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("qual a nota da sua segunda prova? ");
        prova2 = Convert.ToDouble(Console.ReadLine());

        n1 = (trabalho1 * 0.3) + (prova1 * 0.7);
        n2 = (trabalho2 * 0.3) + (prova2 * 0.7);

        media = n1 + n2;

        if (media >= 7)
        {
            Console.WriteLine("aprovado!!");
        }
        else if (media >= 3 && media < 7)
        {
            Console.WriteLine("voce fez a prova final?");
            Console.WriteLine("1 = sim | 2 = nao");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("qual a nota da sua prova final?");
                provafinal = Convert.ToDouble(Console.ReadLine());

                mediafinal = (provafinal + media)/2;

                if (mediafinal >= 5)
                {
                    Console.WriteLine("aprovado!!");
                }
                else
                {
                    Console.WriteLine("reprovado!!");
                }
            }
        }
        else
        {
            Console.WriteLine("reprovado!!");
        }
    }
}