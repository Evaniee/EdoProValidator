namespace EdoProValidator
{
    partial class frm_validator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_validator));
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.tsb_source = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddb_banlist = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_validate = new System.Windows.Forms.ToolStripButton();
            this.dgv_decks = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddb_restrictions = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_none = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_alphabet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv_tbc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cbc_valid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_tbc_alphabet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_decks)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_main
            // 
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_source,
            this.toolStripSeparator2,
            this.tsddb_banlist,
            this.toolStripSeparator1,
            this.tsb_validate,
            this.toolStripSeparator3,
            this.tsddb_restrictions});
            this.ts_main.Location = new System.Drawing.Point(0, 0);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(500, 25);
            this.ts_main.TabIndex = 0;
            this.ts_main.Text = "toolStrip1";
            // 
            // tsb_source
            // 
            this.tsb_source.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_source.Image = ((System.Drawing.Image)(resources.GetObject("tsb_source.Image")));
            this.tsb_source.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_source.Name = "tsb_source";
            this.tsb_source.Size = new System.Drawing.Size(91, 22);
            this.tsb_source.Text = "Change Source";
            this.tsb_source.Click += new System.EventHandler(this.tsb_source_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddb_banlist
            // 
            this.tsddb_banlist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddb_banlist.Image = ((System.Drawing.Image)(resources.GetObject("tsddb_banlist.Image")));
            this.tsddb_banlist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddb_banlist.Name = "tsddb_banlist";
            this.tsddb_banlist.Size = new System.Drawing.Size(89, 22);
            this.tsddb_banlist.Text = "Select Banlist";
            this.tsddb_banlist.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddb_banlist_DropDownItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_validate
            // 
            this.tsb_validate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_validate.Image = ((System.Drawing.Image)(resources.GetObject("tsb_validate.Image")));
            this.tsb_validate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_validate.Name = "tsb_validate";
            this.tsb_validate.Size = new System.Drawing.Size(52, 22);
            this.tsb_validate.Text = "Validate";
            this.tsb_validate.Click += new System.EventHandler(this.tsb_validate_Click);
            // 
            // dgv_decks
            // 
            this.dgv_decks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_decks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_tbc_name,
            this.dgv_cbc_valid,
            this.dgv_tbc_alphabet});
            this.dgv_decks.Location = new System.Drawing.Point(10, 30);
            this.dgv_decks.Name = "dgv_decks";
            this.dgv_decks.ReadOnly = true;
            this.dgv_decks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_decks.RowTemplate.Height = 25;
            this.dgv_decks.Size = new System.Drawing.Size(480, 400);
            this.dgv_decks.TabIndex = 1;
            this.dgv_decks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_decks_CellContentClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddb_restrictions
            // 
            this.tsddb_restrictions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddb_restrictions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_none,
            this.toolStripSeparator4,
            this.tsmi_alphabet});
            this.tsddb_restrictions.Image = ((System.Drawing.Image)(resources.GetObject("tsddb_restrictions.Image")));
            this.tsddb_restrictions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddb_restrictions.Name = "tsddb_restrictions";
            this.tsddb_restrictions.Size = new System.Drawing.Size(81, 22);
            this.tsddb_restrictions.Text = "Restrictions";
            // 
            // tsmi_none
            // 
            this.tsmi_none.Name = "tsmi_none";
            this.tsmi_none.Size = new System.Drawing.Size(180, 22);
            this.tsmi_none.Text = "None";
            this.tsmi_none.Click += new System.EventHandler(this.tsmi_none_Click);
            // 
            // tsmi_alphabet
            // 
            this.tsmi_alphabet.Name = "tsmi_alphabet";
            this.tsmi_alphabet.Size = new System.Drawing.Size(180, 22);
            this.tsmi_alphabet.Text = "Alphabet";
            this.tsmi_alphabet.Click += new System.EventHandler(this.tsmi_alphabet_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // dgv_tbc_name
            // 
            this.dgv_tbc_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_tbc_name.HeaderText = "Name";
            this.dgv_tbc_name.Name = "dgv_tbc_name";
            this.dgv_tbc_name.ReadOnly = true;
            // 
            // dgv_cbc_valid
            // 
            this.dgv_cbc_valid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_cbc_valid.HeaderText = "Valid";
            this.dgv_cbc_valid.Name = "dgv_cbc_valid";
            this.dgv_cbc_valid.ReadOnly = true;
            this.dgv_cbc_valid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cbc_valid.Width = 38;
            // 
            // dgv_tbc_alphabet
            // 
            this.dgv_tbc_alphabet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_tbc_alphabet.HeaderText = "Alphabet Duplicates";
            this.dgv_tbc_alphabet.Name = "dgv_tbc_alphabet";
            this.dgv_tbc_alphabet.ReadOnly = true;
            this.dgv_tbc_alphabet.Visible = false;
            this.dgv_tbc_alphabet.Width = 138;
            // 
            // frm_validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 442);
            this.Controls.Add(this.dgv_decks);
            this.Controls.Add(this.ts_main);
            this.Name = "frm_validator";
            this.Text = "EDOPRO Deck Validator";
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_decks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip ts_main;
        private ToolStripDropDownButton tsddb_banlist;
        private DataGridView dgv_decks;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsb_source;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsb_validate;
        private DataGridViewCheckBoxColumn dgv_cbc_alphabet;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton tsddb_restrictions;
        private ToolStripMenuItem tsmi_none;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsmi_alphabet;
        private DataGridViewTextBoxColumn dgv_tbc_name;
        private DataGridViewCheckBoxColumn dgv_cbc_valid;
        private DataGridViewTextBoxColumn dgv_tbc_alphabet;
    }
}