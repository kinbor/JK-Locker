
namespace JK_Locker
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbEncrypt = new System.Windows.Forms.GroupBox();
            this.lblEPasswordMessage = new System.Windows.Forms.Label();
            this.txtEPasswordText = new System.Windows.Forms.TextBox();
            this.btnECipherFilePath = new System.Windows.Forms.Button();
            this.btnEPlainFilePath = new System.Windows.Forms.Button();
            this.txtECipherFilePath = new System.Windows.Forms.TextBox();
            this.txtEPlainFilePath = new System.Windows.Forms.TextBox();
            this.btnEExecute = new System.Windows.Forms.Button();
            this.lblEPasswordText = new System.Windows.Forms.Label();
            this.lblECipherFilePath = new System.Windows.Forms.Label();
            this.lblEPlainFilePath = new System.Windows.Forms.Label();
            this.gbDecrypt = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDPasswordText = new System.Windows.Forms.TextBox();
            this.txtDPlainText = new System.Windows.Forms.TextBox();
            this.btnDCipherFilePath = new System.Windows.Forms.Button();
            this.txtDCipherFilePath = new System.Windows.Forms.TextBox();
            this.lblDCipherFilePath = new System.Windows.Forms.Label();
            this.btnDExecute = new System.Windows.Forms.Button();
            this.lblDPasswordText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.gbEncrypt.SuspendLayout();
            this.gbDecrypt.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEncrypt
            // 
            this.gbEncrypt.Controls.Add(this.lblEPasswordMessage);
            this.gbEncrypt.Controls.Add(this.txtEPasswordText);
            this.gbEncrypt.Controls.Add(this.btnECipherFilePath);
            this.gbEncrypt.Controls.Add(this.btnEPlainFilePath);
            this.gbEncrypt.Controls.Add(this.txtECipherFilePath);
            this.gbEncrypt.Controls.Add(this.txtEPlainFilePath);
            this.gbEncrypt.Controls.Add(this.btnEExecute);
            this.gbEncrypt.Controls.Add(this.lblEPasswordText);
            this.gbEncrypt.Controls.Add(this.lblECipherFilePath);
            this.gbEncrypt.Controls.Add(this.lblEPlainFilePath);
            this.gbEncrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEncrypt.Location = new System.Drawing.Point(0, 0);
            this.gbEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.gbEncrypt.Name = "gbEncrypt";
            this.gbEncrypt.Padding = new System.Windows.Forms.Padding(4);
            this.gbEncrypt.Size = new System.Drawing.Size(1251, 160);
            this.gbEncrypt.TabIndex = 0;
            this.gbEncrypt.TabStop = false;
            this.gbEncrypt.Text = "文本加密";
            // 
            // lblEPasswordMessage
            // 
            this.lblEPasswordMessage.AutoSize = true;
            this.lblEPasswordMessage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEPasswordMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblEPasswordMessage.Location = new System.Drawing.Point(542, 116);
            this.lblEPasswordMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEPasswordMessage.Name = "lblEPasswordMessage";
            this.lblEPasswordMessage.Size = new System.Drawing.Size(404, 18);
            this.lblEPasswordMessage.TabIndex = 6;
            this.lblEPasswordMessage.Text = "提醒：务必牢记密码，否则无法解密被加密的文件";
            // 
            // txtEPasswordText
            // 
            this.txtEPasswordText.Location = new System.Drawing.Point(122, 111);
            this.txtEPasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.txtEPasswordText.Name = "txtEPasswordText";
            this.txtEPasswordText.PasswordChar = '*';
            this.txtEPasswordText.Size = new System.Drawing.Size(409, 28);
            this.txtEPasswordText.TabIndex = 3;
            // 
            // btnECipherFilePath
            // 
            this.btnECipherFilePath.Location = new System.Drawing.Point(1107, 69);
            this.btnECipherFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnECipherFilePath.Name = "btnECipherFilePath";
            this.btnECipherFilePath.Size = new System.Drawing.Size(126, 34);
            this.btnECipherFilePath.TabIndex = 2;
            this.btnECipherFilePath.Text = "选择";
            this.btnECipherFilePath.UseVisualStyleBackColor = true;
            this.btnECipherFilePath.Click += new System.EventHandler(this.btnECipherFilePath_Click);
            // 
            // btnEPlainFilePath
            // 
            this.btnEPlainFilePath.Location = new System.Drawing.Point(1107, 32);
            this.btnEPlainFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnEPlainFilePath.Name = "btnEPlainFilePath";
            this.btnEPlainFilePath.Size = new System.Drawing.Size(126, 34);
            this.btnEPlainFilePath.TabIndex = 1;
            this.btnEPlainFilePath.Text = "选择";
            this.btnEPlainFilePath.UseVisualStyleBackColor = true;
            this.btnEPlainFilePath.Click += new System.EventHandler(this.btnEPlainFilePath_Click);
            // 
            // txtECipherFilePath
            // 
            this.txtECipherFilePath.BackColor = System.Drawing.Color.White;
            this.txtECipherFilePath.Location = new System.Drawing.Point(122, 72);
            this.txtECipherFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtECipherFilePath.Name = "txtECipherFilePath";
            this.txtECipherFilePath.ReadOnly = true;
            this.txtECipherFilePath.Size = new System.Drawing.Size(974, 28);
            this.txtECipherFilePath.TabIndex = 5;
            // 
            // txtEPlainFilePath
            // 
            this.txtEPlainFilePath.BackColor = System.Drawing.Color.White;
            this.txtEPlainFilePath.Location = new System.Drawing.Point(122, 34);
            this.txtEPlainFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtEPlainFilePath.Name = "txtEPlainFilePath";
            this.txtEPlainFilePath.ReadOnly = true;
            this.txtEPlainFilePath.Size = new System.Drawing.Size(974, 28);
            this.txtEPlainFilePath.TabIndex = 4;
            // 
            // btnEExecute
            // 
            this.btnEExecute.Location = new System.Drawing.Point(1107, 108);
            this.btnEExecute.Margin = new System.Windows.Forms.Padding(4);
            this.btnEExecute.Name = "btnEExecute";
            this.btnEExecute.Size = new System.Drawing.Size(126, 34);
            this.btnEExecute.TabIndex = 4;
            this.btnEExecute.Text = "执行";
            this.btnEExecute.UseVisualStyleBackColor = true;
            this.btnEExecute.Click += new System.EventHandler(this.btnEExecute_Click);
            // 
            // lblEPasswordText
            // 
            this.lblEPasswordText.AutoSize = true;
            this.lblEPasswordText.Location = new System.Drawing.Point(15, 116);
            this.lblEPasswordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEPasswordText.Name = "lblEPasswordText";
            this.lblEPasswordText.Size = new System.Drawing.Size(98, 18);
            this.lblEPasswordText.TabIndex = 2;
            this.lblEPasswordText.Text = "加密密码：";
            // 
            // lblECipherFilePath
            // 
            this.lblECipherFilePath.AutoSize = true;
            this.lblECipherFilePath.Location = new System.Drawing.Point(15, 76);
            this.lblECipherFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblECipherFilePath.Name = "lblECipherFilePath";
            this.lblECipherFilePath.Size = new System.Drawing.Size(98, 18);
            this.lblECipherFilePath.TabIndex = 1;
            this.lblECipherFilePath.Text = "密文路径：";
            // 
            // lblEPlainFilePath
            // 
            this.lblEPlainFilePath.AutoSize = true;
            this.lblEPlainFilePath.Location = new System.Drawing.Point(15, 39);
            this.lblEPlainFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEPlainFilePath.Name = "lblEPlainFilePath";
            this.lblEPlainFilePath.Size = new System.Drawing.Size(98, 18);
            this.lblEPlainFilePath.TabIndex = 0;
            this.lblEPlainFilePath.Text = "原文路径：";
            // 
            // gbDecrypt
            // 
            this.gbDecrypt.Controls.Add(this.btnClearAll);
            this.gbDecrypt.Controls.Add(this.btnClear);
            this.gbDecrypt.Controls.Add(this.rtbRemark);
            this.gbDecrypt.Controls.Add(this.label1);
            this.gbDecrypt.Controls.Add(this.txtDPasswordText);
            this.gbDecrypt.Controls.Add(this.txtDPlainText);
            this.gbDecrypt.Controls.Add(this.btnDCipherFilePath);
            this.gbDecrypt.Controls.Add(this.txtDCipherFilePath);
            this.gbDecrypt.Controls.Add(this.lblDCipherFilePath);
            this.gbDecrypt.Controls.Add(this.btnDExecute);
            this.gbDecrypt.Controls.Add(this.lblDPasswordText);
            this.gbDecrypt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDecrypt.Location = new System.Drawing.Point(0, 209);
            this.gbDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.gbDecrypt.Name = "gbDecrypt";
            this.gbDecrypt.Padding = new System.Windows.Forms.Padding(4);
            this.gbDecrypt.Size = new System.Drawing.Size(1251, 633);
            this.gbDecrypt.TabIndex = 1;
            this.gbDecrypt.TabStop = false;
            this.gbDecrypt.Text = "文本解密";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(1107, 489);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(126, 34);
            this.btnClearAll.TabIndex = 17;
            this.btnClearAll.Text = "清空(All)";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(972, 489);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtbRemark
            // 
            this.rtbRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRemark.ForeColor = System.Drawing.Color.Black;
            this.rtbRemark.Location = new System.Drawing.Point(18, 483);
            this.rtbRemark.Margin = new System.Windows.Forms.Padding(4);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.ReadOnly = true;
            this.rtbRemark.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbRemark.Size = new System.Drawing.Size(1026, 150);
            this.rtbRemark.TabIndex = 15;
            this.rtbRemark.Text = resources.GetString("rtbRemark.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(542, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "提醒：解密密码 = 加密密码";
            // 
            // txtDPasswordText
            // 
            this.txtDPasswordText.Location = new System.Drawing.Point(122, 69);
            this.txtDPasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPasswordText.Name = "txtDPasswordText";
            this.txtDPasswordText.PasswordChar = '*';
            this.txtDPasswordText.Size = new System.Drawing.Size(409, 28);
            this.txtDPasswordText.TabIndex = 6;
            // 
            // txtDPlainText
            // 
            this.txtDPlainText.BackColor = System.Drawing.Color.White;
            this.txtDPlainText.Location = new System.Drawing.Point(18, 110);
            this.txtDPlainText.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPlainText.Multiline = true;
            this.txtDPlainText.Name = "txtDPlainText";
            this.txtDPlainText.ReadOnly = true;
            this.txtDPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDPlainText.Size = new System.Drawing.Size(1213, 368);
            this.txtDPlainText.TabIndex = 8;
            // 
            // btnDCipherFilePath
            // 
            this.btnDCipherFilePath.Location = new System.Drawing.Point(1107, 27);
            this.btnDCipherFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnDCipherFilePath.Name = "btnDCipherFilePath";
            this.btnDCipherFilePath.Size = new System.Drawing.Size(126, 34);
            this.btnDCipherFilePath.TabIndex = 5;
            this.btnDCipherFilePath.Text = "选择";
            this.btnDCipherFilePath.UseVisualStyleBackColor = true;
            this.btnDCipherFilePath.Click += new System.EventHandler(this.btnDCipherFilePath_Click);
            // 
            // txtDCipherFilePath
            // 
            this.txtDCipherFilePath.BackColor = System.Drawing.Color.White;
            this.txtDCipherFilePath.Location = new System.Drawing.Point(122, 30);
            this.txtDCipherFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtDCipherFilePath.Name = "txtDCipherFilePath";
            this.txtDCipherFilePath.ReadOnly = true;
            this.txtDCipherFilePath.Size = new System.Drawing.Size(974, 28);
            this.txtDCipherFilePath.TabIndex = 12;
            // 
            // lblDCipherFilePath
            // 
            this.lblDCipherFilePath.AutoSize = true;
            this.lblDCipherFilePath.Location = new System.Drawing.Point(15, 34);
            this.lblDCipherFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDCipherFilePath.Name = "lblDCipherFilePath";
            this.lblDCipherFilePath.Size = new System.Drawing.Size(98, 18);
            this.lblDCipherFilePath.TabIndex = 9;
            this.lblDCipherFilePath.Text = "密文路径：";
            // 
            // btnDExecute
            // 
            this.btnDExecute.Location = new System.Drawing.Point(1107, 66);
            this.btnDExecute.Margin = new System.Windows.Forms.Padding(4);
            this.btnDExecute.Name = "btnDExecute";
            this.btnDExecute.Size = new System.Drawing.Size(126, 34);
            this.btnDExecute.TabIndex = 7;
            this.btnDExecute.Text = "执行";
            this.btnDExecute.UseVisualStyleBackColor = true;
            this.btnDExecute.Click += new System.EventHandler(this.btnDExecute_Click);
            // 
            // lblDPasswordText
            // 
            this.lblDPasswordText.AutoSize = true;
            this.lblDPasswordText.Location = new System.Drawing.Point(15, 74);
            this.lblDPasswordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPasswordText.Name = "lblDPasswordText";
            this.lblDPasswordText.Size = new System.Drawing.Size(98, 18);
            this.lblDPasswordText.TabIndex = 10;
            this.lblDPasswordText.Text = "解密密码：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Open";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jkf";
            this.saveFileDialog1.Filter = "JK LockFile|*.jkf|All File|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.lblMessage);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 160);
            this.pnlMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1251, 49);
            this.pnlMiddle.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1251, 49);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 842);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.gbDecrypt);
            this.Controls.Add(this.gbEncrypt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JK-Locker";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbEncrypt.ResumeLayout(false);
            this.gbEncrypt.PerformLayout();
            this.gbDecrypt.ResumeLayout(false);
            this.gbDecrypt.PerformLayout();
            this.pnlMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncrypt;
        private System.Windows.Forms.GroupBox gbDecrypt;
        private System.Windows.Forms.TextBox txtDPlainText;
        private System.Windows.Forms.Label lblECipherFilePath;
        private System.Windows.Forms.Label lblEPlainFilePath;
        private System.Windows.Forms.Label lblEPasswordText;
        private System.Windows.Forms.Button btnEExecute;
        private System.Windows.Forms.TextBox txtEPlainFilePath;
        private System.Windows.Forms.TextBox txtECipherFilePath;
        private System.Windows.Forms.Button btnECipherFilePath;
        private System.Windows.Forms.Button btnEPlainFilePath;
        private System.Windows.Forms.TextBox txtEPasswordText;
        private System.Windows.Forms.TextBox txtDPasswordText;
        private System.Windows.Forms.Button btnDCipherFilePath;
        private System.Windows.Forms.TextBox txtDCipherFilePath;
        private System.Windows.Forms.Label lblDCipherFilePath;
        private System.Windows.Forms.Button btnDExecute;
        private System.Windows.Forms.Label lblDPasswordText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblEPasswordMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
    }
}

