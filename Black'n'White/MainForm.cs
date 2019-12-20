using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MijoSoftware.AssemblyInformation;
using Office2007Rendering;

namespace BlackAndWhite
{
	/// <summary>
	/// BlackAndWhiteForm
	/// </summary>
	public partial class BlackAndWhiteForm : Form
	{
		/// <summary>
		/// True if the game is started
		/// </summary>
		private bool isGameStarted;

		/// <summary>
		/// Sum of the klicks
		/// </summary>
		private int sumKlicks;

		/// <summary>
		/// Sum of the ticks
		/// </summary>
		private int sumTicks;

		/// <summary>
		/// Number of the black fields
		/// </summary>
		private int numberBlacks;

		/// <summary>
		/// Number of the white fields
		/// </summary>
		private int numberWhites;

		/// <summary>
		/// Sum of the inverted fields
		/// </summary>
		private int sumInverts;

		/// <summary>
		/// Random number
		/// </summary>
		private readonly Random randomNumber = new Random();

		/// <summary>
		/// String builder
		/// </summary>
		private readonly StringBuilder stringBuilder = new StringBuilder();

		/// <summary>
		/// Constructor
		/// </summary>
		public BlackAndWhiteForm() => InitializeComponent();

		/// <summary>
		/// Load the main window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void MainForm_Load(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new Office2007Renderer();
			ClearStatusLabel(sender: null, e: EventArgs.Empty);
			tabControl.SelectedTab = tabPageGame3x3;
			InitGameboard();
			labelProduct.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = AssemblyInfo.AssemblyVersion;
			labelCompany.Text = AssemblyInfo.AssemblyCompany;
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}

