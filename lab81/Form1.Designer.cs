namespace lab81
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btChoose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задай свой вопрос";
            // 
            // btChoose
            // 
            this.btChoose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btChoose.Location = new System.Drawing.Point(126, 131);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(145, 38);
            this.btChoose.TabIndex = 2;
            this.btChoose.Text = "Получить ответ!";
            this.btChoose.UseVisualStyleBackColor = false;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.SeaGreen;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnswer.Location = new System.Drawing.Point(87, 202);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(219, 98);
            this.txtAnswer.TabIndex = 5;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 391);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}

