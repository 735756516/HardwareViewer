using System.Collections.Generic;
using System;

namespace HardwareViewer
{
    public class Win32ClassesEntity
    {
        #region Win32Classes_ComputerSystemHardware

        /// <summary>
        /// The Cooling Devices subcategory groups classes that represent instrumentable fans, temperature probes, and refrigeration devices.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_CoolingDevice = new String[]
        {
            "Win32_Fan",
            "Win32_HeatPipe",
            "Win32_Refrigeration",
            "Win32_TemperatureProbe"
        };

        /// <summary>
        /// The Input Devices subcategory groups classes that represent keyboards and pointing devices.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_InputDevice = new String[]
        {
            "Win32_Keyboard",
            "Win32_PointingDevice"
        };

        /// <summary>
        /// Classes in the Mass Storage subcategory represent storage devices such as hard disk drives, CD-ROM drives, and tape drives.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_MassStorage = new String[]
        {
            "Win32_AutochkSetting",
            "Win32_CDROMDrive",
            "Win32_DiskDrive",
            "Win32_FloppyDrive",
            "Win32_PhysicalMedia",
            "Win32_TapeDrive"
        };

        /// <summary>
        /// The Motherboard, Controllers, and Ports subcategory groups classes that represent system devices. Examples include system memory, cache memory, and controllers.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_MotherboardControllerPort = new String[]
        {
            "Win32_1394Controller",
            "Win32_1394ControllerDevice",
            "Win32_AllocatedResource",
            "Win32_AssociatedProcessorMemory",
            "Win32_BaseBoard",
            "Win32_BIOS",
            "Win32_Bus",
            "Win32_CacheMemory",
            "Win32_ControllerHasHub",
            "Win32_DeviceBus",
            "Win32_DeviceMemoryAddress",
            "Win32_DeviceSettings",
            "Win32_DMAChannel",
            "Win32_FloppyController",
            "Win32_IDEController",
            "Win32_IDEControllerDevice",
            "Win32_InfraredDevice",
            "Win32_IRQResource",
            "Win32_MemoryArray",
            "Win32_MemoryArrayLocation",
            "Win32_MemoryDevice",
            "Win32_MemoryDeviceArray",
            "Win32_MemoryDeviceLocation",
            "Win32_MotherboardDevice",
            "Win32_OnBoardDevice",
            "Win32_ParallelPort",
            "Win32_PCMCIAController",
            "Win32_PhysicalMemory",
            "Win32_PhysicalMemoryLocation",
            "Win32_PNPAllocatedResource",
            "Win32_PNPDevice",
            "Win32_PNPEntity",
            "Win32_PortConnector",
            "Win32_PortResource",
            "Win32_Processor",
            "Win32_SCSIController",
            "Win32_SCSIControllerDevice",
            "Win32_SerialPort",
            "Win32_SerialPortConfiguration",
            "Win32_SerialPortSetting",
            "Win32_SMBIOSMemory",
            "Win32_SoundDevice",
            "Win32_SystemBIOS",
            "Win32_SystemDriverPNPEntity",
            "Win32_SystemEnclosure",
            "Win32_SystemMemoryResource",
            "Win32_SystemSlot",
            "Win32_USBController",
            "Win32_USBControllerDevice",
            "Win32_USBHub"
        };

        /// <summary>
        /// The Networking Devices subcategory groups classes that represent the network interface controller, its configurations, and its settings.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_NetworkingDevice = new String[]
        {
            "Win32_NetworkAdapter",
            "Win32_NetworkAdapterConfiguration",
            "Win32_NetworkAdapterSetting"
        };

        /// <summary>
        /// The Power subcategory groups classes that represent power supplies, batteries, and events related to these devices.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_Power = new String[]
        {
            "Win32_AssociatedBattery",
            "Win32_Battery",
            "Win32_CurrentProbe",
            "Win32_PortableBattery",
            "Win32_PowerManagementEvent",
            "Win32_UninterruptiblePowerSupply",
            "Win32_VoltageProbe"
        };

        /// <summary>
        /// The Printing subcategory groups classes that represent printers, printer configurations, and print jobs.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_Printing = new String[]
        {
            "Win32_DriverForDevice",
            "Win32_Printer",
            "Win32_PrinterConfiguration",
            "Win32_PrinterController",
            "Win32_PrinterDriver",
            "Win32_PrinterDriverDll",
            "Win32_PrinterSetting",
            "Win32_PrintJob",
            "Win32_TCPIPPrinterPort"
        };

