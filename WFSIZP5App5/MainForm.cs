using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using WFSIZP5App5.EquipmentClass;

namespace WFSIZP5App5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sizp1MainFormDataset.EquipmentView". При необходимости она может быть перемещена или удалена.
            //this.equipmentViewTableAdapter.Fill(this.sizp1MainFormDataset.EquipmentView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sizp1MainFormDataset.SubstationsView". При необходимости она может быть перемещена или удалена.
            reloadSubstationList();
        }

        private void reloadSubstationList()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearchSS.Text))
                {
                    substationsViewTableAdapter.FillBy(sizp1MainFormDataset.SubstationsView, txtSearchSS.Text);
                }
                else
                {
                    substationsViewTableAdapter.Fill(sizp1MainFormDataset.SubstationsView);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtSearchSS_TextChanged(object sender, EventArgs e)
        {
            reloadSubstationList();
        }

        private void substationsViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView currentSS = (DataRowView)substationsViewBindingSource.Current;
            lblEquipmentList.Text = string.Format("{0} {1}", Properties.Resources.LBL_EQIPTIONLIST_TEXT,
                (string)currentSS.Row["Substation"]);
            try
            {
                equipmentViewTableAdapter.FillBySS(sizp1MainFormDataset.EquipmentView, Convert.ToInt32(currentSS.Row["id"]));
            }
            catch (Exception)
            {
                //grdEquipmentView.Rows.Clear();
                throw;
            }
            
        }

        private void euipmentViewBinderSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView currentEquipment = (DataRowView)euipmentViewBinderSource.Current;
            Equipment equipment = new Equipment();
            equipment.EquipmentProperties = new List<EquipmentProperty>()
            {
                new EquipmentProperty()
                {
                    Category = "Основные сведения",
                    Name = "Вид оборудования",
                    Value = Convert.ToString(currentEquipment.Row["EquipmentClassName"]),
                    DisplayName = "Вид оборудования",
                    Description = Convert.ToString(currentEquipment.Row["EquipmentClassName"])

                }
            };
            propertyGrid1.SelectedObject = equipment;
            
        }
    }
}
