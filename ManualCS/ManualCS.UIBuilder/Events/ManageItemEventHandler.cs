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
        private Action<ManageItem> manageItemButtonClickAction = null;

        public ManageItemEventHandler()
        {
        }

        public ManageItemEventHandler(Action<ManageItem> manageItemButtonClickAction)
        {
            this.manageItemButtonClickAction = manageItemButtonClickAction;
        }

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

            var clickAction = manageItemButtonClickAction;

            if (clickAction != null)
                clickAction(manageItem);
        }

        private ManageItem RetrieveManageItemFromButtonTag(Control control)
        {
            if (control != null)
                return control.Tag as ManageItem;

            return null;
        }
    }
}
