using System;
using System.Windows.Forms;

namespace FilterUISample.FilterControls
{
    public partial class TextFilterControl : UserControl
    {
        public TextFilterControl(string filterName)
        {
            InitializeComponent();
            filterLabel.Text = filterName;
            this.Width = this.Width - 57 + filterLabel.Width;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            (this.Parent as FlowLayoutPanel).Controls.Remove(this);
        }
    }
}
