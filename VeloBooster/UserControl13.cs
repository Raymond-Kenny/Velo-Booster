using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl13 : UserControl
{
	private IContainer components = null;

	private CheckBox checkBox26;

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

	private CheckBox checkBox14;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private CheckBox checkBox17;

	private CheckBox checkBox18;

	private CheckBox checkBox19;

	private CheckBox checkBox20;

	private CheckBox checkBox21;

	private CheckBox checkBox22;

	private CheckBox checkBox23;

	private CheckBox checkBox24;

	private CheckBox checkBox25;

	private Label label1;

	private PictureBox pictureBox1;

	public UserControl13()
	{
		InitializeComponent();
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "MetaModes", 0, RegistryValueKind.DWord);
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "MIRACastPreserveConnectedState", 0, RegistryValueKind.DWord);
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "ProcCaps", 0, RegistryValueKind.DWord);
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "RebootDisplayStack", 0, RegistryValueKind.DWord);
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "ScheduleActivity", 0, RegistryValueKind.DWord);
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrDelayMode", 1, RegistryValueKind.DWord);
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrLimitTime", 8, RegistryValueKind.DWord);
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrLimitTimeCreation", 4, RegistryValueKind.DWord);
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrLimitTimeDestruction", 4, RegistryValueKind.DWord);
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrLimitTimeIncrease", 2, RegistryValueKind.DWord);
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrLimitTimePause", 2, RegistryValueKind.DWord);
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrThreshold", 16, RegistryValueKind.DWord);
	}

	private void checkBox26_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "VRAMLimitPercent", 100, RegistryValueKind.DWord);
	}

	private void checkBox25_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "BootExecute", new byte[2], RegistryValueKind.Binary);
	}

	private void checkBox24_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "EnableFirstLogonAnimation", 0, RegistryValueKind.DWord);
	}

	private void checkBox23_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "MaxLogSize", 131072, RegistryValueKind.DWord);
	}

	private void checkBox22_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "MaxSize", 61440, RegistryValueKind.DWord);
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "ScheduleRetryTime", 600, RegistryValueKind.DWord);
	}

	private void checkBox20_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "ServiceDllCacheEntryLifetime", 120, RegistryValueKind.DWord);
	}

	private void checkBox19_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "ServiceDllCacheHitLimit", 5, RegistryValueKind.DWord);
	}

	private void UserControl13_Load(object sender, EventArgs e)
	{
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "ServiceDllCacheMissLimit", 10, RegistryValueKind.DWord);
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "ServiceDllUnloadOnStop", 1, RegistryValueKind.DWord);
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "TaskCache", new byte[8] { 198, 154, 167, 100, 44, 219, 207, 1 }, RegistryValueKind.Binary);
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "TaskRetryTime", 2, RegistryValueKind.DWord);
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule", "UseUnifiedSchedulingEngine", 1, RegistryValueKind.DWord);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl13));
		this.checkBox26 = new System.Windows.Forms.CheckBox();
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
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.checkBox17 = new System.Windows.Forms.CheckBox();
		this.checkBox18 = new System.Windows.Forms.CheckBox();
		this.checkBox19 = new System.Windows.Forms.CheckBox();
		this.checkBox20 = new System.Windows.Forms.CheckBox();
		this.checkBox21 = new System.Windows.Forms.CheckBox();
		this.checkBox22 = new System.Windows.Forms.CheckBox();
		this.checkBox23 = new System.Windows.Forms.CheckBox();
		this.checkBox24 = new System.Windows.Forms.CheckBox();
		this.checkBox25 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.checkBox26.AutoSize = true;
		this.checkBox26.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox26.Location = new System.Drawing.Point(14, 500);
		this.checkBox26.Name = "checkBox26";
		this.checkBox26.Size = new System.Drawing.Size(103, 17);
		this.checkBox26.TabIndex = 97;
		this.checkBox26.Text = "Maximize VRAM";
		this.checkBox26.UseVisualStyleBackColor = true;
		this.checkBox26.CheckedChanged += new System.EventHandler(checkBox26_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(14, 462);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(86, 17);
		this.checkBox7.TabIndex = 96;
		this.checkBox7.Text = "Tdr Treshold";
		this.checkBox7.UseVisualStyleBackColor = true;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(14, 421);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(75, 17);
		this.checkBox8.TabIndex = 95;
		this.checkBox8.Text = "Tdr Pause";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(14, 382);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(86, 17);
		this.checkBox9.TabIndex = 94;
		this.checkBox9.Text = "Tdr Increase";
		this.checkBox9.UseVisualStyleBackColor = true;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(14, 336);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(84, 17);
		this.checkBox10.TabIndex = 93;
		this.checkBox10.Text = "Tdr Kill Time";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(14, 295);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(134, 17);
		this.checkBox11.TabIndex = 92;
		this.checkBox11.Text = "Tdr Time Limit Creation";
		this.checkBox11.UseVisualStyleBackColor = true;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox12.AutoSize = true;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(14, 256);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(86, 17);
		this.checkBox12.TabIndex = 91;
		this.checkBox12.Text = "TdrTimeLimit";
		this.checkBox12.UseVisualStyleBackColor = true;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(14, 216);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(96, 17);
		this.checkBox4.TabIndex = 90;
		this.checkBox4.Text = "TdrDelayMode";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(14, 175);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(131, 17);
		this.checkBox5.TabIndex = 89;
		this.checkBox5.Text = "GPU schedule Tweak";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(14, 136);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(156, 17);
		this.checkBox6.TabIndex = 88;
		this.checkBox6.Text = "Disable GPU Reboot Stack";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(14, 90);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(115, 17);
		this.checkBox3.TabIndex = 87;
		this.checkBox3.Text = "GPU Caps Tweak ";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(14, 49);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(146, 17);
		this.checkBox2.TabIndex = 86;
		this.checkBox2.Text = "GPU MIRA CAST Tweak";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(14, 10);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(123, 17);
		this.checkBox1.TabIndex = 85;
		this.checkBox1.Text = "GPU  Modes Tweak";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(196, 382);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(107, 17);
		this.checkBox14.TabIndex = 109;
		this.checkBox14.Text = "Schedule Engine";
		this.checkBox14.UseVisualStyleBackColor = true;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged);
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(196, 341);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(102, 17);
		this.checkBox15.TabIndex = 108;
		this.checkBox15.Text = "Task Retry Limit";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox15.CheckedChanged += new System.EventHandler(checkBox15_CheckedChanged);
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(196, 302);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(117, 17);
		this.checkBox16.TabIndex = 107;
		this.checkBox16.Text = "TaskCache Tweak";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox16.CheckedChanged += new System.EventHandler(checkBox16_CheckedChanged);
		this.checkBox17.AutoSize = true;
		this.checkBox17.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox17.Location = new System.Drawing.Point(196, 256);
		this.checkBox17.Name = "checkBox17";
		this.checkBox17.Size = new System.Drawing.Size(122, 17);
		this.checkBox17.TabIndex = 106;
		this.checkBox17.Text = "Service DLL Unload";
		this.checkBox17.UseVisualStyleBackColor = true;
		this.checkBox17.CheckedChanged += new System.EventHandler(checkBox17_CheckedChanged);
		this.checkBox18.AutoSize = true;
		this.checkBox18.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox18.Location = new System.Drawing.Point(196, 215);
		this.checkBox18.Name = "checkBox18";
		this.checkBox18.Size = new System.Drawing.Size(143, 17);
		this.checkBox18.TabIndex = 105;
		this.checkBox18.Text = "Service DLL Cache Limit";
		this.checkBox18.UseVisualStyleBackColor = true;
		this.checkBox18.CheckedChanged += new System.EventHandler(checkBox18_CheckedChanged);
		this.checkBox19.AutoSize = true;
		this.checkBox19.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox19.Location = new System.Drawing.Point(196, 176);
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.Size = new System.Drawing.Size(125, 17);
		this.checkBox19.TabIndex = 104;
		this.checkBox19.Text = "Service DLL Hit Limit";
		this.checkBox19.UseVisualStyleBackColor = true;
		this.checkBox19.CheckedChanged += new System.EventHandler(checkBox19_CheckedChanged);
		this.checkBox20.AutoSize = true;
		this.checkBox20.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox20.Location = new System.Drawing.Point(196, 136);
		this.checkBox20.Name = "checkBox20";
		this.checkBox20.Size = new System.Drawing.Size(121, 17);
		this.checkBox20.TabIndex = 103;
		this.checkBox20.Text = "Service DLL Tweak";
		this.checkBox20.UseVisualStyleBackColor = true;
		this.checkBox20.CheckedChanged += new System.EventHandler(checkBox20_CheckedChanged);
		this.checkBox21.AutoSize = true;
		this.checkBox21.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox21.Location = new System.Drawing.Point(196, 95);
		this.checkBox21.Name = "checkBox21";
		this.checkBox21.Size = new System.Drawing.Size(113, 17);
		this.checkBox21.TabIndex = 102;
		this.checkBox21.Text = "Retry Time Tweak";
		this.checkBox21.UseVisualStyleBackColor = true;
		this.checkBox21.CheckedChanged += new System.EventHandler(checkBox21_CheckedChanged);
		this.checkBox22.AutoSize = true;
		this.checkBox22.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox22.Location = new System.Drawing.Point(196, 56);
		this.checkBox22.Name = "checkBox22";
		this.checkBox22.Size = new System.Drawing.Size(160, 17);
		this.checkBox22.TabIndex = 101;
		this.checkBox22.Text = "Optimize Max Schedule Size";
		this.checkBox22.UseVisualStyleBackColor = true;
		this.checkBox22.CheckedChanged += new System.EventHandler(checkBox22_CheckedChanged);
		this.checkBox23.AutoSize = true;
		this.checkBox23.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox23.Location = new System.Drawing.Point(196, 10);
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.Size = new System.Drawing.Size(110, 17);
		this.checkBox23.TabIndex = 100;
		this.checkBox23.Text = "Optimize Log Size";
		this.checkBox23.UseVisualStyleBackColor = true;
		this.checkBox23.CheckedChanged += new System.EventHandler(checkBox23_CheckedChanged);
		this.checkBox24.AutoSize = true;
		this.checkBox24.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox24.Location = new System.Drawing.Point(14, 570);
		this.checkBox24.Name = "checkBox24";
		this.checkBox24.Size = new System.Drawing.Size(141, 17);
		this.checkBox24.TabIndex = 99;
		this.checkBox24.Text = "Logon Animation Tweak";
		this.checkBox24.UseVisualStyleBackColor = true;
		this.checkBox24.CheckedChanged += new System.EventHandler(checkBox24_CheckedChanged);
		this.checkBox25.AutoSize = true;
		this.checkBox25.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox25.Location = new System.Drawing.Point(14, 531);
		this.checkBox25.Name = "checkBox25";
		this.checkBox25.Size = new System.Drawing.Size(129, 17);
		this.checkBox25.TabIndex = 98;
		this.checkBox25.Text = "Boot Execude Tweak";
		this.checkBox25.UseVisualStyleBackColor = true;
		this.checkBox25.CheckedChanged += new System.EventHandler(checkBox25_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(193, 425);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(32, 13);
		this.label1.TabIndex = 110;
		this.label1.Text = "Soon";
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(450, 515);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 111;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.checkBox17);
		base.Controls.Add(this.checkBox18);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.checkBox20);
		base.Controls.Add(this.checkBox21);
		base.Controls.Add(this.checkBox22);
		base.Controls.Add(this.checkBox23);
		base.Controls.Add(this.checkBox24);
		base.Controls.Add(this.checkBox25);
		base.Controls.Add(this.checkBox26);
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
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl13";
		base.Size = new System.Drawing.Size(619, 605);
		base.Load += new System.EventHandler(UserControl13_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
