using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Data.SqlClient;
namespace Private_Chat
{
	public partial class Form1 : Form
	{
		public string connectionString;
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
		public Form1()
		{
			InitializeComponent();
		}

		private void label_Stato_Connessione_Click(object sender, EventArgs e)
		{

		}

		private void button_Connettiti_Click(object sender, EventArgs e)
		{
			if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
			{
				DisconnettiDb();
			}
			else
			{
				ConnettiDb();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

			IConfiguration config = builder.Build();
			connectionString = config.GetConnectionString("DefaultConnection");
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
	}
}
