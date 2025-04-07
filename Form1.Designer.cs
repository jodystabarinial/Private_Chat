namespace Private_Chat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox_Id_PersonaChat = new ReaLTaiizor.Controls.SmallTextBox();
			buttonConnettiti = new ReaLTaiizor.Controls.Button();
			button_Connettiti = new ReaLTaiizor.Controls.Button();
			label = new ReaLTaiizor.Controls.SmallLabel();
			smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
			label_Stato_Connessione = new ReaLTaiizor.Controls.SmallLabel();
			buttonAggiornaRichiesteChat = new ReaLTaiizor.Controls.Button();
			bigTextBoxMessaggio = new ReaLTaiizor.Controls.BigTextBox();
			label_Id_Connessione = new ReaLTaiizor.Controls.SmallLabel();
			buttonInviaMessaggio = new ReaLTaiizor.Controls.Button();
			textBoxMessages = new TextBox();
			SuspendLayout();
			// 
			// textBox_Id_PersonaChat
			// 
			textBox_Id_PersonaChat.BackColor = Color.Transparent;
			textBox_Id_PersonaChat.BorderColor = Color.FromArgb(180, 180, 180);
			textBox_Id_PersonaChat.CustomBGColor = Color.White;
			textBox_Id_PersonaChat.Font = new Font("Tahoma", 11F);
			textBox_Id_PersonaChat.ForeColor = Color.DimGray;
			textBox_Id_PersonaChat.Location = new Point(12, 109);
			textBox_Id_PersonaChat.MaxLength = 32767;
			textBox_Id_PersonaChat.Multiline = false;
			textBox_Id_PersonaChat.Name = "textBox_Id_PersonaChat";
			textBox_Id_PersonaChat.ReadOnly = false;
			textBox_Id_PersonaChat.Size = new Size(110, 28);
			textBox_Id_PersonaChat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			textBox_Id_PersonaChat.TabIndex = 8;
			textBox_Id_PersonaChat.TextAlignment = HorizontalAlignment.Left;
			textBox_Id_PersonaChat.UseSystemPasswordChar = false;
			// 
			// buttonConnettiti
			// 
			buttonConnettiti.BackColor = Color.Transparent;
			buttonConnettiti.BorderColor = Color.FromArgb(32, 34, 37);
			buttonConnettiti.EnteredBorderColor = Color.FromArgb(165, 37, 37);
			buttonConnettiti.EnteredColor = Color.FromArgb(32, 34, 37);
			buttonConnettiti.Font = new Font("Microsoft Sans Serif", 12F);
			buttonConnettiti.Image = null;
			buttonConnettiti.ImageAlign = ContentAlignment.MiddleLeft;
			buttonConnettiti.InactiveColor = Color.FromArgb(32, 34, 37);
			buttonConnettiti.Location = new Point(128, 109);
			buttonConnettiti.Name = "buttonConnettiti";
			buttonConnettiti.PressedBorderColor = Color.FromArgb(165, 37, 37);
			buttonConnettiti.PressedColor = Color.FromArgb(165, 37, 37);
			buttonConnettiti.Size = new Size(77, 28);
			buttonConnettiti.TabIndex = 9;
			buttonConnettiti.Text = "Connettiti";
			buttonConnettiti.TextAlignment = StringAlignment.Center;
			buttonConnettiti.Click += buttonConnettiti_Click;
			// 
			// button_Connettiti
			// 
			button_Connettiti.BackColor = Color.Transparent;
			button_Connettiti.BorderColor = Color.FromArgb(32, 34, 37);
			button_Connettiti.EnteredBorderColor = Color.FromArgb(165, 37, 37);
			button_Connettiti.EnteredColor = Color.FromArgb(32, 34, 37);
			button_Connettiti.Font = new Font("Microsoft Sans Serif", 12F);
			button_Connettiti.Image = null;
			button_Connettiti.ImageAlign = ContentAlignment.MiddleLeft;
			button_Connettiti.InactiveColor = Color.FromArgb(32, 34, 37);
			button_Connettiti.Location = new Point(12, 9);
			button_Connettiti.Name = "button_Connettiti";
			button_Connettiti.PressedBorderColor = Color.FromArgb(165, 37, 37);
			button_Connettiti.PressedColor = Color.FromArgb(165, 37, 37);
			button_Connettiti.Size = new Size(94, 28);
			button_Connettiti.TabIndex = 10;
			button_Connettiti.Text = "Connetti";
			button_Connettiti.TextAlignment = StringAlignment.Center;
			button_Connettiti.Click += button_Connettiti_Click;
			// 
			// label
			// 
			label.AutoSize = true;
			label.BackColor = Color.Transparent;
			label.Font = new Font("Segoe UI", 8F);
			label.ForeColor = Color.FromArgb(142, 142, 142);
			label.Location = new Point(8, 41);
			label.Name = "label";
			label.Size = new Size(94, 13);
			label.TabIndex = 11;
			label.Text = "ID Connessione: ";
			// 
			// smallLabel1
			// 
			smallLabel1.AutoSize = true;
			smallLabel1.BackColor = Color.Transparent;
			smallLabel1.Font = new Font("Segoe UI", 8F);
			smallLabel1.ForeColor = Color.FromArgb(142, 142, 142);
			smallLabel1.Location = new Point(12, 93);
			smallLabel1.Name = "smallLabel1";
			smallLabel1.Size = new Size(256, 13);
			smallLabel1.TabIndex = 12;
			smallLabel1.Text = "Inserisci l'id della persona con cui vuoi chattare: ";
			// 
			// label_Stato_Connessione
			// 
			label_Stato_Connessione.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label_Stato_Connessione.AutoSize = true;
			label_Stato_Connessione.BackColor = Color.Transparent;
			label_Stato_Connessione.Font = new Font("Segoe UI", 8F);
			label_Stato_Connessione.ForeColor = Color.FromArgb(142, 142, 142);
			label_Stato_Connessione.Location = new Point(614, 9);
			label_Stato_Connessione.Name = "label_Stato_Connessione";
			label_Stato_Connessione.Size = new Size(107, 13);
			label_Stato_Connessione.TabIndex = 13;
			label_Stato_Connessione.Text = "Stato Connessione:";
			// 
			// buttonAggiornaRichiesteChat
			// 
			buttonAggiornaRichiesteChat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonAggiornaRichiesteChat.BackColor = Color.Transparent;
			buttonAggiornaRichiesteChat.BorderColor = Color.FromArgb(32, 34, 37);
			buttonAggiornaRichiesteChat.EnteredBorderColor = Color.FromArgb(165, 37, 37);
			buttonAggiornaRichiesteChat.EnteredColor = Color.FromArgb(32, 34, 37);
			buttonAggiornaRichiesteChat.Font = new Font("Microsoft Sans Serif", 12F);
			buttonAggiornaRichiesteChat.Image = null;
			buttonAggiornaRichiesteChat.ImageAlign = ContentAlignment.MiddleLeft;
			buttonAggiornaRichiesteChat.InactiveColor = Color.FromArgb(32, 34, 37);
			buttonAggiornaRichiesteChat.Location = new Point(614, 26);
			buttonAggiornaRichiesteChat.Name = "buttonAggiornaRichiesteChat";
			buttonAggiornaRichiesteChat.PressedBorderColor = Color.FromArgb(165, 37, 37);
			buttonAggiornaRichiesteChat.PressedColor = Color.FromArgb(165, 37, 37);
			buttonAggiornaRichiesteChat.Size = new Size(77, 28);
			buttonAggiornaRichiesteChat.TabIndex = 14;
			buttonAggiornaRichiesteChat.Text = "Aggiorna";
			buttonAggiornaRichiesteChat.TextAlignment = StringAlignment.Center;
			buttonAggiornaRichiesteChat.Click += buttonAggiornaRichiesteChat_Click;
			// 
			// bigTextBoxMessaggio
			// 
			bigTextBoxMessaggio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			bigTextBoxMessaggio.BackColor = Color.Transparent;
			bigTextBoxMessaggio.Font = new Font("Tahoma", 11F);
			bigTextBoxMessaggio.ForeColor = Color.DimGray;
			bigTextBoxMessaggio.Image = null;
			bigTextBoxMessaggio.Location = new Point(12, 393);
			bigTextBoxMessaggio.MaxLength = 32767;
			bigTextBoxMessaggio.Multiline = true;
			bigTextBoxMessaggio.Name = "bigTextBoxMessaggio";
			bigTextBoxMessaggio.ReadOnly = false;
			bigTextBoxMessaggio.Size = new Size(693, 45);
			bigTextBoxMessaggio.TabIndex = 15;
			bigTextBoxMessaggio.TextAlignment = HorizontalAlignment.Left;
			bigTextBoxMessaggio.UseSystemPasswordChar = false;
			// 
			// label_Id_Connessione
			// 
			label_Id_Connessione.AutoSize = true;
			label_Id_Connessione.BackColor = Color.Transparent;
			label_Id_Connessione.Font = new Font("Segoe UI", 8F);
			label_Id_Connessione.ForeColor = Color.FromArgb(142, 142, 142);
			label_Id_Connessione.Location = new Point(102, 41);
			label_Id_Connessione.Name = "label_Id_Connessione";
			label_Id_Connessione.Size = new Size(0, 13);
			label_Id_Connessione.TabIndex = 17;
			// 
			// buttonInviaMessaggio
			// 
			buttonInviaMessaggio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonInviaMessaggio.BackColor = Color.Transparent;
			buttonInviaMessaggio.BorderColor = Color.FromArgb(32, 34, 37);
			buttonInviaMessaggio.EnteredBorderColor = Color.FromArgb(165, 37, 37);
			buttonInviaMessaggio.EnteredColor = Color.FromArgb(32, 34, 37);
			buttonInviaMessaggio.Font = new Font("Microsoft Sans Serif", 12F);
			buttonInviaMessaggio.Image = null;
			buttonInviaMessaggio.ImageAlign = ContentAlignment.MiddleLeft;
			buttonInviaMessaggio.InactiveColor = Color.FromArgb(32, 34, 37);
			buttonInviaMessaggio.Location = new Point(711, 393);
			buttonInviaMessaggio.Name = "buttonInviaMessaggio";
			buttonInviaMessaggio.PressedBorderColor = Color.FromArgb(165, 37, 37);
			buttonInviaMessaggio.PressedColor = Color.FromArgb(165, 37, 37);
			buttonInviaMessaggio.Size = new Size(77, 45);
			buttonInviaMessaggio.TabIndex = 19;
			buttonInviaMessaggio.Text = "Invia";
			buttonInviaMessaggio.TextAlignment = StringAlignment.Center;
			buttonInviaMessaggio.Click += buttonInviaMessaggio_Click;
			// 
			// textBoxMessages
			// 
			textBoxMessages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBoxMessages.Location = new Point(12, 143);
			textBoxMessages.Multiline = true;
			textBoxMessages.Name = "textBoxMessages";
			textBoxMessages.Size = new Size(693, 244);
			textBoxMessages.TabIndex = 22;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(textBoxMessages);
			Controls.Add(buttonInviaMessaggio);
			Controls.Add(label_Id_Connessione);
			Controls.Add(bigTextBoxMessaggio);
			Controls.Add(buttonAggiornaRichiesteChat);
			Controls.Add(label_Stato_Connessione);
			Controls.Add(smallLabel1);
			Controls.Add(label);
			Controls.Add(button_Connettiti);
			Controls.Add(buttonConnettiti);
			Controls.Add(textBox_Id_PersonaChat);
			Name = "Form1";
			Text = "Form1";
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ReaLTaiizor.Controls.SmallTextBox textBox_Id_PersonaChat;
		private ReaLTaiizor.Controls.Button buttonConnettiti;
		private ReaLTaiizor.Controls.Button button_Connettiti;
		private ReaLTaiizor.Controls.SmallLabel label;
		private ReaLTaiizor.Controls.SmallLabel smallLabel1;
		private ReaLTaiizor.Controls.SmallLabel label_Stato_Connessione;
		private ReaLTaiizor.Controls.Button buttonAggiornaRichiesteChat;
		private ReaLTaiizor.Controls.BigTextBox bigTextBoxMessaggio;
		private ReaLTaiizor.Controls.SmallLabel label_Id_Connessione;
		private ReaLTaiizor.Controls.Button buttonInviaMessaggio;
		private TextBox textBoxMessages;
	}
}
