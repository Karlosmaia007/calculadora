using System;

namespace Calculadora
{
    class Program
    {



         
        static void Main(string[] args)
        {  

            while(UserInputBool("DESEJA CALCULAR?"))
            {
          double  x = UserInputDouble("digite  primeiro numero");
          double  y =  UserInputDouble("digite  segundo numero");
            Execute(x,y);
            }
        }

        static void Execute(double x , double y )
        {
            do
            {
                string operation = UserInputOperation();
                double res = 0.0;
                if(operation == "+")
                res = Somar(x,y);
                 if(operation == "-")
                res = Subtrair(x,y);
                 if(operation == "*")
                res = Multiplicar(x,y);
                 if(operation == "/")
                res = Dividir(x,y);
                Console.WriteLine($"o RESULTADO DE {x} {operation} {y} = { res } ");

                
            } while (UserInputBool("DESEJA CONTINUAR CALCULANDO?"));
        }
                    static double Somar(double x , double y ){
                        return x + y ; 
                    }

                    static double Subtrair(double x , double y ){
                        return x - y ; 
                    }

                    static double Multiplicar(double x , double y ){
                        return x * y ; 
                    }

                    static double Dividir(double x , double y ){
                        return x / y ; 
                    }

                static bool UserInputBool(string pergunta){

                        do
                        {
                                string stop = UserInput($"{pergunta} DIGITE SIM OU NÃO");
                                if(string.Equals(stop, "não", StringComparison.InvariantCultureIgnoreCase))
                                return false ; 
                                 if(string.Equals(stop, "sim", StringComparison.InvariantCultureIgnoreCase))
                                return true;    
                        } while (true);

                }



         static  string UserInputOperation(){
          do
          {
 
         Console.WriteLine("QUAL OPERAÇÃO DESEJA ");
         Console.WriteLine("+ SOMAR");
         Console.WriteLine(" - SUBTRAIR");
         Console.WriteLine(" * MULTIPLICAR");
         Console.WriteLine(" / DIVIDIR");
            
            string operation = UserInput("  +  ,  - ,*  , / ");

            if(operation == "+")
            return operation;
            if(operation == "-")
            return operation;
            if(operation == "*")
            return operation;
            if(operation == "/")
            return operation;
            
    } while (true);
}


    static double UserInputDouble(string pergunta){
        do
        {
            string read = UserInput(pergunta);

            if(double.TryParse(read, out double value))
            return value;

            Console.WriteLine("digite um numero! ");

        } while (true);
    }

        static string UserInput(string pergunta){

            do {


                      Console.WriteLine(pergunta);
                        string read = Console.ReadLine();
                        if(!string.IsNullOrWhiteSpace(read ))
                        return read;

            }while(true);
        }


       
    }
}
