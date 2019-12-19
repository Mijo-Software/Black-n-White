using Office2007Rendering;

using System;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BlackAndWhite
{
	/// <summary>
	/// 
	/// </summary>
	public partial class BlackAndWhiteForm : Form
	{
		private bool isGameStarted;

		private int
			numberKlicks = 0,
			numberTicks = 0,
			numberBlacks = 0,
			numberWhites = 0,
			numberInvertedFields = 0;

		private readonly Random randomNumber = new Random();

		private readonly StringBuilder stringBuilder = new StringBuilder();

		#region Assemblyattributaccessoren

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyTitle()
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

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyDescription()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyDescriptionAttribute)attributes[0]).Description;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyProduct()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyProductAttribute)attributes[0]).Product;
		}

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyCopyright()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyCompany()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCompanyAttribute)attributes[0]).Company;
		}
		#endregion

		/// <summary>
		/// 
		/// </summary>
		public BlackAndWhiteForm() => InitializeComponent();

		private void MainForm_Load(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new Office2007Renderer();
			ClearStatusLabel(sender: sender, e: e);
			tabControl.SelectedTab = tabPageGame3x3;
			InitGameboard();
			labelProduct.Text = GetAssemblyProduct();
			labelVersion.Text = GetAssemblyVersion();
			labelCompany.Text = GetAssemblyCompany();
			labelCopyright.Text = GetAssemblyCopyright();
			textBoxDescription.Text = GetAssemblyDescription();
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

		private void ClearStatusLabel(object sender, EventArgs e) => toolStripStatusLabel.Text = string.Empty;

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

		private void InvertFields(ushort[] idField)
		{
			foreach (ushort i in idField)
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

		private void InvertFieldColor(ushort field)
		{
			switch (field)
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
			if (!toolStripButtonPause.Enabled)
			{
				toolStripButtonPause.Enabled = true;
			}

			if (!timer.Enabled)
			{
				timer.Enabled = true;
			}

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
			if ((numbWhiteColor == (3 * 3)) || (numbBlackColor == (3 * 3)))
			{
				isSameColor = true;
			}

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
			if ((numbWhiteColor == (4 * 4)) || (numbBlackColor == (4 * 4)))
			{
				isSameColor = true;
			}

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
			if ((numbWhiteColor == (5 * 5)) || (numbBlackColor == (5 * 5)))
			{
				isSameColor = true;
			}

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
				InvertFields(idField: new ushort[] { 312, 321 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 322 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 312, 321, 322 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 311 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field12_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 311, 313, 322 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 321, 323 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 311, 313, 322, 321, 323 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 312 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field13_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 312, 323 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 322 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 312, 323, 322 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 313 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field21_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 311, 322, 331 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 312, 332 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 311, 322, 331, 312, 332 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 321 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field22_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 312, 321, 323, 332 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 311, 313, 331, 333 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 312, 321, 323, 332, 311, 313, 331, 333 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 322 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field23_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 313, 322, 333 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 312, 332 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 313, 322, 333, 312, 332 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 323 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field31_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 321, 332 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 322 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 321, 332, 322 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 331 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field32_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 322, 331, 333 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 321, 323 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 322, 331, 333, 321, 323 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 332 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame3Field33_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 323, 332 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 322 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 323, 332, 322 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 333 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard3x3();
		}

		private void ButtonGame4Field11_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (!timer.Enabled)
			{
				timer.Enabled = true;
			}

			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 412, 421 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 422 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 412, 421, 422 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 411 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field12_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 411, 413, 422 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 421, 423 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 411, 413, 422, 421, 423 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 412 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field13_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 412, 414, 423 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 422, 424 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 412, 414, 423, 422, 424 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 413 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field14_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 413, 424 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 423 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 413, 424, 423 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 414 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field21_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 411, 422, 431 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 412, 432 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 411, 422, 431, 412, 432 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 421 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field22_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 412, 421, 423, 432 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 411, 413, 431, 433 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 412, 421, 423, 432, 411, 413, 431, 433 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 422 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field23_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 413, 422, 424, 433 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 412, 414, 432, 434 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 413, 422, 424, 433, 412, 414, 432, 434 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 423 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field24_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 414, 423, 434 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 413, 433 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 414, 423, 434, 413, 433 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 424 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field31_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 421, 432, 441 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 422, 442 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 421, 432, 441, 422, 442 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 431 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field32_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 422, 431, 433, 442 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 421, 423, 441, 443 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 422, 431, 433, 442, 421, 423, 441, 443 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 432 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field33_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 423, 432, 434, 443 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 422, 424, 442, 444 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 423, 432, 434, 443, 422, 424, 442, 444 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 433 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field34_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 424, 433, 444 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 423, 443 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 424, 433, 444, 423, 443 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 434 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field41_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 431, 442 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 432 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 431, 442, 432 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 441 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field42_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 432, 441, 443 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 431, 433 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 432, 441, 443, 431, 433 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 442 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field43_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 433, 442, 444 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 432, 434 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 433, 442, 444, 432, 434 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 443 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame4Field44_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 434, 443 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 433 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 434, 443, 433 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 444 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard4x4();
		}

		private void ButtonGame5Field11_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 512, 521 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 522 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 512, 521, 522 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 511 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field12_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 511, 513, 522 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 521, 523 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 511, 513, 522, 521, 523 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 512 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field13_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 512, 514, 523 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 522, 524 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 512, 514, 523, 522, 524 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 513 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field14_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 513, 515, 524 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 523, 525 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 513, 515, 524, 523, 525 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 514 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field15_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 514, 525 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 524 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 514, 525, 524 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 515 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field21_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 511, 522, 531 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 512, 532 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 511, 522, 531, 512, 532 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 521 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field22_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 512, 521, 523, 532 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 511, 513, 531, 533 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 512, 521, 523, 532, 511, 513, 531, 533 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 522 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field23_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 513, 522, 524, 533 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 512, 514, 532, 534 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 513, 522, 524, 533, 512, 514, 532, 534 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 523 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field24_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 514, 523, 525, 534 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 513, 515, 533, 535 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 514, 523, 525, 534, 513, 515, 533, 535 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 524 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field25_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 515, 524, 535 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 514, 534 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 515, 524, 535, 514, 534 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 525 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field31_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (!timer.Enabled)
			{
				timer.Enabled = true;
			}

			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 521, 532, 541 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 522, 542 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 521, 532, 541, 522, 542 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 531 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field32_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 522, 531, 533, 542 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 521, 523, 541, 543 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 522, 531, 533, 542, 521, 523, 541, 543 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 532 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field33_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 523, 532, 534, 543 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 522, 524, 542, 544 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 523, 532, 534, 543, 522, 524, 542, 544 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 533 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field34_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 524, 533, 535, 544 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 523, 525, 543, 545 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 524, 533, 535, 544, 523, 525, 543, 545 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 534 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field35_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 525, 534, 545 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 524, 544 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 525, 534, 545, 524, 544 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 535 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field41_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 531, 542, 551 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 532, 552 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 531, 542, 551, 532, 552 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 541 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field42_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 532, 541, 543, 552 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 531, 533, 551, 553 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 532, 541, 543, 552, 531, 533, 551, 553 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 542 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field43_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 533, 542, 544, 553 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 532, 534, 552, 554 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 533, 542, 544, 553, 532, 534, 552, 554 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 543 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field44_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 534, 543, 545, 554 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 533, 535, 553, 555 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 534, 543, 545, 554, 533, 535, 553, 555 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 544 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field45_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 535, 544, 555 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 534, 554 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 535, 544, 555, 534, 554 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 545 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field51_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 541, 552 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 542 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 541, 552, 542 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 551 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field52_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 542, 551, 553 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 541, 543 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 542, 551, 553 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 552 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field53_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 543, 552, 554 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 542, 544 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 543, 552, 554, 542, 544 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 553 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field54_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 544, 553, 555 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 543, 545 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 544, 553, 555, 543, 545 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 554 });
				SetStatusLabelField(sender: sender, e: e);
			}
			CountColorsAndCheckForWinInGameboard5x5();
		}

		private void ButtonGame5Field55_Click(object sender, EventArgs e)
		{
			numberKlicks++;
			if (toolStripMenuItemOptionLinear.Checked)
			{
				InvertFields(idField: new ushort[] { 545, 554 });
			}
			else if (toolStripMenuItemOptionDiagonal.Checked)
			{
				InvertFields(idField: new ushort[] { 544 });
			}
			else if (toolStripMenuItemOptionCombined.Checked)
			{
				InvertFields(idField: new ushort[] { 545, 554, 544 });
			}
			if (toolStripMenuItemOptionCentered.Checked)
			{
				InvertFields(idField: new ushort[] { 555 });
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