using System.ComponentModel;
using System.Globalization;
using System.Text;
using MijoSoftware.AssemblyInformation;
using Office2007Rendering;

namespace BlackAndWhite
{
	/// <summary>
	/// BlackAndWhiteForm
	/// </summary>
	public partial class BlackAndWhiteForm : Form
	{
		#region Variables

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
		private readonly Random randomNumber = new();

		/// <summary>
		/// String builder
		/// </summary>
		private readonly StringBuilder stringBuilder = new();

		/// <summary>
		/// Culture info
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		#endregion

		#region Helpers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="res"></param>
		/// <param name="control"></param>
		private static void ApplyResourceToControl(ComponentResourceManager res, Control control)
		{
			foreach (Control c in control.Controls)
			{
				ApplyResourceToControl(res: res, control: c);
			}
			string text = res.GetString(name: $"{control.Name}.Text", culture: culture);
			control.Text = text ?? control.Text;
		}

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			toolStripStatusLabelInformation.Enabled = !string.IsNullOrEmpty(value: text);
			toolStripStatusLabelInformation.Text = text;
		}

		/// <summary>
		/// Return a randomized background color of the field
		/// </summary>
		/// <returns>background color</returns>
		private Color RandomFieldColor()
		{
			return randomNumber.Next(minValue: 0, maxValue: 2) switch
			{
				0 => Color.Black,
				1 => Color.White,
				_ => SystemColors.Control,
			};
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
			return color.Name switch
			{
				"Black" => Color.White,
				"White" => Color.Black,
				_ => color,
			};
		}

		/// <summary>
		/// Init the game board
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
		/// Init the game board with the size 3x3
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
		/// Init the game board with the size 4x4
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
		/// Init the game board with the size 5x5
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
		/// Count the colors of the game board
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
		/// Check if it is the same color in the game board
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
		/// Check for win in the game board
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
		/// Count the colors and check for win in the game board
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

		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		public BlackAndWhiteForm() => InitializeComponent();

		#endregion

		#region Load event handler

		/// <summary>
		/// Load the main window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
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

		#endregion

