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
            ComboBoxMethod(cmbWall1);
            ComboBoxMethod(cmbWall2);
            ComboBoxMethod(cmbWall3);
            ComboBoxMethod(cmbWall4);
            ComboBoxMethod(cmbFloor1);
            ComboBoxMethod(cmbFloor2);
            ComboBoxMethod(cmbFloor3);
            ComboBoxMethod(cmbFloor4);

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
            _viewModel.TempDiff = _viewModel.HeatTemp - _viewModel.MinOutTemp;
            _viewModel.TempDiffGrd = _viewModel.HeatTemp - 3;
            _viewModel.AreaRoof = (double)numAreaRoof.Value;
            _viewModel.AreaWall = (double)numAreaWall.Value;
            _viewModel.AreaFloor = (double)numAreaFloor.Value;

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
            //vytvaranie IdListu z combo pre stenu
            _viewModel.IdWall.Add((int)cmbWall1.SelectedValue);
            _viewModel.IdWall.Add((int)cmbWall2.SelectedValue);
            _viewModel.IdWall.Add((int)cmbWall3.SelectedValue);
            _viewModel.IdWall.Add((int)cmbWall4.SelectedValue);
            //vytvaranie WidthListu z numUp pre stenu
            _viewModel.WidthWall.Add((double)numWall1.Value);
            _viewModel.WidthWall.Add((double)numWall2.Value);
            _viewModel.WidthWall.Add((double)numWall3.Value);
            _viewModel.WidthWall.Add((double)numWall4.Value);
            //vytvaranie IdListu z combo pre podlahu
            _viewModel.IdFloor.Add((int)cmbFloor1.SelectedValue);
            _viewModel.IdFloor.Add((int)cmbFloor2.SelectedValue);
            _viewModel.IdFloor.Add((int)cmbFloor3.SelectedValue);
            _viewModel.IdFloor.Add((int)cmbFloor4.SelectedValue);
            //vytvaranie WidthListu z numUp pre podlahu
            _viewModel.WidthFloor.Add((double)numFloor1.Value);
            _viewModel.WidthFloor.Add((double)numFloor2.Value);
            _viewModel.WidthFloor.Add((double)numFloor3.Value);
            _viewModel.WidthFloor.Add((double)numFloor4.Value);

            MessageBox.Show("stena "+_viewModel.CalculateWall().ToString());
            MessageBox.Show("strecha "+_viewModel.CalculateRoof().ToString());
            MessageBox.Show("podlaha " + _viewModel.CalculateFloor().ToString());
            textBox1.Text = _viewModel.SummaryWrite();
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
