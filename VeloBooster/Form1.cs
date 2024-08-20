using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace VeloBooster;

public class Form1 : Form
{
	private IContainer components;

	private Panel panel1;

	private Button button6;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private UserControl5 userControl51;

	private UserControl1 userControl11;

	private UserControl1 userControl12;

	private Label label2;

	private Panel panel2;

	private Panel panel3;

	private UserControl5 userControl52;

	private UserControl4 userControl41;

	private UserControl3 userControl31;

	private UserControl2 userControl21;

	private UserControl1 userControl13;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label1;

	private Label label7;

	private Button button5;

	private Label label8;

	private UserControl6 userControl61;

	private UserControl8 userControl81;

	private UserControl7 userControl71;

	private Button button7;

	private Button button9;

	private UserControl10 userControl101;

	private Button button10;

	private UserControl9 userControl91;

	private UserControl12 userControl121;

	private Button button11;

	private UserControl12 userControl122;

	private UserControl13 userControl131;

	private Label label9;

	private Button button12;

	private Button buttoneight;

	public Form1()
	{
		InitializeComponent();
		panel3.Show();
		userControl91.Hide();
		button10.Hide();
		panel2.Show();
		panel1.Show();
		userControl101.Hide();
		buttoneight.Hide();
		label9.Hide();
		userControl12.Hide();
		userControl13.Show();
		userControl21.Hide();
		userControl31.Hide();
		userControl41.Hide();
		userControl52.Hide();
		userControl61.Hide();
		userControl71.Hide();
		userControl81.Hide();
		userControl122.Hide();
		userControl131.Hide();
		button11.Hide();
		button9.Hide();
		button7.Hide();
		label1.Show();
		label3.Hide();
		label4.Hide();
		label5.Hide();
		label6.Hide();
		label7.Hide();
		button7.Hide();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		userControl91.Hide();
		button10.Hide();
		userControl101.Hide();
		buttoneight.Hide();
		label9.Hide();
		userControl13.Show();
		userControl13.BringToFront();
		userControl21.Hide();
		userControl31.Hide();
		userControl41.Hide();
		userControl52.Hide();
		userControl61.Hide();
		userControl71.Hide();
		userControl81.Hide();
		userControl122.Hide();
		userControl131.Hide();
		button11.Hide();
		button9.Hide();
		button7.Show();
		button7.BringToFront();
		label1.Show();
		label3.Hide();
		label4.Hide();
		label5.Hide();
		label6.Hide();
		label7.Hide();
	}

