using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterUISample.FilterControls
{
    public partial class NumberFilterControl : UserControl
    {
        public NumberFilterControl(string filterName)
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
