using System;

namespace tp_modul_05
{
    public class HalloGeneric
    {

        public void sapaUser<T>(T entity)
        {
            Console.WriteLine($"Halo Nama Saya {entity}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            string nama;

            HalloGeneric user = new HalloGeneric();

            Console.Write("Masukan Nama kamu : ");
            nama = Console.ReadLine();

            user.sapaUser(nama);

        }
    }
}
