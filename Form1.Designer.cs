namespace WindowsForms2hw2sp
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
            System.Windows.Forms.Button btnPauseFibonacci;
            this.lblLowerBound = new System.Windows.Forms.Label();
            this.lblUpperBound = new System.Windows.Forms.Label();
            this.txtLowerBound = new System.Windows.Forms.TextBox();
            this.txtUpperBound = new System.Windows.Forms.TextBox();
            this.btnGeneratePrimes = new System.Windows.Forms.Button();
            this.lstPrimes = new System.Windows.Forms.ListBox();
            this.btnStopPrimes = new System.Windows.Forms.Button();
            this.btnGenerateFibonacci = new System.Windows.Forms.Button();
            this.btnStopFibonacci = new System.Windows.Forms.Button();
            this.btnResumeFibonacci = new System.Windows.Forms.Button();
            this.btnRestartPrimes = new System.Windows.Forms.Button();
            this.lstFibonacci = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            btnPauseFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPauseFibonacci
            // 
            btnPauseFibonacci.BackColor = System.Drawing.Color.LightSalmon;
            btnPauseFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnPauseFibonacci.Location = new System.Drawing.Point(359, 363);
            btnPauseFibonacci.Name = "btnPauseFibonacci";
            btnPauseFibonacci.Size = new System.Drawing.Size(186, 77);
            btnPauseFibonacci.TabIndex = 9;
            btnPauseFibonacci.Text = "Пауза генерации чисел Фибоначче";
            btnPauseFibonacci.UseVisualStyleBackColor = false;
            btnPauseFibonacci.Click += new System.EventHandler(this.btnPauseFibonacci_Click);
            // 
            // lblLowerBound
            // 
            this.lblLowerBound.AutoSize = true;
            this.lblLowerBound.BackColor = System.Drawing.Color.Tomato;
            this.lblLowerBound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLowerBound.Location = new System.Drawing.Point(12, 24);
            this.lblLowerBound.Name = "lblLowerBound";
            this.lblLowerBound.Size = new System.Drawing.Size(161, 20);
            this.lblLowerBound.TabIndex = 0;
            this.lblLowerBound.Text = "Нижняя граница";
            // 
            // lblUpperBound
            // 
            this.lblUpperBound.AutoSize = true;
            this.lblUpperBound.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblUpperBound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpperBound.Location = new System.Drawing.Point(189, 24);
            this.lblUpperBound.Name = "lblUpperBound";
            this.lblUpperBound.Size = new System.Drawing.Size(167, 20);
            this.lblUpperBound.TabIndex = 1;
            this.lblUpperBound.Text = "Верхняя граница";
            // 
            // txtLowerBound
            // 
            this.txtLowerBound.Location = new System.Drawing.Point(61, 73);
            this.txtLowerBound.Name = "txtLowerBound";
            this.txtLowerBound.Size = new System.Drawing.Size(57, 22);
            this.txtLowerBound.TabIndex = 2;
            // 
            // txtUpperBound
            // 
            this.txtUpperBound.Location = new System.Drawing.Point(215, 73);
            this.txtUpperBound.Name = "txtUpperBound";
            this.txtUpperBound.Size = new System.Drawing.Size(61, 22);
            this.txtUpperBound.TabIndex = 3;
            // 
            // btnGeneratePrimes
            // 
            this.btnGeneratePrimes.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGeneratePrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGeneratePrimes.Location = new System.Drawing.Point(414, 37);
            this.btnGeneratePrimes.Name = "btnGeneratePrimes";
            this.btnGeneratePrimes.Size = new System.Drawing.Size(321, 36);
            this.btnGeneratePrimes.TabIndex = 4;
            this.btnGeneratePrimes.Text = "Генерировать простые числа";
            this.btnGeneratePrimes.UseVisualStyleBackColor = false;
            // 
            // lstPrimes
            // 
            this.lstPrimes.FormattingEnabled = true;
            this.lstPrimes.ItemHeight = 16;
            this.lstPrimes.Location = new System.Drawing.Point(39, 104);
            this.lstPrimes.Name = "lstPrimes";
            this.lstPrimes.Size = new System.Drawing.Size(263, 148);
            this.lstPrimes.TabIndex = 5;
            // 
            // btnStopPrimes
            // 
            this.btnStopPrimes.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStopPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopPrimes.Location = new System.Drawing.Point(414, 79);
            this.btnStopPrimes.Name = "btnStopPrimes";
            this.btnStopPrimes.Size = new System.Drawing.Size(321, 82);
            this.btnStopPrimes.TabIndex = 6;
            this.btnStopPrimes.Text = "Стоп генерации простых чисел";
            this.btnStopPrimes.UseVisualStyleBackColor = false;
            this.btnStopPrimes.Click += new System.EventHandler(this.btnStopPrimes_Click);
            // 
            // btnGenerateFibonacci
            // 
            this.btnGenerateFibonacci.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGenerateFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateFibonacci.Location = new System.Drawing.Point(414, 230);
            this.btnGenerateFibonacci.Name = "btnGenerateFibonacci";
            this.btnGenerateFibonacci.Size = new System.Drawing.Size(321, 48);
            this.btnGenerateFibonacci.TabIndex = 7;
            this.btnGenerateFibonacci.Text = "Генерация чисел Фибоначчи";
            this.btnGenerateFibonacci.UseVisualStyleBackColor = false;
            // 
            // btnStopFibonacci
            // 
            this.btnStopFibonacci.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStopFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopFibonacci.Location = new System.Drawing.Point(414, 295);
            this.btnStopFibonacci.Name = "btnStopFibonacci";
            this.btnStopFibonacci.Size = new System.Drawing.Size(331, 58);
            this.btnStopFibonacci.TabIndex = 8;
            this.btnStopFibonacci.Text = "Остановка генерации чисел Фибоначчи";
            this.btnStopFibonacci.UseVisualStyleBackColor = false;
            // 
            // btnResumeFibonacci
            // 
            this.btnResumeFibonacci.BackColor = System.Drawing.Color.OliveDrab;
            this.btnResumeFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResumeFibonacci.Location = new System.Drawing.Point(573, 363);
            this.btnResumeFibonacci.Name = "btnResumeFibonacci";
            this.btnResumeFibonacci.Size = new System.Drawing.Size(200, 77);
            this.btnResumeFibonacci.TabIndex = 10;
            this.btnResumeFibonacci.Text = "Возобновление генерации";
            this.btnResumeFibonacci.UseVisualStyleBackColor = false;
            this.btnResumeFibonacci.Click += new System.EventHandler(this.btnResumeFibonacci_Click);
            // 
            // btnRestartPrimes
            // 
            this.btnRestartPrimes.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRestartPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestartPrimes.Location = new System.Drawing.Point(414, 167);
            this.btnRestartPrimes.Name = "btnRestartPrimes";
            this.btnRestartPrimes.Size = new System.Drawing.Size(321, 57);
            this.btnRestartPrimes.TabIndex = 11;
            this.btnRestartPrimes.Text = "Рестрат генерации простых чисел";
            this.btnRestartPrimes.UseVisualStyleBackColor = false;
            // 
            // lstFibonacci
            // 
            this.lstFibonacci.FormattingEnabled = true;
            this.lstFibonacci.ItemHeight = 16;
            this.lstFibonacci.Location = new System.Drawing.Point(39, 263);
            this.lstFibonacci.Name = "lstFibonacci";
            this.lstFibonacci.Size = new System.Drawing.Size(263, 164);
            this.lstFibonacci.TabIndex = 12;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(509, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 30);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "СТАРТ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstFibonacci);
            this.Controls.Add(this.btnRestartPrimes);
            this.Controls.Add(this.btnResumeFibonacci);
            this.Controls.Add(btnPauseFibonacci);
            this.Controls.Add(this.btnStopFibonacci);
            this.Controls.Add(this.btnGenerateFibonacci);
            this.Controls.Add(this.btnStopPrimes);
            this.Controls.Add(this.lstPrimes);
            this.Controls.Add(this.btnGeneratePrimes);
            this.Controls.Add(this.txtUpperBound);
            this.Controls.Add(this.txtLowerBound);
            this.Controls.Add(this.lblUpperBound);
            this.Controls.Add(this.lblLowerBound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLowerBound;
        private System.Windows.Forms.Label lblUpperBound;
        private System.Windows.Forms.TextBox txtLowerBound;
        private System.Windows.Forms.TextBox txtUpperBound;
        private System.Windows.Forms.Button btnGeneratePrimes;
        private System.Windows.Forms.ListBox lstPrimes;
        private System.Windows.Forms.Button btnStopPrimes;
        private System.Windows.Forms.Button btnGenerateFibonacci;
        private System.Windows.Forms.Button btnStopFibonacci;
        private System.Windows.Forms.Button btnResumeFibonacci;
        private System.Windows.Forms.Button btnRestartPrimes;
        private System.Windows.Forms.ListBox lstFibonacci;
        private System.Windows.Forms.Button btnStart;
    }
}

