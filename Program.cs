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
                    case 2: SecondoPunto(s, n);
                    break;
                    
                    
                }
                


                Console.Write("Rieseguire? 1/0: ");
                restart = int.Parse(Console.ReadLine());
            }while (restart == 1);
            
        
        }
        
        static string s ="";
        static int n = 0;
        static string result1="";
         static string result2 ="";
        
        


        
        
        public static void PrimoPunto(string s,int n)
        {
           try{
            
                

                
                char[] arr1 = s.ToCharArray();
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (char.IsLetter(arr1[i]))
                    {
                        char c = (char)(arr1[i] + n);
                        if (c > 'z')
                            c = (char)(c - 26);
                        arr1[i] = c;
                    }
                }
                result1 = new string(arr1);
                Console.WriteLine($"Punto 1: {result1}");
                
                
            }
            catch
            {
                
            }
                
        }
        public static void SecondoPunto(string s,int n)
        {
            return false;
                
        }
       


               


            }
}
        
    
