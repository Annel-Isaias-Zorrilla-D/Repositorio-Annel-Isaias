namespace RisXpert_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtActive = new System.Windows.Forms.TextBox();
            this.lblAnalyst = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblNewRisk = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAnalystName = new System.Windows.Forms.TextBox();
            this.dtgvRisks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnNewRisk = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCaseID2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvValues = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgvEvaluation = new System.Windows.Forms.DataGridView();
            this.Fase3Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase3Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase3Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarDeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PdeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuanDeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRisks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValues)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEvaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1178, 471);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.lblActive);
            this.tabPage1.Controls.Add(this.txtActive);
            this.tabPage1.Controls.Add(this.lblAnalyst);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.lblCaseID);
            this.tabPage1.Controls.Add(this.lblSave);
            this.tabPage1.Controls.Add(this.lblNewRisk);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.txtAnalystName);
            this.tabPage1.Controls.Add(this.dtgvRisks);
            this.tabPage1.Controls.Add(this.btnSave1);
            this.tabPage1.Controls.Add(this.btnNewRisk);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fase #1";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.ForeColor = System.Drawing.Color.Orange;
            this.lblActive.Location = new System.Drawing.Point(162, 157);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(94, 16);
            this.lblActive.TabIndex = 18;
            this.lblActive.Text = "Bien o Activo:";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtActive
            // 
            this.txtActive.BackColor = System.Drawing.SystemColors.Control;
            this.txtActive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtActive.Location = new System.Drawing.Point(294, 158);
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(418, 17);
            this.txtActive.TabIndex = 17;
            this.txtActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActive.TextChanged += new System.EventHandler(this.UpdateData);
            // 
            // lblAnalyst
            // 
            this.lblAnalyst.AutoSize = true;
            this.lblAnalyst.ForeColor = System.Drawing.Color.Orange;
            this.lblAnalyst.Location = new System.Drawing.Point(162, 118);
            this.lblAnalyst.Name = "lblAnalyst";
            this.lblAnalyst.Size = new System.Drawing.Size(95, 16);
            this.lblAnalyst.TabIndex = 16;
            this.lblAnalyst.Text = "Analista:        ";
            this.lblAnalyst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnalyst.Click += new System.EventHandler(this.lblAnalyst_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDate.Location = new System.Drawing.Point(973, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 16);
            this.lblDate.TabIndex = 15;
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.ForeColor = System.Drawing.Color.Orange;
            this.lblCaseID.Location = new System.Drawing.Point(785, 118);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(61, 16);
            this.lblCaseID.TabIndex = 14;
            this.lblCaseID.Text = "Case ID:";
            this.lblCaseID.Click += new System.EventHandler(this.lblCaseID_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(135, 81);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(103, 16);
            this.lblSave.TabIndex = 13;
            this.lblSave.Text = "Guardar Datos";
            // 
            // lblNewRisk
            // 
            this.lblNewRisk.AutoSize = true;
            this.lblNewRisk.Location = new System.Drawing.Point(135, 20);
            this.lblNewRisk.Name = "lblNewRisk";
            this.lblNewRisk.Size = new System.Drawing.Size(94, 16);
            this.lblNewRisk.TabIndex = 12;
            this.lblNewRisk.Text = "Nuevo Riesgo";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Red;
            this.txtID.Location = new System.Drawing.Point(878, 118);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 17);
            this.txtID.TabIndex = 11;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.TextChanged += new System.EventHandler(this.UpdateData);
            // 
            // txtAnalystName
            // 
            this.txtAnalystName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnalystName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnalystName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAnalystName.Location = new System.Drawing.Point(294, 118);
            this.txtAnalystName.Name = "txtAnalystName";
            this.txtAnalystName.Size = new System.Drawing.Size(418, 17);
            this.txtAnalystName.TabIndex = 8;
            this.txtAnalystName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnalystName.TextChanged += new System.EventHandler(this.UpdateData);
            // 
            // dtgvRisks
            // 
            this.dtgvRisks.AllowUserToAddRows = false;
            this.dtgvRisks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRisks.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgvRisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRisks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Analista,
            this.BienActivo,
            this.Riesgo,
            this.Daño});
            this.dtgvRisks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvRisks.Location = new System.Drawing.Point(3, 187);
            this.dtgvRisks.Name = "dtgvRisks";
            this.dtgvRisks.RowHeadersWidth = 51;
            this.dtgvRisks.RowTemplate.Height = 24;
            this.dtgvRisks.Size = new System.Drawing.Size(1164, 252);
            this.dtgvRisks.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.FillWeight = 48.12834F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Analista
            // 
            this.Analista.FillWeight = 112.9679F;
            this.Analista.HeaderText = "Analista";
            this.Analista.MinimumWidth = 6;
            this.Analista.Name = "Analista";
            this.Analista.ReadOnly = true;
            // 
            // BienActivo
            // 
            this.BienActivo.FillWeight = 112.9679F;
            this.BienActivo.HeaderText = "Bien o Activo";
            this.BienActivo.MinimumWidth = 6;
            this.BienActivo.Name = "BienActivo";
            this.BienActivo.ReadOnly = true;
            // 
            // Riesgo
            // 
            this.Riesgo.FillWeight = 112.9679F;
            this.Riesgo.HeaderText = "Riesgo";
            this.Riesgo.MinimumWidth = 6;
            this.Riesgo.Name = "Riesgo";
            // 
            // Daño
            // 
            this.Daño.FillWeight = 112.9679F;
            this.Daño.HeaderText = "Daño";
            this.Daño.MinimumWidth = 6;
            this.Daño.Name = "Daño";
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(76, 68);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(44, 42);
            this.btnSave1.TabIndex = 1;
            this.btnSave1.Text = "✔";
            this.btnSave1.UseVisualStyleBackColor = true;
            // 
            // btnNewRisk
            // 
            this.btnNewRisk.Location = new System.Drawing.Point(76, 7);
            this.btnNewRisk.Name = "btnNewRisk";
            this.btnNewRisk.Size = new System.Drawing.Size(44, 42);
            this.btnNewRisk.TabIndex = 0;
            this.btnNewRisk.Text = "➕";
            this.btnNewRisk.UseVisualStyleBackColor = true;
            this.btnNewRisk.Click += new System.EventHandler(this.btnNewRisk_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblCaseID2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtgvValues);
            this.tabPage2.Controls.Add(this.btnSave2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1170, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fase #2";
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(1064, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 24);
            this.lblID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(985, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 15;
            // 
            // lblCaseID2
            // 
            this.lblCaseID2.AutoSize = true;
            this.lblCaseID2.ForeColor = System.Drawing.Color.Orange;
            this.lblCaseID2.Location = new System.Drawing.Point(985, 54);
            this.lblCaseID2.Name = "lblCaseID2";
            this.lblCaseID2.Size = new System.Drawing.Size(61, 16);
            this.lblCaseID2.TabIndex = 14;
            this.lblCaseID2.Text = "Case ID:";
            this.lblCaseID2.Click += new System.EventHandler(this.lblCaseID2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Guardar Datos";
            // 
            // dtgvValues
            // 
            this.dtgvValues.AllowUserToAddRows = false;
            this.dtgvValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvValues.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ValorS,
            this.ValorF,
            this.ValorP,
            this.ValorA,
            this.ValorV,
            this.ValorE});
            this.dtgvValues.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvValues.Location = new System.Drawing.Point(3, 164);
            this.dtgvValues.Name = "dtgvValues";
            this.dtgvValues.RowHeadersWidth = 51;
            this.dtgvValues.RowTemplate.Height = 24;
            this.dtgvValues.Size = new System.Drawing.Size(1164, 275);
            this.dtgvValues.TabIndex = 4;
            this.dtgvValues.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvValues_CellEndEdit);
            this.dtgvValues.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgtvValues_CellValidating);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 198.0747F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Bien o Activo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 198.0747F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Riesgo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 198.0747F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Daño";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ValorS
            // 
            this.ValorS.FillWeight = 74.37184F;
            this.ValorS.HeaderText = "S";
            this.ValorS.MaxInputLength = 1;
            this.ValorS.MinimumWidth = 6;
            this.ValorS.Name = "ValorS";
            // 
            // ValorF
            // 
            this.ValorF.FillWeight = 57.41415F;
            this.ValorF.HeaderText = "F";
            this.ValorF.MaxInputLength = 1;
            this.ValorF.MinimumWidth = 6;
            this.ValorF.Name = "ValorF";
            // 
            // ValorP
            // 
            this.ValorP.FillWeight = 57.98459F;
            this.ValorP.HeaderText = "P";
            this.ValorP.MaxInputLength = 1;
            this.ValorP.MinimumWidth = 6;
            this.ValorP.Name = "ValorP";
            // 
            // ValorA
            // 
            this.ValorA.FillWeight = 58.26947F;
            this.ValorA.HeaderText = "A";
            this.ValorA.MaxInputLength = 1;
            this.ValorA.MinimumWidth = 6;
            this.ValorA.Name = "ValorA";
            // 
            // ValorV
            // 
            this.ValorV.FillWeight = 51.45176F;
            this.ValorV.HeaderText = "V";
            this.ValorV.MaxInputLength = 1;
            this.ValorV.MinimumWidth = 6;
            this.ValorV.Name = "ValorV";
            // 
            // ValorE
            // 
            this.ValorE.FillWeight = 45.18789F;
            this.ValorE.HeaderText = "E";
            this.ValorE.MaxInputLength = 1;
            this.ValorE.MinimumWidth = 6;
            this.ValorE.Name = "ValorE";
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(107, 41);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(44, 42);
            this.btnSave2.TabIndex = 1;
            this.btnSave2.Text = "✔";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtgvEvaluation);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1170, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fase #3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgvEvaluation
            // 
            this.dtgvEvaluation.AllowUserToAddRows = false;
            this.dtgvEvaluation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEvaluation.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgvEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEvaluation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fase3Activo,
            this.Fase3Riesgo,
            this.Fase3Daño,
            this.CarDeRiesgo,
            this.PdeRiesgo,
            this.CuanDeRiesgo});
            this.dtgvEvaluation.Location = new System.Drawing.Point(3, 79);
            this.dtgvEvaluation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvEvaluation.Name = "dtgvEvaluation";
            this.dtgvEvaluation.RowHeadersWidth = 51;
            this.dtgvEvaluation.RowTemplate.Height = 24;
            this.dtgvEvaluation.Size = new System.Drawing.Size(1165, 362);
            this.dtgvEvaluation.TabIndex = 0;
            this.dtgvEvaluation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEvaluation_CellContentClick);
            // 
            // Fase3Activo
            // 
            this.Fase3Activo.HeaderText = "Bien o Activo";
            this.Fase3Activo.MinimumWidth = 6;
            this.Fase3Activo.Name = "Fase3Activo";
            this.Fase3Activo.ReadOnly = true;
            // 
            // Fase3Riesgo
            // 
            this.Fase3Riesgo.HeaderText = "Riesgo";
            this.Fase3Riesgo.MinimumWidth = 6;
            this.Fase3Riesgo.Name = "Fase3Riesgo";
            this.Fase3Riesgo.ReadOnly = true;
            // 
            // Fase3Daño
            // 
            this.Fase3Daño.HeaderText = "Daño";
            this.Fase3Daño.MinimumWidth = 6;
            this.Fase3Daño.Name = "Fase3Daño";
            this.Fase3Daño.ReadOnly = true;
            // 
            // CarDeRiesgo
            // 
            this.CarDeRiesgo.HeaderText = "Carácter de Riesgo";
            this.CarDeRiesgo.MinimumWidth = 6;
            this.CarDeRiesgo.Name = "CarDeRiesgo";
            this.CarDeRiesgo.ReadOnly = true;
            // 
            // PdeRiesgo
            // 
            this.PdeRiesgo.HeaderText = "Prob. de Riesgo \"Pb\"";
            this.PdeRiesgo.MinimumWidth = 6;
            this.PdeRiesgo.Name = "PdeRiesgo";
            this.PdeRiesgo.ReadOnly = true;
            // 
            // CuanDeRiesgo
            // 
            this.CuanDeRiesgo.HeaderText = "Cuantificación de Riesgo \"ER\"";
            this.CuanDeRiesgo.MinimumWidth = 6;
            this.CuanDeRiesgo.Name = "CuanDeRiesgo";
            this.CuanDeRiesgo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 471);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("MT Extra", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "RisXpert";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRisks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvValues)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEvaluation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnNewRisk;
        private System.Windows.Forms.DataGridView dtgvRisks;
        private System.Windows.Forms.TextBox txtAnalystName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblNewRisk;
        private System.Windows.Forms.Label lblAnalyst;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analista;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCaseID2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvValues;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorE;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtgvEvaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Daño;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarDeRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PdeRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuanDeRiesgo;
    }
}

