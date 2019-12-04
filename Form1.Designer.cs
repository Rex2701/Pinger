namespace Pinger
{
    partial class MainWin
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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PingTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Hostname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PingTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(45, 100);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(96, 32);
            this.Start.TabIndex = 0;
            this.Start.Text = "Пуск";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Stop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.Location = new System.Drawing.Point(182, 100);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(96, 32);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Интервал ожидания";
            // 
            // PingTimeOut
            // 
            this.PingTimeOut.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PingTimeOut.Location = new System.Drawing.Point(134, 47);
            this.PingTimeOut.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PingTimeOut.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PingTimeOut.Name = "PingTimeOut";
            this.PingTimeOut.Size = new System.Drawing.Size(58, 22);
            this.PingTimeOut.TabIndex = 12;
            this.PingTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PingTimeOut.ThousandsSeparator = true;
            this.PingTimeOut.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "мс";
            // 
            // Hostname
            // 
            this.Hostname.AllowDrop = true;
            this.Hostname.Location = new System.Drawing.Point(59, 13);
            this.Hostname.Name = "Hostname";
            this.Hostname.Size = new System.Drawing.Size(159, 22);
            this.Hostname.TabIndex = 16;
            this.Hostname.Text = "ya.ru";
            // 
            // MainWin
            // 
            this.AcceptButton = this.Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Stop;
            this.ClientSize = new System.Drawing.Size(321, 153);
            this.Controls.Add(this.Hostname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PingTimeOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.Text = "Pinger";
            ((System.ComponentModel.ISupportInitialize)(this.PingTimeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PingTimeOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Hostname;
    }
}

