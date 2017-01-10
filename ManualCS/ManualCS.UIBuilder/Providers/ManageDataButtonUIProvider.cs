using ManualCS.Data.Models;
using ManualCS.Data.Providers;
using ManualCS.UIBuilder.Abstracts;
using ManualCS.UIBuilder.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualCS.UIBuilder.Providers
{
    public class ManageDataButtonUIProvider : IManageDataUIProvider
    {
        private ManageItemEventHandler manageItemEventHandler = null;

        private Dictionary<string, IEnumerable<Control>> categoryItems = new Dictionary<string, IEnumerable<Control>>(StringComparer.OrdinalIgnoreCase);
        private ImageList iconList = new IconProvider().IconList;

        public ManageDataButtonUIProvider(Action<ManageItem> manageItemButtonClickAction)
        {
            this.manageItemEventHandler = new ManageItemEventHandler(manageItemButtonClickAction);
        }

        # region IManageDataUIProvider implementation

        public IEnumerable<Control> GetUIComponents()
        {
            return GetManageDataUIComponents();
        }

        public void BuildSubItemUI(Control parent, Control container)
        {
            if (parent == null || container == null)
                return;

            container.Controls.Clear();
            if (categoryItems.ContainsKey(parent.Name))
            {
                foreach (Control categoryItem in categoryItems[parent.Name])
                {
                    container.Controls.Add(categoryItem);
                }
            }

            return;
        }

        #endregion

        #region Private Methods

        private IEnumerable<Control> GetManageDataUIComponents()
        {
            List<Button> manageDataCategoryButtonList = new List<Button>();
            ManageDataProvider dataProvider = new ManageDataProvider();

            int index = 0;
            foreach (ManageCategory category in dataProvider.GetList())
            {
                var categoryButton = BuildUICartegory(category, index);
                BuildUICategorySubItem(categoryButton, category.Items);

                manageDataCategoryButtonList.Add(categoryButton);
                index++;
            }

            return manageDataCategoryButtonList;
        }

        private Button BuildUICartegory(ManageCategory category, int index)
        {
            Button categoryButton = new Button();

            categoryButton.UseVisualStyleBackColor = true;
            categoryButton.BackColor = System.Drawing.Color.White;
            categoryButton.Name = string.Format("btnCategory{0}", category.Name);
            categoryButton.Text = category.HeaderText;

            categoryButton.Size = new Size(125, 35);
            categoryButton.Location = new Point(10, 10 + index * (categoryButton.Size.Height + 10));

            return categoryButton;
        }

        private void BuildUICategorySubItem(Button category, IEnumerable<ManageItem> items)
        {
            List<Button> categorySubItem = new List<Button>();

            int index = 0;
            foreach (ManageItem item in items)
            {
                categorySubItem.Add(GetSubItemButton(item, index));
                index++;
            }

            categoryItems.Add(category.Name, categorySubItem);
        }

        private Button GetSubItemButton(ManageItem item, int index)
        {
            Button buttonEx = new Button();

            buttonEx.Name = item.Name;
            buttonEx.Text = item.HeaderText;
            buttonEx.Size = new System.Drawing.Size(180, 45);
            buttonEx.Location = new System.Drawing.Point(10, 25 + index * (buttonEx.Size.Height + 10));
            buttonEx.BackColor = System.Drawing.Color.White;
            buttonEx.TabIndex = index;
            buttonEx.TabStop = false;
            buttonEx.Tag = item;

            buttonEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEx.ImageList = this.iconList;
            buttonEx.ImageIndex = item.IconIndex;

            buttonEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;

            // Set Event Handler for Button Click
            buttonEx.Click += manageItemEventHandler.EventHandler;

            return buttonEx;
        }

        #endregion
    }
}
