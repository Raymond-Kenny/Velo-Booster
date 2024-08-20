using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl6 : UserControl
{
	private PerformanceCounter perfCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");

	private PerformanceCounter perfRAM = new PerformanceCounter("Memory", "Available MBytes");

	private IContainer components;

	private PictureBox pictureBox1;

	private Label label7;

	private Label label4;

	private TextBox textBox3;

	private Label label6;

	private TextBox textBox2;

	private Label label5;

	private Label label3;

	private Label label2;

	private TrackBar trackBar1;

	private Label label1;

	private TextBox textBox1;

	private CheckBox checkBox1;

	private Label label11;

	private TextBox textBox9;

	private Label label8;

	private TextBox textBox6;

	private Label label9;

	private TextBox textBox7;

	private Label label10;

	private TextBox textBox8;

	private Label label12;

	private Label label13;

	private TextBox textBox5;

	private Label label14;

	private TextBox textBox4;

	private Label label16;

	private TextBox textBox11;

	private Label label17;

	private Label label15;

	private CheckBox checkBox2;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox7;

	public UserControl6()
	{
		InitializeComponent();
	}

	private void UserControl6_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		if (textBox1.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MousePollInterval", textBox1.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		if (textBox3.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseDataQueueSize", textBox2.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		if (textBox3.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseThreshold1", textBox3.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
		if (textBox5.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseThreshold2", textBox5.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox11_TextChanged(object sender, EventArgs e)
	{
		if (textBox11.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MousePollInterval", textBox11.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
		if (textBox4.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseThreshold1", textBox4.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox5_TextChanged_1(object sender, EventArgs e)
	{
		if (textBox5.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseThreshold2", textBox5.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox3_TextChanged_1(object sender, EventArgs e)
	{
		if (textBox3.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseInputBufferSize", textBox3.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox2_TextChanged_1(object sender, EventArgs e)
	{
		if (textBox2.Text == "0")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseTimeToLive", textBox2.Text, RegistryValueKind.DWord);
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseFlushQueueOnClose", 1, RegistryValueKind.DWord);
		}
	}

	private void textBox1_TextChanged_1(object sender, EventArgs e)
	{
		if (textBox1.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "Moufiltr", textBox1.Text, RegistryValueKind.String);
		}
	}

	private void trackBar1_Scroll(object sender, EventArgs e)
	{
		label3.Text = trackBar1.Value.ToString();
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseDataQueueSize", trackBar1.Value, RegistryValueKind.DWord);
	}

	private void textBox8_TextChanged(object sender, EventArgs e)
	{
		if (textBox8.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\kbdclass\\Parameters", "PriorityBoost", textBox8.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox7_TextChanged(object sender, EventArgs e)
	{
		if (textBox7.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\kbdclass\\Parameters", "KeyboardDataQueueSize", textBox7.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		if (textBox6.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\kbdclass\\Parameters", "KeyboardInputDataQueueSize", textBox6.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox9_TextChanged(object sender, EventArgs e)
	{
		if (textBox9.Text == "")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\kbdclass\\Parameters", "SendOutputBufferWithLowPriority", textBox9.Text, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\BthHFSrv\\Parameters", "DisableSBC", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HidUsb\\Parameters", "HidReadTimeout", 500, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HidUsb\\Parameters", "DisableLED", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HidUsb\\Parameters", "PowerManagement", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\USB", "TimeoutSelect", 100, RegistryValueKind.DWord);
		}
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox7.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Enum\\USB\\ROOT_HUB30\\4&22224d6e&0&0\\Device Parameters", "PollingRate", 1000, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Enum\\USB\\ROOT_HUB30\\4&3ce02d8&0&0\\Device Parameters", "PollingRate", 1000, RegistryValueKind.DWord);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl6));
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.trackBar1 = new System.Windows.Forms.TrackBar();
		this.label1 = new System.Windows.Forms.Label();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.label11 = new System.Windows.Forms.Label();
		this.textBox9 = new System.Windows.Forms.TextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.textBox8 = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.label14 = new System.Windows.Forms.Label();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.label16 = new System.Windows.Forms.Label();
		this.textBox11 = new System.Windows.Forms.TextBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
		base.SuspendLayout();
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(450, 512);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 74;
		this.pictureBox1.TabStop = false;
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(119, 442);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(50, 13);
		this.label7.TabIndex = 87;
		this.label7.Text = "Default 0";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(116, 377);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(68, 13);
		this.label4.TabIndex = 86;
		this.label4.Text = "Default 4096";
		this.textBox3.Location = new System.Drawing.Point(10, 370);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new System.Drawing.Size(100, 20);
		this.textBox3.TabIndex = 85;
		this.textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged_1);
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(10, 414);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(74, 13);
		this.label6.TabIndex = 84;
		this.label6.Text = "Mouse to Live";
		this.textBox2.Location = new System.Drawing.Point(13, 439);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(100, 20);
		this.textBox2.TabIndex = 83;
		this.textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged_1);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(5, 338);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(91, 13);
		this.label5.TabIndex = 82;
		this.label5.Text = "Mouse Buffer size";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(116, 152);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(19, 13);
		this.label3.TabIndex = 80;
		this.label3.Text = "50";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(10, 113);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(95, 13);
		this.label2.TabIndex = 79;
		this.label2.Text = "Mouse Queue size";
		this.trackBar1.Location = new System.Drawing.Point(6, 139);
		this.trackBar1.Maximum = 255;
		this.trackBar1.Minimum = 20;
		this.trackBar1.Name = "trackBar1";
		this.trackBar1.Size = new System.Drawing.Size(104, 45);
		this.trackBar1.TabIndex = 78;
		this.trackBar1.TickFrequency = 50;
		this.trackBar1.Value = 50;
		this.trackBar1.Scroll += new System.EventHandler(trackBar1_Scroll);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(14, 512);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(61, 13);
		this.label1.TabIndex = 77;
		this.label1.Text = "Mouse filter";
		this.textBox1.Location = new System.Drawing.Point(10, 537);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(100, 20);
		this.textBox1.TabIndex = 76;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged_1);
		this.checkBox1.AutoSize = true;
		this.checkBox1.Location = new System.Drawing.Point(10, 475);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(83, 17);
		this.checkBox1.TabIndex = 75;
		this.checkBox1.Text = "FlushQueue";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.label11.AutoSize = true;
		this.label11.ForeColor = System.Drawing.SystemColors.Control;
		this.label11.Location = new System.Drawing.Point(226, 272);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(152, 13);
		this.label11.TabIndex = 105;
		this.label11.Text = "Output Buffer With Low Priority";
		this.textBox9.Location = new System.Drawing.Point(229, 298);
		this.textBox9.Name = "textBox9";
		this.textBox9.Size = new System.Drawing.Size(100, 20);
		this.textBox9.TabIndex = 104;
		this.textBox9.TextChanged += new System.EventHandler(textBox9_TextChanged);
		this.label8.AutoSize = true;
		this.label8.ForeColor = System.Drawing.SystemColors.Control;
		this.label8.Location = new System.Drawing.Point(228, 199);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(137, 13);
		this.label8.TabIndex = 103;
		this.label8.Text = "Keyboard Input Queue Size";
		this.textBox6.Location = new System.Drawing.Point(231, 225);
		this.textBox6.Name = "textBox6";
		this.textBox6.Size = new System.Drawing.Size(100, 20);
		this.textBox6.TabIndex = 102;
		this.textBox6.TextChanged += new System.EventHandler(textBox6_TextChanged);
		this.label9.AutoSize = true;
		this.label9.ForeColor = System.Drawing.SystemColors.Control;
		this.label9.Location = new System.Drawing.Point(228, 128);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(110, 13);
		this.label9.TabIndex = 101;
		this.label9.Text = "Keyboard Queue Size";
		this.textBox7.Location = new System.Drawing.Point(231, 154);
		this.textBox7.Name = "textBox7";
		this.textBox7.Size = new System.Drawing.Size(100, 20);
		this.textBox7.TabIndex = 100;
		this.textBox7.TextChanged += new System.EventHandler(textBox7_TextChanged);
		this.label10.AutoSize = true;
		this.label10.ForeColor = System.Drawing.SystemColors.Control;
		this.label10.Location = new System.Drawing.Point(228, 42);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(122, 26);
		this.label10.TabIndex = 99;
		this.label10.Text = "Priority Boost \r\n(Can lower performance)";
		this.textBox8.Location = new System.Drawing.Point(229, 81);
		this.textBox8.Name = "textBox8";
		this.textBox8.Size = new System.Drawing.Size(100, 20);
		this.textBox8.TabIndex = 98;
		this.textBox8.TextChanged += new System.EventHandler(textBox8_TextChanged);
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label12.ForeColor = System.Drawing.SystemColors.Control;
		this.label12.Location = new System.Drawing.Point(226, 11);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(104, 25);
		this.label12.TabIndex = 97;
		this.label12.Text = "Keyboard";
		this.label13.AutoSize = true;
		this.label13.ForeColor = System.Drawing.SystemColors.Control;
		this.label13.Location = new System.Drawing.Point(4, 272);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(92, 13);
		this.label13.TabIndex = 96;
		this.label13.Text = "MouseThreshold2";
		this.textBox5.Location = new System.Drawing.Point(7, 298);
		this.textBox5.Name = "textBox5";
		this.textBox5.Size = new System.Drawing.Size(100, 20);
		this.textBox5.TabIndex = 95;
		this.textBox5.TextChanged += new System.EventHandler(textBox5_TextChanged_1);
		this.label14.AutoSize = true;
		this.label14.ForeColor = System.Drawing.SystemColors.Control;
		this.label14.Location = new System.Drawing.Point(4, 199);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(92, 13);
		this.label14.TabIndex = 94;
		this.label14.Text = "MouseThreshold1";
		this.textBox4.Location = new System.Drawing.Point(7, 225);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new System.Drawing.Size(100, 20);
		this.textBox4.TabIndex = 93;
		this.textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
		this.label16.AutoSize = true;
		this.label16.ForeColor = System.Drawing.SystemColors.Control;
		this.label16.Location = new System.Drawing.Point(2, 55);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(73, 13);
		this.label16.TabIndex = 90;
		this.label16.Text = "Mouse Polling";
		this.textBox11.Location = new System.Drawing.Point(5, 81);
		this.textBox11.Name = "textBox11";
		this.textBox11.Size = new System.Drawing.Size(100, 20);
		this.textBox11.TabIndex = 89;
		this.textBox11.TextChanged += new System.EventHandler(textBox11_TextChanged);
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label17.ForeColor = System.Drawing.SystemColors.Control;
		this.label17.Location = new System.Drawing.Point(28, 11);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(77, 25);
		this.label17.TabIndex = 88;
		this.label17.Text = "Mouse";
		this.label15.AutoSize = true;
		this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label15.ForeColor = System.Drawing.SystemColors.Control;
		this.label15.Location = new System.Drawing.Point(445, 11);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(105, 25);
		this.label15.TabIndex = 106;
		this.label15.Text = "Controller";
		this.checkBox2.AutoSize = true;
		this.checkBox2.Location = new System.Drawing.Point(445, 57);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(85, 17);
		this.checkBox2.TabIndex = 109;
		this.checkBox2.Text = "Disable SBC";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.Location = new System.Drawing.Point(445, 96);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(112, 17);
		this.checkBox3.TabIndex = 110;
		this.checkBox3.Text = "Improve Hid Read";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.Location = new System.Drawing.Point(445, 137);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(85, 17);
		this.checkBox4.TabIndex = 111;
		this.checkBox4.Text = "Disable LED";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.Location = new System.Drawing.Point(445, 172);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(156, 17);
		this.checkBox5.TabIndex = 112;
		this.checkBox5.Text = "Disable PowerManagement";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.Location = new System.Drawing.Point(445, 211);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(105, 17);
		this.checkBox6.TabIndex = 113;
		this.checkBox6.Text = "Improve Timeout\r\n";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.Location = new System.Drawing.Point(445, 249);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(123, 17);
		this.checkBox7.TabIndex = 114;
		this.checkBox7.Text = "Improve Pooling rate";
		this.checkBox7.UseVisualStyleBackColor = true;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		base.Controls.Add(this.checkBox7);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.label15);
		base.Controls.Add(this.label11);
		base.Controls.Add(this.textBox9);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.textBox7);
		base.Controls.Add(this.label10);
		base.Controls.Add(this.textBox8);
		base.Controls.Add(this.label12);
		base.Controls.Add(this.label13);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.label14);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.label16);
		base.Controls.Add(this.textBox11);
		base.Controls.Add(this.label17);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.trackBar1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.pictureBox1);
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl6";
		base.Size = new System.Drawing.Size(619, 605);
		base.Load += new System.EventHandler(UserControl6_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
