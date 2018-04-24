using FilterUISample.FilterControls;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FilterUISample
{
    public partial class mainForm : Form
    {
        BindingSource bs = new BindingSource();
        DataList dl;
        public mainForm()
        {
            InitializeComponent();
            filterCheckBox_CheckedChanged(this, EventArgs.Empty);
            dl = new DataList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bs.DataSource = dl.list;
            mainDataGridView.DataSource = bs;
            mainDataGridView.Refresh();
        }

        private void viewResults()
        {
            DataList fl = new DataList();
            fl.list = dl.list.Where(x => 
                x.name.Contains(mainFlowLayoutPanel.Controls.ContainsKey("nameFindFilter") 
                    ? (mainFlowLayoutPanel.Controls["nameFindFilter"] as TextFilterControl).valueTextBox.Text 
                    : string.Empty
                ) &&
                x.state.Contains(mainFlowLayoutPanel.Controls.ContainsKey("stateFindFilter")
                    ? (mainFlowLayoutPanel.Controls["stateFindFilter"] as TextFilterControl).valueTextBox.Text
                    : string.Empty
                ) && 
                x.price == (mainFlowLayoutPanel.Controls.ContainsKey("priceFindFilter")
                    ? Convert.ToDouble((mainFlowLayoutPanel.Controls["priceFindFilter"] as NumberFilterControl).valueNumericUpDown.Value)
                    : x.price
                ) &&
                x.time.Date == (mainFlowLayoutPanel.Controls.ContainsKey("timeFindFilter")
                    ? (mainFlowLayoutPanel.Controls["timeFindFilter"] as DateFilterControl).valueDateTimePicker.Value.Date
                    : x.time.Date
                )
                ).ToList();
            bs.DataSource = fl.list;
            mainDataGridView.DataSource = bs;
            mainDataGridView.Refresh();
        }

        private void filterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mainSplitContainer.Panel1Collapsed = (!filterCheckBox.Checked);
        }

        private void mainFlowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            mainSplitContainer.SplitterDistance = mainFlowLayoutPanel.Height + 6;
        }

        private void newFilterButton_Click(object sender, EventArgs e)
        {
            if (newFilterComboBox.SelectedIndex == -1) return;
            switch (newFilterComboBox.SelectedIndex)
            {
                case 0:
                    if (mainFlowLayoutPanel.Controls.ContainsKey("nameFindFilter")) break;
                    TextFilterControl nameFindFilter = new TextFilterControl("name");
                    nameFindFilter.Name = "nameFindFilter";
                    nameFindFilter.valueTextBox.TextChanged += Value_ValueChanged;
                    mainFlowLayoutPanel.Controls.Add(nameFindFilter);
                    break;
                case 1:
                    if (mainFlowLayoutPanel.Controls.ContainsKey("stateFindFilter")) break;
                    TextFilterControl stateFindFilter = new TextFilterControl("state");
                    stateFindFilter.Name = "stateFindFilter";
                    stateFindFilter.valueTextBox.TextChanged += Value_ValueChanged;
                    mainFlowLayoutPanel.Controls.Add(stateFindFilter);
                    break;
                case 2:
                    if (mainFlowLayoutPanel.Controls.ContainsKey("priceFindFilter")) break;
                    NumberFilterControl priceFindFilter = new NumberFilterControl("price");
                    priceFindFilter.Name = "priceFindFilter";
                    priceFindFilter.valueNumericUpDown.ValueChanged += Value_ValueChanged;
                    mainFlowLayoutPanel.Controls.Add(priceFindFilter);
                    break;
                case 3:
                    if (mainFlowLayoutPanel.Controls.ContainsKey("timeFindFilter")) break;
                    DateFilterControl timeFindFilter = new DateFilterControl("time");
                    timeFindFilter.Name = "timeFindFilter";
                    timeFindFilter.valueDateTimePicker.ValueChanged += Value_ValueChanged;
                    mainFlowLayoutPanel.Controls.Add(timeFindFilter);
                    break;
            }
        }

        private void Value_ValueChanged(object sender, EventArgs e)
        {
            viewResults();
        }

        private void mainFlowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            viewResults();
        }

        private void mainFlowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            viewResults();
        }
    }
}
