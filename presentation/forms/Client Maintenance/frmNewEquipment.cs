using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Layer.Objects;
using Data.Layer.Controller;

namespace sen381_t7_premier_service_solutions.presentation.forms.Client_Maintenance
{
    public partial class frmNewEquipment : Form
    {
        public Equipment eResult = null;
        private frmNewEquipment()
        {
            InitializeComponent();

            EquipmentCategoryController equipmentCategoryController = new EquipmentCategoryController();

            foreach (EquipmentCategory equipmentCategory in equipmentCategoryController.Read())
            {
                cbEquipmentCat.Items.Add(equipmentCategory);
            }
        }

        public static Equipment CreateNewEquipment()
        {
            frmNewEquipment form = new frmNewEquipment();
            form.ShowDialog();
            return form.eResult;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbEquipmentCat.SelectedItem == null) { MessageBox.Show("Select category first"); return; }
            if (tbSerialNumber.Text.Length == 0) { MessageBox.Show("Enter Serial number first"); return; }
            if (tbManufacturer.Text.Length == 0) { MessageBox.Show("Enter manufacturer first"); return; }

            this.eResult = new Equipment(
                tbSerialNumber.Text,
                tbManufacturer.Text
            );
            this.eResult.Category = cbEquipmentCat.SelectedItem as EquipmentCategory;

            Close();
        }
    }
}
