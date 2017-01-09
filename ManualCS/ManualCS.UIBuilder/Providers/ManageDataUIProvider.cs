using ManualCS.Data.Models;
using ManualCS.Data.Providers;
using ManualCS.UIBuilder.Abstracts;
using ManualCS.UIBuilder.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIBlend.WinForms.Controls;

namespace ManualCS.UIBuilder.Providers
{
    public class ManageDataUIProvider : IManageDataUIProvider
    {
        private ImageList iconList = new IconProvider().IconList;
        private ManageItemEventHandler manageItemEventHandler = new ManageItemEventHandler();
        
        public IEnumerable<Control> GetUIComponents()
        {
            return GetManageDataUIComponents();
        }

        private IEnumerable<Control> GetManageDataUIComponents()
        {
            List<vNavPaneItem> manageDataUIList  = new List<vNavPaneItem>();
            ManageDataProvider dataProvider = new ManageDataProvider();

            foreach (ManageCategory category in dataProvider.GetList())
            {
                var navPaneItem = BuildUICartegory(category);
                BuildUICategorySubItem(navPaneItem, category.Items);

                manageDataUIList.Add(navPaneItem);
            }

            return manageDataUIList;
        }

        private vNavPaneItem BuildUICartegory(ManageCategory category)
        {
            vNavPaneItem vNavPaneItemEx = new vNavPaneItem();

            vNavPaneItemEx.BackColor = System.Drawing.Color.White;
            vNavPaneItemEx.HeaderText = category.HeaderText;
            vNavPaneItemEx.TooltipText = category.HeaderText;
            vNavPaneItemEx.Name = string.Format("vNavPItem{0}", category.Name);
            // vNavPaneItemEx.TabIndex = this.vNavCategory.Items.Count;
            vNavPaneItemEx.Text = category.Name;

            vNavPaneItemEx.ItemPanel.AutoScroll = true;

            // this.vNavCategory.Controls.Add(vNavPaneItemEx);
            // this.vNavCategory.Items.Add(vNavPaneItemEx);

            return vNavPaneItemEx;
        }

        private void BuildUICategorySubItem(vNavPaneItem category, IEnumerable<ManageItem> items)
        {
            int index = 0;
            foreach (ManageItem item in items)
            {
                category.ItemPanel.Controls.Add(GetSubItemButton(item, index));
                index++;
            }
        }

        private Button GetSubItemButton(ManageItem item, int index)
        {
            Button buttonEx = new Button();

            buttonEx.Name = item.Name;
            buttonEx.Text = item.HeaderText;
            buttonEx.Size = new System.Drawing.Size(180, 45);
            buttonEx.Location = new System.Drawing.Point(25, 15 + index * (45 + 10));
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

    }
}
