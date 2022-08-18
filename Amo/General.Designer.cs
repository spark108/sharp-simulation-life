
namespace Amo
{
    partial class General
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddSimBtn = new System.Windows.Forms.Button();
            this.ResumeAllSimBtn = new System.Windows.Forms.Button();
            this.PauseAllSimBtn = new System.Windows.Forms.Button();
            this.SimulationList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.startSimBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SimIdLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PointSizeTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DensityTrack = new System.Windows.Forms.TrackBar();
            this.stopSimBtn = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointSizeTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.tabControl1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 578);
            this.menuPanel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.SimulationList);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Все";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddSimBtn);
            this.panel1.Controls.Add(this.ResumeAllSimBtn);
            this.panel1.Controls.Add(this.PauseAllSimBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 110);
            this.panel1.TabIndex = 1;
            // 
            // AddSimBtn
            // 
            this.AddSimBtn.Location = new System.Drawing.Point(3, 3);
            this.AddSimBtn.Name = "AddSimBtn";
            this.AddSimBtn.Size = new System.Drawing.Size(178, 23);
            this.AddSimBtn.TabIndex = 2;
            this.AddSimBtn.Text = "Создать новую";
            this.AddSimBtn.UseVisualStyleBackColor = true;
            this.AddSimBtn.Click += new System.EventHandler(this.AddSimBtn_Click);
            // 
            // ResumeAllSimBtn
            // 
            this.ResumeAllSimBtn.Location = new System.Drawing.Point(5, 51);
            this.ResumeAllSimBtn.Name = "ResumeAllSimBtn";
            this.ResumeAllSimBtn.Size = new System.Drawing.Size(178, 23);
            this.ResumeAllSimBtn.TabIndex = 1;
            this.ResumeAllSimBtn.Text = "Запустить все";
            this.ResumeAllSimBtn.UseVisualStyleBackColor = true;
            this.ResumeAllSimBtn.Click += new System.EventHandler(this.ResumeAllSimBtn_Click);
            // 
            // PauseAllSimBtn
            // 
            this.PauseAllSimBtn.Location = new System.Drawing.Point(5, 80);
            this.PauseAllSimBtn.Name = "PauseAllSimBtn";
            this.PauseAllSimBtn.Size = new System.Drawing.Size(178, 23);
            this.PauseAllSimBtn.TabIndex = 0;
            this.PauseAllSimBtn.Text = "Приостановить все";
            this.PauseAllSimBtn.UseVisualStyleBackColor = true;
            this.PauseAllSimBtn.Click += new System.EventHandler(this.PauseAllSimBtn_Click);
            // 
            // SimulationList
            // 
            this.SimulationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SimulationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationList.FormattingEnabled = true;
            this.SimulationList.ItemHeight = 15;
            this.SimulationList.Location = new System.Drawing.Point(3, 3);
            this.SimulationList.Name = "SimulationList";
            this.SimulationList.Size = new System.Drawing.Size(186, 544);
            this.SimulationList.TabIndex = 0;
            this.SimulationList.SelectedIndexChanged += new System.EventHandler(this.SimulationList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stopSimBtn);
            this.tabPage2.Controls.Add(this.startSimBtn);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Текущая";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // startSimBtn
            // 
            this.startSimBtn.Location = new System.Drawing.Point(8, 275);
            this.startSimBtn.Name = "startSimBtn";
            this.startSimBtn.Size = new System.Drawing.Size(178, 25);
            this.startSimBtn.TabIndex = 2;
            this.startSimBtn.Text = "Начать симуляцию";
            this.startSimBtn.UseVisualStyleBackColor = true;
            this.startSimBtn.Click += new System.EventHandler(this.startSimBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SimIdLabel);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Симуляция";
            // 
            // SimIdLabel
            // 
            this.SimIdLabel.Location = new System.Drawing.Point(6, 19);
            this.SimIdLabel.Name = "SimIdLabel";
            this.SimIdLabel.Size = new System.Drawing.Size(166, 70);
            this.SimIdLabel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PointSizeTrack);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DensityTrack);
            this.groupBox1.Location = new System.Drawing.Point(8, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инициалиация";
            // 
            // PointSizeTrack
            // 
            this.PointSizeTrack.Location = new System.Drawing.Point(6, 105);
            this.PointSizeTrack.Maximum = 25;
            this.PointSizeTrack.Minimum = 1;
            this.PointSizeTrack.Name = "PointSizeTrack";
            this.PointSizeTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PointSizeTrack.Size = new System.Drawing.Size(166, 45);
            this.PointSizeTrack.TabIndex = 3;
            this.PointSizeTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PointSizeTrack.Value = 1;
            this.PointSizeTrack.Scroll += new System.EventHandler(this.PointSizeTrack_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Размер клетки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Плотность";
            // 
            // DensityTrack
            // 
            this.DensityTrack.Location = new System.Drawing.Point(6, 41);
            this.DensityTrack.Maximum = 100;
            this.DensityTrack.Minimum = 2;
            this.DensityTrack.Name = "DensityTrack";
            this.DensityTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DensityTrack.Size = new System.Drawing.Size(166, 45);
            this.DensityTrack.TabIndex = 0;
            this.DensityTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DensityTrack.Value = 2;
            this.DensityTrack.Scroll += new System.EventHandler(this.DensityTrack_Scroll);
            // 
            // stopSimBtn
            // 
            this.stopSimBtn.Location = new System.Drawing.Point(8, 306);
            this.stopSimBtn.Name = "stopSimBtn";
            this.stopSimBtn.Size = new System.Drawing.Size(178, 25);
            this.stopSimBtn.TabIndex = 3;
            this.stopSimBtn.Text = "Остановить симуляцию";
            this.stopSimBtn.UseVisualStyleBackColor = true;
            this.stopSimBtn.Click += new System.EventHandler(this.stopSimBtn_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 578);
            this.Controls.Add(this.menuPanel);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1188, 617);
            this.Name = "General";
            this.Text = "Главное окно";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointSizeTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddSimBtn;
        private System.Windows.Forms.Button ResumeAllSimBtn;
        private System.Windows.Forms.Button PauseAllSimBtn;
        private System.Windows.Forms.ListBox SimulationList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar DensityTrack;
        private System.Windows.Forms.TrackBar PointSizeTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SimIdLabel;
        private System.Windows.Forms.Button startSimBtn;
        private System.Windows.Forms.Button stopSimBtn;
    }
}

