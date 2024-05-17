using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public class DataConsolePrinter
    {
        public void Print(IDataset dataset) 
        {
            ReadOnlyCollection<List<string>> data = dataset.GetData();

            if(data == null)
            {
                Console.WriteLine("There's no data.");
            }
            else
            {
                foreach(List<string> outer in data)
                {
                    foreach(string inner in outer)
                    {
                        Console.Write(inner + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