	private void label2_Click(object sender, EventArgs e)
	{
		userControl91.Hide();
		button10.Hide();
		userControl101.Hide();
		buttoneight.Hide();
		label9.Hide();
		userControl13.Hide();
		userControl21.Show();
		userControl21.BringToFront();
		userControl31.Hide();
		userControl41.Hide();
		userControl52.Hide();
		userControl71.Hide();
		userControl122.Hide();
		userControl131.Hide();
		button11.Hide();
		userControl81.Hide();
		button7.Hide();
		button9.Hide();
		userControl61.Hide();
		button7.Hide();
		label1.Hide();
		label3.Show();
		label4.Hide();
		label5.Hide();
		label7.Hide();
		label6.Hide();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		userControl91.Hide();
		button10.Hide();
		userControl101.Hide();
		userControl122.Hide();
		userControl131.Hide();
		button11.Hide();
		label9.Hide();
		buttoneight.Hide();
		userControl13.Hide();
		userControl21.Show();
		userControl21.BringToFront();
		userControl31.Hide();
		userControl41.Hide();
		userControl52.Hide();
		userControl61.Hide();
		userControl71.Hide();
		userControl81.Hide();
		button7.Hide();
		button9.Hide();
		button7.Hide();
		label1.Hide();
		label3.Show();
		label4.Hide();
		label5.Hide();
		label6.Hide();
		label7.Hide();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		userControl91.Hide();
		button10.Hide();
		userControl101.Hide();
		label9.Hide();
		userControl13.Hide();
		userControl21.Hide();
		userControl31.Show();
		userControl31.BringToFront();
		userControl41.Hide();
		userControl52.Hide();
		userControl61.Hide();
		userControl71.Hide();
		userControl81.Hide();
		userControl101.Hide();
		userControl122.Hide();
		userControl131.Hide();
		button11.Hide();
		button7.Hide();
		button9.Hide();
		label1.Hide();
		label3.Hide();
		label4.Show();
		label5.Hide();
		label6.Hide();
		label7.Hide();
		buttoneight.Show();
		buttoneight.BringToFront();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		userControl101.Hide();
		buttoneight.Hide();
		userControl91.Hide();
		label9.Hide();
		userControl13.Hide();
		userControl21.Hide();
		userControl31.Hide();
		userControl41.Show();
		userControl41.BringToFront();
		userControl52.Hide();
		userControl61.Hide();
		userControl71.Hide();
		userControl81.Hide();
		userControl122.Hide();
		userControl131.Hide();
		button11.Hide();
		button9.Hide();
		button7.Hide();
		label1.Hide();
		label3.Hide();
		label4.Hide();
		label5.Show();
		label6.Hide();
		label7.Hide();
		button10.Show();
		button10.BringToFront();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		userControl91.Hide();
		button10.Hide();
		userControl101.Hide();
		label9.Hide();
		buttoneight.Hide();
		userControl13.Hide();
		userControl21.Hide();
		userControl31.Hide();
		userControl41.Hide();
		userControl52.Show();
		userControl52.BringToFront();
		userControl61.Hide();
		userControl71.Hide();
		userControl81.Hide();
		userControl122.Hide();
		userControl131.Hide();
		button11.Hide();
		button7.Hide();
		button9.Show();
		button9.BringToFront();
		label1.Hide();
		label3.Hide();
		label4.Hide();
		label5.Hide();
		label6.Show();
		label7.Hide();
	}

	private void button8_Click(object sender, EventArgs e)
	{
		button9.Show();
	}

