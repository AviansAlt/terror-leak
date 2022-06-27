using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace E_Ware
{
	// Token: 0x02000005 RID: 5
	public class LoaderUI : Form
	{
		public LoaderUI()
		{
			this.InitializeComponent();
		}

		[DebuggerStepThrough]
		private void timer1_Tick(object sender, EventArgs e)
		{
			LoaderUI.<timer1_Tick>d__1 <timer1_Tick>d__ = new LoaderUI.<timer1_Tick>d__1();
			<timer1_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<timer1_Tick>d__.<>4__this = this;
			<timer1_Tick>d__.sender = sender;
			<timer1_Tick>d__.e = e;
			<timer1_Tick>d__.<>1__state = -1;
			<timer1_Tick>d__.<>t__builder.Start<LoaderUI.<timer1_Tick>d__1>(ref <timer1_Tick>d__);
		}

        //random shit??? (wtf)
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
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
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.Title = new Label();
			this.label1 = new Label();
			this.timer1 = new Timer(this.components);
			this.panel3 = new Panel();
			this.siticoneButton1 = new SiticoneButton();
			this.label2 = new Label();
			this.siticoneDragControl1 = new SiticoneDragControl(this.components);
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(20, 20, 20);
			this.panel1.Location = new Point(11, 141);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(282, 38);
			this.panel1.TabIndex = 0;
			this.panel2.BackColor = Color.Red;
			this.panel2.Location = new Point(-4, 141);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(17, 38);
			this.panel2.TabIndex = 1;
			this.Title.AutoSize = true;
			this.Title.BackColor = Color.Black;
			this.Title.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Title.ForeColor = Color.Red;
			this.Title.Location = new Point(3, 6);
			this.Title.Name = "Title";
			this.Title.Size = new Size(130, 18);
			this.Title.TabIndex = 2;
			this.Title.Text = "Terror - Loading";
			this.label1.Font = new Font("Franklin Gothic Medium", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Red;
			this.label1.Location = new Point(-4, 109);
			this.label1.Name = "label1";
			this.label1.Size = new Size(297, 23);
			this.label1.TabIndex = 3;
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.timer1.Enabled = true;
			this.timer1.Tick += this.timer1_Tick;
			this.panel3.BackColor = Color.FromArgb(5, 5, 5);
			this.panel3.Controls.Add(this.siticoneButton1);
			this.panel3.Controls.Add(this.Title);
			this.panel3.Location = new Point(0, 1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(293, 29);
			this.panel3.TabIndex = 4;
			this.panel3.Paint += this.panel3_Paint;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = Color.Black;
			this.siticoneButton1.Font = new Font("Segoe UI", 9f);
			this.siticoneButton1.ForeColor = Color.Red;
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new Point(262, 3);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new Size(28, 23);
			this.siticoneButton1.TabIndex = 3;
			this.siticoneButton1.Text = "X";
			this.siticoneButton1.Click += this.siticoneButton1_Click;
			this.label2.BackColor = Color.Black;
			this.label2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Red;
			this.label2.Location = new Point(-4, 91);
			this.label2.Name = "label2";
			this.label2.Size = new Size(297, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Terror ";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.siticoneDragControl1.TargetControl = this.panel3;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(10, 10, 10);
			base.ClientSize = new Size(291, 179);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "LoaderUI";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "LoaderUI";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		private IContainer components = null;

		private Panel panel1;

		private Panel panel2;

		private Label Title;

		private Label label1;

		private Timer timer1;

		private Panel panel3;

		private Label label2;

		private SiticoneDragControl siticoneDragControl1;

		private SiticoneButton siticoneButton1;
	}
}
