using System;
using System.Text;

namespace Cop8_Homeworktimetwo
{
    enum BaiTap
    {
        bai1=1,
        bai2=2,
        bai3=3,
        bai4=4
    }

    class Program
    {
        static int[] ds = null;
     
        public static void Nhap()
        {
            int n;
            Console.WriteLine("Enter so luong elements: ");
            n = int.Parse(Console.ReadLine());
            ds = new int[n];// cấp phát động.
            for (int i = 0; i < ds.Length; i++)
            {
                Console.Write("Input element number {0}: ", i + 1);
                ds[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array after input: ");
            foreach (var item in ds)
            {
                Console.Write(" " + item);
            }
        }
        public static void CopyElementArray()
        {
            int[] dsB = ds;
            Console.WriteLine("\nArray after copy to orther array: ");
            foreach (var item in dsB)
            {
                Console.Write(" " + item);
            }
        }
        public static void ReverseElementArray()
        {
            for (int i = 0; i < ds.Length / 2; i++)// thử căn bậc 2. sqrt(dsa) có tối ưu. i=1, not reversed
            {
                int temp = ds[i];
                ds[i] = ds[ds.Length - i - 1]; //  get value at index dsa.Length - i - 1 : is index end. ; dsa[dsa.Length - i - 1]: value.
                ds[ds.Length - i - 1] = temp;// -1: 'cuz start index 0.
            }
            // reverse array 2:            
            Console.WriteLine("\n3. Elements of ds array after reverse: ");
            foreach (var item in ds)
            {
                Console.Write(" " + item);

            }
        }
        public static void FindElementInArray()
        {
            // Find element in dsa array, dislay it and see 
            int findnumber;
            int count = 0;
            Console.Write("\nNhap so can tim: ");
            findnumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i] == findnumber)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine("Have number {0} in array: ", findnumber);
            }
            else
            {
                Console.WriteLine("Not have number {0} in array: ", findnumber);
            }
            Console.WriteLine("So lan xuat hien in arry: {0}", count);
        }
        public static void InsertElementInArray()
        {
            int[] arr1 = new int[10];
            int i, n, p, x;
            Console.Write("Input size array again: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/           
            for (i = 0; i < n; i++)
            {
                Console.Write("Elements - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input new value would insert: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input postion: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Array current: :\n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);
            /* di chuyen vi tri cac phan tu ben phai cua mang */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];
            /* chen gia tri vao vi tri da cho */
            arr1[p - 1] = x;


            Console.Write("\n\nArray after inserted:\n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n\n");

        }
        static void Main(string[] args)

        {            
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.ForegroundColor = ConsoleColor.White;
            int choice = 0;
            do
            {
                Console.WriteLine("\n-----------------C#-----------------");
                Console.WriteLine("1. Enter array");
                Console.WriteLine("2. Copy array to orther array");
                Console.WriteLine("3. Reverse array");
                Console.WriteLine("4. Looking for element in array, watch the number of occurrences");
                Console.WriteLine("5. Insert a element into array, position inputed from keyboard");
                Console.WriteLine("6. Exit");
                Console.Write("please, input choose: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Nhap(); break;
                    case 2: CopyElementArray(); break;
                    case 3: ReverseElementArray(); break;
                    case 4: FindElementInArray(); break;
                    case 5: InsertElementInArray(); break;
                    case 6: System.Environment.Exit(1); break;
                }
            } while (choice != 6);
            //  Use Enum:
            int input;
            do
            {              
                Console.Write("\n-------Input number 'bai': ");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case (int)BaiTap.bai1:
                        Nhap();
                        CopyElementArray();
                        break;
                    case (int)BaiTap.bai2:
                        Nhap();
                        ReverseElementArray();
                        break;
                    case (int)BaiTap.bai3:
                        Nhap();
                        FindElementInArray();
                        break;
                    case (int)BaiTap.bai4:
                        InsertElementInArray();
                        break;
                    case 5: System.Environment.Exit(1); break;
                    default:
                        Console.WriteLine("Hello Cọp");
                        break;
                }
            } while (input!= 5);
            Console.ReadLine();
        }
    }
}

