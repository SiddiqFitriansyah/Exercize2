using System;

namespace Execize2
{
    class Program
    {
        //Deklarasi Array dengan ikuran 25
        int[] Siddiq = new int[25];

        //Deklarasi Variabel int untuk menyimpan banyaknya data
        int n;

        public void read()
        {
            //Menerima angka untuk menyatukan banyaknya data
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen pada Array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 41)
                    break;
                else
                    Console.WriteLine("/nArray dapat mempunyai maksimal 41 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Masukkan Jumlah Elemen Pada Array");
            Console.WriteLine("-------------------------------------");

            //Memasukkan Elemen Pada Array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + i) + ">");
                string s1 = Console.ReadLine();
                Siddiq[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan Array yang telah Tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element Array yang Telah Tersusun");
            Console.WriteLine("---------------------------------");
            for (int SF = 0; SF < n; SF++)
            {
                Console.WriteLine(Siddiq[SF]);
            }
            Console.WriteLine("");
        }
        static public void MergeSort(int[] numbers, int low, int mid, int high)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = low;
            num = (high - low + 1);

            while ((low <= eol) && (mid <= high))
            {
                if (numbers[low] <= numbers[mid])
                    temp[pos++] = numbers[low++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (low <= eol)
                temp[pos++] = numbers[low++];
            while (mid <= high)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[high] = temp[high];
                high--;
            }
            
        }
        static public void SortMerge(int[] numbers, int low, int high)
        {
            int mid;
            if (high > low)
            {
                mid = (high + low) / 2;
                SortMerge(numbers, low, mid);
                SortMerge(numbers, (mid + 1), high);
                MergeSort(numbers, low, (mid + 1), high);
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the MergeSort and SortMerge Class
            Program myList = new Program();

            Console.Write("\nProgram Sorting Array Dengan Menggunakkan MergeSort");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\nMasukkan Jumlah Elemen Pada Array ");
            Console.WriteLine("----------------------------------------");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Meampilkan Kembali Array Awal yang Telah Dimasukkan sebelumnya
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Input kembali array awal yang telah dimasukkan : ");
            Console.WriteLine("-------------------------------------------------");
            for (int k = 0; k < max; k++)
            {
                Console.Write(numbers[k] + " ");
                Console.Write("\n");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element Array Yang Telah Tersusun");
            Console.WriteLine("---------------------------------");
            SortMerge(numbers, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadLine();
        }

    }
}