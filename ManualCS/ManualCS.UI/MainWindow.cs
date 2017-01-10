using ManualCS.UIBuilder.Abstracts;
using ManualCS.UIBuilder.Providers;
using System;
using System.Windows.Forms;

namespace ManualCS.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            IManageDataUIProvider uiProvider = new ManageDataUIProvider();

            foreach (Control category in uiProvider.GetUIComponents())
            {
                category.TabIndex = this.vNavCategory.Items.Count;
                this.vNavCategory.Controls.Add(category);
                this.vNavCategory.Items.Add(category);
            }

            this.ResumeLayout(false);
        }
    }
}
