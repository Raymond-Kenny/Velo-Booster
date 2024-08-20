using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl8 : UserControl
{
	private IContainer components;

	private PictureBox pictureBox1;

	private CheckBox checkBox21;

	private CheckBox checkBox22;

	private CheckBox checkBox23;

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

	public UserControl8()
	{
		InitializeComponent();
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\NetworkList\\DefaultMediaCost", "Ethernet", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\AFD\\Parameters", "DynamicBacklogGrowthDelta", 255, RegistryValueKind.DWord);
		}
	}

	private void checkBox14_CheckedChanged_1(object sender, EventArgs e)
	{
		if (checkBox14.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip6\\Parameters", "DisabledComponents", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NDIS\\Parameters", "MaxSendPackets", 10, RegistryValueKind.DWord);
		}
	}

	private void checkBox20_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("", "", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox21.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "MaxSOACacheEntryTtlLimit", 301, RegistryValueKind.DWord);
		}
	}

	private void checkBox22_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox22.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "MaxCacheEntryTtlLimit", 64000, RegistryValueKind.DWord);
		}
	}

	private void checkBox23_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox23.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "CacheHashTableSize", 180, RegistryValueKind.DWord);
		}
	}

	private void checkBox33_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox33.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "CacheHashTableBucketSize", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "MaxHashTableSize", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox7.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsivenessScaler", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "UseRawRead", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox9.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableDeadGWDetect", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox10.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "DisableIPSourceRouting", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox11.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableTCPChimney", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox12.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "MaxCmds", 40, RegistryValueKind.DWord);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Hide();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl8));
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.checkBox21 = new System.Windows.Forms.CheckBox();
		this.checkBox22 = new System.Windows.Forms.CheckBox();
		this.checkBox23 = new System.Windows.Forms.CheckBox();
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
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(447, 512);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.checkBox21.AutoSize = true;
		this.checkBox21.BackColor = System.Drawing.Color.Black;
		this.checkBox21.FlatAppearance.BorderSize = 5;
		this.checkBox21.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox21.Location = new System.Drawing.Point(11, 535);
		this.checkBox21.Name = "checkBox21";
		this.checkBox21.Size = new System.Drawing.Size(84, 17);
		this.checkBox21.TabIndex = 121;
		this.checkBox21.Text = "SOA Tweak";
		this.checkBox21.UseVisualStyleBackColor = false;
		this.checkBox21.CheckedChanged += new System.EventHandler(checkBox21_CheckedChanged);
		this.checkBox22.AutoSize = true;
		this.checkBox22.BackColor = System.Drawing.Color.Black;
		this.checkBox22.FlatAppearance.BorderSize = 5;
		this.checkBox22.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox22.Location = new System.Drawing.Point(11, 500);
		this.checkBox22.Name = "checkBox22";
		this.checkBox22.Size = new System.Drawing.Size(148, 17);
		this.checkBox22.TabIndex = 120;
		this.checkBox22.Text = "Increase Cache Entry limit";
		this.checkBox22.UseVisualStyleBackColor = false;
		this.checkBox22.CheckedChanged += new System.EventHandler(checkBox22_CheckedChanged);
		this.checkBox23.AutoSize = true;
		this.checkBox23.BackColor = System.Drawing.Color.Black;
		this.checkBox23.FlatAppearance.BorderSize = 5;
		this.checkBox23.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox23.Location = new System.Drawing.Point(13, 462);
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.Size = new System.Drawing.Size(174, 17);
		this.checkBox23.TabIndex = 119;
		this.checkBox23.Text = "Optimize Cash Hash Table Size";
		this.checkBox23.UseVisualStyleBackColor = false;
		this.checkBox23.CheckedChanged += new System.EventHandler(checkBox23_CheckedChanged);
		this.checkBox33.AutoSize = true;
		this.checkBox33.BackColor = System.Drawing.Color.Black;
		this.checkBox33.FlatAppearance.BorderSize = 5;
		this.checkBox33.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox33.Location = new System.Drawing.Point(13, 430);
		this.checkBox33.Name = "checkBox33";
		this.checkBox33.Size = new System.Drawing.Size(123, 17);
		this.checkBox33.TabIndex = 118;
		this.checkBox33.Text = "Increase Cach Hash";
		this.checkBox33.UseVisualStyleBackColor = false;
		this.checkBox33.CheckedChanged += new System.EventHandler(checkBox33_CheckedChanged);
		this.checkBox3.AutoSize = true;
		this.checkBox3.BackColor = System.Drawing.Color.Black;
		this.checkBox3.FlatAppearance.BorderSize = 5;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(13, 392);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(94, 17);
		this.checkBox3.TabIndex = 117;
		this.checkBox3.Text = "Optimize Hash";
		this.checkBox3.UseVisualStyleBackColor = false;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox7.AutoSize = true;
		this.checkBox7.BackColor = System.Drawing.Color.Black;
		this.checkBox7.FlatAppearance.BorderSize = 5;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(13, 352);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(134, 17);
		this.checkBox7.TabIndex = 116;
		this.checkBox7.Text = "Improve responsivness";
		this.checkBox7.UseVisualStyleBackColor = false;
		this.checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.BackColor = System.Drawing.Color.Black;
		this.checkBox8.FlatAppearance.BorderSize = 5;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(13, 317);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(77, 17);
		this.checkBox8.TabIndex = 115;
		this.checkBox8.Text = "Raw Read";
		this.checkBox8.UseVisualStyleBackColor = false;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox9.AutoSize = true;
		this.checkBox9.BackColor = System.Drawing.Color.Black;
		this.checkBox9.FlatAppearance.BorderSize = 5;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(13, 284);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(110, 17);
		this.checkBox9.TabIndex = 114;
		this.checkBox9.Text = "Enable Dead GW";
		this.checkBox9.UseVisualStyleBackColor = false;
		this.checkBox9.CheckedChanged += new System.EventHandler(checkBox9_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.BackColor = System.Drawing.Color.Black;
		this.checkBox10.FlatAppearance.BorderSize = 5;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(13, 246);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(151, 17);
		this.checkBox10.TabIndex = 113;
		this.checkBox10.Text = "Disable IPS ource Routing";
		this.checkBox10.UseVisualStyleBackColor = false;
		this.checkBox10.CheckedChanged += new System.EventHandler(checkBox10_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.BackColor = System.Drawing.Color.Black;
		this.checkBox11.FlatAppearance.BorderSize = 5;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(13, 207);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(128, 17);
		this.checkBox11.TabIndex = 112;
		this.checkBox11.Text = "Disable TCP Chimney";
		this.checkBox11.UseVisualStyleBackColor = false;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox12.AutoSize = true;
		this.checkBox12.BackColor = System.Drawing.Color.Black;
		this.checkBox12.FlatAppearance.BorderSize = 5;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(13, 163);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(98, 17);
		this.checkBox12.TabIndex = 111;
		this.checkBox12.Text = "Optimize CMDs";
		this.checkBox12.UseVisualStyleBackColor = false;
		this.checkBox12.CheckedChanged += new System.EventHandler(checkBox12_CheckedChanged);
		this.checkBox13.AutoSize = true;
		this.checkBox13.BackColor = System.Drawing.Color.Black;
		this.checkBox13.FlatAppearance.BorderSize = 5;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(13, 122);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(108, 17);
		this.checkBox13.TabIndex = 110;
		this.checkBox13.Text = "Optimize Packets";
		this.checkBox13.UseVisualStyleBackColor = false;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.BackColor = System.Drawing.Color.Black;
		this.checkBox14.FlatAppearance.BorderSize = 5;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(13, 86);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(85, 17);
		this.checkBox14.TabIndex = 109;
		this.checkBox14.Text = "Disable Ipv6";
		this.checkBox14.UseVisualStyleBackColor = false;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged_1);
		this.checkBox5.AutoSize = true;
		this.checkBox5.BackColor = System.Drawing.Color.Black;
		this.checkBox5.FlatAppearance.BorderSize = 5;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(13, 51);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(133, 17);
		this.checkBox5.TabIndex = 108;
		this.checkBox5.Text = "Disable Dynamic Delta";
		this.checkBox5.UseVisualStyleBackColor = false;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged_1);
		this.checkBox6.AutoSize = true;
		this.checkBox6.BackColor = System.Drawing.Color.Black;
		this.checkBox6.FlatAppearance.BorderSize = 5;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(13, 12);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(109, 17);
		this.checkBox6.TabIndex = 107;
		this.checkBox6.Text = "Optimize Ethernet";
		this.checkBox6.UseVisualStyleBackColor = false;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
		base.Name = "UserControl8";
		base.Size = new System.Drawing.Size(619, 605);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