        /// <summary>
        /// The Telephony subcategory groups classes that represent "plain old telephone" modem devices and their associated serial connections.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_Telephony = new String[]
        {
            "Win32_POTSModem",
            "Win32_POTSModemToSerialPort"
        };

        /// <summary>
        /// The Video and Monitors subcategory groups classes that represent monitors, video cards, and their associated settings.
        /// </summary>
        private readonly static String[] Win32Classes_ComputerSystemHardware_VideoMonitor = new String[]
        {
            "Win32_DesktopMonitor",
            "Win32_DisplayConfiguration",
            "Win32_DisplayControllerConfiguration",
            "Win32_VideoConfiguration",
            "Win32_VideoController",
            "Win32_VideoSettings"
        };

        #endregion


        #region Win32Classes_InstalledApplications

        private readonly static String[] Win32Classes_InstalledApplications_Common = new String[]
        {
            "Win32_ProductSoftwareFeatures",
            "Win32_Property",
            "Win32_Product",
            "Win32_Binary",
            "Win32_ActionCheck",
            "Win32_ApplicationCommandLine",
            "Win32_ApplicationService",
            "Win32_BindImageAction",
            "Win32_CheckCheck",
            "Win32_ClassInfoAction",
            "Win32_CommandLineAccess",
            "Win32_Condition",
            "Win32_CreateFolderAction",
            "Win32_DuplicateFileAction",
            "Win32_EnvironmentSpecification",
            "Win32_ExtensionInfoAction",
            "Win32_FileSpecification",
            "Win32_FontInfoAction",
            "Win32_IniFileSpecification",
            "Win32_InstalledSoftwareElement",
            "Win32_LaunchCondition",
            "Win32_ManagedSystemElementResource",
            "Win32_MIMEInfoAction",
            "Win32_MoveFileAction",
            "Win32_MSIResource",
            "Win32_ODBCAttribute",
            "Win32_ODBCDataSourceAttribute",
            "Win32_ODBCDataSourceSpecification",
            "Win32_ODBCDriverAttribute",
            "Win32_ODBCDriverSoftwareElement",
            "Win32_ODBCDriverSpecification",
            "Win32_ODBCSourceAttribute",
            "Win32_ODBCTranslatorSpecification",
            "Win32_Patch",
            "Win32_PatchFile",
            "Win32_PatchPackage",
            "Win32_ProductCheck",
            "Win32_ProductResource",
            "Win32_ProgIDSpecification",
            "Win32_PublishComponentAction",
            "Win32_RegistryAction",
            "Win32_RemoveFileAction",
            "Win32_RemoveIniAction",
            "Win32_ReserveCost",
            "Win32_SelfRegModuleAction",
            "Win32_ServiceControl",
            "Win32_ServiceSpecification",
            "Win32_ServiceSpecificationService",
            "Win32_SettingCheck",
            "Win32_ShortcutAction",
            "Win32_ShortcutSAP",
            "Win32_SoftwareElement",
            "Win32_SoftwareElementAction",
            "Win32_SoftwareElementCheck",
            "Win32_SoftwareElementCondition",
            "Win32_SoftwareElementResource",
            "Win32_SoftwareFeature",
            "Win32_SoftwareFeatureAction",
            "Win32_SoftwareFeatureCheck",
            "Win32_SoftwareFeatureParent",
            "Win32_SoftwareFeatureSoftwareElements",
            "Win32_TypeLibraryAction"
        };

        #endregion


        #region Win32Classes_OperatingSystem

        /// <summary>
        /// The COM subcategory groups classes that represent COM and DCOM settings, classes, and client application settings.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Com = new String[]
        {
            "Win32_ClassicCOMApplicationClasses",
            "Win32_ClassicCOMClass",
            "Win32_ClassicCOMClassSettings",
            "Win32_ClientApplicationSetting",
            "Win32_COMApplication",
            "Win32_COMApplicationClasses",
            "Win32_COMApplicationSettings",
            "Win32_COMClass",
            "Win32_ComClassAutoEmulator",
            "Win32_ComClassEmulator",
            "Win32_ComponentCategory",
            "Win32_COMSetting",
            "Win32_DCOMApplication",
            "Win32_DCOMApplicationAccessAllowedSetting",
            "Win32_DCOMApplicationLaunchAllowedSetting",
            "Win32_DCOMApplicationSetting",
            "Win32_ImplementedCategory"
        };

