using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualCS.UIBuilder.Abstracts
{
    public interface IManageDataUIProvider
    {
        IEnumerable<Control> GetUIComponents();
        void BuildSubItemUI(Control parent, Control container);
    }
}
