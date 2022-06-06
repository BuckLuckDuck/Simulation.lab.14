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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_oper_1 = new System.Windows.Forms.Button();
            this.btn_oper_2 = new System.Windows.Forms.Button();
            this.btn_oper_3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(974, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(46, 41);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btn_oper_1
            // 
            this.btn_oper_1.BackColor = System.Drawing.Color.Lime;
            this.btn_oper_1.Enabled = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_oper_3);
            this.Controls.Add(this.btn_oper_2);
            this.Controls.Add(this.btn_oper_1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_oper_1;
        private System.Windows.Forms.Button btn_oper_2;
        private System.Windows.Forms.Button btn_oper_3;
        private System.Windows.Forms.Label label1;
    }
}

