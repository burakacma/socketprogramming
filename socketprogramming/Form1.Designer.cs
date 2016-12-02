namespace socketprogramming
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_portgonderen = new System.Windows.Forms.TextBox();
            this.txb_ipgonderen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_portalici = new System.Windows.Forms.TextBox();
            this.tbx_ipalici = new System.Windows.Forms.TextBox();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.listBox_massage = new System.Windows.Forms.ListBox();
            this.textBox_textmassage = new System.Windows.Forms.TextBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbx_portgonderen);
            this.groupBox1.Controls.Add(this.txb_ipgonderen);
            this.groupBox1.Location = new System.Drawing.Point(30, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kendi IP Bilgilerimiz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // tbx_portgonderen
            // 
            this.tbx_portgonderen.Location = new System.Drawing.Point(246, 48);
            this.tbx_portgonderen.Name = "tbx_portgonderen";
            this.tbx_portgonderen.Size = new System.Drawing.Size(35, 20);
            this.tbx_portgonderen.TabIndex = 1;
            this.tbx_portgonderen.Text = "80";
            // 
            // txb_ipgonderen
            // 
            this.txb_ipgonderen.Location = new System.Drawing.Point(6, 48);
            this.txb_ipgonderen.Name = "txb_ipgonderen";
            this.txb_ipgonderen.Size = new System.Drawing.Size(197, 20);
            this.txb_ipgonderen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbx_portalici);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbx_ipalici);
            this.groupBox2.Location = new System.Drawing.Point(427, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bağlantı Kurulacak Kişinin IP Bilgileri";
            // 
            // tbx_portalici
            // 
            this.tbx_portalici.Location = new System.Drawing.Point(265, 50);
            this.tbx_portalici.Name = "tbx_portalici";
            this.tbx_portalici.Size = new System.Drawing.Size(35, 20);
            this.tbx_portalici.TabIndex = 3;
            this.tbx_portalici.Text = "88";
            // 
            // tbx_ipalici
            // 
            this.tbx_ipalici.Location = new System.Drawing.Point(25, 50);
            this.tbx_ipalici.Name = "tbx_ipalici";
            this.tbx_ipalici.Size = new System.Drawing.Size(197, 20);
            this.tbx_ipalici.TabIndex = 2;
            // 
            // btn_baglan
            // 
            this.btn_baglan.Location = new System.Drawing.Point(346, 61);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(75, 23);
            this.btn_baglan.TabIndex = 2;
            this.btn_baglan.Text = "Baglan";
            this.btn_baglan.UseVisualStyleBackColor = true;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // listBox_massage
            // 
            this.listBox_massage.FormattingEnabled = true;
            this.listBox_massage.Location = new System.Drawing.Point(30, 165);
            this.listBox_massage.Name = "listBox_massage";
            this.listBox_massage.Size = new System.Drawing.Size(312, 160);
            this.listBox_massage.TabIndex = 3;
            // 
            // textBox_textmassage
            // 
            this.textBox_textmassage.Location = new System.Drawing.Point(427, 165);
            this.textBox_textmassage.Multiline = true;
            this.textBox_textmassage.Name = "textBox_textmassage";
            this.textBox_textmassage.Size = new System.Drawing.Size(344, 51);
            this.textBox_textmassage.TabIndex = 4;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(681, 232);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(75, 23);
            this.btn_gonder.TabIndex = 5;
            this.btn_gonder.Text = "Gonder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mesajlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mesajınızı Buraya Yazınız.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "IP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(675, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "Burak Açma 2014010206068";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 355);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.textBox_textmassage);
            this.Controls.Add(this.listBox_massage);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chat Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_portgonderen;
        private System.Windows.Forms.TextBox txb_ipgonderen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_portalici;
        private System.Windows.Forms.TextBox tbx_ipalici;
        private System.Windows.Forms.Button btn_baglan;
        private System.Windows.Forms.ListBox listBox_massage;
        private System.Windows.Forms.TextBox textBox_textmassage;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

