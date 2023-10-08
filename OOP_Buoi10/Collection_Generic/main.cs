using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic
{
    internal class main
    {
        //Generic
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void xuatSV(ArrayList arr)
        {
            foreach (SV item in arr)
            {
                Console.WriteLine(item.Name+" "+item.Age);
            }
        }
        public class sortSVtd : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                SV xx = (SV)x;
                SV yy = (SV)y;
                return xx.Age.CompareTo(yy.Age);//đổi 2 biến xx va yy để thay đổi sắp xếp
            }
        }
        public class sortSVdd : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                SV xx = (SV)x;
                SV yy = (SV)y;
                return xx.Age.CompareTo(yy.Age);//đổi 2 biến xx va yy để thay đổi sắp xếp
            }
        }

        static void Main(string[] args)
        {
            /*ArrayList x = new ArrayList();
            x.Add(1);
            x.Add(2);
            x.Add(3);
            ArrayList y = new ArrayList();
            y.Add(4);
            y.Add(5);

            x.AddRange(y);

            //Console.WriteLine("Count:  "+x.Count);//độ dài mảng
            //Console.WriteLine("Sức chứa:  "+x.Capacity);// sức chứa của mảng
            x.Reverse();
            xuat(x);

            Console.WriteLine("Tim value 1: " + x.BinarySearch(1));// trả về vị trí của phần tử tìm kiếm*/

            ArrayList sv = new ArrayList();

            // Thêm 3 SV vào danh sách
            /*sv.Add(new SV("Nguyen Van A", 18));
            sv.Add(new SV("Nguyen Van B", 25));
            sv.Add(new SV("Nguyen Van C", 20));
            xuatSV(sv);

            sv.Sort(new sortSVtd());
            Console.WriteLine("Danh sach Sinh Vien tang dan: ");
            xuatSV(sv);
            sv.Sort(new sortSVdd());
            Console.WriteLine("Danh sach Sinh Vien giam dan: ");
            xuatSV(sv);
            */



            //Generic
           /* float a = 1, b = 2;

            Swap(ref a, ref b);

            Console.WriteLine(a +" "+ b);

            MyGeneric<int> MyG = new MyGeneric<int>(15);

            MyG.SetItemValue(0, 10);*/

            List<int> list = new List<int>(10);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            

            /*Console.WriteLine(list.IndexOf(3));
            Console.WriteLine(list.IndexOf(2));*/

            Console.ReadKey();
        }
    }
}