		#region Statuslabel

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusLabel(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox textBox: SetStatusbarText(text: textBox.AccessibleDescription); break;
				case Button button: SetStatusbarText(text: button.AccessibleDescription); break;
				case RadioButton radioButton: SetStatusbarText(text: radioButton.AccessibleDescription); break;
				case CheckBox checkBox: SetStatusbarText(text: checkBox.AccessibleDescription); break;
				case DateTimePicker dateTimePicker: SetStatusbarText(text: dateTimePicker.AccessibleDescription); break;
				case Label label: SetStatusbarText(text: label.AccessibleDescription); break;
				case PictureBox pictureBox: SetStatusbarText(text: pictureBox.AccessibleDescription); break;
				case CheckedListBox checkedListBox: SetStatusbarText(text: checkedListBox.AccessibleDescription); break;
				case ComboBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case DataGridView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case GroupBox group: SetStatusbarText(text: group.AccessibleDescription); break;
				case ListBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case ListView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case MaskedTextBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case NumericUpDown numericUpDown: SetStatusbarText(text: numericUpDown.AccessibleDescription); break;
				case MonthCalendar monthCalendar: SetStatusbarText(text: monthCalendar.AccessibleDescription); break;
				case PropertyGrid propertyGrid: SetStatusbarText(text: propertyGrid.AccessibleDescription); break;
				case RichTextBox richTextBox: SetStatusbarText(text: richTextBox.AccessibleDescription); break;
				case ScrollBar scrollBar: SetStatusbarText(text: scrollBar.AccessibleDescription); break;
				case TrackBar trackBar: SetStatusbarText(text: trackBar.AccessibleDescription); break;
				case WebBrowser webBrowser: SetStatusbarText(text: webBrowser.AccessibleDescription); break;
				case DomainUpDown domainUpDown: SetStatusbarText(text: domainUpDown.AccessibleDescription); break;
				case ToolStripButton toolStripButton: SetStatusbarText(text: toolStripButton.AccessibleDescription); break;
				case ToolStripMenuItem toolStripMenuItem: SetStatusbarText(text: toolStripMenuItem.AccessibleDescription); break;
				case ToolStripLabel toolStripLabel: SetStatusbarText(text: toolStripLabel.AccessibleDescription); break;
				case ToolStripComboBox toolStripComboBox: SetStatusbarText(text: toolStripComboBox.AccessibleDescription); break;
				case ToolStripDropDown toolStripDropDown: SetStatusbarText(text: toolStripDropDown.AccessibleDescription); break;
				case ToolStripDropDownButton toolStripDropDownButton: SetStatusbarText(text: toolStripDropDownButton.AccessibleDescription); break;
				case ToolStripDropDownItem toolStripDropDownItem: SetStatusbarText(text: toolStripDropDownItem.AccessibleDescription); break;
				case ToolStripProgressBar progressBar: SetStatusbarText(text: progressBar.AccessibleDescription); break;
				case ToolStripSeparator toolStripSeparator: SetStatusbarText(text: toolStripSeparator.AccessibleDescription); break;
				case ToolStripTextBox toolStripTextBox: SetStatusbarText(text: toolStripTextBox.AccessibleDescription); break;
				default: return;
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
				toolStripStatusLabelInformation.Text = stringBuilder.ToString();
			}
		}

		/// <summary>
		/// Clear the text of the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusLabel(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		#endregion

		#region Click event handlers

		/// <summary>
		/// Init the game board 3x3 while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemNewGame3x3_Click(object sender, EventArgs e)
		{
			toolStripMenuItemNewGame3x3.Checked = true;
			toolStripMenuItemNewGame4x4.Checked = false;
			toolStripMenuItemNewGame5x5.Checked = false;
			tabControl.SelectedTab = tabPageGame3x3;
			InitGameboard3x3();
		}

		/// <summary>
		/// Init the game board 4x4 while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemNewGame4x4_Click(object sender, EventArgs e)
		{
			toolStripMenuItemNewGame3x3.Checked = false;
			toolStripMenuItemNewGame4x4.Checked = true;
			toolStripMenuItemNewGame5x5.Checked = false;
			tabControl.SelectedTab = tabPageGame4x4;
			InitGameboard4x4();
		}

		/// <summary>
		/// Init the game board 4x4 while clicking the ToolStripMenuItem
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
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
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
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
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
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
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemOptionCombined_Click(object sender, EventArgs e)
		{
			toolStripMenuItemOptionLinear.Checked = false;
			toolStripMenuItemOptionDiagonal.Checked = false;
			toolStripMenuItemOptionCombined.Checked = true;
		}

		/// <summary>
		/// Invert the neighbour fields
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <param name="linearNeightbourFields">array with ids of the linear neighbour fields</param>
		/// <param name="diagonalNeightbourFields">array with ids of the diagonal neighbour fields</param>
		/// <param name="centeredField">array with id of the own field</param>
		/// <remarks>The parameter <paramref name="e"/> ist not needed, but must be indicated.</remarks>
		private void InvertNeighbourFields(
			object sender,
			EventArgs e,
			ushort[] linearNeightbourFields,
			ushort[] diagonalNeightbourFields,
			ushort[] centeredField)
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
		/// Invert the neighbour fields while clicking on the button
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> ist not needed, but must be indicated.</remarks>
		private void ButtonField_Click(object sender, EventArgs e)
		{
			var control = sender as Control;
			ushort[] linearNeightbourFields = { 0 };
			ushort[] diagonalNeightbourFields = { 0 };
			ushort[] centeredField = { 0 };
			switch (control.Tag.ToString())
			{
				case "311":
					linearNeightbourFields = new ushort[] { 312, 321 };
					diagonalNeightbourFields = new ushort[] { 322 };
					centeredField = new ushort[] { 311 };
					break;
				case "312":
					linearNeightbourFields = new ushort[] { 311, 313, 322 };
					diagonalNeightbourFields = new ushort[] { 321, 323 };
					centeredField = new ushort[] { 312 };
					break;
				case "313":
					linearNeightbourFields = new ushort[] { 312, 323 };
					diagonalNeightbourFields = new ushort[] { 322 };
					centeredField = new ushort[] { 313 };
					break;
				case "321":
					linearNeightbourFields = new ushort[] { 311, 322, 331 };
					diagonalNeightbourFields = new ushort[] { 312, 332 };
					centeredField = new ushort[] { 321 };
					break;
				case "322":
					linearNeightbourFields = new ushort[] { 312, 321, 323, 332 };
					diagonalNeightbourFields = new ushort[] { 311, 313, 331, 333 };
					centeredField = new ushort[] { 322 };
					break;
				case "323":
					linearNeightbourFields = new ushort[] { 313, 322, 333 };
					diagonalNeightbourFields = new ushort[] { 312, 332 };
					centeredField = new ushort[] { 323 };
					break;
				case "331":
					linearNeightbourFields = new ushort[] { 321, 332 };
					diagonalNeightbourFields = new ushort[] { 322 };
					centeredField = new ushort[] { 331 };
					break;
				case "332":
					linearNeightbourFields = new ushort[] { 322, 331, 333 };
					diagonalNeightbourFields = new ushort[] { 321, 323 };
					centeredField = new ushort[] { 332 };
					break;
				case "333":
					linearNeightbourFields = new ushort[] { 323, 332 };
					diagonalNeightbourFields = new ushort[] { 322 };
					centeredField = new ushort[] { 333 };
					break;
				case "411":
					linearNeightbourFields = new ushort[] { 412, 421 };
					diagonalNeightbourFields = new ushort[] { 422 };
					centeredField = new ushort[] { 411 };
					break;
				case "412":
					linearNeightbourFields = new ushort[] { 411, 413, 422 };
					diagonalNeightbourFields = new ushort[] { 421, 423 };
					centeredField = new ushort[] { 412 };
					break;
				case "413":
					linearNeightbourFields = new ushort[] { 412, 414, 423 };
					diagonalNeightbourFields = new ushort[] { 422, 424 };
					centeredField = new ushort[] { 413 };
					break;
				case "414":
					linearNeightbourFields = new ushort[] { 413, 424 };
					diagonalNeightbourFields = new ushort[] { 423 };
					centeredField = new ushort[] { 414 };
					break;
				case "421":
					linearNeightbourFields = new ushort[] { 411, 422, 431 };
					diagonalNeightbourFields = new ushort[] { 412, 432 };
					centeredField = new ushort[] { 421 };
					break;
				case "422":
					linearNeightbourFields = new ushort[] { 412, 421, 423, 432 };
					diagonalNeightbourFields = new ushort[] { 411, 413, 431, 433 };
					centeredField = new ushort[] { 422 };
					break;
				case "423":
					linearNeightbourFields = new ushort[] { 413, 422, 424, 433 };
					diagonalNeightbourFields = new ushort[] { 412, 414, 432, 434 };
					centeredField = new ushort[] { 423 };
					break;
				case "424":
					linearNeightbourFields = new ushort[] { 414, 423, 434 };
					diagonalNeightbourFields = new ushort[] { 413, 433 };
					centeredField = new ushort[] { 424 };
					break;
				case "431":
					linearNeightbourFields = new ushort[] { 421, 432, 441 };
					diagonalNeightbourFields = new ushort[] { 422, 442 };
					centeredField = new ushort[] { 431 };
					break;
				case "432":
					linearNeightbourFields = new ushort[] { 422, 431, 433, 442 };
					diagonalNeightbourFields = new ushort[] { 421, 423, 441, 443 };
					centeredField = new ushort[] { 432 };
					break;
				case "433":
					linearNeightbourFields = new ushort[] { 423, 432, 434, 443 };
					diagonalNeightbourFields = new ushort[] { 422, 424, 442, 444 };
					centeredField = new ushort[] { 433 };
					break;
				case "434":
					linearNeightbourFields = new ushort[] { 424, 433, 444 };
					diagonalNeightbourFields = new ushort[] { 423, 443 };
					centeredField = new ushort[] { 434 };
					break;
				case "441":
					linearNeightbourFields = new ushort[] { 431, 442 };
					diagonalNeightbourFields = new ushort[] { 432 };
					centeredField = new ushort[] { 441 };
					break;
				case "442":
					linearNeightbourFields = new ushort[] { 432, 441, 443 };
					diagonalNeightbourFields = new ushort[] { 431, 433 };
					centeredField = new ushort[] { 442 };
					break;
				case "443":
					linearNeightbourFields = new ushort[] { 433, 442, 444 };
					diagonalNeightbourFields = new ushort[] { 432, 434 };
					centeredField = new ushort[] { 443 };
					break;
				case "444":
					linearNeightbourFields = new ushort[] { 434, 443 };
					diagonalNeightbourFields = new ushort[] { 433 };
					centeredField = new ushort[] { 444 };
					break;
				case "511":
					linearNeightbourFields = new ushort[] { 512, 521 };
					diagonalNeightbourFields = new ushort[] { 522 };
					centeredField = new ushort[] { 511 };
					break;
				case "512":
					linearNeightbourFields = new ushort[] { 511, 513, 522 };
					diagonalNeightbourFields = new ushort[] { 521, 523 };
					centeredField = new ushort[] { 512 };
					break;
				case "513":
					linearNeightbourFields = new ushort[] { 512, 514, 523 };
					diagonalNeightbourFields = new ushort[] { 522, 524 };
					centeredField = new ushort[] { 513 };
					break;
				case "514":
					linearNeightbourFields = new ushort[] { 513, 515, 524 };
					diagonalNeightbourFields = new ushort[] { 523, 525 };
					centeredField = new ushort[] { 514 };
					break;
				case "515":
					linearNeightbourFields = new ushort[] { 514, 525 };
					diagonalNeightbourFields = new ushort[] { 524 };
					centeredField = new ushort[] { 515 };
					break;
				case "521":
					linearNeightbourFields = new ushort[] { 511, 522, 531 };
					diagonalNeightbourFields = new ushort[] { 512, 532 };
					centeredField = new ushort[] { 521 };
					break;
				case "522":
					linearNeightbourFields = new ushort[] { 512, 521, 523, 532 };
					diagonalNeightbourFields = new ushort[] { 511, 513, 531, 533 };
					centeredField = new ushort[] { 522 };
					break;
				case "523":
					linearNeightbourFields = new ushort[] { 513, 522, 524, 533 };
					diagonalNeightbourFields = new ushort[] { 512, 514, 532, 534 };
					centeredField = new ushort[] { 523 };
					break;
				case "524":
					linearNeightbourFields = new ushort[] { 514, 523, 525, 534 };
					diagonalNeightbourFields = new ushort[] { 513, 515, 533, 535 };
					centeredField = new ushort[] { 524 };
					break;
				case "525":
					linearNeightbourFields = new ushort[] { 515, 524, 535 };
					diagonalNeightbourFields = new ushort[] { 514, 534 };
					centeredField = new ushort[] { 525 };
					break;
				case "531":
					linearNeightbourFields = new ushort[] { 521, 532, 541 };
					diagonalNeightbourFields = new ushort[] { 522, 542 };
					centeredField = new ushort[] { 531 };
					break;
				case "532":
					linearNeightbourFields = new ushort[] { 522, 531, 533, 542 };
					diagonalNeightbourFields = new ushort[] { 521, 523, 541, 543 };
					centeredField = new ushort[] { 532 };
					break;
				case "533":
					linearNeightbourFields = new ushort[] { 523, 532, 534, 543 };
					diagonalNeightbourFields = new ushort[] { 522, 524, 542, 544 };
					centeredField = new ushort[] { 533 };
					break;
				case "534":
					linearNeightbourFields = new ushort[] { 524, 533, 535, 544 };
					diagonalNeightbourFields = new ushort[] { 523, 525, 543, 545 };
					centeredField = new ushort[] { 534 };
					break;
				case "535":
					linearNeightbourFields = new ushort[] { 525, 534, 545 };
					diagonalNeightbourFields = new ushort[] { 524, 544 };
					centeredField = new ushort[] { 535 };
					break;
				case "541":
					linearNeightbourFields = new ushort[] { 531, 542, 551 };
					diagonalNeightbourFields = new ushort[] { 532, 552 };
					centeredField = new ushort[] { 541 };
					break;
				case "542":
					linearNeightbourFields = new ushort[] { 532, 541, 543, 552 };
					diagonalNeightbourFields = new ushort[] { 531, 533, 551, 553 };
					centeredField = new ushort[] { 542 };
					break;
				case "543":
					linearNeightbourFields = new ushort[] { 533, 542, 544, 553 };
					diagonalNeightbourFields = new ushort[] { 532, 534, 552, 554 };
					centeredField = new ushort[] { 543 };
					break;
				case "544":
					linearNeightbourFields = new ushort[] { 534, 543, 545, 554 };
					diagonalNeightbourFields = new ushort[] { 533, 535, 553, 555 };
					centeredField = new ushort[] { 544 };
					break;
				case "545":
					linearNeightbourFields = new ushort[] { 535, 544, 555 };
					diagonalNeightbourFields = new ushort[] { 534, 554 };
					centeredField = new ushort[] { 545 };
					break;
				case "551":
					linearNeightbourFields = new ushort[] { 541, 552 };
					diagonalNeightbourFields = new ushort[] { 542 };
					centeredField = new ushort[] { 551 };
					break;
				case "552":
					linearNeightbourFields = new ushort[] { 542, 551, 553 };
					diagonalNeightbourFields = new ushort[] { 541, 543 };
					centeredField = new ushort[] { 552 };
					break;
				case "553":
					linearNeightbourFields = new ushort[] { 543, 552, 554 };
					diagonalNeightbourFields = new ushort[] { 542, 544 };
					centeredField = new ushort[] { 553 };
					break;
				case "554":
					linearNeightbourFields = new ushort[] { 544, 553, 555 };
					diagonalNeightbourFields = new ushort[] { 543, 545 };
					centeredField = new ushort[] { 554 };
					break;
				case "555":
					linearNeightbourFields = new ushort[] { 545, 554 };
					diagonalNeightbourFields = new ushort[] { 544 };
					centeredField = new ushort[] { 555 };
					break;
			}
			InvertNeighbourFields(
				sender: sender,
				e: e,
				linearNeightbourFields: linearNeightbourFields,
				diagonalNeightbourFields: diagonalNeightbourFields,
				centeredField: centeredField);
		}

		/// <summary>
		/// Begin a new game while the ToolStripSplitButton
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
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
		/// <remarks>The parameter <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
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
		/// 
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripSplitButtonLanguage_ButtonClick(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(name: "en");
			ComponentResourceManager resources = new(t: GetType());
			ApplyResourceToControl(res: resources, control: this);
		}

		#endregion

		#region Tick event handlers

		/// <summary>
		/// Output the statistics message on every tick
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void Timer_Tick(object sender, EventArgs e)
		{
			sumTicks++;
			toolStripLabelStatistic.Text = $"Klicks: {sumKlicks} - Ticks: {sumTicks} - Blacks: {numberBlacks} - Whites: {numberWhites} - Inverts: {sumInverts}";
		}

		#endregion
	}
}