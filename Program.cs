using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int step = 1; step < 26; step++)
            {
              var  decryptText = " jqrrg, jqrrg,tgkvgt jqrrg jqrrg,tgkvgt,ygpp gt hcgnnv,fcpp uejtgkv gt hcgnnv gt kp fgp ıtcdgp htguugp kjp fkg tcdgp,hgnnv gt kp fgp uworh fcpp ocejv fgtt tgkvgt rnworu"
               + "jworva fworva jworva fworva ucv qp cycnn jworva fworva jcf citgcv hcnn  cnn vjg mkpi u jqtugu cpf cnn vjg mkpi u ogp eqwnfp v rwv jworva vqigvjgt cickp";
                List<char> alpha = new List<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray()); 
                List<char> chareArry = new List<char>(decryptText.Trim().ToCharArray());
                for (int i =0; i < decryptText.Length-1 ; i++)
                {
                    var control = alpha.IndexOf(chareArry[i]);
                    if (control > 0)
                    {                       
                        chareArry[i] = alpha[(control + step) % 25];
                    }
                   
                }
                for (int k = 0; k < chareArry.Count; k++)
                {
                    Console.Write(chareArry[k]);

                }               
                Console.WriteLine(chareArry.Count);          
                Console.ReadKey();
                chareArry.Clear();
            }
               
        }
    }
}
