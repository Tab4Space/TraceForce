using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KiwoomCode;


namespace TraceForce2
{
   
    public partial class Form1 : Form
    {
        public struct ConditionList
        {
            public string strConditionName;
            public int nIndex;
        }

        private int _scrNum = 5000;
        private string _strRealConScrNum = "0000";
        private string _strRealConName = "0000";
        private int _nIndex = 0;

        private bool _bRealTrade = false;

        public Form1()
        {
            InitializeComponent();
            axKHOpenAPI1.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.OnReceiveTrDataPlus);
        }
        
        private void OnReceiveTrDataPlus(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "Request_maximum_price")
            {
                textBox1.Clear();
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                if(nCnt==0)
                {
                    textBox1.Text += "상한가 종목 없음.";
                }
                for (int i = 0; i < nCnt; i++)
                {
                    textBox1.Text += "\r\n";
                    textBox1.Text += "종목명 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim() + "\r\n";
                    textBox1.Text += "종목코드 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "종목코드").Trim() + "\r\n";
                    textBox1.Text += "현재가 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim() + "\r\n";
                    textBox1.Text += "등락율 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "등락률").Trim() + "\r\n";
                    textBox1.Text += "거래량 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "현재거래량").Trim() + "\r\n";
                    textBox1.Text += "\r\n ==========================================\r\n";
                }

            }

            if (e.sRQName == "Request_volume_top10")
            {
                textBox1.Clear();
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                if (nCnt == 0)
                {
                    textBox1.Text += "에러";
                }
                for (int i = 0; i < 10; i++)
                {
                    textBox1.Text += "\r\n";
                    textBox1.Text += "종목명 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "종목명").Trim() + "\r\n";
                    textBox1.Text += "종목코드 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "종목코드").Trim() + "\r\n";
                    textBox1.Text += "현재가 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim() + "\r\n";
                    textBox1.Text += "등락율 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "등락률").Trim() + "\r\n";
                    textBox1.Text += "거래량 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "현재거래량").Trim() + "\r\n";
                    textBox1.Text += "\r\n ==========================================\r\n";
                }

            }
          

