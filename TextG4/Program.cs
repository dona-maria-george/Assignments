using System;

namespace TextG4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int wrds = 0, ch = 0, sps = 0, spch = 0, vow = 0,i=0,l;
            Console.WriteLine("Enter the text");
            text = Console.ReadLine();
            l = text.Length;
            while(i<l)
            {
                if((text[i]==' '|| text[i]=='\t')&&(text[i+1]!=' '&& text[i+1] != '\t'))
                {
                    sps++;
                    wrds++;
                }

                if(text[i]=='!'||text[i]=='@'||text[i]=='#'
                    ||text[i]=='$' || text[i] == '%' || text[i] == '^' || text[i] == '&' || text[i] == '*' 
                    || text[i] == '(' || text[i] == ')' || text[i] == '_' || text[i] == '-' || text[i] == '+' || text[i] == '='
                    || text[i] == '{' || text[i] == '}' || text[i] == '[' || text[i] == ']' || text[i] == ':'
                    || text[i] == ';' || text[i] == '"' || text[i] == '\'' || text[i] == '|' || text[i] == '\\')
                    spch++;
                
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                    vow++;

                i++;
            }
            wrds++;
            Console.WriteLine("Number of words:" + wrds +"\nNumber of charas:"+l+"\nNumber of spcl charas:"+spch+"\nNUmber of Vowels:"+vow+ "\nNumber of spaces:"+sps);
        }
    }
}
