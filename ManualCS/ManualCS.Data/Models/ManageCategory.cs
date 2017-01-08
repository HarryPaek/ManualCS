using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualCS.Data.Models
{
    public class ManageCategory
    {
        public ManageCategory(string headerText) : this(headerText, new List<ManageItem>())
        {
        }

        public ManageCategory(string headerText, List<ManageItem> items)
        {
            this.HeaderText = headerText;
            this.Name = headerText;
            this.Items = items;
        }

        public String HeaderText { get; set; }

        public String Name { get; set; }

        public IList<ManageItem> Items { get; private set; }
    }
}
