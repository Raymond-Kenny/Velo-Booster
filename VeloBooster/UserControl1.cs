using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl1 : UserControl
{
	private IContainer components;

	private CheckBox checkBox1;

	private CheckBox checkBox2;

	private CheckBox checkBox3;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox14;

	private CheckBox checkBox15;

	private CheckBox checkBox17;

	private CheckBox checkBox18;

	private CheckBox checkBox19;

	private CheckBox checkBox21;

	private CheckBox checkBox22;

	private TextBox textBox1;

	private Label label1;

	private Label label2;

	private TextBox textBox2;

	private Label label3;

	private TextBox textBox3;

	private Label label4;

	private TextBox textBox4;

	private CheckBox checkBox4;

	private CheckBox checkBox6;

	private CheckBox checkBox16;

	private CheckBox checkBox23;

	private CheckBox checkBox24;

	private CheckBox checkBox5;

	private PictureBox pictureBox1;

	public UserControl1()
	{
		InitializeComponent();
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR", "AllowGameDVR", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\System\\GameConfigStore", "GameDVR_FSEBehaviorMode", 2, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\System\\GameConfigStore\\DirectX\\dxgi", "DisableFullScreenOptimizations", 1, RegistryValueKind.DWord);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\System\\GameConfigStore", "MaxForegroundFPS", textBox1.Text, RegistryValueKind.DWord);
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\System\\GameConfigStore", "MaxBackgroundFPS", textBox2.Text, RegistryValueKind.DWord);
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox7.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power", "PowerThrottlingOff", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\HighPrecisionEventTimer", "UsePlatformClock", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox15.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "DisableOnDesktopRuntimeBroker", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox14.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", "EnableSuperfetch", 0, RegistryValueKind.DWord);
		}
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "GameResponsiveness", textBox3.Text, RegistryValueKind.DWord);
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox11.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\System\\GameConfigStore", "AllowBackgroundRecording", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox10.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power", "DynamicTick", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox9.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "NoAutoUpdate", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox22_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox22.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseAcceleration", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox21.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Audio", "DisableProtectedAudioDG", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox19_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox19.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU", "NoAutoRebootWithLoggedOnUsers", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox18.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "PriorityBoost", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox17.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "ThumbnailCacheSize", 1388, RegistryValueKind.DWord);
		}
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "PagingFiles", "C:\\pagefile.sys" + textBox4.Text, RegistryValueKind.String);
	}

	private void checkBox24_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox24.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 38, RegistryValueKind.DWord);
		}
	}

	private void checkBox23_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox23.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\\PowerSettings\\54533251-82be-4824-96c1-47b60b740d00\\0cc5b647-c1df-4637-891a-dec35c318583", "Value", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox16.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4d36e968-e325-11ce-bfc1-08002be10318}\\0000", "PowerMizerPowerManagement", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "ForegroundPriorityBoost", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Configuration\\IdleMaintenance", "MaintenanceDisabled", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\PowerCfg\\GlobalPowerPolicy", "ProcOptimize", 1, RegistryValueKind.DWord);
		}
	}

	private void UserControl1_Load(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl1));
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox17 = new System.Windows.Forms.CheckBox();
		this.checkBox18 = new System.Windows.Forms.CheckBox();
		this.checkBox19 = new System.Windows.Forms.CheckBox();
		this.checkBox21 = new System.Windows.Forms.CheckBox();
		this.checkBox22 = new System.Windows.Forms.CheckBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.checkBox23 = new System.Windows.Forms.CheckBox();
		this.checkBox24 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(13, 31);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(107, 17);
		this.checkBox1.TabIndex = 0;
		this.checkBox1.Text = "Disable Gamebar";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(13, 70);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(122, 17);
		this.checkBox2.TabIndex = 1;
		this.checkBox2.Text = "Disable Game Mode";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(13, 111);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(172, 17);
		this.checkBox3.TabIndex = 2;
		this.checkBox3.Text = "Disable Fullscreen Optimization";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(13, 264);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(141, 17);
		this.checkBox7.TabIndex = 6;
		this.checkBox7.Text = "Disable Power Throttling";
		this.checkBox7.UseVisualStyleBackColor = true;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(13, 305);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(93, 17);
		this.checkBox8.TabIndex = 7;
		this.checkBox8.Text = "Disable HPET";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(13, 576);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(247, 17);
		this.checkBox9.TabIndex = 14;
		this.checkBox9.Text = "Disable Windows Update Delivery Optimization";
		this.checkBox9.UseVisualStyleBackColor = true;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(13, 535);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(129, 17);
		this.checkBox10.TabIndex = 13;
		this.checkBox10.Text = "Disable Dynamic Tick";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(13, 497);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(174, 17);
		this.checkBox11.TabIndex = 12;
		this.checkBox11.Text = "Disable Background Recording";
		this.checkBox11.UseVisualStyleBackColor = true;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(13, 382);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(116, 17);
		this.checkBox14.TabIndex = 9;
		this.checkBox14.Text = "Disable Superfetch";
		this.checkBox14.UseVisualStyleBackColor = true;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged);
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(13, 341);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(142, 17);
		this.checkBox15.TabIndex = 8;
		this.checkBox15.Text = "Optimize Runtime Broker";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox15.CheckedChanged += new System.EventHandler(checkBox15_CheckedChanged);
		this.checkBox17.AutoSize = true;
		this.checkBox17.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox17.Location = new System.Drawing.Point(285, 185);
		this.checkBox17.Name = "checkBox17";
		this.checkBox17.Size = new System.Drawing.Size(163, 17);
		this.checkBox17.TabIndex = 20;
		this.checkBox17.Text = "Increase Texture Cache Size";
		this.checkBox17.UseVisualStyleBackColor = true;
		this.checkBox17.CheckedChanged += new System.EventHandler(checkBox17_CheckedChanged);
		this.checkBox18.AutoSize = true;
		this.checkBox18.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox18.Location = new System.Drawing.Point(285, 147);
		this.checkBox18.Name = "checkBox18";
		this.checkBox18.Size = new System.Drawing.Size(106, 17);
		this.checkBox18.TabIndex = 19;
		this.checkBox18.Text = "Set Priority Boost";
		this.checkBox18.UseVisualStyleBackColor = true;
		this.checkBox18.CheckedChanged += new System.EventHandler(checkBox18_CheckedChanged);
		this.checkBox19.AutoSize = true;
		this.checkBox19.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox19.Location = new System.Drawing.Point(285, 108);
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.Size = new System.Drawing.Size(203, 17);
		this.checkBox19.TabIndex = 18;
		this.checkBox19.Text = "Disable Forced Reboot After Updates";
		this.checkBox19.UseVisualStyleBackColor = true;
		this.checkBox19.CheckedChanged += new System.EventHandler(checkBox19_CheckedChanged);
		this.checkBox21.AutoSize = true;
		this.checkBox21.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox21.Location = new System.Drawing.Point(287, 70);
		this.checkBox21.Name = "checkBox21";
		this.checkBox21.Size = new System.Drawing.Size(129, 17);
		this.checkBox21.TabIndex = 16;
		this.checkBox21.Text = "Improve Audio Quality";
		this.checkBox21.UseVisualStyleBackColor = true;
		this.checkBox21.CheckedChanged += new System.EventHandler(checkBox21_CheckedChanged);
		this.checkBox22.AutoSize = true;
		this.checkBox22.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox22.Location = new System.Drawing.Point(287, 29);
		this.checkBox22.Name = "checkBox22";
		this.checkBox22.Size = new System.Drawing.Size(163, 17);
		this.checkBox22.TabIndex = 15;
		this.checkBox22.Text = "Optimize Mouse Acceleration";
		this.checkBox22.UseVisualStyleBackColor = true;
		this.checkBox22.CheckedChanged += new System.EventHandler(checkBox22_CheckedChanged);
		this.textBox1.Location = new System.Drawing.Point(13, 165);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(100, 20);
		this.textBox1.TabIndex = 22;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.SystemColors.Control;
		this.label1.Location = new System.Drawing.Point(10, 146);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(126, 13);
		this.label1.TabIndex = 23;
		this.label1.Text = "Set Max Foreground FPS";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.SystemColors.Control;
		this.label2.Location = new System.Drawing.Point(6, 205);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(130, 13);
		this.label2.TabIndex = 25;
		this.label2.Text = "Set Max Background FPS";
		this.textBox2.Location = new System.Drawing.Point(13, 223);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(100, 20);
		this.textBox2.TabIndex = 24;
		this.textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.SystemColors.Control;
		this.label3.Location = new System.Drawing.Point(6, 420);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(135, 13);
		this.label3.TabIndex = 27;
		this.label3.Text = "Set Game Responsiveness";
		this.textBox3.Location = new System.Drawing.Point(9, 445);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new System.Drawing.Size(100, 20);
		this.textBox3.TabIndex = 26;
		this.textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.SystemColors.Control;
		this.label4.Location = new System.Drawing.Point(276, 226);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(76, 13);
		this.label4.TabIndex = 29;
		this.label4.Text = "Virtual Memory";
		this.textBox4.Location = new System.Drawing.Point(279, 251);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new System.Drawing.Size(100, 20);
		this.textBox4.TabIndex = 28;
		this.textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(278, 438);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(173, 17);
		this.checkBox4.TabIndex = 37;
		this.checkBox4.Text = "Disable Idle Maintenance Task";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(278, 396);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(197, 17);
		this.checkBox6.TabIndex = 35;
		this.checkBox6.Text = "Increase Priority of Foreground Apps";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(278, 359);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(187, 17);
		this.checkBox16.TabIndex = 32;
		this.checkBox16.Text = "Increase Power Plan Performance";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox16.CheckedChanged += new System.EventHandler(checkBox16_CheckedChanged);
		this.checkBox23.AutoSize = true;
		this.checkBox23.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox23.Location = new System.Drawing.Point(279, 323);
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.Size = new System.Drawing.Size(125, 17);
		this.checkBox23.TabIndex = 31;
		this.checkBox23.Text = "Disable CPU Parking";
		this.checkBox23.UseVisualStyleBackColor = true;
		this.checkBox23.CheckedChanged += new System.EventHandler(checkBox23_CheckedChanged);
		this.checkBox24.AutoSize = true;
		this.checkBox24.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox24.Location = new System.Drawing.Point(279, 287);
		this.checkBox24.Name = "checkBox24";
		this.checkBox24.Size = new System.Drawing.Size(148, 17);
		this.checkBox24.TabIndex = 30;
		this.checkBox24.Text = "Set Processor Scheduling";
		this.checkBox24.UseVisualStyleBackColor = true;
		this.checkBox24.CheckedChanged += new System.EventHandler(checkBox24_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.BackColor = System.Drawing.Color.Transparent;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(278, 473);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(202, 17);
		this.checkBox5.TabIndex = 38;
		this.checkBox5.Text = "Enable Processor Performance Mode";
		this.checkBox5.UseVisualStyleBackColor = false;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(450, 515);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 73;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.checkBox23);
		base.Controls.Add(this.checkBox24);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.checkBox17);
		base.Controls.Add(this.checkBox18);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.checkBox21);
		base.Controls.Add(this.checkBox22);
		base.Controls.Add(this.checkBox9);
		base.Controls.Add(this.checkBox10);
		base.Controls.Add(this.checkBox11);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox7);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.pictureBox1);
		base.Name = "UserControl1";
		base.Size = new System.Drawing.Size(619, 605);
		base.Load += new System.EventHandler(UserControl1_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
