namespace BankS
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new BankS.Database1DataSet1();
            this.database1DataSet = new BankS.Database1DataSet();
            this.table1TableAdapter = new BankS.Database1DataSet1TableAdapters.table1TableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрытьИСохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameV = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Stavka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViplProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popoln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChastichSn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinVelSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameV,
            this.Stavka,
            this.MinSum,
            this.ViplProc,
            this.Capital,
            this.Popoln,
            this.ChastichSn,
            this.MinVelSr});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1367, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "table1";
            this.table1BindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьИСохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1367, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закрытьИСохранитьToolStripMenuItem
            // 
            this.закрытьИСохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.закрытьИСохранитьToolStripMenuItem.Name = "закрытьИСохранитьToolStripMenuItem";
            this.закрытьИСохранитьToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.закрытьИСохранитьToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить и выйти";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // NameV
            // 
            this.NameV.DataPropertyName = "Naime";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameV.DefaultCellStyle = dataGridViewCellStyle1;
            this.NameV.HeaderText = "Наименование Вклада";
            this.NameV.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.NameV.LinkColor = System.Drawing.Color.Black;
            this.NameV.Name = "NameV";
            this.NameV.Width = 180;
            // 
            // Stavka
            // 
            this.Stavka.DataPropertyName = "Stavka";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stavka.DefaultCellStyle = dataGridViewCellStyle2;
            this.Stavka.HeaderText = "Ставка";
            this.Stavka.Name = "Stavka";
            // 
            // MinSum
            // 
            this.MinSum.DataPropertyName = "MinSumTisR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinSum.DefaultCellStyle = dataGridViewCellStyle3;
            this.MinSum.HeaderText = "Минимальная сумма тыс. руб.";
            this.MinSum.Name = "MinSum";
            // 
            // ViplProc
            // 
            this.ViplProc.DataPropertyName = "ViplataProc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViplProc.DefaultCellStyle = dataGridViewCellStyle4;
            this.ViplProc.HeaderText = "Выплата Процентов";
            this.ViplProc.Name = "ViplProc";
            // 
            // Capital
            // 
            this.Capital.DataPropertyName = "Capital";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capital.DefaultCellStyle = dataGridViewCellStyle5;
            this.Capital.HeaderText = "Капитализация";
            this.Capital.Name = "Capital";
            this.Capital.Width = 150;
            // 
            // Popoln
            // 
            this.Popoln.DataPropertyName = "Popoln";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Popoln.DefaultCellStyle = dataGridViewCellStyle6;
            this.Popoln.HeaderText = "Пополнение";
            this.Popoln.Name = "Popoln";
            // 
            // ChastichSn
            // 
            this.ChastichSn.DataPropertyName = "ChastichSn";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChastichSn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ChastichSn.HeaderText = "Частичное снятие";
            this.ChastichSn.Name = "ChastichSn";
            // 
            // MinVelSr
            // 
            this.MinVelSr.DataPropertyName = "MinVel";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinVelSr.DefaultCellStyle = dataGridViewCellStyle8;
            this.MinVelSr.HeaderText = "Минимальная величина срока, дни";
            this.MinVelSr.Name = "MinVelSr";
            this.MinVelSr.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 268);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Таблица экспертов";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private Database1DataSet1TableAdapters.table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьИСохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewLinkColumn NameV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stavka;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViplProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popoln;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChastichSn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinVelSr;
    }
}