using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyLoss
{
    public partial class MainView : Form
    {
        private MainViewModel _viewModel;


        public MainView(MainViewModel mainViewModel)
        {
            _viewModel = mainViewModel;
            InitializeComponent();
            Init();

        }
        private void Init()
        {
            ComboBoxMethod(cmbRoof1);
            ComboBoxMethod(cmbRoof2);
            ComboBoxMethod(cmbRoof3);
            ComboBoxMethod(cmbRoof4);

        }

        public void ComboBoxMethod(ComboBox cmb)
        {
            cmb.DataSource = _viewModel.GetMaterials();
            cmb.BindingContext = new BindingContext();
            cmb.DisplayMember = (nameof(Material.Name));
            cmb.ValueMember = nameof(Material.Id);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.Title = txtTitle.Text;
            _viewModel.Name = txtName.Text;
            _viewModel.MinOutTemp = double.Parse(txtMinOutTmp.Text);
            _viewModel.HeatTemp = double.Parse(txtHeatTmp.Text);
            _viewModel.AreaRoof = (double)numAreaRoof.Value;

            //vytvaranie IdListu z combo pre strechu
            _viewModel.IdRoof.Add((int)cmbRoof1.SelectedValue);
            _viewModel.IdRoof.Add((int)cmbRoof2.SelectedValue);
            _viewModel.IdRoof.Add((int)cmbRoof3.SelectedValue);
            _viewModel.IdRoof.Add((int)cmbRoof4.SelectedValue);
            //vytvaranie WidthListu z numUp pre strechu
            _viewModel.WidthRoof.Add((double)numRoof1.Value);
            _viewModel.WidthRoof.Add((double)numRoof2.Value);
            _viewModel.WidthRoof.Add((double)numRoof3.Value);
            _viewModel.WidthRoof.Add((double)numRoof4.Value);




            MessageBox.Show(_viewModel.CalculateRoof().ToString());
        }

        private void rBtnBuild_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                _viewModel.BuildType = double.Parse(radioButton.Tag.ToString());
            }

        }

        private void rBtnNat_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                _viewModel.NationType = double.Parse(radioButton.Tag.ToString());
            }
        }


}
}
