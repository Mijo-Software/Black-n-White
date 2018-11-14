using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Black_n_White
{
  public partial class Black_n_WhiteForm : Form
  {
    const String Space = " ";
    const String Colon = ":";
    const int intNumberOfAllFields = 5 * 5;
    int intClicks = 0;
    int intTicks = 0;
    int intBlacks = 0;
    int intWhites = 0;
    int intGamesize = 5;
    bool boolFirstClickDone = false;                    
    bool boolIsGameRunning = false;

    public Black_n_WhiteForm()
    {
      InitializeComponent();
    }

    private void UpdateClicks()
    {
      intClicks++;
      labelClicks.Text = "Klicks: " + intClicks;
    }

    private void CheckIfTimerIsEnabled()
    {
      if (!boolFirstClickDone)
      {
        boolFirstClickDone = true;
        timer.Enabled = true;
      }
    }

    private void ShowFields(params int[] Values)
    {
      for (int i = 1; i < Values.Length + 1; i++)
      {
        switch (Values[i - 1])
        {
          case 0: pictureBoxField1.Show(); break;
          case 1: pictureBoxField2.Show(); break;
          case 2: pictureBoxField3.Show(); break;
          case 3: pictureBoxField4.Show(); break;
          case 4: pictureBoxField5.Show(); break;
          case 5: pictureBoxField6.Show(); break;
          case 6: pictureBoxField7.Show(); break;
          case 7: pictureBoxField8.Show(); break;
          case 8: pictureBoxField9.Show(); break;
          case 9: pictureBoxField10.Show(); break;
          case 10: pictureBoxField11.Show(); break;
          case 11: pictureBoxField12.Show(); break;
          case 12: pictureBoxField13.Show(); break;
          case 13: pictureBoxField14.Show(); break;
          case 14: pictureBoxField15.Show(); break;
          case 15: pictureBoxField16.Show(); break;
          case 16: pictureBoxField17.Show(); break;
          case 17: pictureBoxField18.Show(); break;
          case 18: pictureBoxField19.Show(); break;
          case 19: pictureBoxField20.Show(); break;
          case 20: pictureBoxField21.Show(); break;
          case 21: pictureBoxField22.Show(); break;
          case 22: pictureBoxField23.Show(); break;
          case 23: pictureBoxField24.Show(); break;
          case 24: pictureBoxField25.Show(); break;
        }
      }
    }

    private void HideFields(params int[] Values)
    {
      for (int i = 1; i < Values.Length + 1; i++)
      {
        switch (Values[i - 1])
        {
          case 0: pictureBoxField1.Hide(); break;
          case 1: pictureBoxField2.Hide(); break;
          case 2: pictureBoxField3.Hide(); break;
          case 3: pictureBoxField4.Hide(); break;
          case 4: pictureBoxField5.Hide(); break;
          case 5: pictureBoxField6.Hide(); break;
          case 6: pictureBoxField7.Hide(); break;
          case 7: pictureBoxField8.Hide(); break;
          case 8: pictureBoxField9.Hide(); break;
          case 9: pictureBoxField10.Hide(); break;
          case 10: pictureBoxField11.Hide(); break;
          case 11: pictureBoxField12.Hide(); break;
          case 12: pictureBoxField13.Hide(); break;
          case 13: pictureBoxField14.Hide(); break;
          case 14: pictureBoxField15.Hide(); break;
          case 15: pictureBoxField16.Hide(); break;
          case 16: pictureBoxField17.Hide(); break;
          case 17: pictureBoxField18.Hide(); break;
          case 18: pictureBoxField19.Hide(); break;
          case 19: pictureBoxField20.Hide(); break;
          case 20: pictureBoxField21.Hide(); break;
          case 21: pictureBoxField22.Hide(); break;
          case 22: pictureBoxField23.Hide(); break;
          case 23: pictureBoxField24.Hide(); break;
          case 24: pictureBoxField25.Hide(); break;
        }
      }
    }

    private void InitializeGame()
    {
      Random rnd = new Random();
      int r = 0;
      Color color;
      intTicks = 0;
      intClicks = 0;
      intBlacks = 0;
      intWhites = 0;

      for (int i = 0; i < intNumberOfAllFields; i++)
      {
        r = rnd.Next();
        if (r % 2 == 0) color = Color.Black; else color = Color.White;
        switch (i)
        {
          case 0: pictureBoxField1.BackColor = color; break;
          case 1: pictureBoxField2.BackColor = color; break;
          case 2: pictureBoxField3.BackColor = color; break;
          case 3: pictureBoxField4.BackColor = color; break;
          case 4: pictureBoxField5.BackColor = color; break;
          case 5: pictureBoxField6.BackColor = color; break;
          case 6: pictureBoxField7.BackColor = color; break;
          case 7: pictureBoxField8.BackColor = color; break;
          case 8: pictureBoxField9.BackColor = color; break;
          case 9: pictureBoxField10.BackColor = color; break;
          case 10: pictureBoxField11.BackColor = color; break;
          case 11: pictureBoxField12.BackColor = color; break;
          case 12: pictureBoxField13.BackColor = color; break;
          case 13: pictureBoxField14.BackColor = color; break;
          case 14: pictureBoxField15.BackColor = color; break;
          case 15: pictureBoxField16.BackColor = color; break;
          case 16: pictureBoxField17.BackColor = color; break;
          case 17: pictureBoxField18.BackColor = color; break;
          case 18: pictureBoxField19.BackColor = color; break;
          case 19: pictureBoxField20.BackColor = color; break;
          case 20: pictureBoxField21.BackColor = color; break;
          case 21: pictureBoxField22.BackColor = color; break;
          case 22: pictureBoxField23.BackColor = color; break;
          case 23: pictureBoxField24.BackColor = color; break;
          case 24: pictureBoxField25.BackColor = color; break;
        }
      }

      if (intGamesize == 3)
      {
        HideFields(4, 5, 9, 10, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
      }
      else if (intGamesize == 4)
      {
        ShowFields(4, 9, 14, 16, 17, 18, 19);
        HideFields(5, 10, 15, 20, 21, 22, 23, 24, 25);
      }
      else if (intGamesize == 5)
      {
        ShowFields(4, 5, 9, 10, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
      }

      labelClicks.Text = "Klicks: " + intClicks;
      labelTicks.Text = "Ticks: " + intTicks;
      CountBlacksAndWhites();
      boolFirstClickDone = false;
      timer.Enabled = false;
    }

    private bool isFieldUnicolor()
    {
      if (intGamesize == 3)
      {
        if (
          (pictureBoxField1.BackColor == Color.Black &&
          pictureBoxField2.BackColor == Color.Black &&
          pictureBoxField3.BackColor == Color.Black &&
          pictureBoxField6.BackColor == Color.Black &&
          pictureBoxField7.BackColor == Color.Black &&
          pictureBoxField8.BackColor == Color.Black &&
          pictureBoxField11.BackColor == Color.Black &&
          pictureBoxField12.BackColor == Color.Black &&
          pictureBoxField13.BackColor == Color.Black) ||
          (pictureBoxField1.BackColor == Color.White &&
          pictureBoxField2.BackColor == Color.White &&
          pictureBoxField3.BackColor == Color.White &&
          pictureBoxField6.BackColor == Color.White &&
          pictureBoxField7.BackColor == Color.White &&
          pictureBoxField8.BackColor == Color.White &&
          pictureBoxField11.BackColor == Color.White &&
          pictureBoxField12.BackColor == Color.White &&
          pictureBoxField13.BackColor == Color.White)
        )
        {
          return true;
        }
      }
      else if (intGamesize == 4)
      {
        if (
          (pictureBoxField1.BackColor == Color.Black &&
          pictureBoxField2.BackColor == Color.Black &&
          pictureBoxField3.BackColor == Color.Black &&
          pictureBoxField4.BackColor == Color.Black &&
          pictureBoxField6.BackColor == Color.Black &&
          pictureBoxField7.BackColor == Color.Black &&
          pictureBoxField8.BackColor == Color.Black &&
          pictureBoxField9.BackColor == Color.Black &&
          pictureBoxField11.BackColor == Color.Black &&
          pictureBoxField12.BackColor == Color.Black &&
          pictureBoxField13.BackColor == Color.Black &&
          pictureBoxField14.BackColor == Color.Black &&
          pictureBoxField16.BackColor == Color.Black &&
          pictureBoxField17.BackColor == Color.Black &&
          pictureBoxField18.BackColor == Color.Black &&
          pictureBoxField19.BackColor == Color.Black) ||
          (pictureBoxField1.BackColor == Color.White &&
          pictureBoxField2.BackColor == Color.White &&
          pictureBoxField3.BackColor == Color.White &&
          pictureBoxField4.BackColor == Color.White &&
          pictureBoxField6.BackColor == Color.White &&
          pictureBoxField7.BackColor == Color.White &&
          pictureBoxField8.BackColor == Color.White &&
          pictureBoxField9.BackColor == Color.White &&
          pictureBoxField11.BackColor == Color.White &&
          pictureBoxField12.BackColor == Color.White &&
          pictureBoxField13.BackColor == Color.White &&
          pictureBoxField14.BackColor == Color.White &&
          pictureBoxField16.BackColor == Color.White &&
          pictureBoxField17.BackColor == Color.White &&
          pictureBoxField18.BackColor == Color.White &&
          pictureBoxField19.BackColor == Color.White)
        )
        {
          return true;
        }
      }
      if (intGamesize == 5)
      {
        if (
          (pictureBoxField1.BackColor == Color.Black &&
          pictureBoxField2.BackColor == Color.Black &&
          pictureBoxField3.BackColor == Color.Black &&
          pictureBoxField4.BackColor == Color.Black &&
          pictureBoxField5.BackColor == Color.Black &&
          pictureBoxField6.BackColor == Color.Black &&
          pictureBoxField7.BackColor == Color.Black &&
          pictureBoxField8.BackColor == Color.Black &&
          pictureBoxField9.BackColor == Color.Black &&
          pictureBoxField10.BackColor == Color.Black &&
          pictureBoxField11.BackColor == Color.Black &&
          pictureBoxField12.BackColor == Color.Black &&
          pictureBoxField13.BackColor == Color.Black &&
          pictureBoxField14.BackColor == Color.Black &&
          pictureBoxField15.BackColor == Color.Black &&
          pictureBoxField16.BackColor == Color.Black &&
          pictureBoxField17.BackColor == Color.Black &&
          pictureBoxField18.BackColor == Color.Black &&
          pictureBoxField19.BackColor == Color.Black &&
          pictureBoxField20.BackColor == Color.Black &&
          pictureBoxField21.BackColor == Color.Black &&
          pictureBoxField22.BackColor == Color.Black &&
          pictureBoxField23.BackColor == Color.Black &&
          pictureBoxField24.BackColor == Color.Black &&
          pictureBoxField25.BackColor == Color.Black) ||
          (pictureBoxField1.BackColor == Color.White &&
          pictureBoxField2.BackColor == Color.White &&
          pictureBoxField3.BackColor == Color.White &&
          pictureBoxField4.BackColor == Color.White &&
          pictureBoxField5.BackColor == Color.White &&
          pictureBoxField6.BackColor == Color.White &&
          pictureBoxField7.BackColor == Color.White &&
          pictureBoxField8.BackColor == Color.White &&
          pictureBoxField9.BackColor == Color.White &&
          pictureBoxField10.BackColor == Color.White &&
          pictureBoxField11.BackColor == Color.White &&
          pictureBoxField12.BackColor == Color.White &&
          pictureBoxField13.BackColor == Color.White &&
          pictureBoxField14.BackColor == Color.White &&
          pictureBoxField15.BackColor == Color.White &&
          pictureBoxField16.BackColor == Color.White &&
          pictureBoxField17.BackColor == Color.White &&
          pictureBoxField18.BackColor == Color.White &&
          pictureBoxField19.BackColor == Color.White &&
          pictureBoxField20.BackColor == Color.White &&
          pictureBoxField21.BackColor == Color.White &&
          pictureBoxField22.BackColor == Color.White &&
          pictureBoxField23.BackColor == Color.White &&
          pictureBoxField24.BackColor == Color.White &&
          pictureBoxField25.BackColor == Color.White)
        )
        {
          return true;
        }
      }
      return false;
    }

    private void CheckIfWinning()
    {
      if (isFieldUnicolor())
      {
        timer.Stop();
        string message = "Du hast gewonnen mit " + intClicks + " Klicks in " + intTicks + " Ticks.";
        string caption = "Gewonnen";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        DialogResult result;
        result = MessageBox.Show(message, caption, buttons);
         InitializeGame();
        boolIsGameRunning = false;
        buttonNewGameSize.Enabled = true;
        buttonOptions.Enabled = true;
      }
    }

    private void CheckForGameIsRunning()
    {
      if (boolIsGameRunning == false)
      {
        boolIsGameRunning = true;
        buttonNewGameSize.Enabled = false;
        buttonOptions.Enabled = false;
      }
    }

    private void InvertField(byte n)
    {
      Color backColor = Color.Red;
      switch (n)
      {
        case 1: { backColor = pictureBoxField1.BackColor; break; }
        case 2: { backColor = pictureBoxField2.BackColor; break; }
        case 3: { backColor = pictureBoxField3.BackColor; break; }
        case 4: { backColor = pictureBoxField4.BackColor; break; }
        case 5: { backColor = pictureBoxField5.BackColor; break; }
        case 6: { backColor = pictureBoxField6.BackColor; break; }
        case 7: { backColor = pictureBoxField7.BackColor; break; }
        case 8: { backColor = pictureBoxField8.BackColor; break; }
        case 9: { backColor = pictureBoxField9.BackColor; break; }
        case 10: { backColor = pictureBoxField10.BackColor; break; }
        case 11: { backColor = pictureBoxField11.BackColor; break; }
        case 12: { backColor = pictureBoxField12.BackColor; break; }
        case 13: { backColor = pictureBoxField13.BackColor; break; }
        case 14: { backColor = pictureBoxField14.BackColor; break; }
        case 15: { backColor = pictureBoxField15.BackColor; break; }
        case 16: { backColor = pictureBoxField16.BackColor; break; }
        case 17: { backColor = pictureBoxField17.BackColor; break; }
        case 18: { backColor = pictureBoxField18.BackColor; break; }
        case 19: { backColor = pictureBoxField19.BackColor; break; }
        case 20: { backColor = pictureBoxField20.BackColor; break; }
        case 21: { backColor = pictureBoxField21.BackColor; break; }
        case 22: { backColor = pictureBoxField22.BackColor; break; }
        case 23: { backColor = pictureBoxField23.BackColor; break; }
        case 24: { backColor = pictureBoxField24.BackColor; break; }
        case 25: { backColor = pictureBoxField25.BackColor; break; }
      }
      if (backColor == Color.Black) backColor = Color.White;
      else if (backColor == Color.White) backColor = Color.Black;
      switch (n)
      {
        case 1: { pictureBoxField1.BackColor = backColor; break; }
        case 2: { pictureBoxField2.BackColor = backColor; break; }
        case 3: { pictureBoxField3.BackColor = backColor; break; }
        case 4: { pictureBoxField4.BackColor = backColor; break; }
        case 5: { pictureBoxField5.BackColor = backColor; break; }
        case 6: { pictureBoxField6.BackColor = backColor; break; }
        case 7: { pictureBoxField7.BackColor = backColor; break; }
        case 8: { pictureBoxField8.BackColor = backColor; break; }
        case 9: { pictureBoxField9.BackColor = backColor; break; }
        case 10: { pictureBoxField10.BackColor = backColor; break; }
        case 11: { pictureBoxField11.BackColor = backColor; break; }
        case 12: { pictureBoxField12.BackColor = backColor; break; }
        case 13: { pictureBoxField13.BackColor = backColor; break; }
        case 14: { pictureBoxField14.BackColor = backColor; break; }
        case 15: { pictureBoxField15.BackColor = backColor; break; }
        case 16: { pictureBoxField16.BackColor = backColor; break; }
        case 17: { pictureBoxField17.BackColor = backColor; break; }
        case 18: { pictureBoxField18.BackColor = backColor; break; }
        case 19: { pictureBoxField19.BackColor = backColor; break; }
        case 20: { pictureBoxField20.BackColor = backColor; break; }
        case 21: { pictureBoxField21.BackColor = backColor; break; }
        case 22: { pictureBoxField22.BackColor = backColor; break; }
        case 23: { pictureBoxField23.BackColor = backColor; break; }
        case 24: { pictureBoxField24.BackColor = backColor; break; }
        case 25: { pictureBoxField25.BackColor = backColor; break; }
      }
    }

    private void InvertFields(params int[] Values)
    {
      for (int i = 1; i < Values.Length + 1; i++)
      {
        switch (Values[i - 1])
        {
          case 1: InvertField(1); break;
          case 2: InvertField(2); break;
          case 3: InvertField(3); break;
          case 4: InvertField(4); break;
          case 5: InvertField(5); break;
          case 6: InvertField(6); break;
          case 7: InvertField(7); break;
          case 8: InvertField(8); break;
          case 9: InvertField(9); break;
          case 10: InvertField(10); break;
          case 11: InvertField(11); break;
          case 12: InvertField(12); break;
          case 13: InvertField(13); break;
          case 14: InvertField(14); break;
          case 15: InvertField(15); break;
          case 16: InvertField(16); break;
          case 17: InvertField(17); break;
          case 18: InvertField(18); break;
          case 19: InvertField(19); break;
          case 20: InvertField(20); break;
          case 21: InvertField(21); break;
          case 22: InvertField(22); break;
          case 23: InvertField(23); break;
          case 24: InvertField(24); break;
          case 25: InvertField(25); break;
        }
      }
    }

    private void CountBlacksAndWhites()
    {
      intBlacks = 0;
      intWhites = 0;
      if (intGamesize == 3)
      {
        if (pictureBoxField1.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField1.BackColor == Color.White) intWhites++;
        if (pictureBoxField2.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField2.BackColor == Color.White) intWhites++;
        if (pictureBoxField3.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField3.BackColor == Color.White) intWhites++;
        if (pictureBoxField6.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField6.BackColor == Color.White) intWhites++;
        if (pictureBoxField7.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField7.BackColor == Color.White) intWhites++;
        if (pictureBoxField8.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField8.BackColor == Color.White) intWhites++;
        if (pictureBoxField11.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField11.BackColor == Color.White) intWhites++;
        if (pictureBoxField12.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField12.BackColor == Color.White) intWhites++;
        if (pictureBoxField13.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField13.BackColor == Color.White) intWhites++;
      }
      else if (intGamesize == 4)
      {
        if (pictureBoxField1.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField1.BackColor == Color.White) intWhites++;
        if (pictureBoxField2.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField2.BackColor == Color.White) intWhites++;
        if (pictureBoxField3.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField3.BackColor == Color.White) intWhites++;
        if (pictureBoxField4.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField4.BackColor == Color.White) intWhites++;
        if (pictureBoxField6.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField6.BackColor == Color.White) intWhites++;
        if (pictureBoxField7.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField7.BackColor == Color.White) intWhites++;
        if (pictureBoxField8.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField8.BackColor == Color.White) intWhites++;
        if (pictureBoxField9.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField9.BackColor == Color.White) intWhites++;
        if (pictureBoxField11.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField11.BackColor == Color.White) intWhites++;
        if (pictureBoxField12.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField12.BackColor == Color.White) intWhites++;
        if (pictureBoxField13.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField13.BackColor == Color.White) intWhites++;
        if (pictureBoxField14.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField14.BackColor == Color.White) intWhites++;
        if (pictureBoxField16.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField16.BackColor == Color.White) intWhites++;
        if (pictureBoxField17.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField17.BackColor == Color.White) intWhites++;
        if (pictureBoxField18.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField18.BackColor == Color.White) intWhites++;
        if (pictureBoxField19.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField19.BackColor == Color.White) intWhites++;
      }
      if (intGamesize == 5)
      {
        if (pictureBoxField1.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField1.BackColor == Color.White) intWhites++;
        if (pictureBoxField2.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField2.BackColor == Color.White) intWhites++;
        if (pictureBoxField3.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField3.BackColor == Color.White) intWhites++;
        if (pictureBoxField4.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField4.BackColor == Color.White) intWhites++;
        if (pictureBoxField5.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField5.BackColor == Color.White) intWhites++;
        if (pictureBoxField6.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField6.BackColor == Color.White) intWhites++;
        if (pictureBoxField7.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField7.BackColor == Color.White) intWhites++;
        if (pictureBoxField8.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField8.BackColor == Color.White) intWhites++;
        if (pictureBoxField9.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField9.BackColor == Color.White) intWhites++;
        if (pictureBoxField10.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField10.BackColor == Color.White) intWhites++;
        if (pictureBoxField11.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField11.BackColor == Color.White) intWhites++;
        if (pictureBoxField12.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField12.BackColor == Color.White) intWhites++;
        if (pictureBoxField13.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField13.BackColor == Color.White) intWhites++;
        if (pictureBoxField14.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField14.BackColor == Color.White) intWhites++;
        if (pictureBoxField15.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField15.BackColor == Color.White) intWhites++;
        if (pictureBoxField16.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField16.BackColor == Color.White) intWhites++;
        if (pictureBoxField17.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField17.BackColor == Color.White) intWhites++;
        if (pictureBoxField18.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField18.BackColor == Color.White) intWhites++;
        if (pictureBoxField19.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField19.BackColor == Color.White) intWhites++;
        if (pictureBoxField20.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField20.BackColor == Color.White) intWhites++;
        if (pictureBoxField21.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField21.BackColor == Color.White) intWhites++;
        if (pictureBoxField22.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField22.BackColor == Color.White) intWhites++;
        if (pictureBoxField23.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField23.BackColor == Color.White) intWhites++;
        if (pictureBoxField24.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField24.BackColor == Color.White) intWhites++;
        if (pictureBoxField25.BackColor == Color.Black) intBlacks++;
        else if (pictureBoxField25.BackColor == Color.White) intWhites++;
      }
      labelBlacks.Text = "Blacks: " + intBlacks;
      labelWhites.Text = "Whites: " + intWhites;
    }

    private void setStatusbarText(String str)
    {
      toolStripStatusLabel.Text = str;
    }

    private void clearStatusbar()
    {
      setStatusbarText("");
    }

    private String getBackcolorInGerman(PictureBox picBox)
    {
      String str = "???";
      if (picBox.BackColor == Color.Black) str = "schwarz"; else if (picBox.BackColor == Color.White) str = "weiß";
      return str;
    }

    private void Black_n_WhiteForm_Load(object sender, EventArgs e)
    {
      InitializeGame();
      clearStatusbar();
    }

    private void pictureBoxField1_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(1);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(2, 6);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(2, 6, 7);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField1.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField1));
      CheckIfWinning();
    }

    private void pictureBoxField2_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(2);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(1, 3, 7);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(6, 8);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(1, 3, 6, 7, 8);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField2.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField2));
      CheckIfWinning();
    }

    private void pictureBoxField3_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(3);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(2, 4, 8);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(7, 9);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(2, 4, 7, 8, 9);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField3.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField3));
      CheckIfWinning();
    }

    private void pictureBoxField4_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(4);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(3, 5, 9);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(8, 10);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(3, 5, 8, 9, 10);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField4.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField4));
      CheckIfWinning();
    }

    private void pictureBoxField5_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(5);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(4, 10);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(9);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(4, 9, 10);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField5.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField5));
      CheckIfWinning();
    }

    private void pictureBoxField6_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(6);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(1, 7, 11);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(2, 12);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(1, 2, 7, 11, 12);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField6.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField6));
      CheckIfWinning();
    }

    private void pictureBoxField7_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(7);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(2, 6, 8, 12);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(1, 3, 11, 13);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(1, 2, 3, 6, 8, 11, 12, 13);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField7.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField7));
      CheckIfWinning();
    }

    private void pictureBoxField8_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(8);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(3, 7, 9, 13);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(2, 4, 12, 14);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(2, 3, 4, 7, 9, 12, 13, 14);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField8.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField8));
      CheckIfWinning();
    }

    private void pictureBoxField9_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(9);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(4, 8, 10, 14);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(3, 5, 13, 15);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(3, 4, 5, 8, 10, 13, 14, 15);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField9.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField9));
      CheckIfWinning();
    }

    private void pictureBoxField10_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(10);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(5, 9, 15);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(4, 14);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(4, 5, 9, 14, 15);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField10.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField10));
      CheckIfWinning();
    }

    private void pictureBoxField11_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(11);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(6, 12, 16);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(7, 17);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(6, 7, 12, 16, 17);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField11.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField11));
      CheckIfWinning();
    }

    private void pictureBoxField12_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(12);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(7, 11, 13, 17);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(6, 8, 16, 18);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(6, 7, 11, 13, 16, 17, 18);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField12.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField12));
      CheckIfWinning();
    }

    private void pictureBoxField13_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(13);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(8, 12, 14, 18);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(7, 9, 17, 19);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(7, 8, 9, 12, 14, 17, 18, 19);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField13.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField13));
      CheckIfWinning();
    }

    private void pictureBoxField14_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(14);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(9, 13, 15, 19);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(8, 10, 18, 20);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(8, 9, 10, 13, 15, 18, 19, 20);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField14.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField14));
      CheckIfWinning();
    }

    private void pictureBoxField15_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(15);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(10, 14, 20);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(9, 19);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(9, 10, 14, 19, 20);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField15.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField15));
      CheckIfWinning();
    }

    private void pictureBoxField16_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(16);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(11, 17, 21);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(12, 22);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(11, 12, 17, 21, 22);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField16.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField16));
      CheckIfWinning();
    }

    private void pictureBoxField17_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(17);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(12, 16, 18, 22);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(11, 13, 21, 23);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(11, 12, 13, 16, 18, 21, 22, 23);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField17.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField17));
      CheckIfWinning();
    }

    private void pictureBoxField18_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(18);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(13, 17, 19, 23);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(12, 14, 22, 24);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(12, 13, 14, 17, 19, 22, 23, 24);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField18.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField18));
      CheckIfWinning();
    }

    private void pictureBoxField19_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(19);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(14, 18, 20, 24);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(13, 15, 23, 25);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(13, 14, 15, 18, 20, 23, 24, 25);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField19.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField19));
      CheckIfWinning();
    }

    private void pictureBoxField20_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(20);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(15, 19, 25);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(14, 24);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(14, 15, 19, 24, 25);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField20.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField20));
      CheckIfWinning();
    }

    private void pictureBoxField21_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(21);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(16, 22);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(17);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(16, 17, 22);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField21.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField21));
      CheckIfWinning();
    }

    private void pictureBoxField22_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(22);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(17, 21, 23);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(16, 18);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(16, 17, 18, 21, 23);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField22.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField22));
      CheckIfWinning();
    }

    private void pictureBoxField23_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(23);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(18, 22, 24);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(17, 19);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(17, 18, 19, 22, 24);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField23.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField23));
      CheckIfWinning();
    }

    private void pictureBoxField24_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(24);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(19, 23, 25);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertFields(18, 20);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(18, 19, 20, 23, 25);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField24.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField24));
      CheckIfWinning();
    }

    private void pictureBoxField25_Click(object sender, EventArgs e)
    {
      CheckIfTimerIsEnabled();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(25);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertFields(20, 24);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(19);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertFields(19, 20, 24);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      setStatusbarText(pictureBoxField25.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField25));
      CheckIfWinning();
    }

    private void buttonNewGame_Click(object sender, EventArgs e)
    {
      InitializeGame();
      CountBlacksAndWhites();
      boolIsGameRunning = false;
      buttonNewGameSize.Enabled = true;
      buttonOptions.Enabled = true;
    }

    private void buttonGameConcept_Click(object sender, EventArgs e)
    {
      timer.Stop();
      AboutBoxForm formAboutBox = new AboutBoxForm();
      formAboutBox.ShowDialog();
      if (boolIsGameRunning == true)
      {
        timer.Start();
      } 
    }

    private void buttonQuitGame_Click(object sender, EventArgs e)
    {
      timer.Stop();
      string message = "Willst Du das Spiel wirklich beenden?";
      string caption = "Spiel beenden";
      MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result;
      result = MessageBox.Show(message, caption, buttons);
      if (result == DialogResult.Yes)
      {
        this.Close();
      }
      if (boolIsGameRunning == true)
      {
        timer.Start();
      }
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      intTicks++;
      labelTicks.Text = "Ticks: " + intTicks;
    }

    private void buttonNewGameSize_Click(object sender, EventArgs e)
    {
      contextMenuStripGamesize.Show(buttonNewGameSize, 0, buttonNewGameSize.Size.Height);
    }

    private void toolStripMenuItemGamesize3x3_Click(object sender, EventArgs e)
    {
      intGamesize = 3;
      toolStripMenuItemGamesize3x3.Checked = true;
      toolStripMenuItemGamesize4x4.Checked = false;
      toolStripMenuItemGamesize5x5.Checked = false;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      HideFields(4, 5, 9, 10, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
      CountBlacksAndWhites();
    }

    private void toolStripMenuItemGamesize4x4_Click(object sender, EventArgs e)
    {
      intGamesize = 4;
      toolStripMenuItemGamesize3x3.Checked = false;
      toolStripMenuItemGamesize4x4.Checked = true;
      toolStripMenuItemGamesize5x5.Checked = false;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      ShowFields(4, 9, 14, 16, 17, 18, 19);
      HideFields(5, 10, 15, 20, 21, 22, 23, 24, 25);
      CountBlacksAndWhites();
    }

    private void toolStripMenuItemGamesize5x5_Click(object sender, EventArgs e)
    {
      intGamesize = 5;
      toolStripMenuItemGamesize3x3.Checked = false;
      toolStripMenuItemGamesize4x4.Checked = false;
      toolStripMenuItemGamesize5x5.Checked = true;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      ShowFields(4, 5, 9, 10, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
      CountBlacksAndWhites();
    }

    private void buttonOptions_Click(object sender, EventArgs e)
    {
      contextMenuStripNeighbourhood.Show(buttonOptions, 0, buttonOptions.Size.Height);
    }

    private void toolStripMenuItemNeighbourhoodLinear_Click(object sender, EventArgs e)
    {
      toolStripMenuItemNeighbourhoodLinear.Checked = true;
      toolStripMenuItemNeighbourhoodDiagonal.Checked = false;
      toolStripMenuItemNeighbourhoodCombined.Checked = false;
    }

    private void toolStripMenuItemNeighbourhoodDiagonal_Click(object sender, EventArgs e)
    {
      toolStripMenuItemNeighbourhoodLinear.Checked = false;
      toolStripMenuItemNeighbourhoodDiagonal.Checked = true;
      toolStripMenuItemNeighbourhoodCombined.Checked = false;
    }

    private void toolStripMenuItemNeighbourhoodCombined_Click(object sender, EventArgs e)
    {
      toolStripMenuItemNeighbourhoodLinear.Checked = false;
      toolStripMenuItemNeighbourhoodDiagonal.Checked = false;
      toolStripMenuItemNeighbourhoodCombined.Checked = true;
    }

    private void pictureBoxField1_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField1.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField1));
    }

    private void pictureBoxField2_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField2.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField2));
    }

    private void pictureBoxField3_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField3.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField3));
    }

    private void pictureBoxField4_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField4.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField4));
    }

    private void pictureBoxField5_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField5.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField5));
    }

    private void pictureBoxField6_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField6.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField6));
    }

    private void pictureBoxField7_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField7.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField7));
    }

    private void pictureBoxField8_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField8.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField8));
    }

    private void pictureBoxField9_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField9.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField9));
    }

    private void pictureBoxField10_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField10.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField10));
    }

    private void pictureBoxField11_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField11.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField11));
    }

    private void pictureBoxField12_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField12.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField12));
    }

    private void pictureBoxField13_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField13.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField13));
    }

    private void pictureBoxField14_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField14.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField14));
    }

    private void pictureBoxField15_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField15.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField15));
    }

    private void pictureBoxField16_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField16.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField16));
    }

    private void pictureBoxField17_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField17.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField17));
    }

    private void pictureBoxField18_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField18.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField18));
    }

    private void pictureBoxField19_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField19.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField19));
    }

    private void pictureBoxField20_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField20.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField20));
    }

    private void pictureBoxField21_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField21.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField21));
    }

    private void pictureBoxField22_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField22.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField22));
    }

    private void pictureBoxField23_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField23.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField23));
    }

    private void pictureBoxField24_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField24.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField24));
    }

    private void pictureBoxField25_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(pictureBoxField25.AccessibleName + Colon + Space + getBackcolorInGerman(pictureBoxField25));
    }

    private void pictureBoxField1_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField2_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField3_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField4_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField5_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField6_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField7_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField8_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField9_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField10_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField11_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField12_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField13_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField14_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField15_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField16_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField17_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField18_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField19_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField20_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField21_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField22_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField23_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField24_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void pictureBoxField25_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      clearStatusbar();
    }

    private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      clearStatusbar();
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      clearStatusbar();
    }

    private void buttonNewGame_Enter(object sender, EventArgs e)
    {
      setStatusbarText(buttonNewGame.AccessibleDescription);
    }

    private void buttonNewGameSize_Enter(object sender, EventArgs e)
    {
      setStatusbarText(buttonNewGameSize.AccessibleDescription);
    }

    private void buttonOptions_Enter(object sender, EventArgs e)
    {
      setStatusbarText(buttonOptions.AccessibleDescription);
    }

    private void buttonGameConcept_Enter(object sender, EventArgs e)
    {
      setStatusbarText(buttonGameConcept.AccessibleDescription);
    }

    private void buttonQuitGame_Enter(object sender, EventArgs e)
    {
      setStatusbarText(buttonQuitGame.AccessibleDescription);
    }

    private void labelGamesize_Enter(object sender, EventArgs e)
    {
      setStatusbarText(labelGamesize.AccessibleDescription);
    }

    private void labelClicks_Enter(object sender, EventArgs e)
    {
      setStatusbarText(labelClicks.AccessibleDescription);
    }

    private void labelTicks_Enter(object sender, EventArgs e)
    {
      setStatusbarText(labelTicks.AccessibleDescription);
    }

    private void labelBlacks_Enter(object sender, EventArgs e)
    {
      setStatusbarText(labelBlacks.AccessibleDescription);
    }

    private void labelWhites_Enter(object sender, EventArgs e)
    {
      setStatusbarText(labelWhites.AccessibleDescription);
    }

    private void buttonNewGame_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(buttonNewGame.AccessibleDescription);
    }

    private void buttonNewGameSize_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(buttonNewGameSize.AccessibleDescription);
    }

    private void buttonOptions_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(buttonOptions.AccessibleDescription);
    }

    private void buttonGameConcept_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(buttonGameConcept.AccessibleDescription);
    }

    private void buttonQuitGame_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(buttonQuitGame.AccessibleDescription);
    }

    private void labelGamesize_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(labelGamesize.AccessibleDescription);
    }

    private void labelClicks_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(labelClicks.AccessibleDescription);
    }

    private void labelTicks_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(labelTicks.AccessibleDescription);
    }

    private void labelBlacks_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(labelBlacks.AccessibleDescription);
    }

    private void labelWhites_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(labelWhites.AccessibleDescription);
    }

    private void buttonNewGame_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonNewGameSize_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonOptions_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonGameConcept_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonQuitGame_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelGamesize_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelClicks_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelTicks_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelBlacks_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelWhites_Leave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonNewGame_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonNewGameSize_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonOptions_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonGameConcept_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void buttonQuitGame_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelGamesize_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelClicks_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelTicks_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelBlacks_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void labelWhites_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void contextMenuStripGamesize_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(contextMenuStripGamesize.AccessibleDescription);
    }

    private void toolStripMenuItemGamesize3x3_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemGamesize3x3.AccessibleDescription);
    }
 
    private void toolStripMenuItemGamesize4x4_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemGamesize4x4.AccessibleDescription);
    }

    private void toolStripMenuItemGamesize5x5_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemGamesize5x5.AccessibleDescription);
    }

    private void contextMenuStripNeighbourhood_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(contextMenuStripNeighbourhood.AccessibleDescription);
    }

    private void toolStripMenuItemNeighbourhoodLinear_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemNeighbourhoodLinear.AccessibleDescription);
    }

    private void toolStripMenuItemNeighbourhoodDiagonal_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemNeighbourhoodDiagonal.AccessibleDescription);
    }

    private void toolStripMenuItemNeighbourhoodCombined_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemNeighbourhoodCombined.AccessibleDescription);
    }

    private void toolStripMenuItemNeighbourhoodCentered_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemNeighbourhoodCentered.AccessibleDescription);
    }
                                       
    private void toolStripSeparator1_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripSeparator1.AccessibleDescription);
    }

    private void contextMenuStripGamesize_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripMenuItemGamesize3x3_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripMenuItemGamesize4x4_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripMenuItemGamesize5x5_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void contextMenuStripNeighbourhood_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripMenuItemNeighbourhoodLinear_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripMenuItemNeighbourhoodDiagonal_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripMenuItemNeighbourhoodCombined_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripMenuItemNeighbourhoodCentered_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripSeparator1_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }
  }
}
