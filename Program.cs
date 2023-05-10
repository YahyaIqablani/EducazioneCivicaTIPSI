using System;

namespace EducazioneCivica
{
    class Sicurezza
    {
         static void Main(string[] args)
        {
             int restart = 0;
            do{
                Console.Write("Inserisci una stringa: ");
                string s = Console.ReadLine();
                Console.Write("Inserisci un numero: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Che funzione vuoi eseguire? ");
                int funz=int.Parse(Console.ReadLine());
                switch(funz)
                {
                    case 1: PrimoPunto(s, n);
                    break;
                    
                    
                }
                


                Console.Write("Rieseguire? 1/0: ");
                restart = int.Parse(Console.ReadLine());
            }while (restart == 1);
            
        
        }
        
        static string s ="";
        static int n = 0;
        
        


        
        
        public static void PrimoPunto(string s,int n)
        {
            return false;
                
        }
       


               


            }
}
        
    
