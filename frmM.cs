using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ECAN;

namespace ECanTest
{
    public partial class frmM : Form
    {
        // 定义波特率变量
        byte m_Baudrate;
        byte m_Baudrate2;

        // 连接状态变量
        byte m_connect = 0;
        ComProc mCan = new ComProc(); // 创建 ComProc 实例，用于处理 CAN 消息

        // 向 ListBox 添加信息的方法
        private void IncludeTextMessage(string strMsg)
        {
            lbxInfo.Items.Add(strMsg); // 将消息添加到 ListBox
            lbxInfo.SelectedIndex = lbxInfo.Items.Count - 1; // 选择最后一项
        }

        // 窗体构造函数
        public frmM()
        {
            InitializeComponent(); // 初始化组件
        }

        // 窗体关闭事件处理
        private void frmM_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.m_connect = 0; // 设置连接状态为 0
            this.mCan.EnableProc = false; // 禁用处理

            ECANDLL.CloseDevice(1, 0); // 关闭设备
        }

        // 初始化按钮点击事件处理
        private void btnInit_Click(object sender, EventArgs e)
        {
            if (m_connect == 1) // 如果已连接
            {
                m_connect = 0; // 更新连接状态
                this.mCan.EnableProc = false; // 禁用处理

                ECANDLL.CloseDevice(1, 0); // 关闭设备
                btnInit.Text = "打开设备"; // 更新按钮文本

                btnReset.Enabled = false; // 禁用重置按钮
                btnWrite.Enabled = false; // 禁用写入按钮

                return; // 退出方法
            }

            // 初始化配置
            INIT_CONFIG init_config = new INIT_CONFIG();
            init_config.AccCode = 0; // 设置接收代码
            init_config.AccMask = 0xffffff; // 设置接收掩码
            init_config.Filter = 0; // 设置过滤器

            // 根据波特率设置定时器
            switch (m_Baudrate)
            {
                case 0: // 1000
                    init_config.Timing0 = 0;
                    init_config.Timing1 = 0x14;
                    break;
                case 1: // 800
                    init_config.Timing0 = 0;
                    init_config.Timing1 = 0x16;
                    break;
                case 2: // 666
                    init_config.Timing0 = 0x80;
                    init_config.Timing1 = 0xb6;
                    break;
                case 3: // 500
                    init_config.Timing0 = 0x1c;
                    init_config.Timing1 = 0x1c;
                    break;
                case 4: // 400
                    init_config.Timing0 = 0x80;
                    init_config.Timing1 = 0xfa;
                    break;
                case 5: // 250
                    init_config.Timing0 = 0x01;
                    init_config.Timing1 = 0x1c;
                    break;
                case 6: // 200
                    init_config.Timing0 = 0x81;
                    init_config.Timing1 = 0xfa;
                    break;
                case 7: // 125
                    init_config.Timing0 = 0x03;
                    init_config.Timing1 = 0x1c;
                    break;
                case 8: // 100
                    init_config.Timing0 = 0x04;
                    init_config.Timing1 = 0x1c;
                    break;
                case 9: // 80
                    init_config.Timing0 = 0x83;
                    init_config.Timing1 = 0xff;
                    break;
                case 10: // 50
                    init_config.Timing0 = 0x09;
                    init_config.Timing1 = 0x1c;
                    break;
            }

            init_config.Mode = 0; // 设置模式

            // 打开设备
            if (ECANDLL.OpenDevice(1, 0, 0) != ECAN.ECANStatus.STATUS_OK)
            {
                MessageBox.Show("Open device fault!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 退出方法
            }

            // 设置 CAN1 波特率
            if (ECANDLL.InitCAN(1, 0, 0, ref init_config) != ECAN.ECANStatus.STATUS_OK)
            {
                MessageBox.Show("Init can fault!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ECANDLL.CloseDevice(1, 0); // 关闭设备
                return; // 退出方法
            }

            // 设置 CAN2 波特率
            switch (m_Baudrate2)
            {
                case 0: // 1000
                    init_config.Timing0 = 0;
                    init_config.Timing1 = 0x14;
                    break;
                case 1: // 800
                    init_config.Timing0 = 0;
                    init_config.Timing1 = 0x16;
                    break;
                case 2: // 666
                    init_config.Timing0 = 0x80;
                    init_config.Timing1 = 0xb6;
                    break;
                case 3: // 500
                    init_config.Timing0 = 0x1c;
                    init_config.Timing1 = 0x1c;
                    break;
                case 4: // 400
                    init_config.Timing0 = 0x80;
                    init_config.Timing1 = 0xfa;
                    break;
                case 5: // 250
                    init_config.Timing0 = 0x01;
                    init_config.Timing1 = 0x1c;
                    break;
                case 6: // 200
                    init_config.Timing0 = 0x81;
                    init_config.Timing1 = 0xfa;
                    break;
                case 7: // 125
                    init_config.Timing0 = 0x03;
                    init_config.Timing1 = 0x1c;
                    break;
                case 8: // 100
                    init_config.Timing0 = 0x04;
                    init_config.Timing1 = 0x1c;
                    break;
                case 9: // 80
                    init_config.Timing0 = 0x83;
                    init_config.Timing1 = 0xff;
                    break;
                case 10: // 50
                    init_config.Timing0 = 0x09;
                    init_config.Timing1 = 0x1c;
                    break;
            }

            init_config.Mode = 0; // 设置模式

            // 初始化 CAN2
            if (ECANDLL.InitCAN(1, 0, 1, ref init_config) != ECAN.ECANStatus.STATUS_OK)
            {
                MessageBox.Show("Init can fault!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ECANDLL.CloseDevice(1, 0); // 关闭设备
                return; // 退出方法
            }

            m_connect = 1; // 更新连接状态
            this.mCan.EnableProc = true; // 启用处理

            btnInit.Text = "关闭设备"; // 更新按钮文本
            btnReset.Enabled = true; // 启用重置按钮
            btnWrite.Enabled = true; // 启用写入按钮
            IncludeTextMessage("Open Success"); // 显示成功消息

            btnWrite2.Enabled = true; // 启用第二个写入按钮

            if (m_connect == 0) // 检查连接状态
            {
                MessageBox.Show("Not open device!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 退出方法
            }

            // 启动 CAN1
            if (ECANDLL.StartCAN(1, 0, 0) == ECAN.ECANStatus.STATUS_OK)
            {
                IncludeTextMessage("Start CAN1 Success"); // 显示成功消息
                tmrRead.Enabled = true; // 启用定时器
            }
            else
            {
                IncludeTextMessage("Start Fault"); // 显示失败消息
            }

            // 启动 CAN2
            if (ECANDLL.StartCAN(1, 0, 1) == ECAN.ECANStatus.STATUS_OK)
            {
                IncludeTextMessage("Start CAN2 Success"); // 显示成功消息
                tmrRead.Enabled = true; // 启用定时器
            }
            else
            {
                IncludeTextMessage("Start Fault"); // 显示失败消息
            }
        }

        // 波特率选择变化事件处理
        private void cbbBaudrates_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Baudrate = (byte)cbbBaudrates.SelectedIndex; // 更新波特率
        }

        // 重置按钮点击事件处理
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (m_connect == 0) // 检查连接状态
            {
                MessageBox.Show("Not open device!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 退出方法
            }

            // 重置 CAN1
            if (ECANDLL.ResetCAN(1, 0, 0) == ECANStatus.STATUS_OK)
            {
                IncludeTextMessage("Reset Success"); // 显示成功消息
            }
            else
            {
                IncludeTextMessage("Reset Fault"); // 显示失败消息
            }
        }

        // 写入按钮点击事件处理
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (this.m_connect == 0) // 检查连接状态
            {
                MessageBox.Show("Not open device!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                CAN_OBJ frameinfo; // 创建 CAN 消息对象
                TextBox txtbCurrentTextBox; // 当前文本框

                // 创建 CAN 消息结构
                frameinfo = new CAN_OBJ();
                frameinfo.SendType = 0; // 设置发送类型

                frameinfo.data = new byte[8]; // 初始化数据数组
                frameinfo.Reserved = new byte[2]; // 初始化保留字段

                // 配置消息的 ID、数据长度、消息类型和数据
                frameinfo.ID = Convert.ToUInt32(txtID.Text, 16); // 从文本框获取 ID
                frameinfo.DataLen = Convert.ToByte(nudLength.Value); // 从数值框获取数据长度

                // 设置扩展标志
                if (this.chbExtended.Checked)
                {
                    frameinfo.ExternFlag = 1; // 设置为扩展帧
                }
                else
                {
                    frameinfo.ExternFlag = 0; // 设置为标准帧
                }

                // 设置远程标志
                if (this.chbRemote.Checked)
                {
                    frameinfo.RemoteFlag = 1; // 设置为远程帧
                }
                else
                {
                    frameinfo.RemoteFlag = 0; // 设置为数据帧
                    txtbCurrentTextBox = txtData0; // 获取第一个数据框

                    int tlen = frameinfo.DataLen - 1; // 计算数据长度
                    for (int i = 0; i <= tlen; i++)
                    {
                        frameinfo.data[i] = Convert.ToByte(txtbCurrentTextBox.Text, 0x10); // 从文本框获取数据
                        if (i < 7)
                        {
                            txtbCurrentTextBox = (TextBox)this.GetNextControl(txtbCurrentTextBox, true); // 获取下一个文本框
                        }
                    }
                }

                // 将消息添加到发送缓冲区
                this.mCan.gSendMsgBuf[this.mCan.gSendMsgBufHead].ID = frameinfo.ID;
                this.mCan.gSendMsgBuf[this.mCan.gSendMsgBufHead].DataLen = frameinfo.DataLen;
                this.mCan.gSendMsgBuf[this.mCan.gSendMsgBufHead].data = frameinfo.data;
                this.mCan.gSendMsgBuf[this.mCan.gSendMsgBufHead].ExternFlag = frameinfo.ExternFlag;
                this.mCan.gSendMsgBuf[this.mCan.gSendMsgBufHead].RemoteFlag = frameinfo.RemoteFlag;
                this.mCan.gSendMsgBufHead += 1; // 更新发送缓冲区头
                if (this.mCan.gSendMsgBufHead >= ComProc.SEND_MSG_BUF_MAX)
                {
                    this.mCan.gSendMsgBufHead = 0; // 循环缓冲区
                }
            }
        }

        // 清除信息按钮点击事件处理
        private void btnInfoClear_Click(object sender, EventArgs e)
        {
            lbxInfo.Items.Clear(); // 清空信息列表
        }

        // 定时器读取事件处理
        private void tmrRead_Tick(object sender, EventArgs e)
        {
            ReadMessages(); // 读取消息
            ReadMessages2(); // 读取第二条消息
            ReadError1(); // 读取错误信息
            ReadError2(); // 读取第二条错误信息
            ProcessDataFromCAN1(); // 处理来自 CAN1 的数据
        }

        // 读取错误信息的方法
        private void ReadError1()
        {
            CAN_ERR_INFO mErrInfo = new CAN_ERR_INFO(); // 创建错误信息对象

            // 读取错误信息
            if (ECANDLL.ReadErrInfo(1, 0, 0, out mErrInfo) == ECANStatus.STATUS_OK)
            {
                labErrInfo1.Text = string.Format("{0:X4}h", mErrInfo.ErrCode); // 显示错误代码
                labRx.Text = string.Format("{0:X4}h", mErrInfo.Passive_ErrData[1]); // 显示接收错误数据
                labTx.Text = string.Format("{0:X4}h", mErrInfo.Passive_ErrData[2]); // 显示发送错误数据
            }
            else
            {
                labErrInfo1.Text = "Read Error Fault"; // 显示读取错误信息失败
            }
        }

        // 读取第二条错误信息的方法
        private void ReadError2()
        {
            CAN_ERR_INFO mErrInfo = new CAN_ERR_INFO(); // 创建错误信息对象

            // 读取错误信息
            if (ECANDLL.ReadErrInfo(1, 0, 1, out mErrInfo) == ECANStatus.STATUS_OK)
            {
                labErrInfo2.Text = string.Format("{0:X4}h", mErrInfo.ErrCode); // 显示错误代码
            }
            else
            {
                labErrInfo2.Text = "Read Error Fault"; // 显示读取错误信息失败
            }
        }

        // 读取消息的方法
        private void ReadMessages()
        {
            CAN_OBJ frameinfo = new CAN_OBJ(); // 创建 CAN 消息对象
            int mCount = 0; // 消息计数器
            while (this.mCan.gRecMsgBufHead != this.mCan.gRecMsgBufTail) // 当接收缓冲区不为空
            {
                string tmpstr; // 临时字符串
                frameinfo = this.mCan.gRecMsgBuf[this.mCan.gRecMsgBufTail]; // 获取消息
                this.mCan.gRecMsgBufTail += 1; // 更新接收缓冲区尾
                if (this.mCan.gRecMsgBufTail >= ComProc.REC_MSG_BUF_MAX)
                {
                    this.mCan.gRecMsgBufTail = 0; // 循环缓冲区
                }
                string str = "Rec: "; // 接收消息前缀
                if (frameinfo.TimeFlag == 0)
                {
                    tmpstr = "Time:  "; // 时间标志
                }
                else
                {
                    tmpstr = "Time:" + string.Format("{0:X8}h", frameinfo.TimeStamp); // 显示时间戳
                }
                str = str + tmpstr; // 拼接字符串
                tmpstr = "  ID:" + string.Format("{0:X8}h", frameinfo.ID); // 显示消息 ID
                str = str + tmpstr + " Format:"; // 拼接格式字符串
                if (frameinfo.RemoteFlag == 0)
                {
                    tmpstr = "Data "; // 数据帧
                }
                else
                {
                    tmpstr = "Romte "; // 远程帧
                }
                str = str + tmpstr + " Type:"; // 拼接类型字符串
                if (frameinfo.ExternFlag == 0)
                {
                    tmpstr = "Stand "; // 标准帧
                }
                else
                {
                    tmpstr = "Exten "; // 扩展帧
                }
                str = str + tmpstr; // 拼接扩展标志字符串
                if (frameinfo.RemoteFlag == 0) // 如果是数据帧
                {
                    str = str + " Data:"; // 添加数据前缀
                    if (frameinfo.DataLen > 8)
                    {
                        frameinfo.DataLen = 8; // 限制数据长度
                    }
                    int mlen = frameinfo.DataLen - 1; // 计算数据长度
                    for (int j = 0; j <= mlen; j++)
                    {
                        tmpstr = string.Format("{0:X2}h", frameinfo.data[j]); // 格式化数据
                        str = str + tmpstr; // 拼接数据字符串
                    }
                }
                this.lbxRec.Items.Add(str); // 将接收字符串添加到 ListBox
                if (this.lbxRec.Items.Count > 500) // 如果超过 500 条
                {
                    this.lbxRec.Items.Clear(); // 清空 ListBox
                }
                mCount++; // 增加计数
                if (mCount >= 50) // 如果达到 50 条
                {
                    break; // 退出循环
                }
                Application.DoEvents(); // 处理应用程序事件
            }
        }

        // 读取第二条消息的方法
        private void ReadMessages2()
        {
            CAN_OBJ frameinfo = new CAN_OBJ(); // 创建 CAN 消息对象
            int mCount = 0; // 消息计数器
            while (this.mCan.gRecMsgBufHead2 != this.mCan.gRecMsgBufTail2) // 当接收缓冲区不为空
            {
                string tmpstr; // 临时字符串
                frameinfo = this.mCan.gRecMsgBuf2[this.mCan.gRecMsgBufTail2]; // 获取消息
                this.mCan.gRecMsgBufTail2 += 1; // 更新接收缓冲区尾
                if (this.mCan.gRecMsgBufTail2 >= ComProc.REC_MSG_BUF_MAX)
                {
                    this.mCan.gRecMsgBufTail2 = 0; // 循环缓冲区
                }
                string str = "Rec: "; // 接收消息前缀
                if (frameinfo.TimeFlag == 0)
                {
                    tmpstr = "Time:  "; // 时间标志
                }
                else
                {
                    tmpstr = "Time:" + string.Format("{0:X8}h", frameinfo.TimeStamp); // 显示时间戳
                }
                str = str + tmpstr; // 拼接字符串
                tmpstr = "  ID:" + string.Format("{0:X8}h", frameinfo.ID); // 显示消息 ID
                str = str + tmpstr + " Format:"; // 拼接格式字符串
                if (frameinfo.RemoteFlag == 0)
                {
                    tmpstr = "Data "; // 数据帧
                }
                else
                {
                    tmpstr = "Romte "; // 远程帧
                }
                str = str + tmpstr + " Type:"; // 拼接类型字符串
                if (frameinfo.ExternFlag == 0)
                {
                    tmpstr = "Stand "; // 标准帧
                }
                else
                {
                    tmpstr = "Exten "; // 扩展帧
                }
                str = str + tmpstr; // 拼接扩展标志字符串
                if (frameinfo.RemoteFlag == 0) // 如果是数据帧
                {
                    str = str + " Data:"; // 添加数据前缀
                    if (frameinfo.DataLen > 8)
                    {
                        frameinfo.DataLen = 8; // 限制数据长度
                    }
                    int mlen = frameinfo.DataLen - 1; // 计算数据长度
                    for (int j = 0; j <= mlen; j++)
                    {
                        tmpstr = string.Format("{0:X2}h", frameinfo.data[j]); // 格式化数据
                        str = str + tmpstr; // 拼接数据字符串
                    }
                }
                this.lbxRec2.Items.Add(str); // 将接收字符串添加到 ListBox
                if (this.lbxRec2.Items.Count > 500) // 如果超过 500 条
                {
                    this.lbxRec2.Items.Clear(); // 清空 ListBox
                }
                mCount++; // 增加计数
                if (mCount >= 50) // 如果达到 50 条
                {
                    break; // 退出循环
                }
                Application.DoEvents(); // 处理应用程序事件
            }
        }

        // 清除消息按钮点击事件处理
        private void btnMsgClear_Click(object sender, EventArgs e)
        {
            lbxRec.Items.Clear(); // 清空接收消息列表
        }

        // 清除第二条消息按钮点击事件处理
        private void btnMsgClear2_Click(object sender, EventArgs e)
        {
            lbxRec2.Items.Clear(); // 清空第二条接收消息列表
        }

        // 读取信息按钮点击事件处理
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                BOARD_INFO mReadBoardInfo = new BOARD_INFO(); // 创建板卡信息对象

                // 读取板卡信息
                if (ECANDLL.ReadBoardInfo(1, 0, out mReadBoardInfo) == ECANStatus.STATUS_OK)
                {
                    for (i = 0; i < 10; i++)
                        labInfo.Text = labInfo.Text + (mReadBoardInfo.str_Serial_Num[i]); // 显示序列号
                }
                else
                {
                    MessageBox.Show("读取信息失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); // 显示错误消息
                }
            }
            catch (DllNotFoundException ex)
            {
                MessageBox.Show("无法加载 DLL: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); // 显示 DLL 加载错误
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); // 显示其他错误
            }
        }

        // 新增选项卡AG-CAN-TEST处理来自 CAN1 的数据的方法
        private void ProcessDataFromCAN1()
        {
            // 假设我们从 CAN1 获取数据并进行处理
            // 这里可以添加具体的数据处理逻辑
            string processedData = "AG_CAN_Test"; // 示例数据
            // 将处理后的数据添加到新选项卡的控件中
            // 例如，假设我们有一个 ListBox 控件来显示数据
            ListBox lbxProcessedData = new ListBox();
            lbxProcessedData.Items.Add(processedData); // 添加处理后的数据
            this.tabPage3.Controls.Add(lbxProcessedData); // 将 ListBox 添加到新选项卡
        }

        // 波特率选择变化事件处理
        private void cbbBaudrates2_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Baudrate2 = (byte)cbbBaudrates2.SelectedIndex; // 更新第二个波特率
        }

        // 写入按钮点击事件处理
        private void btnWrite2_Click(object sender, EventArgs e)
        {
            // 这里可以添加写入 CAN2 的逻辑
            MessageBox.Show("写入按钮被点击！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 清除信息按钮点击事件处理
        private void btnInfoClear2_Click(object sender, EventArgs e)
        {
            lbxInfo2.Items.Clear(); // 清空第二个信息列表
        }

        // 窗体加载事件处理
        private void Form1_Load(object sender, EventArgs e)
        {
            // 这里可以添加窗体加载时的初始化逻辑
            cbbBaudrates.SelectedIndex = 3; // 设置默认波特率
            cbbBaudrates2.SelectedIndex = 5; // 设置第二个波特率的默认值
        }

        private void UpdateStatusDisplay()
        {
            // 假设我们从 CAN 获取到的状态数据
            lblCommStatus.Text = "通讯状态: 成功"; // 更新通讯状态
            lblBatteryStatus.Text = "电池状态: 正常"; // 更新电池状态
            lblSOC.Text = "SOC: 75%"; // 更新 SOC
            lblSOH.Text = "SOH: 80%"; // 更新 SOH
            lblTotalVoltage.Text = "总电压: 48V"; // 更新总电压
            lblMinCellVoltage.Text = "单体最低电压: 3.2V"; // 更新单体最低电压
            lblMaxCellVoltage.Text = "单体最高电压: 3.6V"; // 更新单体最高电压
            lblCurrent.Text = "电流: 10A"; // 更新电流
            lblMaxTemperature.Text = "最高温度: 30°C"; // 更新最高温度
            lblChargeMOSStatus.Text = "充电MOS状态: 正常"; // 更新充电 MOS 状态
            lblDischargeMOSStatus.Text = "放电MOS状态: 正常"; // 更新放电 MOS 状态
            lblCurrentState.Text = "当前状态: 运行中"; // 更新当前状态
        }
    }
}