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

            List<Material> materRoof = new List<Material>();
            materRoof.Add(_viewModel.CreateMaterial((int)cmbRoof1.SelectedValue, (double)numRoof1.Value));
            materRoof.Add(_viewModel.CreateMaterial((int)cmbRoof2.SelectedValue, (double)numRoof2.Value));
            materRoof.Add(_viewModel.CreateMaterial((int)cmbRoof3.SelectedValue, (double)numRoof3.Value));
            materRoof.Add(_viewModel.CreateMaterial((int)cmbRoof4.SelectedValue, (double)numRoof4.Value));
            Roof strecha = new Roof((double)numAreaRoof.Value,materRoof);
            MessageBox.Show(strecha.Calc().ToString());
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
