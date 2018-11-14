namespace Black_n_White
{
  partial class Black_n_WhiteForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Black_n_WhiteForm));
      this.buttonNewGame = new System.Windows.Forms.Button();
      this.buttonQuitGame = new System.Windows.Forms.Button();
      this.buttonGameConcept = new System.Windows.Forms.Button();
      this.labelClicks = new System.Windows.Forms.Label();
      this.labelTicks = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.buttonField1 = new System.Windows.Forms.Button();
      this.buttonField2 = new System.Windows.Forms.Button();
      this.buttonField3 = new System.Windows.Forms.Button();
      this.buttonField6 = new System.Windows.Forms.Button();
      this.buttonField5 = new System.Windows.Forms.Button();
      this.buttonField4 = new System.Windows.Forms.Button();
      this.buttonField9 = new System.Windows.Forms.Button();
      this.buttonField8 = new System.Windows.Forms.Button();
      this.buttonField7 = new System.Windows.Forms.Button();
      this.buttonField10 = new System.Windows.Forms.Button();
      this.buttonField15 = new System.Windows.Forms.Button();
      this.buttonField14 = new System.Windows.Forms.Button();
      this.buttonField13 = new System.Windows.Forms.Button();
      this.buttonField12 = new System.Windows.Forms.Button();
      this.buttonField11 = new System.Windows.Forms.Button();
      this.buttonField20 = new System.Windows.Forms.Button();
      this.buttonField19 = new System.Windows.Forms.Button();
      this.buttonField18 = new System.Windows.Forms.Button();
      this.buttonField17 = new System.Windows.Forms.Button();
      this.buttonField16 = new System.Windows.Forms.Button();
      this.buttonField25 = new System.Windows.Forms.Button();
      this.buttonField24 = new System.Windows.Forms.Button();
      this.buttonField23 = new System.Windows.Forms.Button();
      this.buttonField22 = new System.Windows.Forms.Button();
      this.buttonField21 = new System.Windows.Forms.Button();
      this.buttonOptions = new System.Windows.Forms.Button();
      this.buttonNewGamesize = new System.Windows.Forms.Button();
      this.labelGamesize = new System.Windows.Forms.Label();
      this.labelBlacks = new System.Windows.Forms.Label();
      this.labelWhites = new System.Windows.Forms.Label();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.contextMenuStripGamesize = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItemGamesize3x3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemGamesize4x4 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemGamesize5x5 = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStripNeighbourhood = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItemNeighbourhoodLinear = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemNeighbourhoodDiagonal = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemNeighbourhoodCombined = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItemNeighbourhoodCentered = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.contextMenuStripGamesize.SuspendLayout();
      this.contextMenuStripNeighbourhood.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonNewGame
      // 
      this.buttonNewGame.AccessibleDescription = "Startet ein neues Spiel";
      this.buttonNewGame.AccessibleName = "Neues Spiel";
      this.buttonNewGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonNewGame.Location = new System.Drawing.Point(264, 8);
      this.buttonNewGame.Name = "buttonNewGame";
      this.buttonNewGame.Size = new System.Drawing.Size(72, 23);
      this.buttonNewGame.TabIndex = 0;
      this.buttonNewGame.Text = "&Neues Spiel";
      this.toolTip.SetToolTip(this.buttonNewGame, "Startet ein neues Spiel");
      this.buttonNewGame.UseVisualStyleBackColor = true;
      this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
      this.buttonNewGame.Enter += new System.EventHandler(this.buttonNewGame_Enter);
      this.buttonNewGame.Leave += new System.EventHandler(this.buttonNewGame_Leave);
      this.buttonNewGame.MouseEnter += new System.EventHandler(this.buttonNewGame_MouseEnter);
      this.buttonNewGame.MouseLeave += new System.EventHandler(this.buttonNewGame_MouseLeave);
      // 
      // buttonQuitGame
      // 
      this.buttonQuitGame.AccessibleDescription = "Beendet das Spiel";
      this.buttonQuitGame.AccessibleName = "Spiel beenden";
      this.buttonQuitGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonQuitGame.Location = new System.Drawing.Point(264, 104);
      this.buttonQuitGame.Name = "buttonQuitGame";
      this.buttonQuitGame.Size = new System.Drawing.Size(90, 23);
      this.buttonQuitGame.TabIndex = 4;
      this.buttonQuitGame.Text = "Spiel &beenden";
      this.toolTip.SetToolTip(this.buttonQuitGame, "Beendet das Spiel");
      this.buttonQuitGame.UseVisualStyleBackColor = true;
      this.buttonQuitGame.Click += new System.EventHandler(this.buttonQuitGame_Click);
      this.buttonQuitGame.Enter += new System.EventHandler(this.buttonQuitGame_Enter);
      this.buttonQuitGame.Leave += new System.EventHandler(this.buttonQuitGame_Leave);
      this.buttonQuitGame.MouseEnter += new System.EventHandler(this.buttonQuitGame_MouseEnter);
      this.buttonQuitGame.MouseLeave += new System.EventHandler(this.buttonQuitGame_MouseLeave);
      // 
      // buttonGameConcept
      // 
      this.buttonGameConcept.AccessibleDescription = "Erläutert das Spielprinzip";
      this.buttonGameConcept.AccessibleName = "Spielprinzip";
      this.buttonGameConcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonGameConcept.Location = new System.Drawing.Point(264, 72);
      this.buttonGameConcept.Name = "buttonGameConcept";
      this.buttonGameConcept.Size = new System.Drawing.Size(89, 23);
      this.buttonGameConcept.TabIndex = 3;
      this.buttonGameConcept.Text = "Spiel&prinzip";
      this.toolTip.SetToolTip(this.buttonGameConcept, "Erläutert das Spielprinzip");
      this.buttonGameConcept.UseVisualStyleBackColor = true;
      this.buttonGameConcept.Click += new System.EventHandler(this.buttonGameConcept_Click);
      this.buttonGameConcept.Enter += new System.EventHandler(this.buttonGameConcept_Enter);
      this.buttonGameConcept.Leave += new System.EventHandler(this.buttonGameConcept_Leave);
      this.buttonGameConcept.MouseEnter += new System.EventHandler(this.buttonGameConcept_MouseEnter);
      this.buttonGameConcept.MouseLeave += new System.EventHandler(this.buttonGameConcept_MouseLeave);
      // 
      // labelClicks
      // 
      this.labelClicks.AccessibleDescription = "Zeigt die Anzahl der Klicks an";
      this.labelClicks.AccessibleName = "Klicks";
      this.labelClicks.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
      this.labelClicks.AutoSize = true;
      this.labelClicks.Location = new System.Drawing.Point(264, 176);
      this.labelClicks.Name = "labelClicks";
      this.labelClicks.Size = new System.Drawing.Size(38, 13);
      this.labelClicks.TabIndex = 6;
      this.labelClicks.Text = "Klicks:";
      this.toolTip.SetToolTip(this.labelClicks, "Zeigt die Anzahl der Klicks an");
      this.labelClicks.Enter += new System.EventHandler(this.labelClicks_Enter);
      this.labelClicks.Leave += new System.EventHandler(this.labelClicks_Leave);
      this.labelClicks.MouseEnter += new System.EventHandler(this.labelClicks_MouseEnter);
      this.labelClicks.MouseLeave += new System.EventHandler(this.labelClicks_MouseLeave);
      // 
      // labelTicks
      // 
      this.labelTicks.AccessibleDescription = "Zeigt die Anzahl der Ticks an";
      this.labelTicks.AccessibleName = "Ticks";
      this.labelTicks.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
      this.labelTicks.AutoSize = true;
      this.labelTicks.Location = new System.Drawing.Point(264, 192);
      this.labelTicks.Name = "labelTicks";
      this.labelTicks.Size = new System.Drawing.Size(36, 13);
      this.labelTicks.TabIndex = 7;
      this.labelTicks.Text = "Ticks:";
      this.toolTip.SetToolTip(this.labelTicks, "Zeigt die Anzahl der Ticks an");
      this.labelTicks.Enter += new System.EventHandler(this.labelTicks_Enter);
      this.labelTicks.Leave += new System.EventHandler(this.labelTicks_Leave);
      this.labelTicks.MouseEnter += new System.EventHandler(this.labelTicks_MouseEnter);
      this.labelTicks.MouseLeave += new System.EventHandler(this.labelTicks_MouseLeave);
      // 
      // timer
      // 
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // buttonField1
      // 
      this.buttonField1.AccessibleDescription = "Zeigt das Feld 1x1 an";
      this.buttonField1.AccessibleName = "Feld 1x1";
      this.buttonField1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField1.Location = new System.Drawing.Point(16, 8);
      this.buttonField1.Name = "buttonField1";
      this.buttonField1.Size = new System.Drawing.Size(48, 48);
      this.buttonField1.TabIndex = 10;
      this.buttonField1.UseVisualStyleBackColor = true;
      this.buttonField1.Click += new System.EventHandler(this.buttonField1_Click);
      this.buttonField1.Enter += new System.EventHandler(this.buttonField1_Enter);
      this.buttonField1.Leave += new System.EventHandler(this.buttonField1_Leave);
      this.buttonField1.MouseEnter += new System.EventHandler(this.buttonField1_MouseEnter);
      this.buttonField1.MouseHover += new System.EventHandler(this.buttonField1_MouseHover);
      // 
      // buttonField2
      // 
      this.buttonField2.AccessibleDescription = "Zeigt das Feld 1x2 an";
      this.buttonField2.AccessibleName = "Feld 1x2";
      this.buttonField2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField2.Location = new System.Drawing.Point(64, 8);
      this.buttonField2.Name = "buttonField2";
      this.buttonField2.Size = new System.Drawing.Size(48, 48);
      this.buttonField2.TabIndex = 11;
      this.buttonField2.UseVisualStyleBackColor = true;
      this.buttonField2.Click += new System.EventHandler(this.buttonField2_Click);
      this.buttonField2.Enter += new System.EventHandler(this.buttonField2_Enter);
      this.buttonField2.Leave += new System.EventHandler(this.buttonField2_Leave);
      this.buttonField2.MouseEnter += new System.EventHandler(this.buttonField2_MouseEnter);
      this.buttonField2.MouseHover += new System.EventHandler(this.buttonField2_MouseHover);
      // 
      // buttonField3
      // 
      this.buttonField3.AccessibleDescription = "Zeigt das Feld 1x3 an";
      this.buttonField3.AccessibleName = "Feld 1x3";
      this.buttonField3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField3.Location = new System.Drawing.Point(112, 8);
      this.buttonField3.Name = "buttonField3";
      this.buttonField3.Size = new System.Drawing.Size(48, 48);
      this.buttonField3.TabIndex = 12;
      this.buttonField3.UseVisualStyleBackColor = true;
      this.buttonField3.Click += new System.EventHandler(this.buttonField3_Click);
      this.buttonField3.Enter += new System.EventHandler(this.buttonField3_Enter);
      this.buttonField3.Leave += new System.EventHandler(this.buttonField3_Leave);
      this.buttonField3.MouseEnter += new System.EventHandler(this.buttonField3_MouseEnter);
      this.buttonField3.MouseHover += new System.EventHandler(this.buttonField3_MouseHover);
      // 
      // buttonField6
      // 
      this.buttonField6.AccessibleDescription = "Zeigt das Feld 2x1 an";
      this.buttonField6.AccessibleName = "Feld 2x1";
      this.buttonField6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField6.Location = new System.Drawing.Point(16, 56);
      this.buttonField6.Name = "buttonField6";
      this.buttonField6.Size = new System.Drawing.Size(48, 48);
      this.buttonField6.TabIndex = 15;
      this.buttonField6.UseVisualStyleBackColor = true;
      this.buttonField6.Click += new System.EventHandler(this.buttonField6_Click);
      this.buttonField6.Enter += new System.EventHandler(this.buttonField6_Enter);
      this.buttonField6.Leave += new System.EventHandler(this.buttonField6_Leave);
      this.buttonField6.MouseEnter += new System.EventHandler(this.buttonField6_MouseEnter);
      // 
      // buttonField5
      // 
      this.buttonField5.AccessibleDescription = "Zeigt das Feld 1x5 an";
      this.buttonField5.AccessibleName = "Feld 1x5";
      this.buttonField5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField5.Location = new System.Drawing.Point(208, 8);
      this.buttonField5.Name = "buttonField5";
      this.buttonField5.Size = new System.Drawing.Size(48, 48);
      this.buttonField5.TabIndex = 14;
      this.buttonField5.UseVisualStyleBackColor = true;
      this.buttonField5.Click += new System.EventHandler(this.buttonField5_Click);
      this.buttonField5.Enter += new System.EventHandler(this.buttonField5_Enter);
      this.buttonField5.Leave += new System.EventHandler(this.buttonField5_Leave);
      this.buttonField5.MouseEnter += new System.EventHandler(this.buttonField5_MouseEnter);
      this.buttonField5.MouseHover += new System.EventHandler(this.buttonField5_MouseHover);
      // 
      // buttonField4
      // 
      this.buttonField4.AccessibleDescription = "Zeigt das Feld 1x4 an";
      this.buttonField4.AccessibleName = "Feld 1x4";
      this.buttonField4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField4.Location = new System.Drawing.Point(160, 8);
      this.buttonField4.Name = "buttonField4";
      this.buttonField4.Size = new System.Drawing.Size(48, 48);
      this.buttonField4.TabIndex = 13;
      this.buttonField4.UseVisualStyleBackColor = true;
      this.buttonField4.Click += new System.EventHandler(this.buttonField4_Click);
      this.buttonField4.Enter += new System.EventHandler(this.buttonField4_Enter);
      this.buttonField4.Leave += new System.EventHandler(this.buttonField4_Leave);
      this.buttonField4.MouseEnter += new System.EventHandler(this.buttonField4_MouseEnter);
      this.buttonField4.MouseHover += new System.EventHandler(this.buttonField4_MouseHover);
      // 
      // buttonField9
      // 
      this.buttonField9.AccessibleDescription = "Zeigt das Feld 2x4 an";
      this.buttonField9.AccessibleName = "Feld 2x4";
      this.buttonField9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField9.Location = new System.Drawing.Point(160, 56);
      this.buttonField9.Name = "buttonField9";
      this.buttonField9.Size = new System.Drawing.Size(48, 48);
      this.buttonField9.TabIndex = 18;
      this.buttonField9.UseVisualStyleBackColor = true;
      this.buttonField9.Click += new System.EventHandler(this.buttonField9_Click);
      this.buttonField9.Enter += new System.EventHandler(this.buttonField9_Enter);
      this.buttonField9.Leave += new System.EventHandler(this.buttonField9_Leave);
      this.buttonField9.MouseEnter += new System.EventHandler(this.buttonField9_MouseEnter);
      // 
      // buttonField8
      // 
      this.buttonField8.AccessibleDescription = "Zeigt das Feld 2x3 an";
      this.buttonField8.AccessibleName = "Feld 2x3";
      this.buttonField8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField8.Location = new System.Drawing.Point(112, 56);
      this.buttonField8.Name = "buttonField8";
      this.buttonField8.Size = new System.Drawing.Size(48, 48);
      this.buttonField8.TabIndex = 17;
      this.buttonField8.UseVisualStyleBackColor = true;
      this.buttonField8.Click += new System.EventHandler(this.buttonField8_Click);
      this.buttonField8.Enter += new System.EventHandler(this.buttonField8_Enter);
      this.buttonField8.Leave += new System.EventHandler(this.buttonField8_Leave);
      this.buttonField8.MouseEnter += new System.EventHandler(this.buttonField8_MouseEnter);
      // 
      // buttonField7
      // 
      this.buttonField7.AccessibleDescription = "Zeigt das Feld 2x2 an";
      this.buttonField7.AccessibleName = "Feld 2x2";
      this.buttonField7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField7.Location = new System.Drawing.Point(64, 56);
      this.buttonField7.Name = "buttonField7";
      this.buttonField7.Size = new System.Drawing.Size(48, 48);
      this.buttonField7.TabIndex = 16;
      this.buttonField7.UseVisualStyleBackColor = true;
      this.buttonField7.Click += new System.EventHandler(this.buttonField7_Click);
      this.buttonField7.Enter += new System.EventHandler(this.buttonField7_Enter);
      this.buttonField7.Leave += new System.EventHandler(this.buttonField7_Leave);
      this.buttonField7.MouseEnter += new System.EventHandler(this.buttonField7_MouseEnter);
      // 
      // buttonField10
      // 
      this.buttonField10.AccessibleDescription = "Zeigt das Feld 2x5 an";
      this.buttonField10.AccessibleName = "Feld 2x5";
      this.buttonField10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField10.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField10.Location = new System.Drawing.Point(208, 56);
      this.buttonField10.Name = "buttonField10";
      this.buttonField10.Size = new System.Drawing.Size(48, 48);
      this.buttonField10.TabIndex = 19;
      this.buttonField10.UseVisualStyleBackColor = true;
      this.buttonField10.Click += new System.EventHandler(this.buttonField10_Click);
      this.buttonField10.Enter += new System.EventHandler(this.buttonField10_Enter);
      this.buttonField10.Leave += new System.EventHandler(this.buttonField10_Leave);
      this.buttonField10.MouseEnter += new System.EventHandler(this.buttonField10_MouseEnter);
      // 
      // buttonField15
      // 
      this.buttonField15.AccessibleDescription = "Zeigt das Feld 3x5 an";
      this.buttonField15.AccessibleName = "Feld 3x5";
      this.buttonField15.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField15.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField15.Location = new System.Drawing.Point(208, 104);
      this.buttonField15.Name = "buttonField15";
      this.buttonField15.Size = new System.Drawing.Size(48, 48);
      this.buttonField15.TabIndex = 24;
      this.buttonField15.UseVisualStyleBackColor = true;
      this.buttonField15.Click += new System.EventHandler(this.buttonField15_Click);
      this.buttonField15.Enter += new System.EventHandler(this.buttonField15_Enter);
      this.buttonField15.Leave += new System.EventHandler(this.buttonField15_Leave);
      this.buttonField15.MouseEnter += new System.EventHandler(this.buttonField15_MouseEnter);
      this.buttonField15.MouseHover += new System.EventHandler(this.buttonField15_MouseHover);
      // 
      // buttonField14
      // 
      this.buttonField14.AccessibleDescription = "Zeigt das Feld 3x4 an";
      this.buttonField14.AccessibleName = "Feld 3x4";
      this.buttonField14.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField14.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField14.Location = new System.Drawing.Point(160, 104);
      this.buttonField14.Name = "buttonField14";
      this.buttonField14.Size = new System.Drawing.Size(48, 48);
      this.buttonField14.TabIndex = 23;
      this.buttonField14.UseVisualStyleBackColor = true;
      this.buttonField14.Click += new System.EventHandler(this.buttonField14_Click);
      this.buttonField14.Enter += new System.EventHandler(this.buttonField14_Enter);
      this.buttonField14.Leave += new System.EventHandler(this.buttonField14_Leave);
      this.buttonField14.MouseEnter += new System.EventHandler(this.buttonField14_MouseEnter);
      this.buttonField14.MouseHover += new System.EventHandler(this.buttonField14_MouseHover);
      // 
      // buttonField13
      // 
      this.buttonField13.AccessibleDescription = "Zeigt das Feld 3x3 an";
      this.buttonField13.AccessibleName = "Feld 3x3";
      this.buttonField13.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField13.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField13.Location = new System.Drawing.Point(112, 104);
      this.buttonField13.Name = "buttonField13";
      this.buttonField13.Size = new System.Drawing.Size(48, 48);
      this.buttonField13.TabIndex = 22;
      this.buttonField13.UseVisualStyleBackColor = true;
      this.buttonField13.Click += new System.EventHandler(this.buttonField13_Click);
      this.buttonField13.Enter += new System.EventHandler(this.buttonField13_Enter);
      this.buttonField13.Leave += new System.EventHandler(this.buttonField13_Leave);
      this.buttonField13.MouseEnter += new System.EventHandler(this.buttonField13_MouseEnter);
      this.buttonField13.MouseHover += new System.EventHandler(this.buttonField13_MouseHover);
      // 
      // buttonField12
      // 
      this.buttonField12.AccessibleDescription = "Zeigt das Feld 3x2 an";
      this.buttonField12.AccessibleName = "Feld 3x2";
      this.buttonField12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField12.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField12.Location = new System.Drawing.Point(64, 104);
      this.buttonField12.Name = "buttonField12";
      this.buttonField12.Size = new System.Drawing.Size(48, 48);
      this.buttonField12.TabIndex = 21;
      this.buttonField12.UseVisualStyleBackColor = true;
      this.buttonField12.Click += new System.EventHandler(this.buttonField12_Click);
      this.buttonField12.Enter += new System.EventHandler(this.buttonField12_Enter);
      this.buttonField12.Leave += new System.EventHandler(this.buttonField12_Leave);
      this.buttonField12.MouseEnter += new System.EventHandler(this.buttonField12_MouseEnter);
      this.buttonField12.MouseHover += new System.EventHandler(this.buttonField12_MouseHover);
      // 
      // buttonField11
      // 
      this.buttonField11.AccessibleDescription = "Zeigt das Feld 3x1 an";
      this.buttonField11.AccessibleName = "Feld 3x1";
      this.buttonField11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField11.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField11.Location = new System.Drawing.Point(16, 104);
      this.buttonField11.Name = "buttonField11";
      this.buttonField11.Size = new System.Drawing.Size(48, 48);
      this.buttonField11.TabIndex = 20;
      this.buttonField11.UseVisualStyleBackColor = true;
      this.buttonField11.Click += new System.EventHandler(this.buttonField11_Click);
      this.buttonField11.Enter += new System.EventHandler(this.buttonField11_Enter);
      this.buttonField11.Leave += new System.EventHandler(this.buttonField11_Leave);
      this.buttonField11.MouseEnter += new System.EventHandler(this.buttonField11_MouseEnter);
      this.buttonField11.MouseHover += new System.EventHandler(this.buttonField11_MouseHover);
      // 
      // buttonField20
      // 
      this.buttonField20.AccessibleDescription = "Zeigt das Feld 4x5 an";
      this.buttonField20.AccessibleName = "Feld 4x5";
      this.buttonField20.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField20.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField20.Location = new System.Drawing.Point(208, 152);
      this.buttonField20.Name = "buttonField20";
      this.buttonField20.Size = new System.Drawing.Size(48, 48);
      this.buttonField20.TabIndex = 29;
      this.buttonField20.UseVisualStyleBackColor = true;
      this.buttonField20.Click += new System.EventHandler(this.buttonField20_Click);
      this.buttonField20.Enter += new System.EventHandler(this.buttonField20_Enter);
      this.buttonField20.Leave += new System.EventHandler(this.buttonField20_Leave);
      this.buttonField20.MouseEnter += new System.EventHandler(this.buttonField20_MouseEnter);
      this.buttonField20.MouseHover += new System.EventHandler(this.buttonField20_MouseHover);
      // 
      // buttonField19
      // 
      this.buttonField19.AccessibleDescription = "Zeigt das Feld 4x4 an";
      this.buttonField19.AccessibleName = "Feld 4x4";
      this.buttonField19.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField19.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField19.Location = new System.Drawing.Point(160, 152);
      this.buttonField19.Name = "buttonField19";
      this.buttonField19.Size = new System.Drawing.Size(48, 48);
      this.buttonField19.TabIndex = 28;
      this.buttonField19.UseVisualStyleBackColor = true;
      this.buttonField19.Click += new System.EventHandler(this.buttonField19_Click);
      this.buttonField19.Enter += new System.EventHandler(this.buttonField19_Enter);
      this.buttonField19.Leave += new System.EventHandler(this.buttonField19_Leave);
      this.buttonField19.MouseEnter += new System.EventHandler(this.buttonField19_MouseEnter);
      this.buttonField19.MouseHover += new System.EventHandler(this.buttonField19_MouseHover);
      // 
      // buttonField18
      // 
      this.buttonField18.AccessibleDescription = "Zeigt das Feld 4x3 an";
      this.buttonField18.AccessibleName = "Feld 4x3";
      this.buttonField18.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField18.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField18.Location = new System.Drawing.Point(112, 152);
      this.buttonField18.Name = "buttonField18";
      this.buttonField18.Size = new System.Drawing.Size(48, 48);
      this.buttonField18.TabIndex = 27;
      this.buttonField18.UseVisualStyleBackColor = true;
      this.buttonField18.Click += new System.EventHandler(this.buttonField18_Click);
      this.buttonField18.Enter += new System.EventHandler(this.buttonField18_Enter);
      this.buttonField18.Leave += new System.EventHandler(this.buttonField18_Leave);
      this.buttonField18.MouseEnter += new System.EventHandler(this.buttonField18_MouseEnter);
      this.buttonField18.MouseHover += new System.EventHandler(this.buttonField18_MouseHover);
      // 
      // buttonField17
      // 
      this.buttonField17.AccessibleDescription = "Zeigt das Feld 4x2 an";
      this.buttonField17.AccessibleName = "Feld 4x2";
      this.buttonField17.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField17.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField17.Location = new System.Drawing.Point(64, 152);
      this.buttonField17.Name = "buttonField17";
      this.buttonField17.Size = new System.Drawing.Size(48, 48);
      this.buttonField17.TabIndex = 26;
      this.buttonField17.UseVisualStyleBackColor = true;
      this.buttonField17.Click += new System.EventHandler(this.buttonField17_Click);
      this.buttonField17.Enter += new System.EventHandler(this.buttonField17_Enter);
      this.buttonField17.Leave += new System.EventHandler(this.buttonField17_Leave);
      this.buttonField17.MouseEnter += new System.EventHandler(this.buttonField17_MouseEnter);
      this.buttonField17.MouseHover += new System.EventHandler(this.buttonField17_MouseHover);
      // 
      // buttonField16
      // 
      this.buttonField16.AccessibleDescription = "Zeigt das Feld 4x1 an";
      this.buttonField16.AccessibleName = "Feld 4x1";
      this.buttonField16.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField16.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField16.Location = new System.Drawing.Point(16, 152);
      this.buttonField16.Name = "buttonField16";
      this.buttonField16.Size = new System.Drawing.Size(48, 48);
      this.buttonField16.TabIndex = 25;
      this.buttonField16.UseVisualStyleBackColor = true;
      this.buttonField16.Click += new System.EventHandler(this.buttonField16_Click);
      this.buttonField16.Enter += new System.EventHandler(this.buttonField16_Enter);
      this.buttonField16.Leave += new System.EventHandler(this.buttonField16_Leave);
      this.buttonField16.MouseEnter += new System.EventHandler(this.buttonField16_MouseEnter);
      this.buttonField16.MouseHover += new System.EventHandler(this.buttonField16_MouseHover);
      // 
      // buttonField25
      // 
      this.buttonField25.AccessibleDescription = "Zeigt das Feld 5x5 an";
      this.buttonField25.AccessibleName = "Feld 5x5";
      this.buttonField25.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField25.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField25.Location = new System.Drawing.Point(208, 200);
      this.buttonField25.Name = "buttonField25";
      this.buttonField25.Size = new System.Drawing.Size(48, 48);
      this.buttonField25.TabIndex = 34;
      this.buttonField25.UseVisualStyleBackColor = true;
      this.buttonField25.Click += new System.EventHandler(this.buttonField25_Click);
      this.buttonField25.Enter += new System.EventHandler(this.buttonField25_Enter);
      this.buttonField25.Leave += new System.EventHandler(this.buttonField25_Leave);
      this.buttonField25.MouseEnter += new System.EventHandler(this.buttonField25_MouseEnter);
      this.buttonField25.MouseHover += new System.EventHandler(this.buttonField25_MouseHover);
      // 
      // buttonField24
      // 
      this.buttonField24.AccessibleDescription = "Zeigt das Feld 5x4 an";
      this.buttonField24.AccessibleName = "Feld 5x4";
      this.buttonField24.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField24.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField24.Location = new System.Drawing.Point(160, 200);
      this.buttonField24.Name = "buttonField24";
      this.buttonField24.Size = new System.Drawing.Size(48, 48);
      this.buttonField24.TabIndex = 33;
      this.buttonField24.UseVisualStyleBackColor = true;
      this.buttonField24.Click += new System.EventHandler(this.buttonField24_Click);
      this.buttonField24.Enter += new System.EventHandler(this.buttonField24_Enter);
      this.buttonField24.Leave += new System.EventHandler(this.buttonField24_Leave);
      this.buttonField24.MouseEnter += new System.EventHandler(this.buttonField24_MouseEnter);
      this.buttonField24.MouseHover += new System.EventHandler(this.buttonField24_MouseHover);
      // 
      // buttonField23
      // 
      this.buttonField23.AccessibleDescription = "Zeigt das Feld 5x3 an";
      this.buttonField23.AccessibleName = "Feld 5x3";
      this.buttonField23.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField23.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField23.Location = new System.Drawing.Point(112, 200);
      this.buttonField23.Name = "buttonField23";
      this.buttonField23.Size = new System.Drawing.Size(48, 48);
      this.buttonField23.TabIndex = 32;
      this.buttonField23.UseVisualStyleBackColor = true;
      this.buttonField23.Click += new System.EventHandler(this.buttonField23_Click);
      this.buttonField23.Enter += new System.EventHandler(this.buttonField23_Enter);
      this.buttonField23.Leave += new System.EventHandler(this.buttonField23_Leave);
      this.buttonField23.MouseEnter += new System.EventHandler(this.buttonField23_MouseEnter);
      this.buttonField23.MouseHover += new System.EventHandler(this.buttonField23_MouseHover);
      // 
      // buttonField22
      // 
      this.buttonField22.AccessibleDescription = "Zeigt das Feld 5x2 an";
      this.buttonField22.AccessibleName = "Feld 5x2";
      this.buttonField22.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField22.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField22.Location = new System.Drawing.Point(64, 200);
      this.buttonField22.Name = "buttonField22";
      this.buttonField22.Size = new System.Drawing.Size(48, 48);
      this.buttonField22.TabIndex = 31;
      this.buttonField22.UseVisualStyleBackColor = true;
      this.buttonField22.Click += new System.EventHandler(this.buttonField22_Click);
      this.buttonField22.Enter += new System.EventHandler(this.buttonField22_Enter);
      this.buttonField22.Leave += new System.EventHandler(this.buttonField22_Leave);
      this.buttonField22.MouseEnter += new System.EventHandler(this.buttonField22_MouseEnter);
      this.buttonField22.MouseHover += new System.EventHandler(this.buttonField22_MouseHover);
      // 
      // buttonField21
      // 
      this.buttonField21.AccessibleDescription = "Zeigt das Feld 5x1 an";
      this.buttonField21.AccessibleName = "Feld 5x1";
      this.buttonField21.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonField21.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField21.Location = new System.Drawing.Point(16, 200);
      this.buttonField21.Name = "buttonField21";
      this.buttonField21.Size = new System.Drawing.Size(48, 48);
      this.buttonField21.TabIndex = 30;
      this.buttonField21.UseVisualStyleBackColor = true;
      this.buttonField21.Click += new System.EventHandler(this.buttonField21_Click);
      this.buttonField21.Enter += new System.EventHandler(this.buttonField21_Enter);
      this.buttonField21.Leave += new System.EventHandler(this.buttonField21_Leave);
      this.buttonField21.MouseEnter += new System.EventHandler(this.buttonField21_MouseEnter);
      this.buttonField21.MouseHover += new System.EventHandler(this.buttonField21_MouseHover);
      // 
      // buttonOptions
      // 
      this.buttonOptions.AccessibleDescription = "Wählt die Einstellungen des Spielverhaltens";
      this.buttonOptions.AccessibleName = "Einstellungen";
      this.buttonOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonOptions.Location = new System.Drawing.Point(264, 40);
      this.buttonOptions.Name = "buttonOptions";
      this.buttonOptions.Size = new System.Drawing.Size(89, 23);
      this.buttonOptions.TabIndex = 2;
      this.buttonOptions.Text = "&Einstellungen";
      this.toolTip.SetToolTip(this.buttonOptions, "Wählt die Einstellungen des Spielverhaltens");
      this.buttonOptions.UseVisualStyleBackColor = true;
      this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
      this.buttonOptions.Enter += new System.EventHandler(this.buttonOptions_Enter);
      this.buttonOptions.Leave += new System.EventHandler(this.buttonOptions_Leave);
      this.buttonOptions.MouseEnter += new System.EventHandler(this.buttonOptions_MouseEnter);
      this.buttonOptions.MouseLeave += new System.EventHandler(this.buttonOptions_MouseLeave);
      // 
      // buttonNewGamesize
      // 
      this.buttonNewGamesize.AccessibleDescription = "Wählt die Größe des Spielfeldes aus";
      this.buttonNewGamesize.AccessibleName = "Größe des Spielfeldes";
      this.buttonNewGamesize.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.buttonNewGamesize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonNewGamesize.Location = new System.Drawing.Point(336, 8);
      this.buttonNewGamesize.Name = "buttonNewGamesize";
      this.buttonNewGamesize.Size = new System.Drawing.Size(16, 23);
      this.buttonNewGamesize.TabIndex = 1;
      this.buttonNewGamesize.Text = "▼";
      this.toolTip.SetToolTip(this.buttonNewGamesize, "Wählt die Größe des Spielfeldes aus");
      this.buttonNewGamesize.UseVisualStyleBackColor = true;
      this.buttonNewGamesize.Click += new System.EventHandler(this.buttonNewGamesize_Click);
      this.buttonNewGamesize.Enter += new System.EventHandler(this.buttonNewGamesize_Enter);
      this.buttonNewGamesize.Leave += new System.EventHandler(this.buttonNewGamesize_Leave);
      this.buttonNewGamesize.MouseEnter += new System.EventHandler(this.buttonNewGamesize_MouseEnter);
      this.buttonNewGamesize.MouseLeave += new System.EventHandler(this.buttonNewGamesize_MouseLeave);
      // 
      // labelGamesize
      // 
      this.labelGamesize.AccessibleDescription = "Zeigt die Größe des Spielfeldes an";
      this.labelGamesize.AccessibleName = "Größe des Spielfeldes";
      this.labelGamesize.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
      this.labelGamesize.AutoSize = true;
      this.labelGamesize.Location = new System.Drawing.Point(264, 152);
      this.labelGamesize.Name = "labelGamesize";
      this.labelGamesize.Size = new System.Drawing.Size(59, 13);
      this.labelGamesize.TabIndex = 5;
      this.labelGamesize.Text = "Größe: 5x5";
      this.toolTip.SetToolTip(this.labelGamesize, "Zeigt die Größe des Spielfeldes an");
      this.labelGamesize.Enter += new System.EventHandler(this.labelGamesize_Enter);
      this.labelGamesize.Leave += new System.EventHandler(this.labelGamesize_Leave);
      this.labelGamesize.MouseEnter += new System.EventHandler(this.labelGamesize_MouseEnter);
      this.labelGamesize.MouseLeave += new System.EventHandler(this.labelGamesize_MouseLeave);
      // 
      // labelBlacks
      // 
      this.labelBlacks.AccessibleDescription = "Zeigt die Anzahl der schwarzen Felder an";
      this.labelBlacks.AccessibleName = "Blacks";
      this.labelBlacks.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
      this.labelBlacks.AutoSize = true;
      this.labelBlacks.Location = new System.Drawing.Point(264, 216);
      this.labelBlacks.Name = "labelBlacks";
      this.labelBlacks.Size = new System.Drawing.Size(42, 13);
      this.labelBlacks.TabIndex = 8;
      this.labelBlacks.Text = "Blacks:";
      this.toolTip.SetToolTip(this.labelBlacks, "Zeigt die Anzahl der schwarzen Felder an");
      this.labelBlacks.Enter += new System.EventHandler(this.labelBlacks_Enter);
      this.labelBlacks.Leave += new System.EventHandler(this.labelBlacks_Leave);
      this.labelBlacks.MouseEnter += new System.EventHandler(this.labelBlacks_MouseEnter);
      this.labelBlacks.MouseLeave += new System.EventHandler(this.labelBlacks_MouseLeave);
      // 
      // labelWhites
      // 
      this.labelWhites.AccessibleDescription = "Zeigt die Anzahl der weißen Felder an";
      this.labelWhites.AccessibleName = "Whites";
      this.labelWhites.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
      this.labelWhites.AutoSize = true;
      this.labelWhites.Location = new System.Drawing.Point(264, 232);
      this.labelWhites.Name = "labelWhites";
      this.labelWhites.Size = new System.Drawing.Size(40, 13);
      this.labelWhites.TabIndex = 9;
      this.labelWhites.Text = "Whites";
      this.toolTip.SetToolTip(this.labelWhites, "Zeigt die Anzahl der weißen Felder an");
      this.labelWhites.Enter += new System.EventHandler(this.labelWhites_Enter);
      this.labelWhites.Leave += new System.EventHandler(this.labelWhites_Leave);
      this.labelWhites.MouseEnter += new System.EventHandler(this.labelWhites_MouseEnter);
      this.labelWhites.MouseLeave += new System.EventHandler(this.labelWhites_MouseLeave);
      // 
      // contextMenuStripGamesize
      // 
      this.contextMenuStripGamesize.AccessibleDescription = "Öffnet das Menü für die Einstellung der Größe des Spielfeldes";
      this.contextMenuStripGamesize.AccessibleName = "Einstellung der Größe des Spielfeldes";
      this.contextMenuStripGamesize.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
      this.contextMenuStripGamesize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGamesize3x3,
            this.toolStripMenuItemGamesize4x4,
            this.toolStripMenuItemGamesize5x5});
      this.contextMenuStripGamesize.Name = "contextMenuStripGamesize";
      this.contextMenuStripGamesize.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.contextMenuStripGamesize.ShowCheckMargin = true;
      this.contextMenuStripGamesize.ShowImageMargin = false;
      this.contextMenuStripGamesize.Size = new System.Drawing.Size(92, 70);
      this.contextMenuStripGamesize.TabStop = true;
      this.contextMenuStripGamesize.Text = "Spielfeldgröße";
      this.toolTip.SetToolTip(this.contextMenuStripGamesize, "Öffnet das Menü für die Einstellung der Größe des Spielfeldes");
      this.contextMenuStripGamesize.MouseEnter += new System.EventHandler(this.contextMenuStripGamesize_MouseEnter);
      this.contextMenuStripGamesize.MouseLeave += new System.EventHandler(this.contextMenuStripGamesize_MouseLeave);
      // 
      // toolStripMenuItemGamesize3x3
      // 
      this.toolStripMenuItemGamesize3x3.AccessibleDescription = "Wählt die Größe des Spielfeld von 3x3";
      this.toolStripMenuItemGamesize3x3.AccessibleName = " Größe des Spielfeld von 3x3";
      this.toolStripMenuItemGamesize3x3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.toolStripMenuItemGamesize3x3.AutoToolTip = true;
      this.toolStripMenuItemGamesize3x3.CheckOnClick = true;
      this.toolStripMenuItemGamesize3x3.DoubleClickEnabled = true;
      this.toolStripMenuItemGamesize3x3.Name = "toolStripMenuItemGamesize3x3";
      this.toolStripMenuItemGamesize3x3.Size = new System.Drawing.Size(91, 22);
      this.toolStripMenuItemGamesize3x3.Text = "3x3";
      this.toolStripMenuItemGamesize3x3.ToolTipText = "Wählt die Größe des Spielfeld von 3x3";
      this.toolStripMenuItemGamesize3x3.Click += new System.EventHandler(this.ToolStripMenuItemGamesize3x3_Click);
      this.toolStripMenuItemGamesize3x3.MouseEnter += new System.EventHandler(this.toolStripMenuItemGamesize3x3_MouseEnter);
      this.toolStripMenuItemGamesize3x3.MouseLeave += new System.EventHandler(this.toolStripMenuItemGamesize3x3_MouseLeave);
      // 
      // toolStripMenuItemGamesize4x4
      // 
      this.toolStripMenuItemGamesize4x4.AccessibleDescription = "Wählt die Größe des Spielfeld von 4x4";
      this.toolStripMenuItemGamesize4x4.AccessibleName = " Größe des Spielfeld von 4x4";
      this.toolStripMenuItemGamesize4x4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.toolStripMenuItemGamesize4x4.AutoToolTip = true;
      this.toolStripMenuItemGamesize4x4.CheckOnClick = true;
      this.toolStripMenuItemGamesize4x4.DoubleClickEnabled = true;
      this.toolStripMenuItemGamesize4x4.Name = "toolStripMenuItemGamesize4x4";
      this.toolStripMenuItemGamesize4x4.Size = new System.Drawing.Size(91, 22);
      this.toolStripMenuItemGamesize4x4.Text = "4x4";
      this.toolStripMenuItemGamesize4x4.ToolTipText = "Wählt die Größe des Spielfeld von 4x4";
      this.toolStripMenuItemGamesize4x4.Click += new System.EventHandler(this.ToolStripMenuItemGamesize4x4_Click);
      this.toolStripMenuItemGamesize4x4.MouseEnter += new System.EventHandler(this.toolStripMenuItemGamesize4x4_MouseEnter);
      this.toolStripMenuItemGamesize4x4.MouseLeave += new System.EventHandler(this.toolStripMenuItemGamesize4x4_MouseLeave);
      // 
      // toolStripMenuItemGamesize5x5
      // 
      this.toolStripMenuItemGamesize5x5.AccessibleDescription = "Wählt die Größe des Spielfeld von 5x5";
      this.toolStripMenuItemGamesize5x5.AccessibleName = " Größe des Spielfeld von 4x4";
      this.toolStripMenuItemGamesize5x5.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.toolStripMenuItemGamesize5x5.AutoToolTip = true;
      this.toolStripMenuItemGamesize5x5.Checked = true;
      this.toolStripMenuItemGamesize5x5.CheckOnClick = true;
      this.toolStripMenuItemGamesize5x5.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripMenuItemGamesize5x5.DoubleClickEnabled = true;
      this.toolStripMenuItemGamesize5x5.Name = "toolStripMenuItemGamesize5x5";
      this.toolStripMenuItemGamesize5x5.Size = new System.Drawing.Size(91, 22);
      this.toolStripMenuItemGamesize5x5.Text = "5x5";
      this.toolStripMenuItemGamesize5x5.ToolTipText = "Wählt die Größe des Spielfeld von 5x5";
      this.toolStripMenuItemGamesize5x5.Click += new System.EventHandler(this.ToolStripMenuItemGamesize5x5_Click);
      this.toolStripMenuItemGamesize5x5.MouseEnter += new System.EventHandler(this.toolStripMenuItemGamesize5x5_MouseEnter);
      this.toolStripMenuItemGamesize5x5.MouseLeave += new System.EventHandler(this.toolStripMenuItemGamesize5x5_MouseLeave);
      // 
      // contextMenuStripNeighbourhood
      // 
      this.contextMenuStripNeighbourhood.AccessibleDescription = "Öffnet das Menü für die Einstellungen des Spiels";
      this.contextMenuStripNeighbourhood.AccessibleName = "Einstellungen";
      this.contextMenuStripNeighbourhood.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
      this.contextMenuStripNeighbourhood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNeighbourhoodLinear,
            this.toolStripMenuItemNeighbourhoodDiagonal,
            this.toolStripMenuItemNeighbourhoodCombined,
            this.toolStripSeparator1,
            this.toolStripMenuItemNeighbourhoodCentered});
      this.contextMenuStripNeighbourhood.Name = "contextMenuStripNeighbourhood";
      this.contextMenuStripNeighbourhood.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.contextMenuStripNeighbourhood.ShowCheckMargin = true;
      this.contextMenuStripNeighbourhood.ShowImageMargin = false;
      this.contextMenuStripNeighbourhood.Size = new System.Drawing.Size(133, 98);
      this.contextMenuStripNeighbourhood.TabStop = true;
      this.contextMenuStripNeighbourhood.Text = "Einstellungen";
      this.toolTip.SetToolTip(this.contextMenuStripNeighbourhood, "Öffnet das Menü für die Einstellungen des Spiels");
      this.contextMenuStripNeighbourhood.MouseEnter += new System.EventHandler(this.contextMenuStripNeighbourhood_MouseEnter);
      this.contextMenuStripNeighbourhood.MouseLeave += new System.EventHandler(this.contextMenuStripNeighbourhood_MouseLeave);
      // 
      // toolStripMenuItemNeighbourhoodLinear
      // 
      this.toolStripMenuItemNeighbourhoodLinear.AccessibleDescription = "Ändert die invertierbaren Nachbar-Spielfelder auf lineare Nachbar-Spielfelder";
      this.toolStripMenuItemNeighbourhoodLinear.AccessibleName = "Linear";
      this.toolStripMenuItemNeighbourhoodLinear.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.toolStripMenuItemNeighbourhoodLinear.AutoToolTip = true;
      this.toolStripMenuItemNeighbourhoodLinear.Checked = true;
      this.toolStripMenuItemNeighbourhoodLinear.CheckOnClick = true;
      this.toolStripMenuItemNeighbourhoodLinear.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripMenuItemNeighbourhoodLinear.DoubleClickEnabled = true;
      this.toolStripMenuItemNeighbourhoodLinear.Name = "toolStripMenuItemNeighbourhoodLinear";
      this.toolStripMenuItemNeighbourhoodLinear.Size = new System.Drawing.Size(132, 22);
      this.toolStripMenuItemNeighbourhoodLinear.Text = "linear";
      this.toolStripMenuItemNeighbourhoodLinear.ToolTipText = "Ändert die invertierbaren Nachbar-Spielfelder auf lineare Nachbar-Spielfelder";
      this.toolStripMenuItemNeighbourhoodLinear.Click += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodLinear_Click);
      this.toolStripMenuItemNeighbourhoodLinear.MouseEnter += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodLinear_MouseEnter);
      this.toolStripMenuItemNeighbourhoodLinear.MouseLeave += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodLinear_MouseLeave);
      // 
      // toolStripMenuItemNeighbourhoodDiagonal
      // 
      this.toolStripMenuItemNeighbourhoodDiagonal.AccessibleDescription = "Ändert die invertierbaren Nachbar-Spielfelder auf diagonale Nachbar-Spielfelder";
      this.toolStripMenuItemNeighbourhoodDiagonal.AccessibleName = "Diagonal";
      this.toolStripMenuItemNeighbourhoodDiagonal.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.toolStripMenuItemNeighbourhoodDiagonal.CheckOnClick = true;
      this.toolStripMenuItemNeighbourhoodDiagonal.DoubleClickEnabled = true;
      this.toolStripMenuItemNeighbourhoodDiagonal.Name = "toolStripMenuItemNeighbourhoodDiagonal";
      this.toolStripMenuItemNeighbourhoodDiagonal.Size = new System.Drawing.Size(132, 22);
      this.toolStripMenuItemNeighbourhoodDiagonal.Text = "diagonal";
      this.toolStripMenuItemNeighbourhoodDiagonal.ToolTipText = "Ändert die invertierbaren Nachbar-Spielfelder auf diagonale Nachbar-Spielfelder";
      this.toolStripMenuItemNeighbourhoodDiagonal.Click += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodDiagonal_Click);
      this.toolStripMenuItemNeighbourhoodDiagonal.MouseEnter += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodDiagonal_MouseEnter);
      this.toolStripMenuItemNeighbourhoodDiagonal.MouseLeave += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodDiagonal_MouseLeave);
      // 
      // toolStripMenuItemNeighbourhoodCombined
      // 
      this.toolStripMenuItemNeighbourhoodCombined.AccessibleDescription = "Ändert die invertierbaren Nachbar-Spielfelder auf lineare und diagonale Nachbar-S" +
    "pielfelder";
      this.toolStripMenuItemNeighbourhoodCombined.AccessibleName = "Kombiniert";
      this.toolStripMenuItemNeighbourhoodCombined.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.toolStripMenuItemNeighbourhoodCombined.AutoToolTip = true;
      this.toolStripMenuItemNeighbourhoodCombined.CheckOnClick = true;
      this.toolStripMenuItemNeighbourhoodCombined.DoubleClickEnabled = true;
      this.toolStripMenuItemNeighbourhoodCombined.Name = "toolStripMenuItemNeighbourhoodCombined";
      this.toolStripMenuItemNeighbourhoodCombined.Size = new System.Drawing.Size(132, 22);
      this.toolStripMenuItemNeighbourhoodCombined.Text = "kombiniert";
      this.toolStripMenuItemNeighbourhoodCombined.ToolTipText = "Ändert die invertierbaren Nachbar-Spielfelder auf lineare und diagonale Nachbar-S" +
    "pielfelder";
      this.toolStripMenuItemNeighbourhoodCombined.Click += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodCombined_Click);
      this.toolStripMenuItemNeighbourhoodCombined.MouseEnter += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodCombined_MouseEnter);
      this.toolStripMenuItemNeighbourhoodCombined.MouseLeave += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodCombined_MouseLeave);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.AccessibleDescription = ";-P";
      this.toolStripSeparator1.AccessibleName = "Spearator";
      this.toolStripSeparator1.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
      this.toolStripSeparator1.MouseEnter += new System.EventHandler(this.toolStripSeparator1_MouseEnter);
      this.toolStripSeparator1.MouseLeave += new System.EventHandler(this.toolStripSeparator1_MouseLeave);
      // 
      // toolStripMenuItemNeighbourhoodCentered
      // 
      this.toolStripMenuItemNeighbourhoodCentered.AccessibleDescription = "Ändert, ob das eigene Feld invertiert werden soll";
      this.toolStripMenuItemNeighbourhoodCentered.AccessibleName = "Zentriert";
      this.toolStripMenuItemNeighbourhoodCentered.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
      this.toolStripMenuItemNeighbourhoodCentered.AutoToolTip = true;
      this.toolStripMenuItemNeighbourhoodCentered.Checked = true;
      this.toolStripMenuItemNeighbourhoodCentered.CheckOnClick = true;
      this.toolStripMenuItemNeighbourhoodCentered.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripMenuItemNeighbourhoodCentered.DoubleClickEnabled = true;
      this.toolStripMenuItemNeighbourhoodCentered.Name = "toolStripMenuItemNeighbourhoodCentered";
      this.toolStripMenuItemNeighbourhoodCentered.Size = new System.Drawing.Size(132, 22);
      this.toolStripMenuItemNeighbourhoodCentered.Text = "zentriert";
      this.toolStripMenuItemNeighbourhoodCentered.ToolTipText = "Ändert, ob das eigene Feld invertiert werden soll";
      this.toolStripMenuItemNeighbourhoodCentered.Click += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodCentered_Click);
      this.toolStripMenuItemNeighbourhoodCentered.MouseEnter += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodCentered_MouseEnter);
      this.toolStripMenuItemNeighbourhoodCentered.MouseLeave += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodCentered_MouseLeave);
      // 
      // statusStrip
      // 
      this.statusStrip.AccessibleDescription = "Zeigt die Statusbar an";
      this.statusStrip.AccessibleName = "Statusbar";
      this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 257);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
      this.statusStrip.Size = new System.Drawing.Size(364, 22);
      this.statusStrip.SizingGrip = false;
      this.statusStrip.TabIndex = 35;
      this.statusStrip.Text = "statusStrip";
      // 
      // toolStripStatusLabel
      // 
      this.toolStripStatusLabel.AccessibleDescription = "Zeigt den Informationstext an";
      this.toolStripStatusLabel.AccessibleName = "Informationstext";
      this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
      this.toolStripStatusLabel.AutoToolTip = true;
      this.toolStripStatusLabel.DoubleClickEnabled = true;
      this.toolStripStatusLabel.Name = "toolStripStatusLabel";
      this.toolStripStatusLabel.Size = new System.Drawing.Size(94, 17);
      this.toolStripStatusLabel.Text = "Informationstext";
      this.toolStripStatusLabel.ToolTipText = "Informationstext";
      // 
      // backgroundWorker
      // 
      this.backgroundWorker.WorkerReportsProgress = true;
      this.backgroundWorker.WorkerSupportsCancellation = true;
      this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
      this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
      this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
      // 
      // Black_n_WhiteForm
      // 
      this.AccessibleDescription = "Das ist das Programm.";
      this.AccessibleName = "Programm";
      this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(364, 279);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.labelWhites);
      this.Controls.Add(this.labelBlacks);
      this.Controls.Add(this.labelGamesize);
      this.Controls.Add(this.buttonNewGamesize);
      this.Controls.Add(this.buttonOptions);
      this.Controls.Add(this.buttonField25);
      this.Controls.Add(this.buttonField24);
      this.Controls.Add(this.buttonField23);
      this.Controls.Add(this.buttonField22);
      this.Controls.Add(this.buttonField21);
      this.Controls.Add(this.buttonField20);
      this.Controls.Add(this.buttonField19);
      this.Controls.Add(this.buttonField18);
      this.Controls.Add(this.buttonField17);
      this.Controls.Add(this.buttonField16);
      this.Controls.Add(this.buttonField15);
      this.Controls.Add(this.buttonField14);
      this.Controls.Add(this.buttonField13);
      this.Controls.Add(this.buttonField12);
      this.Controls.Add(this.buttonField11);
      this.Controls.Add(this.buttonField10);
      this.Controls.Add(this.buttonField9);
      this.Controls.Add(this.buttonField8);
      this.Controls.Add(this.buttonField7);
      this.Controls.Add(this.buttonField6);
      this.Controls.Add(this.buttonField5);
      this.Controls.Add(this.buttonField4);
      this.Controls.Add(this.buttonField3);
      this.Controls.Add(this.buttonField2);
      this.Controls.Add(this.buttonField1);
      this.Controls.Add(this.labelTicks);
      this.Controls.Add(this.labelClicks);
      this.Controls.Add(this.buttonGameConcept);
      this.Controls.Add(this.buttonQuitGame);
      this.Controls.Add(this.buttonNewGame);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Black_n_WhiteForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Black\'n\'White";
      this.Load += new System.EventHandler(this.Black_n_WhiteForm_Load);
      this.contextMenuStripGamesize.ResumeLayout(false);
      this.contextMenuStripNeighbourhood.ResumeLayout(false);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonNewGame;
    private System.Windows.Forms.Button buttonQuitGame;
    private System.Windows.Forms.Button buttonGameConcept;
    private System.Windows.Forms.Label labelClicks;
    private System.Windows.Forms.Label labelTicks;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.Button buttonField1;
    private System.Windows.Forms.Button buttonField2;
    private System.Windows.Forms.Button buttonField3;
    private System.Windows.Forms.Button buttonField6;
    private System.Windows.Forms.Button buttonField5;
    private System.Windows.Forms.Button buttonField4;
    private System.Windows.Forms.Button buttonField9;
    private System.Windows.Forms.Button buttonField8;
    private System.Windows.Forms.Button buttonField7;
    private System.Windows.Forms.Button buttonField10;
    private System.Windows.Forms.Button buttonField15;
    private System.Windows.Forms.Button buttonField14;
    private System.Windows.Forms.Button buttonField13;
    private System.Windows.Forms.Button buttonField12;
    private System.Windows.Forms.Button buttonField11;
    private System.Windows.Forms.Button buttonField20;
    private System.Windows.Forms.Button buttonField19;
    private System.Windows.Forms.Button buttonField18;
    private System.Windows.Forms.Button buttonField17;
    private System.Windows.Forms.Button buttonField16;
    private System.Windows.Forms.Button buttonField25;
    private System.Windows.Forms.Button buttonField24;
    private System.Windows.Forms.Button buttonField23;
    private System.Windows.Forms.Button buttonField22;
    private System.Windows.Forms.Button buttonField21;
    private System.Windows.Forms.Button buttonOptions;
    private System.Windows.Forms.Button buttonNewGamesize;
    private System.Windows.Forms.Label labelGamesize;
    private System.Windows.Forms.Label labelBlacks;
    private System.Windows.Forms.Label labelWhites;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripGamesize;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGamesize3x3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGamesize4x4;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGamesize5x5;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripNeighbourhood;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNeighbourhoodLinear;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNeighbourhoodDiagonal;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNeighbourhoodCombined;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNeighbourhoodCentered;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    private System.ComponentModel.BackgroundWorker backgroundWorker;
  }
}

