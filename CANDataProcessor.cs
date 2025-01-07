using System;
using System.Drawing;

namespace ECanTest
{
  public class CANDataProcessor
  {
    private readonly Action<string, string, Color, Color> updateDataBlockAction;

    public CANDataProcessor(Action<string, string, Color, Color> updateDataBlockAction)
    {
      this.updateDataBlockAction = updateDataBlockAction;
    }


    string CommunicationStatus = "失败";
    public void ProcessCANData(uint id, byte[] data)
    {
      
      switch (id)
      {
        
        case 0x1806E5F4:
          ProcessCommunicationStatus(data);
          ProcessBatteryStatus(data);
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x101:
         
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x04008001:
          ProcessMinCellVoltage(data);
          ProcessMaxCellVoltage(data);
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x103:
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x04028001:
          ProcessSOC(data);
          ProcessSOH(data);
          ProcessTotalVoltage(data);
          ProcessCurrent(data);
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x04228001:
          // 空闲
          break;
        case 0x106:
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x107:
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x04018001:
          ProcessMaxTemperature(data);
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x04068001:
          ProcessChargeMOSStatus(data);
          ProcessDischargeMOSStatus(data);
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        case 0x10A:
          
          break;
        case 0x04078001:
          ProcessCurrentState(data);
          Console.WriteLine($"Received CAN ID:{id:X8}");
          Console.WriteLine($"Received CAN DATA:{data[0]}");
          break;
        default:
         
          // Console.WriteLine($"Received CAN ID:{id:X8}");
          break;
      }
    }

    private void ProcessCommunicationStatus(byte[] data)
    {
      CommunicationStatus = "成功";
      Color bgColor =   CustomColors.CGreen;
      updateDataBlockAction("通讯状态", CommunicationStatus, Color.White, bgColor);
      Console.WriteLine($"通讯状态: {CommunicationStatus}");
    }

    private void ProcessBatteryStatus(byte[] data)
    {
      string status = data[0] == 0 ? "正常" : "异常";
      Color bgColor = data[0] == 0 ? CustomColors.CGreen : CustomColors.CRed;
      updateDataBlockAction("电池状态", status, Color.White, bgColor);
      Console.WriteLine($"电池状态: {status}");
    }

    private void ProcessSOC(byte[] data)
    {
      int soc = data[4];
      updateDataBlockAction("SOC", $"{soc}%", Color.Black, CustomColors.CYellow);
      Console.WriteLine($"SOC: {soc}%");
    }

    private void ProcessSOH(byte[] data)
    {
    
      int soh = data[6];
      updateDataBlockAction("SOH", $"{soh}%", Color.Black, CustomColors.CYellow);
      Console.WriteLine($"SOH: {soh}%");
    }

    private void ProcessTotalVoltage(byte[] data)
    {
      float totalVoltage = BitConverter.ToSingle(data, 0);
      updateDataBlockAction("总电压", $"{totalVoltage:F1}V", Color.Black, CustomColors.CBlue);
      Console.WriteLine($"总电压: {totalVoltage:F1}V");
    }

    private void ProcessMinCellVoltage(byte[] data)
    {
      float minCellVoltage = BitConverter.ToSingle(data, 1);
      // float minCellVoltage = 70.1f;
      updateDataBlockAction("单体最低电压", $"{minCellVoltage:F1}V", Color.Black, CustomColors.CBlue);
      Console.WriteLine($"单体最低电压: {minCellVoltage:F1}V");
    }

    private void ProcessMaxCellVoltage(byte[] data)
    {
      float maxCellVoltage = BitConverter.ToSingle(data, 0);
      // float maxCellVoltage = 72.3f;
      updateDataBlockAction("单体最高电压", $"{maxCellVoltage:F1}V", Color.Black, CustomColors.CBlue);
      Console.WriteLine($"单体最高电压: {maxCellVoltage:F1}V");
    }


    private void ProcessCurrent(byte[] data)
    {
      float current = BitConverter.ToSingle(data, 2);
      updateDataBlockAction("电流", $"{current:F1}A", Color.Black, CustomColors.CBlue);
      Console.WriteLine($"电流: {current:F1}A");
    }
    private void ProcessMaxTemperature(byte[] data)
    {
      float maxTemperature = BitConverter.ToSingle(data, 0);
      updateDataBlockAction("最高温度", $"{maxTemperature:F1}°C", Color.Black, CustomColors.CYellow);
      Console.WriteLine($"最高温度: {maxTemperature:F1}°C");
    }
    private void ProcessChargeMOSStatus(byte[] data)
    {
      string chargeStatus = data[0] == 1 ? "开启" : "关闭";
      Color chargeBgColor = data[0] == 1 ? CustomColors.CRed : CustomColors.CBlue;
      updateDataBlockAction("充电MOS状态", chargeStatus, Color.White, chargeBgColor);
      Console.WriteLine($"充电MOS状态: {chargeStatus}");
    }

    private void ProcessDischargeMOSStatus(byte[] data)
    {
      string dischargeStatus = data[1] == 1 ? "开启" : "关闭";
      Color dischargeBgColor = data[1] == 1 ? CustomColors.CRed : CustomColors.CBlue;
      updateDataBlockAction("放电MOS状态", dischargeStatus, Color.White, dischargeBgColor);
      Console.WriteLine($" 放电MOS状态: {dischargeStatus}");
    }


    private void ProcessCurrentState(byte[] data)
    {
      string[] states = { "待机", "充电", "放电", "故障" };
      string currentState = states[data[0]];
      Color bgColor = data[0] == 3 ? CustomColors.CRed : CustomColors.CGreen;
      updateDataBlockAction("当前状态", currentState, Color.White, bgColor);
      Console.WriteLine($"当前状态: {currentState}");
    }


  }
}