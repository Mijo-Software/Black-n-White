using System;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Office2007Rendering;

namespace Black_n_White
{
	public partial class Black_n_WhiteForm : Form
	{
		private bool isGameStarted = false;
		private int
			numberKlicks = 0,
			numberTicks = 0,
			numberBlacks = 0,
			numberWhites = 0,
			numberInvertedFields = 0;
		private Random randomNumber = new Random();
		private StringBuilder stringBuilder = new StringBuilder();

		#region Assemblyattributaccessoren

		public string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion

		public Black_n_WhiteForm() => InitializeComponent();

		private void MainForm_Load(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new Office2007Renderer();
			ClearStatusLabel(sender: sender, e: e);
			tabControl.SelectedTab = tabPageGame3x3;
			InitGameboard();
			labelProduct.Text = AssemblyProduct;
			labelVersion.Text = AssemblyVersion;
			labelCompany.Text = AssemblyCompany;
			labelCopyright.Text = AssemblyCopyright;
			textBoxDescription.Text = AssemblyDescription;
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

		private Color RandomFieldColor()
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

		private void InvertFields(ushort[] fieldIDArray)
		{
			foreach (ushort i in fieldIDArray)
			{ 
				switch (i)
				{
					case 311:
						buttonGame3Field11.BackColor = InvertFieldColor(color: buttonGame3Field11.BackColor);
						break;
					case 312:
						buttonGame3Field12.BackColor = InvertFieldColor(color: buttonGame3Field12.BackColor);
						break;
					case 313:
						buttonGame3Field13.BackColor = InvertFieldColor(color: buttonGame3Field13.BackColor);
						break;
					case 321:
						buttonGame3Field21.BackColor = InvertFieldColor(color: buttonGame3Field21.BackColor);
						break;
					case 322:
						buttonGame3Field22.BackColor = InvertFieldColor(color: buttonGame3Field22.BackColor);
						break;
					case 323:
						buttonGame3Field23.BackColor = InvertFieldColor(color: buttonGame3Field23.BackColor);
						break;
					case 331:
						buttonGame3Field31.BackColor = InvertFieldColor(color: buttonGame3Field31.BackColor);
						break;
					case 332:
						buttonGame3Field32.BackColor = InvertFieldColor(color: buttonGame3Field32.BackColor);
						break;
					case 333:
						buttonGame3Field33.BackColor = InvertFieldColor(color: buttonGame3Field33.BackColor);
						break;
					case 411:
						buttonGame4Field11.BackColor = InvertFieldColor(color: buttonGame4Field11.BackColor);
						break;
					case 412:
						buttonGame4Field12.BackColor = InvertFieldColor(color: buttonGame4Field12.BackColor);
						break;
					case 413:
						buttonGame4Field13.BackColor = InvertFieldColor(color: buttonGame4Field13.BackColor);
						break;
					case 414:
						buttonGame4Field14.BackColor = InvertFieldColor(color: buttonGame4Field14.BackColor);
						break;
					case 421:
						buttonGame4Field21.BackColor = InvertFieldColor(color: buttonGame4Field21.BackColor);
						break;
					case 422:
						buttonGame4Field22.BackColor = InvertFieldColor(color: buttonGame4Field22.BackColor);
						break;
					case 423:
						buttonGame4Field23.BackColor = InvertFieldColor(color: buttonGame4Field23.BackColor);
						break;
					case 424:
						buttonGame4Field24.BackColor = InvertFieldColor(color: buttonGame4Field24.BackColor);
						break;
					case 431:
						buttonGame4Field31.BackColor = InvertFieldColor(color: buttonGame4Field31.BackColor);
						break;
					case 432:
						buttonGame4Field32.BackColor = InvertFieldColor(color: buttonGame4Field32.BackColor);
						break;
					case 433:
						buttonGame4Field33.BackColor = InvertFieldColor(color: buttonGame4Field33.BackColor);
						break;
					case 434:
						buttonGame4Field34.BackColor = InvertFieldColor(color: buttonGame4Field34.BackColor);
						break;
					case 441:
						buttonGame4Field41.BackColor = InvertFieldColor(color: buttonGame4Field41.BackColor);
						break;
					case 442:
						buttonGame4Field42.BackColor = InvertFieldColor(color: buttonGame4Field42.BackColor);
						break;
					case 443:
						buttonGame4Field43.BackColor = InvertFieldColor(color: buttonGame4Field43.BackColor);
						break;
					case 444:
						buttonGame4Field44.BackColor = InvertFieldColor(color: buttonGame4Field44.BackColor);
						break;
					case 511:
						buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
						break;
					case 512:
						buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
						break;
					case 513:
						buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
						break;
					case 514:
						buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
						break;
					case 515:
						buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
						break;
					case 521:
						buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
						break;
					case 522:
						buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
						break;
					case 523:
						buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
						break;
					case 524:
						buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
						break;
					case 525:
						buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
						break;
					case 531:
						buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
						break;
					case 532:
						buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
						break;
					case 533:
						buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
						break;
					case 534:
						buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
						break;
					case 535:
						buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
						break;
					case 541:
						buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
						break;
					case 542:
						buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
						break;
					case 543:
						buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
						break;
					case 544:
						buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
						break;
					case 545:
						buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
						break;
					case 551:
						buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
						break;
					case 552:
						buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
						break;
					case 553:
						buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
						break;
					case 554:
						buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
						break;
					case 555:
						buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
						break;
				}
			}
		}

		private void InvertFieldColor(ushort fieldID)
		{
			switch (fieldID)
			{
				case 311:
					buttonGame3Field11.BackColor = InvertFieldColor(color: buttonGame3Field11.BackColor);
					break;
				case 312:
					buttonGame3Field12.BackColor = InvertFieldColor(color: buttonGame3Field12.BackColor);
					break;
				case 313:
					buttonGame3Field13.BackColor = InvertFieldColor(color: buttonGame3Field13.BackColor);
					break;
				case 321:
					buttonGame3Field21.BackColor = InvertFieldColor(color: buttonGame3Field21.BackColor);
					break;
				case 322:
					buttonGame3Field22.BackColor = InvertFieldColor(color: buttonGame3Field22.BackColor);
					break;
				case 323:
					buttonGame3Field23.BackColor = InvertFieldColor(color: buttonGame3Field23.BackColor);
					break;
				case 331:
					buttonGame3Field31.BackColor = InvertFieldColor(color: buttonGame3Field31.BackColor);
					break;
				case 332:
					buttonGame3Field32.BackColor = InvertFieldColor(color: buttonGame3Field32.BackColor);
					break;
				case 333:
					buttonGame3Field33.BackColor = InvertFieldColor(color: buttonGame3Field33.BackColor);
					break;
				case 411:
					buttonGame4Field11.BackColor = InvertFieldColor(color: buttonGame4Field11.BackColor);
					break;
				case 412:
					buttonGame4Field12.BackColor = InvertFieldColor(color: buttonGame4Field12.BackColor);
					break;
				case 413:
					buttonGame4Field13.BackColor = InvertFieldColor(color: buttonGame4Field13.BackColor);
					break;
				case 414:
					buttonGame4Field14.BackColor = InvertFieldColor(color: buttonGame4Field14.BackColor);
					break;
				case 421:
					buttonGame4Field21.BackColor = InvertFieldColor(color: buttonGame4Field21.BackColor);
					break;
				case 422:
					buttonGame4Field22.BackColor = InvertFieldColor(color: buttonGame4Field22.BackColor);
					break;
				case 423:
					buttonGame4Field23.BackColor = InvertFieldColor(color: buttonGame4Field23.BackColor);
					break;
				case 424:
					buttonGame4Field24.BackColor = InvertFieldColor(color: buttonGame4Field24.BackColor);
					break;
				case 431:
					buttonGame4Field31.BackColor = InvertFieldColor(color: buttonGame4Field31.BackColor);
					break;
				case 432:
					buttonGame4Field32.BackColor = InvertFieldColor(color: buttonGame4Field32.BackColor);
					break;
				case 433:
					buttonGame4Field33.BackColor = InvertFieldColor(color: buttonGame4Field33.BackColor);
					break;
				case 434:
					buttonGame4Field34.BackColor = InvertFieldColor(color: buttonGame4Field34.BackColor);
					break;
				case 441:
					buttonGame4Field41.BackColor = InvertFieldColor(color: buttonGame4Field41.BackColor);
					break;
				case 442:
					buttonGame4Field42.BackColor = InvertFieldColor(color: buttonGame4Field42.BackColor);
					break;
				case 443:
					buttonGame4Field43.BackColor = InvertFieldColor(color: buttonGame4Field43.BackColor);
					break;
				case 444:
					buttonGame4Field44.BackColor = InvertFieldColor(color: buttonGame4Field44.BackColor);
					break;
				case 511:
					buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
					break;
				case 512:
					buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
					break;
				case 513:
					buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
					break;
				case 514:
					buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
					break;
				case 515:
					buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
					break;
				case 521:
					buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
					break;
				case 522:
					buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
					break;
				case 523:
					buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
					break;
				case 524:
					buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
					break;
				case 525:
					buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
					break;
				case 531:
					buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
					break;
				case 532:
					buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
					break;
				case 533:
					buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
					break;
				case 534:
					buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
					break;
				case 535:
					buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
					break;
				case 541:
					buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
					break;
				case 542:
					buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
					break;
				case 543:
					buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
					break;
				case 544:
					buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
					break;
				case 545:
					buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
					break;
				case 551:
					buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
					break;
				case 552:
					buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
					break;
				case 553:
					buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
					break;
				case 554:
					buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
					break;
				case 555:
					buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
					break;
			}
		}

		private Color InvertFieldColor(Color color)
		{
			if (!toolStripButtonPause.Enabled) toolStripButtonPause.Enabled = true;
			if (!timer.Enabled) timer.Enabled = true;
			numberInvertedFields++;
			switch (color.Name)
			{
				case "Black":
					return Color.White;
				case "White":
					return Color.Black;
				default:
					return color;
			}
		}

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

		private void InitGameboard3x3()
		{
			timer.Enabled = false;
			toolStripButtonPause.Enabled = false;
			toolStripLabelStatistic.Text = I10n.statisticDefault;
			numberTicks = 0;
			numberKlicks = 0;
			numberInvertedFields = 0;
			tabPageGame3x3.Parent = tabControl;
			tabPageGame4x4.Parent = null;
			tabPageGame5x5.Parent = null;
			foreach (Control button in tableLayoutPanelGame3x3.Controls)
			{
				button.BackColor = RandomFieldColor();
			}
		}

		private void InitGameboard4x4()
		{
			timer.Enabled = false;
			toolStripButtonPause.Enabled = false;
			toolStripLabelStatistic.Text = I10n.statisticDefault;
			numberTicks = 0;
			numberKlicks = 0;
			numberInvertedFields = 0;
			tabPageGame3x3.Parent = null;
			tabPageGame4x4.Parent = tabControl;
			tabPageGame5x5.Parent = null;
			foreach (Control button in tableLayoutPanelGame4x4.Controls)
			{
				button.BackColor = RandomFieldColor();
			}
		}

		private void InitGameboard5x5()
		{
			timer.Enabled = false;
			toolStripButtonPause.Enabled = false;
			toolStripLabelStatistic.Text = I10n.statisticDefault;
			numberTicks = 0;
			numberKlicks = 0;
			numberInvertedFields = 0;
			tabPageGame3x3.Parent = null;
			tabPageGame4x4.Parent = null;
			tabPageGame5x5.Parent = tabControl;
			foreach (Control button in tableLayoutPanelGame5x5.Controls)
			{
				button.BackColor = RandomFieldColor();
			}
		}

		private void CountColorsInGameboard3x3()
		{
			numberBlacks = 0;
			numberWhites = 0;
			foreach (Control button in tableLayoutPanelGame3x3.Controls)
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

		private void CountColorsInGameboard4x4()
		{
			numberBlacks = 0;
			numberWhites = 0;
			foreach (Control button in tableLayoutPanelGame4x4.Controls)
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

		private void CountColorsInGameboard5x5()
		{
			numberBlacks = 0;
			numberWhites = 0;
			foreach (Control button in tableLayoutPanelGame5x5.Controls)
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

		private bool IsSameColorsInGameboard3x3()
		{
			bool isSameColor = false;
			int
				numbUndefinedColor = 0,
				numbWhiteColor = 0,
				numbBlackColor = 0;
			foreach (Control button in tableLayoutPanelGame3x3.Controls)
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
			if ((numbWhiteColor == (3 * 3)) || (numbBlackColor == (3 * 3))) isSameColor = true;
			return isSameColor;
		}

		private bool IsSameColorsInGameboard4x4()
		{
			bool isSameColor = false;
			int
				numbUndefinedColor = 0,
				numbWhiteColor = 0,
				numbBlackColor = 0;
			foreach (Control button in tableLayoutPanelGame4x4.Controls)
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
			if ((numbWhiteColor == (4 * 4)) || (numbBlackColor == (4 * 4))) isSameColor = true;
			return isSameColor;
		}

		private bool IsSameColorsInGameboard5x5()
		{
			bool isSameColor = false;
			int
				numbUndefinedColor = 0,
				numbWhiteColor = 0,
				numbBlackColor = 0;
			foreach (Control button in tableLayoutPanelGame5x5.Controls)
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
			if ((numbWhiteColor == (5 * 5)) || (numbBlackColor == (5 * 5))) isSameColor = true;
			return isSameColor;
		}

		private void CheckForWinInGameboard3x3()
		{
			if (!isGameStarted)
			{
				isGameStarted = true;
				toolStripMenuItemGameOptions.Enabled = false;
			}
			if (IsSameColorsInGameboard3x3())
			{
				FinishGame();
			}
		}

		private void CheckForWinInGameboard4x4()
		{
			if (!isGameStarted)
			{
				isGameStarted = true;
				toolStripMenuItemGameOptions.Enabled = false;
			}
			if (IsSameColorsInGameboard4x4())
			{
				FinishGame();
			}
		}

		private void CheckForWinInGameboard5x5()
		{
			if (!isGameStarted)
			{
				isGameStarted = true;
				toolStripMenuItemGameOptions.Enabled = false;
			}
			if (IsSameColorsInGameboard5x5())
			{
				FinishGame();
			}
		}

		private void CountColorsAndCheckForWinInGameboard3x3()
		{
			CountColorsInGameboard3x3();
			CheckForWinInGameboard3x3();
		}

		private void CountColorsAndCheckForWinInGameboard4x4()
		{
			CountColorsInGameboard4x4();
			CheckForWinInGameboard4x4();
		}

		private void CountColorsAndCheckForWinInGameboard5x5()
		{
			CountColorsInGameboard5x5();
			CheckForWinInGameboard5x5();
		}

		private void FinishGame()
		{
			timer.Stop();
			timer.Enabled = false;
			string message = $"Du hast gewonnen mit {numberKlicks} Klicks in {numberTicks} Ticks.";
			MessageBox.Show(text: message, caption: I10n.won, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			isGameStarted = false;
			toolStripMenuItemGameOptions.Enabled = true;
			numberTicks = 0;
			toolStripLabelStatistic.Text = I10n.statisticDefault;
			InitGameboard();
		}

		private void ToolStripMenuItemNewGame3x3_Click(object sender, EventArgs e)
		{
			toolStripMenuItemNewGame3x3.Checked = true;
			toolStripMenuItemNewGame4x4.Checked = false;
			toolStripMenuItemNewGame5x5.Checked = false;
			tabControl.SelectedTab = tabPageGame3x3;
			InitGameboard3x3();
		}

		private void ToolStripMenuItemNewGame4x4_Click(object sender, EventArgs e)
		{
			toolStripMenuItemNewGame3x3.Checked = false;
			toolStripMenuItemNewGame4x4.Checked = true;
			toolStripMenuItemNewGame5x5.Checked = false;
			tabControl.SelectedTab = tabPageGame4x4;
			InitGameboard4x4();
		}

		private void ToolStripMenuItemNewGame5x5_Click(object sender, EventArgs e)
		{
			toolStripMenuItemNewGame3x3.Checked = false;
			toolStripMenuItemNewGame4x4.Checked = false;
			toolStripMenuItemNewGame5x5.Checked = true;
			tabControl.SelectedTab = tabPageGame5x5;
			InitGameboard5x5();
		}

		private void ToolStripMenuItemOptionLinear_Click(object sender, EventArgs e)
		{
			toolStripMenuItemOptionLinear.Checked = true;
			toolStripMenuItemOptionDiagonal.Checked = false;
			toolStripMenuItemOptionCombined.Checked = false;
		}

		private void ToolStripMenuItemOptionDiagonal_Click(object sender, EventArgs e)
		{
			toolStripMenuItemOptionLinear.Checked = false;
			toolStripMenuItemOptionDiagonal.Checked = true;
			toolStripMenuItemOptionCombined.Checked = false;
		}

		private void ToolStripMenuItemOptionCombined_Click(object sender, EventArgs e)
		{
			toolStripMenuItemOptionLinear.Checked = false;
			toolStripMenuItemOptionDiagonal.Checked = false;
			toolStripMenuItemOptionCombined.Checked = true;
		}

		private void ButtonGame3Field11_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 312, 321 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 322 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 312, 321, 322 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 311 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field12_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 311, 313, 322 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 321, 323 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 311, 313, 322, 321, 323 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 312 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field13_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 312, 323 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 322 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 312, 323, 322 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 313 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field21_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 311, 322, 331 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 312, 332 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 311, 322, 331, 312, 332 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 321 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field22_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 312, 321, 323, 332 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 311, 313, 331, 333 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 312, 321, 323, 332, 311, 313, 331, 333 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 322 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field23_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 313, 322, 333 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 312, 332 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 313, 322, 333, 312, 332 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 323 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field31_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 321, 332 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 322 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 321, 332, 322 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 331 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field32_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 322, 331, 333 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 321, 323 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 322, 331, 333, 321, 323 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 332 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field33_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(new ushort[] { 323, 332 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(new ushort[] { 322 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(new ushort[] { 323, 332, 322 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(new ushort[] { 333 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame4Field11_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (!timer.Enabled) timer.Enabled = true;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field21.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field22.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field11.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field12_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field11.BackColor);
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field11.BackColor);
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field13_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field14.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field24.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field14.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field24.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field14_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field24.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field23.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field24.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field14.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field21_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field11.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field31.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field11.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field22_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field11.BackColor);
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field11.BackColor);
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field23_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field24.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field14.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field34.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field24.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
				InvertFieldColor(color: buttonGame4Field12.BackColor);
				InvertFieldColor(color: buttonGame4Field14.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field34.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field24_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field14.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field34.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field14.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field34.BackColor);
				InvertFieldColor(color: buttonGame4Field13.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field24.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field31_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field41.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field41.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field32_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field41.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
				InvertFieldColor(color: buttonGame4Field21.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field41.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field33_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field34.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field24.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
				InvertFieldColor(color: buttonGame4Field44.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field34.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
				InvertFieldColor(color: buttonGame4Field22.BackColor);
				InvertFieldColor(color: buttonGame4Field24.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
				InvertFieldColor(color: buttonGame4Field44.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field33.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field34_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field24.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
				InvertFieldColor(color: buttonGame4Field44.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field24.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
				InvertFieldColor(color: buttonGame4Field44.BackColor);
				InvertFieldColor(color: buttonGame4Field23.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field34.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field41_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field32.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field41.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field42_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field41.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field41.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
				InvertFieldColor(color: buttonGame4Field31.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field42.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field43_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field33.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
				InvertFieldColor(color: buttonGame4Field44.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field34.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field33.BackColor);
				InvertFieldColor(color: buttonGame4Field42.BackColor);
				InvertFieldColor(color: buttonGame4Field44.BackColor);
				InvertFieldColor(color: buttonGame4Field32.BackColor);
				InvertFieldColor(color: buttonGame4Field34.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field43.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field44_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFieldColor(color: buttonGame4Field34.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFieldColor(color: buttonGame4Field34.BackColor);
				InvertFieldColor(color: buttonGame4Field43.BackColor);
				InvertFieldColor(color: buttonGame4Field33.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFieldColor(color: buttonGame4Field44.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame5Field11_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field12_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field13_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field14_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field15_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field21_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field22_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field11.BackColor = InvertFieldColor(color: buttonGame5Field11.BackColor);
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field23_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field12.BackColor = InvertFieldColor(color: buttonGame5Field12.BackColor);
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field24_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field13.BackColor = InvertFieldColor(color: buttonGame5Field13.BackColor);
				buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field25_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field15.BackColor = InvertFieldColor(color: buttonGame5Field15.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
				buttonGame5Field14.BackColor = InvertFieldColor(color: buttonGame5Field14.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field31_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (!timer.Enabled) timer.Enabled = true;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field32_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field21.BackColor = InvertFieldColor(color: buttonGame5Field21.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field33_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field22.BackColor = InvertFieldColor(color: buttonGame5Field22.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field34_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
				buttonGame5Field23.BackColor = InvertFieldColor(color: buttonGame5Field23.BackColor);
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field35_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field25.BackColor = InvertFieldColor(color: buttonGame5Field25.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
				buttonGame5Field24.BackColor = InvertFieldColor(color: buttonGame5Field24.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field41_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field42_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
				buttonGame5Field31.BackColor = InvertFieldColor(color: buttonGame5Field31.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field43_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
				buttonGame5Field32.BackColor = InvertFieldColor(color: buttonGame5Field32.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field44_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
				buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
				buttonGame5Field33.BackColor = InvertFieldColor(color: buttonGame5Field33.BackColor);
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
				buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field45_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
				buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field35.BackColor = InvertFieldColor(color: buttonGame5Field35.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
				buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
				buttonGame5Field34.BackColor = InvertFieldColor(color: buttonGame5Field34.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field51_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field52_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field51.BackColor = InvertFieldColor(color: buttonGame5Field51.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
				buttonGame5Field41.BackColor = InvertFieldColor(color: buttonGame5Field41.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field53_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field52.BackColor = InvertFieldColor(color: buttonGame5Field52.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
				buttonGame5Field42.BackColor = InvertFieldColor(color: buttonGame5Field42.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field54_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
				buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
				buttonGame5Field53.BackColor = InvertFieldColor(color: buttonGame5Field53.BackColor);
				buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
				buttonGame5Field43.BackColor = InvertFieldColor(color: buttonGame5Field43.BackColor);
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field55_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				buttonGame5Field45.BackColor = InvertFieldColor(color: buttonGame5Field45.BackColor);
				buttonGame5Field54.BackColor = InvertFieldColor(color: buttonGame5Field54.BackColor);
				buttonGame5Field44.BackColor = InvertFieldColor(color: buttonGame5Field44.BackColor);
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				buttonGame5Field55.BackColor = InvertFieldColor(color: buttonGame5Field55.BackColor);
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ToolStripSplitButtonNewGame_Click(object sender, EventArgs e)
		{
			isGameStarted = false;
			toolStripMenuItemGameOptions.Enabled = true;
			InitGameboard();
		}

		private void ToolStripButtonPause_Click(object sender, EventArgs e)
		{
			timer.Enabled = false;
			MessageBox.Show(
				text: I10n.gamePaused,
				caption: I10n.paused,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information);
			timer.Enabled = true;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			numberTicks++;
			toolStripLabelStatistic.Text = $"Klicks: {numberKlicks} - Ticks: {numberTicks} - Blacks: {numberBlacks} - Whites: {numberWhites}";
		}
	}
}