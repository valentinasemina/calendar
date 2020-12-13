namespace Kalendar
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
            this.tb_day = new System.Windows.Forms.TextBox();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_err = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_day
            // 
            this.tb_day.Location = new System.Drawing.Point(43, 45);
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(67, 20);
            this.tb_day.TabIndex = 0;
            // 
            // tb_month
            // 
            this.tb_month.Location = new System.Drawing.Point(116, 45);
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(67, 20);
            this.tb_month.TabIndex = 1;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(189, 45);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(67, 20);
            this.tb_year.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Today";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Next >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_err
            // 
            this.lb_err.AutoSize = true;
            this.lb_err.Location = new System.Drawing.Point(40, 72);
            this.lb_err.Name = "lb_err";
            this.lb_err.Size = new System.Drawing.Size(0, 13);
            this.lb_err.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(141, 88);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(75, 35);
            this.bt_create.TabIndex = 8;
            this.bt_create.Text = "Create";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_err);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.tb_month);
            this.Controls.Add(this.tb_day);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_day;
        private System.Windows.Forms.TextBox tb_month;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_err;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_create;
    }
}

