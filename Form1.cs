using System.Text;

namespace EdoProValidator
{
    public partial class frm_validator : Form
    {
        private List<Tuple<Deck,DataGridViewRow,List<char>>> decks;
        private List<Banlist> banlists;
        private Banlist? selectedList;
        private string edoInstall;
        public frm_validator()
        {
            InitializeComponent();
            UpdateSource();
        }

        private void tsb_source_Click(object sender, EventArgs e)
        {
            UpdateSource();
        }

        private void UpdateSource()
        {
            FolderBrowserDialog fbd_source = new FolderBrowserDialog();
            fbd_source.ShowNewFolderButton = false;
            fbd_source.UseDescriptionForTitle = true;
            fbd_source.Description = "Select your EDOPRO install";
            if (fbd_source.ShowDialog() == DialogResult.OK)
            {
                edoInstall = fbd_source.SelectedPath;
                CardDatabase.Instance.UseSource(edoInstall);
                if (Directory.Exists(edoInstall + "\\deck"))
                {
                    decks = new List<Tuple<Deck,DataGridViewRow,List<char>>>();
                    foreach (string filepath in Directory.GetFiles(edoInstall + "\\deck", "*.ydk", SearchOption.AllDirectories))
                        try
                        {
                            // Add to Decks
                            Deck deck = new Deck(filepath);
                            

                            // Add to Data Grid View
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgv_decks);
                            row.Cells[0].Value = deck.Name;
                            dgv_decks.Rows.Add(row);
                            decks.Add(new Tuple<Deck,DataGridViewRow,List<char>>(deck,row,new List<char>()));
                        }
                        catch (Exception e)
                        {

                        }
                }
                else
                {
                    MessageBox.Show("Erorr! Could not find directory \"" + edoInstall + "\\decks\". Select a valid EDOPRO install.");
                }

                banlists = new List<Banlist>();
                if(Directory.Exists(edoInstall + "\\lflists"))
                {
                    foreach (string filepath in Directory.GetFiles(edoInstall + "\\lflists", "*.lflist.conf", SearchOption.AllDirectories))
                        try
                        {
                            // Add to Decks
                            Banlist banlist = new Banlist(filepath);
                            banlists.Add(banlist);

                            // Add to Dropdown
                            tsddb_banlist.DropDownItems.Add(banlist.Name);
                        }
                        catch (Exception e)
                        {

                        }
                }
                else
                {
                    MessageBox.Show("Erorr! Could not find directory \"" + edoInstall + "\\lflists\". EDOPRO install selected may not be valid. Some banlists may be missing.");
                }

                if (Directory.Exists(edoInstall + "\\repositories"))
                {
                    foreach (string filepath in Directory.GetFiles(edoInstall + "\\repositories", "*.lflist.conf", SearchOption.AllDirectories))
                        try
                        {
                            // Add to Decks
                            Banlist banlist = new Banlist(filepath);
                            banlists.Add(banlist);

                            // Add to Dropdown
                            tsddb_banlist.DropDownItems.Add(banlist.Name);
                        }
                        catch (Exception e)
                        {

                        }
                }
                else
                {
                    MessageBox.Show("Erorr! Could not find directory \"" + edoInstall + "\\repositories\". EDOPRO install selected may not be valid. Some banlists may be missing.");
                }

                ValidateDecks();
            }
        }

        private void tsddb_banlist_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string selected = e.ClickedItem.Text;
            selectedList = banlists.Find(x => x.Name == selected);
            if(selectedList != null)
            {
                this.Text = "EDOPRO Deck Validator - " + selectedList.Name;
                ValidateDecks();
            }
        }

        private void ValidateDecks()
        {
            if(selectedList != null)
                foreach(Tuple<Deck, DataGridViewRow,List<char>> deck in decks)
                {
                    bool valid = deck.Item1.Validate(selectedList);
                    deck.Item2.Cells[1].Value = valid;

                    // Validate to alphabet ruleset and display issue characters.
                    List<char> issues = deck.Item1.AlphabetValidate();
                    StringBuilder builder = new StringBuilder();
                    for(int i = 0; i < issues.Count; i++)
                        if (i == 0)
                            builder.Append(issues[i]);
                        else
                            builder.Append(", " + issues[i]);
                    deck.Item2.Cells[2].Value = builder.ToString();
                }


        }

        private void tsb_validate_Click(object sender, EventArgs e)
        {
            ValidateDecks();
        }

        private void dgv_decks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Deck deck = decks.Find(x => x.Item2 == dgv_decks.Rows[e.RowIndex]).Item1;
                MessageBox.Show(deck.ToString(), deck.Name);
            }
            catch(Exception ex) { }
        }
    }
}