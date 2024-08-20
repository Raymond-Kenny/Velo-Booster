using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl9 : UserControl
{
	private IContainer components;

	private Label label2;

	private TextBox textBox2;

	private Label label1;

	private TextBox textBox1;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox8;

	private CheckBox checkBox7;

	private CheckBox checkBox3;

	private CheckBox checkBox2;

	private CheckBox checkBox1;

	private Label label4;

	private TextBox textBox4;

	private CheckBox checkBox4;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox12;

	private CheckBox checkBox13;

	private PictureBox pictureBox1;

	public UserControl9()
	{
		InitializeComponent();
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "EnableNUMAPolicy", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "PhysicalAddressExtension", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\Memory Compression", "Disable", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox9.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "SystemCacheMaximumSize", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox10.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisableTrims", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox11.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "LargeAddressAware", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "LowMemoryThreshold", uint.MaxValue, RegistryValueKind.DWord);
		}
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox7.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\CrashControl", "CrashDumpEnabled", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisableCodeIntegrityChecks", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox12.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "EnableAppMemoryTuning", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox13.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "EnableMemoryCoalescing", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "EnableLowFragmentationHeap", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "CommitLimit", 0, RegistryValueKind.DWord);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		if (textBox1.Text.Length > 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "StandbyListNormalPriorityThreshold", textBox1.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		if (textBox2.Text.Length > 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "KernelStackLimit", textBox1.Text, RegistryValueKind.DWord);
		}
	}

	private void textBox4_TextChanged(object sender, EventArgs e)
	{
		if (textBox4.Text.Length > 0)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "LookasideListSize", textBox1.Text, RegistryValueKind.DWord);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl9));
		this.label2 = new System.Windows.Forms.Label();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.label4 = new System.Windows.Forms.Label();
		this.textBox4 = new System.Windows.Forms.TextBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.SystemColors.Control;
		this.label2.Location = new System.Drawing.Point(5, 186);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(166, 13);
		this.label2.TabIndex = 41;
		this.label2.Text = "Adjust the size of the kernel stack";
		this.textBox2.Location = new System.Drawing.Point(12, 204);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(100, 20);
		this.textBox2.TabIndex = 40;
		this.textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.SystemColors.Control;
		this.label1.Location = new System.Drawing.Point(9, 127);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(160, 13);
		this.label1.TabIndex = 39;
		this.label1.Text = "Adjust the size of the standby list";
		this.textBox1.Location = new System.Drawing.Point(12, 146);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(100, 20);
		this.textBox1.TabIndex = 38;
		this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(12, 403);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(238, 17);
		this.checkBox9.TabIndex = 37;
		this.checkBox9.Text = "Adjust the maximum size of the system cache";
		this.checkBox9.UseVisualStyleBackColor = true;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(12, 362);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(157, 17);
		this.checkBox10.TabIndex = 36;
		this.checkBox10.Text = "Enable working set trimming";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(12, 324);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(179, 17);
		this.checkBox11.TabIndex = 35;
		this.checkBox11.Text = "Enable large address awareness";
		this.checkBox11.UseVisualStyleBackColor = true;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(12, 286);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(191, 17);
		this.checkBox8.TabIndex = 32;
		this.checkBox8.Text = "Disable the low memory notification";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(12, 245);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(145, 17);
		this.checkBox7.TabIndex = 31;
		this.checkBox7.Text = "Disable memory dump file";
		this.checkBox7.UseVisualStyleBackColor = true;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(12, 92);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(188, 17);
		this.checkBox3.TabIndex = 30;
		this.checkBox3.Text = "Enable physical address extension";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(12, 51);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(162, 17);
		this.checkBox2.TabIndex = 29;
		this.checkBox2.Text = "Disable memory compression";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(12, 12);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(152, 17);
		this.checkBox1.TabIndex = 28;
		this.checkBox1.Text = "Enable NUMA optimization";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.SystemColors.Control;
		this.label4.Location = new System.Drawing.Point(9, 440);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(171, 13);
		this.label4.TabIndex = 43;
		this.label4.Text = "Adjust the size of the look-aside list";
		this.textBox4.Location = new System.Drawing.Point(12, 459);
		this.textBox4.Name = "textBox4";
		this.textBox4.Size = new System.Drawing.Size(100, 20);
		this.textBox4.TabIndex = 42;
		this.textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(305, 53);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(219, 17);
		this.checkBox4.TabIndex = 48;
		this.checkBox4.Text = "Adjust the size of the memory commit limit";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(305, 12);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(282, 17);
		this.checkBox5.TabIndex = 47;
		this.checkBox5.Text = "Enable the use of system-wide low fragmentation heap";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(12, 571);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(238, 17);
		this.checkBox6.TabIndex = 46;
		this.checkBox6.Text = "Disable the removal of the code from memory";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox12.AutoSize = true;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(12, 538);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(157, 17);
		this.checkBox12.TabIndex = 45;
		this.checkBox12.Text = "Enable Memory App Tuning";
		this.checkBox12.UseVisualStyleBackColor = true;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.checkBox13.AutoSize = true;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(12, 497);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(152, 17);
		this.checkBox13.TabIndex = 44;
		this.checkBox13.Text = "Enable memory coalescing";
		this.checkBox13.UseVisualStyleBackColor = true;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged);
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(450, 515);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 77;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.checkBox12);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.textBox4);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.textBox2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.checkBox9);
		base.Controls.Add(this.checkBox10);
		base.Controls.Add(this.checkBox11);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox7);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.checkBox1);
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl9";
		base.Size = new System.Drawing.Size(619, 605);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
