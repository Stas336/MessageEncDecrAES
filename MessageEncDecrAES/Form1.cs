using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MessageEncDecrAES
{
    public partial class Form1 : Form
    {
        private static RijndaelManaged aes;
        private static int HASH_ITER = 10000;

        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(origText, "Enter here original text or encrypted text");
            toolTip.SetToolTip(modText, "Result will be displayed here");
            toolTip.SetToolTip(key, "Enter encryption/decryption key here");
            aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
        }

        private void encrButton_Click(object sender, EventArgs e)
        {
            if (key.Text.Length == 0 || origText.Text.Length == 0)
            {
                MessageBox.Show("Message or key is empty. Fill it before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Rfc2898DeriveBytes aesKey = new Rfc2898DeriveBytes(key.Text, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }, HASH_ITER);
            aes.Key = aesKey.GetBytes(32);
            aes.IV = aesKey.GetBytes(16);
            byte[] bytesBuff = Encoding.Unicode.GetBytes(origText.Text);
            using (MemoryStream mStream = new MemoryStream())
            {
                using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cStream.Write(bytesBuff, 0, bytesBuff.Length);
                    cStream.Close();
                }
                modText.Text = Convert.ToBase64String(mStream.ToArray());
            }
            aes.Clear();
        }

        private void decrButton_Click(object sender, EventArgs e)
        {
            if (key.Text.Length == 0 || origText.Text.Length == 0)
            {
                MessageBox.Show("Encrypted message or key is empty. Fill it before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Rfc2898DeriveBytes aesKey = new Rfc2898DeriveBytes(key.Text, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }, HASH_ITER);
            aes.Key = aesKey.GetBytes(32);
            aes.IV = aesKey.GetBytes(16);
            byte[] bytesBuff = Convert.FromBase64String(origText.Text);
            try
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    modText.Text = Encoding.Unicode.GetString(mStream.ToArray());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong decryption key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                aes.Clear();
            }
        }
    }
}
