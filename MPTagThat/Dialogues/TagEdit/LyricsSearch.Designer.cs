﻿namespace MPTagThat.TagEdit
{
  partial class LyricsSearch
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
      this.btCancel = new MPTagThat.Core.WinControls.MPTButton();
      this.tbTitle = new System.Windows.Forms.TextBox();
      this.lvSearchResults = new System.Windows.Forms.ListView();
      this.chSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chLyric = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.groupBox1 = new MPTagThat.Core.WinControls.MPTGroupBox();
      this.lbTitle = new MPTagThat.Core.WinControls.MPTLabel();
      this.btUpdate = new MPTagThat.Core.WinControls.MPTButton();
      this.tbArtist = new System.Windows.Forms.TextBox();
      this.btFind = new MPTagThat.Core.WinControls.MPTButton();
      this.btClose = new MPTagThat.Core.WinControls.MPTButton();
      this.tbLyrics = new System.Windows.Forms.TextBox();
      this.groupBox2 = new MPTagThat.Core.WinControls.MPTGroupBox();
      this.lbArtist = new MPTagThat.Core.WinControls.MPTLabel();
      this.gbSearchInfo = new MPTagThat.Core.WinControls.MPTGroupBox();
      this.btSwitchArtist = new MPTagThat.Core.WinControls.MPTButton();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.gbSearchInfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // btCancel
      // 
      this.btCancel.Id = "512afead-3145-484e-a7ee-6d543133c3d1";
      this.btCancel.Localisation = "Cancel";
      this.btCancel.LocalisationContext = "LyricsSearch";
      this.btCancel.Location = new System.Drawing.Point(489, 109);
      this.btCancel.Name = "btCancel";
      this.btCancel.Size = new System.Drawing.Size(100, 23);
      this.btCancel.TabIndex = 42;
      this.btCancel.Text = "&Cancel";
      this.btCancel.UseVisualStyleBackColor = true;
      this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
      // 
      // tbTitle
      // 
      this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbTitle.Location = new System.Drawing.Point(73, 53);
      this.tbTitle.Name = "tbTitle";
      this.tbTitle.Size = new System.Drawing.Size(498, 20);
      this.tbTitle.TabIndex = 2;
      // 
      // lvSearchResults
      // 
      this.lvSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSite,
            this.chResult,
            this.chLyric});
      this.lvSearchResults.FullRowSelect = true;
      this.lvSearchResults.Location = new System.Drawing.Point(17, 21);
      this.lvSearchResults.MultiSelect = false;
      this.lvSearchResults.Name = "lvSearchResults";
      this.lvSearchResults.Size = new System.Drawing.Size(554, 152);
      this.lvSearchResults.TabIndex = 10;
      this.lvSearchResults.UseCompatibleStateImageBehavior = false;
      this.lvSearchResults.View = System.Windows.Forms.View.Details;
      this.lvSearchResults.SelectedIndexChanged += new System.EventHandler(this.lvSearchResults_SelectedIndexChanged);
      this.lvSearchResults.DoubleClick += new System.EventHandler(this.lvSearchResults_DoubleClick);
      // 
      // chSite
      // 
      this.chSite.Text = "Site";
      this.chSite.Width = 113;
      // 
      // chResult
      // 
      this.chResult.Text = "Result";
      this.chResult.Width = 58;
      // 
      // chLyric
      // 
      this.chLyric.Text = "Lyric";
      this.chLyric.Width = 375;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.lvSearchResults);
      this.groupBox1.Id = "9acc7891-750c-4711-945d-aa94f486977b";
      this.groupBox1.Localisation = "GroupBoxSearchResults";
      this.groupBox1.LocalisationContext = "LyricsSearch";
      this.groupBox1.Location = new System.Drawing.Point(18, 148);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(591, 191);
      this.groupBox1.TabIndex = 39;
      this.groupBox1.Text = "Search results";
      // 
      // lbTitle
      // 
      this.lbTitle.Localisation = "Title";
      this.lbTitle.LocalisationContext = "LyricsSearch";
      this.lbTitle.Location = new System.Drawing.Point(15, 56);
      this.lbTitle.Name = "lbTitle";
      this.lbTitle.Size = new System.Drawing.Size(30, 13);
      this.lbTitle.TabIndex = 2;
      this.lbTitle.Text = "Title:";
      // 
      // btUpdate
      // 
      this.btUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btUpdate.Enabled = false;
      this.btUpdate.Id = "617aeb49-8a43-431b-b319-ec45f68116be";
      this.btUpdate.Localisation = "Update";
      this.btUpdate.LocalisationContext = "LyricsSearch";
      this.btUpdate.Location = new System.Drawing.Point(403, 599);
      this.btUpdate.Name = "btUpdate";
      this.btUpdate.Size = new System.Drawing.Size(100, 23);
      this.btUpdate.TabIndex = 43;
      this.btUpdate.Text = "Update";
      this.btUpdate.UseVisualStyleBackColor = true;
      this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
      // 
      // tbArtist
      // 
      this.tbArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbArtist.Location = new System.Drawing.Point(73, 26);
      this.tbArtist.Name = "tbArtist";
      this.tbArtist.Size = new System.Drawing.Size(498, 20);
      this.tbArtist.TabIndex = 1;
      // 
      // btFind
      // 
      this.btFind.Id = "b9513354-0ab0-4eb2-9ab8-b6132886f6bb";
      this.btFind.Localisation = "Find";
      this.btFind.LocalisationContext = "LyricsSearch";
      this.btFind.Location = new System.Drawing.Point(383, 109);
      this.btFind.Name = "btFind";
      this.btFind.Size = new System.Drawing.Size(100, 23);
      this.btFind.TabIndex = 41;
      this.btFind.Text = "&Fetch";
      this.btFind.UseVisualStyleBackColor = true;
      this.btFind.Click += new System.EventHandler(this.btFind_Click);
      // 
      // btClose
      // 
      this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btClose.Id = "a8efc655-3c74-402e-ae90-24da17fb017c";
      this.btClose.Localisation = "Close";
      this.btClose.LocalisationContext = "LyricsSearch";
      this.btClose.Location = new System.Drawing.Point(509, 599);
      this.btClose.Name = "btClose";
      this.btClose.Size = new System.Drawing.Size(100, 23);
      this.btClose.TabIndex = 44;
      this.btClose.Text = "Close";
      this.btClose.UseVisualStyleBackColor = true;
      this.btClose.Click += new System.EventHandler(this.btClose_Click);
      // 
      // tbLyrics
      // 
      this.tbLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbLyrics.Location = new System.Drawing.Point(17, 19);
      this.tbLyrics.Multiline = true;
      this.tbLyrics.Name = "tbLyrics";
      this.tbLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLyrics.Size = new System.Drawing.Size(554, 193);
      this.tbLyrics.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.tbLyrics);
      this.groupBox2.Id = "40b91b00-0b77-4b76-a233-ea42be63285e";
      this.groupBox2.Localisation = "GroupBoxLyric";
      this.groupBox2.LocalisationContext = "LyricsSearch";
      this.groupBox2.Location = new System.Drawing.Point(18, 356);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(591, 230);
      this.groupBox2.TabIndex = 40;
      this.groupBox2.Text = "Lyric";
      // 
      // lbArtist
      // 
      this.lbArtist.Localisation = "Artist";
      this.lbArtist.LocalisationContext = "LyricsSearch";
      this.lbArtist.Location = new System.Drawing.Point(15, 29);
      this.lbArtist.Name = "lbArtist";
      this.lbArtist.Size = new System.Drawing.Size(33, 13);
      this.lbArtist.TabIndex = 0;
      this.lbArtist.Text = "Artist:";
      // 
      // gbSearchInfo
      // 
      this.gbSearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbSearchInfo.Controls.Add(this.tbTitle);
      this.gbSearchInfo.Controls.Add(this.lbTitle);
      this.gbSearchInfo.Controls.Add(this.tbArtist);
      this.gbSearchInfo.Controls.Add(this.lbArtist);
      this.gbSearchInfo.Id = "5f7de5a3-08f5-4fee-a4e1-45a37d4535cf";
      this.gbSearchInfo.Localisation = "GroupBoxSearchInfo";
      this.gbSearchInfo.LocalisationContext = "LyricsSearch";
      this.gbSearchInfo.Location = new System.Drawing.Point(18, 18);
      this.gbSearchInfo.Name = "gbSearchInfo";
      this.gbSearchInfo.Size = new System.Drawing.Size(591, 85);
      this.gbSearchInfo.TabIndex = 38;
      this.gbSearchInfo.Text = "Search information";
      // 
      // btSwitchArtist
      // 
      this.btSwitchArtist.Id = "094642bb-33e6-4e95-bb93-1a623cef6c55";
      this.btSwitchArtist.Localisation = "SwitchArtist";
      this.btSwitchArtist.LocalisationContext = "LyricsSearch";
      this.btSwitchArtist.Location = new System.Drawing.Point(18, 109);
      this.btSwitchArtist.Name = "btSwitchArtist";
      this.btSwitchArtist.Size = new System.Drawing.Size(192, 23);
      this.btSwitchArtist.TabIndex = 45;
      this.btSwitchArtist.Text = "&Switch Artist";
      this.btSwitchArtist.UseVisualStyleBackColor = true;
      this.btSwitchArtist.Click += new System.EventHandler(this.btSwitchArtist_Click);
      // 
      // LyricsSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(631, 634);
      this.Controls.Add(this.btSwitchArtist);
      this.Controls.Add(this.btCancel);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btUpdate);
      this.Controls.Add(this.btFind);
      this.Controls.Add(this.btClose);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.gbSearchInfo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "LyricsSearch";
      this.ShowInTaskbar = false;
      this.Text = "LyricsSearch";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.gbSearchInfo.ResumeLayout(false);
      this.gbSearchInfo.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MPTagThat.Core.WinControls.MPTButton btCancel;
    private System.Windows.Forms.TextBox tbTitle;
    private System.Windows.Forms.ListView lvSearchResults;
    private System.Windows.Forms.ColumnHeader chSite;
    private System.Windows.Forms.ColumnHeader chResult;
    private System.Windows.Forms.ColumnHeader chLyric;
    private MPTagThat.Core.WinControls.MPTGroupBox groupBox1;
    private MPTagThat.Core.WinControls.MPTLabel lbTitle;
    private MPTagThat.Core.WinControls.MPTButton btUpdate;
    private System.Windows.Forms.TextBox tbArtist;
    private MPTagThat.Core.WinControls.MPTButton btFind;
    private MPTagThat.Core.WinControls.MPTButton btClose;
    private System.Windows.Forms.TextBox tbLyrics;
    private MPTagThat.Core.WinControls.MPTGroupBox groupBox2;
    private MPTagThat.Core.WinControls.MPTLabel lbArtist;
    private MPTagThat.Core.WinControls.MPTGroupBox gbSearchInfo;
    private MPTagThat.Core.WinControls.MPTButton btSwitchArtist;
  }
}