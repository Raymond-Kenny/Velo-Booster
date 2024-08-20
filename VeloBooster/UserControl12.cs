using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl12 : UserControl
{
	private IContainer components = null;

	private CheckBox checkBox27;

	private CheckBox checkBox28;

	private CheckBox checkBox25;

	private CheckBox checkBox26;

	private CheckBox checkBox19;

	private CheckBox checkBox20;

	private CheckBox checkBox21;

	private CheckBox checkBox22;

	private CheckBox checkBox23;

	private CheckBox checkBox24;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private CheckBox checkBox17;

	private CheckBox checkBox18;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox12;

	private CheckBox checkBox4;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox3;

	private CheckBox checkBox2;

	private CheckBox checkBox1;

	private CheckBox checkBox33;

	private CheckBox checkBox34;

	private CheckBox checkBox35;

	private CheckBox checkBox36;

	private CheckBox checkBox37;

	private CheckBox checkBox38;

	private CheckBox checkBox39;

	private CheckBox checkBox40;

	private CheckBox checkBox41;

	private CheckBox checkBox42;

	private CheckBox checkBox29;

	private CheckBox checkBox30;

	private CheckBox checkBox31;

	private CheckBox checkBox32;

	private PictureBox pictureBox1;

	public UserControl12()
	{
		InitializeComponent();
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "200");
	}

	private void checkBox29_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
	}

	private void checkBox30_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
	}

	private void checkBox31_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
	}

	private void checkBox32_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "1000");
	}

	private void checkBox33_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
	}

	private void checkBox34_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
	}

	private void checkBox35_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\Reliability", "ShutdownReasonOnHang", "1");
	}

	private void checkBox36_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\Reliability", "ShutdownReasonUI", "1");
	}

	private void checkBox37_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "NoAutoRebootWithLoggedOnUsers", "1");
	}

	private void checkBox38_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0");
	}

	private void checkBox39_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", "1");
	}

	private void checkBox40_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "0");
	}

	private void checkBox41_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoFolderOptions", "0");
	}

	private void checkBox42_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoRun", "0");
	}

	private void checkBox27_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoDriveTypeAutoRun", "0");
	}

	private void checkBox28_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "StartButtonBalloonTip", "0");
	}

	private void checkBox25_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "TaskbarSizeMove", "1");
	}

	private void checkBox26_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "TaskbarGlomming", "1");
	}

	private void checkBox19_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ExtendedUIHoverTime", "200");
	}

	private void checkBox20_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ThumbnailLivePreviewHoverTime", "1000");
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLinkedConnections", "dword:00000001");
	}

	private void checkBox22_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableLockWorkstation", "dword:00000001");
	}

	private void checkBox23_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters", "IrpStackSize", "dword:00000018");
	}

	private void checkBox24_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "ServicesPipeTimeout", "dword:0002bf20");
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoRecentDocsHistory", "dword:00000001");
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\FileSystem", "NtfsDisableLastAccessUpdate", "dword:00000001");
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "DisableBkGndGroupPolicy", "dword:00000001");
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\W32Time\\TimeProviders\\NtpClient", "SpecialPollInterval", "dword:00000384");
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisablePageFaultClustering", "dword:00000001");
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "HideFastUserSwitching", "dword:00000001");
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "BackgroundThrottlingIndex", "dword:000000ff");
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "ForegroundFlashCount", "dword:00000000");
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "ForegroundLockTimeout", "dword:00000000");
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoBandCustomize", "dword:00000001");
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisablePageCombining", "dword:00000001");
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters", "Smb2", "dword:00000001");
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "DelayedInstallsAtInit", 0, RegistryValueKind.DWord);
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "DelayedInstalls", 0, RegistryValueKind.DWord);
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "Configuration", 1, RegistryValueKind.DWord);
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "Connectivity", 1, RegistryValueKind.DWord);
	}

	private void UserControl12_Load(object sender, EventArgs e)
	{
	}

	private void checkBox32_CheckedChanged_1(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "DPConfigurations", 0, RegistryValueKind.DWord);
	}

	private void checkBox31_CheckedChanged_1(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "DpiSupportPolicy", 0, RegistryValueKind.DWord);
	}

	private void checkBox30_CheckedChanged_1(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "FrameRateCounter", 0, RegistryValueKind.DWord);
	}

	private void checkBox29_CheckedChanged_1(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "LUMABias", 0, RegistryValueKind.DWord);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl12));
		this.checkBox27 = new System.Windows.Forms.CheckBox();
		this.checkBox28 = new System.Windows.Forms.CheckBox();
		this.checkBox25 = new System.Windows.Forms.CheckBox();
		this.checkBox26 = new System.Windows.Forms.CheckBox();
		this.checkBox19 = new System.Windows.Forms.CheckBox();
		this.checkBox20 = new System.Windows.Forms.CheckBox();
		this.checkBox21 = new System.Windows.Forms.CheckBox();
		this.checkBox22 = new System.Windows.Forms.CheckBox();
		this.checkBox23 = new System.Windows.Forms.CheckBox();
		this.checkBox24 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.checkBox17 = new System.Windows.Forms.CheckBox();
		this.checkBox18 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.checkBox33 = new System.Windows.Forms.CheckBox();
		this.checkBox34 = new System.Windows.Forms.CheckBox();
		this.checkBox35 = new System.Windows.Forms.CheckBox();
		this.checkBox36 = new System.Windows.Forms.CheckBox();
		this.checkBox37 = new System.Windows.Forms.CheckBox();
		this.checkBox38 = new System.Windows.Forms.CheckBox();
		this.checkBox39 = new System.Windows.Forms.CheckBox();
		this.checkBox40 = new System.Windows.Forms.CheckBox();
		this.checkBox41 = new System.Windows.Forms.CheckBox();
		this.checkBox42 = new System.Windows.Forms.CheckBox();
		this.checkBox29 = new System.Windows.Forms.CheckBox();
		this.checkBox30 = new System.Windows.Forms.CheckBox();
		this.checkBox31 = new System.Windows.Forms.CheckBox();
		this.checkBox32 = new System.Windows.Forms.CheckBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.checkBox27.AutoSize = true;
		this.checkBox27.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox27.Location = new System.Drawing.Point(198, 550);
		this.checkBox27.Name = "checkBox27";
		this.checkBox27.Size = new System.Drawing.Size(129, 17);
		this.checkBox27.TabIndex = 86;
		this.checkBox27.Text = "Disable Drive Autorun";
		this.checkBox27.UseVisualStyleBackColor = true;
		this.checkBox27.CheckedChanged += new System.EventHandler(checkBox27_CheckedChanged);
		this.checkBox28.AutoSize = true;
		this.checkBox28.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox28.Location = new System.Drawing.Point(198, 509);
		this.checkBox28.Name = "checkBox28";
		this.checkBox28.Size = new System.Drawing.Size(84, 17);
		this.checkBox28.TabIndex = 85;
		this.checkBox28.Text = "Disable Tips";
		this.checkBox28.UseVisualStyleBackColor = true;
		this.checkBox28.CheckedChanged += new System.EventHandler(checkBox28_CheckedChanged);
		this.checkBox25.AutoSize = true;
		this.checkBox25.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox25.Location = new System.Drawing.Point(3, 550);
		this.checkBox25.Name = "checkBox25";
		this.checkBox25.Size = new System.Drawing.Size(101, 17);
		this.checkBox25.TabIndex = 84;
		this.checkBox25.Text = "Taskbar Tweak";
		this.checkBox25.UseVisualStyleBackColor = true;
		this.checkBox25.CheckedChanged += new System.EventHandler(checkBox25_CheckedChanged);
		this.checkBox26.AutoSize = true;
		this.checkBox26.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox26.Location = new System.Drawing.Point(3, 509);
		this.checkBox26.Name = "checkBox26";
		this.checkBox26.Size = new System.Drawing.Size(106, 17);
		this.checkBox26.TabIndex = 83;
		this.checkBox26.Text = "Taskbar Gloming";
		this.checkBox26.UseVisualStyleBackColor = true;
		this.checkBox26.CheckedChanged += new System.EventHandler(checkBox26_CheckedChanged);
		this.checkBox19.AutoSize = true;
		this.checkBox19.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox19.Location = new System.Drawing.Point(198, 471);
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.Size = new System.Drawing.Size(125, 17);
		this.checkBox19.TabIndex = 82;
		this.checkBox19.Text = "Extended Hover time";
		this.checkBox19.UseVisualStyleBackColor = true;
		this.checkBox19.CheckedChanged += new System.EventHandler(checkBox19_CheckedChanged);
		this.checkBox20.AutoSize = true;
		this.checkBox20.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox20.Location = new System.Drawing.Point(198, 430);
		this.checkBox20.Name = "checkBox20";
		this.checkBox20.Size = new System.Drawing.Size(127, 17);
		this.checkBox20.TabIndex = 81;
		this.checkBox20.Text = "Thumbnail hover time";
		this.checkBox20.UseVisualStyleBackColor = true;
		this.checkBox20.CheckedChanged += new System.EventHandler(checkBox20_CheckedChanged);
		this.checkBox21.AutoSize = true;
		this.checkBox21.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox21.Location = new System.Drawing.Point(198, 391);
		this.checkBox21.Name = "checkBox21";
		this.checkBox21.Size = new System.Drawing.Size(151, 17);
		this.checkBox21.TabIndex = 80;
		this.checkBox21.Text = "Linked connections tweak";
		this.checkBox21.UseVisualStyleBackColor = true;
		this.checkBox21.CheckedChanged += new System.EventHandler(checkBox21_CheckedChanged);
		this.checkBox22.AutoSize = true;
		this.checkBox22.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox22.Location = new System.Drawing.Point(198, 345);
		this.checkBox22.Name = "checkBox22";
		this.checkBox22.Size = new System.Drawing.Size(148, 17);
		this.checkBox22.TabIndex = 79;
		this.checkBox22.Text = "Disable Lock Workstation";
		this.checkBox22.UseVisualStyleBackColor = true;
		this.checkBox22.CheckedChanged += new System.EventHandler(checkBox22_CheckedChanged);
		this.checkBox23.AutoSize = true;
		this.checkBox23.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox23.Location = new System.Drawing.Point(198, 304);
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.Size = new System.Drawing.Size(85, 17);
		this.checkBox23.TabIndex = 78;
		this.checkBox23.Text = "IRP Tweaks";
		this.checkBox23.UseVisualStyleBackColor = true;
		this.checkBox23.CheckedChanged += new System.EventHandler(checkBox23_CheckedChanged);
		this.checkBox24.AutoSize = true;
		this.checkBox24.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox24.Location = new System.Drawing.Point(198, 265);
		this.checkBox24.Name = "checkBox24";
		this.checkBox24.Size = new System.Drawing.Size(130, 17);
		this.checkBox24.TabIndex = 77;
		this.checkBox24.Text = "Serives timeout tweak";
		this.checkBox24.UseVisualStyleBackColor = true;
		this.checkBox24.CheckedChanged += new System.EventHandler(checkBox24_CheckedChanged);
		this.checkBox13.AutoSize = true;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(198, 225);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(113, 17);
		this.checkBox13.TabIndex = 76;
		this.checkBox13.Text = "No explorer history";
		this.checkBox13.UseVisualStyleBackColor = true;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(198, 184);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(127, 17);
		this.checkBox14.TabIndex = 75;
		this.checkBox14.Text = "Memory Acess tweak";
		this.checkBox14.UseVisualStyleBackColor = true;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged);
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(198, 145);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(144, 17);
		this.checkBox15.TabIndex = 74;
		this.checkBox15.Text = "Background Optimization";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox15.CheckedChanged += new System.EventHandler(checkBox15_CheckedChanged);
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(198, 99);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(116, 17);
		this.checkBox16.TabIndex = 73;
		this.checkBox16.Text = "Better Pool Interval";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox16.CheckedChanged += new System.EventHandler(checkBox16_CheckedChanged);
		this.checkBox17.AutoSize = true;
		this.checkBox17.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox17.Location = new System.Drawing.Point(198, 58);
		this.checkBox17.Name = "checkBox17";
		this.checkBox17.Size = new System.Drawing.Size(134, 17);
		this.checkBox17.TabIndex = 72;
		this.checkBox17.Text = "Fault Clustering Tweak";
		this.checkBox17.UseVisualStyleBackColor = true;
		this.checkBox17.CheckedChanged += new System.EventHandler(checkBox17_CheckedChanged);
		this.checkBox18.AutoSize = true;
		this.checkBox18.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox18.Location = new System.Drawing.Point(198, 19);
		this.checkBox18.Name = "checkBox18";
		this.checkBox18.Size = new System.Drawing.Size(140, 17);
		this.checkBox18.TabIndex = 71;
		this.checkBox18.Text = "Optimize User Switching";
		this.checkBox18.UseVisualStyleBackColor = true;
		this.checkBox18.CheckedChanged += new System.EventHandler(checkBox18_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(3, 471);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(195, 17);
		this.checkBox7.TabIndex = 70;
		this.checkBox7.Text = "Background throttling (experimental)";
		this.checkBox7.UseVisualStyleBackColor = true;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(3, 430);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(133, 17);
		this.checkBox8.TabIndex = 69;
		this.checkBox8.Text = "Foreground size tweak";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(3, 391);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(123, 17);
		this.checkBox9.TabIndex = 68;
		this.checkBox9.Text = "Optimize Foreground";
		this.checkBox9.UseVisualStyleBackColor = true;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(3, 345);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(87, 17);
		this.checkBox10.TabIndex = 67;
		this.checkBox10.Text = "Band Tweak";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(3, 304);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(141, 17);
		this.checkBox11.TabIndex = 66;
		this.checkBox11.Text = "Disable Page Combining";
		this.checkBox11.UseVisualStyleBackColor = true;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox12.AutoSize = true;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(3, 265);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(152, 17);
		this.checkBox12.TabIndex = 65;
		this.checkBox12.Text = "Enable NUMA optimization";
		this.checkBox12.UseVisualStyleBackColor = true;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(3, 225);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(92, 17);
		this.checkBox4.TabIndex = 64;
		this.checkBox4.Text = "Optimize SMB";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(3, 184);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(156, 17);
		this.checkBox5.TabIndex = 63;
		this.checkBox5.Text = "Disable GPU Delay Install 2";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(3, 145);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(147, 17);
		this.checkBox6.TabIndex = 62;
		this.checkBox6.Text = "Disable GPU Delay Install";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(3, 99);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(150, 17);
		this.checkBox3.TabIndex = 61;
		this.checkBox3.Text = "GPU Configuration Tweak";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(3, 58);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(140, 17);
		this.checkBox2.TabIndex = 60;
		this.checkBox2.Text = "GPU Conectivity Tweak";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(3, 19);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(113, 17);
		this.checkBox1.TabIndex = 59;
		this.checkBox1.Text = "Lower Hover Time";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.checkBox33.AutoSize = true;
		this.checkBox33.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox33.Location = new System.Drawing.Point(380, 391);
		this.checkBox33.Name = "checkBox33";
		this.checkBox33.Size = new System.Drawing.Size(98, 17);
		this.checkBox33.TabIndex = 96;
		this.checkBox33.Text = "Hooks Timeout";
		this.checkBox33.UseVisualStyleBackColor = true;
		this.checkBox33.CheckedChanged += new System.EventHandler(checkBox33_CheckedChanged);
		this.checkBox34.AutoSize = true;
		this.checkBox34.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox34.Location = new System.Drawing.Point(380, 345);
		this.checkBox34.Name = "checkBox34";
		this.checkBox34.Size = new System.Drawing.Size(118, 17);
		this.checkBox34.TabIndex = 95;
		this.checkBox34.Text = "Service kill Timeout";
		this.checkBox34.UseVisualStyleBackColor = true;
		this.checkBox34.CheckedChanged += new System.EventHandler(checkBox34_CheckedChanged);
		this.checkBox35.AutoSize = true;
		this.checkBox35.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox35.Location = new System.Drawing.Point(380, 304);
		this.checkBox35.Name = "checkBox35";
		this.checkBox35.Size = new System.Drawing.Size(160, 17);
		this.checkBox35.TabIndex = 94;
		this.checkBox35.Text = "Shutdown Reason On Hang";
		this.checkBox35.UseVisualStyleBackColor = true;
		this.checkBox35.CheckedChanged += new System.EventHandler(checkBox35_CheckedChanged);
		this.checkBox36.AutoSize = true;
		this.checkBox36.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox36.Location = new System.Drawing.Point(380, 265);
		this.checkBox36.Name = "checkBox36";
		this.checkBox36.Size = new System.Drawing.Size(106, 17);
		this.checkBox36.TabIndex = 93;
		this.checkBox36.Text = "Shutdown tweak";
		this.checkBox36.UseVisualStyleBackColor = true;
		this.checkBox36.CheckedChanged += new System.EventHandler(checkBox36_CheckedChanged);
		this.checkBox37.AutoSize = true;
		this.checkBox37.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox37.Location = new System.Drawing.Point(380, 225);
		this.checkBox37.Name = "checkBox37";
		this.checkBox37.Size = new System.Drawing.Size(114, 17);
		this.checkBox37.TabIndex = 92;
		this.checkBox37.Text = "Autoreboot Tweak";
		this.checkBox37.UseVisualStyleBackColor = true;
		this.checkBox37.CheckedChanged += new System.EventHandler(checkBox37_CheckedChanged);
		this.checkBox38.AutoSize = true;
		this.checkBox38.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox38.Location = new System.Drawing.Point(380, 184);
		this.checkBox38.Name = "checkBox38";
		this.checkBox38.Size = new System.Drawing.Size(105, 17);
		this.checkBox38.TabIndex = 91;
		this.checkBox38.Text = "Disable Hide exit";
		this.checkBox38.UseVisualStyleBackColor = true;
		this.checkBox38.CheckedChanged += new System.EventHandler(checkBox38_CheckedChanged);
		this.checkBox39.AutoSize = true;
		this.checkBox39.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox39.Location = new System.Drawing.Point(380, 145);
		this.checkBox39.Name = "checkBox39";
		this.checkBox39.Size = new System.Drawing.Size(93, 17);
		this.checkBox39.TabIndex = 90;
		this.checkBox39.Text = "Show Hidden ";
		this.checkBox39.UseVisualStyleBackColor = true;
		this.checkBox39.CheckedChanged += new System.EventHandler(checkBox39_CheckedChanged);
		this.checkBox40.AutoSize = true;
		this.checkBox40.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox40.Location = new System.Drawing.Point(380, 99);
		this.checkBox40.Name = "checkBox40";
		this.checkBox40.Size = new System.Drawing.Size(138, 17);
		this.checkBox40.TabIndex = 89;
		this.checkBox40.Text = "Resolve Search Tweak";
		this.checkBox40.UseVisualStyleBackColor = true;
		this.checkBox40.CheckedChanged += new System.EventHandler(checkBox40_CheckedChanged);
		this.checkBox41.AutoSize = true;
		this.checkBox41.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox41.Location = new System.Drawing.Point(380, 58);
		this.checkBox41.Name = "checkBox41";
		this.checkBox41.Size = new System.Drawing.Size(115, 17);
		this.checkBox41.TabIndex = 88;
		this.checkBox41.Text = "Folder Optimization";
		this.checkBox41.UseVisualStyleBackColor = true;
		this.checkBox41.CheckedChanged += new System.EventHandler(checkBox41_CheckedChanged);
		this.checkBox42.AutoSize = true;
		this.checkBox42.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox42.Location = new System.Drawing.Point(380, 19);
		this.checkBox42.Name = "checkBox42";
		this.checkBox42.Size = new System.Drawing.Size(114, 17);
		this.checkBox42.TabIndex = 87;
		this.checkBox42.Text = "Explorer run tweak";
		this.checkBox42.UseVisualStyleBackColor = true;
		this.checkBox42.CheckedChanged += new System.EventHandler(checkBox42_CheckedChanged);
		this.checkBox29.AutoSize = true;
		this.checkBox29.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox29.Location = new System.Drawing.Point(380, 550);
		this.checkBox29.Name = "checkBox29";
		this.checkBox29.Size = new System.Drawing.Size(108, 17);
		this.checkBox29.TabIndex = 100;
		this.checkBox29.Text = "GPU Bias Tweak";
		this.checkBox29.UseVisualStyleBackColor = true;
		this.checkBox29.CheckedChanged += new System.EventHandler(checkBox29_CheckedChanged_1);
		this.checkBox30.AutoSize = true;
		this.checkBox30.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox30.Location = new System.Drawing.Point(379, 509);
		this.checkBox30.Name = "checkBox30";
		this.checkBox30.Size = new System.Drawing.Size(162, 17);
		this.checkBox30.TabIndex = 99;
		this.checkBox30.Text = "Disable GPU Frame Counter ";
		this.checkBox30.UseVisualStyleBackColor = true;
		this.checkBox30.CheckedChanged += new System.EventHandler(checkBox30_CheckedChanged_1);
		this.checkBox31.AutoSize = true;
		this.checkBox31.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox31.Location = new System.Drawing.Point(379, 471);
		this.checkBox31.Name = "checkBox31";
		this.checkBox31.Size = new System.Drawing.Size(146, 17);
		this.checkBox31.TabIndex = 98;
		this.checkBox31.Text = "GPU DPI Support Tweak";
		this.checkBox31.UseVisualStyleBackColor = true;
		this.checkBox31.CheckedChanged += new System.EventHandler(checkBox31_CheckedChanged_1);
		this.checkBox32.AutoSize = true;
		this.checkBox32.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox32.Location = new System.Drawing.Point(379, 430);
		this.checkBox32.Name = "checkBox32";
		this.checkBox32.Size = new System.Drawing.Size(158, 17);
		this.checkBox32.TabIndex = 97;
		this.checkBox32.Text = "GPU DConfiguration Tweak";
		this.checkBox32.UseVisualStyleBackColor = true;
		this.checkBox32.CheckedChanged += new System.EventHandler(checkBox32_CheckedChanged_1);
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(447, 515);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 101;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		base.Controls.Add(this.checkBox29);
		base.Controls.Add(this.checkBox30);
		base.Controls.Add(this.checkBox31);
		base.Controls.Add(this.checkBox32);
		base.Controls.Add(this.checkBox33);
		base.Controls.Add(this.checkBox34);
		base.Controls.Add(this.checkBox35);
		base.Controls.Add(this.checkBox36);
		base.Controls.Add(this.checkBox37);
		base.Controls.Add(this.checkBox38);
		base.Controls.Add(this.checkBox39);
		base.Controls.Add(this.checkBox40);
		base.Controls.Add(this.checkBox41);
		base.Controls.Add(this.checkBox42);
		base.Controls.Add(this.checkBox27);
		base.Controls.Add(this.checkBox28);
		base.Controls.Add(this.checkBox25);
		base.Controls.Add(this.checkBox26);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.checkBox20);
		base.Controls.Add(this.checkBox21);
		base.Controls.Add(this.checkBox22);
		base.Controls.Add(this.checkBox23);
		base.Controls.Add(this.checkBox24);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.checkBox17);
		base.Controls.Add(this.checkBox18);
		base.Controls.Add(this.checkBox7);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox9);
		base.Controls.Add(this.checkBox10);
		base.Controls.Add(this.checkBox11);
		base.Controls.Add(this.checkBox12);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.pictureBox1);
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl12";
		base.Size = new System.Drawing.Size(619, 605);
		base.Load += new System.EventHandler(UserControl12_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
