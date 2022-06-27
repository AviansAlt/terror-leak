using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace E_Ware
{
	public class HomeUI : Form
	{
		public HomeUI()
		{
			this.InitializeComponent();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
			LoaderUI loaderUI = new LoaderUI();
			loaderUI.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			Process.Start("https://avian.lol");
            MessageBox.Show("Dumped by Avian! Don't follow Toro10, he's a skid.");
		}

		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new Container();
			this.button8 = new Button();
			this.button7 = new Button();
			this.Title = new Label();
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.label2 = new Label();
			this.siticoneButton1 = new SiticoneButton();
			this.siticoneButton2 = new SiticoneButton();
			this.siticoneDragControl1 = new SiticoneDragControl(this.components);
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.button8.BackColor = Color.FromArgb(10, 10, 10);
			this.button8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.Red;
			this.button8.Location = new Point(328, 6);
			this.button8.Name = "button8";
			this.button8.Size = new Size(28, 23);
			this.button8.TabIndex = 3;
			this.button8.Text = "X";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.button7.BackColor = Color.FromArgb(10, 10, 10);
			this.button7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.Red;
			this.button7.Location = new Point(294, 6);
			this.button7.Name = "button7";
			this.button7.Size = new Size(28, 23);
			this.button7.TabIndex = 2;
			this.button7.Text = "-";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.Title.AutoSize = true;
			this.Title.BackColor = Color.Black;
			this.Title.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Title.ForeColor = Color.Red;
			this.Title.Location = new Point(3, 3);
			this.Title.Name = "Title";
			this.Title.Size = new Size(68, 24);
			this.Title.TabIndex = 0;
			this.Title.Text = "Terror - Dumped by Avian";
			this.panel1.BackColor = Color.FromArgb(5, 5, 5);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.Title);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Location = new Point(-1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(359, 32);
			this.panel1.TabIndex = 4;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Black;
			this.label1.Font = new Font("Tahoma", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Red;
			this.label1.Location = new Point(84, 84);
			this.label1.Name = "label1";
			this.label1.Size = new Size(182, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "Welcome To";
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Black;
			this.label2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Red;
			this.label2.Location = new Point(140, 121);
			this.label2.Name = "label2";
			this.label2.Size = new Size(68, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Terror";
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = Color.Black;
			this.siticoneButton1.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.siticoneButton1.ForeColor = Color.Red;
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new Point(90, 164);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new Size(176, 23);
			this.siticoneButton1.TabIndex = 5;
			this.siticoneButton1.Text = "Launch Terror Exploit";
			this.siticoneButton1.Click += this.siticoneButton1_Click;
			this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
			this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
			this.siticoneButton2.FillColor = Color.Black;
			this.siticoneButton2.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.siticoneButton2.ForeColor = Color.Red;
			this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
			this.siticoneButton2.Location = new Point(90, 193);
			this.siticoneButton2.Name = "siticoneButton2";
			this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
			this.siticoneButton2.Size = new Size(176, 23);
			this.siticoneButton2.TabIndex = 6;
			this.siticoneButton2.Text = "Support Avian";
			this.siticoneButton2.Click += this.siticoneButton2_Click;
			this.siticoneDragControl1.TargetControl = this.panel1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(10, 10, 10);
			base.ClientSize = new Size(359, 251);
			base.Controls.Add(this.siticoneButton2);
			base.Controls.Add(this.siticoneButton1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "HomeUI";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "HomeUI";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private IContainer components = null;

		private Button button8;

		private Button button7;

		private Label Title;

		private Panel panel1;

		private Label label1;

		private Label label2;

		private SiticoneButton siticoneButton1;

		private SiticoneButton siticoneButton2;

		private SiticoneDragControl siticoneDragControl1;
	}
}
