namespace Simulation.lab._14
{
    partial class Form1
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_oper_1 = new System.Windows.Forms.Button();
            this.btn_oper_2 = new System.Windows.Forms.Button();
            this.btn_oper_3 = new System.Windows.Forms.Button();
            this.lbl_oper_1 = new System.Windows.Forms.Label();
            this.lbl_oper_2 = new System.Windows.Forms.Label();
            this.lbl_oper_3 = new System.Windows.Forms.Label();
            this.lbl_ppl = new System.Windows.Forms.Label();
            this.lbl_ppl_count = new System.Windows.Forms.Label();
            this.nud_avg_new_ppl = new System.Windows.Forms.NumericUpDown();
            this.lbl_avg_new_ppl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_avg_service_time = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_avg_new_ppl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_avg_service_time)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(974, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(46, 41);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_oper_1
            // 
            this.btn_oper_1.BackColor = System.Drawing.Color.Lime;
            this.btn_oper_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oper_1.Location = new System.Drawing.Point(44, 94);
            this.btn_oper_1.Name = "btn_oper_1";
            this.btn_oper_1.Size = new System.Drawing.Size(277, 144);
            this.btn_oper_1.TabIndex = 1;
            this.btn_oper_1.UseVisualStyleBackColor = false;
            // 
            // btn_oper_2
            // 
            this.btn_oper_2.BackColor = System.Drawing.Color.Lime;
            this.btn_oper_2.Enabled = false;
            this.btn_oper_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oper_2.Location = new System.Drawing.Point(360, 94);
            this.btn_oper_2.Name = "btn_oper_2";
            this.btn_oper_2.Size = new System.Drawing.Size(268, 144);
            this.btn_oper_2.TabIndex = 2;
            this.btn_oper_2.UseVisualStyleBackColor = false;
            // 
            // btn_oper_3
            // 
            this.btn_oper_3.BackColor = System.Drawing.Color.Lime;
            this.btn_oper_3.Enabled = false;
            this.btn_oper_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oper_3.Location = new System.Drawing.Point(676, 94);
            this.btn_oper_3.Name = "btn_oper_3";
            this.btn_oper_3.Size = new System.Drawing.Size(271, 144);
            this.btn_oper_3.TabIndex = 3;
            this.btn_oper_3.UseVisualStyleBackColor = false;
            // 
            // lbl_oper_1
            // 
            this.lbl_oper_1.AutoSize = true;
            this.lbl_oper_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_oper_1.Location = new System.Drawing.Point(41, 40);
            this.lbl_oper_1.Name = "lbl_oper_1";
            this.lbl_oper_1.Size = new System.Drawing.Size(99, 24);
            this.lbl_oper_1.TabIndex = 4;
            this.lbl_oper_1.Text = "Operator 1";
            // 
            // lbl_oper_2
            // 
            this.lbl_oper_2.AutoSize = true;
            this.lbl_oper_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_oper_2.Location = new System.Drawing.Point(356, 40);
            this.lbl_oper_2.Name = "lbl_oper_2";
            this.lbl_oper_2.Size = new System.Drawing.Size(99, 24);
            this.lbl_oper_2.TabIndex = 5;
            this.lbl_oper_2.Text = "Operator 2";
            // 
            // lbl_oper_3
            // 
            this.lbl_oper_3.AutoSize = true;
            this.lbl_oper_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_oper_3.Location = new System.Drawing.Point(672, 40);
            this.lbl_oper_3.Name = "lbl_oper_3";
            this.lbl_oper_3.Size = new System.Drawing.Size(99, 24);
            this.lbl_oper_3.TabIndex = 6;
            this.lbl_oper_3.Text = "Operator 3";
            // 
            // lbl_ppl
            // 
            this.lbl_ppl.AutoSize = true;
            this.lbl_ppl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ppl.Location = new System.Drawing.Point(41, 287);
            this.lbl_ppl.Name = "lbl_ppl";
            this.lbl_ppl.Size = new System.Drawing.Size(130, 24);
            this.lbl_ppl.TabIndex = 7;
            this.lbl_ppl.Text = "People in line:";
            // 
            // lbl_ppl_count
            // 
            this.lbl_ppl_count.AutoSize = true;
            this.lbl_ppl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ppl_count.Location = new System.Drawing.Point(177, 287);
            this.lbl_ppl_count.Name = "lbl_ppl_count";
            this.lbl_ppl_count.Size = new System.Drawing.Size(20, 24);
            this.lbl_ppl_count.TabIndex = 8;
            this.lbl_ppl_count.Text = "0";
            // 
            // nud_avg_new_ppl
            // 
            this.nud_avg_new_ppl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_avg_new_ppl.Location = new System.Drawing.Point(827, 288);
            this.nud_avg_new_ppl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_avg_new_ppl.Name = "nud_avg_new_ppl";
            this.nud_avg_new_ppl.Size = new System.Drawing.Size(120, 26);
            this.nud_avg_new_ppl.TabIndex = 9;
            this.nud_avg_new_ppl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_avg_new_ppl.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lbl_avg_new_ppl
            // 
            this.lbl_avg_new_ppl.AutoSize = true;
            this.lbl_avg_new_ppl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_avg_new_ppl.Location = new System.Drawing.Point(672, 287);
            this.lbl_avg_new_ppl.Name = "lbl_avg_new_ppl";
            this.lbl_avg_new_ppl.Size = new System.Drawing.Size(145, 24);
            this.lbl_avg_new_ppl.TabIndex = 10;
            this.lbl_avg_new_ppl.Text = "Average person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(316, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Average service time";
            // 
            // nud_avg_service_time
            // 
            this.nud_avg_service_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_avg_service_time.Location = new System.Drawing.Point(508, 285);
            this.nud_avg_service_time.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_avg_service_time.Name = "nud_avg_service_time";
            this.nud_avg_service_time.Size = new System.Drawing.Size(120, 26);
            this.nud_avg_service_time.TabIndex = 11;
            this.nud_avg_service_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_avg_service_time.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Lime;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(750, 351);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(197, 54);
            this.btn_start.TabIndex = 13;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Coral;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.Location = new System.Drawing.Point(750, 351);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(197, 54);
            this.btn_stop.TabIndex = 14;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 431);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_avg_service_time);
            this.Controls.Add(this.lbl_avg_new_ppl);
            this.Controls.Add(this.nud_avg_new_ppl);
            this.Controls.Add(this.lbl_ppl_count);
            this.Controls.Add(this.lbl_ppl);
            this.Controls.Add(this.lbl_oper_3);
            this.Controls.Add(this.lbl_oper_2);
            this.Controls.Add(this.lbl_oper_1);
            this.Controls.Add(this.btn_oper_3);
            this.Controls.Add(this.btn_oper_2);
            this.Controls.Add(this.btn_oper_1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_avg_new_ppl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_avg_service_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_oper_1;
        private System.Windows.Forms.Label lbl_oper_2;
        private System.Windows.Forms.Label lbl_oper_3;
        private System.Windows.Forms.Label lbl_ppl;
        private System.Windows.Forms.Label lbl_ppl_count;
        private System.Windows.Forms.Label lbl_avg_new_ppl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_avg_service_time;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_oper_1;
        public System.Windows.Forms.Button btn_oper_2;
        public System.Windows.Forms.Button btn_oper_3;
        public System.Windows.Forms.NumericUpDown nud_avg_new_ppl;
    }
}

