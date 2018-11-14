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

    private void Black_n_WhiteForm_Load(object sender, EventArgs e)
    {
      InitializeGame();
    }

    private void pictureBoxField1_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(1);
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

    private void pictureBoxField2_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(2);
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

    private void pictureBoxField3_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(3);
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

    private void pictureBoxField4_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(4);
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

    private void pictureBoxField5_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(5);
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

    private void pictureBoxField6_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(6);
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

    private void pictureBoxField7_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(7);
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

    private void pictureBoxField8_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(8);
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

    private void pictureBoxField9_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(9);
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

    private void pictureBoxField10_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(10);
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

    private void pictureBoxField11_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(11);
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

    private void pictureBoxField12_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(12);
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

    private void pictureBoxField13_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(13);
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

    private void pictureBoxField14_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(14);
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

    private void pictureBoxField15_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(15);
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

    private void pictureBoxField16_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(16);
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

    private void pictureBoxField17_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(17);
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

    private void pictureBoxField18_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(18);
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

    private void pictureBoxField19_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(19);
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

    private void pictureBoxField20_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(20);
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

    private void pictureBoxField21_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(21);
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

    private void pictureBoxField22_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(22);
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

    private void pictureBoxField23_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(23);
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

    private void pictureBoxField24_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(24);
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

    private void pictureBoxField25_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      if (toolStripMenuItemCentered.Checked) InvertField(25);
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
      ToolStripMenuItemGamesize4x4.Checked = false;
      ToolStripMenuItemGamesize5x5.Checked = false;
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
      ToolStripMenuItemGamesize3x3.Checked = false;
      ToolStripMenuItemGamesize5x5.Checked = false;
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
      ToolStripMenuItemGamesize3x3.Checked = false;
      ToolStripMenuItemGamesize4x4.Checked = false;
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
  }
}
