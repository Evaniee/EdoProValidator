using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdoProValidator
{
    internal class CardDatabase
    {
        /// <summary>
        /// All Cards in the Database
        /// </summary>
        public Dictionary<int, string> Cards { get { return cards; } }
        private Dictionary<int, string> cards;

        /// <summary>
        /// Get the current instance of the Card Database
        /// </summary>
        public static CardDatabase Instance
        {
            get
            {
                if (instance == null)
                    instance = new CardDatabase();
                return instance;
            }
        }
        private static CardDatabase instance;

        /// <summary>
        /// A Database of Yu-Gi-Oh! Cards
        /// </summary>
        private CardDatabase() { cards = new Dictionary<int, string>(); }

        /// <summary>
        /// Use a different source for data
        /// </summary>
        /// <param name="edoInstall">EDOPRO install directory to pull files from</param>
        /// <returns>True if successful, null if missing delta.cards.cdb, false if missing cards.cdb</returns>
        public bool? UseSource(string edoInstall)
        {
            cards.Clear();

            bool? result = true;
            string delta = edoInstall + "\\repositories\\delta-puppet\\cards.delta.cdb";
            string normal = edoInstall + "\\expansions\\cards.cdb";

            // Delta for up to date names;
            if (File.Exists(delta))
            {
                if (!AddSource(delta))
                    result = null;
            }
            // If cards.delta.cdb not found. Will have some cards with incorrect names
            else
                result = null;

            // Remaining cards from cards.cdb
            if (File.Exists(normal))
            {
                if (!AddSource(normal))
                    result = false;
            }
            // Too many cards will be missing to be reasonably useable
            else
                result = false;
            return result;
        }

        /// <summary>
        /// Add another datasource to the current database
        /// </summary>
        /// <param name="source">New source to add</param>
        /// <returns>True if successful, otherwise false</returns>
        private bool AddSource(string source)
        {
            try
            {
                using (SqliteConnection connection = new SqliteConnection("Data Source=" + source))
                {
                    connection.Open();
                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT id, name FROM texts";
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                if (!cards.ContainsKey(id))
                                    cards.Add(id, reader.GetString(1));
                            }
                        }
                    }
                    connection.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Get a cards name from its ID
        /// </summary>
        /// <param name="id">ID of a card</param>
        /// <returns>Card's name if known, otherwise empty string</returns>
        public string IdToName(int id)
        {
            if (cards.ContainsKey(id))
                return cards[id];
            return string.Empty;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<int, string> card in cards)
                builder.AppendLine(card.Value + " = " + card.Key);
            return builder.ToString();
        }
    }
}
