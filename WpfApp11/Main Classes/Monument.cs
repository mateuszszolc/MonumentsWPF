using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;

namespace WpfApp11
{
    class Monument
    {
       public int monumentId { get; set; }
       public string monumentName { get; set; }
       public string cityId { get; set; } 
    }
}
