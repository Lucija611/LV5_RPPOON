using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