	private void panel3_Paint(object sender, PaintEventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void userControl52_Load(object sender, EventArgs e)
	{
	}

	private void userControl41_Load(object sender, EventArgs e)
	{
	}

	private void userControl52_Load_1(object sender, EventArgs e)
	{
		userControl81.Hide();
	}

	private void label7_Click(object sender, EventArgs e)
	{
	}

	private void button5_Click(object sender, EventArgs e)
	{
		userControl91.Hide();
		button10.Hide();
		userControl101.Hide();
		label9.Hide();
		buttoneight.Hide();
		userControl13.Hide();
		userControl21.Hide();
		userControl31.Hide();
		userControl41.Hide();
		userControl52.Hide();
		userControl71.Hide();
		userControl81.Hide();
		userControl122.Hide();
		userControl131.Hide();
		button11.Hide();
		userControl61.Show();
		userControl61.BringToFront();
		button9.Hide();
		button7.Hide();
		label1.Hide();
		label3.Hide();
		label4.Hide();
		label5.Hide();
		label6.Hide();
		label7.Show();
	}

	private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
	{
	}

	private void button7_Click(object sender, EventArgs e)
	{
		userControl81.Show();
		userControl81.BringToFront();
	}

	private void button8_Click_1(object sender, EventArgs e)
	{
		userControl51.Show();
		userControl51.BringToFront();
		userControl81.Hide();
	}

	private void userControl81_Load(object sender, EventArgs e)
	{
	}

	private void userControl71_Load(object sender, EventArgs e)
	{
	}

	private void button9_Click(object sender, EventArgs e)
	{
		userControl13.Show();
	}

	private void userControl13_Load(object sender, EventArgs e)
	{
		button7.Show();
	}

	private void button7_Click_1(object sender, EventArgs e)
	{
		userControl13.Show();
		userControl71.Show();
		userControl71.BringToFront();
		button7.Hide();
	}

	private void button8_Click_2(object sender, EventArgs e)
	{
		userControl13.Show();
		button7.Show();
	}

	private void button9_Click_1(object sender, EventArgs e)
	{
		userControl81.Show();
		userControl81.BringToFront();
		button9.Hide();
	}

	private void button8_Click_3(object sender, EventArgs e)
	{
		userControl101.Show();
		userControl101.BringToFront();
		buttoneight.Hide();
	}

	private void button10_Click(object sender, EventArgs e)
	{
		userControl91.Show();
		userControl91.BringToFront();
		button10.Hide();
	}

	private void button11_Click(object sender, EventArgs e)
	{
		userControl122.Hide();
		button11.Hide();
		userControl131.Show();
		userControl131.BringToFront();
	}

	private void label9_Click(object sender, EventArgs e)
	{
	}

	private void button12_Click(object sender, EventArgs e)
	{
		label9.Show();
		userControl122.Show();
		userControl122.BringToFront();
		button11.Show();
		button11.BringToFront();
		userControl131.Hide();
		label1.Hide();
		label3.Hide();
		label4.Hide();
		label5.Hide();
		label6.Hide();
		label7.Hide();
	}

	private void button13_Click(object sender, EventArgs e)
	{
	}

	private void buttoneight_Click(object sender, EventArgs e)
	{
		userControl101.Show();
		userControl101.BringToFront();
		buttoneight.Hide();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeloBooster.Form1));
		this.panel1 = new System.Windows.Forms.Panel();
		this.label9 = new System.Windows.Forms.Label();
		this.button12 = new System.Windows.Forms.Button();
		this.label8 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.button5 = new System.Windows.Forms.Button();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.userControl12 = new VeloBooster.UserControl1();
		this.userControl51 = new VeloBooster.UserControl5();
		this.userControl11 = new VeloBooster.UserControl1();
		this.button6 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.panel2 = new System.Windows.Forms.Panel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.buttoneight = new System.Windows.Forms.Button();
		this.button9 = new System.Windows.Forms.Button();
		this.button7 = new System.Windows.Forms.Button();
		this.button11 = new System.Windows.Forms.Button();
		this.button10 = new System.Windows.Forms.Button();
		this.userControl13 = new VeloBooster.UserControl1();
		this.userControl81 = new VeloBooster.UserControl8();
		this.userControl71 = new VeloBooster.UserControl7();
		this.userControl61 = new VeloBooster.UserControl6();
		this.userControl52 = new VeloBooster.UserControl5();
		this.userControl131 = new VeloBooster.UserControl13();
		this.userControl122 = new VeloBooster.UserControl12();
		this.userControl121 = new VeloBooster.UserControl12();
		this.userControl91 = new VeloBooster.UserControl9();
		this.userControl41 = new VeloBooster.UserControl4();
		this.userControl101 = new VeloBooster.UserControl10();
		this.userControl31 = new VeloBooster.UserControl3();
		this.userControl21 = new VeloBooster.UserControl2();
		this.panel1.SuspendLayout();
		this.panel2.SuspendLayout();
		this.panel3.SuspendLayout();
		base.SuspendLayout();
		this.panel1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.button12);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.button5);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.userControl12);
		this.panel1.Controls.Add(this.userControl51);
		this.panel1.Controls.Add(this.userControl11);
		this.panel1.Controls.Add(this.button6);
		this.panel1.Controls.Add(this.button4);
		this.panel1.Controls.Add(this.button3);
		this.panel1.Controls.Add(this.button2);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(181, 605);
		this.panel1.TabIndex = 0;
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.ForeColor = System.Drawing.SystemColors.Control;
		this.label9.Location = new System.Drawing.Point(7, 550);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(27, 25);
		this.label9.TabIndex = 18;
		this.label9.Text = "⭕";
		this.label9.Click += new System.EventHandler(label9_Click);
		this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button12.ForeColor = System.Drawing.SystemColors.Control;
		this.button12.Location = new System.Drawing.Point(12, 535);
		this.button12.Name = "button12";
		this.button12.Size = new System.Drawing.Size(151, 58);
		this.button12.TabIndex = 17;
		this.button12.Text = "1.5 Tweaks";
		this.button12.UseVisualStyleBackColor = true;
		this.button12.Click += new System.EventHandler(button12_Click);
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.ForeColor = System.Drawing.SystemColors.Control;
		this.label7.Location = new System.Drawing.Point(7, 473);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(27, 25);
		this.label7.TabIndex = 15;
		this.label7.Text = "⭕";
		this.label7.Click += new System.EventHandler(label7_Click);
		this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.ForeColor = System.Drawing.SystemColors.Control;
		this.button5.Location = new System.Drawing.Point(12, 458);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(151, 58);
		this.button5.TabIndex = 14;
		this.button5.Text = "Hardware";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.SystemColors.Control;
		this.label6.Location = new System.Drawing.Point(7, 390);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(27, 25);
		this.label6.TabIndex = 13;
		this.label6.Text = "⭕";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.SystemColors.Control;
		this.label5.Location = new System.Drawing.Point(7, 303);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(27, 25);
		this.label5.TabIndex = 12;
		this.label5.Text = "⭕";
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.SystemColors.Control;
		this.label4.Location = new System.Drawing.Point(7, 217);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(27, 25);
		this.label4.TabIndex = 11;
		this.label4.Text = "⭕";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.SystemColors.Control;
		this.label3.Location = new System.Drawing.Point(7, 130);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(27, 25);
		this.label3.TabIndex = 10;
		this.label3.Text = "⭕";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.SystemColors.Control;
		this.label1.Location = new System.Drawing.Point(7, 45);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(27, 25);
		this.label1.TabIndex = 9;
		this.label1.Text = "⭕";
		this.userControl12.BackColor = System.Drawing.Color.Black;
		this.userControl12.Location = new System.Drawing.Point(179, 3);
		this.userControl12.Name = "userControl12";
		this.userControl12.Size = new System.Drawing.Size(619, 605);
		this.userControl12.TabIndex = 8;
		this.userControl51.BackColor = System.Drawing.Color.Black;
		this.userControl51.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl51.Location = new System.Drawing.Point(179, 2);
		this.userControl51.Name = "userControl51";
		this.userControl51.Size = new System.Drawing.Size(621, 600);
		this.userControl51.TabIndex = 7;
		this.userControl11.BackColor = System.Drawing.Color.Black;
		this.userControl11.Location = new System.Drawing.Point(179, 2);
		this.userControl11.Name = "userControl11";
		this.userControl11.Size = new System.Drawing.Size(619, 605);
		this.userControl11.TabIndex = 6;
		this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button6.ForeColor = System.Drawing.SystemColors.Control;
		this.button6.Location = new System.Drawing.Point(12, 375);
		this.button6.Name = "button6";
		this.button6.Size = new System.Drawing.Size(151, 58);
		this.button6.TabIndex = 5;
		this.button6.Text = "Latency";
		this.button6.UseVisualStyleBackColor = true;
		this.button6.Click += new System.EventHandler(button6_Click);
		this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.ForeColor = System.Drawing.SystemColors.Control;
		this.button4.Location = new System.Drawing.Point(12, 288);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(151, 58);
		this.button4.TabIndex = 3;
		this.button4.Text = "Memory";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.ForeColor = System.Drawing.SystemColors.Control;
		this.button3.Location = new System.Drawing.Point(12, 202);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(151, 58);
		this.button3.TabIndex = 2;
		this.button3.Text = "GPU";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.SystemColors.Control;
		this.button2.Location = new System.Drawing.Point(12, 115);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(151, 58);
		this.button2.TabIndex = 1;
		this.button2.Text = "CPU";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.SystemColors.Control;
		this.button1.Location = new System.Drawing.Point(12, 30);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(151, 58);
		this.button1.TabIndex = 0;
		this.button1.Text = "Performance";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.label2.Click += new System.EventHandler(label2_Click);
		this.panel2.BackColor = System.Drawing.Color.Black;
		this.panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
		this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.panel2.Controls.Add(this.panel3);
		this.panel2.Controls.Add(this.label2);
		this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new System.Drawing.Point(181, 0);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(619, 605);
		this.panel2.TabIndex = 1;
		this.panel3.Controls.Add(this.buttoneight);
		this.panel3.Controls.Add(this.button9);
		this.panel3.Controls.Add(this.button7);
		this.panel3.Controls.Add(this.button11);
		this.panel3.Controls.Add(this.button10);
		this.panel3.Controls.Add(this.userControl13);
		this.panel3.Controls.Add(this.userControl81);
		this.panel3.Controls.Add(this.userControl71);
		this.panel3.Controls.Add(this.userControl61);
		this.panel3.Controls.Add(this.userControl52);
		this.panel3.Controls.Add(this.userControl131);
		this.panel3.Controls.Add(this.userControl122);
		this.panel3.Controls.Add(this.userControl121);
		this.panel3.Controls.Add(this.userControl91);
		this.panel3.Controls.Add(this.userControl41);
		this.panel3.Controls.Add(this.userControl101);
		this.panel3.Controls.Add(this.userControl31);
		this.panel3.Controls.Add(this.userControl21);
		this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel3.Location = new System.Drawing.Point(0, 0);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(619, 605);
		this.panel3.TabIndex = 3;
		this.buttoneight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttoneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.buttoneight.ForeColor = System.Drawing.SystemColors.Control;
		this.buttoneight.Location = new System.Drawing.Point(529, 240);
		this.buttoneight.Name = "buttoneight";
		this.buttoneight.Size = new System.Drawing.Size(87, 56);
		this.buttoneight.TabIndex = 20;
		this.buttoneight.Text = ">";
		this.buttoneight.UseVisualStyleBackColor = true;
		this.buttoneight.Click += new System.EventHandler(buttoneight_Click);
		this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button9.ForeColor = System.Drawing.SystemColors.Control;
		this.button9.Location = new System.Drawing.Point(529, 240);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(87, 56);
		this.button9.TabIndex = 11;
		this.button9.Text = ">";
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new System.EventHandler(button9_Click_1);
		this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button7.ForeColor = System.Drawing.SystemColors.Control;
		this.button7.Location = new System.Drawing.Point(529, 240);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(87, 56);
		this.button7.TabIndex = 9;
		this.button7.Text = ">";
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new System.EventHandler(button7_Click_1);
		this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button11.ForeColor = System.Drawing.SystemColors.Control;
		this.button11.Location = new System.Drawing.Point(529, 240);
		this.button11.Name = "button11";
		this.button11.Size = new System.Drawing.Size(87, 56);
		this.button11.TabIndex = 18;
		this.button11.Text = ">";
		this.button11.UseVisualStyleBackColor = true;
		this.button11.Click += new System.EventHandler(button11_Click);
		this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button10.ForeColor = System.Drawing.SystemColors.Control;
		this.button10.Location = new System.Drawing.Point(529, 240);
		this.button10.Name = "button10";
		this.button10.Size = new System.Drawing.Size(87, 56);
		this.button10.TabIndex = 14;
		this.button10.Text = ">";
		this.button10.UseVisualStyleBackColor = true;
		this.button10.Click += new System.EventHandler(button10_Click);
		this.userControl13.BackColor = System.Drawing.Color.Black;
		this.userControl13.Location = new System.Drawing.Point(-2, -3);
		this.userControl13.Name = "userControl13";
		this.userControl13.Size = new System.Drawing.Size(619, 605);
		this.userControl13.TabIndex = 0;
		this.userControl13.Load += new System.EventHandler(userControl13_Load);
		this.userControl81.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.userControl81.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl81.Location = new System.Drawing.Point(-2, 0);
		this.userControl81.Name = "userControl81";
		this.userControl81.Size = new System.Drawing.Size(619, 605);
		this.userControl81.TabIndex = 8;
		this.userControl81.Load += new System.EventHandler(userControl81_Load);
		this.userControl71.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.userControl71.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl71.Location = new System.Drawing.Point(-3, 0);
		this.userControl71.Name = "userControl71";
		this.userControl71.Size = new System.Drawing.Size(619, 605);
		this.userControl71.TabIndex = 7;
		this.userControl71.Load += new System.EventHandler(userControl71_Load);
		this.userControl61.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.userControl61.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl61.Location = new System.Drawing.Point(0, -2);
		this.userControl61.Name = "userControl61";
		this.userControl61.Size = new System.Drawing.Size(619, 605);
		this.userControl61.TabIndex = 5;
		this.userControl52.BackColor = System.Drawing.Color.Black;
		this.userControl52.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl52.Location = new System.Drawing.Point(0, 1);
		this.userControl52.Name = "userControl52";
		this.userControl52.Size = new System.Drawing.Size(622, 607);
		this.userControl52.TabIndex = 4;
		this.userControl52.Load += new System.EventHandler(userControl52_Load_1);
		this.userControl131.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.userControl131.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl131.Location = new System.Drawing.Point(-3, -2);
		this.userControl131.Name = "userControl131";
		this.userControl131.Size = new System.Drawing.Size(619, 605);
		this.userControl131.TabIndex = 19;
		this.userControl122.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.userControl122.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl122.Location = new System.Drawing.Point(-2, 1);
		this.userControl122.Name = "userControl122";
		this.userControl122.Size = new System.Drawing.Size(621, 604);
		this.userControl122.TabIndex = 17;
		this.userControl121.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.userControl121.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl121.Location = new System.Drawing.Point(-2, 1);
		this.userControl121.Name = "userControl121";
		this.userControl121.Size = new System.Drawing.Size(619, 605);
		this.userControl121.TabIndex = 16;
		this.userControl91.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.userControl91.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl91.Location = new System.Drawing.Point(0, 1);
		this.userControl91.Name = "userControl91";
		this.userControl91.Size = new System.Drawing.Size(619, 605);
		this.userControl91.TabIndex = 15;
		this.userControl41.BackColor = System.Drawing.Color.Black;
		this.userControl41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.userControl41.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl41.Location = new System.Drawing.Point(-2, 0);
		this.userControl41.Name = "userControl41";
		this.userControl41.Size = new System.Drawing.Size(619, 605);
		this.userControl41.TabIndex = 3;
		this.userControl101.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.userControl101.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl101.Location = new System.Drawing.Point(-2, 0);
		this.userControl101.Name = "userControl101";
		this.userControl101.Size = new System.Drawing.Size(619, 605);
		this.userControl101.TabIndex = 13;
		this.userControl31.BackColor = System.Drawing.Color.Black;
		this.userControl31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.userControl31.Location = new System.Drawing.Point(0, -2);
		this.userControl31.Name = "userControl31";
		this.userControl31.Size = new System.Drawing.Size(619, 605);
		this.userControl31.TabIndex = 2;
		this.userControl21.BackColor = System.Drawing.Color.Black;
		this.userControl21.ForeColor = System.Drawing.SystemColors.Control;
		this.userControl21.Location = new System.Drawing.Point(0, 0);
		this.userControl21.Name = "userControl21";
		this.userControl21.Size = new System.Drawing.Size(619, 605);
		this.userControl21.TabIndex = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 605);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.panel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Form1";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Velocity Booster";
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		this.panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
