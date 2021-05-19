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

namespace Presentation.Forms.ClientMaintenance
{
    public partial class frmNewEquipment : Form
    {
        public Equipment newEquipment;

        public frmNewEquipment()
        {
            InitializeComponent();
        }

        private void frmNewEquipment_Load(object sender, EventArgs e)
        {
            EquipmentCategoryController equipmentCategoryController = new EquipmentCategoryController();

            foreach (EquipmentCategory equipmentCategory in equipmentCategoryController.Read())
            {
                cbxCategory.Items.Add(equipmentCategory);
            }

            cbxCategory.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSerialNum.Text.Equals(""))
            {
                MessageBox.Show("Please enter serial number");
            }
            else if (txtManufacturer.Text.Equals(""))
            {
                MessageBox.Show("Please enter manufacturer");
            }
            else
            {
                newEquipment = new Equipment(
                        txtSerialNum.Text,
                        txtManufacturer.Text
                    );

                newEquipment.Category = cbxCategory.SelectedItem as EquipmentCategory;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