        /// <summary>
        /// The Desktop subcategory groups classes that represent objects that define a specific desktop configuration.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Desktop = new String[]
        {
            "Win32_Desktop",
            "Win32_Environment",
            "Win32_TimeZone",
            "Win32_UserDesktop"
        };

        /// <summary>
        /// The Drivers subcategory groups classes that represent virtual device drivers and system drivers for base services.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Drivers = new String[]
        {
            "Win32_DriverVXD",
            "Win32_SystemDriver"
        };

        /// <summary>
        /// The File System subcategory groups classes that represent the way a hard disk is logically arranged. 
        /// This includes the type of file system used, the directory structure, and way the disk is partitioned.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_FileSystem = new String[]
        {
            "Win32_CIMLogicalDeviceCIMDataFile",
            "Win32_Directory",
            "Win32_DirectorySpecification",
            "Win32_DiskDriveToDiskPartition",
            "Win32_DiskPartition",
            "Win32_DiskQuota",
            "Win32_LogicalDisk",
            "Win32_LogicalDiskRootDirectory",
            "Win32_LogicalDiskToPartition",
            "Win32_MappedLogicalDisk",
            "Win32_OperatingSystemAutochkSetting",
            "Win32_QuotaSetting",
            "Win32_ShortcutFile",
            "Win32_SubDirectory",
            "Win32_SystemPartitions",
            "Win32_Volume",
            "Win32_VolumeQuota",
            "Win32_VolumeQuotaSetting",
            "Win32_VolumeUserQuota"
        };

        /// <summary>
        /// The Job Objects subcategory groups classes that represent classes that provide the means of instrumenting named job objects. 
        /// An unnamed job object cannot be instrumented.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_JobObjects = new String[]
        {
            "Win32_CollectionStatistics",
            "Win32_LUID",
            "Win32_LUIDandAttributes",
            "Win32_NamedJobObject",
            "Win32_NamedJobObjectActgInfo",
            "Win32_NamedJobObjectLimit",
            "Win32_NamedJobObjectLimitSetting",
            "Win32_NamedJobObjectProcess",
            "Win32_NamedJobObjectSecLimit",
            "Win32_NamedJobObjectSecLimitSetting",
            "Win32_NamedJobObjectStatistics",
            "Win32_SIDandAttributes",
            "Win32_TokenGroups",
            "Win32_TokenPrivileges"
        };

        /// <summary>
        /// The Memory and Page files subcategory groups classes that represent page file configuration settings.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_MemoryPageFiles = new String[]
        {
            "Win32_LogicalMemoryConfiguration",
            "Win32_PageFile",
            "Win32_PageFileElementSetting",
            "Win32_PageFileSetting",
            "Win32_PageFileUsage",
            "Win32_SystemLogicalMemoryConfiguration"
        };

        /// <summary>
        /// The class in the Multimedia Audio or Visual subcategory represents properties of the audio or video codec installed on the computer system.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_MultimediaAudioVisual = new String[]
        {
            "Win32_CodecFile"
        };

        /// <summary>
        /// The Networking subcategory groups classes that represent network connections, network clients, and network connection settings such as the protocol used.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Networking = new String[]
        {
            "Win32_ActiveRoute",
            "Win32_IP4PersistedRouteTable",
            "Win32_IP4RouteTable",
            "Win32_IP4RouteTableEvent",
            "Win32_NetworkClient",
            "Win32_NetworkConnection",
            "Win32_NetworkProtocol",
            "Win32_NTDomain",
            "Win32_PingStatus",
            "Win32_ProtocolBinding"
        };

        /// <summary>
        /// The Operating System Events subcategory groups classes that represent events in the operating system related to processes, threads, and system shutdown.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_OperatingSystemEvents = new String[]
        {
            "Win32_ComputerShutdownEvent",
            "Win32_ComputerSystemEvent",
            "Win32_DeviceChangeEvent",
            "Win32_ModuleLoadTrace",
            "Win32_ModuleTrace",
            "Win32_ProcessStartTrace",
            "Win32_ProcessStopTrace",
            "Win32_ProcessTrace",
            "Win32_SystemConfigurationChangeEvent",
            "Win32_SystemTrace",
            "Win32_ThreadStartTrace",
            "Win32_ThreadStopTrace",
            "Win32_ThreadTrace",
            "Win32_VolumeChangeEvent"
        };

