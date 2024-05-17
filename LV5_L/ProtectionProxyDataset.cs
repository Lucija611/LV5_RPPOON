using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public class ProtectionProxyDataset : IDataset
    {
        private Dataset dataset;
        private List<int> allowedIDs;
        public User user { private get; set; }
        public ProtectionProxyDataset(User user)
        {
            this.allowedIDs = new List<int>(new int[] { 1, 3, 4 });
            this.user = user;
        }
        private bool AuthenticateUser()
        {
            return allowedIDs.Contains(this.user.ID);
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (this.AuthenticateUser())
            {
                if (this.dataset == null)
                {
                    this.dataset = new Dataset("C:\\Users\\lucij\\Desktop\\Faks\\4semestar\\RPPOON\\LV\\LV5_L\\LV5_L\\CSV.txt");
                }
                return this.dataset.GetData();
            }
            return null;
        }
    }
}
