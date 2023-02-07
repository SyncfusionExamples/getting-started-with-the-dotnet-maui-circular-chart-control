using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiExample
{
    public class DataViewModel
    {
        public ObservableCollection<DataModel> Products { get; set; }

        public DataViewModel() {
            Products = new ObservableCollection<DataModel>
            {
                new DataModel { Name="iPad", Sales=16.6},
                new DataModel { Name="iPhone", Sales=18.5},
                new DataModel { Name="MacBook", Sales=13.4},
                new DataModel { Name="Mac", Sales=15.6},
                new DataModel { Name="Others", Sales=36.3}

            };

        }
    }
}
