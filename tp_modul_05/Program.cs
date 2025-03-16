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

    class Program
    {
        public static void Main(string[] args)
        {
            GenericData<long> data = new GenericData<long>(103022300110);

            data.printData(103022300110);
        }
    }

}
