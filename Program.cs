using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_methods_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Raghsana";
            var sentence1 = "  My name is Raghsana  ";
            var result = sentence.LastIndexOf(" "); //sonuncu boslugun indeksi
            var result1=sentence.LastIndexOf("Raghsana");
            var result2=sentence.LastIndexOf('m');

            var result3 = sentence.Substring(3,6); //3 cu simvoldan sonra 6 simvolu goturur
            var result4=sentence.Substring(3);     //3 cu indeksden sonra her seyi goturur

            var result5=sentence.Replace(" ", "-");  //bosluq evezine "-" elave etsin

            var result6=sentence.Contains("name");   //true
            var result7=sentence.Contains("nameee"); //false

            var result8=sentence1.Trim(); //basdaki ve sondaki bosluqlari atir
            
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.WriteLine(result3); 
            Console.WriteLine(result4);

            Console.WriteLine(result5);

            Console.WriteLine(result6);
            Console.WriteLine(result7);

            Console.WriteLine(result8);
            
        }
    }
}