        /// <summary>
        /// The Operating System Settings subcategory groups classes that represent the Operating System and its settings.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_OperatingSystemSettings = new String[]
        {
            "Win32_BootConfiguration",
            "Win32_ComputerSystem",
            "Win32_ComputerSystemProcessor",
            "Win32_ComputerSystemProduct",
            "Win32_DependentService",
            "Win32_LoadOrderGroup",
            "Win32_LoadOrderGroupServiceDependencies",
            "Win32_LoadOrderGroupServiceMembers",
            "Win32_OperatingSystem",
            "Win32_OperatingSystemQFE",
            "Win32_OSRecoveryConfiguration",
            "Win32_QuickFixEngineering",
            "Win32_StartupCommand",
            "Win32_SystemBootConfiguration",
            "Win32_SystemDesktop",
            "Win32_SystemDevices",
            "Win32_SystemLoadOrderGroups",
            "Win32_SystemNetworkConnections",
            "Win32_SystemOperatingSystem",
            "Win32_SystemProcesses",
            "Win32_SystemProgramGroups",
            "Win32_SystemResources",
            "Win32_SystemServices",
            "Win32_SystemSetting",
            "Win32_SystemSystemDriver",
            "Win32_SystemTimeZone",
            "Win32_SystemUsers"
        };

        /// <summary>
        /// The Processes subcategory groups classes that represent system processes and threads.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Processes = new String[]
        {
            "Win32_Process",
            "Win32_ProcessStartup",
            "Win32_Thread"
        };

        /// <summary>
        /// The class in the Registry subcategory represents the contents of the Windows registry.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Registry = new String[]
        {
            "Win32_Registry"
        };

        /// <summary>
        /// The Scheduler Jobs subcategory groups classes that represent scheduled job settings.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_SchedulerJobs = new String[]
        {
            "Win32_CurrentTime",
            "Win32_ScheduledJob",
            "Win32_LocalTime",
            "Win32_UTCTime"
        };

        /// <summary>
        /// The Security subcategory groups classes that represent system security settings.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Security = new String[]
        {
            "Win32_AccountSID",
            "Win32_ACE",
            "Win32_LogicalFileAccess",
            "Win32_LogicalFileAuditing",
            "Win32_LogicalFileGroup",
            "Win32_LogicalFileOwner",
            "Win32_LogicalFileSecuritySetting",
            "Win32_LogicalShareAccess",
            "Win32_LogicalShareAuditing",
            "Win32_LogicalShareSecuritySetting",
            "Win32_PrivilegesStatus",
            "Win32_SecurityDescriptor",
            "Win32_SecuritySetting",
            "Win32_SecuritySettingAccess",
            "Win32_SecuritySettingAuditing",
            "Win32_SecuritySettingGroup",
            "Win32_SecuritySettingOfLogicalFile",
            "Win32_SecuritySettingOfLogicalShare",
            "Win32_SecuritySettingOfObject",
            "Win32_SecuritySettingOwner",
            "Win32_SID",
            "Win32_Trustee"
        };

        /// <summary>
        /// The Services subcategory groups classes that represent services and base services.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Services = new String[]
        {
            "Win32_BaseService",
            "Win32_Service"
        };

        /// <summary>
        /// The Shares subcategory groups classes that represent details of shared resources, such as printers and folders.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Shares = new String[]
        {
            "Win32_DFSNode",
            "Win32_DFSNodeTarget",
            "Win32_DFSTarget",
            "Win32_ServerConnection",
            "Win32_ServerSession",
            "Win32_ConnectionShare",
            "Win32_PrinterShare",
            "Win32_SessionConnection",
            "Win32_SessionProcess",
            "Win32_ShareToDirectory",
            "Win32_Share"
        };

        /// <summary>
        /// The Start Menu subcategory groups classes that represent program groups.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_StartMenu = new String[]
        {
            "Win32_LogicalProgramGroup",
            "Win32_LogicalProgramGroupDirectory",
            "Win32_LogicalProgramGroupItem",
            "Win32_LogicalProgramGroupItemDataFile",
            "Win32_ProgramGroup",
            "Win32_ProgramGroupContents",
            "Win32_ProgramGroupOrItem"
        };

        /// <summary>
        /// The Users subcategory groups classes that represent storage information.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Storage = new String[]
        {
            "Win32_ShadowBy",
            "Win32_ShadowContext",
            "Win32_ShadowCopy",
            "Win32_ShadowDiffVolumeSupport",
            "Win32_ShadowFor",
            "Win32_ShadowOn",
            "Win32_ShadowProvider",
            "Win32_ShadowStorage",
            "Win32_ShadowVolumeSupport",
            "Win32_Volume",
            "Win32_VolumeUserQuota"
        };

