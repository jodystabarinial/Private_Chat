using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Text;
using dotenv.net;
using System.Security.Cryptography;
using System;
using System.Windows.Forms;
namespace Private_Chat
{
	public partial class Form1 : Form
	{
		public string connectionString;
		public string encryptionKey;
		SqlConnection cnn;
		SqlCommand cmd;

		int idConnessione;
		string Id_PersonaChat;



		//Connessione Database
		public void ConnettiDb()
		{
			try
			{
				if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
				{
					MessageBox.Show("La connessione è già attiva.");
					return;
				}

				if (cnn == null)
				{
					cnn = new SqlConnection(connectionString);
				}

				cnn.Open();
				Random random = new Random();
				idConnessione = random.Next(0, 999999);
				label_Id_Connessione.Text = $"ID Connessione: {idConnessione}";
				label_Stato_Connessione.Text = "Stato Connessione: Connesso";
				button_Connettiti.Text = "Disconnetti";

				string query = $"INSERT INTO Utenti (IdConnessione) VALUES (@IDConnessione)";

				using (cmd = new SqlCommand(query, cnn))
				{
					cmd.Parameters.Add("@IDConnessione", System.Data.SqlDbType.Int).Value = idConnessione;
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				label_Stato_Connessione.Text = "Stato Connessione: Errore";
				MessageBox.Show($"Errore di connessione: {ex.Message}");
			}
		}

		// Disconnessione Database
		public void DisconnettiDb()
		{
			try
			{
				if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
				{
					string query = "DELETE FROM Utenti WHERE IdConnessione = @IDConnessione";
					using (cmd = new SqlCommand(query, cnn))
					{
						cmd.Parameters.Add("@IDConnessione", System.Data.SqlDbType.Int).Value = idConnessione;
						cmd.ExecuteNonQuery();
					}
					cnn.Close();
					label_Stato_Connessione.Text = "Stato Connessione: Disconnesso";
					label_Id_Connessione.Text = $"ID Connessione: ";
					button_Connettiti.Text = "Connettiti";
				}
				else
				{
					MessageBox.Show("La connessione non è aperta.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore durante la disconnessione: {ex.Message}");
			}
		}

		//Richiesta chat
		public void RichiestaChat()
		{
			try
			{
				string query = "UPDATE Utenti SET InvitoChat = @InvitoChat WHERE IdConnessione = @IDConnessione";
				using (cmd = new SqlCommand(query, cnn))
				{
					cmd.Parameters.Add("@IDConnessione", System.Data.SqlDbType.Int).Value = Id_PersonaChat;
					cmd.Parameters.Add("@InvitoChat", System.Data.SqlDbType.NVarChar).Value = 1;
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show($"Richiesta di chat inviata con successo!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore durante la richiesta chat: {ex.Message}");
			}
		}

		//Aggiorna richieste chat
		public void AggiornaRichiesteChat()
		{
			try
			{
				string query = "SELECT IdConnessione FROM Utenti WHERE InvitoChat = 1 AND IdConnessione = @idConnessione";

				using (cmd = new SqlCommand(query, cnn))
				{
					cmd.Parameters.Add("@idConnessione", System.Data.SqlDbType.Int).Value = idConnessione;


					DialogResult result = MessageBox.Show($"Hai ricevuto un invito alla chat da {idConnessione}. Vuoi accettare?",
														  "Invito Chat", MessageBoxButtons.YesNo);

					string updateQuery;

					if (result == DialogResult.Yes)
					{
						updateQuery = "UPDATE Utenti SET InvitoChat = 0, IsChat = 1 WHERE IdConnessione = @connessioneId";

						MessageBox.Show($"Hai accettato l'invito alla chat .");
					}
					else
					{
						updateQuery = "UPDATE Utenti SET InvitoChat = 0, IsChat = 0 WHERE IdConnessione = @connessioneId";
					}

					using (cmd = new SqlCommand(updateQuery, cnn))
					{
						cmd.Parameters.Add("@connessioneId", System.Data.SqlDbType.Int).Value = idConnessione;
						cmd.ExecuteNonQuery();
					}


				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore durante l'aggiornamento delle richieste chat: {ex.Message}");
			}
		}
		private Page_Loading formCaricamento;
		public Form1()
		{
			formCaricamento = new Page_Loading();
			formCaricamento.Show();
			Application.DoEvents();
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;

			formCaricamento.Close();
		}

		private void label_Stato_Connessione_Click(object sender, EventArgs e)
		{

		}

		private void button_Connettiti_Click(object sender, EventArgs e)
		{
			try
			{
				if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
				{
					DisconnettiDb();
					string query = "DELETE FROM Messaggi WHERE MittenteId = @IDconn AND DestinatarioId = @IDestinatario OR MittenteId = @IDestinatario AND DestinatarioId = @IDconn";
					cnn.Open();
					using (SqlCommand cmd = new SqlCommand(query, cnn))
					{
						cmd.Parameters.Add("@IDconn", System.Data.SqlDbType.Int).Value = idConnessione;
						if (string.IsNullOrEmpty(Id_PersonaChat))
						{
							return;
						}
						int destinatarioId;
						if (!int.TryParse(Id_PersonaChat, out destinatarioId))
						{
							MessageBox.Show("ID destinatario non valido.");
							return;
						}
						cmd.Parameters.Add("@IDestinatario", System.Data.SqlDbType.Int).Value = int.Parse(Id_PersonaChat);
						cmd.ExecuteNonQuery();
					}

					cnn.Close();
				}
				else
				{
					ConnettiDb();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore: {ex.Message}");
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

			IConfiguration config = builder.Build();
			connectionString = config.GetConnectionString("DefaultConnection");
			encryptionKey = config["Encryption:Key"];


			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
			timer.Interval = 5000;
			timer.Tick += (s, ev) => ControllaMessaggi();
			timer.Start();


		}

		private void buttonConnettiti_Click(object sender, EventArgs e)
		{
			if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
			{
				Id_PersonaChat = textBox_Id_PersonaChat.Text;
				RichiestaChat();
			}
			else
			{
				Console.WriteLine("Devi prima connetterti al database");
			}
		}

		private void buttonAggiornaRichiesteChat_Click(object sender, EventArgs e)
		{
			AggiornaRichiesteChat();
		}

		private void label_Id_Connessione_Click(object sender, EventArgs e)
		{

		}
		string testo;
		private void buttonInviaMessaggio_Click(object sender, EventArgs e)
		{
			testo = bigTextBoxMessaggio.Text;
			string chiave = encryptionKey;

			string messaggioCifrato = CifraMessaggio(testo, chiave);
			InviaMessaggio(messaggioCifrato);

		}

		public void InviaMessaggio(string messaggioCifrato)
		{
			try
			{
				string query = "INSERT INTO Messaggi (MittenteId, DestinatarioId, Testo) VALUES (@mittente, @destinatario, @testo)";
				using (cmd = new SqlCommand(query, cnn))
				{
					cmd.Parameters.Add("@mittente", System.Data.SqlDbType.Int).Value = idConnessione;
					cmd.Parameters.Add("@destinatario", System.Data.SqlDbType.Int).Value = int.Parse(Id_PersonaChat);
					cmd.Parameters.Add("@testo", System.Data.SqlDbType.NVarChar).Value = messaggioCifrato;
					cmd.ExecuteNonQuery();
				}
				//MessageBox.Show("Messaggio inviato!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore nell'invio del messaggio: {ex.Message}");
			}
		}
		int lastMessageId = 0;

		public void ControllaMessaggi()
		{
			try
			{
				string query = "SELECT Id, MittenteId, Testo, DataInvio FROM Messaggi WHERE DestinatarioId = @destinatario AND Id > @lastId ORDER BY Id";
				using (cmd = new SqlCommand(query, cnn))
				{
					cmd.Parameters.Add("@destinatario", System.Data.SqlDbType.Int).Value = idConnessione;
					cmd.Parameters.Add("@lastId", System.Data.SqlDbType.Int).Value = lastMessageId;

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int currentId = Convert.ToInt32(reader["Id"]);
							string mittente = reader["MittenteId"].ToString();
							string messaggioCifrato = reader["Testo"].ToString();
							string data = reader["DataInvio"].ToString();

							string testoDecifrato = DecifraMessaggio(messaggioCifrato, encryptionKey);

							textBoxMessages.AppendText($"[{data}] {mittente}: {testoDecifrato}\r\n");

							// Aggiorna lastMessageId
							lastMessageId = currentId;
						}
					}
				}
			}
			catch (Exception ex)
			{

			}
		}

		public string CifraMessaggio(string messaggio, string chiave)
		{
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Encoding.UTF8.GetBytes(chiave.PadRight(32).Substring(0, 16));
				aesAlg.IV = new byte[16];

				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

				using (MemoryStream msEncrypt = new MemoryStream())
				{
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							swEncrypt.Write(messaggio);
						}
						return Convert.ToBase64String(msEncrypt.ToArray());
					}
				}
			}
		}
		public string DecifraMessaggio(string messaggioCifrato, string chiave)
		{
			using (Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Encoding.UTF8.GetBytes(chiave.PadRight(32).Substring(0, 16));
				aesAlg.IV = new byte[16];
				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
				using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(messaggioCifrato)))
				using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
				using (StreamReader srDecrypt = new StreamReader(csDecrypt))
				{
					return srDecrypt.ReadToEnd();
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{

				string query = "DELETE FROM Messaggi WHERE MittenteId = @IDconn AND DestinatarioId = @IDestinatario OR MittenteId = @IDestinatario AND DestinatarioId = @IDconn";
				if (cnn == null || cnn.State != System.Data.ConnectionState.Open)
				{
					return;
				}
				using (SqlCommand cmd = new SqlCommand(query, cnn))
				{
					cmd.Parameters.Add("@IDconn", System.Data.SqlDbType.Int).Value = idConnessione;
					if (string.IsNullOrEmpty(Id_PersonaChat))
					{
						return;
					}

					if (!int.TryParse(Id_PersonaChat, out int idDestinatario))
					{
						return;
					}
					cmd.Parameters.Add("@IDestinatario", System.Data.SqlDbType.Int).Value = idDestinatario;
					cmd.ExecuteNonQuery();
				}
				string query2 = "DELETE FROM Utenti WHERE IdConnessione = @IDConnessione";
				using (cmd = new SqlCommand(query2, cnn))
				{
					cmd.Parameters.Add("@IDConnessione", System.Data.SqlDbType.Int).Value = idConnessione;
					cmd.ExecuteNonQuery();
				}
				cnn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Sembra essere impossibile chiudere la form senza essere connessi al server." +
					$" Prova ad aprire la connessione e poi ad chiudere la form (Questo errore non dovrebbe capitare, i dati" +
					$"verranno comunque eliminati dal server");

			}
		}

		private void hopePictureBox4_Click(object sender, EventArgs e)
		{

		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
				{
					string query = "DELETE FROM Utenti WHERE IdConnessione = @IDConnessione";
					using (cmd = new SqlCommand(query, cnn))
					{
						cmd.Parameters.Add("@IDConnessione", System.Data.SqlDbType.Int).Value = idConnessione;
						cmd.ExecuteNonQuery();
					}
					cnn.Close();
					label_Stato_Connessione.Text = "Stato Connessione: Disconnesso";
					label_Id_Connessione.Text = $"ID Connessione: ";
					button_Connettiti.Text = "Connettiti";
				}
				else
				{
					MessageBox.Show("La connessione non è aperta.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore durante la disconnessione: {ex.Message}");
			}
		}
	}
}
