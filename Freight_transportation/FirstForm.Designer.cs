
namespace Freight_transportation
{
    partial class FirstForm
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
            this.tabl = new System.Windows.Forms.TabControl();
            this.PilotINFO = new System.Windows.Forms.TabPage();
            this.button = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.Name_pilot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_pilot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stage_pilot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverINFO = new System.Windows.Forms.TabPage();
            this.dataTable_driver = new System.Windows.Forms.DataGridView();
            this.Name_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stage_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodINFO = new System.Windows.Forms.TabPage();
            this.dataGood = new System.Windows.Forms.DataGridView();
            this.Name_good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabl.SuspendLayout();
            this.PilotINFO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.DriverINFO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_driver)).BeginInit();
            this.GoodINFO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGood)).BeginInit();
            this.SuspendLayout();
            // 
            // tabl
            // 
            this.tabl.Controls.Add(this.PilotINFO);
            this.tabl.Controls.Add(this.DriverINFO);
            this.tabl.Controls.Add(this.GoodINFO);
            this.tabl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabl.Location = new System.Drawing.Point(0, 0);
            this.tabl.MaximumSize = new System.Drawing.Size(800, 450);
            this.tabl.Name = "tabl";
            this.tabl.SelectedIndex = 0;
            this.tabl.Size = new System.Drawing.Size(800, 450);
            this.tabl.TabIndex = 0;
            // 
            // PilotINFO
            // 
            this.PilotINFO.Controls.Add(this.button);
            this.PilotINFO.Controls.Add(this.dataTable);
            this.PilotINFO.Location = new System.Drawing.Point(4, 22);
            this.PilotINFO.Name = "PilotINFO";
            this.PilotINFO.Padding = new System.Windows.Forms.Padding(3);
            this.PilotINFO.Size = new System.Drawing.Size(792, 424);
            this.PilotINFO.TabIndex = 0;
            this.PilotINFO.Text = "Pilot";
            this.PilotINFO.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button.Location = new System.Drawing.Point(3, 398);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(786, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Показать информацию";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_pilot,
            this.Surname_pilot,
            this.Stage_pilot,
            this.idEdu});
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(3, 3);
            this.dataTable.MaximumSize = new System.Drawing.Size(786, 418);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(786, 418);
            this.dataTable.TabIndex = 0;
            // 
            // Name_pilot
            // 
            this.Name_pilot.HeaderText = "Name";
            this.Name_pilot.Name = "Name_pilot";
            // 
            // Surname_pilot
            // 
            this.Surname_pilot.HeaderText = "Surname";
            this.Surname_pilot.Name = "Surname_pilot";
            // 
            // Stage_pilot
            // 
            this.Stage_pilot.HeaderText = "Stage";
            this.Stage_pilot.Name = "Stage_pilot";
            // 
            // idEdu
            // 
            this.idEdu.HeaderText = "idEducation";
            this.idEdu.Name = "idEdu";
            // 
            // DriverINFO
            // 
            this.DriverINFO.Controls.Add(this.dataTable_driver);
            this.DriverINFO.Location = new System.Drawing.Point(4, 22);
            this.DriverINFO.Name = "DriverINFO";
            this.DriverINFO.Padding = new System.Windows.Forms.Padding(3);
            this.DriverINFO.Size = new System.Drawing.Size(792, 424);
            this.DriverINFO.TabIndex = 1;
            this.DriverINFO.Text = "Driver";
            this.DriverINFO.UseVisualStyleBackColor = true;
            // 
            // dataTable_driver
            // 
            this.dataTable_driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable_driver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_driver,
            this.Surname_driver,
            this.Stage_driver});
            this.dataTable_driver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable_driver.Location = new System.Drawing.Point(3, 3);
            this.dataTable_driver.MaximumSize = new System.Drawing.Size(786, 418);
            this.dataTable_driver.Name = "dataTable_driver";
            this.dataTable_driver.Size = new System.Drawing.Size(786, 418);
            this.dataTable_driver.TabIndex = 0;
            // 
            // Name_driver
            // 
            this.Name_driver.HeaderText = "Name";
            this.Name_driver.Name = "Name_driver";
            // 
            // Surname_driver
            // 
            this.Surname_driver.HeaderText = "Surname";
            this.Surname_driver.Name = "Surname_driver";
            // 
            // Stage_driver
            // 
            this.Stage_driver.HeaderText = "Stage";
            this.Stage_driver.Name = "Stage_driver";
            // 
            // GoodINFO
            // 
            this.GoodINFO.Controls.Add(this.dataGood);
            this.GoodINFO.Location = new System.Drawing.Point(4, 22);
            this.GoodINFO.Name = "GoodINFO";
            this.GoodINFO.Padding = new System.Windows.Forms.Padding(3);
            this.GoodINFO.Size = new System.Drawing.Size(792, 424);
            this.GoodINFO.TabIndex = 2;
            this.GoodINFO.Text = "Good";
            this.GoodINFO.UseVisualStyleBackColor = true;
            // 
            // dataGood
            // 
            this.dataGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_good,
            this.Weight});
            this.dataGood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGood.Location = new System.Drawing.Point(3, 3);
            this.dataGood.MaximumSize = new System.Drawing.Size(786, 418);
            this.dataGood.Name = "dataGood";
            this.dataGood.Size = new System.Drawing.Size(786, 418);
            this.dataGood.TabIndex = 0;
            // 
            // Name_good
            // 
            this.Name_good.HeaderText = "Name";
            this.Name_good.Name = "Name_good";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabl);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "FirstForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.tabl.ResumeLayout(false);
            this.PilotINFO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.DriverINFO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_driver)).EndInit();
            this.GoodINFO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabl;
        private System.Windows.Forms.TabPage PilotINFO;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.TabPage DriverINFO;
        private System.Windows.Forms.DataGridView dataTable_driver;
        private System.Windows.Forms.TabPage GoodINFO;
        private System.Windows.Forms.DataGridView dataGood;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_pilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_pilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage_pilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_good;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}