        /// <summary>
        /// The Users subcategory groups classes that represent user account information, such as group membership details.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_Users = new String[]
        {
            "Win32_Account",
            "Win32_Group",
            "Win32_GroupInDomain",
            "Win32_GroupUser",
            "Win32_LogonSession",
            "Win32_LogonSessionMappedDisk",
            "Win32_NetworkLoginProfile",
            "Win32_SystemAccount",
            "Win32_UserAccount",
            "Win32_UserInDomain"
        };

        /// <summary>
        /// The Windows NT Event Log subcategory groups classes that represent events, event log entries, event log configuration settings, and so on.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_WindowsNTEventLog = new String[]
        {
            "Win32_NTEventlogFile",
            "Win32_NTLogEvent",
            "Win32_NTLogEventComputer",
            "Win32_NTLogEventLog",
            "Win32_NTLogEventUser"
        };

        /// <summary>
        /// Windows Product Activation (WPA) is an antipiracy technology to reduce the casual copying of software.
        /// </summary>
        private readonly static String[] Win32Classes_OperatingSystem_WindowsProductActivation = new String[]
        {
            "Win32_ComputerSystemWindowsProductActivationSetting",
            "Win32_Proxy",
            "Win32_WindowsProductActivation"
        };

        #endregion


        #region Win32Classes_PerformanceCounter

        /// <summary>
        /// The following table lists the formatted performance counter classes.
        /// </summary>
        private readonly static String[] Win32Classes_PerformanceCounter_FormattedPerformanceCounter = new String[]
        {
            "Win32_PerfFormattedData",
            "Win32_PerfFormattedData_ASP_ActiveServerPages",
            "Win32_PerfFormattedData_ContentFilter_IndexingServiceFilter",
            "Win32_PerfFormattedData_ContentIndex_IndexingService",
            "Win32_PerfFormattedData_InetInfo_InternetInformationServicesGlobal",
            "Win32_PerfFormattedData_ISAPISearch_HttpIndexingService",
            "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator",
            "Win32_PerfFormattedData_NTFSDRV_SMTPNTFSStoreDriver",
            "Win32_PerfFormattedData_PerfDisk_LogicalDisk",
            "Win32_PerfFormattedData_PerfDisk_PhysicalDisk",
            "Win32_PerfFormattedData_PerfNet_Browser",
            "Win32_PerfFormattedData_PerfNet_Redirector",
            "Win32_PerfFormattedData_PerfNet_Server",
            "Win32_PerfFormattedData_PerfNet_ServerWorkQueues",
            "Win32_PerfFormattedData_PerfOS_Cache",
            "Win32_PerfFormattedData_PerfOS_Memory",
            "Win32_PerfFormattedData_PerfOS_Objects",
            "Win32_PerfFormattedData_PerfOS_PagingFile",
            "Win32_PerfFormattedData_PerfOS_Processor",
            "Win32_PerfFormattedData_PerfOS_System",
            "Win32_PerfFormattedData_PerfProc_FullImage_Costly",
            "Win32_PerfFormattedData_PerfProc_Image_Costly",
            "Win32_PerfFormattedData_PerfProc_JobObject",
            "Win32_PerfFormattedData_PerfProc_JobObjectDetails",
            "Win32_PerfFormattedData_PerfProc_Process",
            "Win32_PerfFormattedData_PerfProc_ProcessAddressSpace_Costly",
            "Win32_PerfFormattedData_PerfProc_Thread",
            "Win32_PerfFormattedData_PerfProc_ThreadDetails_Costly",
            "Win32_PerfFormattedData_PSched_PSchedFlow",
            "Win32_PerfFormattedData_PSched_PSchedPipe",
            "Win32_PerfFormattedData_RemoteAccess_RASPort",
            "Win32_PerfFormattedData_RemoteAccess_RASTotal",
            "Win32_PerfFormattedData_RSVP_ACSRSVPInterfaces",
            "Win32_PerfFormattedData_RSVP_ACSRSVPService",
            "Win32_PerfFormattedData_SMTPSVC_SMTPServer",
            "Win32_PerfFormattedData_Spooler_PrintQueue",
            "Win32_PerfFormattedData_TapiSrv_Telephony",
            "Win32_PerfFormattedData_Tcpip_ICMP",
            "Win32_PerfFormattedData_Tcpip_IP",
            "Win32_PerfFormattedData_Tcpip_NBTConnection",
            "Win32_PerfFormattedData_Tcpip_NetworkInterface",
            "Win32_PerfFormattedData_Tcpip_TCP",
            "Win32_PerfFormattedData_Tcpip_UDP",
            "Win32_PerfFormattedData_TermService_TerminalServices",
            "Win32_PerfFormattedData_TermService_TerminalServicesSession",
            "Win32_PerfFormattedData_W3SVC_WebService"
        };

