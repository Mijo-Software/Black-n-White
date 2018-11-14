using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Black_n_White
{
  public partial class Black_n_WhiteForm : Form
  {
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

    private void CheckForEnabledTimer()
    {
      if (!boolFirstClickDone)
      {
        boolFirstClickDone = true;
        timer.Enabled = true;
      }
    }

    private void InitializeGame()
    {
      Random rnd = new Random();
      int r = 0;
      intTicks = 0;
      intClicks = 0;
      intBlacks = 0;
      intWhites = 0;

      r = rnd.Next();
      if (r % 2 == 0) buttonField1.BackColor = Color.Black; else buttonField1.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField2.BackColor = Color.Black; else buttonField2.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField3.BackColor = Color.Black; else buttonField3.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField4.BackColor = Color.Black; else buttonField4.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField5.BackColor = Color.Black; else buttonField5.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField6.BackColor = Color.Black; else buttonField6.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField7.BackColor = Color.Black; else buttonField7.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField8.BackColor = Color.Black; else buttonField8.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField9.BackColor = Color.Black; else buttonField9.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField10.BackColor = Color.Black; else buttonField10.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField11.BackColor = Color.Black; else buttonField11.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField12.BackColor = Color.Black; else buttonField12.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField13.BackColor = Color.Black; else buttonField13.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField14.BackColor = Color.Black; else buttonField14.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField15.BackColor = Color.Black; else buttonField15.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField16.BackColor = Color.Black; else buttonField16.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField17.BackColor = Color.Black; else buttonField17.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField18.BackColor = Color.Black; else buttonField18.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField19.BackColor = Color.Black; else buttonField19.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField20.BackColor = Color.Black; else buttonField20.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField21.BackColor = Color.Black; else buttonField21.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField22.BackColor = Color.Black; else buttonField22.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField23.BackColor = Color.Black; else buttonField23.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField24.BackColor = Color.Black; else buttonField24.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) buttonField25.BackColor = Color.Black; else buttonField25.BackColor = Color.White;

      if (intGamesize == 3)
      {
        buttonField4.Hide();
        buttonField5.Hide();
        buttonField9.Hide();
        buttonField10.Hide();
        buttonField14.Hide();
        buttonField15.Hide();
        buttonField16.Hide();
        buttonField17.Hide();
        buttonField18.Hide();
        buttonField19.Hide();
        buttonField20.Hide();
        buttonField21.Hide();
        buttonField22.Hide();
        buttonField23.Hide();
        buttonField24.Hide();
        buttonField25.Hide();
      }
      else if (intGamesize == 4)
      {
        buttonField4.Show();
        buttonField5.Hide();
        buttonField9.Show();
        buttonField10.Hide();
        buttonField14.Show();
        buttonField15.Hide();
        buttonField16.Show();
        buttonField17.Show();
        buttonField18.Show();
        buttonField19.Show();
        buttonField20.Hide();
        buttonField21.Hide();
        buttonField22.Hide();
        buttonField23.Hide();
        buttonField24.Hide();
        buttonField25.Hide();
      }
      else if (intGamesize == 5)
      {
        buttonField4.Show();
        buttonField5.Show();
        buttonField9.Show();
        buttonField10.Show();
        buttonField14.Show();
        buttonField15.Show();
        buttonField16.Show();
        buttonField17.Show();
        buttonField18.Show();
        buttonField19.Show();
        buttonField20.Show();
        buttonField21.Show();
        buttonField22.Show();
        buttonField23.Show();
        buttonField24.Show();
        buttonField25.Show();
      }

      labelClicks.Text = "Klicks: " + intClicks;
      labelTicks.Text = "Ticks: " + intTicks;
      CountBlacksAndWhites();
      boolFirstClickDone = false;
      timer.Enabled = false;
    }

    private void CheckForWin()
    {
      if (intGamesize == 3)
      {
        if (
          (buttonField1.BackColor == Color.Black &&
          buttonField2.BackColor == Color.Black &&
          buttonField3.BackColor == Color.Black &&
          buttonField6.BackColor == Color.Black &&
          buttonField7.BackColor == Color.Black &&
          buttonField8.BackColor == Color.Black &&
          buttonField11.BackColor == Color.Black &&
          buttonField12.BackColor == Color.Black &&
          buttonField13.BackColor == Color.Black) ||
          (buttonField1.BackColor == Color.White &&
          buttonField2.BackColor == Color.White &&
          buttonField3.BackColor == Color.White &&
          buttonField6.BackColor == Color.White &&
          buttonField7.BackColor == Color.White &&
          buttonField8.BackColor == Color.White &&
          buttonField11.BackColor == Color.White &&
          buttonField12.BackColor == Color.White &&
          buttonField13.BackColor == Color.White)
        )
        {
          timer.Stop();
          string message = "Du hast gewonnen mit " + intClicks + " Klicks in " + intTicks + " Ticks.";
          string caption = "Gewonnen";
          MessageBoxButtons buttons = MessageBoxButtons.OK;
          DialogResult result;
          result = MessageBox.Show(message, caption, buttons);
          InitializeGame();
          boolIsGameRunning = false;
          buttonNewGamesize.Enabled = true;
          buttonOptions.Enabled = true;
        }
      }
      else if (intGamesize == 4)
      {
        if (
          (buttonField1.BackColor == Color.Black &&
          buttonField2.BackColor == Color.Black &&
          buttonField3.BackColor == Color.Black &&
          buttonField4.BackColor == Color.Black &&
          buttonField6.BackColor == Color.Black &&
          buttonField7.BackColor == Color.Black &&
          buttonField8.BackColor == Color.Black &&
          buttonField9.BackColor == Color.Black &&
          buttonField11.BackColor == Color.Black &&
          buttonField12.BackColor == Color.Black &&
          buttonField13.BackColor == Color.Black &&
          buttonField14.BackColor == Color.Black &&
          buttonField16.BackColor == Color.Black &&
          buttonField17.BackColor == Color.Black &&
          buttonField18.BackColor == Color.Black &&
          buttonField19.BackColor == Color.Black) ||
          (buttonField1.BackColor == Color.White &&
          buttonField2.BackColor == Color.White &&
          buttonField3.BackColor == Color.White &&
          buttonField4.BackColor == Color.White &&
          buttonField6.BackColor == Color.White &&
          buttonField7.BackColor == Color.White &&
          buttonField8.BackColor == Color.White &&
          buttonField9.BackColor == Color.White &&
          buttonField11.BackColor == Color.White &&
          buttonField12.BackColor == Color.White &&
          buttonField13.BackColor == Color.White &&
          buttonField14.BackColor == Color.White &&
          buttonField16.BackColor == Color.White &&
          buttonField17.BackColor == Color.White &&
          buttonField18.BackColor == Color.White &&
          buttonField19.BackColor == Color.White)
        )
        {
          timer.Stop();
          string message = "Du hast gewonnen mit " + intClicks + " Klicks in " + intTicks + " Ticks.";
          string caption = "Gewonnen";
          MessageBoxButtons buttons = MessageBoxButtons.OK;
          DialogResult result;
          result = MessageBox.Show(message, caption, buttons);
          InitializeGame();
          boolIsGameRunning = false;
          buttonNewGamesize.Enabled = true;
          buttonOptions.Enabled = true;
        }
      }
      if (intGamesize == 5)
      {
        if (
          (buttonField1.BackColor == Color.Black &&
          buttonField2.BackColor == Color.Black &&
          buttonField3.BackColor == Color.Black &&
          buttonField4.BackColor == Color.Black &&
          buttonField5.BackColor == Color.Black &&
          buttonField6.BackColor == Color.Black &&
          buttonField7.BackColor == Color.Black &&
          buttonField8.BackColor == Color.Black &&
          buttonField9.BackColor == Color.Black &&
          buttonField10.BackColor == Color.Black &&
          buttonField11.BackColor == Color.Black &&
          buttonField12.BackColor == Color.Black &&
          buttonField13.BackColor == Color.Black &&
          buttonField14.BackColor == Color.Black &&
          buttonField15.BackColor == Color.Black &&
          buttonField16.BackColor == Color.Black &&
          buttonField17.BackColor == Color.Black &&
          buttonField18.BackColor == Color.Black &&
          buttonField19.BackColor == Color.Black &&
          buttonField20.BackColor == Color.Black &&
          buttonField21.BackColor == Color.Black &&
          buttonField22.BackColor == Color.Black &&
          buttonField23.BackColor == Color.Black &&
          buttonField24.BackColor == Color.Black &&
          buttonField25.BackColor == Color.Black) ||
          (buttonField1.BackColor == Color.White &&
          buttonField2.BackColor == Color.White &&
          buttonField3.BackColor == Color.White &&
          buttonField4.BackColor == Color.White &&
          buttonField5.BackColor == Color.White &&
          buttonField6.BackColor == Color.White &&
          buttonField7.BackColor == Color.White &&
          buttonField8.BackColor == Color.White &&
          buttonField9.BackColor == Color.White &&
          buttonField10.BackColor == Color.White &&
          buttonField11.BackColor == Color.White &&
          buttonField12.BackColor == Color.White &&
          buttonField13.BackColor == Color.White &&
          buttonField14.BackColor == Color.White &&
          buttonField15.BackColor == Color.White &&
          buttonField16.BackColor == Color.White &&
          buttonField17.BackColor == Color.White &&
          buttonField18.BackColor == Color.White &&
          buttonField19.BackColor == Color.White &&
          buttonField20.BackColor == Color.White &&
          buttonField21.BackColor == Color.White &&
          buttonField22.BackColor == Color.White &&
          buttonField23.BackColor == Color.White &&
          buttonField24.BackColor == Color.White &&
          buttonField25.BackColor == Color.White)
        )
        {
          timer.Stop();
          string message = "Du hast gewonnen mit " + intClicks + " Klicks in " + intTicks + " Ticks.";
          string caption = "Gewonnen";
          MessageBoxButtons buttons = MessageBoxButtons.OK;
          DialogResult result;
          result = MessageBox.Show(message, caption, buttons);
          InitializeGame();
          boolIsGameRunning = false;
          buttonNewGamesize.Enabled = true;
          buttonOptions.Enabled = true;
        }
      }
    }

    private void CheckForGameIsRunning()
    {
      if (boolIsGameRunning == false)
      {
        boolIsGameRunning = true;
        buttonNewGamesize.Enabled = false;
        buttonOptions.Enabled = false;
      }
    }

    private void InvertField(byte n)
    {
      switch (n)
      {
        case 1:
          {
            if (buttonField1.BackColor == Color.Black) buttonField1.BackColor = Color.White;
            else if (buttonField1.BackColor == Color.White) buttonField1.BackColor = Color.Black;
            break;
          }
        case 2:
          {
            if (buttonField2.BackColor == Color.Black) buttonField2.BackColor = Color.White;
            else if (buttonField2.BackColor == Color.White) buttonField2.BackColor = Color.Black;
            break;
          }
        case 3:
          {
            if (buttonField3.BackColor == Color.Black) buttonField3.BackColor = Color.White;
            else if (buttonField3.BackColor == Color.White) buttonField3.BackColor = Color.Black;
            break;
          }
        case 4:
          {
            if (buttonField4.BackColor == Color.Black) buttonField4.BackColor = Color.White;
            else if (buttonField4.BackColor == Color.White) buttonField4.BackColor = Color.Black;
            break;
          }
        case 5:
          {
            if (buttonField5.BackColor == Color.Black) buttonField5.BackColor = Color.White;
            else if (buttonField5.BackColor == Color.White) buttonField5.BackColor = Color.Black;
            break;
          }
        case 6:
          {
            if (buttonField6.BackColor == Color.Black) buttonField6.BackColor = Color.White;
            else if (buttonField6.BackColor == Color.White) buttonField6.BackColor = Color.Black;
            break;
          }
        case 7:
          {
            if (buttonField7.BackColor == Color.Black) buttonField7.BackColor = Color.White;
            else if (buttonField7.BackColor == Color.White) buttonField7.BackColor = Color.Black;
            break;
          }
        case 8:
          {
            if (buttonField8.BackColor == Color.Black) buttonField8.BackColor = Color.White;
            else if (buttonField8.BackColor == Color.White) buttonField8.BackColor = Color.Black;
            break;
          }
        case 9:
          {
            if (buttonField9.BackColor == Color.Black) buttonField9.BackColor = Color.White;
            else if (buttonField9.BackColor == Color.White) buttonField9.BackColor = Color.Black;
            break;
          }
        case 10:
          {
            if (buttonField10.BackColor == Color.Black) buttonField10.BackColor = Color.White;
            else if (buttonField10.BackColor == Color.White) buttonField10.BackColor = Color.Black;
            break;
          }
        case 11:
          {
            if (buttonField11.BackColor == Color.Black) buttonField11.BackColor = Color.White;
            else if (buttonField11.BackColor == Color.White) buttonField11.BackColor = Color.Black;
            break;
          }
        case 12:
          {
            if (buttonField12.BackColor == Color.Black) buttonField12.BackColor = Color.White;
            else if (buttonField12.BackColor == Color.White) buttonField12.BackColor = Color.Black;
            break;
          }
        case 13:
          {
            if (buttonField13.BackColor == Color.Black) buttonField13.BackColor = Color.White;
            else if (buttonField13.BackColor == Color.White) buttonField13.BackColor = Color.Black;
            break;
          }
        case 14:
          {
            if (buttonField14.BackColor == Color.Black) buttonField14.BackColor = Color.White;
            else if (buttonField14.BackColor == Color.White) buttonField14.BackColor = Color.Black;
            break;
          }
        case 15:
          {
            if (buttonField15.BackColor == Color.Black) buttonField15.BackColor = Color.White;
            else if (buttonField15.BackColor == Color.White) buttonField15.BackColor = Color.Black;
            break;
          }
        case 16:
          {
            if (buttonField16.BackColor == Color.Black) buttonField16.BackColor = Color.White;
            else if (buttonField16.BackColor == Color.White) buttonField16.BackColor = Color.Black;
            break;
          }
        case 17:
          {
            if (buttonField17.BackColor == Color.Black) buttonField17.BackColor = Color.White;
            else if (buttonField17.BackColor == Color.White) buttonField17.BackColor = Color.Black;
            break;
          }
        case 18:
          {
            if (buttonField18.BackColor == Color.Black) buttonField18.BackColor = Color.White;
            else if (buttonField18.BackColor == Color.White) buttonField18.BackColor = Color.Black;
            break;
          }
        case 19:
          {
            if (buttonField19.BackColor == Color.Black) buttonField19.BackColor = Color.White;
            else if (buttonField19.BackColor == Color.White) buttonField19.BackColor = Color.Black;
            break;
          }
        case 20:
          {
            if (buttonField20.BackColor == Color.Black) buttonField20.BackColor = Color.White;
            else if (buttonField20.BackColor == Color.White) buttonField20.BackColor = Color.Black;
            break;
          }
        case 21:
          {
            if (buttonField21.BackColor == Color.Black) buttonField21.BackColor = Color.White;
            else if (buttonField21.BackColor == Color.White) buttonField21.BackColor = Color.Black;
            break;
          }
        case 22:
          {
            if (buttonField22.BackColor == Color.Black) buttonField22.BackColor = Color.White;
            else if (buttonField22.BackColor == Color.White) buttonField22.BackColor = Color.Black;
            break;
          }
        case 23:
          {
            if (buttonField23.BackColor == Color.Black) buttonField23.BackColor = Color.White;
            else if (buttonField23.BackColor == Color.White) buttonField23.BackColor = Color.Black;
            break;
          }
        case 24:
          {
            if (buttonField24.BackColor == Color.Black) buttonField24.BackColor = Color.White;
            else if (buttonField24.BackColor == Color.White) buttonField24.BackColor = Color.Black;
            break;
          }
        case 25:
          {
            if (buttonField25.BackColor == Color.Black) buttonField25.BackColor = Color.White;
            else if (buttonField25.BackColor == Color.White) buttonField25.BackColor = Color.Black;
            break;
          }
      }
    }

    private void CountBlacksAndWhites()
    {
      intBlacks = 0;
      intWhites = 0;
      if (intGamesize == 3)
      {
        if (buttonField1.BackColor == Color.Black) intBlacks++;
        else if (buttonField1.BackColor == Color.White) intWhites++;
        if (buttonField2.BackColor == Color.Black) intBlacks++;
        else if (buttonField2.BackColor == Color.White) intWhites++;
        if (buttonField3.BackColor == Color.Black) intBlacks++;
        else if (buttonField3.BackColor == Color.White) intWhites++;
        if (buttonField6.BackColor == Color.Black) intBlacks++;
        else if (buttonField6.BackColor == Color.White) intWhites++;
        if (buttonField7.BackColor == Color.Black) intBlacks++;
        else if (buttonField7.BackColor == Color.White) intWhites++;
        if (buttonField8.BackColor == Color.Black) intBlacks++;
        else if (buttonField8.BackColor == Color.White) intWhites++;
        if (buttonField11.BackColor == Color.Black) intBlacks++;
        else if (buttonField11.BackColor == Color.White) intWhites++;
        if (buttonField12.BackColor == Color.Black) intBlacks++;
        else if (buttonField12.BackColor == Color.White) intWhites++;
        if (buttonField13.BackColor == Color.Black) intBlacks++;
        else if (buttonField13.BackColor == Color.White) intWhites++;
      }
      else if (intGamesize == 4)
      {
        if (buttonField1.BackColor == Color.Black) intBlacks++;
        else if (buttonField1.BackColor == Color.White) intWhites++;
        if (buttonField2.BackColor == Color.Black) intBlacks++;
        else if (buttonField2.BackColor == Color.White) intWhites++;
        if (buttonField3.BackColor == Color.Black) intBlacks++;
        else if (buttonField3.BackColor == Color.White) intWhites++;
        if (buttonField4.BackColor == Color.Black) intBlacks++;
        else if (buttonField4.BackColor == Color.White) intWhites++;
        if (buttonField6.BackColor == Color.Black) intBlacks++;
        else if (buttonField6.BackColor == Color.White) intWhites++;
        if (buttonField7.BackColor == Color.Black) intBlacks++;
        else if (buttonField7.BackColor == Color.White) intWhites++;
        if (buttonField8.BackColor == Color.Black) intBlacks++;
        else if (buttonField8.BackColor == Color.White) intWhites++;
        if (buttonField9.BackColor == Color.Black) intBlacks++;
        else if (buttonField9.BackColor == Color.White) intWhites++;
        if (buttonField11.BackColor == Color.Black) intBlacks++;
        else if (buttonField11.BackColor == Color.White) intWhites++;
        if (buttonField12.BackColor == Color.Black) intBlacks++;
        else if (buttonField12.BackColor == Color.White) intWhites++;
        if (buttonField13.BackColor == Color.Black) intBlacks++;
        else if (buttonField13.BackColor == Color.White) intWhites++;
        if (buttonField14.BackColor == Color.Black) intBlacks++;
        else if (buttonField14.BackColor == Color.White) intWhites++;
        if (buttonField16.BackColor == Color.Black) intBlacks++;
        else if (buttonField16.BackColor == Color.White) intWhites++;
        if (buttonField17.BackColor == Color.Black) intBlacks++;
        else if (buttonField17.BackColor == Color.White) intWhites++;
        if (buttonField18.BackColor == Color.Black) intBlacks++;
        else if (buttonField18.BackColor == Color.White) intWhites++;
        if (buttonField19.BackColor == Color.Black) intBlacks++;
        else if (buttonField19.BackColor == Color.White) intWhites++;
      }
      if (intGamesize == 5)
      {
        if (buttonField1.BackColor == Color.Black) intBlacks++;
        else if (buttonField1.BackColor == Color.White) intWhites++;
        if (buttonField2.BackColor == Color.Black) intBlacks++;
        else if (buttonField2.BackColor == Color.White) intWhites++;
        if (buttonField3.BackColor == Color.Black) intBlacks++;
        else if (buttonField3.BackColor == Color.White) intWhites++;
        if (buttonField4.BackColor == Color.Black) intBlacks++;
        else if (buttonField4.BackColor == Color.White) intWhites++;
        if (buttonField5.BackColor == Color.Black) intBlacks++;
        else if (buttonField5.BackColor == Color.White) intWhites++;
        if (buttonField6.BackColor == Color.Black) intBlacks++;
        else if (buttonField6.BackColor == Color.White) intWhites++;
        if (buttonField7.BackColor == Color.Black) intBlacks++;
        else if (buttonField7.BackColor == Color.White) intWhites++;
        if (buttonField8.BackColor == Color.Black) intBlacks++;
        else if (buttonField8.BackColor == Color.White) intWhites++;
        if (buttonField9.BackColor == Color.Black) intBlacks++;
        else if (buttonField9.BackColor == Color.White) intWhites++;
        if (buttonField10.BackColor == Color.Black) intBlacks++;
        else if (buttonField10.BackColor == Color.White) intWhites++;
        if (buttonField11.BackColor == Color.Black) intBlacks++;
        else if (buttonField11.BackColor == Color.White) intWhites++;
        if (buttonField12.BackColor == Color.Black) intBlacks++;
        else if (buttonField12.BackColor == Color.White) intWhites++;
        if (buttonField13.BackColor == Color.Black) intBlacks++;
        else if (buttonField13.BackColor == Color.White) intWhites++;
        if (buttonField14.BackColor == Color.Black) intBlacks++;
        else if (buttonField14.BackColor == Color.White) intWhites++;
        if (buttonField15.BackColor == Color.Black) intBlacks++;
        else if (buttonField15.BackColor == Color.White) intWhites++;
        if (buttonField16.BackColor == Color.Black) intBlacks++;
        else if (buttonField16.BackColor == Color.White) intWhites++;
        if (buttonField17.BackColor == Color.Black) intBlacks++;
        else if (buttonField17.BackColor == Color.White) intWhites++;
        if (buttonField18.BackColor == Color.Black) intBlacks++;
        else if (buttonField18.BackColor == Color.White) intWhites++;
        if (buttonField19.BackColor == Color.Black) intBlacks++;
        else if (buttonField19.BackColor == Color.White) intWhites++;
        if (buttonField20.BackColor == Color.Black) intBlacks++;
        else if (buttonField20.BackColor == Color.White) intWhites++;
        if (buttonField21.BackColor == Color.Black) intBlacks++;
        else if (buttonField21.BackColor == Color.White) intWhites++;
        if (buttonField22.BackColor == Color.Black) intBlacks++;
        else if (buttonField22.BackColor == Color.White) intWhites++;
        if (buttonField23.BackColor == Color.Black) intBlacks++;
        else if (buttonField23.BackColor == Color.White) intWhites++;
        if (buttonField24.BackColor == Color.Black) intBlacks++;
        else if (buttonField24.BackColor == Color.White) intWhites++;
        if (buttonField25.BackColor == Color.Black) intBlacks++;
        else if (buttonField25.BackColor == Color.White) intWhites++;
      }
      labelBlacks.Text = "Blacks: " + intBlacks;
      labelWhites.Text = "Whites: " + intWhites;
    }

    private void clearStatusbarText()
    {
      toolStripStatusLabel.Text = "";
    }

    private void setStatusbarText(String str)
    {
      toolStripStatusLabel.Text = str;
    }

    private void Black_n_WhiteForm_Load(object sender, EventArgs e)
    {
      InitializeGame();
      clearStatusbarText();
    }

    private void buttonField1_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(1);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(2);
        InvertField(6);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(2);
        InvertField(6);
        InvertField(7);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField1.BackColor == Color.Black) str = "schwarz";
      else if (buttonField1.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x1: " + str);
      CheckForWin();
    }

    private void buttonField2_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(2);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(1);
        InvertField(3);
        InvertField(7);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(6);
        InvertField(8);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(1);
        InvertField(3);
        InvertField(7);
        InvertField(6);
        InvertField(8);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField2.BackColor == Color.Black) str = "schwarz";
      else if (buttonField2.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x2: " + str);
      CheckForWin();
    }

    private void buttonField3_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(3);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(2);
        InvertField(4);
        InvertField(8);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
        InvertField(9);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(2);
        InvertField(4);
        InvertField(8);
        InvertField(7);
        InvertField(9);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField3.BackColor == Color.Black) str = "schwarz";
      else if (buttonField3.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x3: " + str);
      CheckForWin();
    }

    private void buttonField4_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(4);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(3);
        InvertField(5);
        InvertField(9);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(8);
        InvertField(10);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(3);
        InvertField(5);
        InvertField(9);
        InvertField(8);
        InvertField(10);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField4.BackColor == Color.Black) str = "schwarz";
      else if (buttonField4.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x4: " + str);
      CheckForWin();
    }

    private void buttonField5_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(5);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(4);
        InvertField(10);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(9);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(4);
        InvertField(10);
        InvertField(9);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField5.BackColor == Color.Black) str = "schwarz";
      else if (buttonField5.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x5: " + str);
      CheckForWin();
    }

    private void buttonField6_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(6);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(1);
        InvertField(7);
        InvertField(11);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(2);
        InvertField(12);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(1);
        InvertField(7);
        InvertField(11);
        InvertField(2);
        InvertField(12);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField6.BackColor == Color.Black) str = "schwarz";
      else if (buttonField6.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x1: " + str);
      CheckForWin();
    }

    private void buttonField7_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(7);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(2);
        InvertField(6);
        InvertField(8);
        InvertField(12);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(1);
        InvertField(3);
        InvertField(11);
        InvertField(13);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(2);
        InvertField(6);
        InvertField(8);
        InvertField(12);
        InvertField(1);
        InvertField(3);
        InvertField(11);
        InvertField(13);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField7.BackColor == Color.Black) str = "schwarz";
      else if (buttonField7.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x2: " + str);
      CheckForWin();
    }

    private void buttonField8_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(8);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(3);
        InvertField(7);
        InvertField(9);
        InvertField(13);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(2);
        InvertField(4);
        InvertField(12);
        InvertField(14);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(3);
        InvertField(7);
        InvertField(9);
        InvertField(13);
        InvertField(2);
        InvertField(4);
        InvertField(12);
        InvertField(14);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField8.BackColor == Color.Black) str = "schwarz";
      else if (buttonField8.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x3: " + str);
      CheckForWin();
    }

    private void buttonField9_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(9);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(4);
        InvertField(8);
        InvertField(10);
        InvertField(14);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(3);
        InvertField(5);
        InvertField(13);
        InvertField(15);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(4);
        InvertField(8);
        InvertField(10);
        InvertField(14);
        InvertField(3);
        InvertField(5);
        InvertField(13);
        InvertField(15);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField9.BackColor == Color.Black) str = "schwarz";
      else if (buttonField9.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x4: " + str);
      CheckForWin();
    }

    private void buttonField10_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(10);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(5);
        InvertField(9);
        InvertField(15);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(4);
        InvertField(14);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(5);
        InvertField(9);
        InvertField(15);
        InvertField(4);
        InvertField(14);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField10.BackColor == Color.Black) str = "schwarz";
      else if (buttonField10.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x5: " + str);
      CheckForWin();
    }

    private void buttonField11_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(11);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(6);
        InvertField(12);
        InvertField(16);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
        InvertField(17);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(6);
        InvertField(12);
        InvertField(16);
        InvertField(7);
        InvertField(17);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField11.BackColor == Color.Black) str = "schwarz";
      else if (buttonField11.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x1: " + str);
      CheckForWin();
    }

    private void buttonField12_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(12);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(7);
        InvertField(11);
        InvertField(13);
        InvertField(17);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(6);
        InvertField(8);
        InvertField(16);
        InvertField(18);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(7);
        InvertField(11);
        InvertField(13);
        InvertField(17);
        InvertField(6);
        InvertField(8);
        InvertField(16);
        InvertField(18);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField12.BackColor == Color.Black) str = "schwarz";
      else if (buttonField12.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x2: " + str);
      CheckForWin();
    }

    private void buttonField13_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(13);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(8);
        InvertField(12);
        InvertField(14);
        InvertField(18);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
        InvertField(9);
        InvertField(17);
        InvertField(19);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(8);
        InvertField(12);
        InvertField(14);
        InvertField(18);
        InvertField(7);
        InvertField(9);
        InvertField(17);
        InvertField(19);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField13.BackColor == Color.Black) str = "schwarz";
      else if (buttonField13.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x3: " + str);
      CheckForWin();
    }

    private void buttonField14_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(14);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(9);
        InvertField(13);
        InvertField(15);
        InvertField(19);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(8);
        InvertField(10);
        InvertField(18);
        InvertField(20);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(9);
        InvertField(13);
        InvertField(15);
        InvertField(19);
        InvertField(8);
        InvertField(10);
        InvertField(18);
        InvertField(20);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField14.BackColor == Color.Black) str = "schwarz";
      else if (buttonField14.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x4: " + str);
      CheckForWin();
    }

    private void buttonField15_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(15);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(10);
        InvertField(14);
        InvertField(20);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(9);
        InvertField(19);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(10);
        InvertField(14);
        InvertField(20);
        InvertField(9);
        InvertField(19);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField15.BackColor == Color.Black) str = "schwarz";
      else if (buttonField15.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x5: " + str);
      CheckForWin();
    }

    private void buttonField16_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(16);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(11);
        InvertField(17);
        InvertField(21);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(12);
        InvertField(22);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(11);
        InvertField(17);
        InvertField(21);
        InvertField(12);
        InvertField(22);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField16.BackColor == Color.Black) str = "schwarz";
      else if (buttonField16.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x1: " + str);
      CheckForWin();
    }

    private void buttonField17_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(17);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(12);
        InvertField(16);
        InvertField(18);
        InvertField(22);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(11);
        InvertField(13);
        InvertField(21);
        InvertField(23);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(12);
        InvertField(16);
        InvertField(18);
        InvertField(22);
        InvertField(11);
        InvertField(13);
        InvertField(21);
        InvertField(23);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField17.BackColor == Color.Black) str = "schwarz";
      else if (buttonField17.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x2: " + str);
      CheckForWin();
    }

    private void buttonField18_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(18);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(13);
        InvertField(17);
        InvertField(19);
        InvertField(23);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(12);
        InvertField(14);
        InvertField(22);
        InvertField(24);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(13);
        InvertField(17);
        InvertField(19);
        InvertField(23);
        InvertField(12);
        InvertField(14);
        InvertField(22);
        InvertField(24);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField18.BackColor == Color.Black) str = "schwarz";
      else if (buttonField18.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x3: " + str);
      CheckForWin();
    }

    private void buttonField19_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(19);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(14);
        InvertField(18);
        InvertField(20);
        InvertField(24);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(13);
        InvertField(15);
        InvertField(23);
        InvertField(25);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(14);
        InvertField(18);
        InvertField(20);
        InvertField(24);
        InvertField(13);
        InvertField(15);
        InvertField(23);
        InvertField(25);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField19.BackColor == Color.Black) str = "schwarz";
      else if (buttonField19.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x4: " + str);
      CheckForWin();
    }

    private void buttonField20_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(20);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(15);
        InvertField(19);
        InvertField(25);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(14);
        InvertField(24);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(15);
        InvertField(19);
        InvertField(25);
        InvertField(14);
        InvertField(24);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField20.BackColor == Color.Black) str = "schwarz";
      else if (buttonField20.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x5: " + str);
      CheckForWin();
    }

    private void buttonField21_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(21);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(16);
        InvertField(22);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(17);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(16);
        InvertField(22);
        InvertField(17);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField21.BackColor == Color.Black) str = "schwarz";
      else if (buttonField21.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x1: " + str);
      CheckForWin();
    }

    private void buttonField22_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(22);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(17);
        InvertField(21);
        InvertField(23);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(16);
        InvertField(18);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(17);
        InvertField(21);
        InvertField(23);
        InvertField(16);
        InvertField(18);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField22.BackColor == Color.Black) str = "schwarz";
      else if (buttonField22.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x2: " + str);
      CheckForWin();
    }

    private void buttonField23_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(23);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(18);
        InvertField(22);
        InvertField(24);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(17);
        InvertField(19);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(18);
        InvertField(22);
        InvertField(24);
        InvertField(17);
        InvertField(19);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField23.BackColor == Color.Black) str = "schwarz";
      else if (buttonField23.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x3: " + str);
      CheckForWin();
    }

    private void buttonField24_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(24);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(19);
        InvertField(23);
        InvertField(25);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(18);
        InvertField(20);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(19);
        InvertField(23);
        InvertField(25);
        InvertField(18);
        InvertField(20);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField24.BackColor == Color.Black) str = "schwarz";
      else if (buttonField24.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x4: " + str);
      CheckForWin();
    }

    private void buttonField25_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemNeighbourhoodCentered.Checked) InvertField(25);
      if (toolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(20);
        InvertField(24);
      }
      else if (toolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(19);
      }
      else if (toolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(20);
        InvertField(24);
        InvertField(19);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      String str;
      if (buttonField25.BackColor == Color.Black) str = "schwarz";
      else if (buttonField25.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x5: " + str);
      CheckForWin();
    }

    private void buttonNewGame_Click(object sender, EventArgs e)
    {
      InitializeGame();
      CountBlacksAndWhites();
      boolIsGameRunning = false;
      buttonNewGamesize.Enabled = true;
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

    private void ToolStripMenuItemGamesize3x3_Click(object sender, EventArgs e)
    {
      intGamesize = 3;
      toolStripMenuItemGamesize4x4.Checked = false;
      toolStripMenuItemGamesize5x5.Checked = false;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      buttonField4.Hide();
      buttonField5.Hide();
      buttonField9.Hide();
      buttonField10.Hide();
      buttonField14.Hide();
      buttonField15.Hide();
      buttonField16.Hide();
      buttonField17.Hide();
      buttonField18.Hide();
      buttonField19.Hide();
      buttonField20.Hide();
      buttonField21.Hide();
      buttonField22.Hide();
      buttonField23.Hide();
      buttonField24.Hide();
      buttonField25.Hide();
      CountBlacksAndWhites();
    }

    private void ToolStripMenuItemGamesize4x4_Click(object sender, EventArgs e)
    {
      intGamesize = 4;
      toolStripMenuItemGamesize3x3.Checked = false;
      toolStripMenuItemGamesize5x5.Checked = false;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      buttonField4.Show();
      buttonField5.Hide();
      buttonField9.Show();
      buttonField10.Hide();
      buttonField14.Show();
      buttonField15.Hide();
      buttonField16.Show();
      buttonField17.Show();
      buttonField18.Show();
      buttonField19.Show();
      buttonField20.Hide();
      buttonField21.Hide();
      buttonField22.Hide();
      buttonField23.Hide();
      buttonField24.Hide();
      buttonField25.Hide();
      CountBlacksAndWhites();
    }

    private void ToolStripMenuItemGamesize5x5_Click(object sender, EventArgs e)
    {
      intGamesize = 5;
      toolStripMenuItemGamesize3x3.Checked = false;
      toolStripMenuItemGamesize4x4.Checked = false;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      buttonField4.Show();
      buttonField5.Show();
      buttonField9.Show();
      buttonField10.Show();
      buttonField14.Show();
      buttonField15.Show();
      buttonField16.Show();
      buttonField17.Show();
      buttonField18.Show();
      buttonField19.Show();
      buttonField20.Show();
      buttonField21.Show();
      buttonField22.Show();
      buttonField23.Show();
      buttonField24.Show();
      buttonField25.Show();
      CountBlacksAndWhites();
    }

    private void ToolStripMenuItemNeighbourhoodLinear_Click(object sender, EventArgs e)
    {
      toolStripMenuItemNeighbourhoodDiagonal.Checked = false;
      toolStripMenuItemNeighbourhoodCombined.Checked = false;
    }

    private void ToolStripMenuItemNeighbourhoodDiagonal_Click(object sender, EventArgs e)
    {
      toolStripMenuItemNeighbourhoodLinear.Checked = false;
      toolStripMenuItemNeighbourhoodCombined.Checked = false;
    }

    private void ToolStripMenuItemNeighbourhoodCombined_Click(object sender, EventArgs e)
    {
      toolStripMenuItemNeighbourhoodLinear.Checked = false;
      toolStripMenuItemNeighbourhoodDiagonal.Checked = false;
    }

    private void ToolStripMenuItemNeighbourhoodCentered_Click(object sender, EventArgs e)
    {
    }

    private void buttonNewGamesize_Click(object sender, EventArgs e)
    {
      contextMenuStripGamesize.Show(buttonNewGamesize, 0, buttonNewGamesize.Size.Height);
    }

    private void buttonOptions_Click(object sender, EventArgs e)
    {
      contextMenuStripNeighbourhood.Show(buttonOptions, 0, buttonOptions.Size.Height);
    }

    private void buttonField1_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField1.BackColor == Color.Black) str = "schwarz";
      else if (buttonField1.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x1: " + str);
    }

    private void buttonField2_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField2.BackColor == Color.Black) str = "schwarz";
      else if (buttonField2.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x2: " + str);
    }

    private void buttonField3_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField3.BackColor == Color.Black) str = "schwarz";
      else if (buttonField3.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x3: " + str);
    }

    private void buttonField4_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField4.BackColor == Color.Black) str = "schwarz";
      else if (buttonField4.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x4: " + str);
    }

    private void buttonField5_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField5.BackColor == Color.Black) str = "schwarz";
      else if (buttonField5.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x5: " + str);
    }

    private void buttonField6_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField6.BackColor == Color.Black) str = "schwarz";
      else if (buttonField6.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x1: " + str);
    }

    private void buttonField7_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField7.BackColor == Color.Black) str = "schwarz";
      else if (buttonField7.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x2: " + str);
    }

    private void buttonField8_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField8.BackColor == Color.Black) str = "schwarz";
      else if (buttonField8.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x3: " + str);
    }

    private void buttonField9_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField9.BackColor == Color.Black) str = "schwarz";
      else if (buttonField9.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x4: " + str);
    }

    private void buttonField10_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField10.BackColor == Color.Black) str = "schwarz";
      else if (buttonField10.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x5: " + str);
    }

    private void buttonField11_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField11.BackColor == Color.Black) str = "schwarz";
      else if (buttonField11.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x1: " + str);
    }

    private void buttonField12_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField12.BackColor == Color.Black) str = "schwarz";
      else if (buttonField12.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x2: " + str);
    }

    private void buttonField13_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField13.BackColor == Color.Black) str = "schwarz";
      else if (buttonField13.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x3: " + str);
    }

    private void buttonField14_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField14.BackColor == Color.Black) str = "schwarz";
      else if (buttonField14.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x4: " + str);
    }

    private void buttonField15_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField15.BackColor == Color.Black) str = "schwarz";
      else if (buttonField15.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x5: " + str);
    }

    private void buttonField16_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField16.BackColor == Color.Black) str = "schwarz";
      else if (buttonField16.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x1: " + str);
    }

    private void buttonField17_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField17.BackColor == Color.Black) str = "schwarz";
      else if (buttonField17.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x2: " + str);
    }

    private void buttonField18_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField18.BackColor == Color.Black) str = "schwarz";
      else if (buttonField18.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x3: " + str);
    }

    private void buttonField19_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField19.BackColor == Color.Black) str = "schwarz";
      else if (buttonField19.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x4: " + str);
    }

    private void buttonField20_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField20.BackColor == Color.Black) str = "schwarz";
      else if (buttonField20.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x5: " + str);
    }

    private void buttonField21_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField21.BackColor == Color.Black) str = "schwarz";
      else if (buttonField21.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x1: " + str);
    }

    private void buttonField22_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField22.BackColor == Color.Black) str = "schwarz";
      else if (buttonField22.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x2: " + str);
    }

    private void buttonField23_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField23.BackColor == Color.Black) str = "schwarz";
      else if (buttonField23.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x3: " + str);
    }

    private void buttonField24_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField24.BackColor == Color.Black) str = "schwarz";
      else if (buttonField24.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x4: " + str);
    }

    private void buttonField25_Enter(object sender, EventArgs e)
    {
      String str;
      if (buttonField25.BackColor == Color.Black) str = "schwarz";
      else if (buttonField25.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x5: " + str);
    }

    private void buttonField1_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField1.BackColor == Color.Black) str = "schwarz";
      else if (buttonField1.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x1: " + str);
    }

    private void buttonField2_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField2.BackColor == Color.Black) str = "schwarz";
      else if (buttonField2.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x2: " + str);
    }

    private void buttonField3_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField3.BackColor == Color.Black) str = "schwarz";
      else if (buttonField3.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x3: " + str);
    }

    private void buttonField4_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField4.BackColor == Color.Black) str = "schwarz";
      else if (buttonField4.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x4: " + str);
    }

    private void buttonField5_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField5.BackColor == Color.Black) str = "schwarz";
      else if (buttonField5.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 1x5: " + str);
    }

    private void buttonField6_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField6.BackColor == Color.Black) str = "schwarz";
      else if (buttonField6.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x1: " + str);
    }

    private void buttonField7_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField7.BackColor == Color.Black) str = "schwarz";
      else if (buttonField7.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x2: " + str);
    }

    private void buttonField8_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField8.BackColor == Color.Black) str = "schwarz";
      else if (buttonField8.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x3: " + str);
    }

    private void buttonField9_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField9.BackColor == Color.Black) str = "schwarz";
      else if (buttonField9.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x4: " + str);
    }

    private void buttonField10_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField10.BackColor == Color.Black) str = "schwarz";
      else if (buttonField10.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 2x5: " + str);
    }

    private void buttonField11_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField11.BackColor == Color.Black) str = "schwarz";
      else if (buttonField11.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x1: " + str);
    }

    private void buttonField12_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField12.BackColor == Color.Black) str = "schwarz";
      else if (buttonField12.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x2: " + str);
    }

    private void buttonField13_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField13.BackColor == Color.Black) str = "schwarz";
      else if (buttonField13.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x3: " + str);
    }

    private void buttonField14_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField14.BackColor == Color.Black) str = "schwarz";
      else if (buttonField14.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x4: " + str);
    }

    private void buttonField15_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField15.BackColor == Color.Black) str = "schwarz";
      else if (buttonField15.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 3x5: " + str);
    }

    private void buttonField16_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField16.BackColor == Color.Black) str = "schwarz";
      else if (buttonField16.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x1: " + str);
    }

    private void buttonField17_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField17.BackColor == Color.Black) str = "schwarz";
      else if (buttonField17.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x2: " + str);
    }

    private void buttonField18_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField18.BackColor == Color.Black) str = "schwarz";
      else if (buttonField18.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x3: " + str);
    }

    private void buttonField19_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField19.BackColor == Color.Black) str = "schwarz";
      else if (buttonField19.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x4: " + str);
    }

    private void buttonField20_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField20.BackColor == Color.Black) str = "schwarz";
      else if (buttonField20.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 4x5: " + str);
    }

    private void buttonField21_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField21.BackColor == Color.Black) str = "schwarz";
      else if (buttonField21.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x1: " + str);
    }

    private void buttonField22_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField22.BackColor == Color.Black) str = "schwarz";
      else if (buttonField22.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x2: " + str);
    }

    private void buttonField23_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField23.BackColor == Color.Black) str = "schwarz";
      else if (buttonField23.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x3: " + str);
    }

    private void buttonField24_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField24.BackColor == Color.Black) str = "schwarz";
      else if (buttonField24.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x4: " + str);
    }

    private void buttonField25_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (buttonField25.BackColor == Color.Black) str = "schwarz";
      else if (buttonField25.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarText("Feld 5x5: " + str);
    }

    private void buttonField1_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField2_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField3_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField4_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField5_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField6_Leave(object sender, EventArgs e)
    {

    }

    private void buttonField7_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField8_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField9_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField10_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField11_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField12_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField13_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField14_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField15_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField16_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField17_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField18_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField19_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField20_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField21_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField22_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField23_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField24_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField25_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonField1_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField2_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField3_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField4_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField5_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField11_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField12_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField13_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField14_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField15_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField16_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField17_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField18_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField19_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField20_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField21_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField22_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField23_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField24_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonField25_MouseHover(object sender, EventArgs e)
    {

    }

    private void buttonNewGame_Enter(object sender, EventArgs e)
    {
      setStatusbarText(buttonNewGame.AccessibleDescription);
    }

    private void buttonNewGamesize_Enter(object sender, EventArgs e)
    {
      setStatusbarText(buttonNewGamesize.AccessibleDescription);
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

    private void buttonNewGame_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonNewGamesize_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonOptions_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonGameConcept_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonQuitGame_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelGamesize_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelClicks_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelTicks_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelBlacks_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelWhites_Leave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonNewGame_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(buttonNewGame.AccessibleDescription);
    }

    private void buttonNewGamesize_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(buttonNewGamesize.AccessibleDescription);
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

    private void buttonNewGame_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonNewGamesize_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonOptions_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonGameConcept_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void buttonQuitGame_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelGamesize_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelClicks_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelTicks_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelBlacks_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void labelWhites_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
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

    private void ToolStripMenuItemNeighbourhoodLinear_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemNeighbourhoodLinear.AccessibleDescription);
    }

    private void ToolStripMenuItemNeighbourhoodDiagonal_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemNeighbourhoodDiagonal.AccessibleDescription);
    }

    private void ToolStripMenuItemNeighbourhoodCombined_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemNeighbourhoodCombined.AccessibleDescription);
    }

    private void ToolStripMenuItemNeighbourhoodCentered_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripMenuItemNeighbourhoodCentered.AccessibleDescription);
    }

    private void toolStripSeparator1_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarText(toolStripSeparator1.AccessibleDescription);
    }

    private void contextMenuStripGamesize_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void toolStripMenuItemGamesize3x3_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void toolStripMenuItemGamesize4x4_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void toolStripMenuItemGamesize5x5_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void contextMenuStripNeighbourhood_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void ToolStripMenuItemNeighbourhoodLinear_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void ToolStripMenuItemNeighbourhoodDiagonal_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void ToolStripMenuItemNeighbourhoodCombined_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void ToolStripMenuItemNeighbourhoodCentered_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void toolStripSeparator1_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbarText();
    }

    private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
    }

    private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
    }
  }
}
