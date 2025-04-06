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
			label_Stato_Connessione = new Label();
			button_Connettiti = new Button();
			label_Id_Connessione = new Label();
			textBox_Id_PersonaChat = new TextBox();
			label1 = new Label();
			buttonConnettiti = new Button();
			textBox1 = new TextBox();
			buttonAggiornaRichiesteChat = new Button();
			SuspendLayout();
			// 
			// label_Stato_Connessione
			// 
			label_Stato_Connessione.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label_Stato_Connessione.AutoSize = true;
			label_Stato_Connessione.Location = new Point(614, 9);
			label_Stato_Connessione.Name = "label_Stato_Connessione";
			label_Stato_Connessione.Size = new Size(108, 15);
			label_Stato_Connessione.TabIndex = 0;
			label_Stato_Connessione.Text = "Stato Connessione:";
			label_Stato_Connessione.Click += label_Stato_Connessione_Click;
			// 
			// button_Connettiti
			// 
			button_Connettiti.Location = new Point(12, 5);
			button_Connettiti.Name = "button_Connettiti";
			button_Connettiti.Size = new Size(75, 23);
			button_Connettiti.TabIndex = 1;
			button_Connettiti.Text = "Connetti";
			button_Connettiti.UseVisualStyleBackColor = true;
			button_Connettiti.Click += button_Connettiti_Click;
			// 
			// label_Id_Connessione
			// 
			label_Id_Connessione.AutoSize = true;
			label_Id_Connessione.Location = new Point(12, 31);
			label_Id_Connessione.Name = "label_Id_Connessione";
			label_Id_Connessione.Size = new Size(95, 15);
			label_Id_Connessione.TabIndex = 2;
			label_Id_Connessione.Text = "ID Connessione: ";
			// 
			// textBox_Id_PersonaChat
			// 
			textBox_Id_PersonaChat.Location = new Point(12, 109);
			textBox_Id_PersonaChat.Name = "textBox_Id_PersonaChat";
			textBox_Id_PersonaChat.Size = new Size(100, 23);
			textBox_Id_PersonaChat.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 91);
			label1.Name = "label1";
			label1.Size = new Size(261, 15);
			label1.TabIndex = 4;
			label1.Text = "Inserisci l'id della persona con cui vuoi chattare: ";
			// 
			// buttonConnettiti
			// 
			buttonConnettiti.Location = new Point(118, 109);
			buttonConnettiti.Name = "buttonConnettiti";
			buttonConnettiti.Size = new Size(75, 23);
			buttonConnettiti.TabIndex = 5;
			buttonConnettiti.Text = "Connettiti";
			buttonConnettiti.UseVisualStyleBackColor = true;
			buttonConnettiti.Click += buttonConnettiti_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 196);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(776, 242);
			textBox1.TabIndex = 6;
			// 
			// buttonAggiornaRichiesteChat
			// 
			buttonAggiornaRichiesteChat.Location = new Point(614, 31);
			buttonAggiornaRichiesteChat.Name = "buttonAggiornaRichiesteChat";
			buttonAggiornaRichiesteChat.Size = new Size(75, 23);
			buttonAggiornaRichiesteChat.TabIndex = 7;
			buttonAggiornaRichiesteChat.Text = "Aggiorna";
			buttonAggiornaRichiesteChat.UseVisualStyleBackColor = true;
			buttonAggiornaRichiesteChat.Click += buttonAggiornaRichiesteChat_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonAggiornaRichiesteChat);
			Controls.Add(textBox1);
			Controls.Add(buttonConnettiti);
			Controls.Add(label1);
			Controls.Add(textBox_Id_PersonaChat);
			Controls.Add(label_Id_Connessione);
			Controls.Add(button_Connettiti);
			Controls.Add(label_Stato_Connessione);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label_Stato_Connessione;
		private Button button_Connettiti;
		private Label label_Id_Connessione;
		private TextBox textBox_Id_PersonaChat;
		private Label label1;
		private Button buttonConnettiti;
		private TextBox textBox1;
		private Button buttonAggiornaRichiesteChat;
	}
}
