//Manuel Rojas Henarejos
using System;

public class Bucles
{
    public static void Main()
    {
        int n1 , n2;
        
        Console.Write("Introduce un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce un número: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        int mayor , menor;
        
        if (n1 > n2)
        {
            mayor = n1;
            menor = n2;
        }
        else
        {
            mayor = n2;
            menor = n1;
        }
        
        for (int i = mayor ; i >= menor ; i--)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
           
        for (int i = mayor ; i >= menor ; i-=2)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        
        int totalWhile = mayor;
        
        while(totalWhile >= menor)
        {
            Console.Write("{0} ",totalWhile);
            totalWhile--;
        }
        Console.WriteLine();
        
        do
        {
            Console.Write("{0} ",mayor);
            mayor--;
            
        }while(mayor >= menor);
        Console.WriteLine();
    }
}
