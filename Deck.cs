using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdoProValidator
{
    internal class Deck
    {
        /// <summary>
        /// Main deck of the deck
        /// </summary>
        public Dictionary<string, int> Main { get { return main; } }
        private Dictionary<string, int> main;

        /// <summary>
        /// Side deck of the deck
        /// </summary>
        public Dictionary<string, int> Side { get { return side; } }
        private Dictionary<string, int> side;

        /// <summary>
        /// Name of the deck
        /// </summary>
        public string Name { get { return name; } }
        private string name;

        /// <summary>
        /// A Yu-Gi-Oh! Deck
        /// </summary>
        /// <param name="filepath">Filepath to .ydk file</param>
        /// <exception cref="InvalidDataException">Thrown if a .ydk file count not be found at "filepath"</exception>
        public Deck(string filepath)
        {
            if (File.Exists(filepath) && filepath.EndsWith(".ydk"))
            {
                main = new Dictionary<string, int>();
                side = new Dictionary<string, int>();
                name = filepath.Split("\\").Last();
                bool siding = false;

                // Convert File to Deck
                foreach (string line in File.ReadAllLines(filepath))
                    if (line.Equals("!side"))
                        siding = true;
                    else if (!line.StartsWith('#') && !string.IsNullOrWhiteSpace(line))
                    {
                        int id;
                        if (int.TryParse(line, out id))
                            if (!AddCard(siding, id))
                                Debug.WriteLine("Could not find card with id " + id);
                            else
                                Debug.WriteLine("Could not convert " + line + " into an integer ID");
                    }
            }
            else
                throw new InvalidDataException(".ydk file not found at " + filepath);
        }

        /// <summary>
        /// Add a card into the deck
        /// </summary>
        /// <param name="siding">Is card being sided</param>
        /// <param name="id">Id of card</param>
        private bool AddCard(bool siding, int id)
        {
            string name = CardDatabase.Instance.IdToName(id);
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (siding)
                    if (side.ContainsKey(name))
                        side[name]++;
                    else
                        side.Add(name, 1);
                else
                    if (main.ContainsKey(name))
                    main[name]++;
                else
                    main.Add(name, 1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validate a deck against a given banlist
        /// </summary>
        /// <param name="banlist">Banlist to validate agains</param>
        /// <returns>True if valid, otherwise false</returns>
        public bool Validate(Banlist banlist)
        {
            foreach(KeyValuePair<string, int> card in banlist.Cards)
            {
                int copies = 0;
                if (main.ContainsKey(card.Key))
                    copies += main[card.Key];
                if (side.ContainsKey(card.Key))
                    copies += side[card.Key];
                if (copies > card.Value)
                    return false;
            }
            return true;
        }

        public List<char> AlphabetValidate()
        {
            List<char> used = new List<char>();
            List<char> issues = new List<char>();
            foreach(string card in main.Keys)
            {
                char start = card[0];
                // Add new char to used
                if (!used.Contains(start))
                    used.Add(start);
                // Add new duplicate issue;
                else if (!issues.Contains(start))
                    issues.Add(start);   
            }
            issues.Sort();
            return issues;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Main Deck:");
            foreach (KeyValuePair<string, int> card in main)
                builder.AppendLine("\t" + card.Value + "x " + card.Key);
            builder.AppendLine("Side Deck:");
            foreach (KeyValuePair<string, int> card in side)
                builder.AppendLine("\t" + card.Value + "x " + card.Key);
            return builder.ToString();
        }
    }
}
