using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Web.UI.WebControls;
//using RestSharp.Validation;



namespace WindowsFormsApp4
{
    
    public partial class Form1 : Form
    {
        int Status;

        public Form1()
        {
            InitializeComponent();
            
        }
              
        private void Pair()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/pair?tid=" + textBox_Tid.Text + "&pairingCode=" + textBox_Paring_code.Text, Method.GET);
            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            int found = 0;
            found =  textBox1.Text.IndexOf("authToken") + 12;
            if (found > 12)
            {
                textBox_Auth_token.Text = textBox1.Text.Substring(found, 16);
            }
                
        }

        private void Auth_post()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/transaction?tid=" + textBox_Tid.Text + "&disablePrinting=" + comboBox_Disable_printing.Text, Method.POST);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text);

            string amount = textBox_Amount.Text;
            string transType = comboBox_TransType.Text;
                       
            var body = new
            {
                transType = transType,
                amountTrans = amount,
                amountGratuity = 0,
                amountCashback = 0,
                reference = "TEST CARD"
            };
            
            request.AddJsonBody(body);
            
            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            int found = 0;
            found = textBox1.Text.IndexOf("uti") + 6;
            if (found > 6)
            {
                textBox_Uti.Text = textBox1.Text.Substring(found, 36);
            }


            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');
                       
            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }

            if (checkBox_Auto_increase.Checked == true)
            {
                textBox_Amount.Text = "" + (Int32.Parse(textBox_Amount.Text) + 100);
            }

        }
                

        private void GetRequest()
        {
            int int_cardholder_start = 0;
            int int_cardholder_end = 0;
            int int_merchant_start = 0;
            int int_merchant_end = 0;
            String String_total;
            string String_cardholder = "";
            string String_merchant = "";

            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/transaction?tid=" + textBox_Tid.Text + "&uti=" + textBox_Uti.Text, Method.GET);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text + "");
            
            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            //Console.WriteLine(MyString.Remove(5,10));
                        
            String_total = textBox1.Text;

            listBox1.Items.Clear();

            string string_start = "cardholderReceipt";
            string string_end = "]]";
            int_cardholder_start = String_total.IndexOf(string_start);
            int_cardholder_end = String_total.IndexOf(string_end);
            if (int_cardholder_start > 0 && int_cardholder_end > 0)
            {
                String_cardholder = String_total.Substring(int_cardholder_start - 1, int_cardholder_end + string_end.Length - int_cardholder_start + 2);
                String_total = String_total.Remove(int_cardholder_start - 1, int_cardholder_end + string_end.Length - int_cardholder_start + 2);
            }

            string_start = "merchantReceipt";
            string_end = "]]";
            int_merchant_start = String_total.IndexOf(string_start);
            int_merchant_end = String_total.IndexOf(string_end);
            if (int_merchant_start > 0 && int_merchant_end > 0)
            {
                String_merchant = String_total.Substring(int_merchant_start - 1, int_merchant_end + string_end.Length - int_merchant_start + 2);
                String_total = String_total.Remove(int_merchant_start - 1, int_merchant_end + string_end.Length - int_merchant_start + 2);
            }

            string[] array = String_total.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }

            listBox1.Items.Add("");
            if(String_cardholder.Length > 0)
            {
                array = String_cardholder.Split(new string[] { ",[", "[[" }, StringSplitOptions.None);

                foreach (string value in array)
                {
                    listBox1.Items.Add("[" + value);
                }
                listBox1.Items.Add("");
            }
            
            
            if(String_merchant.Length > 0)
            {
                array = String_merchant.Split(new string[] { ",[", "[[" }, StringSplitOptions.None);

                foreach (string value in array)
                {
                    listBox1.Items.Add("[" + value);
                }
            }
            


        }

        private void Reversal()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/transaction?tid=" + textBox_Tid.Text + "&disablePrinting=" + comboBox_Disable_printing.Text, Method.POST);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text + "");

            string uti = textBox_Uti.Text;
                        
            var body = new
            {
                uti = uti,
                transType = "REVERSAL"
            };

            request.AddJsonBody(body);

            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            int found = 0;
            found = textBox1.Text.IndexOf("uti") + 6;
            if (found > 6)
            {
                textBox_Uti.Text = textBox1.Text.Substring(found, 36);
            }


            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }

        }

        private void PostResponse()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/result?tid=" + textBox_Tid.Text + "&uti=" + textBox_Uti.Text, Method.POST);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text + "");

            string uti = textBox_Uti.Text;

            var body = new
            {
                result = comboBox_Post_approval.Text
            };

            request.AddJsonBody(body);

            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            int found = 0;
            found = textBox1.Text.IndexOf("uti") + 6;
            if (found > 6)
            {
                textBox_Uti.Text = textBox1.Text.Substring(found, 36);
            }


            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }

        }

        private void DelRequest()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/transaction?tid=" + textBox_Tid.Text, Method.DELETE);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text + "");

            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }
        }

        private void StatusRequest()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/status?tid=" + textBox_Tid.Text, Method.GET);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text + "");

            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }
        }

        private void XReport()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/report?tid=" + textBox_Tid.Text + "&disablePrinting=" + comboBox_Disable_printing.Text + "& reportType=XReport", Method.GET);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text + "");

            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }
        }

        private void ZReport()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/report?tid=" + textBox_Tid.Text + "&disablePrinting=" + comboBox_Disable_printing.Text + "&reportType=ZReport", Method.GET);
            //request.Timeout = 1000;
            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text + "");

            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }
        }

        private void History()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/rest/historyReports?tid=" + textBox_Tid.Text + "&disablePrinting=" + comboBox_Disable_printing.Text, Method.GET);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text + "");

            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }
        }

        private void Display_post()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/display?tid=" + textBox_Tid.Text, Method.POST);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text);

            string json = "[{\"text\": \"Tomato\", \"amount\": 279},{\"text\": \"Milk\", \"amount\": 243},{\"text\": \"Avokado - 450gr\", \"amount\": 478},{\"text\": \"Coca Cola       6 pack\", \"amount\": 412}, {\"text\": \"Snickers\", \"amount\": 305}]";
            request.AddParameter("application/json", json, ParameterType.RequestBody);
                        
            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            int found = 0;
            found = textBox1.Text.IndexOf("uti") + 6;
            if (found > 6)
            {
                textBox_Uti.Text = textBox1.Text.Substring(found, 36);
            }


            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }

            if (checkBox_Auto_increase.Checked == true)
            {
                textBox_Amount.Text = "" + (Int32.Parse(textBox_Amount.Text) + 100);
            }

        }

        private void Print_post()
        {
            var client = new RestClient("https://" + textBox_IP_address.Text);
            client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            var request = new RestRequest("/locallink/1.0.0/print?tid=" + textBox_Tid.Text, Method.POST);

            request.AddHeader("Authorization", "Bearer " + textBox_Auth_token.Text);

            string json = "{\"data\": [[LOGO],[\"This is test 1 - 1,L,N\",\"1\",\"L\",\"N\"],[\"This is test 2 - 5,L,N\",\"5\",\"L\",\"N\"],[\"This is test 3 - 9,L,N\",\"9\",\"L\",\"N\"],[\"This is test 4 - 1,L,B\",\"1\",\"L\",\"B\"],[\"This is test 5 - 5,L,B\",\"5\",\"L\",\"B\"],[\"This is test 6 - 9,L,B\",\"9\",\"L\",\"B\"],[\"This is test 7 - 1,L,I\",\"1\",\"L\",\"I\"],[\"This is test 8 - 5,L,I\",\"5\",\"L\",\"I\"],[\"This is test 9 - 9,L,I\",\"9\",\"L\",\"I\"],[],[\"This is test 11 - 1,C,N\",\"1\",\"C\",\"N\"],[\"This is test 12 - 5,C,N\",\"5\",\"C\",\"N\"],[\"This is test 13 - 9,C,N\",\"9\",\"C\",\"N\"],[\"This is test 14 - 1,C,B\",\"1\",\"C\",\"B\"],[\"This is test 15 - 5,C,B\",\"5\",\"C\",\"B\"],[\"This is test 16 - 9,C,B\",\"9\",\"C\",\"B\"],[\"This is test 17 - 1,C,I\",\"1\",\"C\",\"I\"],[\"This is test 18 - 5,C,I\",\"5\",\"C\",\"I\"],[\"This is test 19 - 9,C,I\",\"9\",\"C\",\"I\"],[\"This is test 21 - 1,R,N\",\"1\",\"R\",\"N\"],[\"This is test 22 - 5,R,N\",\"5\",\"R\",\"N\"],[\"This is test 23 - 9,R,N\",\"9\",\"R\",\"N\"],[\"This is test 24 - 1,R,B\",\"1\",\"R\",\"B\"],[\"This is test 25 - 5,R,B\",\"5\",\"R\",\"B\"],[\"This is test 26 - 9,R,B\",\"9\",\"R\",\"B\"],[\"This is test 27 - 1,R,I\",\"1\",\"R\",\"I\"],[\"This is test 28 - 5,R,I\",\"5\",\"R\",\"I\"],[\"This is test 29 - 9,R,I\",\"9\",\"R\",\"I\"],[\"This is\",\"Split 1\",\"1\",\"S\",\"N\"],[\"This is\",\"Split 2\",\"4\",\"S\",\"N\"],[\"This is\",\"Split 3\",\"9\",\"S\",\"N\"],[\"This is\",\"Split 4\",\"1\",\"S\",\"B\"],[\"This is\",\"Split 5\",\"4\",\"S\",\"B\"],[\"This is\",\"Split 6\",\"9\",\"S\",\"B\"],[]]}";
            request.AddParameter("application/json", json, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            textBox1.Text = response.Content;

            int found = 0;
            found = textBox1.Text.IndexOf("uti") + 6;
            if (found > 6)
            {
                textBox_Uti.Text = textBox1.Text.Substring(found, 36);
            }


            listBox1.Items.Clear();
            string[] array = textBox1.Text.Split(',');

            foreach (string value in array)
            {
                listBox1.Items.Add(value);
            }

            if (checkBox_Auto_increase.Checked == true)
            {
                textBox_Amount.Text = "" + (Int32.Parse(textBox_Amount.Text) + 100);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Open_Settings_file();
            Status = 1;
        }

        private void Save_Settings_file()
        {
            DateTime now = DateTime.UtcNow;
            String NOW_string = "Settings.txt";

            FileStream fslog;
            StreamWriter tblog;

            //Opnum log skrá
            try
            {
                fslog = new FileStream(NOW_string, FileMode.Create);
                tblog = new StreamWriter(fslog, Encoding.GetEncoding("ISO-8859-15"));

                tblog.WriteLine(textBox_IP_address.Text);
                tblog.WriteLine(textBox_Paring_code.Text);
                tblog.WriteLine(textBox_Tid.Text);
                tblog.WriteLine(textBox_Auth_token.Text);
                tblog.WriteLine(textBox_Uti.Text);

                tblog.Close();

            }
            catch (IOException ee)
            {

            }
        }

        private void Open_Settings_file()
        {
            DateTime now = DateTime.UtcNow;
            String NOW_string = "Settings.txt";

            FileStream fslog;
            StreamReader tblog;

            //Opnum log skrá
            try
            {
                fslog = new FileStream(NOW_string, FileMode.Open);
                tblog = new StreamReader(fslog, Encoding.GetEncoding("ISO-8859-15"));

                textBox_IP_address.Text = tblog.ReadLine();
                textBox_Paring_code.Text = tblog.ReadLine();
                textBox_Tid.Text = tblog.ReadLine();
                textBox_Auth_token.Text = tblog.ReadLine();
                textBox_Uti.Text = tblog.ReadLine();

                tblog.Close();

            }
            catch (IOException ee)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            Pair();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            Auth_post();
                        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            GetRequest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            DelRequest();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            StatusRequest();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            XReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            ZReport();
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            Reversal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Auth_post();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            PostResponse();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            Display_post();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Save_Settings_file();
            Print_post();
        }
    }
}
