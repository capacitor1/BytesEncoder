using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BytesEncoder
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        // 使用System.IO.Compression进行Deflate压缩
        public static byte[] MicrosoftCompress(byte[] data)
        {
            MemoryStream uncompressed = new MemoryStream(data); // 这里举例用的是内存中的数据；需要对文本进行压缩的话，使用 FileStream 即可
            MemoryStream compressed = new MemoryStream();
            DeflateStream deflateStream = new DeflateStream(compressed, CompressionMode.Compress); // 注意：这里第一个参数填写的是压缩后的数据应该被输出到的地方
            uncompressed.CopyTo(deflateStream); // 用 CopyTo 将需要压缩的数据一次性输入；也可以使用Write进行部分输入
            deflateStream.Close();  // 在Close中，会先后执行 Finish 和 Flush 操作。
            byte[] result = compressed.ToArray();
            return result;
        }
        // 使用System.IO.Compression进行Deflate解压
        public static byte[] MicrosoftDecompress(byte[] data)
        {
            MemoryStream compressed = new MemoryStream(data);
            MemoryStream decompressed = new MemoryStream();
            DeflateStream deflateStream = new DeflateStream(compressed, CompressionMode.Decompress); // 注意： 这里第一个参数同样是填写压缩的数据，但是这次是作为输入的数据
            deflateStream.CopyTo(decompressed);
            byte[] result = decompressed.ToArray();
            return result;
        }
        public string[] dict = { "00", "01", "10", "11" };
        /// <summary>
        /// 字符串转二进制
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string StringToBinary(string str)
        {
            byte[] data = Encoding.Unicode.GetBytes(str);
            StringBuilder sb = new StringBuilder(data.Length * 8);
            foreach (byte item in data)
            {
                sb.Append(Convert.ToString(item, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        private string StringToBinarywithComp(string str)
        {
            byte[] data = Encoding.Unicode.GetBytes(str);
            byte[] datac = MicrosoftCompress(data);
            StringBuilder sb = new StringBuilder(datac.Length * 8);
            foreach (byte item in datac)
            {
                sb.Append(Convert.ToString(item, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 二进制转字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string BinaryToString(string str)
        {
            System.Text.RegularExpressions.CaptureCollection cs = System.Text.RegularExpressions.Regex.Match(str, @"([01]{8})+").Groups[1].Captures;
            byte[] data = new byte[cs.Count];
            for (int i = 0; i < cs.Count; i++)
            {
                data[i] = Convert.ToByte(cs[i].Value, 2);
            }
            return Encoding.Unicode.GetString(data, 0, data.Length);
        }
        private string BinaryToStringwithComp(string str)
        {
            System.Text.RegularExpressions.CaptureCollection cs = System.Text.RegularExpressions.Regex.Match(str, @"([01]{8})+").Groups[1].Captures;
            byte[] data = new byte[cs.Count];
            for (int i = 0; i < cs.Count; i++)
            {
                data[i] = Convert.ToByte(cs[i].Value, 2);
            }
            byte[] datadec = MicrosoftDecompress(data);
            return Encoding.Unicode.GetString(datadec, 0, datadec.Length);
        }

        /// <summary>
        /// 兽语转二进制
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string aniTobinary(string str)
        {
            string result = "";
            string language = EncC.Text;
            string tmp = "";

            for (int i = 0; i < str.Length; i++)
            {
                tmp = str[i].ToString();

                if (tmp.Equals(language[0].ToString()))
                {
                    result += dict[0];
                }
                else if (tmp.Equals(language[1].ToString()))
                {
                    result += dict[1];
                }
                else if (tmp.Equals(language[2].ToString()))
                {
                    result += dict[2];
                }
                else if (tmp.Equals(language[3].ToString()))
                {
                    result += dict[3];
                }
            }

            return result;
        }

        /// <summary>
        /// 二进制转兽语
        /// </summary>
        /// <param name="binary"></param>
        /// <returns></returns>
        private string binaryToAni(string binary)
        {
            string r = "";
            string language = EncC.Text;
            string tmp = "";

            for (int i = 0; i < binary.Length; i += 2)
            {
                tmp = binary.Substring(i, 2);
                if (tmp.Equals(dict[0]))
                {
                    r += language[0].ToString();
                }
                else if (tmp.Equals(dict[1]))
                {
                    r += language[1].ToString();
                }
                else if (tmp.Equals(dict[2]))
                {
                    r += language[2].ToString();
                }
                else if (tmp.Equals(dict[3]))
                {
                    r += language[3].ToString();
                }
            }

            return r;
        }
        public string HComp(string intext)
        {
            string opt = "";
            if(HCT.Checked)
            {
                opt = intext.Replace("magnet:?xt=urn:btih:", "$:M").Replace("114514", "$:1").Replace("来点涩涩","$:L").Replace("https://www.pixiv.net/artworks/","$:P");
            }
            else
            {
                opt = intext;
            }
            return opt;
        }
        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Clear();
                string result = "";
                string binary = "";

                if (Mode.Checked)
                {
                    if (Input.Text != null)
                    {
                        if(EncC.Text.Contains("?")|| EncC.Text.Contains("&")|| EncC.Text.Contains("/"))
                        {
                            throw new Exception(@"编码字符不得包含下列字符：? & /" + "\r\nErrCode: -2");
                        }
                        if (Standard.Checked)
                        {
                            binary = StringToBinary(HComp(Input.Text));
                            result = "roar://Raw?text=" + binaryToAni(binary) + "&encc=" + EncC.Text;
                        }
                        else
                        {
                            binary = StringToBinarywithComp(HComp(Input.Text));
                            result = "roar://Deflate?text=" + binaryToAni(binary) + "&encc=" + EncC.Text;
                        }

                    }
                    else
                    {
                        throw new Exception("输入内容不得为空\r\nErrCode: -1");
                    }
                }
                else
                {
                    if (Input.Text != null)
                    {
                        //处理文本
                        if(Input.Text.Contains("roar://") && Input.Text.Contains("&encc="))
                        {
                            string key = Input.Text.ToString().Substring(Input.Text.ToString().LastIndexOf(@"=") + 1);
                            if(key.Length != 4)
                            {
                                throw new Exception("密文错误：编码字符不正确\r\nErrCode: 2");
                            }
                            EncC.Text = key;
                            string[] tl = Input.Text.ToString().Split('?');
                            string tp = tl[0].Substring(tl[0].LastIndexOf(@"/") + 1);
                            if(tp.Contains("Raw"))
                            {
                                string[] rt = Input.Text.ToString().Split('&');
                                string dt = rt[0].Replace("roar://Raw?text=","");
                                binary = aniTobinary(dt);
                                result = BinaryToString(binary);
                            }
                            else if(tp.Contains("Deflate"))
                            {
                                string[] rt = Input.Text.ToString().Split('&');
                                string dt = rt[0].Replace("roar://Deflate?text=", "");
                                binary = aniTobinary(dt);
                                result = BinaryToStringwithComp(binary);
                            }
                            else
                            {
                                throw new Exception("密文错误：不支持的或未知的格式\r\nErrCode: 3");
                            }
                        }
                        else
                        {
                            binary = aniTobinary(Input.Text);
                            result = BinaryToString(binary);
                        }
                        
                    }
                    else
                    {
                        throw new Exception("输入内容不得为空\r\nErrCode: -1");
                    }
                }
                Output.Text = result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HCT_CheckedChanged(object sender, EventArgs e)
        {
            if (HCT.Checked)
            {
                MessageBox.Show("警告：目前高级压缩只作为实验模式和压缩率对比，只提供“编码”功能，事后无法解码！");
            }
        }
    }
}
