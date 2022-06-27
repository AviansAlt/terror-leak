using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyExploits;
using FastColoredTextBoxNS;
using KrnlAPI;
using Siticone.UI.WinForms;
using WeAreDevs_API;

namespace E_Ware
{
	public class MainUI : Form
	{
		public MainUI()
		{
			this.InitializeComponent();
			MainAPI.Load();
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void button6_Click(object sender, EventArgs e)
		{
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.ScriptHere.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.ScriptHere.Text);
					}
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ScriptHere.Text = File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem));
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		private void name_Click(object sender, EventArgs e)
		{
		}

		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			bool @checked = this.EasyExploitsRadio.Checked;
			if (@checked)
			{
				this.EasyExploits.LaunchExploit();
			}
			else
			{
				bool checked2 = this.KrnlRadio.Checked;
				if (checked2)
				{
					MainAPI.Inject();
				}
				else
				{
					bool checked3 = this.WRDRadio.Checked;
					if (checked3)
					{
						this.WRDAPI.LaunchExploit();
					}
				}
			}
		}

		private void siticoneButton4_Click(object sender, EventArgs e)
		{
			this.ScriptHere.Clear();
		}

		private void siticoneButton5_Click(object sender, EventArgs e)
		{
			bool @checked = this.EasyExploitsRadio.Checked;
			if (@checked)
			{
				this.EasyExploits.ExecuteScript(this.ScriptHere.Text);
			}
			else
			{
				bool checked2 = this.KrnlRadio.Checked;
				if (checked2)
				{
					MainAPI.Execute(this.ScriptHere.Text);
				}
				else
				{
					bool checked3 = this.WRDRadio.Checked;
					if (checked3)
					{
						this.WRDAPI.SendLuaScript(this.ScriptHere.Text);
					}
				}
			}
		}

		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.ScriptHere.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.ScriptHere.Text);
					}
				}
			}
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainUI));
			this.panel1 = new Panel();
			this.button8 = new Button();
			this.button7 = new Button();
			this.close = new Button();
			this.Title = new Label();
			this.listBox1 = new ListBox();
			this.ScriptHere = new FastColoredTextBox();
			this.siticoneButton1 = new SiticoneButton();
			this.siticoneButton2 = new SiticoneButton();
			this.siticoneButton3 = new SiticoneButton();
			this.siticoneButton4 = new SiticoneButton();
			this.siticoneButton5 = new SiticoneButton();
			this.EasyExploitsRadio = new SiticoneRadioButton();
			this.KrnlRadio = new SiticoneRadioButton();
			this.WRDRadio = new SiticoneRadioButton();
			this.panel1.SuspendLayout();
			this.ScriptHere.BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(5, 5, 5);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.close);
			this.panel1.Controls.Add(this.Title);
			this.panel1.Location = new Point(-1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(482, 30);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += this.panel1_MouseDown;
			this.panel1.MouseMove += this.panel1_MouseMove;
			this.button8.BackColor = Color.FromArgb(10, 10, 10);
			this.button8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.Red;
			this.button8.Location = new Point(383, 3);
			this.button8.Name = "button8";
			this.button8.Size = new Size(28, 23);
			this.button8.TabIndex = 3;
			this.button8.Text = "↻";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.button7.BackColor = Color.FromArgb(10, 10, 10);
			this.button7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.Red;
			this.button7.Location = new Point(417, 4);
			this.button7.Name = "button7";
			this.button7.Size = new Size(28, 23);
			this.button7.TabIndex = 2;
			this.button7.Text = "-";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.close.BackColor = Color.FromArgb(10, 10, 10);
			this.close.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.close.ForeColor = Color.Red;
			this.close.Location = new Point(451, 4);
			this.close.Name = "close";
			this.close.Size = new Size(28, 23);
			this.close.TabIndex = 1;
			this.close.Text = "X";
			this.close.UseVisualStyleBackColor = false;
			this.close.Click += this.close_Click;
			this.Title.AutoSize = true;
			this.Title.BackColor = Color.Black;
			this.Title.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Title.ForeColor = Color.Red;
			this.Title.Location = new Point(5, 3);
			this.Title.Name = "Title";
			this.Title.Size = new Size(68, 24);
			this.Title.TabIndex = 0;
			this.Title.Text = "Terror";
			this.Title.Click += this.name_Click;
			this.listBox1.BackColor = Color.FromArgb(20, 20, 20);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.ForeColor = Color.Red;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new Point(86, 168);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new Size(382, 104);
			this.listBox1.TabIndex = 8;
			this.listBox1.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
			this.ScriptHere.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.ScriptHere.AutoScrollMinSize = new Size(139, 42);
			this.ScriptHere.BackBrush = null;
			this.ScriptHere.BackColor = Color.FromArgb(20, 20, 20);
			this.ScriptHere.CharHeight = 14;
			this.ScriptHere.CharWidth = 8;
			this.ScriptHere.Cursor = Cursors.IBeam;
			this.ScriptHere.DisabledColor = Color.FromArgb(100, 180, 180, 180);
			this.ScriptHere.Font = new Font("Courier New", 9.75f);
			this.ScriptHere.ForeColor = Color.Red;
			this.ScriptHere.IndentBackColor = Color.Maroon;
			this.ScriptHere.IsReplaceMode = false;
			this.ScriptHere.Location = new Point(86, 36);
			this.ScriptHere.Name = "ScriptHere";
			this.ScriptHere.Paddings = new Padding(0);
			this.ScriptHere.SelectionColor = Color.FromArgb(60, 0, 0, 255);
			this.ScriptHere.ServiceColors = (ServiceColors)componentResourceManager.GetObject("ScriptHere.ServiceColors");
			this.ScriptHere.Size = new Size(382, 119);
			this.ScriptHere.TabIndex = 11;
			this.ScriptHere.Text = "Terror\r\nMade By Toro10\r\n";
			this.ScriptHere.Zoom = 100;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = Color.FromArgb(10, 10, 10);
			this.siticoneButton1.Font = new Font("Segoe UI", 9f);
			this.siticoneButton1.ForeColor = Color.Red;
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new Point(8, 132);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.PressedColor = Color.BlanchedAlmond;
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new Size(60, 18);
			this.siticoneButton1.TabIndex = 12;
			this.siticoneButton1.Text = "Inject";
			this.siticoneButton1.Click += this.siticoneButton1_Click;
			this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
			this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
			this.siticoneButton2.FillColor = Color.FromArgb(10, 10, 10);
			this.siticoneButton2.Font = new Font("Segoe UI", 9f);
			this.siticoneButton2.ForeColor = Color.Red;
			this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
			this.siticoneButton2.Location = new Point(8, 108);
			this.siticoneButton2.Name = "siticoneButton2";
			this.siticoneButton2.PressedColor = Color.BlanchedAlmond;
			this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
			this.siticoneButton2.Size = new Size(60, 18);
			this.siticoneButton2.TabIndex = 13;
			this.siticoneButton2.Text = "Save File";
			this.siticoneButton2.Click += this.siticoneButton2_Click;
			this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
			this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
			this.siticoneButton3.FillColor = Color.FromArgb(10, 10, 10);
			this.siticoneButton3.Font = new Font("Segoe UI", 9f);
			this.siticoneButton3.ForeColor = Color.Red;
			this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
			this.siticoneButton3.Location = new Point(8, 84);
			this.siticoneButton3.Name = "siticoneButton3";
			this.siticoneButton3.PressedColor = Color.BlanchedAlmond;
			this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
			this.siticoneButton3.Size = new Size(60, 18);
			this.siticoneButton3.TabIndex = 14;
			this.siticoneButton3.Text = "Open File";
			this.siticoneButton3.Click += this.siticoneButton3_Click;
			this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
			this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
			this.siticoneButton4.FillColor = Color.FromArgb(10, 10, 10);
			this.siticoneButton4.Font = new Font("Segoe UI", 9f);
			this.siticoneButton4.ForeColor = Color.Red;
			this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
			this.siticoneButton4.Location = new Point(8, 60);
			this.siticoneButton4.Name = "siticoneButton4";
			this.siticoneButton4.PressedColor = Color.BlanchedAlmond;
			this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
			this.siticoneButton4.Size = new Size(60, 18);
			this.siticoneButton4.TabIndex = 15;
			this.siticoneButton4.Text = "Clear";
			this.siticoneButton4.Click += this.siticoneButton4_Click;
			this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
			this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
			this.siticoneButton5.FillColor = Color.FromArgb(10, 10, 10);
			this.siticoneButton5.Font = new Font("Segoe UI", 9f);
			this.siticoneButton5.ForeColor = Color.Red;
			this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
			this.siticoneButton5.Location = new Point(8, 36);
			this.siticoneButton5.Name = "siticoneButton5";
			this.siticoneButton5.PressedColor = Color.BlanchedAlmond;
			this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
			this.siticoneButton5.Size = new Size(60, 18);
			this.siticoneButton5.TabIndex = 16;
			this.siticoneButton5.Text = "Execute";
			this.siticoneButton5.Click += this.siticoneButton5_Click;
			this.EasyExploitsRadio.AutoSize = true;
			this.EasyExploitsRadio.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.EasyExploitsRadio.CheckedState.BorderThickness = 0;
			this.EasyExploitsRadio.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.EasyExploitsRadio.CheckedState.InnerColor = Color.White;
			this.EasyExploitsRadio.ForeColor = Color.Red;
			this.EasyExploitsRadio.Location = new Point(-1, 255);
			this.EasyExploitsRadio.Name = "EasyExploitsRadio";
			this.EasyExploitsRadio.Size = new Size(84, 17);
			this.EasyExploitsRadio.TabIndex = 17;
			this.EasyExploitsRadio.TabStop = true;
			this.EasyExploitsRadio.Text = "EasyExploits";
			this.EasyExploitsRadio.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.EasyExploitsRadio.UncheckedState.BorderThickness = 2;
			this.EasyExploitsRadio.UncheckedState.FillColor = Color.Transparent;
			this.EasyExploitsRadio.UncheckedState.InnerColor = Color.Transparent;
			this.EasyExploitsRadio.UseVisualStyleBackColor = true;
			this.KrnlRadio.AutoSize = true;
			this.KrnlRadio.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.KrnlRadio.CheckedState.BorderThickness = 0;
			this.KrnlRadio.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.KrnlRadio.CheckedState.InnerColor = Color.White;
			this.KrnlRadio.ForeColor = Color.Red;
			this.KrnlRadio.Location = new Point(-1, 232);
			this.KrnlRadio.Name = "KrnlRadio";
			this.KrnlRadio.Size = new Size(60, 17);
			this.KrnlRadio.TabIndex = 18;
			this.KrnlRadio.TabStop = true;
			this.KrnlRadio.Text = "KrnlAPI";
			this.KrnlRadio.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.KrnlRadio.UncheckedState.BorderThickness = 2;
			this.KrnlRadio.UncheckedState.FillColor = Color.Transparent;
			this.KrnlRadio.UncheckedState.InnerColor = Color.Transparent;
			this.KrnlRadio.UseVisualStyleBackColor = true;
			this.WRDRadio.AutoSize = true;
			this.WRDRadio.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.WRDRadio.CheckedState.BorderThickness = 0;
			this.WRDRadio.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.WRDRadio.CheckedState.InnerColor = Color.White;
			this.WRDRadio.ForeColor = Color.Red;
			this.WRDRadio.Location = new Point(-1, 209);
			this.WRDRadio.Name = "WRDRadio";
			this.WRDRadio.Size = new Size(70, 17);
			this.WRDRadio.TabIndex = 19;
			this.WRDRadio.TabStop = true;
			this.WRDRadio.Text = "WRD Api";
			this.WRDRadio.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.WRDRadio.UncheckedState.BorderThickness = 2;
			this.WRDRadio.UncheckedState.FillColor = Color.Transparent;
			this.WRDRadio.UncheckedState.InnerColor = Color.Transparent;
			this.WRDRadio.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(10, 10, 10);
			base.ClientSize = new Size(480, 283);
			base.Controls.Add(this.WRDRadio);
			base.Controls.Add(this.KrnlRadio);
			base.Controls.Add(this.EasyExploitsRadio);
			base.Controls.Add(this.siticoneButton5);
			base.Controls.Add(this.siticoneButton4);
			base.Controls.Add(this.siticoneButton3);
			base.Controls.Add(this.siticoneButton2);
			base.Controls.Add(this.siticoneButton1);
			base.Controls.Add(this.ScriptHere);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "MainUI";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "MainUI";
			base.Load += this.Form1_Load;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ScriptHere.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private Module EasyExploits = new Module();

		private ExploitAPI WRDAPI = new ExploitAPI();

		private Point lastPoint;

		private IContainer components = null;

		private Panel panel1;

		private Label Title;

		private Button button7;

		private Button close;

		private ListBox listBox1;

		private Button button8;

		private FastColoredTextBox ScriptHere;

		private SiticoneButton siticoneButton1;

		private SiticoneButton siticoneButton2;

		private SiticoneButton siticoneButton3;

		private SiticoneButton siticoneButton4;

		private SiticoneButton siticoneButton5;

		private SiticoneRadioButton EasyExploitsRadio;

		private SiticoneRadioButton KrnlRadio;

		private SiticoneRadioButton WRDRadio;
	}
}
