using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VeloBooster;

public class UserControl11 : UserControl
{
	private IContainer components;

	private CheckBox checkBox3;

	private CheckBox checkBox2;

	private CheckBox checkBox1;

	private CheckBox checkBox4;

	private CheckBox checkBox5;

	private CheckBox checkBox6;

	private CheckBox checkBox7;

	private CheckBox checkBox8;

	private CheckBox checkBox9;

	private CheckBox checkBox10;

	private CheckBox checkBox11;

	private CheckBox checkBox12;

	private CheckBox checkBox13;

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

	private CheckBox checkBox26;

	private CheckBox checkBox27;

	private CheckBox checkBox28;

	public UserControl11()
	{
		InitializeComponent();
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			Registry.SetValue("HKEYLOCALMACHINE\\SYSTEM\\CurrentControlSet\\Services\\BasicRender\\Parameters", " EnableHDR", 1, RegistryValueKind.DWord);
		}
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox2.Checked)
		{
			Registry.SetValue("HKEYLOCALMACHINE\\SYSTEM\\CurrentControlSet\\Services\\BasicRender\\Parameters", " EnableVRS", 1, RegistryValueKind.DWord);
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
		this.checkBox3 = new System.Windows.Forms.CheckBox();
		this.checkBox2 = new System.Windows.Forms.CheckBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.checkBox4 = new System.Windows.Forms.CheckBox();
		this.checkBox5 = new System.Windows.Forms.CheckBox();
		this.checkBox6 = new System.Windows.Forms.CheckBox();
		this.checkBox7 = new System.Windows.Forms.CheckBox();
		this.checkBox8 = new System.Windows.Forms.CheckBox();
		this.checkBox9 = new System.Windows.Forms.CheckBox();
		this.checkBox10 = new System.Windows.Forms.CheckBox();
		this.checkBox11 = new System.Windows.Forms.CheckBox();
		this.checkBox12 = new System.Windows.Forms.CheckBox();
		this.checkBox13 = new System.Windows.Forms.CheckBox();
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
		this.checkBox26 = new System.Windows.Forms.CheckBox();
		this.checkBox27 = new System.Windows.Forms.CheckBox();
		this.checkBox28 = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.checkBox3.AutoSize = true;
		this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox3.Location = new System.Drawing.Point(12, 83);
		this.checkBox3.Name = "checkBox3";
		this.checkBox3.Size = new System.Drawing.Size(188, 17);
		this.checkBox3.TabIndex = 33;
		this.checkBox3.Text = "Enable physical address extension";
		this.checkBox3.UseVisualStyleBackColor = true;
		this.checkBox2.AutoSize = true;
		this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox2.Location = new System.Drawing.Point(12, 42);
		this.checkBox2.Name = "checkBox2";
		this.checkBox2.Size = new System.Drawing.Size(165, 17);
		this.checkBox2.TabIndex = 32;
		this.checkBox2.Text = "disables variable rate shading";
		this.checkBox2.UseVisualStyleBackColor = true;
		this.checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
		this.checkBox1.AutoSize = true;
		this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox1.Location = new System.Drawing.Point(12, 3);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(97, 17);
		this.checkBox1.TabIndex = 31;
		this.checkBox1.Text = "Dynamic range";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.checkBox4.AutoSize = true;
		this.checkBox4.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox4.Location = new System.Drawing.Point(12, 209);
		this.checkBox4.Name = "checkBox4";
		this.checkBox4.Size = new System.Drawing.Size(188, 17);
		this.checkBox4.TabIndex = 36;
		this.checkBox4.Text = "Enable physical address extension";
		this.checkBox4.UseVisualStyleBackColor = true;
		this.checkBox5.AutoSize = true;
		this.checkBox5.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox5.Location = new System.Drawing.Point(12, 168);
		this.checkBox5.Name = "checkBox5";
		this.checkBox5.Size = new System.Drawing.Size(162, 17);
		this.checkBox5.TabIndex = 35;
		this.checkBox5.Text = "Disable memory compression";
		this.checkBox5.UseVisualStyleBackColor = true;
		this.checkBox6.AutoSize = true;
		this.checkBox6.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox6.Location = new System.Drawing.Point(12, 129);
		this.checkBox6.Name = "checkBox6";
		this.checkBox6.Size = new System.Drawing.Size(152, 17);
		this.checkBox6.TabIndex = 34;
		this.checkBox6.Text = "Enable NUMA optimization";
		this.checkBox6.UseVisualStyleBackColor = true;
		this.checkBox7.AutoSize = true;
		this.checkBox7.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox7.Location = new System.Drawing.Point(12, 455);
		this.checkBox7.Name = "checkBox7";
		this.checkBox7.Size = new System.Drawing.Size(188, 17);
		this.checkBox7.TabIndex = 42;
		this.checkBox7.Text = "Enable physical address extension";
		this.checkBox7.UseVisualStyleBackColor = true;
		this.checkBox8.AutoSize = true;
		this.checkBox8.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox8.Location = new System.Drawing.Point(12, 414);
		this.checkBox8.Name = "checkBox8";
		this.checkBox8.Size = new System.Drawing.Size(162, 17);
		this.checkBox8.TabIndex = 41;
		this.checkBox8.Text = "Disable memory compression";
		this.checkBox8.UseVisualStyleBackColor = true;
		this.checkBox9.AutoSize = true;
		this.checkBox9.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox9.Location = new System.Drawing.Point(12, 375);
		this.checkBox9.Name = "checkBox9";
		this.checkBox9.Size = new System.Drawing.Size(152, 17);
		this.checkBox9.TabIndex = 40;
		this.checkBox9.Text = "Enable NUMA optimization";
		this.checkBox9.UseVisualStyleBackColor = true;
		this.checkBox10.AutoSize = true;
		this.checkBox10.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox10.Location = new System.Drawing.Point(12, 329);
		this.checkBox10.Name = "checkBox10";
		this.checkBox10.Size = new System.Drawing.Size(188, 17);
		this.checkBox10.TabIndex = 39;
		this.checkBox10.Text = "Enable physical address extension";
		this.checkBox10.UseVisualStyleBackColor = true;
		this.checkBox11.AutoSize = true;
		this.checkBox11.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox11.Location = new System.Drawing.Point(12, 288);
		this.checkBox11.Name = "checkBox11";
		this.checkBox11.Size = new System.Drawing.Size(162, 17);
		this.checkBox11.TabIndex = 38;
		this.checkBox11.Text = "Disable memory compression";
		this.checkBox11.UseVisualStyleBackColor = true;
		this.checkBox12.AutoSize = true;
		this.checkBox12.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox12.Location = new System.Drawing.Point(12, 249);
		this.checkBox12.Name = "checkBox12";
		this.checkBox12.Size = new System.Drawing.Size(152, 17);
		this.checkBox12.TabIndex = 37;
		this.checkBox12.Text = "Enable NUMA optimization";
		this.checkBox12.UseVisualStyleBackColor = true;
		this.checkBox13.AutoSize = true;
		this.checkBox13.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox13.Location = new System.Drawing.Point(268, 209);
		this.checkBox13.Name = "checkBox13";
		this.checkBox13.Size = new System.Drawing.Size(188, 17);
		this.checkBox13.TabIndex = 48;
		this.checkBox13.Text = "Enable physical address extension";
		this.checkBox13.UseVisualStyleBackColor = true;
		this.checkBox14.AutoSize = true;
		this.checkBox14.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox14.Location = new System.Drawing.Point(268, 168);
		this.checkBox14.Name = "checkBox14";
		this.checkBox14.Size = new System.Drawing.Size(162, 17);
		this.checkBox14.TabIndex = 47;
		this.checkBox14.Text = "Disable memory compression";
		this.checkBox14.UseVisualStyleBackColor = true;
		this.checkBox15.AutoSize = true;
		this.checkBox15.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox15.Location = new System.Drawing.Point(268, 129);
		this.checkBox15.Name = "checkBox15";
		this.checkBox15.Size = new System.Drawing.Size(152, 17);
		this.checkBox15.TabIndex = 46;
		this.checkBox15.Text = "Enable NUMA optimization";
		this.checkBox15.UseVisualStyleBackColor = true;
		this.checkBox16.AutoSize = true;
		this.checkBox16.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox16.Location = new System.Drawing.Point(268, 83);
		this.checkBox16.Name = "checkBox16";
		this.checkBox16.Size = new System.Drawing.Size(188, 17);
		this.checkBox16.TabIndex = 45;
		this.checkBox16.Text = "Enable physical address extension";
		this.checkBox16.UseVisualStyleBackColor = true;
		this.checkBox17.AutoSize = true;
		this.checkBox17.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox17.Location = new System.Drawing.Point(268, 42);
		this.checkBox17.Name = "checkBox17";
		this.checkBox17.Size = new System.Drawing.Size(162, 17);
		this.checkBox17.TabIndex = 44;
		this.checkBox17.Text = "Disable memory compression";
		this.checkBox17.UseVisualStyleBackColor = true;
		this.checkBox18.AutoSize = true;
		this.checkBox18.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox18.Location = new System.Drawing.Point(268, 3);
		this.checkBox18.Name = "checkBox18";
		this.checkBox18.Size = new System.Drawing.Size(152, 17);
		this.checkBox18.TabIndex = 43;
		this.checkBox18.Text = "Enable NUMA optimization";
		this.checkBox18.UseVisualStyleBackColor = true;
		this.checkBox19.AutoSize = true;
		this.checkBox19.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox19.Location = new System.Drawing.Point(268, 455);
		this.checkBox19.Name = "checkBox19";
		this.checkBox19.Size = new System.Drawing.Size(188, 17);
		this.checkBox19.TabIndex = 54;
		this.checkBox19.Text = "Enable physical address extension";
		this.checkBox19.UseVisualStyleBackColor = true;
		this.checkBox20.AutoSize = true;
		this.checkBox20.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox20.Location = new System.Drawing.Point(268, 414);
		this.checkBox20.Name = "checkBox20";
		this.checkBox20.Size = new System.Drawing.Size(162, 17);
		this.checkBox20.TabIndex = 53;
		this.checkBox20.Text = "Disable memory compression";
		this.checkBox20.UseVisualStyleBackColor = true;
		this.checkBox21.AutoSize = true;
		this.checkBox21.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox21.Location = new System.Drawing.Point(268, 375);
		this.checkBox21.Name = "checkBox21";
		this.checkBox21.Size = new System.Drawing.Size(152, 17);
		this.checkBox21.TabIndex = 52;
		this.checkBox21.Text = "Enable NUMA optimization";
		this.checkBox21.UseVisualStyleBackColor = true;
		this.checkBox22.AutoSize = true;
		this.checkBox22.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox22.Location = new System.Drawing.Point(268, 329);
		this.checkBox22.Name = "checkBox22";
		this.checkBox22.Size = new System.Drawing.Size(188, 17);
		this.checkBox22.TabIndex = 51;
		this.checkBox22.Text = "Enable physical address extension";
		this.checkBox22.UseVisualStyleBackColor = true;
		this.checkBox23.AutoSize = true;
		this.checkBox23.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox23.Location = new System.Drawing.Point(268, 288);
		this.checkBox23.Name = "checkBox23";
		this.checkBox23.Size = new System.Drawing.Size(162, 17);
		this.checkBox23.TabIndex = 50;
		this.checkBox23.Text = "Disable memory compression";
		this.checkBox23.UseVisualStyleBackColor = true;
		this.checkBox24.AutoSize = true;
		this.checkBox24.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox24.Location = new System.Drawing.Point(268, 249);
		this.checkBox24.Name = "checkBox24";
		this.checkBox24.Size = new System.Drawing.Size(152, 17);
		this.checkBox24.TabIndex = 49;
		this.checkBox24.Text = "Enable NUMA optimization";
		this.checkBox24.UseVisualStyleBackColor = true;
		this.checkBox25.AutoSize = true;
		this.checkBox25.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox25.Location = new System.Drawing.Point(12, 534);
		this.checkBox25.Name = "checkBox25";
		this.checkBox25.Size = new System.Drawing.Size(188, 17);
		this.checkBox25.TabIndex = 56;
		this.checkBox25.Text = "Enable physical address extension";
		this.checkBox25.UseVisualStyleBackColor = true;
		this.checkBox26.AutoSize = true;
		this.checkBox26.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox26.Location = new System.Drawing.Point(12, 493);
		this.checkBox26.Name = "checkBox26";
		this.checkBox26.Size = new System.Drawing.Size(162, 17);
		this.checkBox26.TabIndex = 55;
		this.checkBox26.Text = "Disable memory compression";
		this.checkBox26.UseVisualStyleBackColor = true;
		this.checkBox27.AutoSize = true;
		this.checkBox27.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox27.Location = new System.Drawing.Point(268, 534);
		this.checkBox27.Name = "checkBox27";
		this.checkBox27.Size = new System.Drawing.Size(188, 17);
		this.checkBox27.TabIndex = 58;
		this.checkBox27.Text = "Enable physical address extension";
		this.checkBox27.UseVisualStyleBackColor = true;
		this.checkBox28.AutoSize = true;
		this.checkBox28.ForeColor = System.Drawing.SystemColors.Control;
		this.checkBox28.Location = new System.Drawing.Point(268, 493);
		this.checkBox28.Name = "checkBox28";
		this.checkBox28.Size = new System.Drawing.Size(162, 17);
		this.checkBox28.TabIndex = 57;
		this.checkBox28.Text = "Disable memory compression";
		this.checkBox28.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		base.Controls.Add(this.checkBox27);
		base.Controls.Add(this.checkBox28);
		base.Controls.Add(this.checkBox25);
		base.Controls.Add(this.checkBox26);
		base.Controls.Add(this.checkBox19);
		base.Controls.Add(this.checkBox20);
		base.Controls.Add(this.checkBox21);
		base.Controls.Add(this.checkBox22);
		base.Controls.Add(this.checkBox23);
		base.Controls.Add(this.checkBox24);
		base.Controls.Add(this.checkBox13);
		base.Controls.Add(this.checkBox14);
		base.Controls.Add(this.checkBox15);
		base.Controls.Add(this.checkBox16);
		base.Controls.Add(this.checkBox17);
		base.Controls.Add(this.checkBox18);
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
		base.Name = "UserControl11";
		base.Size = new System.Drawing.Size(619, 605);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
