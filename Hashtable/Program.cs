using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashtableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] array1 = null;

            long bytes1 = GC.GetTotalMemory(false);
            array1 = new byte[1000 * 1000 * 3];
            //array1[0] = 0;
            long bytes2 = GC.GetTotalMemory(false);
            Console.WriteLine("bytes2 ===", bytes2);
            Console.WriteLine("bytes1 ===", bytes1);


            BitArray bitarraySample = new BitArray(8);


            Hashtable ht = new Hashtable();
           
            ht.Add("001", "mimimi mimi");
            ht.Add("002", "momomom muuuuu");
            ht.Add("003", bytes1);
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);

            Console.WriteLine("Count of hashTable");
            int total = ht.Count;
            Console.WriteLine("Count: {0}", total);

            Console.WriteLine("To look inside of hashTabl: contains key");
            bool answer = ht.ContainsKey("001");
            Console.WriteLine("Does it contain 001 > {0}", answer);



        }
    }
}
