using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Office2007Rendering;

namespace Black_n_White
{
	public partial class Black_n_WhiteForm : Form
	{
		private readonly StringBuilder stringBuilder = new StringBuilder();
		private byte gameSize = 3;
		private Random randomNumber = new Random();

		public Black_n_WhiteForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new Office2007Renderer();
			ClearStatusLabel(sender: sender, e: e);
		}

		#region Statuslabel

		private void SetStatusLabel(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				toolStripStatusLabel.Text = button.AccessibleDescription;
			}
			else if (sender is Label label)
			{
				toolStripStatusLabel.Text = label.AccessibleDescription;
			}
		}

		private void SetStatusLabelField(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				stringBuilder.Clear().Append(value: button.AccessibleName).Append(value: ": ");

				switch (button.BackColor.Name)
				{
					case "Black":
						stringBuilder.Append(value: I10n.colorNameBlack);
						break;
					case "White":
						stringBuilder.Append(value: I10n.colorNameWhite);
						break;
					default:
						stringBuilder.Append(value: button.BackColor.Name);
						break;
				}

				toolStripStatusLabel.Text = stringBuilder.ToString();
			}
		}

		private void ClearStatusLabel(object sender, EventArgs e) => toolStripStatusLabel.Text = String.Empty;

		#endregion

		private Color FieldColor()
		{
			switch (randomNumber.Next(minValue: 0, maxValue: 2))
			{
				case 0:
					return Color.Black;
				case 1:
					return Color.White;
				default:
					return SystemColors.Control;
			}
		}

		private Color InvertColor(object sender, EventArgs e)
		{
			switch (randomNumber.Next(minValue: 0, maxValue: 2))
			{
				case 0:
					return Color.Black;
				case 1:
					return Color.White;
				default:
					return SystemColors.Control;
			}
		}

		private void InitGamefield3x3()
		{
			foreach (Control button in tableLayoutPanelGame3x3.Controls)
			{
				button.BackColor = FieldColor();
			}
		}

		private void InitGamefield4x4()
		{
			foreach (Control button in tableLayoutPanelGame4x4.Controls)
			{
				button.BackColor = FieldColor();
			}
		}

		private void InitGamefield5x5()
		{
			foreach (Control button in tableLayoutPanelGame5x5.Controls)
			{
				button.BackColor = FieldColor();
			}
		}

		private void ToolStripMenuItemNewGame3x3_Click(object sender, EventArgs e)
		{
			gameSize = 3;
			toolStripMenuItemNewGame3x3.Checked = true;
			toolStripMenuItemNewGame4x4.Checked = false;
			toolStripMenuItemNewGame5x5.Checked = false;
			tabControl.SelectedTab = tabPageGame3x3;
			InitGamefield3x3();
		}

		private void ToolStripMenuItemNewGame4x4_Click(object sender, EventArgs e)
		{
			gameSize = 4;
			toolStripMenuItemNewGame3x3.Checked = false;
			toolStripMenuItemNewGame4x4.Checked = true;
			toolStripMenuItemNewGame5x5.Checked = false;
			tabControl.SelectedTab = tabPageGame4x4;
			InitGamefield4x4();
		}

		private void ToolStripMenuItemNewGame5x5_Click(object sender, EventArgs e)
		{
			gameSize = 5;
			toolStripMenuItemNewGame3x3.Checked = false;
			toolStripMenuItemNewGame4x4.Checked = false;
			toolStripMenuItemNewGame5x5.Checked = true;
			tabControl.SelectedTab = tabPageGame5x5;
			InitGamefield5x5();
		}

		private void buttonGame3Field11_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame3Field12_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame3Field13_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame3Field21_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame3Field22_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame3Field23_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame3Field31_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame3Field32_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame3Field33_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field11_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field12_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field13_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field14_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field21_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field22_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field23_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field24_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field31_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field32_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field33_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field34_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field41_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field42_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field43_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame4Field44_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field11_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field12_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field13_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field14_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field15_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field21_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field22_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field23_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field24_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field25_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field31_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field32_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field33_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field34_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field35_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field41_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field42_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field43_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field44_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field45_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field51_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field52_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field53_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field54_Click(object sender, EventArgs e)
		{

		}

		private void buttonGame5Field55_Click(object sender, EventArgs e)
		{

		}

		private void toolStripSplitButtonNewGame_Click(object sender, EventArgs e)
		{
			if (toolStripMenuItemNewGame3x3.Checked)
			{
				InitGamefield3x3();
			}
			else if (toolStripMenuItemNewGame4x4.Checked)
			{
				InitGamefield4x4();
			}
			else if (toolStripMenuItemNewGame5x5.Checked)
			{
				InitGamefield5x5();
			}
		}
	}
}