		#region Statuslabel

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusLabel(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				toolStripStatusLabel.Text = control.AccessibleDescription;
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				toolStripStatusLabel.Text = toolStripSplitButton.AccessibleDescription;
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				toolStripStatusLabel.Text = toolStripButton.AccessibleDescription;
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				toolStripStatusLabel.Text = toolStripLabel.AccessibleDescription;
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				toolStripStatusLabel.Text = toolStripMenuItem.AccessibleDescription;
			}
		}

		/// <summary>
		/// Set a specific field text to the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusLabelField(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				stringBuilder.Clear().Append(value: button.AccessibleName).Append(value: ": ");
				switch (button.BackColor.Name)
				{
					case "Black": stringBuilder.Append(value: Localization.colorNameBlack); break;
					case "White": stringBuilder.Append(value: Localization.colorNameWhite); break;
					default: stringBuilder.Append(value: button.BackColor.Name); break;
				}
				toolStripStatusLabel.Text = stringBuilder.ToString();
			}
		}

		/// <summary>
		/// Clear the text of the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusLabel(object sender, EventArgs e) => toolStripStatusLabel.Text = string.Empty;

		#endregion

		/// <summary>
		/// Return a randomized background color of the field
		/// </summary>
		/// <returns>background color</returns>
		private Color RandomFieldColor()
		{
			switch (randomNumber.Next(minValue: 0, maxValue: 2))
			{
				case 0: return Color.Black;
				case 1: return Color.White;
				default: return SystemColors.Control;
			}
		}

		/// <summary>
		/// Invert the background colors of all fields
		/// </summary>
		/// <param name="fieldId">field</param>
		private void InvertFields(ushort[] fieldId)
		{
			foreach (ushort i in fieldId)
			{
				switch (i)
				{
					case 311: buttonGame3Field11.BackColor = InvertFieldColor(color: buttonGame3Field11.BackColor); break;
					case 312: buttonGame3Field12.BackColor = InvertFieldColor(color: buttonGame3Field12.BackColor); break;
					case 313: buttonGame3Field13.BackColor = InvertFieldColor(color: buttonGame3Field13.BackColor); break;
					case 321: buttonGame3Field21.BackColor = InvertFieldColor(color: buttonGame3Field21.BackColor); break;
					case 322: buttonGame3Field22.BackColor = InvertFieldColor(color: buttonGame3Field22.BackColor); break;
					case 323: buttonGame3Field23.BackColor = InvertFieldColor(color: buttonGame3Field23.BackColor); break;
					case 331: buttonGame3Field31.BackColor = InvertFieldColor(color: buttonGame3Field31.BackColor); break;
					case 332: buttonGame3Field32.BackColor = InvertFieldColor(color: buttonGame3Field32.BackColor); break;
					case 333: buttonGame3Field33.BackColor = InvertFieldColor(color: buttonGame3Field33.BackColor); break;
					case 411: buttonGame4Field11.BackColor = InvertFieldColor(color: buttonGame4Field11.BackColor); break;
					case 412: buttonGame4Field12.BackColor = InvertFieldColor(color: buttonGame4Field12.BackColor); break;
					case 413: buttonGame4Field13.BackColor = InvertFieldColor(color: buttonGame4Field13.BackColor); break;
					case 414: buttonGame4Field14.BackColor = InvertFieldColor(color: buttonGame4Field14.BackColor); break;
					case 421: buttonGame4Field21.BackColor = InvertFieldColor(color: buttonGame4Field21.BackColor); break;
					case 422: buttonGame4Field22.BackColor = InvertFieldColor(color: buttonGame4Field22.BackColor); break;
					case 423: buttonGame4Field23.BackColor = InvertFieldColor(color: buttonGame4Field23.BackColor); break;
					case 424: buttonGame4Field24.BackColor = InvertFieldColor(color: buttonGame4Field24.BackColor); break;
					case 431: buttonGame4Field31.BackColor = InvertFieldColor(color: buttonGame4Field31.BackColor); break;
					case 432: buttonGame4Field32.BackColor = InvertFieldColor(color: buttonGame4Field32.BackColor); break;
					case 433: buttonGame4Field33.BackColor = InvertFieldColor(color: buttonGame4Field33.BackColor); break;
					case 434: buttonGame4Field34.BackColor = InvertFieldColor(color: buttonGame4Field34.BackColor); break;
					case 441: buttonGame4Field41.BackColor = InvertFieldColor(color: buttonGame4Field41.BackColor); break;
					case 442: buttonGame4Field42.BackColor = InvertFieldColor(color: buttonGame4Field42.BackColor); break;
					case 443: buttonGame4Field43.BackColor = InvertFieldColor(color: buttonGame4Field43.BackColor); break;
					case 444: buttonGame4Field44.BackColor = InvertFieldColor(color: buttonGame4Field44.BackColor); break;
					case 511: buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor); break;
					case 512: buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor); break;
					case 513: buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor); break;
					case 514: buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor); break;
					case 515: buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor); break;
					case 521: buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor); break;
					case 522: buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor); break;
					case 523: buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor); break;
					case 524: buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor); break;
					case 525: buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor); break;
					case 531: buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor); break;
					case 532: buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor); break;
					case 533: buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor); break;
					case 534: buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor); break;
					case 535: buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor); break;
					case 541: buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor); break;
					case 542: buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor); break;
					case 543: buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor); break;
					case 544: buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor); break;
					case 545: buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor); break;
					case 551: buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor); break;
					case 552: buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor); break;
					case 553: buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor); break;
					case 554: buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor); break;
					case 555: buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor); break;
				}
			}
		}

		/*
		/// <summary>
		/// Invert the background color of a field
		/// </summary>
		/// <param name="field">field</param>
		private void InvertFieldColor(ushort field)
		{
			switch (field)
			{
				case 311: buttonGame3Field11.BackColor = InvertFieldColor(color: buttonGame3Field11.BackColor); break;
				case 312: buttonGame3Field12.BackColor = InvertFieldColor(color: buttonGame3Field12.BackColor); break;
				case 313: buttonGame3Field13.BackColor = InvertFieldColor(color: buttonGame3Field13.BackColor); break;
				case 321: buttonGame3Field21.BackColor = InvertFieldColor(color: buttonGame3Field21.BackColor); break;
				case 322: buttonGame3Field22.BackColor = InvertFieldColor(color: buttonGame3Field22.BackColor); break;
				case 323: buttonGame3Field23.BackColor = InvertFieldColor(color: buttonGame3Field23.BackColor); break;
				case 331: buttonGame3Field31.BackColor = InvertFieldColor(color: buttonGame3Field31.BackColor); break;
				case 332: buttonGame3Field32.BackColor = InvertFieldColor(color: buttonGame3Field32.BackColor); break;
				case 333: buttonGame3Field33.BackColor = InvertFieldColor(color: buttonGame3Field33.BackColor); break;
				case 411: buttonGame4Field11.BackColor = InvertFieldColor(color: buttonGame4Field11.BackColor); break;
				case 412: buttonGame4Field12.BackColor = InvertFieldColor(color: buttonGame4Field12.BackColor); break;
				case 413: buttonGame4Field13.BackColor = InvertFieldColor(color: buttonGame4Field13.BackColor); break;
				case 414: buttonGame4Field14.BackColor = InvertFieldColor(color: buttonGame4Field14.BackColor); break;
				case 421: buttonGame4Field21.BackColor = InvertFieldColor(color: buttonGame4Field21.BackColor); break;
				case 422: buttonGame4Field22.BackColor = InvertFieldColor(color: buttonGame4Field22.BackColor); break;
				case 423: buttonGame4Field23.BackColor = InvertFieldColor(color: buttonGame4Field23.BackColor); break;
				case 424: buttonGame4Field24.BackColor = InvertFieldColor(color: buttonGame4Field24.BackColor); break;
				case 431: buttonGame4Field31.BackColor = InvertFieldColor(color: buttonGame4Field31.BackColor); break;
				case 432: buttonGame4Field32.BackColor = InvertFieldColor(color: buttonGame4Field32.BackColor); break;
				case 433: buttonGame4Field33.BackColor = InvertFieldColor(color: buttonGame4Field33.BackColor); break;
				case 434: buttonGame4Field34.BackColor = InvertFieldColor(color: buttonGame4Field34.BackColor); break;
				case 441: buttonGame4Field41.BackColor = InvertFieldColor(color: buttonGame4Field41.BackColor); break;
				case 442: buttonGame4Field42.BackColor = InvertFieldColor(color: buttonGame4Field42.BackColor); break;
				case 443: buttonGame4Field43.BackColor = InvertFieldColor(color: buttonGame4Field43.BackColor); break;
				case 444: buttonGame4Field44.BackColor = InvertFieldColor(color: buttonGame4Field44.BackColor); break;
				case 511: buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor); break;
				case 512: buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor); break;
				case 513: buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor); break;
				case 514: buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor); break;
				case 515: buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor); break;
				case 521: buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor); break;
				case 522: buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor); break;
				case 523: buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor); break;
				case 524: buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor); break;
				case 525: buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor); break;
				case 531: buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor); break;
				case 532: buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor); break;
				case 533: buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor); break;
				case 534: buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor); break;
				case 535: buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor); break;
				case 541: buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor); break;
				case 542: buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor); break;
				case 543: buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor); break;
				case 544: buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor); break;
				case 545: buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor); break;
				case 551: buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor); break;
				case 552: buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor); break;
				case 553: buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor); break;
				case 554: buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor); break;
				case 555: buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor); break;
			}
		}
		*/

		/// <summary>
		/// Invert the background color of a field
		/// </summary>
		/// <param name="color">color</param>
		/// <returns>inverted color</returns>
		private Color InvertFieldColor(Color color)
		{
			if (!toolStripButtonPause.Enabled)
			{
				toolStripButtonPause.Enabled = true;
			}
			if (!timer.Enabled)
			{
				timer.Enabled = true;
			}
			sumInverts++;
			switch (color.Name)
			{
				case "Black": return Color.White;
				case "White": return Color.Black;
				default: return color;
			}
		}

		/// <summary>
		/// Init the gameboard
		/// </summary>
		private void InitGameboard()
		{
			if (toolStripMenuItemNewGame3x3.Checked)
			{
				InitGameboard3x3();
			}
			else if (toolStripMenuItemNewGame4x4.Checked)
			{
				InitGameboard4x4();
			}
			else if (toolStripMenuItemNewGame5x5.Checked)
			{
				InitGameboard5x5();
			}
		}

		/// <summary>
		/// Init the gameboard with the size 3x3
		/// </summary>
		private void InitGameboard3x3()
		{
			timer.Enabled = false;
			toolStripButtonPause.Enabled = false;
			toolStripLabelStatistic.Text = Localization.statisticDefault;
			sumTicks = 0;
			sumKlicks = 0;
			sumInverts = 0;
			tabPageGame3x3.Parent = tabControl;
			tabPageGame4x4.Parent = null;
			tabPageGame5x5.Parent = null;
			foreach (Control button in tableLayoutPanelGame3x3.Controls)
			{
				button.BackColor = RandomFieldColor();
			}
		}

		/// <summary>
		/// Init the gameboard with the size 4x4
		/// </summary>
		private void InitGameboard4x4()
		{
			timer.Enabled = false;
			toolStripButtonPause.Enabled = false;
			toolStripLabelStatistic.Text = Localization.statisticDefault;
			sumTicks = 0;
			sumKlicks = 0;
			sumInverts = 0;
			tabPageGame3x3.Parent = null;
			tabPageGame4x4.Parent = tabControl;
			tabPageGame5x5.Parent = null;
			foreach (Control button in tableLayoutPanelGame4x4.Controls)
			{
				button.BackColor = RandomFieldColor();
			}
		}

		/// <summary>
		/// Init the gameboard with the size 5x5
		/// </summary>
		private void InitGameboard5x5()
		{
			timer.Enabled = false;
			toolStripButtonPause.Enabled = false;
			toolStripLabelStatistic.Text = Localization.statisticDefault;
			sumTicks = 0;
			sumKlicks = 0;
			sumInverts = 0;
			tabPageGame3x3.Parent = null;
			tabPageGame4x4.Parent = null;
			tabPageGame5x5.Parent = tabControl;
			foreach (Control button in tableLayoutPanelGame5x5.Controls)
			{
				button.BackColor = RandomFieldColor();
			}
		}

		/// <summary>
		/// Count the colors of the gameboard 
		/// </summary>
		private void CountColorsInGameboard()
		{
			TableLayoutPanel tableLayoutPanel = null;
			if (toolStripMenuItemNewGame3x3.Checked)
			{
				tableLayoutPanel = tableLayoutPanelGame3x3;
			}
			else if (toolStripMenuItemNewGame4x4.Checked)
			{
				tableLayoutPanel = tableLayoutPanelGame4x4;
			}
			else if (toolStripMenuItemNewGame5x5.Checked)
			{
				tableLayoutPanel = tableLayoutPanelGame5x5;
			}

			numberBlacks = 0;
			numberWhites = 0;
			foreach (Control button in tableLayoutPanel.Controls)
			{
				if (button.BackColor == Color.Black)
				{
					numberBlacks++;
				}
				else if (button.BackColor == Color.White)
				{
					numberWhites++;
				}
			}
		}

		/// <summary>
		/// Check if it is the same color in the gameboard
		/// </summary>
		/// <returns>true if same</returns>
		private bool IsSameColorsInGameboard()
		{
			bool isSameColor = false;
			int
				gameSize = 0,
				numbUndefinedColor = 0,
				numbWhiteColor = 0,
				numbBlackColor = 0;
			TableLayoutPanel tableLayoutPanel = null;
			if (toolStripMenuItemNewGame3x3.Checked)
			{
				gameSize = 3;
				tableLayoutPanel = tableLayoutPanelGame3x3;
			}
			else if (toolStripMenuItemNewGame4x4.Checked)
			{
				gameSize = 4;
				tableLayoutPanel = tableLayoutPanelGame4x4;
			}
			else if (toolStripMenuItemNewGame5x5.Checked)
			{
				gameSize = 5;
				tableLayoutPanel = tableLayoutPanelGame5x5;
			}

			foreach (Control button in tableLayoutPanel.Controls)
			{
				if (button.BackColor == Color.White)
				{
					numbWhiteColor++;
				}
				else if (button.BackColor == Color.Black)
				{
					numbBlackColor++;
				}
				else
				{
					numbUndefinedColor++;
				}
			}
			if (numbWhiteColor == Math.Pow(x: gameSize, y: 2) || numbBlackColor == Math.Pow(x: gameSize, y: 2))
			{
				isSameColor = true;
			}
			return isSameColor;
		}

		/// <summary>
		/// Check for win in the gameboard
		/// </summary>
		private void CheckForWinInGameboard()
		{
			if (!isGameStarted)
			{
				isGameStarted = true;
				toolStripMenuItemGameOptions.Enabled = false;
			}
			if (IsSameColorsInGameboard())
			{
				FinishGame();
			}
		}

		/// <summary>
		/// Count the colors and check for win in the gameboard
		/// </summary>
		private void CountColorsAndCheckForWinInGameboard()
		{
			CountColorsInGameboard();
			CheckForWinInGameboard();
		}

		/// <summary>
		/// Finish the game
		/// </summary>
		private void FinishGame()
		{
			timer.Stop();
			timer.Enabled = false;
			string message = $"Du hast mit {sumKlicks} Klicks in {sumTicks} Ticks gewonnen.";
			MessageBox.Show(
				text: message,
				caption: Localization.won,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information,
				defaultButton: MessageBoxDefaultButton.Button1,
				options: MessageBoxOptions.DefaultDesktopOnly);
			isGameStarted = false;
			toolStripMenuItemGameOptions.Enabled = true;
			sumTicks = 0;
			toolStripLabelStatistic.Text = Localization.statisticDefault;
			InitGameboard();
		}

		/// <summary>
		/// Init the gameboard 3x3 while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemNewGame3x3_Click(object sender, EventArgs e)
		{
			toolStripMenuItemNewGame3x3.Checked = true;
			toolStripMenuItemNewGame4x4.Checked = false;
			toolStripMenuItemNewGame5x5.Checked = false;
			tabControl.SelectedTab = tabPageGame3x3;
			InitGameboard3x3();
		}

		/// <summary>
		/// Init the gameboard 4x4 while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemNewGame4x4_Click(object sender, EventArgs e)
		{
			toolStripMenuItemNewGame3x3.Checked = false;
			toolStripMenuItemNewGame4x4.Checked = true;
			toolStripMenuItemNewGame5x5.Checked = false;
			tabControl.SelectedTab = tabPageGame4x4;
			InitGameboard4x4();
		}

		/// <summary>
		/// Init the gameboard 4x4 while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemNewGame5x5_Click(object sender, EventArgs e)
		{
			toolStripMenuItemNewGame3x3.Checked = false;
			toolStripMenuItemNewGame4x4.Checked = false;
			toolStripMenuItemNewGame5x5.Checked = true;
			tabControl.SelectedTab = tabPageGame5x5;
			InitGameboard5x5();
		}

		/// <summary>
		/// Active the linear field inverting while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemOptionLinear_Click(object sender, EventArgs e)
		{
			toolStripMenuItemOptionLinear.Checked = true;
			toolStripMenuItemOptionDiagonal.Checked = false;
			toolStripMenuItemOptionCombined.Checked = false;
		}

		/// <summary>
		/// Active the diagonal field inverting while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemOptionDiagonal_Click(object sender, EventArgs e)
		{
			toolStripMenuItemOptionLinear.Checked = false;
			toolStripMenuItemOptionDiagonal.Checked = true;
			toolStripMenuItemOptionCombined.Checked = false;
		}

		/// <summary>
		/// Active the combined field inverting while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemOptionCombined_Click(object sender, EventArgs e)
		{
			toolStripMenuItemOptionLinear.Checked = false;
			toolStripMenuItemOptionDiagonal.Checked = false;
			toolStripMenuItemOptionCombined.Checked = true;
		}

		private void InvertNeighbourFields(object sender, EventArgs e, ushort[] linearNeightbourFields, ushort[] diagonalNeightbourFields, ushort[] centeredField)
		{
			sumKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(fieldId: linearNeightbourFields);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(fieldId: diagonalNeightbourFields);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				ushort[] combinedNeightbourFields = linearNeightbourFields.Union(second: diagonalNeightbourFields).ToArray();
				InvertFields(fieldId: combinedNeightbourFields);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(fieldId: centeredField);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard();
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x1 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field11_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 312, 321 },
				diagonalNeightbourFields: new ushort[] { 322 },
				centeredField: new ushort[] { 311 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x2 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field12_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 311, 313, 322 },
				diagonalNeightbourFields: new ushort[] { 321, 323 },
				centeredField: new ushort[] { 312 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x3 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field13_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 312, 323 },
				diagonalNeightbourFields: new ushort[] { 322 },
				centeredField: new ushort[] { 313 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x1 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field21_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 311, 322, 331 },
				diagonalNeightbourFields: new ushort[] { 312, 332 },
				centeredField: new ushort[] { 321 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x2 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field22_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 312, 321, 323, 332 },
				diagonalNeightbourFields: new ushort[] { 311, 313, 331, 333 },
				centeredField: new ushort[] { 322 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x3 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field23_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 313, 322, 333 },
				diagonalNeightbourFields: new ushort[] { 312, 332 },
				centeredField: new ushort[] { 323 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x1 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field31_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 321, 332 },
				diagonalNeightbourFields: new ushort[] { 322 },
				centeredField: new ushort[] { 331 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x2 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field32_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 322, 331, 333 },
				diagonalNeightbourFields: new ushort[] { 321, 323 },
				centeredField: new ushort[] { 332 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x3 in the game 3x3
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame3Field33_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 323, 332 },
				diagonalNeightbourFields: new ushort[] { 322 },
				centeredField: new ushort[] { 333 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x1 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field11_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 412, 421 },
				diagonalNeightbourFields: new ushort[] { 422 },
				centeredField: new ushort[] { 411 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x2 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field12_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 411, 413, 422 },
				diagonalNeightbourFields: new ushort[] { 421, 423 },
				centeredField: new ushort[] { 412 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x3 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field13_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 412, 414, 423 },
				diagonalNeightbourFields: new ushort[] { 422, 424 },
				centeredField: new ushort[] { 413 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x4 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field14_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 413, 424 },
				diagonalNeightbourFields: new ushort[] { 423 },
				centeredField: new ushort[] { 414 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x1 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field21_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 411, 422, 431 },
				diagonalNeightbourFields: new ushort[] { 412, 432 },
				centeredField: new ushort[] { 421 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x2 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field22_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 412, 421, 423, 432 },
				diagonalNeightbourFields: new ushort[] { 411, 413, 431, 433 },
				centeredField: new ushort[] { 422 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x3 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field23_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 413, 422, 424, 433 },
				diagonalNeightbourFields: new ushort[] { 412, 414, 432, 434 },
				centeredField: new ushort[] { 423 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x4 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field24_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 414, 423, 434 },
				diagonalNeightbourFields: new ushort[] { 413, 433 },
				centeredField: new ushort[] { 424 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x1 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field31_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 421, 432, 441 },
				diagonalNeightbourFields: new ushort[] { 422, 442 },
				centeredField: new ushort[] { 431 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x2 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field32_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 422, 431, 433, 442 },
				diagonalNeightbourFields: new ushort[] { 421, 423, 441, 443 },
				centeredField: new ushort[] { 432 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x3 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field33_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 423, 432, 434, 443 },
				diagonalNeightbourFields: new ushort[] { 422, 424, 442, 444 },
				centeredField: new ushort[] { 433 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x4 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field34_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 424, 433, 444 },
				diagonalNeightbourFields: new ushort[] { 423, 443 },
				centeredField: new ushort[] { 434 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x1 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field41_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 431, 442 },
				diagonalNeightbourFields: new ushort[] { 432 },
				centeredField: new ushort[] { 441 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x2 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field42_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 432, 441, 443 },
				diagonalNeightbourFields: new ushort[] { 431, 433 },
				centeredField: new ushort[] { 442 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x3 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field43_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 433, 442, 444 },
				diagonalNeightbourFields: new ushort[] { 432, 434 },
				centeredField: new ushort[] { 443 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x4 in the game 4x4
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame4Field44_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 434, 443 },
				diagonalNeightbourFields: new ushort[] { 433 },
				centeredField: new ushort[] { 444 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x1 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field11_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 512, 521 },
				diagonalNeightbourFields: new ushort[] { 522 },
				centeredField: new ushort[] { 511 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x2 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field12_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 511, 513, 522 },
				diagonalNeightbourFields: new ushort[] { 521, 523 },
				centeredField: new ushort[] { 512 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x3 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field13_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 512, 514, 523 },
				diagonalNeightbourFields: new ushort[] { 522, 524 },
				centeredField: new ushort[] { 513 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x4 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field14_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 513, 515, 524 },
				diagonalNeightbourFields: new ushort[] { 523, 525 },
				centeredField: new ushort[] { 514 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 1x5 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field15_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 514, 525 },
				diagonalNeightbourFields: new ushort[] { 524 },
				centeredField: new ushort[] { 515 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x1 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field21_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 511, 522, 531 },
				diagonalNeightbourFields: new ushort[] { 512, 532 },
				centeredField: new ushort[] { 521 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x2 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field22_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 512, 521, 523, 532 },
				diagonalNeightbourFields: new ushort[] { 511, 513, 531, 533 },
				centeredField: new ushort[] { 522 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x3 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field23_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 513, 522, 524, 533 },
				diagonalNeightbourFields: new ushort[] { 512, 514, 532, 534 },
				centeredField: new ushort[] { 523 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x4 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field24_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 514, 523, 525, 534 },
				diagonalNeightbourFields: new ushort[] { 513, 515, 533, 535 },
				centeredField: new ushort[] { 524 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 2x5 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field25_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 515, 524, 535 },
				diagonalNeightbourFields: new ushort[] { 514, 534 },
				centeredField: new ushort[] { 525 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x1 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field31_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 521, 532, 541 },
				diagonalNeightbourFields: new ushort[] { 522, 542 },
				centeredField: new ushort[] { 531 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x2 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field32_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 522, 531, 533, 542 },
				diagonalNeightbourFields: new ushort[] { 521, 523, 541, 543 },
				centeredField: new ushort[] { 532 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x3 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field33_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 523, 532, 534, 543 },
				diagonalNeightbourFields: new ushort[] { 522, 524, 542, 544 },
				centeredField: new ushort[] { 533 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x4 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field34_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 524, 533, 535, 544 },
				diagonalNeightbourFields: new ushort[] { 523, 525, 543, 545 },
				centeredField: new ushort[] { 534 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 3x5 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field35_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 525, 534, 545 },
				diagonalNeightbourFields: new ushort[] { 524, 544 },
				centeredField: new ushort[] { 535 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x1 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field41_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 531, 542, 551 },
				diagonalNeightbourFields: new ushort[] { 532, 552 },
				centeredField: new ushort[] { 541 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x2 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field42_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 532, 541, 543, 552 },
				diagonalNeightbourFields: new ushort[] { 531, 533, 551, 553 },
				centeredField: new ushort[] { 542 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x3 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field43_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 533, 542, 544, 553 },
				diagonalNeightbourFields: new ushort[] { 532, 534, 552, 554 },
				centeredField: new ushort[] { 543 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x4 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field44_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 534, 543, 545, 554 },
				diagonalNeightbourFields: new ushort[] { 533, 535, 553, 555 },
				centeredField: new ushort[] { 544 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 4x5 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field45_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 535, 544, 555 },
				diagonalNeightbourFields: new ushort[] { 534, 554 },
				centeredField: new ushort[] { 545 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 5x1 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field51_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 541, 552 },
				diagonalNeightbourFields: new ushort[] { 542 },
				centeredField: new ushort[] { 551 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 5x2 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field52_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 542, 551, 553 },
				diagonalNeightbourFields: new ushort[] { 541, 543 },
				centeredField: new ushort[] { 552 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 5x3 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field53_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 543, 552, 554 },
				diagonalNeightbourFields: new ushort[] { 542, 544 },
				centeredField: new ushort[] { 553 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 5x4 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field54_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 544, 553, 555 },
				diagonalNeightbourFields: new ushort[] { 543, 545 },
				centeredField: new ushort[] { 554 });
		}

		/// <summary>
		/// Invert the neighbour fields of the field 5x5 in the game 5x5
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void ButtonGame5Field55_Click(object sender, EventArgs e)
		{
			InvertNeighbourFields(sender: sender, e: e,
				linearNeightbourFields: new ushort[] { 545, 554 },
				diagonalNeightbourFields: new ushort[] { 544 },
				centeredField: new ushort[] { 555 });
		}

		/// <summary>
		/// Begin a new game while the ToolStripSplitButton
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripSplitButtonNewGame_Click(object sender, EventArgs e)
		{
			isGameStarted = false;
			toolStripMenuItemGameOptions.Enabled = true;
			InitGameboard();
		}

		/// <summary>
		/// Pause a new game while the ToolStripButton
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripButtonPause_Click(object sender, EventArgs e)
		{
			timer.Enabled = false;
			MessageBox.Show(
				text: Localization.gamePaused,
				caption: Localization.paused,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information,
				defaultButton: MessageBoxDefaultButton.Button1,
				options: MessageBoxOptions.DefaultDesktopOnly);
			timer.Enabled = true;
		}

		/// <summary>
		/// Output the statistics message on every tick
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void Timer_Tick(object sender, EventArgs e)
		{
			sumTicks++;
			toolStripLabelStatistic.Text = $"Klicks: {sumKlicks} - Ticks: {sumTicks} - Blacks: {numberBlacks} - Whites: {numberWhites} - Inverts: {sumInverts}";
		}
	}
}