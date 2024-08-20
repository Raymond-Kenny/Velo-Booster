using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl5 : UserControl
{
	private IContainer components;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private CheckBox checkBox8;

	private CheckBox checkBox11;

	private CheckBox checkBox13;

	private CheckBox checkBox14;

	private CheckBox checkBox5;

	private CheckBox checkBox10;

	private CheckBox checkBox15;

	private CheckBox checkBox16;

	private CheckBox checkBox19;

	private CheckBox checkBox20;

	private CheckBox checkBox23;

	private CheckBox checkBox1;

	private Label label1;

	private Label label2;

	private CheckBox checkBox6;

	private Label label3;

	private PictureBox pictureBox1;

	private TrackBar trackBar1;

	private Label label4;

	private Label label5;

	private TrackBar trackBar2;

	private Label label6;

	private TrackBar trackBar3;

	public UserControl5()
	{
		InitializeComponent();
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox5.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "LargeSendOffload", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox14.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "Tcp1323Opts", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox13.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpAutotuning", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox11.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\BITS", "Start", 4, RegistryValueKind.DWord);
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox8.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "EnableDiscovery", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox4.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\CurrentVersion\\PeerDist", "Disabled", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox3.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "NATTraversal", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox16.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "Tcp1323Opts", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox19_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox19.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpNumConnections", 16777215, RegistryValueKind.DWord);
		}
	}

	private void checkBox20_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox20.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TCPOffload", 0, RegistryValueKind.DWord);
		}
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox23_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox23.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpNumConnections", 16777215, RegistryValueKind.DWord);
		}
	}

	private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
	{
		if (checkBox23.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpMaxDataRetransmissions", 255, RegistryValueKind.DWord);
		}
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
	{
		if (checkBox6.Checked)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableTCPA", 1, RegistryValueKind.DWord);
		}
	}

	private void trackBar1_Scroll(object sender, EventArgs e)
	{
		label4.Text = trackBar1.Value.ToString();
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "DefaultTTL", trackBar1.Value, RegistryValueKind.DWord);
	}

	private void trackBar2_Scroll(object sender, EventArgs e)
	{
		label5.Text = trackBar2.Value.ToString();
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpInitialRtt", trackBar2.Value, RegistryValueKind.DWord);
	}

	private void trackBar3_Scroll(object sender, EventArgs e)
	{
		label6.Text = trackBar3.Value.ToString();
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpInitialRtt", trackBar3.Value, RegistryValueKind.DWord);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.UserControl5));
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
		this.checkBox14 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox15 = new System.Windows.Forms.CheckBox();
		this.checkBox16 = new System.Windows.Forms.CheckBox();
		this.checkBox19 = new System.Windows.Forms.CheckBox();
		this.checkBox20 = new System.Windows.Forms.CheckBox();
		this.checkBox23 = new System.Windows.Forms.CheckBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.label3 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.trackBar1 = new System.Windows.Forms.TrackBar();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.trackBar2 = new System.Windows.Forms.TrackBar();
		this.label6 = new System.Windows.Forms.Label();
		this.trackBar3 = new System.Windows.Forms.TrackBar();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar3).BeginInit();
		base.SuspendLayout();
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(14, 246);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(231, 17);
		this.checkBox3.TabIndex = 49;
		this.checkBox3.Text = "Disable Network Address Translation (NAT)";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(14, 210);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(180, 17);
		this.checkBox4.TabIndex = 48;
		this.checkBox4.Text = "Disable Peer-to-Peer Networking";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(14, 168);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(152, 17);
		this.checkBox8.TabIndex = 46;
		this.checkBox8.Text = "Enable Network Discovery";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox8.CheckedChanged += new System.EventHandler(checkBox8_CheckedChanged);
		this.checkBox11.AutoSize = true;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(14, 125);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(284, 17);
		this.checkBox11.TabIndex = 45;
		this.checkBox11.Text = "Disable Background Intelligent Transfer Service (BITS)";
		this.checkBox11.UseVisualStyleBackColor = true;
		this.checkBox11.CheckedChanged += new System.EventHandler(checkBox11_CheckedChanged);
		this.checkBox13.AutoSize = true;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(14, 86);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(161, 17);
		this.checkBox13.TabIndex = 43;
		this.checkBox13.Text = "Disable TCP/IP Auto-Tuning";
		this.checkBox13.UseVisualStyleBackColor = true;
		this.checkBox13.CheckedChanged += new System.EventHandler(checkBox13_CheckedChanged);
		this.checkBox14.AutoSize = true;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(14, 50);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(166, 17);
		this.checkBox14.TabIndex = 42;
		this.checkBox14.Text = "Disable Receive Side Scaling";
		this.checkBox14.UseVisualStyleBackColor = true;
		this.checkBox14.CheckedChanged += new System.EventHandler(checkBox14_CheckedChanged);
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(14, 15);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(156, 17);
		this.checkBox5.TabIndex = 41;
		this.checkBox5.Text = "Disable Large Send Offload";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
		this.checkBox10.AutoSize = true;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(11, 319);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(162, 17);
		this.checkBox10.TabIndex = 53;
		this.checkBox10.Text = "Disable Dynamic Port Range";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(11, 282);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(155, 17);
		this.checkBox15.TabIndex = 52;
		this.checkBox15.Text = "Increase Network Buffering";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(11, 361);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(171, 17);
		this.checkBox16.TabIndex = 55;
		this.checkBox16.Text = "Increase TCP Window Scaling";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox16.CheckedChanged += new System.EventHandler(checkBox16_CheckedChanged);
		this.checkBox19.AutoSize = true;
		this.checkBox19.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox19.Location = new System.Drawing.Point(14, 403);
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.Size = new System.Drawing.Size(220, 17);
		this.checkBox19.TabIndex = 58;
		this.checkBox19.Text = "Increase the number of TCP connections";
		this.checkBox19.UseVisualStyleBackColor = true;
		this.checkBox19.CheckedChanged += new System.EventHandler(checkBox19_CheckedChanged);
		this.checkBox20.AutoSize = true;
		this.checkBox20.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox20.Location = new System.Drawing.Point(14, 437);
		this.checkBox20.Name = "checkBox20";
		this.checkBox20.Size = new System.Drawing.Size(227, 17);
		this.checkBox20.TabIndex = 59;
		this.checkBox20.Text = "Disable Offload State on TCP Connections";
		this.checkBox20.UseVisualStyleBackColor = true;
		this.checkBox20.CheckedChanged += new System.EventHandler(checkBox20_CheckedChanged);
		this.checkBox23.AutoSize = true;
		this.checkBox23.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox23.Location = new System.Drawing.Point(14, 483);
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.Size = new System.Drawing.Size(248, 30);
		this.checkBox23.TabIndex = 62;
		this.checkBox23.Text = "Adjust the maximum number of simultaneous \r\nincomplete outbound TCP connection attempts";
		this.checkBox23.UseVisualStyleBackColor = true;
		this.checkBox23.CheckedChanged += new System.EventHandler(checkBox23_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(14, 532);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(214, 17);
		this.checkBox1.TabIndex = 63;
		this.checkBox1.Text = "Increase the number of Retransmissions";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged_1);
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.SystemColors.Control;
		this.label1.Location = new System.Drawing.Point(427, 19);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(48, 13);
		this.label1.TabIndex = 65;
		this.label1.Text = "Initial Rtt";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.SystemColors.Control;
		this.label2.Location = new System.Drawing.Point(427, 110);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(92, 13);
		this.label2.TabIndex = 67;
		this.label2.Text = "Initial Rtt Minimum";
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(14, 555);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(90, 17);
		this.checkBox6.TabIndex = 69;
		this.checkBox6.Text = "Enable TCPA";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged_1);
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.SystemColors.Control;
		this.label3.Location = new System.Drawing.Point(427, 201);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 13);
		this.label3.TabIndex = 70;
		this.label3.Text = "Cutom TTL";
		this.pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
		this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.pictureBox1.Location = new System.Drawing.Point(450, 515);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(169, 90);
		this.pictureBox1.TabIndex = 72;
		this.pictureBox1.TabStop = false;
		this.trackBar1.Location = new System.Drawing.Point(425, 232);
		this.trackBar1.Maximum = 255;
		this.trackBar1.Name = "trackBar1";
		this.trackBar1.Size = new System.Drawing.Size(104, 45);
		this.trackBar1.TabIndex = 73;
		this.trackBar1.TickFrequency = 52;
		this.trackBar1.Scroll += new System.EventHandler(trackBar1_Scroll);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(539, 241);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(13, 13);
		this.label4.TabIndex = 74;
		this.label4.Text = "0";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(539, 144);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(13, 13);
		this.label5.TabIndex = 76;
		this.label5.Text = "0";
		this.trackBar2.Location = new System.Drawing.Point(425, 140);
		this.trackBar2.Maximum = 3000;
		this.trackBar2.Name = "trackBar2";
		this.trackBar2.Size = new System.Drawing.Size(104, 45);
		this.trackBar2.TabIndex = 75;
		this.trackBar2.TickFrequency = 500;
		this.trackBar2.Scroll += new System.EventHandler(trackBar2_Scroll);
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(539, 54);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(13, 13);
		this.label6.TabIndex = 78;
		this.label6.Text = "0";
		this.trackBar3.Location = new System.Drawing.Point(425, 50);
		this.trackBar3.Maximum = 3000;
		this.trackBar3.Name = "trackBar3";
		this.trackBar3.Size = new System.Drawing.Size(104, 45);
		this.trackBar3.TabIndex = 77;
		this.trackBar3.TickFrequency = 500;
		this.trackBar3.Scroll += new System.EventHandler(trackBar3_Scroll);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.Controls.Add(this.label6);
		base.Controls.Add(this.trackBar3);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.trackBar2);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.trackBar1);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.checkBox6);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBox1);
		base.Controls.Add(this.checkBox23);
		base.Controls.Add(this.checkBox20);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.checkBox10);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox3);
		base.Controls.Add(this.checkBox4);
		base.Controls.Add(this.checkBox8);
		base.Controls.Add(this.checkBox11);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox5);
		this.ForeColor = System.Drawing.SystemColors.Control;
		base.Name = "UserControl5";
		base.Size = new System.Drawing.Size(619, 605);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.trackBar3).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
