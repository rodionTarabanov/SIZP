namespace WFSIZP5App5
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
            this.tabPageSSEquipment = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdSubstationsView = new System.Windows.Forms.DataGridView();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.substationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.substationsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizp1MainFormDataset = new WFSIZP5App5.SIZP1DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grdEquipmentView = new System.Windows.Forms.DataGridView();
            this.feederDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagramPosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentClassNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.euipmentViewBinderSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEquipmentList = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPageEquipmentClasses = new System.Windows.Forms.TabPage();
            this.substationsViewTableAdapter = new WFSIZP5App5.SIZP1DataSetTableAdapters.SubstationsViewTableAdapter();
            this.equipmentViewTableAdapter = new WFSIZP5App5.SIZP1DataSetTableAdapters.EquipmentViewTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageSSEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubstationsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substationsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizp1MainFormDataset)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.euipmentViewBinderSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSSEquipment);
            this.tabControl1.Controls.Add(this.tabPageEquipmentClasses);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSSEquipment
            // 
            this.tabPageSSEquipment.Controls.Add(this.splitContainer1);
            this.tabPageSSEquipment.Location = new System.Drawing.Point(4, 22);
            this.tabPageSSEquipment.Name = "tabPageSSEquipment";
            this.tabPageSSEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSSEquipment.Size = new System.Drawing.Size(789, 411);
            this.tabPageSSEquipment.TabIndex = 0;
            this.tabPageSSEquipment.Text = "Оборудование ПС";
            this.tabPageSSEquipment.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.grdSubstationsView);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(783, 405);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 0;
            // 
            // grdSubstationsView
            // 
            this.grdSubstationsView.AutoGenerateColumns = false;
            this.grdSubstationsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSubstationsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubstationsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionDataGridViewTextBoxColumn,
            this.substationDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn,
            this.sSGroupDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn});
            this.grdSubstationsView.DataSource = this.substationsViewBindingSource;
            this.grdSubstationsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSubstationsView.Location = new System.Drawing.Point(0, 30);
            this.grdSubstationsView.Name = "grdSubstationsView";
            this.grdSubstationsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubstationsView.Size = new System.Drawing.Size(783, 133);
            this.grdSubstationsView.TabIndex = 1;
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
            // sSGroupDataGridViewTextBoxColumn
            // 
            this.sSGroupDataGridViewTextBoxColumn.DataPropertyName = "SSGroup";
            this.sSGroupDataGridViewTextBoxColumn.HeaderText = "Группа ПС";
            this.sSGroupDataGridViewTextBoxColumn.Name = "sSGroupDataGridViewTextBoxColumn";
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "Группа СИЗП";
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            // 
            // substationsViewBindingSource
            // 
            this.substationsViewBindingSource.DataMember = "SubstationsView";
            this.substationsViewBindingSource.DataSource = this.sizp1MainFormDataset;
            this.substationsViewBindingSource.CurrentChanged += new System.EventHandler(this.substationsViewBindingSource_CurrentChanged);
            // 
            // sizp1MainFormDataset
            // 
            this.sizp1MainFormDataset.DataSetName = "SIZP1DataSet";
            this.sizp1MainFormDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchSS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 30);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchSS
            // 
            this.txtSearchSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSS.Location = new System.Drawing.Point(92, 5);
            this.txtSearchSS.Name = "txtSearchSS";
            this.txtSearchSS.Size = new System.Drawing.Size(360, 20);
            this.txtSearchSS.TabIndex = 2;
            this.txtSearchSS.TextChanged += new System.EventHandler(this.txtSearchSS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перечень ПС";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grdEquipmentView);
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(783, 238);
            this.splitContainer2.SplitterDistance = 539;
            this.splitContainer2.TabIndex = 0;
            // 
            // grdEquipmentView
            // 
            this.grdEquipmentView.AutoGenerateColumns = false;
            this.grdEquipmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquipmentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feederDataGridViewTextBoxColumn,
            this.diagramPosDataGridViewTextBoxColumn,
            this.equipmentClassNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.voltageClassDataGridViewTextBoxColumn,
            this.dateOfCheckDataGridViewTextBoxColumn});
            this.grdEquipmentView.DataSource = this.euipmentViewBinderSource;
            this.grdEquipmentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEquipmentView.Location = new System.Drawing.Point(0, 30);
            this.grdEquipmentView.Name = "grdEquipmentView";
            this.grdEquipmentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEquipmentView.Size = new System.Drawing.Size(539, 208);
            this.grdEquipmentView.TabIndex = 1;
            // 
            // feederDataGridViewTextBoxColumn
            // 
            this.feederDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.feederDataGridViewTextBoxColumn.DataPropertyName = "Feeder";
            this.feederDataGridViewTextBoxColumn.HeaderText = "Присоед.";
            this.feederDataGridViewTextBoxColumn.Name = "feederDataGridViewTextBoxColumn";
            this.feederDataGridViewTextBoxColumn.ToolTipText = "Присоединение";
            // 
            // diagramPosDataGridViewTextBoxColumn
            // 
            this.diagramPosDataGridViewTextBoxColumn.DataPropertyName = "DiagramPos";
            this.diagramPosDataGridViewTextBoxColumn.HeaderText = "Поз.";
            this.diagramPosDataGridViewTextBoxColumn.Name = "diagramPosDataGridViewTextBoxColumn";
            this.diagramPosDataGridViewTextBoxColumn.ToolTipText = "Позиция на схеме";
            this.diagramPosDataGridViewTextBoxColumn.Width = 50;
            // 
            // equipmentClassNameDataGridViewTextBoxColumn
            // 
            this.equipmentClassNameDataGridViewTextBoxColumn.DataPropertyName = "EquipmentClassName";
            this.equipmentClassNameDataGridViewTextBoxColumn.HeaderText = "Оборудование";
            this.equipmentClassNameDataGridViewTextBoxColumn.Name = "equipmentClassNameDataGridViewTextBoxColumn";
            this.equipmentClassNameDataGridViewTextBoxColumn.ToolTipText = "Класс оборудования";
            this.equipmentClassNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ToolTipText = "Тип единицы оборудования";
            // 
            // voltageClassDataGridViewTextBoxColumn
            // 
            this.voltageClassDataGridViewTextBoxColumn.DataPropertyName = "VoltageClass";
            this.voltageClassDataGridViewTextBoxColumn.HeaderText = "Класс напр.";
            this.voltageClassDataGridViewTextBoxColumn.Name = "voltageClassDataGridViewTextBoxColumn";
            this.voltageClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.voltageClassDataGridViewTextBoxColumn.ToolTipText = "Класс напряжения";
            this.voltageClassDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateOfCheckDataGridViewTextBoxColumn
            // 
            this.dateOfCheckDataGridViewTextBoxColumn.DataPropertyName = "DateOfCheck";
            this.dateOfCheckDataGridViewTextBoxColumn.HeaderText = "Проверено";
            this.dateOfCheckDataGridViewTextBoxColumn.Name = "dateOfCheckDataGridViewTextBoxColumn";
            this.dateOfCheckDataGridViewTextBoxColumn.ToolTipText = "Дата последней проверки";
            // 
            // euipmentViewBinderSource
            // 
            this.euipmentViewBinderSource.DataMember = "EquipmentView";
            this.euipmentViewBinderSource.DataSource = this.sizp1MainFormDataset;
            this.euipmentViewBinderSource.CurrentChanged += new System.EventHandler(this.euipmentViewBinderSource_CurrentChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEquipmentList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 30);
            this.panel2.TabIndex = 0;
            // 
            // lblEquipmentList
            // 
            this.lblEquipmentList.AutoSize = true;
            this.lblEquipmentList.Location = new System.Drawing.Point(11, 9);
            this.lblEquipmentList.Name = "lblEquipmentList";
            this.lblEquipmentList.Size = new System.Drawing.Size(35, 13);
            this.lblEquipmentList.TabIndex = 0;
            this.lblEquipmentList.Text = "label2";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(240, 238);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabPageEquipmentClasses
            // 
            this.tabPageEquipmentClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageEquipmentClasses.Name = "tabPageEquipmentClasses";
            this.tabPageEquipmentClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEquipmentClasses.Size = new System.Drawing.Size(789, 411);
            this.tabPageEquipmentClasses.TabIndex = 1;
            this.tabPageEquipmentClasses.Text = "Классификация";
            this.tabPageEquipmentClasses.UseVisualStyleBackColor = true;
            // 
            // substationsViewTableAdapter
            // 
            this.substationsViewTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentViewTableAdapter
            // 
            this.equipmentViewTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 437);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(600, 320);
            this.Name = "MainForm";
            this.Text = "Перечень оборудования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSSEquipment.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSubstationsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substationsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizp1MainFormDataset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipmentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.euipmentViewBinderSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSSEquipment;
        private System.Windows.Forms.TabPage tabPageEquipmentClasses;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSubstationsView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView grdEquipmentView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEquipmentList;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private SIZP1DataSet sizp1MainFormDataset;
        private System.Windows.Forms.BindingSource substationsViewBindingSource;
        private SIZP1DataSetTableAdapters.SubstationsViewTableAdapter substationsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn substationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource euipmentViewBinderSource;
        private SIZP1DataSetTableAdapters.EquipmentViewTableAdapter equipmentViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feederDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagramPosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentClassNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCheckDataGridViewTextBoxColumn;
    }
}

