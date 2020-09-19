using System;


 namespace Lab1_ping
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        ///
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
            this.dataGridView_scanning = new System.Windows.Forms.DataGridView();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud4 = new System.Windows.Forms.NumericUpDown();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.nud8 = new System.Windows.Forms.NumericUpDown();
            this.nud7 = new System.Windows.Forms.NumericUpDown();
            this.nud6 = new System.Windows.Forms.NumericUpDown();
            this.nud5 = new System.Windows.Forms.NumericUpDown();
            this.btn_scan = new System.Windows.Forms.Button();
            this.textBox_mask = new System.Windows.Forms.TextBox();
            this.textBox_network = new System.Windows.Forms.TextBox();
            this.textBox_gateway = new System.Windows.Forms.TextBox();
            this.textBox_broadcast = new System.Windows.Forms.TextBox();
            this.btn_analize = new System.Windows.Forms.Button();
            this.label_mask = new System.Windows.Forms.Label();
            this.label_network = new System.Windows.Forms.Label();
            this.label_broadcast = new System.Windows.Forms.Label();
            this.label_gateway = new System.Windows.Forms.Label();
            this.groupBox_scanning = new System.Windows.Forms.GroupBox();
            this.groupBox_analysis = new System.Windows.Forms.GroupBox();
            this.progressBar_scan = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud5)).BeginInit();
            this.groupBox_scanning.SuspendLayout();
            this.groupBox_analysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_scanning
            // 
            this.dataGridView_scanning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_scanning.Location = new System.Drawing.Point(386, 12);
            this.dataGridView_scanning.Name = "dataGridView_scanning";
            this.dataGridView_scanning.Size = new System.Drawing.Size(332, 416);
            this.dataGridView_scanning.TabIndex = 0;
            // 
            // nud1
            // 
            this.nud1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud1.Location = new System.Drawing.Point(75, 26);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(43, 21);
            this.nud1.TabIndex = 1;
            // 
            // nud2
            // 
            this.nud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud2.Location = new System.Drawing.Point(124, 26);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(43, 21);
            this.nud2.TabIndex = 2;
            // 
            // nud4
            // 
            this.nud4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud4.Location = new System.Drawing.Point(222, 26);
            this.nud4.Name = "nud4";
            this.nud4.Size = new System.Drawing.Size(43, 21);
            this.nud4.TabIndex = 4;
            // 
            // nud3
            // 
            this.nud3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud3.Location = new System.Drawing.Point(173, 26);
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(43, 21);
            this.nud3.TabIndex = 3;
            // 
            // nud8
            // 
            this.nud8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud8.Location = new System.Drawing.Point(222, 52);
            this.nud8.Name = "nud8";
            this.nud8.Size = new System.Drawing.Size(43, 21);
            this.nud8.TabIndex = 8;
            // 
            // nud7
            // 
            this.nud7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud7.Location = new System.Drawing.Point(173, 52);
            this.nud7.Name = "nud7";
            this.nud7.Size = new System.Drawing.Size(43, 21);
            this.nud7.TabIndex = 7;
            // 
            // nud6
            // 
            this.nud6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud6.Location = new System.Drawing.Point(124, 52);
            this.nud6.Name = "nud6";
            this.nud6.Size = new System.Drawing.Size(43, 21);
            this.nud6.TabIndex = 6;
            // 
            // nud5
            // 
            this.nud5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud5.Location = new System.Drawing.Point(75, 52);
            this.nud5.Name = "nud5";
            this.nud5.Size = new System.Drawing.Size(43, 21);
            this.nud5.TabIndex = 5;
            // 
            // btn_scan
            // 
            this.btn_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_scan.Location = new System.Drawing.Point(112, 79);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(118, 38);
            this.btn_scan.TabIndex = 9;
            this.btn_scan.Text = "Сканирование";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // textBox_mask
            // 
            this.textBox_mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mask.Location = new System.Drawing.Point(159, 45);
            this.textBox_mask.Name = "textBox_mask";
            this.textBox_mask.Size = new System.Drawing.Size(167, 21);
            this.textBox_mask.TabIndex = 10;
            // 
            // textBox_network
            // 
            this.textBox_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_network.Location = new System.Drawing.Point(159, 98);
            this.textBox_network.Name = "textBox_network";
            this.textBox_network.Size = new System.Drawing.Size(167, 21);
            this.textBox_network.TabIndex = 11;
            // 
            // textBox_gateway
            // 
            this.textBox_gateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_gateway.Location = new System.Drawing.Point(159, 211);
            this.textBox_gateway.Name = "textBox_gateway";
            this.textBox_gateway.Size = new System.Drawing.Size(167, 21);
            this.textBox_gateway.TabIndex = 13;
            // 
            // textBox_broadcast
            // 
            this.textBox_broadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_broadcast.Location = new System.Drawing.Point(159, 158);
            this.textBox_broadcast.Name = "textBox_broadcast";
            this.textBox_broadcast.Size = new System.Drawing.Size(167, 21);
            this.textBox_broadcast.TabIndex = 12;
            // 
            // btn_analize
            // 
            this.btn_analize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_analize.Location = new System.Drawing.Point(7, 126);
            this.btn_analize.Name = "btn_analize";
            this.btn_analize.Size = new System.Drawing.Size(102, 39);
            this.btn_analize.TabIndex = 16;
            this.btn_analize.Text = "Анализ";
            this.btn_analize.UseVisualStyleBackColor = true;
            this.btn_analize.Click += new System.EventHandler(this.onAnalisClick);
            // 
            // label_mask
            // 
            this.label_mask.AutoSize = true;
            this.label_mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mask.Location = new System.Drawing.Point(159, 26);
            this.label_mask.Name = "label_mask";
            this.label_mask.Size = new System.Drawing.Size(95, 15);
            this.label_mask.TabIndex = 15;
            this.label_mask.Text = "Маска подсети";
            // 
            // label_network
            // 
            this.label_network.AutoSize = true;
            this.label_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_network.Location = new System.Drawing.Point(162, 79);
            this.label_network.Name = "label_network";
            this.label_network.Size = new System.Drawing.Size(71, 15);
            this.label_network.TabIndex = 16;
            this.label_network.Text = "Адрес сети";
            // 
            // label_broadcast
            // 
            this.label_broadcast.AutoSize = true;
            this.label_broadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_broadcast.Location = new System.Drawing.Point(156, 139);
            this.label_broadcast.Name = "label_broadcast";
            this.label_broadcast.Size = new System.Drawing.Size(170, 15);
            this.label_broadcast.TabIndex = 17;
            this.label_broadcast.Text = "Широковещательный адрес";
            // 
            // label_gateway
            // 
            this.label_gateway.AutoSize = true;
            this.label_gateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gateway.Location = new System.Drawing.Point(159, 192);
            this.label_gateway.Name = "label_gateway";
            this.label_gateway.Size = new System.Drawing.Size(40, 15);
            this.label_gateway.TabIndex = 18;
            this.label_gateway.Text = "Шлюз";
            // 
            // groupBox_scanning
            // 
            this.groupBox_scanning.Controls.Add(this.progressBar_scan);
            this.groupBox_scanning.Controls.Add(this.btn_scan);
            this.groupBox_scanning.Controls.Add(this.nud1);
            this.groupBox_scanning.Controls.Add(this.nud2);
            this.groupBox_scanning.Controls.Add(this.nud3);
            this.groupBox_scanning.Controls.Add(this.nud4);
            this.groupBox_scanning.Controls.Add(this.nud5);
            this.groupBox_scanning.Controls.Add(this.nud6);
            this.groupBox_scanning.Controls.Add(this.nud7);
            this.groupBox_scanning.Controls.Add(this.nud8);
            this.groupBox_scanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_scanning.Location = new System.Drawing.Point(19, 12);
            this.groupBox_scanning.Name = "groupBox_scanning";
            this.groupBox_scanning.Size = new System.Drawing.Size(345, 158);
            this.groupBox_scanning.TabIndex = 19;
            this.groupBox_scanning.TabStop = false;
            this.groupBox_scanning.Text = "Сканирование диапазона";
            // 
            // groupBox_analysis
            // 
            this.groupBox_analysis.Controls.Add(this.textBox_broadcast);
            this.groupBox_analysis.Controls.Add(this.textBox_mask);
            this.groupBox_analysis.Controls.Add(this.label_gateway);
            this.groupBox_analysis.Controls.Add(this.textBox_network);
            this.groupBox_analysis.Controls.Add(this.label_broadcast);
            this.groupBox_analysis.Controls.Add(this.textBox_gateway);
            this.groupBox_analysis.Controls.Add(this.label_network);
            this.groupBox_analysis.Controls.Add(this.btn_analize);
            this.groupBox_analysis.Controls.Add(this.label_mask);
            this.groupBox_analysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_analysis.Location = new System.Drawing.Point(19, 176);
            this.groupBox_analysis.Name = "groupBox_analysis";
            this.groupBox_analysis.Size = new System.Drawing.Size(345, 252);
            this.groupBox_analysis.TabIndex = 20;
            this.groupBox_analysis.TabStop = false;
            this.groupBox_analysis.Text = "Анализ подсети";
            // 
            // progressBar_scan
            // 
            this.progressBar_scan.Location = new System.Drawing.Point(7, 123);
            this.progressBar_scan.Name = "progressBar_scan";
            this.progressBar_scan.Size = new System.Drawing.Size(319, 29);
            this.progressBar_scan.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.groupBox_analysis);
            this.Controls.Add(this.groupBox_scanning);
            this.Controls.Add(this.dataGridView_scanning);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud5)).EndInit();
            this.groupBox_scanning.ResumeLayout(false);
            this.groupBox_analysis.ResumeLayout(false);
            this.groupBox_analysis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_scanning;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud4;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.NumericUpDown nud8;
        private System.Windows.Forms.NumericUpDown nud7;
        private System.Windows.Forms.NumericUpDown nud6;
        private System.Windows.Forms.NumericUpDown nud5;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.TextBox textBox_mask;
        private System.Windows.Forms.TextBox textBox_network;
        private System.Windows.Forms.TextBox textBox_gateway;
        private System.Windows.Forms.TextBox textBox_broadcast;
        private System.Windows.Forms.Button btn_analize;
        private System.Windows.Forms.Label label_mask;
        private System.Windows.Forms.Label label_network;
        private System.Windows.Forms.Label label_broadcast;
        private System.Windows.Forms.Label label_gateway;
        private System.Windows.Forms.GroupBox groupBox_scanning;
        private System.Windows.Forms.GroupBox groupBox_analysis;
        private System.Windows.Forms.ProgressBar progressBar_scan;
    }
}