using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRApp.Models
{
    public class ListViewContent
    {
        public Dictionary<string, List<ViewContent>> ListOfViewContent { get; set; }
        public ListViewContent(Dictionary<string, List<ViewContent>> val)
        {
            this.ListOfViewContent = val;
        }
    }
}
