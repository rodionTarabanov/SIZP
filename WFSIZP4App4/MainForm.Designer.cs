namespace WFSIZP4App4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdSubstations = new System.Windows.Forms.DataGridView();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.substationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwSubstationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSIZPDB_mainForm = new WFSIZP4App4.dsSIZPDB();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSSSearch = new System.Windows.Forms.TextBox();
            this.cmdDeleteSS = new System.Windows.Forms.Button();
            this.cmdChanheSS = new System.Windows.Forms.Button();
            this.cmdAddSS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdEqBySS = new System.Windows.Forms.DataGridView();
            this.eqTypeGrdEqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGrdEqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionGrdEqBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerGrdEqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumGrdEqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumGrdEqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfManufactureGrdEqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfСommissioningGrdEqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspSelectEqForSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdDelEq = new System.Windows.Forms.Button();
            this.lblSSForEq = new System.Windows.Forms.Label();
            this.cmdChangeEq = new System.Windows.Forms.Button();
            this.cmdAddEq = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mainSettingsTabControl = new System.Windows.Forms.TabControl();
            this.tabPageEqType = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEqTypeSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdEqType = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagramPosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkPeriodYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportTemplateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentTypeGrdEqTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdEquipmentParamType = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isStaticDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqiupmentParamTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblParamsForEqType = new System.Windows.Forms.Label();
            this.tabEquipmentParams = new System.Windows.Forms.TabPage();
            this.vwSubstationsTableAdapter = new WFSIZP4App4.dsSIZPDBTableAdapters.vwSubstationsTableAdapter();
            this.uspSelectEqForSSTableAdapter = new WFSIZP4App4.dsSIZPDBTableAdapters.uspSelectEqForSSTableAdapter();
            this.equipmentTypeTableAdapter = new WFSIZP4App4.dsSIZPDBTableAdapters.EquipmentTypeTableAdapter();
            this.equimpentTypeGrdEquiopmentBingingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentParamTypeTableAdapter = new WFSIZP4App4.dsSIZPDBTableAdapters.EquipmentParamTypeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubstations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubstationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSIZPDB_mainForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEqBySS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSelectEqForSSBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.mainSettingsTabControl.SuspendLayout();
            this.tabPageEqType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEqType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeGrdEqTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipmentParamType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqiupmentParamTypeBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equimpentTypeGrdEquiopmentBingingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ооборудование ПС";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdSubstations);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdEqBySS);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(786, 418);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 0;
            // 
            // grdSubstations
            // 
            this.grdSubstations.AutoGenerateColumns = false;
            this.grdSubstations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSubstations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubstations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionDataGridViewTextBoxColumn,
            this.substationDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn,
            this.sSGroupDataGridViewTextBoxColumn});
            this.grdSubstations.DataSource = this.vwSubstationsBindingSource;
            this.grdSubstations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSubstations.Location = new System.Drawing.Point(0, 30);
            this.grdSubstations.Name = "grdSubstations";
            this.grdSubstations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubstations.Size = new System.Drawing.Size(786, 141);
            this.grdSubstations.TabIndex = 1;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Район";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // substationDataGridViewTextBoxColumn
            // 
            this.substationDataGridViewTextBoxColumn.DataPropertyName = "Substation";
            this.substationDataGridViewTextBoxColumn.HeaderText = "Подстанция";
            this.substationDataGridViewTextBoxColumn.Name = "substationDataGridViewTextBoxColumn";
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            this.voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
            this.voltageDataGridViewTextBoxColumn.HeaderText = "Класс напряжения";
            this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "Группа СИЗП";
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            // 
            // sSGroupDataGridViewTextBoxColumn
            // 
            this.sSGroupDataGridViewTextBoxColumn.DataPropertyName = "SSGroup";
            this.sSGroupDataGridViewTextBoxColumn.HeaderText = "Группа ПС";
            this.sSGroupDataGridViewTextBoxColumn.Name = "sSGroupDataGridViewTextBoxColumn";
            // 
            // vwSubstationsBindingSource
            // 
            this.vwSubstationsBindingSource.DataMember = "vwSubstations";
            this.vwSubstationsBindingSource.DataSource = this.dsSIZPDB_mainForm;
            this.vwSubstationsBindingSource.CurrentChanged += new System.EventHandler(this.vwSubstationsBindingSource_CurrentChanged);
            // 
            // dsSIZPDB_mainForm
            // 
            this.dsSIZPDB_mainForm.DataSetName = "dsSIZPDB";
            this.dsSIZPDB_mainForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSSSearch);
            this.panel1.Controls.Add(this.cmdDeleteSS);
            this.panel1.Controls.Add(this.cmdChanheSS);
            this.panel1.Controls.Add(this.cmdAddSS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 30);
            this.panel1.TabIndex = 0;
            // 
            // txtSSSearch
            // 
            this.txtSSSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSSSearch.Location = new System.Drawing.Point(326, 5);
            this.txtSSSearch.Name = "txtSSSearch";
            this.txtSSSearch.Size = new System.Drawing.Size(370, 20);
            this.txtSSSearch.TabIndex = 2;
            this.txtSSSearch.TextChanged += new System.EventHandler(this.txtSSSearch_TextChanged);
            // 
            // cmdDeleteSS
            // 
            this.cmdDeleteSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDeleteSS.Location = new System.Drawing.Point(706, 6);
            this.cmdDeleteSS.Name = "cmdDeleteSS";
            this.cmdDeleteSS.Size = new System.Drawing.Size(75, 19);
            this.cmdDeleteSS.TabIndex = 1;
            this.cmdDeleteSS.Text = "Удалить";
            this.cmdDeleteSS.UseVisualStyleBackColor = true;
            // 
            // cmdChanheSS
            // 
            this.cmdChanheSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdChanheSS.Location = new System.Drawing.Point(180, 6);
            this.cmdChanheSS.Name = "cmdChanheSS";
            this.cmdChanheSS.Size = new System.Drawing.Size(75, 19);
            this.cmdChanheSS.TabIndex = 1;
            this.cmdChanheSS.Text = "Изменить";
            this.cmdChanheSS.UseVisualStyleBackColor = true;
            // 
            // cmdAddSS
            // 
            this.cmdAddSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAddSS.Location = new System.Drawing.Point(99, 6);
            this.cmdAddSS.Name = "cmdAddSS";
            this.cmdAddSS.Size = new System.Drawing.Size(75, 19);
            this.cmdAddSS.TabIndex = 1;
            this.cmdAddSS.Text = "Добавить";
            this.cmdAddSS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Найти ПС";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перечень ПС";
            // 
            // grdEqBySS
            // 
            this.grdEqBySS.AutoGenerateColumns = false;
            this.grdEqBySS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEqBySS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEqBySS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eqTypeGrdEqColumn,
            this.nameGrdEqColumn,
            this.positionGrdEqBoxColumn,
            this.manufacturerGrdEqColumn,
            this.serialNumGrdEqColumn,
            this.inventoryNumGrdEqColumn,
            this.dateOfManufactureGrdEqColumn,
            this.dateOfСommissioningGrdEqColumn});
            this.grdEqBySS.DataSource = this.uspSelectEqForSSBindingSource;
            this.grdEqBySS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEqBySS.Location = new System.Drawing.Point(0, 30);
            this.grdEqBySS.Name = "grdEqBySS";
            this.grdEqBySS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEqBySS.Size = new System.Drawing.Size(786, 213);
            this.grdEqBySS.TabIndex = 1;
            this.grdEqBySS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEqBySS_CellValueChanged);
            this.grdEqBySS.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdEqBySS_DataError);
            // 
            // eqTypeGrdEqColumn
            // 
            this.eqTypeGrdEqColumn.DataPropertyName = "EqType";
            this.eqTypeGrdEqColumn.HeaderText = "EqType";
            this.eqTypeGrdEqColumn.Name = "eqTypeGrdEqColumn";
            this.eqTypeGrdEqColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameGrdEqColumn
            // 
            this.nameGrdEqColumn.DataPropertyName = "Name";
            this.nameGrdEqColumn.HeaderText = "Name";
            this.nameGrdEqColumn.Name = "nameGrdEqColumn";
            // 
            // positionGrdEqBoxColumn
            // 
            this.positionGrdEqBoxColumn.DataPropertyName = "Position";
            this.positionGrdEqBoxColumn.HeaderText = "Position";
            this.positionGrdEqBoxColumn.Name = "positionGrdEqBoxColumn";
            // 
            // manufacturerGrdEqColumn
            // 
            this.manufacturerGrdEqColumn.DataPropertyName = "Manufacturer";
            this.manufacturerGrdEqColumn.HeaderText = "Manufacturer";
            this.manufacturerGrdEqColumn.Name = "manufacturerGrdEqColumn";
            // 
            // serialNumGrdEqColumn
            // 
            this.serialNumGrdEqColumn.DataPropertyName = "SerialNum";
            this.serialNumGrdEqColumn.HeaderText = "SerialNum";
            this.serialNumGrdEqColumn.Name = "serialNumGrdEqColumn";
            // 
            // inventoryNumGrdEqColumn
            // 
            this.inventoryNumGrdEqColumn.DataPropertyName = "InventoryNum";
            this.inventoryNumGrdEqColumn.HeaderText = "InventoryNum";
            this.inventoryNumGrdEqColumn.Name = "inventoryNumGrdEqColumn";
            // 
            // dateOfManufactureGrdEqColumn
            // 
            this.dateOfManufactureGrdEqColumn.DataPropertyName = "DateOfManufacture";
            this.dateOfManufactureGrdEqColumn.HeaderText = "DateOfManufacture";
            this.dateOfManufactureGrdEqColumn.Name = "dateOfManufactureGrdEqColumn";
            // 
            // dateOfСommissioningGrdEqColumn
            // 
            this.dateOfСommissioningGrdEqColumn.DataPropertyName = "DateOfСommissioning";
            this.dateOfСommissioningGrdEqColumn.HeaderText = "DateOfСommissioning";
            this.dateOfСommissioningGrdEqColumn.Name = "dateOfСommissioningGrdEqColumn";
            // 
            // uspSelectEqForSSBindingSource
            // 
            this.uspSelectEqForSSBindingSource.DataMember = "uspSelectEqForSS";
            this.uspSelectEqForSSBindingSource.DataSource = this.dsSIZPDB_mainForm;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdDelEq);
            this.panel2.Controls.Add(this.lblSSForEq);
            this.panel2.Controls.Add(this.cmdChangeEq);
            this.panel2.Controls.Add(this.cmdAddEq);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 30);
            this.panel2.TabIndex = 0;
            // 
            // cmdDelEq
            // 
            this.cmdDelEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDelEq.Location = new System.Drawing.Point(709, 6);
            this.cmdDelEq.Name = "cmdDelEq";
            this.cmdDelEq.Size = new System.Drawing.Size(75, 19);
            this.cmdDelEq.TabIndex = 1;
            this.cmdDelEq.Text = "Удалить";
            this.cmdDelEq.UseVisualStyleBackColor = true;
            this.cmdDelEq.Click += new System.EventHandler(this.cmdDelEq_Click);
            // 
            // lblSSForEq
            // 
            this.lblSSForEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSSForEq.AutoSize = true;
            this.lblSSForEq.Location = new System.Drawing.Point(12, 9);
            this.lblSSForEq.Name = "lblSSForEq";
            this.lblSSForEq.Size = new System.Drawing.Size(98, 13);
            this.lblSSForEq.TabIndex = 0;
            this.lblSSForEq.Text = "Оборудование ПС";
            // 
            // cmdChangeEq
            // 
            this.cmdChangeEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdChangeEq.Location = new System.Drawing.Point(336, 6);
            this.cmdChangeEq.Name = "cmdChangeEq";
            this.cmdChangeEq.Size = new System.Drawing.Size(75, 19);
            this.cmdChangeEq.TabIndex = 1;
            this.cmdChangeEq.Text = "Изменить";
            this.cmdChangeEq.UseVisualStyleBackColor = true;
            // 
            // cmdAddEq
            // 
            this.cmdAddEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAddEq.Location = new System.Drawing.Point(255, 6);
            this.cmdAddEq.Name = "cmdAddEq";
            this.cmdAddEq.Size = new System.Drawing.Size(75, 19);
            this.cmdAddEq.TabIndex = 1;
            this.cmdAddEq.Text = "Добавить";
            this.cmdAddEq.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Измерения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mainSettingsTabControl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mainSettingsTabControl
            // 
            this.mainSettingsTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainSettingsTabControl.Controls.Add(this.tabPageEqType);
            this.mainSettingsTabControl.Controls.Add(this.tabEquipmentParams);
            this.mainSettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSettingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainSettingsTabControl.Multiline = true;
            this.mainSettingsTabControl.Name = "mainSettingsTabControl";
            this.mainSettingsTabControl.SelectedIndex = 0;
            this.mainSettingsTabControl.Size = new System.Drawing.Size(792, 424);
            this.mainSettingsTabControl.TabIndex = 0;
            // 
            // tabPageEqType
            // 
            this.tabPageEqType.Controls.Add(this.splitContainer2);
            this.tabPageEqType.Location = new System.Drawing.Point(23, 4);
            this.tabPageEqType.Name = "tabPageEqType";
            this.tabPageEqType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEqType.Size = new System.Drawing.Size(765, 416);
            this.tabPageEqType.TabIndex = 0;
            this.tabPageEqType.Text = "Типы оборудования";
            this.tabPageEqType.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            this.splitContainer2.Panel1.Controls.Add(this.grdEqType);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grdEquipmentParamType);
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Size = new System.Drawing.Size(759, 410);
            this.splitContainer2.SplitterDistance = 199;
            this.splitContainer2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEqTypeSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 30);
            this.panel3.TabIndex = 1;
            // 
            // txtEqTypeSearch
            // 
            this.txtEqTypeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEqTypeSearch.Location = new System.Drawing.Point(111, 6);
            this.txtEqTypeSearch.Name = "txtEqTypeSearch";
            this.txtEqTypeSearch.Size = new System.Drawing.Size(459, 20);
            this.txtEqTypeSearch.TabIndex = 1;
            this.txtEqTypeSearch.TextChanged += new System.EventHandler(this.txtEqTypeSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип оборудования";
            // 
            // grdEqType
            // 
            this.grdEqType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEqType.AutoGenerateColumns = false;
            this.grdEqType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEqType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.eqTypeColumn,
            this.diagramPosColumn,
            this.checkPeriodYearColumn,
            this.reportTemplateColumn});
            this.grdEqType.DataSource = this.equipmentTypeGrdEqTypeBindingSource;
            this.grdEqType.Location = new System.Drawing.Point(2, 32);
            this.grdEqType.Name = "grdEqType";
            this.grdEqType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEqType.Size = new System.Drawing.Size(756, 167);
            this.grdEqType.TabIndex = 0;
            this.grdEqType.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "id";
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // eqTypeColumn
            // 
            this.eqTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eqTypeColumn.DataPropertyName = "EqType";
            this.eqTypeColumn.HeaderText = "EqType";
            this.eqTypeColumn.Name = "eqTypeColumn";
            // 
            // diagramPosColumn
            // 
            this.diagramPosColumn.DataPropertyName = "DiagramPos";
            this.diagramPosColumn.HeaderText = "DiagramPos";
            this.diagramPosColumn.Name = "diagramPosColumn";
            // 
            // checkPeriodYearColumn
            // 
            this.checkPeriodYearColumn.DataPropertyName = "CheckPeriodYear";
            this.checkPeriodYearColumn.HeaderText = "CheckPeriodYear";
            this.checkPeriodYearColumn.Name = "checkPeriodYearColumn";
            // 
            // reportTemplateColumn
            // 
            this.reportTemplateColumn.DataPropertyName = "ReportTemplate";
            this.reportTemplateColumn.HeaderText = "ReportTemplate";
            this.reportTemplateColumn.Name = "reportTemplateColumn";
            // 
            // equipmentTypeGrdEqTypeBindingSource
            // 
            this.equipmentTypeGrdEqTypeBindingSource.DataMember = "EquipmentType";
            this.equipmentTypeGrdEqTypeBindingSource.DataSource = this.dsSIZPDB_mainForm;
            this.equipmentTypeGrdEqTypeBindingSource.CurrentChanged += new System.EventHandler(this.equipmentTypeGrdEqTypeBindingSource_CurrentChanged);
            // 
            // grdEquipmentParamType
            // 
            this.grdEquipmentParamType.AutoGenerateColumns = false;
            this.grdEquipmentParamType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquipmentParamType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.isStaticDataGridViewCheckBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.minValueDataGridViewTextBoxColumn,
            this.maxValueDataGridViewTextBoxColumn,
            this.reportFieldDataGridViewTextBoxColumn});
            this.grdEquipmentParamType.DataSource = this.eqiupmentParamTypeBindingSource;
            this.grdEquipmentParamType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEquipmentParamType.Location = new System.Drawing.Point(0, 30);
            this.grdEquipmentParamType.Name = "grdEquipmentParamType";
            this.grdEquipmentParamType.Size = new System.Drawing.Size(759, 177);
            this.grdEquipmentParamType.TabIndex = 1;
            this.grdEquipmentParamType.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEquipmentParamType_CellValueChanged);
            this.grdEquipmentParamType.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdEquipmentParamType_DataError);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Параметр";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Ед.изм.";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 50;
            // 
            // isStaticDataGridViewCheckBoxColumn
            // 
            this.isStaticDataGridViewCheckBoxColumn.DataPropertyName = "IsStatic";
            this.isStaticDataGridViewCheckBoxColumn.HeaderText = "Статический";
            this.isStaticDataGridViewCheckBoxColumn.Name = "isStaticDataGridViewCheckBoxColumn";
            this.isStaticDataGridViewCheckBoxColumn.Width = 75;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Номинал";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // minValueDataGridViewTextBoxColumn
            // 
            this.minValueDataGridViewTextBoxColumn.DataPropertyName = "MinValue";
            this.minValueDataGridViewTextBoxColumn.HeaderText = "Минимум";
            this.minValueDataGridViewTextBoxColumn.Name = "minValueDataGridViewTextBoxColumn";
            // 
            // maxValueDataGridViewTextBoxColumn
            // 
            this.maxValueDataGridViewTextBoxColumn.DataPropertyName = "MaxValue";
            this.maxValueDataGridViewTextBoxColumn.HeaderText = "Максимум";
            this.maxValueDataGridViewTextBoxColumn.Name = "maxValueDataGridViewTextBoxColumn";
            // 
            // reportFieldDataGridViewTextBoxColumn
            // 
            this.reportFieldDataGridViewTextBoxColumn.DataPropertyName = "ReportField";
            this.reportFieldDataGridViewTextBoxColumn.HeaderText = "Поле отчета";
            this.reportFieldDataGridViewTextBoxColumn.Name = "reportFieldDataGridViewTextBoxColumn";
            // 
            // eqiupmentParamTypeBindingSource
            // 
            this.eqiupmentParamTypeBindingSource.AllowNew = true;
            this.eqiupmentParamTypeBindingSource.DataMember = "EquipmentParamType";
            this.eqiupmentParamTypeBindingSource.DataSource = this.dsSIZPDB_mainForm;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblParamsForEqType);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(759, 30);
            this.panel4.TabIndex = 0;
            // 
            // lblParamsForEqType
            // 
            this.lblParamsForEqType.AutoSize = true;
            this.lblParamsForEqType.Location = new System.Drawing.Point(5, 7);
            this.lblParamsForEqType.Name = "lblParamsForEqType";
            this.lblParamsForEqType.Size = new System.Drawing.Size(66, 13);
            this.lblParamsForEqType.TabIndex = 0;
            this.lblParamsForEqType.Text = "Параметры";
            // 
            // tabEquipmentParams
            // 
            this.tabEquipmentParams.Location = new System.Drawing.Point(23, 4);
            this.tabEquipmentParams.Name = "tabEquipmentParams";
            this.tabEquipmentParams.Padding = new System.Windows.Forms.Padding(3);
            this.tabEquipmentParams.Size = new System.Drawing.Size(765, 416);
            this.tabEquipmentParams.TabIndex = 1;
            this.tabEquipmentParams.Text = "Параметры";
            this.tabEquipmentParams.UseVisualStyleBackColor = true;
            // 
            // vwSubstationsTableAdapter
            // 
            this.vwSubstationsTableAdapter.ClearBeforeFill = true;
            // 
            // uspSelectEqForSSTableAdapter
            // 
            this.uspSelectEqForSSTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTypeTableAdapter
            // 
            this.equipmentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // equimpentTypeGrdEquiopmentBingingSource
            // 
            this.equimpentTypeGrdEquiopmentBingingSource.DataMember = "EquipmentType";
            this.equimpentTypeGrdEquiopmentBingingSource.DataSource = this.dsSIZPDB_mainForm;
            this.equimpentTypeGrdEquiopmentBingingSource.CurrentChanged += new System.EventHandler(this.equimpentTypeGrdEquiopmentBingingSource_CurrentChanged);
            // 
            // equipmentParamTypeTableAdapter
            // 
            this.equipmentParamTypeTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSubstations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubstationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSIZPDB_mainForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEqBySS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspSelectEqForSSBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.mainSettingsTabControl.ResumeLayout(false);
            this.tabPageEqType.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEqType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTypeGrdEqTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipmentParamType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqiupmentParamTypeBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equimpentTypeGrdEquiopmentBingingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdDeleteSS;
        private System.Windows.Forms.Button cmdChanheSS;
        private System.Windows.Forms.Button cmdAddSS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSSSearch;
        private System.Windows.Forms.DataGridView grdSubstations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdDelEq;
        private System.Windows.Forms.Label lblSSForEq;
        private System.Windows.Forms.Button cmdChangeEq;
        private System.Windows.Forms.Button cmdAddEq;
        private dsSIZPDB dsSIZPDB_mainForm;
        private System.Windows.Forms.BindingSource vwSubstationsBindingSource;
        private dsSIZPDBTableAdapters.vwSubstationsTableAdapter vwSubstationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn substationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uspSelectEqForSSBindingSource;
        private dsSIZPDBTableAdapters.uspSelectEqForSSTableAdapter uspSelectEqForSSTableAdapter;
        private System.Windows.Forms.DataGridView grdEqBySS;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl mainSettingsTabControl;
        private System.Windows.Forms.TabPage tabPageEqType;
        private System.Windows.Forms.TabPage tabEquipmentParams;
        private System.Windows.Forms.DataGridView grdEqType;
        private System.Windows.Forms.BindingSource equipmentTypeGrdEqTypeBindingSource;
        private dsSIZPDBTableAdapters.EquipmentTypeTableAdapter equipmentTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagramPosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkPeriodYearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportTemplateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqTypeGrdEqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGrdEqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionGrdEqBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerGrdEqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumGrdEqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumGrdEqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfManufactureGrdEqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfСommissioningGrdEqColumn;
        private System.Windows.Forms.BindingSource equimpentTypeGrdEquiopmentBingingSource;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdEquipmentParamType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEqTypeSearch;
        private System.Windows.Forms.Label lblParamsForEqType;
        private System.Windows.Forms.BindingSource eqiupmentParamTypeBindingSource;
        private dsSIZPDBTableAdapters.EquipmentParamTypeTableAdapter equipmentParamTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isStaticDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportFieldDataGridViewTextBoxColumn;
    }
}