        /// <summary>
        /// The following table lists the raw performance counter classes.
        /// </summary>
        private readonly static String[] Win32Classes_PerformanceCounter_RawPerformanceCounter = new String[]
        {
            "Win32_PerfRawData",
            "Win32_PerfRawData_ASP_ActiveServerPages",
            "Win32_PerfRawData_ContentFilter_IndexingServiceFilter",
            "Win32_PerfRawData_ContentIndex_IndexingService",
            "Win32_PerfRawData_InetInfo_InternetInformationServicesGlobal",
            "Win32_PerfRawData_ISAPISearch_HttpIndexingService",
            "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator",
            "Win32_PerfRawData_NTFSDRV_SMTPNTFSStoreDriver",
            "Win32_PerfRawData_PerfDisk_LogicalDisk",
            "Win32_PerfRawData_PerfDisk_PhysicalDisk",
            "Win32_PerfRawData_PerfNet_Browser",
            "Win32_PerfRawData_PerfNet_Redirector",
            "Win32_PerfRawData_PerfNet_Server",
            "Win32_PerfRawData_PerfNet_ServerWorkQueues",
            "Win32_PerfRawData_PerfOS_Cache",
            "Win32_PerfRawData_PerfOS_Memory",
            "Win32_PerfRawData_PerfOS_Objects",
            "Win32_PerfRawData_PerfOS_PagingFile",
            "Win32_PerfRawData_PerfOS_Processor",
            "Win32_PerfRawData_PerfOS_System",
            "Win32_PerfRawData_PerfProc_FullImage_Costly",
            "Win32_PerfRawData_PerfProc_Image_Costly",
            "Win32_PerfRawData_PerfProc_JobObject",
            "Win32_PerfRawData_PerfProc_JobObjectDetails",
            "Win32_PerfRawData_PerfProc_Process",
            "Win32_PerfRawData_PerfProc_ProcessAddressSpace_Costly",
            "Win32_PerfRawData_PerfProc_Thread",
            "Win32_PerfRawData_PerfProc_ThreadDetails_Costly",
            "Win32_PerfRawData_PSched_PSchedFlow",
            "Win32_PerfRawData_PSched_PSchedPipe",
            "Win32_PerfRawData_RemoteAccess_RASPort",
            "Win32_PerfRawData_RemoteAccess_RASTotal",
            "Win32_PerfRawData_RSVP_ACSRSVPInterfaces",
            "Win32_PerfRawData_RSVP_ACSRSVPService",
            "Win32_PerfRawData_SMTPSVC_SMTPServer",
            "Win32_PerfRawData_Spooler_PrintQueue",
            "Win32_PerfRawData_TapiSrv_Telephony",
            "Win32_PerfRawData_Tcpip_ICMP",
            "Win32_PerfRawData_Tcpip_IP",
            "Win32_PerfRawData_Tcpip_NBTConnection",
            "Win32_PerfRawData_Tcpip_NetworkInterface",
            "Win32_PerfRawData_Tcpip_TCP",
            "Win32_PerfRawData_Tcpip_UDP",
            "Win32_PerfRawData_TermService_TerminalServices",
            "Win32_PerfRawData_TermService_TerminalServicesSession",
            "Win32_PerfRawData_W3SVC_WebService"
        };

        #endregion


        #region Win32Classes_WMIServiceManagement

        /// <summary>
        /// The WMI Configuration class derives methods that configure the WMI service.
        /// </summary>
        private readonly static String[] Win32Classes_WMIServiceManagement_WMIConfiguration = new String[]
        {
            "Win32_MethodParameterClass"
        };

        /// <summary>
        /// The WMI management classes represent operational parameters for the WMI service.
        /// </summary>
        private readonly static String[] Win32Classes_WMIServiceManagement_WMIManagement = new String[]
        {
            "Win32_WMISetting",
            "Win32_WMIElementSetting"
        };

