using ManualCS.Data.Abstracts;
using ManualCS.Data.Models;
using ManualCS.Data.Providers;
using ManualCS.UI.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIBlend.WinForms.Controls;

namespace ManualCS.UI
{
    public partial class MainWindow : Form
    {
        ManageItemEventHandler manageItemEventHandler = new ManageItemEventHandler();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            IManageDataProvider provider = new ManageDataProvider();
            IEnumerable<ManageCategory> categoryItems = provider.GetList();

            foreach (ManageCategory category in categoryItems)
            {
                var navPaneItem = BuildUICartegory(category);
                BuildUICategorySubItem(navPaneItem, category.Items);
            }

            this.ResumeLayout(false);
        }

        private vNavPaneItem BuildUICartegory(ManageCategory category)
        {
            vNavPaneItem vNavPaneItemEx = new vNavPaneItem();

            vNavPaneItemEx.BackColor = System.Drawing.Color.White;
            vNavPaneItemEx.HeaderText = category.HeaderText;
            vNavPaneItemEx.TooltipText = category.HeaderText;
            vNavPaneItemEx.Name = string.Format("vNavPItem{0}", category.Name);
            vNavPaneItemEx.TabIndex = this.vNavCategory.Items.Count;
            vNavPaneItemEx.Text = category.Name;

            vNavPaneItemEx.ItemPanel.AutoScroll = true;

            this.vNavCategory.Controls.Add(vNavPaneItemEx);
            this.vNavCategory.Items.Add(vNavPaneItemEx);

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
