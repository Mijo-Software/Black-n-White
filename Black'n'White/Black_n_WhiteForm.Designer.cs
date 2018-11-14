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
      this.ToolStripMenuItemGamesize3x3 = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemGamesize4x4 = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemGamesize5x5 = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStripNeighbourhood = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ToolStripMenuItemNeighbourhoodLinear = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemNeighbourhoodDiagonal = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemNeighbourhoodCombined = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ToolStripMenuItemNeighbourhoodCentered = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStripGamesize.SuspendLayout();
      this.contextMenuStripNeighbourhood.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonNewGame
      // 
      this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonNewGame.Location = new System.Drawing.Point(264, 8);
      this.buttonNewGame.Name = "buttonNewGame";
      this.buttonNewGame.Size = new System.Drawing.Size(72, 23);
      this.buttonNewGame.TabIndex = 0;
      this.buttonNewGame.Text = "Neues Spiel";
      this.toolTip.SetToolTip(this.buttonNewGame, "Startet ein neues Spiel");
      this.buttonNewGame.UseVisualStyleBackColor = true;
      this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
      // 
      // buttonQuitGame
      // 
      this.buttonQuitGame.Location = new System.Drawing.Point(264, 104);
      this.buttonQuitGame.Name = "buttonQuitGame";
      this.buttonQuitGame.Size = new System.Drawing.Size(90, 23);
      this.buttonQuitGame.TabIndex = 4;
      this.buttonQuitGame.Text = "Spiel beenden";
      this.toolTip.SetToolTip(this.buttonQuitGame, "Beendet das Spiel");
      this.buttonQuitGame.UseVisualStyleBackColor = true;
      this.buttonQuitGame.Click += new System.EventHandler(this.buttonQuitGame_Click);
      // 
      // buttonGameConcept
      // 
      this.buttonGameConcept.Location = new System.Drawing.Point(264, 72);
      this.buttonGameConcept.Name = "buttonGameConcept";
      this.buttonGameConcept.Size = new System.Drawing.Size(89, 23);
      this.buttonGameConcept.TabIndex = 3;
      this.buttonGameConcept.Text = "Spielprinzip";
      this.toolTip.SetToolTip(this.buttonGameConcept, "Erläutert das Spielprinzip");
      this.buttonGameConcept.UseVisualStyleBackColor = true;
      this.buttonGameConcept.Click += new System.EventHandler(this.buttonGameConcept_Click);
      // 
      // labelClicks
      // 
      this.labelClicks.AutoSize = true;
      this.labelClicks.Location = new System.Drawing.Point(264, 176);
      this.labelClicks.Name = "labelClicks";
      this.labelClicks.Size = new System.Drawing.Size(38, 13);
      this.labelClicks.TabIndex = 6;
      this.labelClicks.Text = "Klicks:";
      this.toolTip.SetToolTip(this.labelClicks, "Zeigt die Anzahl der Klicks an");
      // 
      // labelTicks
      // 
      this.labelTicks.AutoSize = true;
      this.labelTicks.Location = new System.Drawing.Point(264, 192);
      this.labelTicks.Name = "labelTicks";
      this.labelTicks.Size = new System.Drawing.Size(36, 13);
      this.labelTicks.TabIndex = 7;
      this.labelTicks.Text = "Ticks:";
      this.toolTip.SetToolTip(this.labelTicks, "Zeigt die Anzahl der Ticks an");
      // 
      // timer
      // 
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // buttonField1
      // 
      this.buttonField1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField1.Location = new System.Drawing.Point(16, 8);
      this.buttonField1.Name = "buttonField1";
      this.buttonField1.Size = new System.Drawing.Size(48, 48);
      this.buttonField1.TabIndex = 10;
      this.buttonField1.UseVisualStyleBackColor = true;
      this.buttonField1.Click += new System.EventHandler(this.buttonField1_Click);
      // 
      // buttonField2
      // 
      this.buttonField2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField2.Location = new System.Drawing.Point(64, 8);
      this.buttonField2.Name = "buttonField2";
      this.buttonField2.Size = new System.Drawing.Size(48, 48);
      this.buttonField2.TabIndex = 11;
      this.buttonField2.UseVisualStyleBackColor = true;
      this.buttonField2.Click += new System.EventHandler(this.buttonField2_Click);
      // 
      // buttonField3
      // 
      this.buttonField3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField3.Location = new System.Drawing.Point(112, 8);
      this.buttonField3.Name = "buttonField3";
      this.buttonField3.Size = new System.Drawing.Size(48, 48);
      this.buttonField3.TabIndex = 12;
      this.buttonField3.UseVisualStyleBackColor = true;
      this.buttonField3.Click += new System.EventHandler(this.buttonField3_Click);
      // 
      // buttonField6
      // 
      this.buttonField6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField6.Location = new System.Drawing.Point(16, 56);
      this.buttonField6.Name = "buttonField6";
      this.buttonField6.Size = new System.Drawing.Size(48, 48);
      this.buttonField6.TabIndex = 15;
      this.buttonField6.UseVisualStyleBackColor = true;
      this.buttonField6.Click += new System.EventHandler(this.buttonField6_Click);
      // 
      // buttonField5
      // 
      this.buttonField5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField5.Location = new System.Drawing.Point(208, 8);
      this.buttonField5.Name = "buttonField5";
      this.buttonField5.Size = new System.Drawing.Size(48, 48);
      this.buttonField5.TabIndex = 14;
      this.buttonField5.UseVisualStyleBackColor = true;
      this.buttonField5.Click += new System.EventHandler(this.buttonField5_Click);
      // 
      // buttonField4
      // 
      this.buttonField4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField4.Location = new System.Drawing.Point(160, 8);
      this.buttonField4.Name = "buttonField4";
      this.buttonField4.Size = new System.Drawing.Size(48, 48);
      this.buttonField4.TabIndex = 13;
      this.buttonField4.UseVisualStyleBackColor = true;
      this.buttonField4.Click += new System.EventHandler(this.buttonField4_Click);
      // 
      // buttonField9
      // 
      this.buttonField9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField9.Location = new System.Drawing.Point(160, 56);
      this.buttonField9.Name = "buttonField9";
      this.buttonField9.Size = new System.Drawing.Size(48, 48);
      this.buttonField9.TabIndex = 18;
      this.buttonField9.UseVisualStyleBackColor = true;
      this.buttonField9.Click += new System.EventHandler(this.buttonField9_Click);
      // 
      // buttonField8
      // 
      this.buttonField8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField8.Location = new System.Drawing.Point(112, 56);
      this.buttonField8.Name = "buttonField8";
      this.buttonField8.Size = new System.Drawing.Size(48, 48);
      this.buttonField8.TabIndex = 17;
      this.buttonField8.UseVisualStyleBackColor = true;
      this.buttonField8.Click += new System.EventHandler(this.buttonField8_Click);
      // 
      // buttonField7
      // 
      this.buttonField7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField7.Location = new System.Drawing.Point(64, 56);
      this.buttonField7.Name = "buttonField7";
      this.buttonField7.Size = new System.Drawing.Size(48, 48);
      this.buttonField7.TabIndex = 16;
      this.buttonField7.UseVisualStyleBackColor = true;
      this.buttonField7.Click += new System.EventHandler(this.buttonField7_Click);
      // 
      // buttonField10
      // 
      this.buttonField10.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField10.Location = new System.Drawing.Point(208, 56);
      this.buttonField10.Name = "buttonField10";
      this.buttonField10.Size = new System.Drawing.Size(48, 48);
      this.buttonField10.TabIndex = 19;
      this.buttonField10.UseVisualStyleBackColor = true;
      this.buttonField10.Click += new System.EventHandler(this.buttonField10_Click);
      // 
      // buttonField15
      // 
      this.buttonField15.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField15.Location = new System.Drawing.Point(208, 104);
      this.buttonField15.Name = "buttonField15";
      this.buttonField15.Size = new System.Drawing.Size(48, 48);
      this.buttonField15.TabIndex = 24;
      this.buttonField15.UseVisualStyleBackColor = true;
      this.buttonField15.Click += new System.EventHandler(this.buttonField15_Click);
      // 
      // buttonField14
      // 
      this.buttonField14.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField14.Location = new System.Drawing.Point(160, 104);
      this.buttonField14.Name = "buttonField14";
      this.buttonField14.Size = new System.Drawing.Size(48, 48);
      this.buttonField14.TabIndex = 23;
      this.buttonField14.UseVisualStyleBackColor = true;
      this.buttonField14.Click += new System.EventHandler(this.buttonField14_Click);
      // 
      // buttonField13
      // 
      this.buttonField13.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField13.Location = new System.Drawing.Point(112, 104);
      this.buttonField13.Name = "buttonField13";
      this.buttonField13.Size = new System.Drawing.Size(48, 48);
      this.buttonField13.TabIndex = 22;
      this.buttonField13.UseVisualStyleBackColor = true;
      this.buttonField13.Click += new System.EventHandler(this.buttonField13_Click);
      // 
      // buttonField12
      // 
      this.buttonField12.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField12.Location = new System.Drawing.Point(64, 104);
      this.buttonField12.Name = "buttonField12";
      this.buttonField12.Size = new System.Drawing.Size(48, 48);
      this.buttonField12.TabIndex = 21;
      this.buttonField12.UseVisualStyleBackColor = true;
      this.buttonField12.Click += new System.EventHandler(this.buttonField12_Click);
      // 
      // buttonField11
      // 
      this.buttonField11.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField11.Location = new System.Drawing.Point(16, 104);
      this.buttonField11.Name = "buttonField11";
      this.buttonField11.Size = new System.Drawing.Size(48, 48);
      this.buttonField11.TabIndex = 20;
      this.buttonField11.UseVisualStyleBackColor = true;
      this.buttonField11.Click += new System.EventHandler(this.buttonField11_Click);
      // 
      // buttonField20
      // 
      this.buttonField20.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField20.Location = new System.Drawing.Point(208, 152);
      this.buttonField20.Name = "buttonField20";
      this.buttonField20.Size = new System.Drawing.Size(48, 48);
      this.buttonField20.TabIndex = 29;
      this.buttonField20.UseVisualStyleBackColor = true;
      this.buttonField20.Click += new System.EventHandler(this.buttonField20_Click);
      // 
      // buttonField19
      // 
      this.buttonField19.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField19.Location = new System.Drawing.Point(160, 152);
      this.buttonField19.Name = "buttonField19";
      this.buttonField19.Size = new System.Drawing.Size(48, 48);
      this.buttonField19.TabIndex = 28;
      this.buttonField19.UseVisualStyleBackColor = true;
      this.buttonField19.Click += new System.EventHandler(this.buttonField19_Click);
      // 
      // buttonField18
      // 
      this.buttonField18.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField18.Location = new System.Drawing.Point(112, 152);
      this.buttonField18.Name = "buttonField18";
      this.buttonField18.Size = new System.Drawing.Size(48, 48);
      this.buttonField18.TabIndex = 27;
      this.buttonField18.UseVisualStyleBackColor = true;
      this.buttonField18.Click += new System.EventHandler(this.buttonField18_Click);
      // 
      // buttonField17
      // 
      this.buttonField17.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField17.Location = new System.Drawing.Point(64, 152);
      this.buttonField17.Name = "buttonField17";
      this.buttonField17.Size = new System.Drawing.Size(48, 48);
      this.buttonField17.TabIndex = 26;
      this.buttonField17.UseVisualStyleBackColor = true;
      this.buttonField17.Click += new System.EventHandler(this.buttonField17_Click);
      // 
      // buttonField16
      // 
      this.buttonField16.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField16.Location = new System.Drawing.Point(16, 152);
      this.buttonField16.Name = "buttonField16";
      this.buttonField16.Size = new System.Drawing.Size(48, 48);
      this.buttonField16.TabIndex = 25;
      this.buttonField16.UseVisualStyleBackColor = true;
      this.buttonField16.Click += new System.EventHandler(this.buttonField16_Click);
      // 
      // buttonField25
      // 
      this.buttonField25.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField25.Location = new System.Drawing.Point(208, 200);
      this.buttonField25.Name = "buttonField25";
      this.buttonField25.Size = new System.Drawing.Size(48, 48);
      this.buttonField25.TabIndex = 34;
      this.buttonField25.UseVisualStyleBackColor = true;
      this.buttonField25.Click += new System.EventHandler(this.buttonField25_Click);
      // 
      // buttonField24
      // 
      this.buttonField24.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField24.Location = new System.Drawing.Point(160, 200);
      this.buttonField24.Name = "buttonField24";
      this.buttonField24.Size = new System.Drawing.Size(48, 48);
      this.buttonField24.TabIndex = 33;
      this.buttonField24.UseVisualStyleBackColor = true;
      this.buttonField24.Click += new System.EventHandler(this.buttonField24_Click);
      // 
      // buttonField23
      // 
      this.buttonField23.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField23.Location = new System.Drawing.Point(112, 200);
      this.buttonField23.Name = "buttonField23";
      this.buttonField23.Size = new System.Drawing.Size(48, 48);
      this.buttonField23.TabIndex = 32;
      this.buttonField23.UseVisualStyleBackColor = true;
      this.buttonField23.Click += new System.EventHandler(this.buttonField23_Click);
      // 
      // buttonField22
      // 
      this.buttonField22.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField22.Location = new System.Drawing.Point(64, 200);
      this.buttonField22.Name = "buttonField22";
      this.buttonField22.Size = new System.Drawing.Size(48, 48);
      this.buttonField22.TabIndex = 31;
      this.buttonField22.UseVisualStyleBackColor = true;
      this.buttonField22.Click += new System.EventHandler(this.buttonField22_Click);
      // 
      // buttonField21
      // 
      this.buttonField21.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
      this.buttonField21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.buttonField21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.buttonField21.Location = new System.Drawing.Point(16, 200);
      this.buttonField21.Name = "buttonField21";
      this.buttonField21.Size = new System.Drawing.Size(48, 48);
      this.buttonField21.TabIndex = 30;
      this.buttonField21.UseVisualStyleBackColor = true;
      this.buttonField21.Click += new System.EventHandler(this.buttonField21_Click);
      // 
      // buttonOptions
      // 
      this.buttonOptions.Location = new System.Drawing.Point(264, 40);
      this.buttonOptions.Name = "buttonOptions";
      this.buttonOptions.Size = new System.Drawing.Size(89, 23);
      this.buttonOptions.TabIndex = 2;
      this.buttonOptions.Text = "Einstellungen";
      this.toolTip.SetToolTip(this.buttonOptions, "Wählt die Einstellungen des Spielverhaltens");
      this.buttonOptions.UseVisualStyleBackColor = true;
      this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
      // 
      // buttonNewGamesize
      // 
      this.buttonNewGamesize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonNewGamesize.Location = new System.Drawing.Point(336, 8);
      this.buttonNewGamesize.Name = "buttonNewGamesize";
      this.buttonNewGamesize.Size = new System.Drawing.Size(16, 23);
      this.buttonNewGamesize.TabIndex = 1;
      this.buttonNewGamesize.Text = "▼";
      this.toolTip.SetToolTip(this.buttonNewGamesize, "Wählt die Größe des Spielfeldes aus");
      this.buttonNewGamesize.UseVisualStyleBackColor = true;
      this.buttonNewGamesize.Click += new System.EventHandler(this.buttonNewGamesize_Click);
      // 
      // labelGamesize
      // 
      this.labelGamesize.AutoSize = true;
      this.labelGamesize.Location = new System.Drawing.Point(264, 152);
      this.labelGamesize.Name = "labelGamesize";
      this.labelGamesize.Size = new System.Drawing.Size(59, 13);
      this.labelGamesize.TabIndex = 5;
      this.labelGamesize.Text = "Größe: 5x5";
      this.toolTip.SetToolTip(this.labelGamesize, "Zeigt die Größe des Spielfeldes an");
      // 
      // labelBlacks
      // 
      this.labelBlacks.AutoSize = true;
      this.labelBlacks.Location = new System.Drawing.Point(264, 216);
      this.labelBlacks.Name = "labelBlacks";
      this.labelBlacks.Size = new System.Drawing.Size(42, 13);
      this.labelBlacks.TabIndex = 8;
      this.labelBlacks.Text = "Blacks:";
      this.toolTip.SetToolTip(this.labelBlacks, "Zeigt die Anzahl der schwarzen Felder an");
      // 
      // labelWhites
      // 
      this.labelWhites.AutoSize = true;
      this.labelWhites.Location = new System.Drawing.Point(264, 232);
      this.labelWhites.Name = "labelWhites";
      this.labelWhites.Size = new System.Drawing.Size(40, 13);
      this.labelWhites.TabIndex = 9;
      this.labelWhites.Text = "Whites";
      this.toolTip.SetToolTip(this.labelWhites, "Zeigt die Anzahl der weißen Felder an");
      // 
      // contextMenuStripGamesize
      // 
      this.contextMenuStripGamesize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGamesize3x3,
            this.ToolStripMenuItemGamesize4x4,
            this.ToolStripMenuItemGamesize5x5});
      this.contextMenuStripGamesize.Name = "contextMenuStripGamesize";
      this.contextMenuStripGamesize.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.contextMenuStripGamesize.ShowCheckMargin = true;
      this.contextMenuStripGamesize.ShowImageMargin = false;
      this.contextMenuStripGamesize.Size = new System.Drawing.Size(92, 70);
      this.contextMenuStripGamesize.Text = "Spielfeldgröße";
      this.toolTip.SetToolTip(this.contextMenuStripGamesize, "Öffnet das Menü für die Einstellung der Größe des Spielfeldes");
      // 
      // ToolStripMenuItemGamesize3x3
      // 
      this.ToolStripMenuItemGamesize3x3.CheckOnClick = true;
      this.ToolStripMenuItemGamesize3x3.Name = "ToolStripMenuItemGamesize3x3";
      this.ToolStripMenuItemGamesize3x3.Size = new System.Drawing.Size(91, 22);
      this.ToolStripMenuItemGamesize3x3.Text = "3x3";
      this.ToolStripMenuItemGamesize3x3.ToolTipText = "Wählt die Größe des Spielfeld von 3x3";
      this.ToolStripMenuItemGamesize3x3.Click += new System.EventHandler(this.ToolStripMenuItemGamesize3x3_Click);
      // 
      // ToolStripMenuItemGamesize4x4
      // 
      this.ToolStripMenuItemGamesize4x4.CheckOnClick = true;
      this.ToolStripMenuItemGamesize4x4.Name = "ToolStripMenuItemGamesize4x4";
      this.ToolStripMenuItemGamesize4x4.Size = new System.Drawing.Size(91, 22);
      this.ToolStripMenuItemGamesize4x4.Text = "4x4";
      this.ToolStripMenuItemGamesize4x4.ToolTipText = "Wählt die Größe des Spielfeld von 4x4";
      this.ToolStripMenuItemGamesize4x4.Click += new System.EventHandler(this.ToolStripMenuItemGamesize4x4_Click);
      // 
      // ToolStripMenuItemGamesize5x5
      // 
      this.ToolStripMenuItemGamesize5x5.Checked = true;
      this.ToolStripMenuItemGamesize5x5.CheckOnClick = true;
      this.ToolStripMenuItemGamesize5x5.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ToolStripMenuItemGamesize5x5.Name = "ToolStripMenuItemGamesize5x5";
      this.ToolStripMenuItemGamesize5x5.Size = new System.Drawing.Size(91, 22);
      this.ToolStripMenuItemGamesize5x5.Text = "5x5";
      this.ToolStripMenuItemGamesize5x5.ToolTipText = "Wählt die Größe des Spielfeld von 5x5";
      this.ToolStripMenuItemGamesize5x5.Click += new System.EventHandler(this.ToolStripMenuItemGamesize5x5_Click);
      // 
      // contextMenuStripNeighbourhood
      // 
      this.contextMenuStripNeighbourhood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNeighbourhoodLinear,
            this.ToolStripMenuItemNeighbourhoodDiagonal,
            this.ToolStripMenuItemNeighbourhoodCombined,
            this.toolStripSeparator1,
            this.ToolStripMenuItemNeighbourhoodCentered});
      this.contextMenuStripNeighbourhood.Name = "contextMenuStripNeighbourhood";
      this.contextMenuStripNeighbourhood.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.contextMenuStripNeighbourhood.ShowCheckMargin = true;
      this.contextMenuStripNeighbourhood.ShowImageMargin = false;
      this.contextMenuStripNeighbourhood.Size = new System.Drawing.Size(133, 98);
      this.contextMenuStripNeighbourhood.Text = "Einstellungen";
      this.toolTip.SetToolTip(this.contextMenuStripNeighbourhood, "Öffnet das Menü für die Einstellungen des Spiels");
      // 
      // ToolStripMenuItemNeighbourhoodLinear
      // 
      this.ToolStripMenuItemNeighbourhoodLinear.Checked = true;
      this.ToolStripMenuItemNeighbourhoodLinear.CheckOnClick = true;
      this.ToolStripMenuItemNeighbourhoodLinear.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ToolStripMenuItemNeighbourhoodLinear.Name = "ToolStripMenuItemNeighbourhoodLinear";
      this.ToolStripMenuItemNeighbourhoodLinear.Size = new System.Drawing.Size(132, 22);
      this.ToolStripMenuItemNeighbourhoodLinear.Text = "linear";
      this.ToolStripMenuItemNeighbourhoodLinear.ToolTipText = "Ändert die invertierbaren Nachbar-Spielfelder auf lineare Nachbar-Spielfelder";
      this.ToolStripMenuItemNeighbourhoodLinear.Click += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodLinear_Click);
      // 
      // ToolStripMenuItemNeighbourhoodDiagonal
      // 
      this.ToolStripMenuItemNeighbourhoodDiagonal.CheckOnClick = true;
      this.ToolStripMenuItemNeighbourhoodDiagonal.Name = "ToolStripMenuItemNeighbourhoodDiagonal";
      this.ToolStripMenuItemNeighbourhoodDiagonal.Size = new System.Drawing.Size(132, 22);
      this.ToolStripMenuItemNeighbourhoodDiagonal.Text = "diagonal";
      this.ToolStripMenuItemNeighbourhoodDiagonal.ToolTipText = "Ändert die invertierbaren Nachbar-Spielfelder auf diagonale Nachbar-Spielfelder";
      this.ToolStripMenuItemNeighbourhoodDiagonal.Click += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodDiagonal_Click);
      // 
      // ToolStripMenuItemNeighbourhoodCombined
      // 
      this.ToolStripMenuItemNeighbourhoodCombined.CheckOnClick = true;
      this.ToolStripMenuItemNeighbourhoodCombined.Name = "ToolStripMenuItemNeighbourhoodCombined";
      this.ToolStripMenuItemNeighbourhoodCombined.Size = new System.Drawing.Size(132, 22);
      this.ToolStripMenuItemNeighbourhoodCombined.Text = "kombiniert";
      this.ToolStripMenuItemNeighbourhoodCombined.ToolTipText = "Ändert die invertierbaren Nachbar-Spielfelder auf lineare und diagonale Nachbar-S" +
    "pielfelder";
      this.ToolStripMenuItemNeighbourhoodCombined.Click += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodCombined_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
      // 
      // ToolStripMenuItemNeighbourhoodCentered
      // 
      this.ToolStripMenuItemNeighbourhoodCentered.Checked = true;
      this.ToolStripMenuItemNeighbourhoodCentered.CheckOnClick = true;
      this.ToolStripMenuItemNeighbourhoodCentered.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ToolStripMenuItemNeighbourhoodCentered.Name = "ToolStripMenuItemNeighbourhoodCentered";
      this.ToolStripMenuItemNeighbourhoodCentered.Size = new System.Drawing.Size(132, 22);
      this.ToolStripMenuItemNeighbourhoodCentered.Text = "zentriert";
      this.ToolStripMenuItemNeighbourhoodCentered.ToolTipText = "Ändert, ob das eigene Feld invertiert werden soll";
      this.ToolStripMenuItemNeighbourhoodCentered.Click += new System.EventHandler(this.ToolStripMenuItemNeighbourhoodCentered_Click);
      // 
      // Black_n_WhiteForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(364, 261);
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
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGamesize3x3;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGamesize4x4;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGamesize5x5;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripNeighbourhood;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNeighbourhoodLinear;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNeighbourhoodDiagonal;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNeighbourhoodCombined;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNeighbourhoodCentered;
  }
}

