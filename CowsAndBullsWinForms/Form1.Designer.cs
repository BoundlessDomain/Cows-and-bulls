namespace CowsAndBullsWinForms
{
    partial class frmCowsAndBullsGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbUserNumberA = new System.Windows.Forms.ComboBox();
            this.cmbUserNumberB = new System.Windows.Forms.ComboBox();
            this.cmbUserNumberC = new System.Windows.Forms.ComboBox();
            this.cmbUserNumberD = new System.Windows.Forms.ComboBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmdTutorial = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.cmdGuess = new System.Windows.Forms.Button();
            this.lblBullsAmount = new System.Windows.Forms.Label();
            this.lblCowsAmount = new System.Windows.Forms.Label();
            this.lstGuessList = new System.Windows.Forms.ListBox();
            this.timeUntilExit = new System.Windows.Forms.ProgressBar();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmbUserNumberA
            // 
            this.cmbUserNumberA.FormattingEnabled = true;
            this.cmbUserNumberA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbUserNumberA.Location = new System.Drawing.Point(105, 150);
            this.cmbUserNumberA.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserNumberA.Name = "cmbUserNumberA";
            this.cmbUserNumberA.Size = new System.Drawing.Size(38, 21);
            this.cmbUserNumberA.TabIndex = 0;
            // 
            // cmbUserNumberB
            // 
            this.cmbUserNumberB.FormattingEnabled = true;
            this.cmbUserNumberB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbUserNumberB.Location = new System.Drawing.Point(147, 150);
            this.cmbUserNumberB.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserNumberB.Name = "cmbUserNumberB";
            this.cmbUserNumberB.Size = new System.Drawing.Size(38, 21);
            this.cmbUserNumberB.TabIndex = 1;
            // 
            // cmbUserNumberC
            // 
            this.cmbUserNumberC.FormattingEnabled = true;
            this.cmbUserNumberC.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbUserNumberC.Location = new System.Drawing.Point(189, 150);
            this.cmbUserNumberC.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserNumberC.Name = "cmbUserNumberC";
            this.cmbUserNumberC.Size = new System.Drawing.Size(38, 21);
            this.cmbUserNumberC.TabIndex = 2;
            // 
            // cmbUserNumberD
            // 
            this.cmbUserNumberD.FormattingEnabled = true;
            this.cmbUserNumberD.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbUserNumberD.Location = new System.Drawing.Point(231, 150);
            this.cmbUserNumberD.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserNumberD.Name = "cmbUserNumberD";
            this.cmbUserNumberD.Size = new System.Drawing.Size(38, 21);
            this.cmbUserNumberD.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(131, 10);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(288, 52);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to Cows and Bulls!\r\nThis game is simple but incase you need to read the t" +
    "utorial,\r\nclick the tutorial button!\r\nOtherwise, click the start button to play!" +
    "";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdTutorial
            // 
            this.cmdTutorial.Location = new System.Drawing.Point(73, 87);
            this.cmdTutorial.Margin = new System.Windows.Forms.Padding(2);
            this.cmdTutorial.Name = "cmdTutorial";
            this.cmdTutorial.Size = new System.Drawing.Size(112, 24);
            this.cmdTutorial.TabIndex = 5;
            this.cmdTutorial.Text = "Tutorial";
            this.cmdTutorial.UseVisualStyleBackColor = true;
            this.cmdTutorial.Click += new System.EventHandler(this.cmdTutorial_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(350, 88);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(112, 24);
            this.cmdStart.TabIndex = 6;
            this.cmdStart.Text = "Start Game";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(468, 10);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(2);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(38, 24);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomNumber.Location = new System.Drawing.Point(207, 86);
            this.lblRandomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(106, 25);
            this.lblRandomNumber.TabIndex = 8;
            this.lblRandomNumber.Text = "[-] [-] [-] [-]";
            // 
            // cmdGuess
            // 
            this.cmdGuess.Enabled = false;
            this.cmdGuess.Location = new System.Drawing.Point(362, 145);
            this.cmdGuess.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGuess.Name = "cmdGuess";
            this.cmdGuess.Size = new System.Drawing.Size(75, 24);
            this.cmdGuess.TabIndex = 9;
            this.cmdGuess.Text = "Guess";
            this.cmdGuess.UseVisualStyleBackColor = true;
            this.cmdGuess.Click += new System.EventHandler(this.cmdGuess_Click);
            // 
            // lblBullsAmount
            // 
            this.lblBullsAmount.AutoSize = true;
            this.lblBullsAmount.Location = new System.Drawing.Point(60, 238);
            this.lblBullsAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBullsAmount.Name = "lblBullsAmount";
            this.lblBullsAmount.Size = new System.Drawing.Size(113, 13);
            this.lblBullsAmount.TabIndex = 10;
            this.lblBullsAmount.Text = "The amount of bulls is:";
            // 
            // lblCowsAmount
            // 
            this.lblCowsAmount.AutoSize = true;
            this.lblCowsAmount.Location = new System.Drawing.Point(60, 263);
            this.lblCowsAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCowsAmount.Name = "lblCowsAmount";
            this.lblCowsAmount.Size = new System.Drawing.Size(117, 13);
            this.lblCowsAmount.TabIndex = 11;
            this.lblCowsAmount.Text = "The amount of cows is:";
            // 
            // lstGuessList
            // 
            this.lstGuessList.FormattingEnabled = true;
            this.lstGuessList.Location = new System.Drawing.Point(275, 210);
            this.lstGuessList.Margin = new System.Windows.Forms.Padding(2);
            this.lstGuessList.MultiColumn = true;
            this.lstGuessList.Name = "lstGuessList";
            this.lstGuessList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstGuessList.Size = new System.Drawing.Size(231, 186);
            this.lstGuessList.TabIndex = 12;
            // 
            // timeUntilExit
            // 
            this.timeUntilExit.Location = new System.Drawing.Point(468, 39);
            this.timeUntilExit.Margin = new System.Windows.Forms.Padding(2);
            this.timeUntilExit.Maximum = 5;
            this.timeUntilExit.Name = "timeUntilExit";
            this.timeUntilExit.Size = new System.Drawing.Size(38, 19);
            this.timeUntilExit.TabIndex = 5;
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Interval = 900;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // frmCowsAndBullsGame
            // 
            this.AcceptButton = this.cmdGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 405);
            this.Controls.Add(this.timeUntilExit);
            this.Controls.Add(this.lstGuessList);
            this.Controls.Add(this.lblCowsAmount);
            this.Controls.Add(this.lblBullsAmount);
            this.Controls.Add(this.cmdGuess);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdTutorial);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.cmbUserNumberD);
            this.Controls.Add(this.cmbUserNumberC);
            this.Controls.Add(this.cmbUserNumberB);
            this.Controls.Add(this.cmbUserNumberA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmCowsAndBullsGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cows And Bulls";
            this.Load += new System.EventHandler(this.frmCowsAndBullsGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserNumberA;
        private System.Windows.Forms.ComboBox cmbUserNumberB;
        private System.Windows.Forms.ComboBox cmbUserNumberC;
        private System.Windows.Forms.ComboBox cmbUserNumberD;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button cmdTutorial;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Button cmdGuess;
        private System.Windows.Forms.Label lblBullsAmount;
        private System.Windows.Forms.Label lblCowsAmount;
        private System.Windows.Forms.ListBox lstGuessList;
        private System.Windows.Forms.ProgressBar timeUntilExit;
        private System.Windows.Forms.Timer progressBarTimer;
    }
}

