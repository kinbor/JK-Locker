using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JK_Locker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
            //Ctrl+A
            this.txtDPlainText.KeyDown += new KeyEventHandler(this.TextBox_KeyDown);
            //DoubleClick
            this.txtDPlainText.DoubleClick += new EventHandler(this.TextBox_DoubleClick);
        }
        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnEPlainFilePath_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Text File|*.txt|All File|*.*";
            this.openFileDialog1.ShowDialog();
            this.txtEPlainFilePath.Text = this.openFileDialog1.FileName;
            if (this.txtEPlainFilePath.Text.IsNotNullEmptyWhiteSpace())
            {
                this.txtECipherFilePath.Text = Path.Combine(Path.GetDirectoryName(this.txtEPlainFilePath.Text), Path.GetFileNameWithoutExtension(this.txtEPlainFilePath.Text) + ".jkf");
            }
        }
        private void btnECipherFilePath_Click(object sender, EventArgs e)
        {
            var dResult = this.saveFileDialog1.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                this.txtECipherFilePath.Text = this.saveFileDialog1.FileName;
            }
        }
        private void btnEExecute_Click(object sender, EventArgs e)
        {
            if (this.txtEPlainFilePath.Text.IsNullOrEmptyOrWhiteSpace())
            {
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "请选择您要加密的文件";
            }
            else if (this.txtECipherFilePath.Text.IsNullOrEmptyOrWhiteSpace())
            {
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "请选择文件加密后存储的位置";
            }
            else if (this.txtEPasswordText.Text.Trim().IsNullOrEmptyOrWhiteSpace())
            {
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "请设置文件的加密密码";
            }
            else if (!this.txtEPasswordText.Text.Trim().IsPasswordForcePlus8_32())
            {
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "加密密码长度范围（8-32），格式必须为（四选三）：大写字母，小写字母，数字，特殊符号";
            }
            else
            {
                var aesKey = AESHelper.CreateAESKey(this.txtEPasswordText.Text.Trim());
                var fileText = File.ReadAllText(this.txtEPlainFilePath.Text);
                if (fileText.IsNotNullEmptyWhiteSpace())
                {
                    this.lblMessage.ForeColor = Color.Blue;
                    this.lblMessage.Text = "正在加密...";

                    var execResult = AESHelper.AesEncrypt(aesKey, fileText);
                    if (execResult.Key)
                    {
                        try
                        {
                            if (File.Exists(this.txtECipherFilePath.Text))
                            {
                                File.Delete(this.txtECipherFilePath.Text);
                            }
                            using (var stream = new FileStream(this.txtECipherFilePath.Text, FileMode.Create))
                            {
                                var writer = new StreamWriter(stream);
                                writer.Write(execResult.Value);
                                writer.Flush();
                                writer.Close();
                                writer.Dispose();
                            }
                            this.lblMessage.ForeColor = Color.Green;
                            this.lblMessage.Text = "加密成功";
                        }
                        catch
                        {
                            this.lblMessage.ForeColor = Color.Red;
                            this.lblMessage.Text = "加密成功，保存失败";
                        }
                    }
                    else
                    {
                        this.lblMessage.ForeColor = Color.Red;
                        this.lblMessage.Text = "加密失败";
                    }
                }
                else
                {
                    this.lblMessage.ForeColor = Color.Red;
                    this.lblMessage.Text = "需要被加密的文件里没有信息";
                }
            }
        }

        private void btnDCipherFilePath_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "JK LockFile|*.jkf|All File|*.*";
            this.openFileDialog1.ShowDialog();
            this.txtDCipherFilePath.Text = this.openFileDialog1.FileName;
        }
        private void btnDExecute_Click(object sender, EventArgs e)
        {
            if (this.txtDCipherFilePath.Text.IsNullOrEmptyOrWhiteSpace())
            {
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "请选择您要解密的文件";
            }
            else if (this.txtDPasswordText.Text.Trim().IsNullOrEmptyOrWhiteSpace())
            {
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "请设置文件的解密密码";
            }
            else if (!this.txtDPasswordText.Text.Trim().IsPasswordForcePlus8_32())
            {
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "解密密码长度范围（8-32），格式必须为（四选三）：大写字母，小写字母，数字，特殊符号";
            }
            else
            {
                var aesKey = AESHelper.CreateAESKey(this.txtDPasswordText.Text.Trim());
                var fileText = File.ReadAllText(this.txtDCipherFilePath.Text);
                if (fileText.IsNotNullEmptyWhiteSpace())
                {
                    this.lblMessage.ForeColor = Color.Blue;
                    this.lblMessage.Text = "正在解密...";

                    var execResult = AESHelper.AesDecrypt(aesKey, fileText);
                    if (execResult.Key)
                    {
                        this.txtDPlainText.Text = execResult.Value;
                        this.lblMessage.ForeColor = Color.Green;
                        this.lblMessage.Text = "解密成功";
                    }
                    else
                    {
                        this.lblMessage.ForeColor = Color.Red;
                        this.lblMessage.Text = "解密失败";
                    }
                }
                else
                {
                    this.lblMessage.ForeColor = Color.Red;
                    this.lblMessage.Text = "需要被解密的文件里没有信息";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtDPlainText.Text = "";
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.txtDCipherFilePath.Text = "";
            this.txtDPasswordText.Text = "";
            this.txtDPlainText.Text = "";
            this.txtECipherFilePath.Text = "";
            this.txtEPasswordText.Text = "";
            this.txtEPlainFilePath.Text = "";
        }
    }
}
