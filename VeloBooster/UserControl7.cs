using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl7 : UserControl
{
	private IContainer components;

	private PictureBox pictureBox1;

	private CheckBox checkBox33;

	private CheckBox checkBox3;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox12;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox19;

	private CheckBox checkBox20;

	private CheckBox checkBox21;

	private CheckBox checkBox22;

	private CheckBox checkBox23;

	private CheckBox checkBox1;

	private CheckBox checkBox2;

	private CheckBox checkBox4;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private CheckBox checkBox17;

	private CheckBox checkBox18;

	private CheckBox checkBox24;

	private CheckBox checkBox25;

	private CheckBox checkBox26;

	private CheckBox checkBox27;

	private CheckBox checkBox28;

	private CheckBox checkBox29;

	private CheckBox checkBox30;

	private CheckBox checkBox31;

	private CheckBox checkBox32;

	public UserControl7()
	{
		InitializeComponent();
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", "AllowGameDVR", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Afd\\Parameters", "IrpStackSize", 64, RegistryValueKind.DWord);
		}
	}

	private void checkBox20_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox20.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "CachedLogonsCount", 86400, RegistryValueKind.DWord);
		}
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox21.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Executive", "AdditionalCriticalWorkerThreads", 4, RegistryValueKind.DWord);
		}
	}

	private void checkBox22_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox22.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Disk\\RetryCount", "IoRetryCount", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox23_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox23.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\IsaPnp\\Parameters", "IrqStackSize", 4, RegistryValueKind.DWord);
		}
	}

	private void checkBox33_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox33.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", "ApplicationLaunchMaxWorkingSetSize", 536870912, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\FileSystem", "MaxFileCache", 524288, RegistryValueKind.DWord);
		}
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox7.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "UserPostMessageLimit", 5000, RegistryValueKind.DWord);
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Executive", "MaxThreads", 100, RegistryValueKind.DWord);
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox9.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Explorer.exe", "GlobalFlag", 40000000, RegistryValueKind.DWord);
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox10.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows", "DesktopHeapSize", 65536, RegistryValueKind.DWord);
		}
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox11.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "ForegroundFlashCount", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox12.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Afd\\Parameters", "FastIoDispatchFastMdlReads", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox13.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisablePagingExecutive", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox14.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Executive", "IoSystemThreadPriority", 2, RegistryValueKind.DWord);
		}
	}

	private void checkBox19_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox19.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters", "KernelStackSize", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox32_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox23.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox31_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox31.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowSearchToUseLocation", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox30_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox30.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableWebSearch", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox29_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox29.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "ConnectedSearchUseWeb", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox28_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox28.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowSearchOnUnknownSources", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox27_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox27.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowIndexingEncryptedStoresOrItems", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox26_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox26.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableBackoffForCrawl", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox25_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox25.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableBackoffForNotifications", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox24_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox24.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableBackoffForCi", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox18.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableBackoffForUnthrottledNotifications", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox17.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowIndexingOutlookOnLine", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox16.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "PreventIndexingOutlookOnLine", 1, RegistryValueKind.DWord);
		}
	}

	private void UserControl7_Load(object sender, EventArgs e)
	{
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox15.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowIndexingExchangePublicFolders", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "PreventIndexingExchangePublicFolders", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableRemovableDriveIndexing", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableServerDesktopExperience", 1, RegistryValueKind.DWord);
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl7));
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.checkBox33 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox19 = new System.Windows.Forms.CheckBox();
		this.checkBox20 = new System.Windows.Forms.CheckBox();
		this.checkBox21 = new System.Windows.Forms.CheckBox();
		this.checkBox22 = new System.Windows.Forms.CheckBox();
		this.checkBox23 = new System.Windows.Forms.CheckBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.checkBox17 = new System.Windows.Forms.CheckBox();
		this.checkBox18 = new System.Windows.Forms.CheckBox();
		this.checkBox24 = new System.Windows.Forms.CheckBox();
		this.checkBox25 = new System.Windows.Forms.CheckBox();
		this.checkBox26 = new System.Windows.Forms.CheckBox();
		this.checkBox27 = new System.Windows.Forms.CheckBox();
		this.checkBox28 = new System.Windows.Forms.CheckBox();
		this.checkBox29 = new System.Windows.Forms.CheckBox();
		this.checkBox30 = new System.Windows.Forms.CheckBox();
		this.checkBox31 = new System.Windows.Forms.CheckBox();
		this.checkBox32 = new System.Windows.Forms.CheckBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(450, 515);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 75;
		this.pictureBox1.TabStop = false;
		this.checkBox33.AutoSize = true;
		this.checkBox33.BackColor = System.Drawing.Color.Black;
		this.checkBox33.FlatAppearance.BorderSize = 5;
		this.checkBox33.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox33.Location = new System.Drawing.Point(19, 432);
		this.checkBox33.Name = "checkBox33";
		this.checkBox33.Size = new System.Drawing.Size(130, 17);
		this.checkBox33.TabIndex = 102;
		this.checkBox33.Text = "Improve File work size";
		this.checkBox33.UseVisualStyleBackColor = false;
		this.checkBox33.CheckedChanged += new System.EventHandler(checkBox33_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.BackColor = System.Drawing.Color.Black;
		this.checkBox3.FlatAppearance.BorderSize = 5;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(19, 394);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(120, 17);
		this.checkBox3.TabIndex = 101;
		this.checkBox3.Text = "improve file caching";
		this.checkBox3.UseVisualStyleBackColor = false;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.BackColor = System.Drawing.Color.Black;
		this.checkBox7.FlatAppearance.BorderSize = 5;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(19, 354);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(210, 17);
		this.checkBox7.TabIndex = 100;
		this.checkBox7.Text = "improve global application performance";
		this.checkBox7.UseVisualStyleBackColor = false;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.BackColor = System.Drawing.Color.Black;
		this.checkBox8.FlatAppearance.BorderSize = 5;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(19, 319);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(111, 17);
		this.checkBox8.TabIndex = 99;
		this.checkBox8.Text = "Maximize Threads";
		this.checkBox8.UseVisualStyleBackColor = false;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.BackColor = System.Drawing.Color.Black;
		this.checkBox9.FlatAppearance.BorderSize = 5;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(19, 286);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(123, 17);
		this.checkBox9.TabIndex = 98;
		this.checkBox9.Text = "Increase Global Flag";
		this.checkBox9.UseVisualStyleBackColor = false;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.BackColor = System.Drawing.Color.Black;
		this.checkBox10.FlatAppearance.BorderSize = 5;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(19, 248);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(119, 17);
		this.checkBox10.TabIndex = 97;
		this.checkBox10.Text = "Increase Heap Size";
		this.checkBox10.UseVisualStyleBackColor = false;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.BackColor = System.Drawing.Color.Black;
		this.checkBox11.FlatAppearance.BorderSize = 5;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(19, 209);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(120, 17);
		this.checkBox11.TabIndex = 96;
		this.checkBox11.Text = "Disable Flash Count";
		this.checkBox11.UseVisualStyleBackColor = false;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox12.AutoSize = true;
		this.checkBox12.BackColor = System.Drawing.Color.Black;
		this.checkBox12.FlatAppearance.BorderSize = 5;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(19, 165);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(198, 17);
		this.checkBox12.TabIndex = 95;
		this.checkBox12.Text = "Adjust the size of the I/O Completion";
		this.checkBox12.UseVisualStyleBackColor = false;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.checkBox13.AutoSize = true;
		this.checkBox13.BackColor = System.Drawing.Color.Black;
		this.checkBox13.FlatAppearance.BorderSize = 5;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(19, 124);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(169, 17);
		this.checkBox13.TabIndex = 94;
		this.checkBox13.Text = "Disable paging of kernel mode";
		this.checkBox13.UseVisualStyleBackColor = false;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.BackColor = System.Drawing.Color.Black;
		this.checkBox14.FlatAppearance.BorderSize = 5;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(19, 88);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(227, 17);
		this.checkBox14.TabIndex = 93;
		this.checkBox14.Text = "Increase the number of I/O worker threads";
		this.checkBox14.UseVisualStyleBackColor = false;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.BackColor = System.Drawing.Color.Black;
		this.checkBox5.FlatAppearance.BorderSize = 5;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(19, 53);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(223, 17);
		this.checkBox5.TabIndex = 92;
		this.checkBox5.Text = "Adjust the size of the I/O Request Packet";
		this.checkBox5.UseVisualStyleBackColor = false;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.BackColor = System.Drawing.Color.Black;
		this.checkBox6.FlatAppearance.BorderSize = 5;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(19, 14);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(167, 17);
		this.checkBox6.TabIndex = 91;
		this.checkBox6.Text = "Disable Compatibility Assistant";
		this.checkBox6.UseVisualStyleBackColor = false;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox19.AutoSize = true;
		this.checkBox19.BackColor = System.Drawing.Color.Black;
		this.checkBox19.FlatAppearance.BorderSize = 5;
		this.checkBox19.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox19.Location = new System.Drawing.Point(249, 14);
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.Size = new System.Drawing.Size(155, 17);
		this.checkBox19.TabIndex = 107;
		this.checkBox19.Text = "Increase Kernel size stacks";
		this.checkBox19.UseVisualStyleBackColor = false;
		this.checkBox19.CheckedChanged += new System.EventHandler(checkBox19_CheckedChanged);
		this.checkBox20.AutoSize = true;
		this.checkBox20.BackColor = System.Drawing.Color.Black;
		this.checkBox20.FlatAppearance.BorderSize = 5;
		this.checkBox20.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox20.Location = new System.Drawing.Point(17, 573);
		this.checkBox20.Name = "checkBox20";
		this.checkBox20.Size = new System.Drawing.Size(171, 17);
		this.checkBox20.TabIndex = 106;
		this.checkBox20.Text = "Increase Logon Cache timeout";
		this.checkBox20.UseVisualStyleBackColor = false;
		this.checkBox20.CheckedChanged += new System.EventHandler(checkBox20_CheckedChanged);
		this.checkBox21.AutoSize = true;
		this.checkBox21.BackColor = System.Drawing.Color.Black;
		this.checkBox21.FlatAppearance.BorderSize = 5;
		this.checkBox21.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox21.Location = new System.Drawing.Point(17, 537);
		this.checkBox21.Name = "checkBox21";
		this.checkBox21.Size = new System.Drawing.Size(196, 17);
		this.checkBox21.TabIndex = 105;
		this.checkBox21.Text = "Increase the Critical WorkerThreads";
		this.checkBox21.UseVisualStyleBackColor = false;
		this.checkBox21.CheckedChanged += new System.EventHandler(checkBox21_CheckedChanged);
		this.checkBox22.AutoSize = true;
		this.checkBox22.BackColor = System.Drawing.Color.Black;
		this.checkBox22.FlatAppearance.BorderSize = 5;
		this.checkBox22.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox22.Location = new System.Drawing.Point(17, 502);
		this.checkBox22.Name = "checkBox22";
		this.checkBox22.Size = new System.Drawing.Size(144, 17);
		this.checkBox22.TabIndex = 104;
		this.checkBox22.Text = "improve I/O performance";
		this.checkBox22.UseVisualStyleBackColor = false;
		this.checkBox22.CheckedChanged += new System.EventHandler(checkBox22_CheckedChanged);
		this.checkBox23.AutoSize = true;
		this.checkBox23.BackColor = System.Drawing.Color.Black;
		this.checkBox23.FlatAppearance.BorderSize = 5;
		this.checkBox23.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox23.Location = new System.Drawing.Point(19, 464);
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.Size = new System.Drawing.Size(209, 17);
		this.checkBox23.TabIndex = 103;
		this.checkBox23.Text = "improve interrupt handling performance";
		this.checkBox23.UseVisualStyleBackColor = false;
		this.checkBox23.CheckedChanged += new System.EventHandler(checkBox23_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.BackColor = System.Drawing.Color.Black;
		this.checkBox1.FlatAppearance.BorderSize = 5;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(247, 573);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(194, 17);
		this.checkBox1.TabIndex = 123;
		this.checkBox1.Text = "Disable Server Desktop Experience";
		this.checkBox1.UseVisualStyleBackColor = false;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.BackColor = System.Drawing.Color.Black;
		this.checkBox2.FlatAppearance.BorderSize = 5;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(247, 537);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(189, 17);
		this.checkBox2.TabIndex = 122;
		this.checkBox2.Text = "Disable Removable Drive Indexing";
		this.checkBox2.UseVisualStyleBackColor = false;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.BackColor = System.Drawing.Color.Black;
		this.checkBox4.FlatAppearance.BorderSize = 5;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(247, 502);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(226, 17);
		this.checkBox4.TabIndex = 121;
		this.checkBox4.Text = "Prevent Indexing Exchange Public Folders";
		this.checkBox4.UseVisualStyleBackColor = false;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox15.AutoSize = true;
		this.checkBox15.BackColor = System.Drawing.Color.Black;
		this.checkBox15.FlatAppearance.BorderSize = 5;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(249, 464);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(224, 17);
		this.checkBox15.TabIndex = 120;
		this.checkBox15.Text = "Disable Indexing Exchange Public Folders";
		this.checkBox15.UseVisualStyleBackColor = false;
		this.checkBox15.CheckedChanged += new System.EventHandler(checkBox15_CheckedChanged);
		this.checkBox16.AutoSize = true;
		this.checkBox16.BackColor = System.Drawing.Color.Black;
		this.checkBox16.FlatAppearance.BorderSize = 5;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(249, 432);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(181, 17);
		this.checkBox16.TabIndex = 119;
		this.checkBox16.Text = "Disable Indexing Outlook OnLine";
		this.checkBox16.UseVisualStyleBackColor = false;
		this.checkBox16.CheckedChanged += new System.EventHandler(checkBox16_CheckedChanged);
		this.checkBox17.AutoSize = true;
		this.checkBox17.BackColor = System.Drawing.Color.Black;
		this.checkBox17.FlatAppearance.BorderSize = 5;
		this.checkBox17.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox17.Location = new System.Drawing.Point(249, 394);
		this.checkBox17.Name = "checkBox17";
		this.checkBox17.Size = new System.Drawing.Size(235, 17);
		this.checkBox17.TabIndex = 118;
		this.checkBox17.Text = "Disable Backoff For Unthrottled Notifications";
		this.checkBox17.UseVisualStyleBackColor = false;
		this.checkBox17.CheckedChanged += new System.EventHandler(checkBox17_CheckedChanged);
		this.checkBox18.AutoSize = true;
		this.checkBox18.BackColor = System.Drawing.Color.Black;
		this.checkBox18.FlatAppearance.BorderSize = 5;
		this.checkBox18.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox18.Location = new System.Drawing.Point(248, 354);
		this.checkBox18.Name = "checkBox18";
		this.checkBox18.Size = new System.Drawing.Size(131, 17);
		this.checkBox18.TabIndex = 117;
		this.checkBox18.Text = "Disable Backoff For Ci";
		this.checkBox18.UseVisualStyleBackColor = false;
		this.checkBox18.CheckedChanged += new System.EventHandler(checkBox18_CheckedChanged);
		this.checkBox24.AutoSize = true;
		this.checkBox24.BackColor = System.Drawing.Color.Black;
		this.checkBox24.FlatAppearance.BorderSize = 5;
		this.checkBox24.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox24.Location = new System.Drawing.Point(249, 319);
		this.checkBox24.Name = "checkBox24";
		this.checkBox24.Size = new System.Drawing.Size(180, 17);
		this.checkBox24.TabIndex = 116;
		this.checkBox24.Text = "Disable Backoff For Notifications";
		this.checkBox24.UseVisualStyleBackColor = false;
		this.checkBox24.CheckedChanged += new System.EventHandler(checkBox24_CheckedChanged);
		this.checkBox25.AutoSize = true;
		this.checkBox25.BackColor = System.Drawing.Color.Black;
		this.checkBox25.FlatAppearance.BorderSize = 5;
		this.checkBox25.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox25.Location = new System.Drawing.Point(249, 286);
		this.checkBox25.Name = "checkBox25";
		this.checkBox25.Size = new System.Drawing.Size(148, 17);
		this.checkBox25.TabIndex = 115;
		this.checkBox25.Text = "Disable Backoff For Crawl";
		this.checkBox25.UseVisualStyleBackColor = false;
		this.checkBox25.CheckedChanged += new System.EventHandler(checkBox25_CheckedChanged);
		this.checkBox26.AutoSize = true;
		this.checkBox26.BackColor = System.Drawing.Color.Black;
		this.checkBox26.FlatAppearance.BorderSize = 5;
		this.checkBox26.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox26.Location = new System.Drawing.Point(249, 248);
		this.checkBox26.Name = "checkBox26";
		this.checkBox26.Size = new System.Drawing.Size(230, 17);
		this.checkBox26.TabIndex = 114;
		this.checkBox26.Text = "Disable Indexing Encrypted Stores Or Items";
		this.checkBox26.UseVisualStyleBackColor = false;
		this.checkBox26.CheckedChanged += new System.EventHandler(checkBox26_CheckedChanged);
		this.checkBox27.AutoSize = true;
		this.checkBox27.BackColor = System.Drawing.Color.Black;
		this.checkBox27.FlatAppearance.BorderSize = 5;
		this.checkBox27.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox27.Location = new System.Drawing.Point(249, 209);
		this.checkBox27.Name = "checkBox27";
		this.checkBox27.Size = new System.Drawing.Size(206, 17);
		this.checkBox27.TabIndex = 113;
		this.checkBox27.Text = "Disable Search On Unknown Sources";
		this.checkBox27.UseVisualStyleBackColor = false;
		this.checkBox27.CheckedChanged += new System.EventHandler(checkBox27_CheckedChanged);
		this.checkBox28.AutoSize = true;
		this.checkBox28.BackColor = System.Drawing.Color.Black;
		this.checkBox28.FlatAppearance.BorderSize = 5;
		this.checkBox28.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox28.Location = new System.Drawing.Point(249, 165);
		this.checkBox28.Name = "checkBox28";
		this.checkBox28.Size = new System.Drawing.Size(201, 17);
		this.checkBox28.TabIndex = 112;
		this.checkBox28.Text = "Disable Connected Search Use Web";
		this.checkBox28.UseVisualStyleBackColor = false;
		this.checkBox28.CheckedChanged += new System.EventHandler(checkBox28_CheckedChanged);
		this.checkBox29.AutoSize = true;
		this.checkBox29.BackColor = System.Drawing.Color.Black;
		this.checkBox29.FlatAppearance.BorderSize = 5;
		this.checkBox29.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox29.Location = new System.Drawing.Point(249, 124);
		this.checkBox29.Name = "checkBox29";
		this.checkBox29.Size = new System.Drawing.Size(124, 17);
		this.checkBox29.TabIndex = 111;
		this.checkBox29.Text = "Disable Web Search";
		this.checkBox29.UseVisualStyleBackColor = false;
		this.checkBox29.CheckedChanged += new System.EventHandler(checkBox29_CheckedChanged);
		this.checkBox30.AutoSize = true;
		this.checkBox30.BackColor = System.Drawing.Color.Black;
		this.checkBox30.FlatAppearance.BorderSize = 5;
		this.checkBox30.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox30.Location = new System.Drawing.Point(248, 88);
		this.checkBox30.Name = "checkBox30";
		this.checkBox30.Size = new System.Drawing.Size(127, 17);
		this.checkBox30.TabIndex = 110;
		this.checkBox30.Text = "Disable Use Location";
		this.checkBox30.UseVisualStyleBackColor = false;
		this.checkBox30.CheckedChanged += new System.EventHandler(checkBox30_CheckedChanged);
		this.checkBox31.AutoSize = true;
		this.checkBox31.BackColor = System.Drawing.Color.Black;
		this.checkBox31.FlatAppearance.BorderSize = 5;
		this.checkBox31.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox31.Location = new System.Drawing.Point(248, 53);
		this.checkBox31.Name = "checkBox31";
		this.checkBox31.Size = new System.Drawing.Size(101, 17);
		this.checkBox31.TabIndex = 109;
		this.checkBox31.Text = "Disable Cortana";
		this.checkBox31.UseVisualStyleBackColor = false;
		this.checkBox31.CheckedChanged += new System.EventHandler(checkBox31_CheckedChanged);
		this.checkBox32.AutoSize = true;
		this.checkBox32.BackColor = System.Drawing.Color.Black;
		this.checkBox32.FlatAppearance.BorderSize = 5;
		this.checkBox32.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox32.Location = new System.Drawing.Point(449, 14);
		this.checkBox32.Name = "checkBox32";
		this.checkBox32.Size = new System.Drawing.Size(167, 17);
		this.checkBox32.TabIndex = 108;
		this.checkBox32.Text = "Disable Compatibility Assistant";
		this.checkBox32.UseVisualStyleBackColor = false;
		this.checkBox32.CheckedChanged += new System.EventHandler(checkBox32_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.checkBox17);
		base.Controls.Add(this.checkBox18);
		base.Controls.Add(this.checkBox24);
		base.Controls.Add(this.checkBox25);
		base.Controls.Add(this.checkBox26);
		base.Controls.Add(this.checkBox27);
		base.Controls.Add(this.checkBox28);
		base.Controls.Add(this.checkBox29);
		base.Controls.Add(this.checkBox30);
		base.Controls.Add(this.checkBox31);
		base.Controls.Add(this.checkBox32);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.checkBox20);
		base.Controls.Add(this.checkBox21);
		base.Controls.Add(this.checkBox22);
		base.Controls.Add(this.checkBox23);
		base.Controls.Add(this.checkBox33);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox7);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox9);
		base.Controls.Add(this.checkBox10);
		base.Controls.Add(this.checkBox11);
		base.Controls.Add(this.checkBox12);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.pictureBox1);
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl7";
		base.Size = new System.Drawing.Size(619, 605);
		base.Load += new System.EventHandler(UserControl7_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
