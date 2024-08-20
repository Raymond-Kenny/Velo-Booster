using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl2 : UserControl
{
	private PerformanceCounter perfCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");

	private PerformanceCounter perfRAM = new PerformanceCounter("Memory", "Available MBytes");

	private IContainer components;

	private TextBox textBox3;

	private Label label7;

	private CheckBox checkBox1;

	private PictureBox pictureBox1;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox2;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private CheckBox checkBox12;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private CheckBox checkBox15;

	private ComboBox comboBox1;

	private Label label4;

	private TrackBar trackBar1;

	private Label label5;

	private Label label1;

	private CheckBox checkBox16;

	private Label label2;

	private Label label3;

	private TrackBar trackBar2;

	private Label label6;

	private Label label8;

	private TrackBar trackBar3;

	private Label label9;

	private Label label10;

	private TrackBar trackBar4;

	private Label label11;

	private Label label12;

	private TrackBar trackBar5;

	private Label label13;

	private Label label14;

	private TrackBar trackBar6;

	public UserControl2()
	{
		InitializeComponent();
	}

	private void UserControl2_Load(object sender, EventArgs e)
	{
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\DWM", "DWMMaxFPS", textBox3.Text, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\DWM", "DWMMaxFrameRate", textBox3.Text, RegistryValueKind.DWord);
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\DWM", "DwmUseDetailTexture", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "UserPresencePredictionEnabled", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "CoalescingTimerInterval", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "CpuPriorityClass", 3, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "DisableCpuQuota", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "DisableDynamicProcessorClocks", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox9.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "KernelCpuTimeLimit", 4000, RegistryValueKind.DWord);
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ProcessorParkedForGui", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox7.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ProcessorParkedForKernel", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox15.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ProcessorParkedForServer", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox15.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ProcessorScheduler", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox15.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ProcessorThreadPriority", 24, RegistryValueKind.DWord);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox15.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ThreadQuantum", 18, RegistryValueKind.DWord);
		}
	}

	private void trackBar1_Scroll(object sender, EventArgs e)
	{
		label1.Text = trackBar1.Value.ToString();
		if (trackBar1.Value == 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ThreadQuantum", trackBar1.Value, RegistryValueKind.DWord);
		}
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (comboBox1.SelectedIndex == 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ProcessorType", "x86", RegistryValueKind.String);
		}
		else if (comboBox1.SelectedIndex == 1)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ProcessorType", "AMD64", RegistryValueKind.String);
		}
		else if (comboBox1.SelectedIndex == 2)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\PerfOptions", "ProcessorType", "IA64", RegistryValueKind.String);
		}
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox16.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\intelppm\\Parameters", "C1eEnabled", 1, RegistryValueKind.DWord);
		}
	}

	private void trackBar2_Scroll(object sender, EventArgs e)
	{
		label2.Text = trackBar2.Value.ToString();
		if (trackBar2.Value == 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\intelppm\\Parameters", "IdleStateMaxTime", trackBar2.Value, RegistryValueKind.DWord);
		}
	}

	private void trackBar3_Scroll(object sender, EventArgs e)
	{
		label6.Text = trackBar3.Value.ToString();
		if (trackBar3.Value == 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\intelppm\\Parameters", "PerfDecreaseThreshold", trackBar3.Value, RegistryValueKind.DWord);
		}
	}

	private void trackBar4_Scroll(object sender, EventArgs e)
	{
		label9.Text = trackBar4.Value.ToString();
		if (trackBar3.Value == 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\intelppm\\Parameters", "PerfIncreaseThreshold", trackBar4.Value, RegistryValueKind.DWord);
		}
	}

	private void trackBar5_Scroll(object sender, EventArgs e)
	{
		label11.Text = trackBar5.Value.ToString();
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\intelppm\\Parameters", "ReductionPercentage", trackBar5.Value, RegistryValueKind.DWord);
	}

	private void trackBar6_Scroll(object sender, EventArgs e)
	{
		label13.Text = trackBar6.Value.ToString();
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\intelppm\\Parameters", "IncreasePercentage", trackBar6.Value, RegistryValueKind.DWord);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl2));
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.label4 = new System.Windows.Forms.Label();
		this.trackBar1 = new System.Windows.Forms.TrackBar();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.trackBar2 = new System.Windows.Forms.TrackBar();
		this.label6 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.trackBar3 = new System.Windows.Forms.TrackBar();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.trackBar4 = new System.Windows.Forms.TrackBar();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.trackBar5 = new System.Windows.Forms.TrackBar();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.trackBar6 = new System.Windows.Forms.TrackBar();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar6).BeginInit();
		base.SuspendLayout();
		this.textBox3.Location = new System.Drawing.Point(13, 572);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new System.Drawing.Size(148, 20);
		this.textBox3.TabIndex = 89;
		this.textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
		this.label7.AutoSize = true;
		this.label7.ForeColor = System.Drawing.SystemColors.Control;
		this.label7.Location = new System.Drawing.Point(10, 541);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(105, 13);
		this.label7.TabIndex = 88;
		this.label7.Text = "Maximum DWM FPS";
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(243, 16);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(130, 17);
		this.checkBox1.TabIndex = 96;
		this.checkBox1.Text = "Lower DWM Textures";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(447, 512);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 97;
		this.pictureBox1.TabStop = false;
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(242, 56);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(136, 17);
		this.checkBox5.TabIndex = 111;
		this.checkBox5.Text = "Disable User Prediction";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(242, 100);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(186, 17);
		this.checkBox6.TabIndex = 112;
		this.checkBox6.Text = "Disable Coalescing Timer Interval ";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(17, 101);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(188, 17);
		this.checkBox2.TabIndex = 115;
		this.checkBox2.Text = "Disable Dynamic Processor Clock ";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(17, 66);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(115, 17);
		this.checkBox3.TabIndex = 114;
		this.checkBox3.Text = "Disable Cpu Quota";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(17, 33);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(120, 17);
		this.checkBox4.TabIndex = 113;
		this.checkBox4.Text = "Improve Cpu Priority";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(17, 206);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(145, 17);
		this.checkBox7.TabIndex = 118;
		this.checkBox7.Text = "Unpark CPU From Kernel";
		this.checkBox7.UseVisualStyleBackColor = true;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(17, 171);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(131, 17);
		this.checkBox8.TabIndex = 117;
		this.checkBox8.Text = "Unpark CPU from GUI";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(17, 138);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(148, 17);
		this.checkBox9.TabIndex = 116;
		this.checkBox9.Text = "Improve Kernel CPU Time";
		this.checkBox9.UseVisualStyleBackColor = true;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox12.AutoSize = true;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(17, 345);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(214, 17);
		this.checkBox12.TabIndex = 122;
		this.checkBox12.Text = "Increase Thread Dcheduling Granularity";
		this.checkBox12.UseVisualStyleBackColor = true;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.checkBox13.AutoSize = true;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(17, 308);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(188, 17);
		this.checkBox13.TabIndex = 121;
		this.checkBox13.Text = "Increase Processor Thread Priority\r\n";
		this.checkBox13.UseVisualStyleBackColor = true;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(17, 273);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(166, 17);
		this.checkBox14.TabIndex = 120;
		this.checkBox14.Text = "Optimize CPU For Foreground";
		this.checkBox14.UseVisualStyleBackColor = true;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged);
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(17, 240);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(146, 17);
		this.checkBox15.TabIndex = 119;
		this.checkBox15.Text = "Unpark CPU From Server\r\n";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox15.CheckedChanged += new System.EventHandler(checkBox15_CheckedChanged);
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[3] { "x86 for 32-bit processors", "AMD64 for 64-bit processors", "IA64 for Itanium-based processors" });
		this.comboBox1.Location = new System.Drawing.Point(13, 493);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(135, 21);
		this.comboBox1.TabIndex = 125;
		this.comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.SystemColors.Control;
		this.label4.Location = new System.Drawing.Point(14, 466);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(81, 13);
		this.label4.TabIndex = 126;
		this.label4.Text = "Processor Type";
		this.trackBar1.Location = new System.Drawing.Point(13, 415);
		this.trackBar1.Maximum = 5000;
		this.trackBar1.Name = "trackBar1";
		this.trackBar1.Size = new System.Drawing.Size(150, 45);
		this.trackBar1.TabIndex = 127;
		this.trackBar1.TickFrequency = 500;
		this.trackBar1.Scroll += new System.EventHandler(trackBar1_Scroll);
		this.label5.AutoSize = true;
		this.label5.ForeColor = System.Drawing.SystemColors.Control;
		this.label5.Location = new System.Drawing.Point(14, 385);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(105, 13);
		this.label5.TabIndex = 128;
		this.label5.Text = "User Processor Time";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(166, 425);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(13, 13);
		this.label1.TabIndex = 129;
		this.label1.Text = "0";
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(244, 146);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(82, 17);
		this.checkBox16.TabIndex = 130;
		this.checkBox16.Text = "Enable C1E";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox16.CheckedChanged += new System.EventHandler(checkBox16_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(391, 226);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(13, 13);
		this.label2.TabIndex = 135;
		this.label2.Text = "0";
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.SystemColors.Control;
		this.label3.Location = new System.Drawing.Point(239, 186);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(65, 13);
		this.label3.TabIndex = 134;
		this.label3.Text = "Idle Timeout";
		this.trackBar2.Location = new System.Drawing.Point(238, 216);
		this.trackBar2.Maximum = 10000;
		this.trackBar2.Name = "trackBar2";
		this.trackBar2.Size = new System.Drawing.Size(150, 45);
		this.trackBar2.TabIndex = 133;
		this.trackBar2.TickFrequency = 500;
		this.trackBar2.Scroll += new System.EventHandler(trackBar2_Scroll);
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(395, 311);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(13, 13);
		this.label6.TabIndex = 138;
		this.label6.Text = "0";
		this.label8.AutoSize = true;
		this.label8.ForeColor = System.Drawing.SystemColors.Control;
		this.label8.Location = new System.Drawing.Point(243, 271);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(129, 13);
		this.label8.TabIndex = 137;
		this.label8.Text = "Performance Decrese if %";
		this.trackBar3.Location = new System.Drawing.Point(242, 301);
		this.trackBar3.Maximum = 100;
		this.trackBar3.Name = "trackBar3";
		this.trackBar3.Size = new System.Drawing.Size(150, 45);
		this.trackBar3.TabIndex = 136;
		this.trackBar3.TickFrequency = 10;
		this.trackBar3.Scroll += new System.EventHandler(trackBar3_Scroll);
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(395, 388);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(13, 13);
		this.label9.TabIndex = 141;
		this.label9.Text = "0";
		this.label10.AutoSize = true;
		this.label10.ForeColor = System.Drawing.SystemColors.Control;
		this.label10.Location = new System.Drawing.Point(243, 348);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(124, 13);
		this.label10.TabIndex = 140;
		this.label10.Text = "Performance Increse if %";
		this.trackBar4.Location = new System.Drawing.Point(242, 378);
		this.trackBar4.Maximum = 100;
		this.trackBar4.Name = "trackBar4";
		this.trackBar4.Size = new System.Drawing.Size(150, 45);
		this.trackBar4.TabIndex = 139;
		this.trackBar4.TickFrequency = 10;
		this.trackBar4.Scroll += new System.EventHandler(trackBar4_Scroll);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(395, 476);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(13, 13);
		this.label11.TabIndex = 144;
		this.label11.Text = "0";
		this.label12.AutoSize = true;
		this.label12.ForeColor = System.Drawing.SystemColors.Control;
		this.label12.Location = new System.Drawing.Point(247, 426);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(134, 26);
		this.label12.TabIndex = 143;
		this.label12.Text = "How much performance % \r\nwill be decreased";
		this.trackBar5.Location = new System.Drawing.Point(242, 466);
		this.trackBar5.Maximum = 100;
		this.trackBar5.Name = "trackBar5";
		this.trackBar5.Size = new System.Drawing.Size(150, 45);
		this.trackBar5.TabIndex = 142;
		this.trackBar5.TickFrequency = 10;
		this.trackBar5.Scroll += new System.EventHandler(trackBar5_Scroll);
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(397, 567);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(13, 13);
		this.label13.TabIndex = 147;
		this.label13.Text = "0";
		this.label14.AutoSize = true;
		this.label14.ForeColor = System.Drawing.SystemColors.Control;
		this.label14.Location = new System.Drawing.Point(249, 517);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(134, 26);
		this.label14.TabIndex = 146;
		this.label14.Text = "How much performance % \r\nwill be increased";
		this.trackBar6.Location = new System.Drawing.Point(244, 557);
		this.trackBar6.Maximum = 100;
		this.trackBar6.Name = "trackBar6";
		this.trackBar6.Size = new System.Drawing.Size(150, 45);
		this.trackBar6.TabIndex = 145;
		this.trackBar6.TickFrequency = 10;
		this.trackBar6.Scroll += new System.EventHandler(trackBar6_Scroll);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.Controls.Add(this.label13);
		base.Controls.Add(this.label14);
		base.Controls.Add(this.trackBar6);
		base.Controls.Add(this.label11);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.trackBar5);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.trackBar4);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.trackBar3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.trackBar2);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.trackBar1);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.comboBox1);
		base.Controls.Add(this.checkBox12);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox7);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox9);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.label7);
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl2";
		base.Size = new System.Drawing.Size(619, 605);
		base.Load += new System.EventHandler(UserControl2_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar6).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
