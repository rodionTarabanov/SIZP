using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFSIZP4App4
{
    public partial class MainForm : Form
    {
        bool loadFirstTime = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsSIZPDB.EquipmentType". При необходимости она может быть перемещена или удалена.
            //this.equipmentTypeTableAdapter.Fill(this.dsSIZPDB_mainForm.EquipmentType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsSIZPDB_mainForm.EquipmentType". При необходимости она может быть перемещена или удалена.
           // this.equipmentTypeTableAdapter.Fill(this.dsSIZPDB_mainForm.EquipmentType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsSIZPDB_mainForm.EquipmentType". При необходимости она может быть перемещена или удалена.
            this.equipmentTypeTableAdapter.Fill(this.dsSIZPDB_mainForm.EquipmentType);
            this.grdEqBySS.CellDoubleClick += new DataGridViewCellEventHandler(CreateComboboxOnDataGridView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dsSIZPDB.vwSubstations". При необходимости она может быть перемещена или удалена.
            this.vwSubstationsTableAdapter.Fill(this.dsSIZPDB_mainForm.vwSubstations);
            loadFirstTime = false;

        }

        private void LoadEqParamTypeByEqType()
        {
            //
            //Перезалив данных EquipmentParamType
            //
            try
            {
                DataRowView currentEquipmentType = (DataRowView)equipmentTypeGrdEqTypeBindingSource.Current;
                int eqparId = Convert.ToInt32(currentEquipmentType.Row["id"]);
                this.equipmentParamTypeTableAdapter.Fill(dsSIZPDB_mainForm.EquipmentParamType, eqparId);
            }
            catch (Exception)
            {
                this.grdEquipmentParamType.Rows.Clear();
                throw;
            }
        }
        private void ReloadEquiptionBySS()
        {
            //
            // Перезалив данных EquiptionBySS
            //
            try
            {
                //grdEqBySS.Rows.Clear();
                DataRowView currentSS = (DataRowView)vwSubstationsBindingSource.Current;
                int SSID = Convert.ToInt32(currentSS.Row["id"]);
                this.uspSelectEqForSSTableAdapter.Fill(this.dsSIZPDB_mainForm.uspSelectEqForSS, SSID);
            }
            catch (Exception)
            {

                grdEqBySS.Rows.Clear();
                throw;
            }

        }
        private void CreateComboboxOnDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewComboBoxCell eqTypeComboBox = new DataGridViewComboBoxCell();
                eqTypeComboBox.DataSource = equimpentTypeGrdEquiopmentBingingSource;
                // вот как-то так просто 
                eqTypeComboBox.DisplayMember = "EqType";
                //
                //Если данные для выбора, отображаемые, должны DataGridViewComboBoxCell
                //быть выведены из свойства или столбца, не заданного по умолчанию DataSource,
                //то ValueMember необходимо задать в дополнение к DataSource.
                //
                // НО!!! Если в DataGridViewComboBoxCell явно задать ValueMember,
                // то после завершения операции в поле DataGridViewComboBoxCell
                // будет отображаться именно ValueMember. Поэтому оставляю его закомментированным
                // а передаю именно в обработчике 

                //eqTypeComboBox.ValueMember = "id";
                //


                grdEqBySS.Rows[grdEqBySS.CurrentRow.Index].Cells[0] = eqTypeComboBox;

            }
            catch (Exception)
            {
                throw new NotImplementedException();
                throw;
            }

        }

        private void grdEqBySS_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {


        }


        private void txtSSSearch_TextChanged(object sender, EventArgs e)
        {
            this.vwSubstationsTableAdapter.FillBy(this.dsSIZPDB_mainForm.vwSubstations, this.txtSSSearch.Text);
        }

        private void vwSubstationsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //
            // обработка осбытия изменения выбранной строки для vwSubstationsBindingSource
            //
            try
            {
                // Изменение lblSSForEq после выбора ПС
                //Здесь и далее алгоритм такой
                //1. получаем ссылку на текущую строку из объекта класса BindingSource
                //      (с приведением типов !!!)
                //2. конвертируем в нужный тип поле Row[]. Оно индексируемое и обращение идет
                //по имени колонки соответствующего объекта класса DataTable (см. в dsSIZP.xsd)

                DataRowView row = (DataRowView)vwSubstationsBindingSource.Current;
                String ss = Convert.ToString(row.Row["Substation"]);
                this.lblSSForEq.Text = String.Format("{0} {1}", Properties.Resources.LBL_STATIC_SSEQ, ss);

                // То же другим способом. Строку с приведением типов взял из отладчика
                //
                //this.lblSSForEq.Text = String.Format("{0} {1}", Properties.Settings.Default.LBL_STATIC_SSEQ,
                //    ((WFSIZP4App4.dsSIZPDB.vwSubstationsRow)((System.Data.DataRowView)((WFSIZP4App4.MainForm)
                //    this.TopLevelControl).vwSubstationsBindingSource.Current).Row).Substation);
            }
            catch
            {
                this.lblSSForEq.Text = String.Empty;
                throw;
            }
            ReloadEquiptionBySS();
        }

        private void equipmentTypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Обработка изменения поля данных таблицы типов оборудования 
            //
            if (!loadFirstTime) // если данные уже загружены
            {
                try
                {
                    // текущая выделенная строка
                    DataGridViewRow row = grdEqType.CurrentRow;

                    // если значение ячейки в поле idColumn не равно null (запись уже есть)
                    // то идентификатору etid передается значение id текущей записи
                    // и в  процедуре uspUpdateEquipmentType обрабатывается часть Update
                    // иначе 0. Тогда в процедуре uspUpdateEquipmentType обрабатывается часть Insert
                    int etid;

                    //if (row.Cells["idColumn"].Value == DBNull.Value)
                    //{
                    //    etid = 0;
                    //}
                    //else
                    //{
                    //    etid = Convert.ToInt32(row.Cells["idColumn"].Value);
                    //}

                    //или так

                    if (row.IsNewRow) // если строка новая
                    {
                        etid = 0;
                    }
                    else
                    {
                        etid = Convert.ToInt32(row.Cells["idColumn"].Value);
                    }
                    // вызов uspUpdateEquipmentType - заполнение параметров и исполнение.
                    // эта процедура создана в dsSIZPDB.xsd в EquipmentTypeTableAdapter.
                    // В качестве имен параметров используются поля (Name) (!!!) колонок grdEqType
                    // см. конструктор колонок!!!
                    equipmentTypeTableAdapter.uspUpdateEquipmentType(
                            etid,
                            Convert.ToString(row.Cells["eqTypeColumn"].Value),
                            Convert.ToString(row.Cells["diagramPosColumn"].Value),
                            Convert.ToInt32(row.Cells["checkPeriodYearColumn"].Value),
                            Convert.ToString(row.Cells["reportTemplateColumn"].Value)
                            );
                    // перезалив данных
                    this.equipmentTypeTableAdapter.Fill(this.dsSIZPDB_mainForm.EquipmentType);
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void grdEqBySS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!loadFirstTime)
            {
                try
                {
                    DataRowView currentEquipment = (DataRowView)uspSelectEqForSSBindingSource.Current;
                    DataRowView equipmentTypeRow = (DataRowView)equimpentTypeGrdEquiopmentBingingSource.Current;
                    DataRowView currentSS = (DataRowView)vwSubstationsBindingSource.Current;
                    DataGridViewRow grdEqRow = grdEqBySS.CurrentRow;

                    DataGridViewComboBoxCell grdEqCell0 = (DataGridViewComboBoxCell)grdEqRow.Cells[0];
                    DataGridViewTextBoxCell grdEqCell2 = (DataGridViewTextBoxCell)grdEqRow.Cells[2];
                    if (/*(grdEqRow.IsNewRow | (grdEqRow.Index == 0)) & */grdEqCell0.IsInEditMode)

                    {

                        grdEqCell2.Value = equipmentTypeRow.Row["DiagramPos"];
                    }
                    bool completeFill = (grdEqRow.Cells[0].Value != DBNull.Value)
                                    & (grdEqRow.Cells[1].Value != DBNull.Value)
                                    & (grdEqRow.Cells[2].Value != DBNull.Value);

                    if (completeFill)
                    {
                        int eqid = (currentEquipment.IsNew) ? 0 : Convert.ToInt32(currentEquipment.Row["id"]);
                        int isPartOf = (eqid == 0) ? 0 : Convert.ToInt32(currentEquipment.Row["IsPartOf"]);

                        // вот только так получается 
                        DateTime? dateOfManufacture = null;
                        if (!Convert.IsDBNull(currentEquipment.Row["DateOfManufacture"]))
                        {
                            dateOfManufacture = Convert.ToDateTime(grdEqRow.Cells["dateOfManufactureGrdEqColumn"].Value);
                        };

                        DateTime? dateOfСommissioning = null;
                        if (!Convert.IsDBNull(currentEquipment.Row["DateOfСommissioning"]))
                        {
                            dateOfСommissioning = Convert.ToDateTime(grdEqRow.Cells["dateOfСommissioningGrdEqColumn"].Value);
                        };

                        #region Assignment by ?: operator
                        // вроде правильно, но если присваивать в условном операторе null (вместо DateTime.Today
                        // подразумеевалось null), то так не работает

                        //DateTime? dateOfManufacture = (Convert.IsDBNull(currentEquipment.Row["DateOfManufacture"])) ? 
                        //        DateTime.Today : Convert.ToDateTime(grdEqRow.Cells["dateOfManufactureGrdEqColumn"].Value);
                        //DateTime? dateOfСommissioning = (Convert.IsDBNull(currentEquipment.Row["DateOfСommissioning"])) ? 
                        //        dateOfManufacture : Convert.ToDateTime(grdEqRow.Cells["dateOfСommissioningGrdEqColumn"].Value);

                        #endregion
                        #region Check by MessageBox
                        // Проверка

                        //var writeDataToDB = MessageBox.Show(String.Format("Записать данніе"+
                        //    "\n eq id:{0}" +
                        //    "\n eq type:{1}" +
                        //    "\n SS id:{2}" +
                        //    "\n Name:{3}" +
                        //    "\n Position:{4}" +
                        //    "\n isPartOf:{5}" +
                        //    "\n Manufacturer:{6}" +
                        //    "\n SerialNum:{7}" +
                        //    "\n InventoryNum:{8}" +
                        //    "\n DateOfManufacture: {9}" +
                        //    "\n DateOfСommissioning: {10}",
                        //    Convert.ToString(eqid), //0
                        //    Convert.ToString(equipmentTypeRow.Row["id"]),//1
                        //    Convert.ToString(currentSS.Row["id"]),//2
                        //    Convert.ToString(currentEquipment.Row["Name"]),//3
                        //    Convert.ToString(currentEquipment.Row["Position"]),//4
                        //    Convert.ToString(isPartOf), //isPartOf //5
                        //    Convert.ToString(currentEquipment.Row["Manufacturer"]), //6
                        //    Convert.ToString(currentEquipment.Row["SerialNum"]),//7
                        //    Convert.ToString(currentEquipment.Row["InventoryNum"]),//8
                        //    Convert.ToString(dateOfManufacture),//9
                        //    Convert.ToString(dateOfСommissioning)//10
                        //    ),"Test", MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
                        //if (writeDataToDB == DialogResult.Yes)
                        //{ 
                        #endregion
                        uspSelectEqForSSTableAdapter.uspUpdateEquipment(
                            eqid,//0
                            Convert.ToInt32(equipmentTypeRow.Row["id"]),//1 - not null
                            Convert.ToInt32(currentSS.Row["id"]),//2 - not null
                            Convert.ToString(currentEquipment.Row["Name"]),//3 - not null
                            Convert.ToString(currentEquipment.Row["Position"]),//4 - not null
                            isPartOf, //isPartOf //5 - not null
                            Convert.ToString(currentEquipment.Row["Manufacturer"]), //6 - nullable
                            Convert.ToString(currentEquipment.Row["SerialNum"]),//7 - nullable
                            Convert.ToString(currentEquipment.Row["InventoryNum"]),//8 - nullable
                            dateOfManufacture,//9 - not null
                            dateOfСommissioning//10 - not null
                            );
                        //}
                    }


                }
                catch (Exception)
                {

                    throw;
                }
            }

        }


        private void equipmentTypeGrdEqTypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //
                // При изменении текущего значения equipmentTypeGrdEqTypeBindingSource
                // изменяется метка параметров для этого типа оборудования и перезаливается список параметров

                DataRowView currentEqType = (DataRowView)equimpentTypeGrdEquiopmentBingingSource.Current;
                string curEqTypeName = Convert.ToString(currentEqType.Row["EqType"]);
                lblParamsForEqType.Text = string.Format("{0} {1}", Properties.Resources.LBL_STATIC_SSEQ, curEqTypeName);
                LoadEqParamTypeByEqType();
            }
            catch (Exception)
            {
                //grdEquipmentParamType.Rows.Clear();
                throw;
            }

        }

        private void cmdDelEq_Click(object sender, EventArgs e)
        {
            if (!loadFirstTime)
            {
                try
                {
                    DataRowView currentEquipment = (DataRowView)uspSelectEqForSSBindingSource.Current;
                    uspSelectEqForSSTableAdapter.uspDelEqForSS(Convert.ToInt32(currentEquipment.Row["id"]));
                    ReloadEquiptionBySS();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void equimpentTypeGrdEquiopmentBingingSource_CurrentChanged(object sender, EventArgs e)
        {
            LoadEqParamTypeByEqType();

        }

        private void txtEqTypeSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEqTypeSearch.Text))
                {
                    equipmentTypeTableAdapter.Fill(dsSIZPDB_mainForm.EquipmentType);
                }
                else
                {
                    equipmentTypeTableAdapter.FillBy(dsSIZPDB_mainForm.EquipmentType, txtEqTypeSearch.Text);
                }
            }
            catch (Exception)
            {
                grdEqType.Rows.Clear();
                throw;
            }

        }

        private void grdEquipmentParamType_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void grdEquipmentParamType_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!loadFirstTime)
            {
                try
                {
                    DataGridViewRow paramTypeDataGridViewRow = grdEquipmentParamType.CurrentRow;
                    DataRowView currentEquipmentType = (DataRowView)equimpentTypeGrdEquiopmentBingingSource.Current;
                    DataRowView currentParam = (DataRowView)eqiupmentParamTypeBindingSource.Current;

                    int paramId = (currentParam.IsNew) ? 0 : Convert.ToInt32(currentParam.Row["id"]);
                    bool completeParamRow = (!string.IsNullOrEmpty(Convert.ToString(paramTypeDataGridViewRow.Cells["nameDataGridViewTextBoxColumn"].Value)));
                    if (completeParamRow)
                    {

                        string paramUnit = (string.IsNullOrEmpty(Convert.ToString(paramTypeDataGridViewRow.Cells["unitDataGridViewTextBoxColumn"].Value))) ?
                                null : Convert.ToString(paramTypeDataGridViewRow.Cells["unitDataGridViewTextBoxColumn"].Value);


                        // такая запись потому, что они sql_variant
                        object paramVal = null;
                        object paramMin = null;
                        object paramMax = null;

                        if (!string.IsNullOrEmpty(paramUnit))
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(paramTypeDataGridViewRow.Cells["valueDataGridViewTextBoxColumn"].Value)))
                                paramVal = Convert.ToDouble(paramTypeDataGridViewRow.Cells["valueDataGridViewTextBoxColumn"].Value);
                            if (!string.IsNullOrEmpty(Convert.ToString(paramTypeDataGridViewRow.Cells["minValueDataGridViewTextBoxColumn"].Value)))
                                paramMin = Convert.ToDouble(paramTypeDataGridViewRow.Cells["minValueDataGridViewTextBoxColumn"].Value);
                            if (!string.IsNullOrEmpty(Convert.ToString(paramTypeDataGridViewRow.Cells["maxValueDataGridViewTextBoxColumn"].Value)))
                                paramMax = Convert.ToDouble(paramTypeDataGridViewRow.Cells["maxValueDataGridViewTextBoxColumn"].Value);
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(paramTypeDataGridViewRow.Cells["valueDataGridViewTextBoxColumn"].Value)))
                                paramVal = Convert.ToString(paramTypeDataGridViewRow.Cells["valueDataGridViewTextBoxColumn"].Value);
                        }

                        bool paramIsStatic = (paramTypeDataGridViewRow.Cells["isStaticDataGridViewCheckBoxColumn"].Value == DBNull.Value) ?
                                false : Convert.ToBoolean(paramTypeDataGridViewRow.Cells["isStaticDataGridViewCheckBoxColumn"].Value);
                        string paramReportField = (string.IsNullOrEmpty(Convert.ToString(paramTypeDataGridViewRow.Cells["reportFieldDataGridViewTextBoxColumn"].Value))) ?
                                null : Convert.ToString(paramTypeDataGridViewRow.Cells["reportFieldDataGridViewTextBoxColumn"].Value);


                        equipmentParamTypeTableAdapter.uspUpdateParamTypes(
                            paramId
                            , Convert.ToInt32(currentEquipmentType.Row["id"])
                            , Convert.ToString(currentParam.Row["Name"])
                            , paramUnit
                            , paramIsStatic
                            , paramVal
                            , paramMin
                            , paramMax
                            , paramReportField
                            );
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
