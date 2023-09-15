
namespace QL_tour
{
    partial class frmdangkytaikhoan
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
            this.txtMATKHAUDK = new System.Windows.Forms.TextBox();
            this.rtxtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLOAITK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.txtXACNHANMK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMATKHAUDK
            // 
            this.txtMATKHAUDK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATKHAUDK.Location = new System.Drawing.Point(129, 155);
            this.txtMATKHAUDK.Name = "txtMATKHAUDK";
            this.txtMATKHAUDK.Size = new System.Drawing.Size(232, 22);
            this.txtMATKHAUDK.TabIndex = 12;
            this.txtMATKHAUDK.UseSystemPasswordChar = true;
            this.txtMATKHAUDK.TextChanged += new System.EventHandler(this.rtxtMATKHAU_TextChanged);
            // 
            // rtxtTAIKHOAN
            // 
            this.rtxtTAIKHOAN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTAIKHOAN.Location = new System.Drawing.Point(129, 117);
            this.rtxtTAIKHOAN.Name = "rtxtTAIKHOAN";
            this.rtxtTAIKHOAN.Size = new System.Drawing.Size(232, 22);
            this.rtxtTAIKHOAN.TabIndex = 11;
            this.rtxtTAIKHOAN.TextChanged += new System.EventHandler(this.rtxtTAIKHOAN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Loại TK: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbbLOAITK
            // 
            this.cbbLOAITK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbLOAITK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLOAITK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLOAITK.FormattingEnabled = true;
            this.cbbLOAITK.Items.AddRange(new object[] {
            "Quản trị viên ",
            "Nhân Viên ",
            "Khách Hàng "});
            this.cbbLOAITK.Location = new System.Drawing.Point(129, 77);
            this.cbbLOAITK.Name = "cbbLOAITK";
            this.cbbLOAITK.Size = new System.Drawing.Size(232, 24);
            this.cbbLOAITK.TabIndex = 9;
            this.cbbLOAITK.SelectedIndexChanged += new System.EventHandler(this.cbbLOAITK_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật khẩu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tài Khoản: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ĐĂNG KÝ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTHOAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(253, 242);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(85, 37);
            this.btnTHOAT.TabIndex = 17;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLUU.Location = new System.Drawing.Point(142, 242);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(89, 37);
            this.btnLUU.TabIndex = 16;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // txtXACNHANMK
            // 
            this.txtXACNHANMK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXACNHANMK.Location = new System.Drawing.Point(129, 193);
            this.txtXACNHANMK.MaxLength = 30;
            this.txtXACNHANMK.Name = "txtXACNHANMK";
            this.txtXACNHANMK.Size = new System.Drawing.Size(232, 22);
            this.txtXACNHANMK.TabIndex = 23;
            this.txtXACNHANMK.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Xác nhận mật khẩu:";
            // 
            // frmdangkytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 321);
            this.Controls.Add(this.txtXACNHANMK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.txtMATKHAUDK);
            this.Controls.Add(this.rtxtTAIKHOAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbLOAITK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdangkytaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdangkytaikhoan_FormClosing);
            this.Load += new System.EventHandler(this.frmdangkytaikhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMATKHAUDK;
        private System.Windows.Forms.TextBox rtxtTAIKHOAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLOAITK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.TextBox txtXACNHANMK;
        private System.Windows.Forms.Label label6;
    }
}