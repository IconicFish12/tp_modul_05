using System;

namespace tp_modul_05
{
    public class GenericData<T>
    {
        private readonly T data;

        public GenericData(T data)
        {
            this.data = data;
        }

        public void printData(T data)
        {
            Console.WriteLine($"Data yang tersimpan adalah data {data}");
        }
    }

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
            GenericData<long> data = new GenericData<long>(103022300110);

            data.printData(103022300110);

            string nama;

            HalloGeneric user = new HalloGeneric();

            Console.Write("Masukan Nama kamu : ");
            nama = Console.ReadLine();

            user.sapaUser(nama);

        }
    }

}