        #endregion


        #region Win32Classes_Desc

        /// <summary>
        /// The Computer System Hardware category groups classes together that represent hardware related objects. 
        /// Examples include input devices, hard disks, expansion cards, video devices, networking devices, and system power.
        /// </summary>
        public readonly static String[][] Win32Classes_ComputerSystemHardware = new String[][]
        {
            Win32Classes_ComputerSystemHardware_CoolingDevice,
            Win32Classes_ComputerSystemHardware_InputDevice,
            Win32Classes_ComputerSystemHardware_MassStorage,
            Win32Classes_ComputerSystemHardware_MotherboardControllerPort,
            Win32Classes_ComputerSystemHardware_NetworkingDevice,
            Win32Classes_ComputerSystemHardware_Power,
            Win32Classes_ComputerSystemHardware_Printing,
            Win32Classes_ComputerSystemHardware_Telephony,
            Win32Classes_ComputerSystemHardware_VideoMonitor
        };

        /// <summary>
        /// Description
        /// </summary>
        public readonly static Dictionary<String, String[]> Win32Classes_ComputerSystemHardware_Desc = new Dictionary<String, String[]>
        {
            {"Cooling Device Classes", Win32Classes_ComputerSystemHardware_CoolingDevice},
            {"Input Device Classes", Win32Classes_ComputerSystemHardware_InputDevice},
            {"Mass Storage Classes", Win32Classes_ComputerSystemHardware_MassStorage},
            {"Motherboard, Controller, and Port Classes", Win32Classes_ComputerSystemHardware_MotherboardControllerPort},
            {"Networking Device Classes", Win32Classes_ComputerSystemHardware_NetworkingDevice},
            {"Power Classes", Win32Classes_ComputerSystemHardware_Power},
            {"Printing Classes", Win32Classes_ComputerSystemHardware_Printing},
            {"Telephony Classes", Win32Classes_ComputerSystemHardware_Telephony},
            {"Video and Monitor Classes", Win32Classes_ComputerSystemHardware_VideoMonitor}

        };
        



        /// <summary>
        /// The Installed applications category groups classes that represent software-related objects. 
        /// Access to these objects is supported by Windows Installer. 
        /// Examples of objects in this category are installed products, file specifications, registration actions, and so on.
        /// </summary>
        public readonly static String[][] Win32Classes_InstalledApplications = new String[][]
        {
            Win32Classes_InstalledApplications_Common
        };

        /// <summary>
        /// Description
        /// </summary>
        public readonly static Dictionary<String, String[]> Win32Classes_InstalledApplications_Desc = new Dictionary<String, String[]>
        {
            {"Installed Applications Classes", Win32Classes_InstalledApplications_Common}
        };




        /// <summary>
        /// The Operating System category groups classes that represent operating system related objects. 
        /// They denote the various configurations and settings that define a computing environment. 
        /// Examples include: the boot configuration, Component Object Model (COM) settings, desktop environment settings, drivers, security settings, user settings, and registry settings.
        /// </summary>
        public readonly static String[][] Win32Classes_OperatingSystem = new String[][]
        {
            Win32Classes_OperatingSystem_Com,
            Win32Classes_OperatingSystem_Desktop,
            Win32Classes_OperatingSystem_Drivers,
            Win32Classes_OperatingSystem_WindowsNTEventLog,
            Win32Classes_OperatingSystem_FileSystem,
            Win32Classes_OperatingSystem_JobObjects,
            Win32Classes_OperatingSystem_MemoryPageFiles,
            Win32Classes_OperatingSystem_MultimediaAudioVisual,
            Win32Classes_OperatingSystem_Networking,
            Win32Classes_OperatingSystem_OperatingSystemSettings,
            Win32Classes_OperatingSystem_OperatingSystemEvents,
            Win32Classes_OperatingSystem_Processes,
            Win32Classes_OperatingSystem_Registry,
            Win32Classes_OperatingSystem_SchedulerJobs,
            Win32Classes_OperatingSystem_Security,
            Win32Classes_OperatingSystem_Services,
            Win32Classes_OperatingSystem_Shares,
            Win32Classes_OperatingSystem_StartMenu,
            Win32Classes_OperatingSystem_Storage,
            Win32Classes_OperatingSystem_Users,
            Win32Classes_OperatingSystem_WindowsProductActivation
        };

