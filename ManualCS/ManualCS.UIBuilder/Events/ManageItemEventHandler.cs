using ManualCS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualCS.UIBuilder.Events
{
    public class ManageItemEventHandler
    {
        private EventHandler eventHandler = null;

        public EventHandler EventHandler
        {
            get
            {
                if (eventHandler == null)
                    eventHandler = new EventHandler(ManageItemButton_Click);

                return eventHandler;
            }
        }

        private void ManageItemButton_Click(object sender, EventArgs e)
        {
            ManageItem manageItem = RetrieveManageItemFromButtonTag(sender as Control);

            if (manageItem != null)
                MessageBox.Show(string.Format("파일 [{0}]이(가) 선택되었습니다.", manageItem.FileName), "Selected ManageItem", MessageBoxButtons.OK);
        }

        private ManageItem RetrieveManageItemFromButtonTag(Control control)
        {
            if (control != null)
                return control.Tag as ManageItem;

            return null;
        }
    }
}
