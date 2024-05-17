using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public class LoggingProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        private ConsoleLogger logger;

        public LoggingProxyDataset()
        {
            logger = ConsoleLogger.GetInstance();
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }

            return dataset.GetData();
        }

        public void LogMessage(string message)
        {
            logger.LogMessage(message);
        }
    }
}
