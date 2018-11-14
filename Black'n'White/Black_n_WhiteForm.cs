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
      intClicks = 0;
      labelClicks.Text = "Klicks: " + intClicks;
      labelTicks.Text = "Ticks: " + intTicks;
      boolFirstClickDone = false;
      timer.Enabled = false;
    }

    private void CheckForWin()
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
        buttonField9.BackColor == Color.Black) ||
       (buttonField1.BackColor == Color.White &&
        buttonField2.BackColor == Color.White &&
        buttonField3.BackColor == Color.White &&
        buttonField4.BackColor == Color.White &&
        buttonField5.BackColor == Color.White &&
        buttonField6.BackColor == Color.White &&
        buttonField7.BackColor == Color.White &&
        buttonField8.BackColor == Color.White &&
        buttonField9.BackColor == Color.White)
        )
      {
        timer.Stop();
        string message = "Du hast gewonnen mit " + intClicks + " Klicks in " + intTicks + " Ticks.";
        string caption = "Gewonnen";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        DialogResult result;
        result = MessageBox.Show(message, caption, buttons);
        InitializeGame();
      }
    }


    private void Black_n_WhiteForm_Load(object sender, EventArgs e)
    {
      InitializeGame();
    }

    private void buttonNewGame_Click(object sender, EventArgs e)
    {
      InitializeGame();
    }

    private void buttonGameConcept_Click(object sender, EventArgs e)
    {
      timer.Stop();
      AboutBoxForm formAboutBox = new AboutBoxForm();
      formAboutBox.ShowDialog();
      timer.Start();
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

    private void buttonField1_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField1.BackColor == Color.Black) buttonField1.BackColor = Color.White;
      else if (buttonField1.BackColor == Color.White) buttonField1.BackColor = Color.Black;
      if (buttonField2.BackColor == Color.Black) buttonField2.BackColor = Color.White;
      else if (buttonField2.BackColor == Color.White) buttonField2.BackColor = Color.Black;
      if (buttonField4.BackColor == Color.Black) buttonField4.BackColor = Color.White;
      else if (buttonField4.BackColor == Color.White) buttonField4.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

    private void buttonField2_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField2.BackColor == Color.Black) buttonField2.BackColor = Color.White;
      else if (buttonField2.BackColor == Color.White) buttonField2.BackColor = Color.Black;
      if (buttonField1.BackColor == Color.Black) buttonField1.BackColor = Color.White;
      else if (buttonField1.BackColor == Color.White) buttonField1.BackColor = Color.Black;
      if (buttonField3.BackColor == Color.Black) buttonField3.BackColor = Color.White;
      else if (buttonField3.BackColor == Color.White) buttonField3.BackColor = Color.Black;
      if (buttonField5.BackColor == Color.Black) buttonField5.BackColor = Color.White;
      else if (buttonField5.BackColor == Color.White) buttonField5.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

    private void buttonField3_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField3.BackColor == Color.Black) buttonField3.BackColor = Color.White;
      else if (buttonField3.BackColor == Color.White) buttonField3.BackColor = Color.Black;
      if (buttonField2.BackColor == Color.Black) buttonField2.BackColor = Color.White;
      else if (buttonField2.BackColor == Color.White) buttonField2.BackColor = Color.Black;
      if (buttonField6.BackColor == Color.Black) buttonField6.BackColor = Color.White;
      else if (buttonField6.BackColor == Color.White) buttonField6.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

    private void buttonField4_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField4.BackColor == Color.Black) buttonField4.BackColor = Color.White;
      else if (buttonField4.BackColor == Color.White) buttonField4.BackColor = Color.Black;
      if (buttonField1.BackColor == Color.Black) buttonField1.BackColor = Color.White;
      else if (buttonField1.BackColor == Color.White) buttonField1.BackColor = Color.Black;
      if (buttonField5.BackColor == Color.Black) buttonField5.BackColor = Color.White;
      else if (buttonField5.BackColor == Color.White) buttonField5.BackColor = Color.Black;
      if (buttonField7.BackColor == Color.Black) buttonField7.BackColor = Color.White;
      else if (buttonField7.BackColor == Color.White) buttonField7.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

    private void buttonField5_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField5.BackColor == Color.Black) buttonField5.BackColor = Color.White;
      else if (buttonField5.BackColor == Color.White) buttonField5.BackColor = Color.Black;
      if (buttonField2.BackColor == Color.Black) buttonField2.BackColor = Color.White;
      else if (buttonField2.BackColor == Color.White) buttonField2.BackColor = Color.Black;
      if (buttonField4.BackColor == Color.Black) buttonField4.BackColor = Color.White;
      else if (buttonField4.BackColor == Color.White) buttonField4.BackColor = Color.Black;
      if (buttonField6.BackColor == Color.Black) buttonField6.BackColor = Color.White;
      else if (buttonField6.BackColor == Color.White) buttonField6.BackColor = Color.Black;
      if (buttonField8.BackColor == Color.Black) buttonField8.BackColor = Color.White;
      else if (buttonField8.BackColor == Color.White) buttonField8.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

    private void buttonField6_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField6.BackColor == Color.Black) buttonField6.BackColor = Color.White;
      else if (buttonField6.BackColor == Color.White) buttonField6.BackColor = Color.Black;
      if (buttonField3.BackColor == Color.Black) buttonField3.BackColor = Color.White;
      else if (buttonField3.BackColor == Color.White) buttonField3.BackColor = Color.Black;
      if (buttonField5.BackColor == Color.Black) buttonField5.BackColor = Color.White;
      else if (buttonField5.BackColor == Color.White) buttonField5.BackColor = Color.Black;
      if (buttonField9.BackColor == Color.Black) buttonField9.BackColor = Color.White;
      else if (buttonField9.BackColor == Color.White) buttonField9.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

    private void buttonField7_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField7.BackColor == Color.Black) buttonField7.BackColor = Color.White;
      else if (buttonField7.BackColor == Color.White) buttonField7.BackColor = Color.Black;
      if (buttonField4.BackColor == Color.Black) buttonField4.BackColor = Color.White;
      else if (buttonField4.BackColor == Color.White) buttonField4.BackColor = Color.Black;
      if (buttonField8.BackColor == Color.Black) buttonField8.BackColor = Color.White;
      else if (buttonField8.BackColor == Color.White) buttonField8.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

    private void buttonField8_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField8.BackColor == Color.Black) buttonField8.BackColor = Color.White;
      else if (buttonField8.BackColor == Color.White) buttonField8.BackColor = Color.Black;
      if (buttonField5.BackColor == Color.Black) buttonField5.BackColor = Color.White;
      else if (buttonField5.BackColor == Color.White) buttonField5.BackColor = Color.Black;
      if (buttonField7.BackColor == Color.Black) buttonField7.BackColor = Color.White;
      else if (buttonField7.BackColor == Color.White) buttonField7.BackColor = Color.Black;
      if (buttonField9.BackColor == Color.Black) buttonField9.BackColor = Color.White;
      else if (buttonField9.BackColor == Color.White) buttonField9.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

    private void buttonField9_Click(object sender, EventArgs e)
    {
      CheckForEnabledTimer();
      if (buttonField9.BackColor == Color.Black) buttonField9.BackColor = Color.White;
      else if (buttonField9.BackColor == Color.White) buttonField9.BackColor = Color.Black;
      if (buttonField6.BackColor == Color.Black) buttonField6.BackColor = Color.White;
      else if (buttonField6.BackColor == Color.White) buttonField6.BackColor = Color.Black;
      if (buttonField8.BackColor == Color.Black) buttonField8.BackColor = Color.White;
      else if (buttonField8.BackColor == Color.White) buttonField8.BackColor = Color.Black;
      UpdateClicks();
      CheckForWin();
    }

  }
}
