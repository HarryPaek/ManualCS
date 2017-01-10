using ManualCS.Data.Models;
using ManualCS.UIBuilder.Abstracts;
using ManualCS.UIBuilder.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualCS.UI2
{
    public partial class MainWindow : Form
    {
        IManageDataUIProvider uiProvider = null;

        public MainWindow()
        {
            InitializeComponent();
            uiProvider = new ManageDataButtonUIProvider(ManageItemButtonClickAction);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            EventHandler categoryEventHandler = new EventHandler(ManageCategoryButton_Click);
            var categoryPanel = this.spCategory.Panel1;

            foreach (Control category in uiProvider.GetUIComponents())
            {
                category.TabIndex = categoryPanel.Controls.Count;
                categoryPanel.Controls.Add(category);

                category.Click += categoryEventHandler;
            }

            //Do click event for first button!!!
            ManageCategoryButton_Click(categoryPanel.Controls[0], EventArgs.Empty);

            this.ResumeLayout(false);
        }

        private void ManageCategoryButton_Click(object sender, EventArgs e)
        {
            uiProvider.BuildSubItemUI(sender as Control, this.spCategory.Panel2);
        }

        private void ManageItemButtonClickAction(ManageItem manageItem)
        {
            if (manageItem != null)
                this.rtboxResult.AppendText(string.Format("파일 [{0}]이(가) 선택되었습니다.\n", manageItem.FileName));
        }
    }
}
