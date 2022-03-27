
namespace JSON_tranportation
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
            this.INFO = new System.Windows.Forms.TabControl();
            this.Pilot = new System.Windows.Forms.TabPage();
            this.Driver = new System.Windows.Forms.TabPage();
            this.Good = new System.Windows.Forms.TabPage();
            this.dataGOOD = new System.Windows.Forms.DataGridView();
            this.NameGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NamePilot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnamePilot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StagePilot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NameDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StageDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.Button();
            this.INFO.SuspendLayout();
            this.Pilot.SuspendLayout();
            this.Driver.SuspendLayout();
            this.Good.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGOOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // INFO
            // 
            this.INFO.Controls.Add(this.Pilot);
            this.INFO.Controls.Add(this.Driver);
            this.INFO.Controls.Add(this.Good);
            this.INFO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.INFO.Location = new System.Drawing.Point(0, 0);
            this.INFO.MaximumSize = new System.Drawing.Size(800, 450);
            this.INFO.Name = "INFO";
            this.INFO.SelectedIndex = 0;
            this.INFO.Size = new System.Drawing.Size(800, 450);
            this.INFO.TabIndex = 0;
            // 
            // Pilot
            // 
            this.Pilot.Controls.Add(this.dataGridView1);
            this.Pilot.Location = new System.Drawing.Point(4, 22);
            this.Pilot.Name = "Pilot";
            this.Pilot.Padding = new System.Windows.Forms.Padding(3);
            this.Pilot.Size = new System.Drawing.Size(792, 424);
            this.Pilot.TabIndex = 0;
            this.Pilot.Text = "Pilot";
            this.Pilot.UseVisualStyleBackColor = true;
            // 
            // Driver
            // 
            this.Driver.Controls.Add(this.button);
            this.Driver.Controls.Add(this.dataGridView2);
            this.Driver.Location = new System.Drawing.Point(4, 22);
            this.Driver.Name = "Driver";
            this.Driver.Padding = new System.Windows.Forms.Padding(3);
            this.Driver.Size = new System.Drawing.Size(792, 424);
            this.Driver.TabIndex = 1;
            this.Driver.Text = "Driver";
            this.Driver.UseVisualStyleBackColor = true;
            // 
            // Good
            // 
            this.Good.Controls.Add(this.dataGOOD);
            this.Good.Location = new System.Drawing.Point(4, 22);
            this.Good.Name = "Good";
            this.Good.Padding = new System.Windows.Forms.Padding(3);
            this.Good.Size = new System.Drawing.Size(792, 424);
            this.Good.TabIndex = 2;
            this.Good.Text = "Good";
            this.Good.UseVisualStyleBackColor = true;
            // 
            // dataGOOD
            // 
            this.dataGOOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGOOD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameGood,
            this.Weight});
            this.dataGOOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGOOD.Location = new System.Drawing.Point(3, 3);
            this.dataGOOD.MaximumSize = new System.Drawing.Size(786, 418);
            this.dataGOOD.Name = "dataGOOD";
            this.dataGOOD.Size = new System.Drawing.Size(786, 418);
            this.dataGOOD.TabIndex = 1;
            // 
            // NameGood
            // 
            this.NameGood.HeaderText = "Name";
            this.NameGood.Name = "NameGood";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePilot,
            this.SurnamePilot,
            this.StagePilot,
            this.IdEducation});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(786, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // NamePilot
            // 
            this.NamePilot.HeaderText = "Name";
            this.NamePilot.Name = "NamePilot";
            // 
            // SurnamePilot
            // 
            this.SurnamePilot.HeaderText = "Surname";
            this.SurnamePilot.Name = "SurnamePilot";
            // 
            // StagePilot
            // 
            this.StagePilot.HeaderText = "Stage";
            this.StagePilot.Name = "StagePilot";
            // 
            // IdEducation
            // 
            this.IdEducation.HeaderText = "IdEducation";
            this.IdEducation.Name = "IdEducation";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDriver,
            this.SurnameDriver,
            this.StageDriver});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MaximumSize = new System.Drawing.Size(786, 418);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 418);
            this.dataGridView2.TabIndex = 0;
            // 
            // NameDriver
            // 
            this.NameDriver.HeaderText = "Name";
            this.NameDriver.Name = "NameDriver";
            // 
            // SurnameDriver
            // 
            this.SurnameDriver.HeaderText = "Surname";
            this.SurnameDriver.Name = "SurnameDriver";
            // 
            // StageDriver
            // 
            this.StageDriver.HeaderText = "Stage";
            this.StageDriver.Name = "StageDriver";
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
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.INFO);
            this.Name = "FirstForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.INFO.ResumeLayout(false);
            this.Pilot.ResumeLayout(false);
            this.Driver.ResumeLayout(false);
            this.Good.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGOOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl INFO;
        private System.Windows.Forms.TabPage Pilot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnamePilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn StagePilot;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEducation;
        private System.Windows.Forms.TabPage Driver;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn StageDriver;
        private System.Windows.Forms.TabPage Good;
        private System.Windows.Forms.DataGridView dataGOOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.Button button;
    }
}