            if (e.sRQName == "Request_Chart_View")
            {
                textBox1.Clear();
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                if (nCnt == 0)
                {
                    textBox1.Text += "에러";
                }

                for (int i = 0; i < 10; i++)
                {
                    textBox1.Text += "\r\n";
                    textBox1.Text += "현재가 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "현재가").Trim() + "\r\n";
                    textBox1.Text += "거래량 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "거래량").Trim() + "\r\n";
                    textBox1.Text += "체결시간 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "체결시간").Trim() + "\r\n";
                    textBox1.Text += "시가 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "시가").Trim() + "\r\n";
                    textBox1.Text += "고가 : " + axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, i, "고가").Trim() + "\r\n";
                    textBox1.Text += "\r\n==========================================\r\n";
                }

            }

        }


        private void Login_Button_Click(object sender, EventArgs e)
        {
            long Result;

            Result = axKHOpenAPI1.CommConnect();

            if (Result != 0)
                MessageBox.Show("login창 열림 fail");

            
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            DisconnectAllRealData();
            axKHOpenAPI1.CommTerminate();
            MessageBox.Show("logout");
        }

        private void DisconnectAllRealData()
        {
            for (int i = _scrNum; i > 5000; i--)
            {
                axKHOpenAPI1.DisconnectRealData(i.ToString());
            }

            _scrNum = 5000;
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Data_Log_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Data_Volume_Top10_Button_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.SetInputValue("시장구분", "000");
            axKHOpenAPI1.SetInputValue("정렬구분", "2");
            axKHOpenAPI1.SetInputValue("시간구분", "1");
            axKHOpenAPI1.SetInputValue("거래량구분", "5");
            axKHOpenAPI1.SetInputValue("시간", "1");
            axKHOpenAPI1.SetInputValue("종목조건", "0");
            axKHOpenAPI1.SetInputValue("가격구분", "0");

            int nRet = axKHOpenAPI1.CommRqData("Request_volume_top10", "OPT10023", 0, GetScrNum());
            _scrNum++;
        }

        private void Max_Price_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.SetInputValue("시장구분", "000");
            axKHOpenAPI1.SetInputValue("상하한구분", "1");
            axKHOpenAPI1.SetInputValue("정렬구분", "1");
            axKHOpenAPI1.SetInputValue("종목조건", "0");
            axKHOpenAPI1.SetInputValue("거래량구분", "00000");
            axKHOpenAPI1.SetInputValue("신용조건", "0");
            axKHOpenAPI1.SetInputValue("매매금구분", "0");

            int nRet = axKHOpenAPI1.CommRqData("Request_maximum_price" , "OPT10017", 0, GetScrNum());
            _scrNum++;
        }

        private string GetScrNum()
        {
            if (_scrNum < 9999)
                _scrNum++;
            else
                _scrNum = 5000;

            return _scrNum.ToString();
        }

        private void axKHOpenAPI_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

           
                    Logger(Log.조회, "{0} | 현재가:{1:N0} | 등락율:{2} | 거래량:{3:N0} ",
                        axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, 1, "종목명").Trim(),
                        Int32.Parse(axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, 1, "거래량").Trim()));
            
        
            

        }

        private void axKHOpenAPI_OnReceiveMsg(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEvent e)
        {
            Logger(Log.조회, "===================================================");
            Logger(Log.조회, "화면번호:{0} | RQName:{1} | TRCode:{2} | 메세지:{3}", e.sScrNo, e.sRQName, e.sTrCode, e.sMsg);
        }
        public void Logger(Log type, string format, params Object[] args)
        {
            string message = String.Format(format, args);

            switch (type)
            {
                case Log.조회:
                 
                    break;
                
                default:
                    break;
            }
        }

        private void login_data_Click(object sender, EventArgs e)
        {
            User_Id.Text = axKHOpenAPI1.GetLoginInfo("USER_ID");
            User_Name.Text = axKHOpenAPI1.GetLoginInfo("USER_NAME");

            string[] Acount_arr = axKHOpenAPI1.GetLoginInfo("ACCNO").Split(';');

            User_Account.Items.AddRange(Acount_arr);
            User_Account.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Chart_View_Click(object sender, EventArgs e)
        {
          
            
            axKHOpenAPI1.SetInputValue("종목코드", Chart_Code.Text);
            axKHOpenAPI1.SetInputValue("틱범위", "10");
            axKHOpenAPI1.SetInputValue("수정주가구분", "0");


            int nRet = axKHOpenAPI1.CommRqData("Request_Chart_View", "OPT10080", 0, GetScrNum());
            _scrNum++;
          
        }

        private void Chart_Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // =================================================
            // 거래구분목록 지정
            for (int i = 0; i < 12; i++)
                Trade_Check.Items.Add(KOACode.hogaGb[i].name);

            Trade_Check.SelectedIndex = 0;


            // =================================================
            // 주문유형
            for (int i = 0; i < 5; i++)
                Trade_check2.Items.Add(KOACode.orderType[i].name);

            Trade_check2.SelectedIndex = 0;
        }
        private void Trade_Btn_Click(object sender, EventArgs e)
        {
          
            if (User_Account.Text.Length != 10)
            {
                Trade_TxtBox.Text+= "계좌번호 10자리를 입력해 주세요";

                return;
            }

            // =================================================
            // 종목코드 입력 여부 확인
            if (Trade_Code.TextLength != 6)
            {
                Trade_TxtBox.Text += "종목코드 6자리를 입력해 주세요";

                return;
            }

            // =================================================
            // 주문수량 입력 여부 확인
            int nTrade_amount;

            if (Trade_amount.TextLength > 0)
            {
                nTrade_amount = Int32.Parse(Trade_amount.Text.Trim());
            }
            else
            {
                Trade_TxtBox.Text +="주문수량을 입력하지 않았습니다";

                return;
            }

            if (nTrade_amount < 1)
            {
                Trade_TxtBox.Text += "주문수량이 1보다 작습니다";

                return;
            }

            // =================================================
            // 거래구분 취득
            // 0:지정가, 3:시장가, 5:조건부지정가, 6:최유리지정가, 7:최우선지정가,
            // 10:지정가IOC, 13:시장가IOC, 16:최유리IOC, 20:지정가FOK, 23:시장가FOK,
            // 26:최유리FOK, 61:장개시전시간외, 62:시간외단일가매매, 81:시간외종가

            string s거래구분;
            s거래구분 = "시장가";

            // =================================================
            // 주문가격 입력 여부

            int n주문가격 = 0;

            if (Trade_Price.TextLength > 0)
            {
                n주문가격 = Int32.Parse(Trade_Price.Text.Trim());
            }

            if (s거래구분 == "3" || s거래구분 == "13" || s거래구분 == "23" && n주문가격 < 1)
            {
                Trade_TxtBox.Text += "주문가격이 1보다 작습니다";
            }

            // =================================================
            // 매매구분 취득
            // (1:신규매수, 2:신규매도 3:매수취소, 
            // 4:매도취소, 5:매수정정, 6:매도정정)

            int n매매구분;
            n매매구분 = 1;

            // =================================================
            // 원주문번호 입력 여부

            if (n매매구분 > 2 && Trade_Order_Num.TextLength < 1)
            {
                Trade_TxtBox.Text += "원주문번호를 입력해주세요";
            }


            // =================================================
            // 주식주문
            int lRet;

            lRet = axKHOpenAPI1.SendOrder("주식주문", GetScrNum(), User_Account.Text.Trim(),
                                        n매매구분, Trade_Code.Text.Trim(), nTrade_amount,
                                        n주문가격, s거래구분, Trade_Order_Num.Text.Trim());

            if (lRet == 0)
            {
                Trade_TxtBox.Text += "주문이 전송 되었습니다";
            }
            else
            {
                Trade_TxtBox.Text += "주문이 전송 실패 하였습니다. [에러] : " + lRet;
            }
        }

        private void User_Account_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        ///////////////////////////////////////////////////////////
    }
}
