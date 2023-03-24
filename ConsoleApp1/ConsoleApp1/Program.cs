using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SimpleDataBase<long> wiliam = new SimpleDataBase<long>();
           wiliam.addnewdata(13);
           wiliam.addnewdata(02);
           wiliam.addnewdata(21);
        }

        public class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;

            public SimpleDataBase()
            {
                storedData = new List<T>();
                inputDates = new List<DateTime>();
            }
            
            public void addnewdata(T T)  
            {
                storedData.Add(T);
                inputDates.Add(DateTime.Now);
            }

            public void PrintAllData()
            {
                for(int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine("Data " + (i + 1) + "berisi: " + storedData[i] + " yang disimpan pada waktu" + inputDates[i]);
                }
                
            }
        }
    }
}
