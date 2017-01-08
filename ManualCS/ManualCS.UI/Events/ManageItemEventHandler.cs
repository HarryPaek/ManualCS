using ManualCS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualCS.UI.Events
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
            ManageItem manageItem = RetrieveManageItemFromButtonTag(sender as Button);

            if (manageItem != null)
                MessageBox.Show(string.Format("파일 [{0}]이(가) 선택되었습니다.", manageItem.FileName), "Selected ManageItem", MessageBoxButtons.OK);
        }

        private ManageItem RetrieveManageItemFromButtonTag(Button button)
        {
            if (button != null)
                return button.Tag as ManageItem;

            return null;
        }
    }
}
