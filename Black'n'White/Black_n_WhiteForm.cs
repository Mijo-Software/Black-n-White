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


    private void Black_n_WhiteForm_Load(object sender, EventArgs e)
    {
      InitializeGame();
    }

    private void buttonField1_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(1);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(2);
        InvertField(6);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(2);
        InvertField(6);
        InvertField(7);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField2_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(2);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(1);
        InvertField(3);
        InvertField(7);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(6);
        InvertField(8);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(1);
        InvertField(3);
        InvertField(7);
        InvertField(6);
        InvertField(8);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField3_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(3);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(2);
        InvertField(4);
        InvertField(8);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
        InvertField(9);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(2);
        InvertField(4);
        InvertField(8);
        InvertField(7);
        InvertField(9);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField4_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(4);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(3);
        InvertField(5);
        InvertField(9);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(8);
        InvertField(10);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(3);
        InvertField(5);
        InvertField(9);
        InvertField(8);
        InvertField(10);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField5_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(5);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(4);
        InvertField(10);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(9);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(4);
        InvertField(10);
        InvertField(9);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField6_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(6);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(1);
        InvertField(7);
        InvertField(11);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(2);
        InvertField(12);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(1);
        InvertField(7);
        InvertField(11);
        InvertField(2);
        InvertField(12);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField7_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(7);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(2);
        InvertField(6);
        InvertField(8);
        InvertField(12);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(1);
        InvertField(3);
        InvertField(11);
        InvertField(13);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField8_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(8);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(3);
        InvertField(7);
        InvertField(9);
        InvertField(13);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(2);
        InvertField(4);
        InvertField(12);
        InvertField(14);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField9_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(9);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(4);
        InvertField(8);
        InvertField(10);
        InvertField(14);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(3);
        InvertField(5);
        InvertField(13);
        InvertField(15);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField10_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(10);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(5);
        InvertField(9);
        InvertField(15);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(4);
        InvertField(14);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(5);
        InvertField(9);
        InvertField(15);
        InvertField(4);
        InvertField(14);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField11_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(11);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(6);
        InvertField(12);
        InvertField(16);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
        InvertField(17);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(6);
        InvertField(12);
        InvertField(16);
        InvertField(7);
        InvertField(17);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField12_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(12);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(7);
        InvertField(11);
        InvertField(13);
        InvertField(17);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(6);
        InvertField(8);
        InvertField(16);
        InvertField(18);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField13_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(13);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(8);
        InvertField(12);
        InvertField(14);
        InvertField(18);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(7);
        InvertField(9);
        InvertField(17);
        InvertField(19);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField14_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(14);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(9);
        InvertField(13);
        InvertField(15);
        InvertField(19);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(8);
        InvertField(10);
        InvertField(18);
        InvertField(20);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField15_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(15);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(10);
        InvertField(14);
        InvertField(20);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(9);
        InvertField(19);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(10);
        InvertField(14);
        InvertField(20);
        InvertField(9);
        InvertField(19);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField16_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(16);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(11);
        InvertField(17);
        InvertField(21);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(12);
        InvertField(22);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(11);
        InvertField(17);
        InvertField(21);
        InvertField(12);
        InvertField(22);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField17_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(17);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(12);
        InvertField(16);
        InvertField(18);
        InvertField(22);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(11);
        InvertField(13);
        InvertField(21);
        InvertField(23);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField18_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(18);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(13);
        InvertField(17);
        InvertField(19);
        InvertField(23);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(12);
        InvertField(14);
        InvertField(22);
        InvertField(24);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField19_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(19);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(14);
        InvertField(18);
        InvertField(20);
        InvertField(24);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(13);
        InvertField(15);
        InvertField(23);
        InvertField(25);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
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
      CheckForWin();
    }

    private void buttonField20_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(20);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(15);
        InvertField(19);
        InvertField(25);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(14);
        InvertField(24);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(15);
        InvertField(19);
        InvertField(25);
        InvertField(14);
        InvertField(24);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField21_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(21);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(16);
        InvertField(22);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(17);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(16);
        InvertField(22);
        InvertField(17);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField22_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(22);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(17);
        InvertField(21);
        InvertField(23);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(16);
        InvertField(18);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(17);
        InvertField(21);
        InvertField(23);
        InvertField(16);
        InvertField(18);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField23_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(23);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(18);
        InvertField(22);
        InvertField(24);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(17);
        InvertField(19);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(18);
        InvertField(22);
        InvertField(24);
        InvertField(17);
        InvertField(19);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField24_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(24);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(19);
        InvertField(23);
        InvertField(25);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(18);
        InvertField(20);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(19);
        InvertField(23);
        InvertField(25);
        InvertField(18);
        InvertField(20);
      }
      UpdateClicks();
      CountBlacksAndWhites();
      CheckForWin();
    }

    private void buttonField25_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (ToolStripMenuItemNeighbourhoodCentered.Checked) InvertField(25);
      if (ToolStripMenuItemNeighbourhoodLinear.Checked)
      {
        InvertField(20);
        InvertField(24);
      }
      else if (ToolStripMenuItemNeighbourhoodDiagonal.Checked)
      {
        InvertField(19);
      }
      else if (ToolStripMenuItemNeighbourhoodCombined.Checked)
      {
        InvertField(20);
        InvertField(24);
        InvertField(19);
      }
      UpdateClicks();
      CountBlacksAndWhites();
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
      ToolStripMenuItemGamesize4x4.Checked = false;
      ToolStripMenuItemGamesize5x5.Checked = false;
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
      ToolStripMenuItemGamesize3x3.Checked = false;
      ToolStripMenuItemGamesize5x5.Checked = false;
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
      ToolStripMenuItemGamesize3x3.Checked = false;
      ToolStripMenuItemGamesize4x4.Checked = false;
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
      ToolStripMenuItemNeighbourhoodDiagonal.Checked = false;
      ToolStripMenuItemNeighbourhoodCombined.Checked = false;
    }

    private void ToolStripMenuItemNeighbourhoodDiagonal_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemNeighbourhoodLinear.Checked = false;
      ToolStripMenuItemNeighbourhoodCombined.Checked = false;
    }

    private void ToolStripMenuItemNeighbourhoodCombined_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemNeighbourhoodLinear.Checked = false;
      ToolStripMenuItemNeighbourhoodDiagonal.Checked = false;
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

  }
}
