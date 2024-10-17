using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" provide 1 number to perform the addtion operation ");
        string Add1 = Console.ReadLine();
        int AddNumber1 = int.Parse(Add1);
        Console.WriteLine(" provide a number to add to " + AddNumber1);
        string Add2 = Console.ReadLine();
        int AddNumber2 = int.Parse(Add2);
        Console.WriteLine("Easy " + (AddNumber1 + AddNumber2));
       
       
        Console.WriteLine(" proivde a number for subtraction ");
        string Sub1 = Console.ReadLine();
        int SubNumber1 = int.Parse(Sub1);
        Console.WriteLine(" provide a number to subtract from " + SubNumber1);
        string Sub2 = Console.ReadLine();
        int SubNumber2 = int.Parse(Sub2);
        Console.WriteLine(" Easy " + ( SubNumber1 - SubNumber2 ));

        Console.WriteLine(" provide a number for mulipitcation ");
        string Multiply1 =Console.ReadLine();
        int MultiplyNumber1= int.Parse(Multiply1);
        Console.WriteLine(" provide a number to mutiply " + MultiplyNumber1);
        string Mutiply2 =Console.ReadLine();
        int MultiplyNumber2 = int.Parse(Mutiply2);
        Console.WriteLine("super easy "+  ( MultiplyNumber1 * MultiplyNumber2));
        
        Console.WriteLine(" provide a number for dvision ");
        string Divide1 =Console.ReadLine();
        int DivsionNumber1 = int.Parse(Divide1);
        Console.WriteLine(" provide a number to divde by " + DivsionNumber1);
        string Divide2 = Console.ReadLine();
        int DivisionNumber2= int.Parse(Divide2);
        Console.WriteLine(" too easy "  + ( DivisionNumber2 / DivisionNumber2 ));

        Console.WriteLine(" Provide a number for Modules ");
        string Modules1 =Console.ReadLine();
        int ModulesNumber1 =int.Parse(Modules1);
        Console.WriteLine(" Provide a second number to ");
        string Modules2 =Console.ReadLine();
        int ModulesNumber2 =int.Parse(Modules2);
        Console.WriteLine(" Super easy " + ( ModulesNumber1 % ModulesNumber2));
        
         Console.WriteLine(" Provide A number for  Float operation ");
        string Decimal1 =Console.ReadLine();
        float Number1 =int.Parse(Decimal1);
        Console.WriteLine(" Provide a second number for Float operation");
        string Decimal2 =Console.ReadLine();
        float Number2 =int.Parse(Decimal2);
        Console.WriteLine(" this is nothing " + (Number1 /  Number2));

        

        




    

        







    }
}

