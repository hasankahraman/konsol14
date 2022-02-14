using System;

namespace konsol14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive fonks - Özyinelemeli
            //3^4 = 3*3*3*3

            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }

            Console.WriteLine(result);

            Islemler islem = new Islemler();
            int sonuc = islem.Expo(3,5);

            Console.WriteLine(Convert.ToString(sonuc));


            // Extension metotlar
            string ifade = "Hasan KAHRAMAN";
            bool sonucE = ifade.CheckSpaces();
            Console.WriteLine(sonucE);

            if(sonucE){
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());

            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {9,3,6,0,2,5,4};

            dizi.SortArray();

            dizi.EkranaYazdir();

            int num = 5;
            Console.WriteLine(num.IsEven());

            string deneme = "İzmir";
            Console.WriteLine(deneme.GetFirstCharacter());


        }
    }

    public class Islemler{

        public int Expo (int sayi, int us){
            if (us<2)
            {
                return sayi;
            }

            return Expo(sayi, us-1)* sayi;
        }
    }

    public static class Extensions{

        public static bool CheckSpaces( this string param){
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param){

            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);

        }

        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param){
            
            Array.Sort(param);

            return param;
        }

        public static void EkranaYazdir(this int[] param){
            foreach (var sayi in param)
            {
                Console.WriteLine(sayi);
            }
        }

        public static bool IsEven(this int param){
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param){
            return param.Substring(0,1);
        }
    }
}