        /// <summary>
        /// Description
        /// </summary>
        public readonly static Dictionary<String, String[]> Win32Classes_OperatingSystem_Desc = new Dictionary<String, String[]>
        {
            {"COM", Win32Classes_OperatingSystem_Com},
            {"Desktop", Win32Classes_OperatingSystem_Desktop},
            {"Drivers", Win32Classes_OperatingSystem_Drivers},
            {"Event log", Win32Classes_OperatingSystem_WindowsNTEventLog},
            {"File system", Win32Classes_OperatingSystem_FileSystem},
            {"Job objects", Win32Classes_OperatingSystem_JobObjects},
            {"Memory and page files", Win32Classes_OperatingSystem_MemoryPageFiles},
            {"Multimedia audio or visual", Win32Classes_OperatingSystem_MultimediaAudioVisual},
            {"Networking", Win32Classes_OperatingSystem_Networking},
            {"Operating system settings", Win32Classes_OperatingSystem_OperatingSystemSettings},
            {"Operating system events", Win32Classes_OperatingSystem_OperatingSystemEvents},
            {"Processes", Win32Classes_OperatingSystem_Processes},
            {"Registry", Win32Classes_OperatingSystem_Registry},
            {"Scheduler jobs", Win32Classes_OperatingSystem_SchedulerJobs},
            {"Security", Win32Classes_OperatingSystem_Security},
            {"Services", Win32Classes_OperatingSystem_Services},
            {"Shares", Win32Classes_OperatingSystem_Shares},
            {"Start menu", Win32Classes_OperatingSystem_StartMenu},
            {"Storage", Win32Classes_OperatingSystem_Storage},
            {"Users", Win32Classes_OperatingSystem_Users},
            {"Windows product activation", Win32Classes_OperatingSystem_WindowsProductActivation}
        };




        /// <summary>
        /// Performance Counter classes allow scripting and program access to system performance data calculated by existing high-performance providers. 
        /// For computers running on Windows Vista and later operating systems, different providers supply performance library data through WMI. 
        /// The WMIPerfClass and WMIPerfInst providers supply classes for both version 1 and version 2 Performance Counters. 
        /// These providers maintain compatibility with the classes available in earlier operating systems.
        /// </summary>
        public readonly static String[][] Win32Classes_PerformanceCounter = new String[][]
        {
            Win32Classes_PerformanceCounter_FormattedPerformanceCounter,
            Win32Classes_PerformanceCounter_RawPerformanceCounter
        };

        /// <summary>
        /// Description
        /// </summary>
        public readonly static Dictionary<String, String[]> Win32Classes_PerformanceCounter_Desc = new Dictionary<String, String[]>
        {
            {"Formatted Performance Counter Classes", Win32Classes_PerformanceCounter_FormattedPerformanceCounter},
            {"Raw Performance Counter Classes", Win32Classes_PerformanceCounter_RawPerformanceCounter}
        };




        /// <summary>
        /// WMI service management classes are used to manage the WMI service itself and not the computer system or enterprise network. 
        /// Managing WMI encompasses both configuring the WMI service and managing WMI operations.
        /// </summary>
        public readonly static String[][] Win32Classes_WMIServiceManagement = new String[][]
        {
            Win32Classes_WMIServiceManagement_WMIConfiguration,
            Win32Classes_WMIServiceManagement_WMIManagement
        };

        /// <summary>
        /// Description
        /// </summary>
        public readonly static Dictionary<String, String[]> Win32Classes_WMIServiceManagement_Desc = new Dictionary<String, String[]>
        {
            {"WMI Configuration Classes", Win32Classes_WMIServiceManagement_WMIConfiguration},
            {"WMI Management Classes", Win32Classes_WMIServiceManagement_WMIManagement}
        };




        /// <summary>
        /// Description
        /// </summary>
        public readonly static Dictionary<String, Dictionary<String, String[]>> Win32Classes_Desc = new Dictionary<String, Dictionary<String, String[]>>
        {
            {"Computer System Hardware Classes", Win32Classes_ComputerSystemHardware_Desc},
            {"Installed Applications Classes", Win32Classes_InstalledApplications_Desc},
            {"Operating System Classes", Win32Classes_OperatingSystem_Desc},
            {"Performance Counter Classes", Win32Classes_PerformanceCounter_Desc},
            {"WMI Service Management Classes", Win32Classes_WMIServiceManagement_Desc}
        };

        #endregion
    }
}

