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
      if (r % 2 == 0) pictureBoxField1.BackColor = Color.Black; else pictureBoxField1.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField2.BackColor = Color.Black; else pictureBoxField2.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField3.BackColor = Color.Black; else pictureBoxField3.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField4.BackColor = Color.Black; else pictureBoxField4.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField5.BackColor = Color.Black; else pictureBoxField5.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField6.BackColor = Color.Black; else pictureBoxField6.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField7.BackColor = Color.Black; else pictureBoxField7.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField8.BackColor = Color.Black; else pictureBoxField8.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField9.BackColor = Color.Black; else pictureBoxField9.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField10.BackColor = Color.Black; else pictureBoxField10.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField11.BackColor = Color.Black; else pictureBoxField11.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField12.BackColor = Color.Black; else pictureBoxField12.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField13.BackColor = Color.Black; else pictureBoxField13.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField14.BackColor = Color.Black; else pictureBoxField14.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField15.BackColor = Color.Black; else pictureBoxField15.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField16.BackColor = Color.Black; else pictureBoxField16.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField17.BackColor = Color.Black; else pictureBoxField17.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField18.BackColor = Color.Black; else pictureBoxField18.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField19.BackColor = Color.Black; else pictureBoxField19.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField20.BackColor = Color.Black; else pictureBoxField20.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField21.BackColor = Color.Black; else pictureBoxField21.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField22.BackColor = Color.Black; else pictureBoxField22.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField23.BackColor = Color.Black; else pictureBoxField23.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField24.BackColor = Color.Black; else pictureBoxField24.BackColor = Color.White;
      r = rnd.Next();
      if (r % 2 == 0) pictureBoxField25.BackColor = Color.Black; else pictureBoxField25.BackColor = Color.White;

      if (intGamesize == 3)
      {
        pictureBoxField4.Hide();
        pictureBoxField5.Hide();
        pictureBoxField9.Hide();
        pictureBoxField10.Hide();
        pictureBoxField14.Hide();
        pictureBoxField15.Hide();
        pictureBoxField16.Hide();
        pictureBoxField17.Hide();
        pictureBoxField18.Hide();
        pictureBoxField19.Hide();
        pictureBoxField20.Hide();
        pictureBoxField21.Hide();
        pictureBoxField22.Hide();
        pictureBoxField23.Hide();
        pictureBoxField24.Hide();
        pictureBoxField25.Hide();
      }
      else if (intGamesize == 4)
      {
        pictureBoxField4.Show();
        pictureBoxField5.Hide();
        pictureBoxField9.Show();
        pictureBoxField10.Hide();
        pictureBoxField14.Show();
        pictureBoxField15.Hide();
        pictureBoxField16.Show();
        pictureBoxField17.Show();
        pictureBoxField18.Show();
        pictureBoxField19.Show();
        pictureBoxField20.Hide();
        pictureBoxField21.Hide();
        pictureBoxField22.Hide();
        pictureBoxField23.Hide();
        pictureBoxField24.Hide();
        pictureBoxField25.Hide();
      }
      else if (intGamesize == 5)
      {
        pictureBoxField4.Show();
        pictureBoxField5.Show();
        pictureBoxField9.Show();
        pictureBoxField10.Show();
        pictureBoxField14.Show();
        pictureBoxField15.Show();
        pictureBoxField16.Show();
        pictureBoxField17.Show();
        pictureBoxField18.Show();
        pictureBoxField19.Show();
        pictureBoxField20.Show();
        pictureBoxField21.Show();
        pictureBoxField22.Show();
        pictureBoxField23.Show();
        pictureBoxField24.Show();
        pictureBoxField25.Show();
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
      switch (n)
      {
        case 1:
        {
          if (pictureBoxField1.BackColor == Color.Black) pictureBoxField1.BackColor = Color.White;
          else if (pictureBoxField1.BackColor == Color.White) pictureBoxField1.BackColor = Color.Black;
          break;
        }
        case 2:
        {
          if (pictureBoxField2.BackColor == Color.Black) pictureBoxField2.BackColor = Color.White;
          else if (pictureBoxField2.BackColor == Color.White) pictureBoxField2.BackColor = Color.Black;
          break;
        }
        case 3:
        {
          if (pictureBoxField3.BackColor == Color.Black) pictureBoxField3.BackColor = Color.White;
          else if (pictureBoxField3.BackColor == Color.White) pictureBoxField3.BackColor = Color.Black;
          break;
        }
        case 4:
        {
          if (pictureBoxField4.BackColor == Color.Black) pictureBoxField4.BackColor = Color.White;
          else if (pictureBoxField4.BackColor == Color.White) pictureBoxField4.BackColor = Color.Black;
          break;
        }
        case 5:
        {
          if (pictureBoxField5.BackColor == Color.Black) pictureBoxField5.BackColor = Color.White;
          else if (pictureBoxField5.BackColor == Color.White) pictureBoxField5.BackColor = Color.Black;
          break;
        }
        case 6:
        {
          if (pictureBoxField6.BackColor == Color.Black) pictureBoxField6.BackColor = Color.White;
          else if (pictureBoxField6.BackColor == Color.White) pictureBoxField6.BackColor = Color.Black;
          break;
        }
        case 7:
        {
          if (pictureBoxField7.BackColor == Color.Black) pictureBoxField7.BackColor = Color.White;
          else if (pictureBoxField7.BackColor == Color.White) pictureBoxField7.BackColor = Color.Black;
          break;
        }
        case 8:
        {
          if (pictureBoxField8.BackColor == Color.Black) pictureBoxField8.BackColor = Color.White;
          else if (pictureBoxField8.BackColor == Color.White) pictureBoxField8.BackColor = Color.Black;
          break;
        }
        case 9:
        {
          if (pictureBoxField9.BackColor == Color.Black) pictureBoxField9.BackColor = Color.White;
          else if (pictureBoxField9.BackColor == Color.White) pictureBoxField9.BackColor = Color.Black;
          break;
        }
        case 10:
        {
          if (pictureBoxField10.BackColor == Color.Black) pictureBoxField10.BackColor = Color.White;
          else if (pictureBoxField10.BackColor == Color.White) pictureBoxField10.BackColor = Color.Black;
          break;
        }
        case 11:
        {
          if (pictureBoxField11.BackColor == Color.Black) pictureBoxField11.BackColor = Color.White;
          else if (pictureBoxField11.BackColor == Color.White) pictureBoxField11.BackColor = Color.Black;
          break;
        }
        case 12:
        {
          if (pictureBoxField12.BackColor == Color.Black) pictureBoxField12.BackColor = Color.White;
          else if (pictureBoxField12.BackColor == Color.White) pictureBoxField12.BackColor = Color.Black;
          break;
        }
        case 13:
        {
          if (pictureBoxField13.BackColor == Color.Black) pictureBoxField13.BackColor = Color.White;
          else if (pictureBoxField13.BackColor == Color.White) pictureBoxField13.BackColor = Color.Black;
          break;
        }
        case 14:
        {
          if (pictureBoxField14.BackColor == Color.Black) pictureBoxField14.BackColor = Color.White;
          else if (pictureBoxField14.BackColor == Color.White) pictureBoxField14.BackColor = Color.Black;
          break;
        }
        case 15:
        {
          if (pictureBoxField15.BackColor == Color.Black) pictureBoxField15.BackColor = Color.White;
          else if (pictureBoxField15.BackColor == Color.White) pictureBoxField15.BackColor = Color.Black;
          break;
        }
        case 16:
        {
          if (pictureBoxField16.BackColor == Color.Black) pictureBoxField16.BackColor = Color.White;
          else if (pictureBoxField16.BackColor == Color.White) pictureBoxField16.BackColor = Color.Black;
          break;
        }
        case 17:
        {
          if (pictureBoxField17.BackColor == Color.Black) pictureBoxField17.BackColor = Color.White;
          else if (pictureBoxField17.BackColor == Color.White) pictureBoxField17.BackColor = Color.Black;
          break;
        }
        case 18:
        {
          if (pictureBoxField18.BackColor == Color.Black) pictureBoxField18.BackColor = Color.White;
          else if (pictureBoxField18.BackColor == Color.White) pictureBoxField18.BackColor = Color.Black;
          break;
        }
        case 19:
        {
          if (pictureBoxField19.BackColor == Color.Black) pictureBoxField19.BackColor = Color.White;
          else if (pictureBoxField19.BackColor == Color.White) pictureBoxField19.BackColor = Color.Black;
          break;
        }
        case 20:
        {
          if (pictureBoxField20.BackColor == Color.Black) pictureBoxField20.BackColor = Color.White;
          else if (pictureBoxField20.BackColor == Color.White) pictureBoxField20.BackColor = Color.Black;
          break;
        }
        case 21:
        {
          if (pictureBoxField21.BackColor == Color.Black) pictureBoxField21.BackColor = Color.White;
          else if (pictureBoxField21.BackColor == Color.White) pictureBoxField21.BackColor = Color.Black;
          break;
        }
        case 22:
        {
          if (pictureBoxField22.BackColor == Color.Black) pictureBoxField22.BackColor = Color.White;
          else if (pictureBoxField22.BackColor == Color.White) pictureBoxField22.BackColor = Color.Black;
          break;
        }
        case 23:
        {
          if (pictureBoxField23.BackColor == Color.Black) pictureBoxField23.BackColor = Color.White;
          else if (pictureBoxField23.BackColor == Color.White) pictureBoxField23.BackColor = Color.Black;
          break;
        }
        case 24:
        {
          if (pictureBoxField24.BackColor == Color.Black) pictureBoxField24.BackColor = Color.White;
          else if (pictureBoxField24.BackColor == Color.White) pictureBoxField24.BackColor = Color.Black;
          break;
        }
        case 25:
        {
          if (pictureBoxField25.BackColor == Color.Black) pictureBoxField25.BackColor = Color.White;
          else if (pictureBoxField25.BackColor == Color.White) pictureBoxField25.BackColor = Color.Black;
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

    private void setStatusbarTest(String str)
    {
      toolStripStatusLabel.Text = str;
    }

    private void clearStatusbar()
    {
      setStatusbarTest("");
    }

    private void Black_n_WhiteForm_Load(object sender, EventArgs e)
    {
      InitializeGame();
    }

    private void pictureBoxField1_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(1);
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
      if (pictureBoxField1.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField1.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x1: " + str);
      CheckForWin();
    }

    private void pictureBoxField2_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(2);
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
      if (pictureBoxField2.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField2.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x2: " + str);
      CheckForWin();
    }

    private void pictureBoxField3_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(3);
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
      if (pictureBoxField3.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField3.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x3: " + str);
      CheckForWin();
    }

    private void pictureBoxField4_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(4);
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
      if (pictureBoxField4.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField4.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x4: " + str);
      CheckForWin();
    }

    private void pictureBoxField5_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(5);
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
      if (pictureBoxField5.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField5.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x5: " + str);
      CheckForWin();
    }

    private void pictureBoxField6_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(6);
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
      if (pictureBoxField6.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField6.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x1: " + str);
      CheckForWin();
    }

    private void pictureBoxField7_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(7);
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
      if (pictureBoxField7.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField7.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x2: " + str);
      CheckForWin();
    }

    private void pictureBoxField8_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(8);
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
      if (pictureBoxField8.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField8.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x3: " + str);
      CheckForWin();
    }

    private void pictureBoxField9_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(9);
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
      if (pictureBoxField9.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField9.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x4: " + str);
      CheckForWin();
    }

    private void pictureBoxField10_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(10);
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
      if (pictureBoxField10.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField10.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x5: " + str);
      CheckForWin();
    }

    private void pictureBoxField11_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(11);
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
      if (pictureBoxField11.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField11.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x1: " + str);
      CheckForWin();
    }

    private void pictureBoxField12_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(12);
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
      if (pictureBoxField12.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField12.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x2: " + str);
      CheckForWin();
    }

    private void pictureBoxField13_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(13);
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
      if (pictureBoxField13.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField13.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x3: " + str);
      CheckForWin();
    }

    private void pictureBoxField14_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(14);
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
      if (pictureBoxField14.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField14.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x4: " + str);
      CheckForWin();
    }

    private void pictureBoxField15_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(15);
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
      if (pictureBoxField15.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField15.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x5: " + str);
      CheckForWin();
    }

    private void pictureBoxField16_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(16);
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
      if (pictureBoxField16.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField16.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x1: " + str);
      CheckForWin();
    }

    private void pictureBoxField17_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(17);
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
      if (pictureBoxField17.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField17.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x2: " + str);
      CheckForWin();
    }

    private void pictureBoxField18_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(18);
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
      if (pictureBoxField18.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField18.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x3: " + str);
      CheckForWin();
    }

    private void pictureBoxField19_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(19);
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
      if (pictureBoxField19.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField19.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x4: " + str);
      CheckForWin();
    }

    private void pictureBoxField20_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(20);
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
      if (pictureBoxField1.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField1.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x5: " + str);
      CheckForWin();
    }

    private void pictureBoxField21_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(21);
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
      if (pictureBoxField20.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField21.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x1: " + str);
      CheckForWin();
    }

    private void pictureBoxField22_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(22);
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
      if (pictureBoxField22.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField22.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x2: " + str);
      CheckForWin();
    }

    private void pictureBoxField23_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(23);
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
      if (pictureBoxField23.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField23.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x3: " + str);
      CheckForWin();
    }

    private void pictureBoxField24_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(24);
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
      if (pictureBoxField24.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField24.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x4: " + str);
      CheckForWin();
    }

    private void pictureBoxField25_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(25);
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
      if (pictureBoxField25.BackColor == Color.Black) str = "schwarz";
      else if (pictureBoxField25.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x5: " + str);
      CheckForWin();
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

    private void ToolStripMenuItemGamesize3x3_Click(object sender, EventArgs e)
    {
      intGamesize = 3;
      toolStripMenuItemGamesize4x4.Checked = false;
      toolStripMenuItemGamesize5x5.Checked = false;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      pictureBoxField4.Hide();
      pictureBoxField5.Hide();
      pictureBoxField9.Hide();
      pictureBoxField10.Hide();
      pictureBoxField14.Hide();
      pictureBoxField15.Hide();
      pictureBoxField16.Hide();
      pictureBoxField17.Hide();
      pictureBoxField18.Hide();
      pictureBoxField19.Hide();
      pictureBoxField20.Hide();
      pictureBoxField21.Hide();
      pictureBoxField22.Hide();
      pictureBoxField23.Hide();
      pictureBoxField24.Hide();
      pictureBoxField25.Hide();
      CountBlacksAndWhites();
    }

    private void ToolStripMenuItemGamesize4x4_Click(object sender, EventArgs e)
    {
      intGamesize = 4;
      toolStripMenuItemGamesize3x3.Checked = false;
      toolStripMenuItemGamesize5x5.Checked = false;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      pictureBoxField4.Show();
      pictureBoxField5.Hide();
      pictureBoxField9.Show();
      pictureBoxField10.Hide();
      pictureBoxField14.Show();
      pictureBoxField15.Hide();
      pictureBoxField16.Show();
      pictureBoxField17.Show();
      pictureBoxField18.Show();
      pictureBoxField19.Show();
      pictureBoxField20.Hide();
      pictureBoxField21.Hide();
      pictureBoxField22.Hide();
      pictureBoxField23.Hide();
      pictureBoxField24.Hide();
      pictureBoxField25.Hide();
      CountBlacksAndWhites();
    }

    private void ToolStripMenuItemGamesize5x5_Click(object sender, EventArgs e)
    {
      intGamesize = 5;
      toolStripMenuItemGamesize3x3.Checked = false;
      toolStripMenuItemGamesize4x4.Checked = false;
      labelGamesize.Text = "Größe: " + intGamesize.ToString() + "x" + intGamesize.ToString();
      pictureBoxField4.Show();
      pictureBoxField5.Show();
      pictureBoxField9.Show();
      pictureBoxField10.Show();
      pictureBoxField14.Show();
      pictureBoxField15.Show();
      pictureBoxField16.Show();
      pictureBoxField17.Show();
      pictureBoxField18.Show();
      pictureBoxField19.Show();
      pictureBoxField20.Show();
      pictureBoxField21.Show();
      pictureBoxField22.Show();
      pictureBoxField23.Show();
      pictureBoxField24.Show();
      pictureBoxField25.Show();
      CountBlacksAndWhites();
    }

    private void buttonOptions_Click(object sender, EventArgs e)
    {
      contextMenuStripNeighbourhood.Show(buttonOptions, 0, buttonOptions.Size.Height);
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

    private void pictureBoxField1_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField1.BackColor == Color.Black) str = "schwarz"; else
          if (pictureBoxField1.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x1: " + str);
    }

    private void pictureBoxField2_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField2.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField2.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x2: " + str);
    }

    private void pictureBoxField3_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField3.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField3.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x3: " + str);
    }

    private void pictureBoxField4_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField4.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField4.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x4: " + str);
    }

    private void pictureBoxField5_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField5.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField5.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 1x5: " + str);
    }

    private void pictureBoxField6_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField6.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField6.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x1: " + str);
    }

    private void pictureBoxField7_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField7.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField7.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x2: " + str);
    }

    private void pictureBoxField8_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField8.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField8.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x3: " + str);
    }

    private void pictureBoxField9_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField9.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField9.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x4: " + str);
    }

    private void pictureBoxField10_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField10.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField10.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 2x5: " + str);
    }

    private void pictureBoxField11_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField11.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField11.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x1: " + str);
    }

    private void pictureBoxField12_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField12.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField12.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x2: " + str);
    }

    private void pictureBoxField13_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField13.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField13.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x3: " + str);
    }

    private void pictureBoxField14_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField14.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField14.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x4: " + str);
    }

    private void pictureBoxField15_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField15.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField15.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 3x5: " + str);
    }

    private void pictureBoxField16_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField16.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField16.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x1: " + str);
    }

    private void pictureBoxField17_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField17.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField17.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x2: " + str);
    }

    private void pictureBoxField18_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField18.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField18.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x3: " + str);
    }

    private void pictureBoxField19_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField19.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField19.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x4: " + str);
    }

    private void pictureBoxField20_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField1.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField1.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 4x5: " + str);
    }

    private void pictureBoxField21_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField21.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField21.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x1: " + str);
    }

    private void pictureBoxField22_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField22.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField22.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x2: " + str);
    }

    private void pictureBoxField23_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField23.BackColor == Color.Black) str = "schwarz";
      else
          if (pictureBoxField23.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x3: " + str);
    }

    private void pictureBoxField24_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField24.BackColor == Color.Black) str = "schwarz"; else
          if (pictureBoxField24.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x4: " + str);
    }

    private void pictureBoxField25_MouseEnter(object sender, EventArgs e)
    {
      String str;
      if (pictureBoxField25.BackColor == Color.Black) str = "schwarz";
      else if (pictureBoxField25.BackColor == Color.White) str = "weiß"; else str = "???";
      setStatusbarTest("Feld 5x5: " + str);
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
      setStatusbarTest(buttonNewGame.AccessibleDescription);
    }

    private void buttonNewGameSize_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonNewGameSize.AccessibleDescription);
    }

    private void buttonOptions_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonOptions.AccessibleDescription);
    }

    private void buttonGameConcept_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonGameConcept.AccessibleDescription);
    }

    private void buttonQuitGame_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonQuitGame.AccessibleDescription);
    }

    private void labelGamesize_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(labelGamesize.AccessibleDescription);
    }

    private void labelClicks_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(labelClicks.AccessibleDescription);
    }

    private void labelTicks_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(labelTicks.AccessibleDescription);
    }

    private void labelBlacks_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(labelBlacks.AccessibleDescription);
    }

    private void labelWhites_Enter(object sender, EventArgs e)
    {
      setStatusbarTest(labelWhites.AccessibleDescription);
    }

    private void buttonNewGame_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonNewGame.AccessibleDescription);
    }

    private void buttonNewGameSize_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonNewGameSize.AccessibleDescription);
    }

    private void buttonOptions_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonOptions.AccessibleDescription);
    }

    private void buttonGameConcept_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonGameConcept.AccessibleDescription);
    }

    private void buttonQuitGame_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(buttonQuitGame.AccessibleDescription);
    }

    private void labelGamesize_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(labelGamesize.AccessibleDescription);
    }

    private void labelClicks_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(labelClicks.AccessibleDescription);
    }

    private void labelTicks_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(labelTicks.AccessibleDescription);
    }

    private void labelBlacks_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(labelBlacks.AccessibleDescription);
    }

    private void labelWhites_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(labelWhites.AccessibleDescription);
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
      setStatusbarTest(contextMenuStripGamesize.AccessibleDescription);
    }

    private void ToolStripMenuItemGamesize3x3_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(toolStripMenuItemGamesize3x3.AccessibleDescription);
    }
 
    private void ToolStripMenuItemGamesize4x4_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(toolStripMenuItemGamesize4x4.AccessibleDescription);
    }

    private void ToolStripMenuItemGamesize5x5_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(toolStripMenuItemGamesize5x5.AccessibleDescription);
    }

    private void contextMenuStripNeighbourhood_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(contextMenuStripNeighbourhood.AccessibleDescription);
    }

    private void ToolStripMenuItemNeighbourhoodLinear_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(toolStripMenuItemNeighbourhoodLinear.AccessibleDescription);
    }

    private void ToolStripMenuItemNeighbourhoodDiagonal_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(toolStripMenuItemNeighbourhoodDiagonal.AccessibleDescription);
    }

    private void ToolStripMenuItemNeighbourhoodCombined_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(toolStripMenuItemNeighbourhoodCombined.AccessibleDescription);
    }

    private void toolStripMenuItemCentered_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(toolStripMenuItemCentered.AccessibleDescription);
    }
                                       
    private void toolStripSeparator1_MouseEnter(object sender, EventArgs e)
    {
      setStatusbarTest(toolStripSeparator1.AccessibleDescription);
    }

    private void contextMenuStripGamesize_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void ToolStripMenuItemGamesize3x3_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void ToolStripMenuItemGamesize4x4_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void ToolStripMenuItemGamesize5x5_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void contextMenuStripNeighbourhood_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void ToolStripMenuItemNeighbourhoodLinear_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void ToolStripMenuItemNeighbourhoodDiagonal_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void ToolStripMenuItemNeighbourhoodCombined_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripMenuItemCentered_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }

    private void toolStripSeparator1_MouseLeave(object sender, EventArgs e)
    {
      clearStatusbar();
    }
  }
}
