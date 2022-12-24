using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdoProValidator
{
    internal class Banlist
    {
        /// <summary>
        /// All Cards in the Banlist
        /// </summary>
        public Dictionary<string, int> Cards { get { return cards; } }
        private Dictionary<string, int> cards;

        /// <summary>
        /// Name of the deck
        /// </summary>
        public string Name { get { return name; } }
        private string name;

        public Banlist(string filepath)
        {
            cards = new Dictionary<string, int>();
            string[] lines = File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                name = lines[0].Remove(0, 1);
                foreach (string line in File.ReadAllLines(filepath))
                {
                    string[] splits = line.Split(" ");
                    if (!line.StartsWith('#') && !line.StartsWith('!') && !string.IsNullOrWhiteSpace(line) && splits.Length >= 2)
                    {
                        int max;
                        int id;
                        if (int.TryParse(splits[0], out id) && int.TryParse(splits[1], out max))
                        {
                            string name = CardDatabase.Instance.IdToName(id);
                            if (!string.IsNullOrWhiteSpace(name))
                                if (!cards.ContainsKey(name))
                                    cards.Add(name, max);
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<string, int> card in cards)
                builder.AppendLine("\t" + card.Value.ToString() + "x " + card.Key.ToString());
            return builder.ToString();
        }
    }
}
