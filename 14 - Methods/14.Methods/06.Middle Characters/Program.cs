namespace _06.Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] string1 = Console.ReadLine().ToCharArray();
      
            char firstNumberOfString1Even;
            char secondNumberOfString1Even;
            char firstNumberOfString1Odd;
            
            if ((string1.Length) % 2 == 0)             //1234
            {
                //Console.WriteLine("Two number");
             
                int middleOFstring1 = string1.Length / 2;
               
                int foreachCounter = 0;   
              foreach (char c in string1) 
                {
                    foreachCounter++;

                    if (foreachCounter == middleOFstring1)
                    {
                        firstNumberOfString1Even = c;
                        Console.Write(c);
                    }
                    if (foreachCounter == middleOFstring1 + 1)
                    {
                        secondNumberOfString1Even = c;
                        Console.Write(c);
                    }

                }

                
            }
            else                                       //12345  
            {
                int foreachCounter = 0; 
                 int middleОdd = string1.Length / 2;

                foreach (var c in string1)
                {
                  
                    if (foreachCounter == middleОdd )
                    {
                        firstNumberOfString1Odd = c;
                        Console.WriteLine(c);
                    }
                    foreachCounter++;
                }

            }

        }
    }
}