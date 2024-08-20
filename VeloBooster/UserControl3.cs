using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl3 : UserControl
{
	private IContainer components;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox12;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private Label label1;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private CheckBox checkBox17;

	private CheckBox checkBox18;

	private CheckBox checkBox19;

	private CheckBox checkBox20;

	private CheckBox checkBox21;

	private Label label2;

	private CheckBox checkBox22;

	private CheckBox checkBox23;

	private CheckBox checkBox24;

	private CheckBox checkBox27;

	private CheckBox checkBox28;

	private Label label5;

	private Label label6;

	private ComboBox comboBox1;

	private TextBox textBox3;

	private Label label7;

	private CheckBox checkBox29;

	private CheckBox checkBox30;

	private CheckBox checkBox31;

	private CheckBox checkBox32;

	private CheckBox checkBox33;

	private PictureBox pictureBox1;

	public UserControl3()
	{
		InitializeComponent();
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrDelay", 10, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000\\UMD", "GPU scaling mode", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0001\\UMD", "GPU scaling mode", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox14.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrDelay", 10, RegistryValueKind.DWord);
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox13.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Direct3D", "Threaded Optimization", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox12.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "AllocateDASD", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "AllocateFloppies", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "AllocateCDRoms", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "AllocateDASD", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "ApertureSize", 256, RegistryValueKind.DWord);
		}
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox11.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class{4d36e968-e325-11ce-bfc1-08002be10318}\\0000", "PP_Table_Psm", 3000, RegistryValueKind.DWord);
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox10.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrDdiDelay", 10, RegistryValueKind.DWord);
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox9.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\OpenGLDrivers\\wglSwapLayerBuffers", "GPUThreadPriority", 3, RegistryValueKind.DWord);
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "PerfLevelSrc", 2500, RegistryValueKind.DWord);
		}
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox7.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Avalon.Graphics", "Override", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "GpuFullPwrOpt", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Intel\\GMM", "PerfBoostMode", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "DisableGpuScheduler", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox33_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox33.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "AutoSwitch", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox21.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "EnableUmd", 1, RegistryValueKind.DWord);
		}
	}

	private void UserControl3_Load(object sender, EventArgs e)
	{
	}

	private void checkBox32_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox32.Checked)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "Disable Hardware Acceleration", 0, RegistryValueKind.DWord);
		}
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		if (textBox3.Text == "-")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "Dedicated Video Memory", textBox3.Text, RegistryValueKind.DWord);
		}
	}

	private void checkBox20_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox20.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdPagingMode", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox19_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox19.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdMclkStutterMode", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdMclkStutterEnable", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdMclkStutterDuration", 5, RegistryValueKind.DWord);
		}
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox18.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdUlpsMode", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdUlpsEnable", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdUlpsDuration", 3, RegistryValueKind.DWord);
		}
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox15.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdGfxClockGatingEnable", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdGfxClkGatingDuration", 3, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdPowerGatingEnable", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdPowerGatingDuration", 5, RegistryValueKind.DWord);
		}
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox16.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdDynamicPowerGatingEnable", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UmdDynamicPowerGatingDuration", 3, RegistryValueKind.DWord);
		}
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox17.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdkmdag\\Parameters", "UMDHALPowerSavingLevel", 1, RegistryValueKind.DWord);
		}
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (comboBox1.SelectedIndex == 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "PerfLevelSrc", "0", RegistryValueKind.DWord);
		}
		if (comboBox1.SelectedIndex == 1)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "PerfLevelSrc", "1", RegistryValueKind.DWord);
		}
		if (comboBox1.SelectedIndex == 2)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "PerfLevelSrc", "2", RegistryValueKind.DWord);
		}
		if (comboBox1.SelectedIndex == 3)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "PerfLevelSrc", "3", RegistryValueKind.DWord);
		}
		if (comboBox1.SelectedIndex == 4)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "PerfLevelSrc", "4", RegistryValueKind.DWord);
		}
	}

	private void textBox3_TextChanged_1(object sender, EventArgs e)
	{
		if (textBox3.Text == "-")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "Dedicated Video Memory", textBox3.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void checkBox28_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox28.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "AdaptiveShadingLevel", 2, RegistryValueKind.DWord);
		}
	}

	private void checkBox27_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox27.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TdrDelay", 10, RegistryValueKind.DWord);
		}
	}

	private void checkBox25_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void checkBox26_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox24_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox24.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\Global\\NVTweak", "NVDT_EnablePerfBoost", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox23_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox23.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\GlobalUpdate", "UpdateExePath", "C:\\Program Files\\NVIDIA Corporation\\Update Core\\NvBackend.exe", RegistryValueKind.String);
		}
	}

	private void checkBox22_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox22.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\Global\\Scheduler", "DvmEnabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\Global\\Scheduler", "DvmPolicy", 2, RegistryValueKind.DWord);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl3));
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.checkBox17 = new System.Windows.Forms.CheckBox();
		this.checkBox18 = new System.Windows.Forms.CheckBox();
		this.checkBox19 = new System.Windows.Forms.CheckBox();
		this.checkBox20 = new System.Windows.Forms.CheckBox();
		this.checkBox21 = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBox22 = new System.Windows.Forms.CheckBox();
		this.checkBox23 = new System.Windows.Forms.CheckBox();
		this.checkBox24 = new System.Windows.Forms.CheckBox();
		this.checkBox27 = new System.Windows.Forms.CheckBox();
		this.checkBox28 = new System.Windows.Forms.CheckBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.checkBox29 = new System.Windows.Forms.CheckBox();
		this.checkBox30 = new System.Windows.Forms.CheckBox();
		this.checkBox31 = new System.Windows.Forms.CheckBox();
		this.checkBox32 = new System.Windows.Forms.CheckBox();
		this.checkBox33 = new System.Windows.Forms.CheckBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.checkBox10.AutoSize = true;
		this.checkBox10.BackColor = System.Drawing.Color.Black;
		this.checkBox10.FlatAppearance.BorderSize = 5;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(15, 250);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(129, 17);
		this.checkBox10.TabIndex = 37;
		this.checkBox10.Text = "Increase TdrDdiDelay";
		this.checkBox10.UseVisualStyleBackColor = false;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.BackColor = System.Drawing.Color.Black;
		this.checkBox11.FlatAppearance.BorderSize = 5;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(15, 211);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(176, 17);
		this.checkBox11.TabIndex = 36;
		this.checkBox11.Text = "Increase Graphics Card Voltage";
		this.checkBox11.UseVisualStyleBackColor = false;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox12.AutoSize = true;
		this.checkBox12.BackColor = System.Drawing.Color.Black;
		this.checkBox12.FlatAppearance.BorderSize = 5;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(15, 167);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(178, 17);
		this.checkBox12.TabIndex = 35;
		this.checkBox12.Text = "Increase Graphics Aperture Size";
		this.checkBox12.UseVisualStyleBackColor = false;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.checkBox13.AutoSize = true;
		this.checkBox13.BackColor = System.Drawing.Color.Black;
		this.checkBox13.FlatAppearance.BorderSize = 5;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(15, 126);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(151, 17);
		this.checkBox13.TabIndex = 34;
		this.checkBox13.Text = "Set Threaded Optimization";
		this.checkBox13.UseVisualStyleBackColor = false;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.BackColor = System.Drawing.Color.Black;
		this.checkBox14.FlatAppearance.BorderSize = 5;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(15, 90);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(136, 17);
		this.checkBox14.TabIndex = 33;
		this.checkBox14.Text = "Set GPU Scaling Mode";
		this.checkBox14.UseVisualStyleBackColor = false;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.BackColor = System.Drawing.Color.Black;
		this.checkBox5.FlatAppearance.BorderSize = 5;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(15, 55);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(126, 17);
		this.checkBox5.TabIndex = 32;
		this.checkBox5.Text = "Disable Vertical Sync";
		this.checkBox5.UseVisualStyleBackColor = false;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.BackColor = System.Drawing.Color.Black;
		this.checkBox6.FlatAppearance.BorderSize = 5;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(15, 16);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(149, 17);
		this.checkBox6.TabIndex = 31;
		this.checkBox6.Text = "Increase GPU TDR Delay";
		this.checkBox6.UseVisualStyleBackColor = false;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.BackColor = System.Drawing.Color.Black;
		this.checkBox3.FlatAppearance.BorderSize = 5;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(15, 391);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(138, 17);
		this.checkBox3.TabIndex = 42;
		this.checkBox3.Text = "Disable GPU Scheduler";
		this.checkBox3.UseVisualStyleBackColor = false;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.BackColor = System.Drawing.Color.Black;
		this.checkBox4.FlatAppearance.BorderSize = 5;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(239, 462);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(164, 17);
		this.checkBox4.TabIndex = 41;
		this.checkBox4.Text = "Increase Graphics Heap Size";
		this.checkBox4.UseVisualStyleBackColor = false;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.BackColor = System.Drawing.Color.Black;
		this.checkBox7.FlatAppearance.BorderSize = 5;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(15, 356);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(157, 17);
		this.checkBox7.TabIndex = 40;
		this.checkBox7.Text = "Disable Forced Anti-Aliasing";
		this.checkBox7.UseVisualStyleBackColor = false;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.BackColor = System.Drawing.Color.Black;
		this.checkBox8.FlatAppearance.BorderSize = 5;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(15, 321);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(116, 17);
		this.checkBox8.TabIndex = 39;
		this.checkBox8.Text = "Rapid performance";
		this.checkBox8.UseVisualStyleBackColor = false;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.BackColor = System.Drawing.Color.Black;
		this.checkBox9.FlatAppearance.BorderSize = 5;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(15, 282);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(164, 17);
		this.checkBox9.TabIndex = 38;
		this.checkBox9.Text = "Increase GPU Thread Priority";
		this.checkBox9.UseVisualStyleBackColor = false;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.SystemColors.Control;
		this.label1.Location = new System.Drawing.Point(270, 8);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(79, 33);
		this.label1.TabIndex = 45;
		this.label1.Text = "AMD";
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(248, 250);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(135, 17);
		this.checkBox15.TabIndex = 52;
		this.checkBox15.Text = "Disable Power Savings";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(248, 218);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(169, 17);
		this.checkBox16.TabIndex = 51;
		this.checkBox16.Text = "Dnable Dynamic Power gating";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox17.AutoSize = true;
		this.checkBox17.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox17.Location = new System.Drawing.Point(248, 184);
		this.checkBox17.Name = "checkBox17";
		this.checkBox17.Size = new System.Drawing.Size(120, 17);
		this.checkBox17.TabIndex = 50;
		this.checkBox17.Text = "Enable clock gating";
		this.checkBox17.UseVisualStyleBackColor = true;
		this.checkBox18.AutoSize = true;
		this.checkBox18.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox18.Location = new System.Drawing.Point(248, 148);
		this.checkBox18.Name = "checkBox18";
		this.checkBox18.Size = new System.Drawing.Size(114, 17);
		this.checkBox18.TabIndex = 49;
		this.checkBox18.Text = "Disable ALL ULPS";
		this.checkBox18.UseVisualStyleBackColor = true;
		this.checkBox19.AutoSize = true;
		this.checkBox19.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox19.Location = new System.Drawing.Point(248, 115);
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.Size = new System.Drawing.Size(127, 17);
		this.checkBox19.TabIndex = 48;
		this.checkBox19.Text = "Improve Stutter mode";
		this.checkBox19.UseVisualStyleBackColor = true;
		this.checkBox20.AutoSize = true;
		this.checkBox20.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox20.Location = new System.Drawing.Point(248, 83);
		this.checkBox20.Name = "checkBox20";
		this.checkBox20.Size = new System.Drawing.Size(124, 17);
		this.checkBox20.TabIndex = 47;
		this.checkBox20.Text = "Disable UMD paging";
		this.checkBox20.UseVisualStyleBackColor = true;
		this.checkBox21.AutoSize = true;
		this.checkBox21.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox21.Location = new System.Drawing.Point(248, 49);
		this.checkBox21.Name = "checkBox21";
		this.checkBox21.Size = new System.Drawing.Size(143, 17);
		this.checkBox21.TabIndex = 46;
		this.checkBox21.Text = "Enable AMD UMD driver";
		this.checkBox21.UseVisualStyleBackColor = true;
		this.checkBox21.CheckedChanged += new System.EventHandler(checkBox21_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.SystemColors.Control;
		this.label2.Location = new System.Drawing.Point(474, 16);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(111, 33);
		this.label2.TabIndex = 53;
		this.label2.Text = "NVIDIA";
		this.checkBox22.AutoSize = true;
		this.checkBox22.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox22.Location = new System.Drawing.Point(454, 230);
		this.checkBox22.Name = "checkBox22";
		this.checkBox22.Size = new System.Drawing.Size(80, 17);
		this.checkBox22.TabIndex = 80;
		this.checkBox22.Text = "DVM Boost";
		this.checkBox22.UseVisualStyleBackColor = true;
		this.checkBox22.CheckedChanged += new System.EventHandler(checkBox22_CheckedChanged);
		this.checkBox23.AutoSize = true;
		this.checkBox23.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox23.Location = new System.Drawing.Point(454, 191);
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.Size = new System.Drawing.Size(112, 17);
		this.checkBox23.TabIndex = 75;
		this.checkBox23.Text = "Auto Update GPU";
		this.checkBox23.UseVisualStyleBackColor = true;
		this.checkBox23.CheckedChanged += new System.EventHandler(checkBox23_CheckedChanged);
		this.checkBox24.AutoSize = true;
		this.checkBox24.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox24.Location = new System.Drawing.Point(454, 151);
		this.checkBox24.Name = "checkBox24";
		this.checkBox24.Size = new System.Drawing.Size(148, 17);
		this.checkBox24.TabIndex = 74;
		this.checkBox24.Text = "Auto Display Performance";
		this.checkBox24.UseVisualStyleBackColor = true;
		this.checkBox24.CheckedChanged += new System.EventHandler(checkBox24_CheckedChanged);
		this.checkBox27.AutoSize = true;
		this.checkBox27.Checked = true;
		this.checkBox27.CheckState = System.Windows.Forms.CheckState.Checked;
		this.checkBox27.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox27.Location = new System.Drawing.Point(457, 111);
		this.checkBox27.Name = "checkBox27";
		this.checkBox27.Size = new System.Drawing.Size(135, 17);
		this.checkBox27.TabIndex = 71;
		this.checkBox27.Text = "Allow Gpu Idle Timeout";
		this.checkBox27.UseVisualStyleBackColor = true;
		this.checkBox27.CheckedChanged += new System.EventHandler(checkBox27_CheckedChanged);
		this.checkBox28.AutoSize = true;
		this.checkBox28.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox28.Location = new System.Drawing.Point(457, 74);
		this.checkBox28.Name = "checkBox28";
		this.checkBox28.Size = new System.Drawing.Size(139, 17);
		this.checkBox28.TabIndex = 70;
		this.checkBox28.Text = "Adaptive Shading Level";
		this.checkBox28.UseVisualStyleBackColor = true;
		this.checkBox28.CheckedChanged += new System.EventHandler(checkBox28_CheckedChanged);
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.SystemColors.Control;
		this.label5.Location = new System.Drawing.Point(270, 280);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(97, 33);
		this.label5.TabIndex = 81;
		this.label5.Text = "INTEL";
		this.label6.AutoSize = true;
		this.label6.ForeColor = System.Drawing.SystemColors.Control;
		this.label6.Location = new System.Drawing.Point(239, 486);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(111, 13);
		this.label6.TabIndex = 89;
		this.label6.Text = "GPU Rendering mode";
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[5] { "Maximum Performance", "Defualt", "BIOS Level", "OS Level", "Application level" });
		this.comboBox1.Location = new System.Drawing.Point(239, 515);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(144, 21);
		this.comboBox1.TabIndex = 88;
		this.comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
		this.textBox3.Location = new System.Drawing.Point(239, 573);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new System.Drawing.Size(148, 20);
		this.textBox3.TabIndex = 87;
		this.textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged_1);
		this.label7.AutoSize = true;
		this.label7.ForeColor = System.Drawing.SystemColors.Control;
		this.label7.Location = new System.Drawing.Point(236, 543);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(163, 13);
		this.label7.TabIndex = 86;
		this.label7.Text = "Allocate Dedicated GPU Memory";
		this.checkBox29.AutoSize = true;
		this.checkBox29.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox29.Location = new System.Drawing.Point(239, 433);
		this.checkBox29.Name = "checkBox29";
		this.checkBox29.Size = new System.Drawing.Size(151, 17);
		this.checkBox29.TabIndex = 85;
		this.checkBox29.Text = "Enable Performance mode";
		this.checkBox29.UseVisualStyleBackColor = true;
		this.checkBox30.AutoSize = true;
		this.checkBox30.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox30.Location = new System.Drawing.Point(239, 401);
		this.checkBox30.Name = "checkBox30";
		this.checkBox30.Size = new System.Drawing.Size(212, 17);
		this.checkBox30.TabIndex = 84;
		this.checkBox30.Text = "Maximize Low performance state power";
		this.checkBox30.UseVisualStyleBackColor = true;
		this.checkBox31.AutoSize = true;
		this.checkBox31.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox31.Location = new System.Drawing.Point(239, 363);
		this.checkBox31.Name = "checkBox31";
		this.checkBox31.Size = new System.Drawing.Size(139, 17);
		this.checkBox31.TabIndex = 83;
		this.checkBox31.Text = "Enable Maximum Power";
		this.checkBox31.UseVisualStyleBackColor = true;
		this.checkBox32.AutoSize = true;
		this.checkBox32.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox32.Location = new System.Drawing.Point(239, 325);
		this.checkBox32.Name = "checkBox32";
		this.checkBox32.Size = new System.Drawing.Size(172, 17);
		this.checkBox32.TabIndex = 82;
		this.checkBox32.Text = "Disable Hardware Acceleration";
		this.checkBox32.UseVisualStyleBackColor = true;
		this.checkBox33.AutoSize = true;
		this.checkBox33.BackColor = System.Drawing.Color.Black;
		this.checkBox33.FlatAppearance.BorderSize = 5;
		this.checkBox33.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox33.Location = new System.Drawing.Point(15, 433);
		this.checkBox33.Name = "checkBox33";
		this.checkBox33.Size = new System.Drawing.Size(119, 17);
		this.checkBox33.TabIndex = 90;
		this.checkBox33.Text = "Enable Auto Switch";
		this.checkBox33.UseVisualStyleBackColor = false;
		this.checkBox33.CheckedChanged += new System.EventHandler(checkBox33_CheckedChanged);
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(450, 515);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 98;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.checkBox33);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.comboBox1);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.checkBox29);
		base.Controls.Add(this.checkBox30);
		base.Controls.Add(this.checkBox31);
		base.Controls.Add(this.checkBox32);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.checkBox22);
		base.Controls.Add(this.checkBox23);
		base.Controls.Add(this.checkBox24);
		base.Controls.Add(this.checkBox27);
		base.Controls.Add(this.checkBox28);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.checkBox17);
		base.Controls.Add(this.checkBox18);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.checkBox20);
		base.Controls.Add(this.checkBox21);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox4);
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
		base.Name = "UserControl3";
		base.Size = new System.Drawing.Size(619, 605);
		base.Load += new System.EventHandler(UserControl3_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
