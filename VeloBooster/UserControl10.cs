using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl10 : UserControl
{
	private IContainer components;

	private CheckBox checkBox3;

	private CheckBox checkBox2;

	private CheckBox checkBox1;

	private CheckBox checkBox4;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox11;

	private CheckBox checkBox12;

	private Label label1;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private Label label2;

	private CheckBox checkBox17;

	private CheckBox checkBox18;

	private CheckBox checkBox19;

	private Label label3;

	private PictureBox pictureBox1;

	public UserControl10()
	{
		InitializeComponent();
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "TimeoutDetectionPeriod", 4, RegistryValueKind.DWord);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox12.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\Global\\NVTweak", "VRPreemption", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\Global\\NVTweak\\TexturePriority", "NonGamingAlloc", 20, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000", "EnablePowerContainment", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000", "PStateLimit", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\Global\\NVTweak\\TexturePriority", "DD_texture_alloc", 100, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\Global\\NV_DXGK", "MaxPreemptionLevel", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox11.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\NVIDIA Corporation\\Global\\NVTweak\\PowerMizer", "PowerManagement", 2, RegistryValueKind.DWord);
		}
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox16.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000\\UMD", "EnableLoadBalancing", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox9.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\AMD\\UMD", "MemoryTimingLevel", 2, RegistryValueKind.DWord);
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox10.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000\\UMD", "EnableWorkloadPerformanceMonitoring", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox13.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000\\UMD", "PerformanceLevel", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox14.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000\\UMD", "EnableZeroRPM", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox15.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000\\UMD", "PowerControlLimit", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e96c-e325-11ce-bfc1-08002be10318}\\0000", "EnableHDMIAudio", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox17.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Intel\\GMM", "VideoMemoryPageSize", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Intel\\GMM", "DynamicMemorySize", 80, RegistryValueKind.DWord);
		}
	}

	private void checkBox19_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox19.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Intel\\GMM", "ForcedPreemptionEnable", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox20_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("", "", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("", "", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox22_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("", "", 1, RegistryValueKind.DWord);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl10));
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBox17 = new System.Windows.Forms.CheckBox();
		this.checkBox18 = new System.Windows.Forms.CheckBox();
		this.checkBox19 = new System.Windows.Forms.CheckBox();
		this.label3 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(19, 115);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(277, 17);
		this.checkBox3.TabIndex = 33;
		this.checkBox3.Text = "Adjust the GPU memory allocation for texture caching";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(19, 74);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(262, 17);
		this.checkBox2.TabIndex = 32;
		this.checkBox2.Text = "Increase the maximum number of GPU preemption";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(19, 35);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(233, 17);
		this.checkBox1.TabIndex = 31;
		this.checkBox1.Text = "Increase the maximum GPU memory timeout";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(19, 236);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(186, 17);
		this.checkBox4.TabIndex = 36;
		this.checkBox4.Text = "Adjust the GPU memory allocation";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(19, 195);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(196, 17);
		this.checkBox5.TabIndex = 35;
		this.checkBox5.Text = "Enable maximum performance mode";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(19, 156);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(245, 17);
		this.checkBox6.TabIndex = 34;
		this.checkBox6.Text = "Increase the maximum GPU performance state";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(19, 312);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(184, 17);
		this.checkBox11.TabIndex = 38;
		this.checkBox11.Text = "Enable power management mode";
		this.checkBox11.UseVisualStyleBackColor = true;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox12.AutoSize = true;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(19, 273);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(255, 17);
		this.checkBox12.TabIndex = 37;
		this.checkBox12.Text = "Enable VR preemption for improved performance";
		this.checkBox12.UseVisualStyleBackColor = true;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(414, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(74, 31);
		this.label1.TabIndex = 39;
		this.label1.Text = "AMD";
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(350, 278);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(204, 17);
		this.checkBox8.TabIndex = 46;
		this.checkBox8.Text = "Enable HDMI/DP audio through GPU";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(350, 246);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(173, 17);
		this.checkBox9.TabIndex = 45;
		this.checkBox9.Text = "Adjust the GPU memory timings";
		this.checkBox9.UseVisualStyleBackColor = true;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(350, 205);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(195, 17);
		this.checkBox10.TabIndex = 44;
		this.checkBox10.Text = "Enable GPU workload management";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox13.AutoSize = true;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(350, 166);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(207, 17);
		this.checkBox13.TabIndex = 43;
		this.checkBox13.Text = "Adjust the maximum GPU performance";
		this.checkBox13.UseVisualStyleBackColor = true;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(350, 125);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(138, 17);
		this.checkBox14.TabIndex = 42;
		this.checkBox14.Text = "Enable zero RPM mode";
		this.checkBox14.UseVisualStyleBackColor = true;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged);
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(350, 84);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(166, 17);
		this.checkBox15.TabIndex = 41;
		this.checkBox15.Text = "Adjust the GPU power control";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox15.CheckedChanged += new System.EventHandler(checkBox15_CheckedChanged);
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(350, 45);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(167, 17);
		this.checkBox16.TabIndex = 40;
		this.checkBox16.Text = "Enable GPU workload scaling";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox16.CheckedChanged += new System.EventHandler(checkBox16_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(72, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(106, 31);
		this.label2.TabIndex = 48;
		this.label2.Text = "NVIDIA";
		this.checkBox17.AutoSize = true;
		this.checkBox17.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox17.Location = new System.Drawing.Point(19, 484);
		this.checkBox17.Name = "checkBox17";
		this.checkBox17.Size = new System.Drawing.Size(189, 17);
		this.checkBox17.TabIndex = 55;
		this.checkBox17.Text = "Adjust the video memory page size";
		this.checkBox17.UseVisualStyleBackColor = true;
		this.checkBox17.CheckedChanged += new System.EventHandler(checkBox17_CheckedChanged);
		this.checkBox18.AutoSize = true;
		this.checkBox18.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox18.Location = new System.Drawing.Point(19, 443);
		this.checkBox18.Name = "checkBox18";
		this.checkBox18.Size = new System.Drawing.Size(148, 17);
		this.checkBox18.TabIndex = 54;
		this.checkBox18.Text = "Adjust Dynamic GPU Size";
		this.checkBox18.UseVisualStyleBackColor = true;
		this.checkBox18.CheckedChanged += new System.EventHandler(checkBox18_CheckedChanged);
		this.checkBox19.AutoSize = true;
		this.checkBox19.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox19.Location = new System.Drawing.Point(19, 404);
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.Size = new System.Drawing.Size(147, 17);
		this.checkBox19.TabIndex = 53;
		this.checkBox19.Text = "Enable forced preemption";
		this.checkBox19.UseVisualStyleBackColor = true;
		this.checkBox19.CheckedChanged += new System.EventHandler(checkBox19_CheckedChanged);
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(52, 351);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(92, 31);
		this.label3.TabIndex = 49;
		this.label3.Text = "INTEL";
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
		base.Controls.Add(this.checkBox17);
		base.Controls.Add(this.checkBox18);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox9);
		base.Controls.Add(this.checkBox10);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBox11);
		base.Controls.Add(this.checkBox12);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox5);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox2);
		base.Controls.Add(this.checkBox1);
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl10";
		base.Size = new System.Drawing.Size(619, 605);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
