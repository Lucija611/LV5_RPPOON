using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public class VirtualProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        public VirtualProxyDataset(string filePath)
        {
            this.filePath = filePath;
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            return dataset.GetData();
        }
    }
}
