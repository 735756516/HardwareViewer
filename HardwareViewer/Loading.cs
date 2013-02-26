using System;
using System.Drawing;
using System.Windows.Forms;

namespace HardwareViewer
{
    public partial class Loading : Form
    {
        /// <summary>
        /// 定义 X，Y 坐标
        /// </summary>
        private Int32 nMainXPosition = 0;
        private Int32 nMainYPosition = 0;

        /// <summary>
        /// 定义宽度和高度
        /// </summary>
        private Int32 nMainWidth = 0;
        private Int32 nMainHeight = 0;


        /// <summary>
        /// 构造函数
        /// </summary>
        public Loading(Point mainLocation, Size mainSize)
        {
            InitializeComponent();

            this.nMainXPosition = mainLocation.X;
            this.nMainYPosition = mainLocation.Y;

            this.nMainWidth = mainSize.Width;
            this.nMainHeight = mainSize.Height;
        }


        /// <summary>
        /// 窗体加载事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loading_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.nMainXPosition + (this.nMainWidth - this.Size.Width) / 2, nMainYPosition + (this.nMainHeight - this.Size.Height) / 2);
        }
    }
}
