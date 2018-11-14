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
      intClicks = 0;
      labelClicks.Text = "Klicks: " + intClicks;
      labelTicks.Text = "Ticks: " + intTicks;
      boolFirstClickDone = false;
      timer.Enabled = false;
    }

    private void CheckForWin()
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
        pictureBoxField9.BackColor == Color.Black) ||
        (pictureBoxField1.BackColor == Color.White &&
        pictureBoxField2.BackColor == Color.White &&
        pictureBoxField3.BackColor == Color.White &&
        pictureBoxField4.BackColor == Color.White &&
        pictureBoxField5.BackColor == Color.White &&
        pictureBoxField6.BackColor == Color.White &&
        pictureBoxField7.BackColor == Color.White &&
        pictureBoxField8.BackColor == Color.White &&
        pictureBoxField9.BackColor == Color.White)
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
      }
    }

    private void CheckForGameIsRunning()
    {
      if (boolIsGameRunning == false) boolIsGameRunning = true;
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
      }
    }

    private void Black_n_WhiteForm_Load(object sender, EventArgs e)
    {
      InitializeGame();
    }

    private void pictureBoxField1_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(1);
      InvertField(2);
      InvertField(4);
      UpdateClicks();
      CheckForWin();
    }

    private void pictureBoxField2_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(2);
      InvertField(1);
      InvertField(3);
      InvertField(5);
      UpdateClicks();
      CheckForWin();
    }

    private void pictureBoxField3_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(3);
      InvertField(2);
      InvertField(6);
      UpdateClicks();
      CheckForWin();
    }

    private void pictureBoxField4_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(4);
      InvertField(1);
      InvertField(5);
      InvertField(7);
      UpdateClicks();
      CheckForWin();
    }

    private void pictureBoxField5_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(5);
      InvertField(2);
      InvertField(4);
      InvertField(6);
      InvertField(8);
      UpdateClicks();
      CheckForWin();
    }

    private void pictureBoxField6_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(6);
      InvertField(3);
      InvertField(5);
      InvertField(9);
      UpdateClicks();
      CheckForWin();
    }

    private void pictureBoxField7_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(7);
      InvertField(4);
      InvertField(8);
      UpdateClicks();
      CheckForWin();
    }

    private void pictureBoxField8_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(8);
      InvertField(5);
      InvertField(7);
      InvertField(9);
      UpdateClicks();
      CheckForWin();
    }

    private void pictureBoxField9_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      CheckForGameIsRunning();
      InvertField(9);
      InvertField(6);
      InvertField(8);
      UpdateClicks();
      CheckForWin();
    }

    private void buttonNewGame_Click(object sender, EventArgs e)
    {
      InitializeGame();
      boolIsGameRunning = false;
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
      timer.Start();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      intTicks++;
      labelTicks.Text = "Ticks: " + intTicks;
    }

  }
}
