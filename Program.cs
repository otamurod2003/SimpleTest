using System;


namespace test
{
    class program
    {
        static void Main(string[] args)
        {
            string succesMsg = "To'g'ri", errorMsg = "Noto'g'ri";

            Console.WriteLine("Testimizga xush kelibsiz");
            //1-savol
            Console.Write($"{1}-savol Amir Temur nechanchi yil tug'ilgan: ");
            string question1 = Console.ReadLine();
            if (question1 == "1336")
                Console.WriteLine(succesMsg);
            else
                Console.WriteLine(errorMsg);


            //2-savol
            Console.Write($"{2}-savol: Uzb nechanchi yil mustaqil bo'lgan? :");
            string question2 = Console.ReadLine();
            if (question2 == "1991")
                Console.WriteLine(succesMsg);
            else
                Console.WriteLine(errorMsg);

            //3-savol
            Console.Write($"{3}-savol: Uzb davlat bayrog'i nechanchi yil qabul qilingan? :");
            string question3 = Console.ReadLine();
            if (question3 == "1991")
                Console.WriteLine(succesMsg);
            else
                Console.WriteLine(errorMsg);

            //4-savol
            Console.Write($"{4}-savol: Uzb davlat madhiyasi nechanchi yil qabul qilingan? :");
            string question4 = Console.ReadLine();
            if (question4 == "1992")
                Console.WriteLine(succesMsg);
            else
                Console.WriteLine(errorMsg);
             yakunlandi();

        }
        static string yakunlandi()
        {
            return "FINISH";
        }
    }
}