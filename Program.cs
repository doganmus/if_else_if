using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=18 && time<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if(time<=18)
            {
               Console.WriteLine("İyi Günler"); 
            }
            else
            {
               Console.WriteLine("İyi geceler"); 
            }

            string sonuc= time<=18 ?"iyi günler":"iyi geceler";

            sonuc = time>=6 && time<11 ?"Günaydı" : time<=18 ? "İyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
