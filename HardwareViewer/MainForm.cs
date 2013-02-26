using System;
using System.Collections.Generic;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HardwareViewer
{
    public partial class MainForm : Form
    {
        #region PInvoke Function

        public const int INVALID_HANDLE_VALUE = -1;
        public const int WAIT_TIMEOUT = 258;


        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public int lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        public delegate void CreateThreadProc(IntPtr lpPara);

        [DllImport("Kernel32.dll")]
        public static extern IntPtr CreateThread(ref SECURITY_ATTRIBUTES SecurityAttributes,
            uint StackSize, ThreadStart StartFunction, IntPtr ThreadParameter,
            uint CreationFlags, out uint ThreadId);

        [DllImport("Kernel32.dll")]
        public static extern IntPtr CreateThread(ref SECURITY_ATTRIBUTES SecurityAttributes,
            uint StackSize, CreateThreadProc StartFunction, IntPtr ThreadParameter,
            uint CreationFlags, out uint ThreadId);

        [DllImport("Kernel32.dll")]
        public static extern bool TerminateThread(IntPtr hThread, uint dwExitCode);

        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        #endregion


        /// <summary>
        /// WMI PropertyData 数据格式
        /// </summary>
        public struct WMIPropertyData
        {
            public Object WMIPropertyDataName;
            public Object WMIPropertyDataValue;
        }

        /// <summary>
        /// WMIObj 数据格式
        /// </summary>
        public struct WMIObjData
        {
            public String WMIObjName;
            public List<WMIPropertyData> WMIPropertyDataList;
        }

        /// <summary>
        /// WMI 数据
        /// </summary>
        private static List<WMIObjData> wmiObjDataList = new List<WMIObjData>();



        
        /// <summary>
        /// 构造函数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 窗体加载事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            cbBoxMajorWin32Class.Items.Clear();
            foreach (KeyValuePair<String, Dictionary<String, String[]>> keyValue in Win32ClassesEntity.Win32Classes_Desc)
            {
                cbBoxMajorWin32Class.Items.Add(keyValue.Key);
            }
            if(cbBoxMajorWin32Class.Items.Count > 0)
            {
                cbBoxMajorWin32Class.SelectedIndex = 0;
            }
        }


        /// <summary>
        /// 读取 WMI 数据
        /// </summary>
        /// <param name="lpPara"></param>
        public static void ReadWMIObjectThreadProc(IntPtr lpPara)
        {
            String strWin32Class = Marshal.PtrToStringBSTR(lpPara);

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + strWin32Class);
                foreach (ManagementObject mngObj in searcher.Get())
                {
                    WMIObjData wmiObjData = new WMIObjData();
                    try
                    {
                        wmiObjData.WMIObjName = mngObj["Name"].ToString();
                    }
                    catch
                    {
                        wmiObjData.WMIObjName = mngObj.ToString();mngObj.ToString();
                    }

                    if (mngObj.Properties.Count <= 0)
                    {
                        return;
                    }

                    List<WMIPropertyData> wmiPropertyDataLisy = new List<WMIPropertyData>();
                    foreach (PropertyData propertyData in mngObj.Properties)
                    {
                        WMIPropertyData wmiPropertyData = new WMIPropertyData();
                        wmiPropertyData.WMIPropertyDataName = propertyData.Name;
                        if (propertyData.Value != null && propertyData.Value.ToString() != "")
                        {
                            wmiPropertyData.WMIPropertyDataValue = propertyData.Value;
                        }
                        else
                        {
                            wmiPropertyData.WMIPropertyDataValue = "Null Data";
                        }

                        wmiPropertyDataLisy.Add(wmiPropertyData);
                    }

                    wmiObjData.WMIPropertyDataList = wmiPropertyDataLisy;

                    wmiObjDataList.Add(wmiObjData);
                }
            }
            catch (Exception ex)
            {
                
            }
        }


        /// <summary>
        /// 重新绑定 ListView 上的数据
        /// </summary>
        /// <param name="strWin32Class"></param>
        /// <returns></returns>
        private bool RefreshWMIData(String strWin32Class)
        {
            bool bResult = false;

            uint dwThreadId = 0;
            IntPtr hPara = Marshal.StringToBSTR(strWin32Class);
            SECURITY_ATTRIBUTES sa = new SECURITY_ATTRIBUTES();

            IntPtr hThread = CreateThread(ref sa, 0, ReadWMIObjectThreadProc, hPara, 0, out dwThreadId);
            if (IntPtr.Zero != hThread && INVALID_HANDLE_VALUE != hThread.ToInt32())
            {
                /* 等待 20 秒 */
                if (WAIT_TIMEOUT == WaitForSingleObject(hThread, 20000))
                {
                    bResult = false;
                }
                else
                {
                    bResult = true;
                }

                TerminateThread(hThread, 0);
            }

            Marshal.FreeBSTR(hPara);

            return bResult;
        }


        /// <summary>
        /// 重新绑定 ListView 上的数据
        /// </summary>
        /// <param name="strWin32Class"></param>
        /// <param name="lv"></param>
        /// <param name="bNullShow"></param>
        private void ReBindData2ListView(String strWin32Class, ref ListView lv, bool bNullShow)
        {
            lv.Items.Clear();
            wmiObjDataList.Clear();

            try
            {
                if (RefreshWMIData(strWin32Class) == false)
                {
                    MessageBox.Show("Sorry，WMI Query TimeOut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (wmiObjDataList.Count > 0)
                {
                    foreach (WMIObjData wmiObjData in wmiObjDataList)
                    {
                        ListViewGroup lvGrp;
                        lvGrp = lv.Groups.Add(wmiObjData.WMIObjName, wmiObjData.WMIObjName);

                        if (wmiObjData.WMIPropertyDataList.Count <= 0)
                        {
                            MessageBox.Show("Null Data", "Null Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return;
                        }

                        foreach (WMIPropertyData wmiPropertyData in wmiObjData.WMIPropertyDataList)
                        {
                            ListViewItem item = new ListViewItem(lvGrp);
                            if (lv.Items.Count % 2 != 0)
                            {
                                item.BackColor = Color.White;
                            }
                            else
                            {
                                item.BackColor = Color.WhiteSmoke;
                            }

                            item.Text = wmiPropertyData.WMIPropertyDataName.ToString();

                            if (wmiPropertyData.WMIPropertyDataValue.ToString() != "Null Data")
                            {
                                switch (wmiPropertyData.WMIPropertyDataValue.GetType().ToString())
                                {
                                    case "System.String[]":
                                        {
                                            String[] strValue = (String[])wmiPropertyData.WMIPropertyDataValue;

                                            String strItem = "";
                                            foreach (String str in strValue)
                                            {
                                                strItem += str + " ";
                                            }

                                            item.SubItems.Add(strItem);

                                            break;
                                        }
                                    case "System.UInt16[]":
                                        {
                                            ushort[] ushortValue = (ushort[])wmiPropertyData.WMIPropertyDataValue;

                                            String strItem = "";
                                            foreach (ushort u in ushortValue)
                                            {
                                                strItem += u.ToString() + " ";
                                            }

                                            item.SubItems.Add(strItem);

                                            break;
                                        }
                                    default:
                                        {
                                            item.SubItems.Add(wmiPropertyData.WMIPropertyDataValue.ToString());
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                if (!bNullShow)
                                {
                                    item.SubItems.Add("Null Data");
                                }
                                else
                                {
                                    continue;
                                }
                            }

                            lv.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Sorry，Error Message: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 移除空数据
        /// </summary>
        /// <param name="lv"></param>
        private void RemoveNullValue(ref ListView lv)
        {
            foreach (ListViewItem item in lv.Items)
            {
                if (item.SubItems[1].Text == "Null Data")
                {
                    item.Remove();
                }
            }
        }


        /// <summary>
        /// 是否显示空数据复选框选择事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckBoxShowNull_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxShowNull.Checked == true)
            {
                RemoveNullValue(ref lvHardware);
            }
            else
            {
                String strWin32Class = cbBoxChildWin32Class.SelectedItem.ToString();

                /* 显示加载窗口 */
                Loading loadForm = new Loading(this.Location, this.Size);
                loadForm.Show();

                Application.DoEvents();

                ReBindData2ListView(strWin32Class, ref lvHardware, ckBoxShowNull.Checked);

                loadForm.Close();
            }
        }


        /// <summary>
        /// Major Win32 Class 选择事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxMajorWin32Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxMajorWin32Class.SelectedIndex >= 0 && cbBoxMajorWin32Class.SelectedItem != null)
            {
                String strMajor = cbBoxMajorWin32Class.SelectedItem.ToString();
                if(Win32ClassesEntity.Win32Classes_Desc.ContainsKey(strMajor) ==  true)
                {
                    cbBoxMinorWin32Class.Items.Clear();

                    Dictionary<String, String[]> majorWin32Class = Win32ClassesEntity.Win32Classes_Desc[strMajor];
                    foreach(KeyValuePair<String, String[]> keyValue in majorWin32Class)
                    {
                        cbBoxMinorWin32Class.Items.Add(keyValue.Key);
                    }

                    if(cbBoxMinorWin32Class.Items.Count > 0)
                    {
                        cbBoxMinorWin32Class.SelectedIndex = 0;
                    }
                }
            }
        }


        /// <summary>
        /// Minor Win32 Class 选择事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxMinorWin32Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxMajorWin32Class.SelectedIndex >= 0 && cbBoxMajorWin32Class.SelectedItem != null)
            {
                if (cbBoxMinorWin32Class.SelectedIndex >= 0 && cbBoxMinorWin32Class.SelectedItem != null)
                {
                    String strMajor = cbBoxMajorWin32Class.SelectedItem.ToString();
                    String strMinor = cbBoxMinorWin32Class.SelectedItem.ToString();
                    if (Win32ClassesEntity.Win32Classes_Desc.ContainsKey(strMajor) == true)
                    {
                        if (Win32ClassesEntity.Win32Classes_Desc[strMajor].ContainsKey(strMinor) == true)
                        {
                            cbBoxChildWin32Class.Items.Clear();

                            String[] minorWin32Class = Win32ClassesEntity.Win32Classes_Desc[strMajor][strMinor];
                            foreach (String strWin32Class in minorWin32Class)
                            {
                                cbBoxChildWin32Class.Items.Add(strWin32Class);
                            }

                            if (cbBoxChildWin32Class.Items.Count > 0)
                            {
                                cbBoxChildWin32Class.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Child Win32 Class 选择事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxChildWin32Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvHardware.Items.Clear();

            if (cbBoxMajorWin32Class.SelectedIndex >= 0 && cbBoxMajorWin32Class.SelectedItem != null)
            {
                if (cbBoxMinorWin32Class.SelectedIndex >= 0 && cbBoxMinorWin32Class.SelectedItem != null)
                {
                    if (cbBoxChildWin32Class.SelectedIndex >= 0 && cbBoxChildWin32Class.SelectedItem != null)
                    {
                        String strWin32Class = cbBoxChildWin32Class.SelectedItem.ToString();

                        /* 显示加载窗口 */
                        Loading loadForm = new Loading(this.Location, this.Size);
                        loadForm.Show();

                        Application.DoEvents();

                        ReBindData2ListView(strWin32Class, ref lvHardware, ckBoxShowNull.Checked);

                        loadForm.Close();
                    }
                }
            }
        }
    }
}
