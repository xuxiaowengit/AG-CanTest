// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Windows.Forms;

// namespace ECanTest
// {
//     public partial class DataBlock : UserControl
//     {
//         private Label titleLabel;
//         private Label valueLabel;
//         public DataBlock()
//         {
//             InitializeComponent();
//             SetupControls();
//         }

//         private void DataBlock_Load(object sender, EventArgs e)
//         {

//         }

//         public string Title
//         {
//             get { return titleLabel.Text; }
//             set { titleLabel.Text = value; }
//         }

//         public string Value
//         {
//             get { return valueLabel.Text; }
//             set { valueLabel.Text = value; }
//         }


//         private void SetupControls()
//         {
//             this.titleLabel = new System.Windows.Forms.Label();
//             this.valueLabel = new System.Windows.Forms.Label();
//             this.SuspendLayout();
//             // 
//             // titleLabel // 设置标题标签（titleLabel）的样式
//             // 
//             this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
//             this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             this.titleLabel.Location = new System.Drawing.Point(0, 0);
//             this.titleLabel.Name = "titleLabel";
//             this.titleLabel.Size = new System.Drawing.Size(150, 20);
//             this.titleLabel.TabIndex = 0;
//             this.titleLabel.Text = "Title";
//             this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;// 默认居中
//             // 
//             // valueLabel// 设置值标签（valueLabel）的样式
//             // 
//             this.valueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
//             this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             this.valueLabel.Location = new System.Drawing.Point(0, 20);
//             this.valueLabel.Name = "valueLabel";
//             this.valueLabel.Size = new System.Drawing.Size(150, 30);
//             this.valueLabel.TabIndex = 1;
//             this.valueLabel.Text = "Value";
//             this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//             // 
//             // DataBlock设置整个 DataBlock 控件的样式
//             // 
//             this.Controls.Add(this.valueLabel);
//             this.Controls.Add(this.titleLabel);
//             this.Name = "DataBlock";
//             this.Size = new System.Drawing.Size(150, 50);
//             this.ResumeLayout(false);
//         }

//         public void SetStyle(Color backColor, Color foreColor, Font font)
//         {
//           this.BackColor = backColor; // 设置背景颜色
//         this.ForeColor = foreColor; // 设置前景（文本）颜色
//         this.valueLabel.Font = font; // 设置值标签的字体
//         }

//           public void SetTitleStyle(Color foreColor, Font font, ContentAlignment alignment)
//        {
//         this.titleLabel.ForeColor = foreColor;
//         this.titleLabel.Font = font;
//         this.titleLabel.TextAlign = alignment;
//         }

//         // end of class项目代码结束
//     }

// }



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // 引入用于绘制圆角的命名空间

namespace ECanTest
{
  public partial class DataBlock : UserControl
  {
    // 控件的主要组件
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label valueLabel;
    private int cornerRadius = 10; // 默认圆角半径

    // 标题属性
    public string Title
    {
      get { return titleLabel.Text; }
      set { titleLabel.Text = value; }
    }

    // 值属性
    public string Value
    {
      get { return valueLabel.Text; }
      set { valueLabel.Text = value; }
    }

    // 圆角半径属性
    public int CornerRadius
    {
      get { return cornerRadius; }
      set
      {
        cornerRadius = value;
        Invalidate(); // 重绘控件
      }
    }

    // 构造函数
    public DataBlock()
    {
      InitializeComponent();
      InitializeComponentTabPage3();
      SetupControls();
    }

    // 初始化组件
    private void InitializeComponentTabPage3()
    {
      this.titleLabel = new System.Windows.Forms.Label();
      this.valueLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // titleLabel
      // 
      this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top; // 改为 None 以允许自由定位
      this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titleLabel.Location = new System.Drawing.Point(10, 10); // 可以自由设置位置
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(150, 20);// 调整大小以适应新的位置
      this.titleLabel.TabIndex = 0;
      this.titleLabel.Text = "Title";
      this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;// 可以更改对齐方式
      this.titleLabel.Padding = new Padding(5, 5, 0, 0); // 添加左侧内边距
      // 
      // valueLabel
      // 
      this.valueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.valueLabel.Location = new System.Drawing.Point(0, 20);
      this.valueLabel.Name = "valueLabel";
      this.valueLabel.Size = new System.Drawing.Size(150, 30);
      this.valueLabel.TabIndex = 1;
      this.valueLabel.Text = "Value";
      this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // DataBlock
      // 
      this.Controls.Add(this.valueLabel);
      this.Controls.Add(this.titleLabel);
      this.Name = "DataBlock";
      this.Size = new System.Drawing.Size(150, 50);
      this.ResumeLayout(false);
    }

    // 设置额外的控件属性
    private void SetupControls()
    {
      // 可以在这里添加额外的控件设置
    }

    // 设置控件的整体样式
    public void SetStyle(Color backColor, Color foreColor, Font font)
    {
      this.BackColor = backColor;
      this.ForeColor = foreColor;
      this.valueLabel.Font = font;
    }

    // 设置标题的样式
    public void SetTitleStyle(Color foreColor, Font font, ContentAlignment alignment)
    {
      this.titleLabel.ForeColor = foreColor;
      this.titleLabel.Font = font;
      this.titleLabel.TextAlign = alignment;
    }

    // 重写绘制方法以实现圆角效果
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      using (GraphicsPath path = new GraphicsPath())
      {
        // 创建圆角矩形路径
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
        path.AddArc(Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
        path.AddArc(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
        path.AddArc(0, Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
        path.CloseAllFigures();

        // 设置控件区域为圆角矩形
        this.Region = new Region(path);

        // 使用控件的背景色填充路径
        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
          e.Graphics.FillPath(brush, path);
        }
      }
    }
    // 添加 DataBlock_Load 事件处理程序
    private void DataBlock_Load(object sender, EventArgs e)
    {
      // 在这里添加控件加载时需要执行的代码
    }



  }
}