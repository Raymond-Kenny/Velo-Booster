using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl4 : UserControl
{
	private IContainer components;

	private CheckBox checkBox12;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox1;

	private CheckBox checkBox2;

	private CheckBox checkBox15;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private PictureBox pictureBox1;

	private Label label2;

	private TextBox textBox1;

	private Label label1;

	private TextBox textBox2;

	private Label label3;

	private TextBox textBox3;

	private Label label4;

	private TextBox textBox4;

	private Label label5;

	private TextBox textBox5;

	private Label label6;

	private TextBox textBox6;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private Label label7;

	private TextBox textBox7;

	private CheckBox checkBox16;

	public UserControl4()
	{
		InitializeComponent();
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "LargeSystemCache", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisablePagingExecutive", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox12.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "PoolUsageMaximum", 60, RegistryValueKind.DWord);
		}
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "PagedPoolSize", 192, RegistryValueKind.DWord);
		}
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox7.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisableMemoryCompression", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "LazyWrite", 192, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "LargePageMinimum", 256, RegistryValueKind.DWord);
		}
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "LowPriorityIoBoost", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisableNonPagedPoolTracking", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "SystemCacheLimit", uint.MaxValue, RegistryValueKind.DWord);
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NET Memory Cache 4.0\\Performance", "IntervalSecs", textBox2.Text, RegistryValueKind.DWord);
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NET Memory Cache 4.0\\Performance", "MinimumThresholdLimit", textBox4.Text, RegistryValueKind.DWord);
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NET Memory Cache 4.0\\Performance", "ObjectLimit", textBox5.Text, RegistryValueKind.DWord);
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NET Memory Cache 4.0\\Performance", "CacheLimit", textBox1.Text, RegistryValueKind.DWord);
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NET Memory Cache 4.0\\Performance", "MinimumThreshold", textBox3.Text, RegistryValueKind.DWord);
	}

	private void UserControl4_Load(object sender, EventArgs e)
	{
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NET Memory Cache 4.0\\Performance", "TimeLimit", textBox6.Text, RegistryValueKind.DWord);
	}

	private void checkBox14_CheckedChanged_1(object sender, EventArgs e)
	{
		if (checkBox14.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NETFramework\\Performance", "GcConcurrent", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox13_CheckedChanged_1(object sender, EventArgs e)
	{
		if (checkBox13.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NETFramework\\Performance", "GCLatencyMode", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
	{
		if (checkBox11.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NETFramework\\Performance", "PerfMapEnabled", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox10.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NETFramework\\Performance", "GcAllowVeryLargeObjects", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox9.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NETFramework\\Performance", "HeapVerify", 0, RegistryValueKind.DWord);
		}
	}

	private void textBox7_TextChanged(object sender, EventArgs e)
	{
		if (textBox7.Text == "-")
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NETFramework\\Performance", "ConcurrentGCThreads", textBox7.Text, RegistryValueKind.DWord);
		}
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox16.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\.NETFramework\\Performance", "NgenEnablePause", 0, RegistryValueKind.DWord);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl4));
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.label2 = new System.Windows.Forms.Label();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.textBox3 = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.textBox5 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.textBox6 = new System.Windows.Forms.TextBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.label7 = new System.Windows.Forms.Label();
		this.textBox7 = new System.Windows.Forms.TextBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.checkBox12.AutoSize = true;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(12, 94);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(166, 17);
		this.checkBox12.TabIndex = 34;
		this.checkBox12.Text = "Increase PoolUsageMaximum";
		this.checkBox12.UseVisualStyleBackColor = true;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(12, 56);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(147, 17);
		this.checkBox5.TabIndex = 31;
		this.checkBox5.Text = "Disable Paging Executive";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(12, 17);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(160, 17);
		this.checkBox6.TabIndex = 30;
		this.checkBox6.Text = "Enable Large System Cache";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(12, 173);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(162, 17);
		this.checkBox7.TabIndex = 37;
		this.checkBox7.Text = "Enable Memory Compression";
		this.checkBox7.UseVisualStyleBackColor = true;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(12, 134);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(142, 17);
		this.checkBox8.TabIndex = 36;
		this.checkBox8.Text = "Increase PagedPoolSize";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(12, 209);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(131, 17);
		this.checkBox1.TabIndex = 40;
		this.checkBox1.Text = "Optimize Lazy Memory";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(12, 249);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(142, 17);
		this.checkBox2.TabIndex = 41;
		this.checkBox2.Text = "Optimize Minimum pages";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(12, 289);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(153, 17);
		this.checkBox15.TabIndex = 44;
		this.checkBox15.Text = "Optimize Low Io Page Limit";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox15.CheckedChanged += new System.EventHandler(checkBox15_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(12, 327);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(142, 17);
		this.checkBox3.TabIndex = 45;
		this.checkBox3.Text = "Disable Memory tracking";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(12, 364);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(118, 17);
		this.checkBox4.TabIndex = 46;
		this.checkBox4.Text = "System Cache Limit";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged_1);
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(450, 515);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 74;
		this.pictureBox1.TabStop = false;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(9, 408);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(102, 13);
		this.label2.TabIndex = 76;
		this.label2.Text = "Memory Cache Limit\r\n";
		this.textBox1.Location = new System.Drawing.Point(12, 433);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(100, 20);
		this.textBox1.TabIndex = 75;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(9, 475);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(109, 13);
		this.label1.TabIndex = 78;
		this.label1.Text = "Memory Interval Secs\r\n";
		this.textBox2.Location = new System.Drawing.Point(12, 500);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(100, 20);
		this.textBox2.TabIndex = 77;
		this.textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(9, 536);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(135, 13);
		this.label3.TabIndex = 80;
		this.label3.Text = "Memory MinimumThreshold\r\n";
		this.textBox3.Location = new System.Drawing.Point(12, 561);
		this.textBox3.Name = "textBox3";
		this.textBox3.Size = new System.Drawing.Size(100, 20);
		this.textBox3.TabIndex = 79;
		this.textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(275, 14);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(159, 13);
		this.label4.TabIndex = 82;
		this.label4.Text = "Memory MinimumThreshold Limit\r\n";
		this.textBox4.Location = new System.Drawing.Point(278, 39);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new System.Drawing.Size(100, 20);
		this.textBox4.TabIndex = 81;
		this.textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(275, 85);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(102, 13);
		this.label5.TabIndex = 84;
		this.label5.Text = "Memory Objec tLimit\r\n";
		this.textBox5.Location = new System.Drawing.Point(278, 110);
		this.textBox5.Name = "textBox5";
		this.textBox5.Size = new System.Drawing.Size(100, 20);
		this.textBox5.TabIndex = 83;
		this.textBox5.TextChanged += new System.EventHandler(textBox5_TextChanged);
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(274, 148);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(94, 13);
		this.label6.TabIndex = 86;
		this.label6.Text = "Memory Time Limit";
		this.textBox6.Location = new System.Drawing.Point(277, 173);
		this.textBox6.Name = "textBox6";
		this.textBox6.Size = new System.Drawing.Size(100, 20);
		this.textBox6.TabIndex = 85;
		this.textBox6.TextChanged += new System.EventHandler(textBox6_TextChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(277, 384);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(145, 17);
		this.checkBox9.TabIndex = 91;
		this.checkBox9.Text = "Disable Heap Verification";
		this.checkBox9.UseVisualStyleBackColor = true;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(277, 347);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(136, 17);
		this.checkBox10.TabIndex = 90;
		this.checkBox10.Text = "Optimize Fragmentation";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(277, 309);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(85, 17);
		this.checkBox11.TabIndex = 89;
		this.checkBox11.Text = "Disable Map";
		this.checkBox11.UseVisualStyleBackColor = true;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged_1);
		this.checkBox13.AutoSize = true;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(277, 269);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(170, 17);
		this.checkBox13.TabIndex = 88;
		this.checkBox13.Text = "Enable Memory Latency Mode";
		this.checkBox13.UseVisualStyleBackColor = true;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged_1);
		this.checkBox14.AutoSize = true;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(277, 229);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(130, 17);
		this.checkBox14.TabIndex = 87;
		this.checkBox14.Text = "Optimize Stutter Mode";
		this.checkBox14.UseVisualStyleBackColor = true;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged_1);
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(275, 420);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(71, 13);
		this.label7.TabIndex = 93;
		this.label7.Text = "System Cores\r\n";
		this.textBox7.Location = new System.Drawing.Point(278, 445);
		this.textBox7.Name = "textBox7";
		this.textBox7.Size = new System.Drawing.Size(100, 20);
		this.textBox7.TabIndex = 92;
		this.textBox7.TextChanged += new System.EventHandler(textBox7_TextChanged);
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(278, 486);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(128, 17);
		this.checkBox16.TabIndex = 94;
		this.checkBox16.Text = "Disable NGEN Pause";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox16.CheckedChanged += new System.EventHandler(checkBox16_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.textBox7);
		base.Controls.Add(this.checkBox9);
		base.Controls.Add(this.checkBox10);
		base.Controls.Add(this.checkBox11);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.textBox6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.textBox5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.textBox3);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.checkBox7);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox12);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.checkBox6);
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl4";
		base.Size = new System.Drawing.Size(619, 605);
		base.Load += new System.EventHandler(UserControl4_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
