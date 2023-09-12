using System.Collections;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] NumArr = new int[5];
            NumArr[0] = 1;
            NumArr[1] = 2;
            NumArr[2] = 3;
            NumArr[3] = 4;
            NumArr[4] = 5;
            Console.WriteLine(NumArr.Length);
            foreach (int i in NumArr)
            {
                Console.WriteLine(i);
            }
           // Console.WriteLine("Hello, World!");
           ArrayList arrayList = new ArrayList();   
            arrayList.Add(1);       
             arrayList.Add(2);

            Console.WriteLine(arrayList.Count);
            ArrayDuplicate.Duplicate();
            UniqueElements.elements();
        }
       
    }
}