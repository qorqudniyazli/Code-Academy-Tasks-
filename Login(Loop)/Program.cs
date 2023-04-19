internal class Program
{
    private static void Main(string[] args)
    {
        string kullaniciAdi = "admin";
        string sifre = "123";

        while (true)
        {
            Console.WriteLine("\nKullanici adi: ");
            string username = Console.ReadLine();

            Console.WriteLine("Sifre: ");
            string password = Console.ReadLine();

            if (username == kullaniciAdi && password == sifre)
            {
                Console.WriteLine("Giris edildi!");
                return;
                //break;
            }
            else Console.WriteLine("Yanlis bilgi!");
        }
    }
}
