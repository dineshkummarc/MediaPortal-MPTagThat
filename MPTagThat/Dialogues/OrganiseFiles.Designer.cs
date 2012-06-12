namespace MPTagThat.Organise
{
  partial class OrganiseFiles
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
      this.btApply = new MPTagThat.Core.WinControls.MPTButton();
      this.btCancel = new MPTagThat.Core.WinControls.MPTButton();
      this.groupBoxParm = new MPTagThat.Core.WinControls.MPTGroupBox();
      this.lblParmFolder = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmFirstAlbumArtist = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmFirstArtist = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblModifiedBy = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblBPM = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblSubTitle = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblContentGroup = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblComposer = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblConductor = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmBitRate = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmComment = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblAlbumArtist = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmGenre = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmDiscTotal = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmDisc = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmTrackTotal = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmTrack = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmYear = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmAlbum = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmTitle = new MPTagThat.Core.WinControls.MPTLabel();
      this.lblParmArtist = new MPTagThat.Core.WinControls.MPTLabel();
      this.ckOverwriteFiles = new MPTagThat.Core.WinControls.MPTCheckBox();
      this.ckCopyFiles = new MPTagThat.Core.WinControls.MPTCheckBox();
      this.ckCopyNonMusicFiles = new MPTagThat.Core.WinControls.MPTCheckBox();
      this.groupBoxOptions = new MPTagThat.Core.WinControls.MPTGroupBox();
      this.cbScripts = new System.Windows.Forms.ComboBox();
      this.lblOverrideTargetRootDir = new MPTagThat.Core.WinControls.MPTLabel();
      this.labelHeader = new MPTagThat.Core.WinControls.MPTLabel();
      this.groupBoxSelection = new MPTagThat.Core.WinControls.MPTGroupBox();
      this.btReview = new MPTagThat.Core.WinControls.MPTButton();
      this.cbRootDir = new System.Windows.Forms.ComboBox();
      this.buttonBrowseRootDir = new MPTagThat.Core.WinControls.MPTButton();
      this.lblTargetRootDrectory = new MPTagThat.Core.WinControls.MPTLabel();
      this.btRemoveFormat = new MPTagThat.Core.WinControls.MPTButton();
      this.btAddFormat = new MPTagThat.Core.WinControls.MPTButton();
      this.cbFormat = new System.Windows.Forms.ComboBox();
      this.lblFormat = new MPTagThat.Core.WinControls.MPTLabel();
      this.tabControl1 = new Elegant.Ui.TabControl();
      this.tabPageParameter = new MPTagThat.Core.WinControls.MPTTabPage();
      this.tabPagePreview = new MPTagThat.Core.WinControls.MPTTabPage();
      this.mptPanel1 = new MPTagThat.Core.WinControls.MPTPanel();
      this.groupBoxParm.SuspendLayout();
      this.groupBoxOptions.SuspendLayout();
      this.groupBoxSelection.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
      this.tabPageParameter.SuspendLayout();
      this.mptPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btApply
      // 
      this.btApply.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btApply.Id = "25a677de-50c3-4dcb-96e8-5977032faf48";
      this.btApply.Localisation = "ButtonOrganise";
      this.btApply.LocalisationContext = "Organise";
      this.btApply.Location = new System.Drawing.Point(667, 10);
      this.btApply.Name = "btApply";
      this.btApply.Size = new System.Drawing.Size(100, 23);
      this.btApply.TabIndex = 3;
      this.btApply.Text = "Apply";
      this.btApply.UseVisualStyleBackColor = true;
      this.btApply.Click += new System.EventHandler(this.btApply_Click);
      // 
      // btCancel
      // 
      this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancel.Id = "d270a889-3439-4b70-8c85-b982ba7d1f2f";
      this.btCancel.Localisation = "Cancel";
      this.btCancel.LocalisationContext = "TagAndRename";
      this.btCancel.Location = new System.Drawing.Point(774, 10);
      this.btCancel.Name = "btCancel";
      this.btCancel.Size = new System.Drawing.Size(100, 23);
      this.btCancel.TabIndex = 4;
      this.btCancel.Text = "Cancel";
      this.btCancel.UseVisualStyleBackColor = true;
      this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
      // 
      // groupBoxParm
      // 
      this.groupBoxParm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxParm.Controls.Add(this.lblParmFolder);
      this.groupBoxParm.Controls.Add(this.lblParmFirstAlbumArtist);
      this.groupBoxParm.Controls.Add(this.lblParmFirstArtist);
      this.groupBoxParm.Controls.Add(this.lblModifiedBy);
      this.groupBoxParm.Controls.Add(this.lblBPM);
      this.groupBoxParm.Controls.Add(this.lblSubTitle);
      this.groupBoxParm.Controls.Add(this.lblContentGroup);
      this.groupBoxParm.Controls.Add(this.lblComposer);
      this.groupBoxParm.Controls.Add(this.lblConductor);
      this.groupBoxParm.Controls.Add(this.lblParmBitRate);
      this.groupBoxParm.Controls.Add(this.lblParmComment);
      this.groupBoxParm.Controls.Add(this.lblAlbumArtist);
      this.groupBoxParm.Controls.Add(this.lblParmGenre);
      this.groupBoxParm.Controls.Add(this.lblParmDiscTotal);
      this.groupBoxParm.Controls.Add(this.lblParmDisc);
      this.groupBoxParm.Controls.Add(this.lblParmTrackTotal);
      this.groupBoxParm.Controls.Add(this.lblParmTrack);
      this.groupBoxParm.Controls.Add(this.lblParmYear);
      this.groupBoxParm.Controls.Add(this.lblParmAlbum);
      this.groupBoxParm.Controls.Add(this.lblParmTitle);
      this.groupBoxParm.Controls.Add(this.lblParmArtist);
      this.groupBoxParm.Id = "acb6a2a7-0ef5-486f-be04-56755b94b2fd";
      this.groupBoxParm.Localisation = "groupBoxParm";
      this.groupBoxParm.LocalisationContext = "TagAndRename";
      this.groupBoxParm.Location = new System.Drawing.Point(14, 16);
      this.groupBoxParm.Name = "groupBoxParm";
      this.groupBoxParm.Size = new System.Drawing.Size(824, 182);
      this.groupBoxParm.TabIndex = 22;
      this.groupBoxParm.Text = "Parameters (Click to add to the list)";
      // 
      // lblParmFolder
      // 
      this.lblParmFolder.Localisation = "Folder";
      this.lblParmFolder.LocalisationContext = "TagAndRename";
      this.lblParmFolder.Location = new System.Drawing.Point(11, 160);
      this.lblParmFolder.Name = "lblParmFolder";
      this.lblParmFolder.Size = new System.Drawing.Size(391, 13);
      this.lblParmFolder.TabIndex = 21;
      this.lblParmFolder.Text =
        "\\ = Folder: to specify that parameters in front to be used as subfoldername within target folder";
      this.lblParmFolder.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmFirstAlbumArtist
      // 
      this.lblParmFirstAlbumArtist.Localisation = "FirstNofAlbumArtist";
      this.lblParmFirstAlbumArtist.LocalisationContext = "TagAndRename";
      this.lblParmFirstAlbumArtist.Location = new System.Drawing.Point(318, 137);
      this.lblParmFirstAlbumArtist.Name = "lblParmFirstAlbumArtist";
      this.lblParmFirstAlbumArtist.Size = new System.Drawing.Size(206, 13);
      this.lblParmFirstAlbumArtist.TabIndex = 20;
      this.lblParmFirstAlbumArtist.Text = "<O:n> = First \"n\" characters of AlbumArtist";
      this.lblParmFirstAlbumArtist.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmFirstArtist
      // 
      this.lblParmFirstArtist.Localisation = "FirstNofArtist";
      this.lblParmFirstArtist.LocalisationContext = "TagAndRename";
      this.lblParmFirstArtist.Location = new System.Drawing.Point(6, 137);
      this.lblParmFirstArtist.Name = "lblParmFirstArtist";
      this.lblParmFirstArtist.Size = new System.Drawing.Size(176, 13);
      this.lblParmFirstArtist.TabIndex = 19;
      this.lblParmFirstArtist.Text = "<A:n> = First \"n\" characters of Artist";
      this.lblParmFirstArtist.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblModifiedBy
      // 
      this.lblModifiedBy.Localisation = "ModifiedBy";
      this.lblModifiedBy.LocalisationContext = "TagAndRename";
      this.lblModifiedBy.Location = new System.Drawing.Point(6, 117);
      this.lblModifiedBy.Name = "lblModifiedBy";
      this.lblModifiedBy.Size = new System.Drawing.Size(141, 13);
      this.lblModifiedBy.TabIndex = 18;
      this.lblModifiedBy.Text = "<M> = Modified / remixed by";
      this.lblModifiedBy.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblBPM
      // 
      this.lblBPM.Localisation = "BPM";
      this.lblBPM.LocalisationContext = "TagAndRename";
      this.lblBPM.Location = new System.Drawing.Point(318, 117);
      this.lblBPM.Name = "lblBPM";
      this.lblBPM.Size = new System.Drawing.Size(61, 13);
      this.lblBPM.TabIndex = 17;
      this.lblBPM.Text = "<E> = BPM";
      this.lblBPM.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblSubTitle
      // 
      this.lblSubTitle.Localisation = "SubTitle";
      this.lblSubTitle.LocalisationContext = "TagAndRename";
      this.lblSubTitle.Location = new System.Drawing.Point(629, 97);
      this.lblSubTitle.Name = "lblSubTitle";
      this.lblSubTitle.Size = new System.Drawing.Size(77, 13);
      this.lblSubTitle.TabIndex = 16;
      this.lblSubTitle.Text = "<S> = SubTitle";
      this.lblSubTitle.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblContentGroup
      // 
      this.lblContentGroup.Localisation = "Group";
      this.lblContentGroup.LocalisationContext = "TagAndRename";
      this.lblContentGroup.Location = new System.Drawing.Point(629, 77);
      this.lblContentGroup.Name = "lblContentGroup";
      this.lblContentGroup.Size = new System.Drawing.Size(108, 13);
      this.lblContentGroup.TabIndex = 15;
      this.lblContentGroup.Text = "<U> = Content Group";
      this.lblContentGroup.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblComposer
      // 
      this.lblComposer.Localisation = "Composer";
      this.lblComposer.LocalisationContext = "TagAndRename";
      this.lblComposer.Location = new System.Drawing.Point(629, 57);
      this.lblComposer.Name = "lblComposer";
      this.lblComposer.Size = new System.Drawing.Size(86, 13);
      this.lblComposer.TabIndex = 14;
      this.lblComposer.Text = "<R> = Composer";
      this.lblComposer.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblConductor
      // 
      this.lblConductor.Localisation = "Conductor";
      this.lblConductor.LocalisationContext = "TagAndRename";
      this.lblConductor.Location = new System.Drawing.Point(318, 57);
      this.lblConductor.Name = "lblConductor";
      this.lblConductor.Size = new System.Drawing.Size(88, 13);
      this.lblConductor.TabIndex = 13;
      this.lblConductor.Text = "<N> = Conductor";
      this.lblConductor.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmBitRate
      // 
      this.lblParmBitRate.Localisation = "BitRate";
      this.lblParmBitRate.LocalisationContext = "TagAndRename";
      this.lblParmBitRate.Location = new System.Drawing.Point(629, 117);
      this.lblParmBitRate.Name = "lblParmBitRate";
      this.lblParmBitRate.Size = new System.Drawing.Size(64, 13);
      this.lblParmBitRate.TabIndex = 11;
      this.lblParmBitRate.Text = "<I> = Bitrate";
      this.lblParmBitRate.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmComment
      // 
      this.lblParmComment.Localisation = "Comment";
      this.lblParmComment.LocalisationContext = "TagAndRename";
      this.lblParmComment.Location = new System.Drawing.Point(629, 37);
      this.lblParmComment.Name = "lblParmComment";
      this.lblParmComment.Size = new System.Drawing.Size(82, 13);
      this.lblParmComment.TabIndex = 10;
      this.lblParmComment.Text = "<C> = Comment";
      this.lblParmComment.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblAlbumArtist
      // 
      this.lblAlbumArtist.Localisation = "AlbumArtist";
      this.lblAlbumArtist.LocalisationContext = "TagAndRename";
      this.lblAlbumArtist.Location = new System.Drawing.Point(6, 57);
      this.lblAlbumArtist.Name = "lblAlbumArtist";
      this.lblAlbumArtist.Size = new System.Drawing.Size(151, 13);
      this.lblAlbumArtist.TabIndex = 9;
      this.lblAlbumArtist.Text = "<O> = Orchestra / Album Artist";
      this.lblAlbumArtist.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmGenre
      // 
      this.lblParmGenre.Localisation = "Genre";
      this.lblParmGenre.LocalisationContext = "TagAndRename";
      this.lblParmGenre.Location = new System.Drawing.Point(318, 37);
      this.lblParmGenre.Name = "lblParmGenre";
      this.lblParmGenre.Size = new System.Drawing.Size(68, 13);
      this.lblParmGenre.TabIndex = 8;
      this.lblParmGenre.Text = "<G> = Genre";
      this.lblParmGenre.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmDiscTotal
      // 
      this.lblParmDiscTotal.Localisation = "DiscTotal";
      this.lblParmDiscTotal.LocalisationContext = "TagAndRename";
      this.lblParmDiscTotal.Location = new System.Drawing.Point(318, 97);
      this.lblParmDiscTotal.Name = "lblParmDiscTotal";
      this.lblParmDiscTotal.Size = new System.Drawing.Size(110, 13);
      this.lblParmDiscTotal.TabIndex = 7;
      this.lblParmDiscTotal.Text = "<d> = Total # of discs";
      this.lblParmDiscTotal.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmDisc
      // 
      this.lblParmDisc.Localisation = "Disc";
      this.lblParmDisc.LocalisationContext = "TagAndRename";
      this.lblParmDisc.Location = new System.Drawing.Point(6, 97);
      this.lblParmDisc.Name = "lblParmDisc";
      this.lblParmDisc.Size = new System.Drawing.Size(100, 13);
      this.lblParmDisc.TabIndex = 6;
      this.lblParmDisc.Text = "<D> = Disc Number";
      this.lblParmDisc.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmTrackTotal
      // 
      this.lblParmTrackTotal.Localisation = "TrackTotal";
      this.lblParmTrackTotal.LocalisationContext = "TagAndRename";
      this.lblParmTrackTotal.Location = new System.Drawing.Point(318, 77);
      this.lblParmTrackTotal.Name = "lblParmTrackTotal";
      this.lblParmTrackTotal.Size = new System.Drawing.Size(115, 13);
      this.lblParmTrackTotal.TabIndex = 5;
      this.lblParmTrackTotal.Text = "<k> = Total # of tracks";
      this.lblParmTrackTotal.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmTrack
      // 
      this.lblParmTrack.Localisation = "Track";
      this.lblParmTrack.LocalisationContext = "TagAndRename";
      this.lblParmTrack.Location = new System.Drawing.Point(6, 77);
      this.lblParmTrack.Name = "lblParmTrack";
      this.lblParmTrack.Size = new System.Drawing.Size(106, 13);
      this.lblParmTrack.TabIndex = 4;
      this.lblParmTrack.Text = "<K> = Track Number";
      this.lblParmTrack.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmYear
      // 
      this.lblParmYear.Localisation = "Year";
      this.lblParmYear.LocalisationContext = "TagAndRename";
      this.lblParmYear.Location = new System.Drawing.Point(6, 37);
      this.lblParmYear.Name = "lblParmYear";
      this.lblParmYear.Size = new System.Drawing.Size(60, 13);
      this.lblParmYear.TabIndex = 3;
      this.lblParmYear.Text = "<Y> = Year";
      this.lblParmYear.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmAlbum
      // 
      this.lblParmAlbum.Localisation = "Album";
      this.lblParmAlbum.LocalisationContext = "TagAndRename";
      this.lblParmAlbum.Location = new System.Drawing.Point(629, 17);
      this.lblParmAlbum.Name = "lblParmAlbum";
      this.lblParmAlbum.Size = new System.Drawing.Size(67, 13);
      this.lblParmAlbum.TabIndex = 2;
      this.lblParmAlbum.Text = "<B> = Album";
      this.lblParmAlbum.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmTitle
      // 
      this.lblParmTitle.Localisation = "Title";
      this.lblParmTitle.LocalisationContext = "TagAndRename";
      this.lblParmTitle.Location = new System.Drawing.Point(318, 16);
      this.lblParmTitle.Name = "lblParmTitle";
      this.lblParmTitle.Size = new System.Drawing.Size(58, 13);
      this.lblParmTitle.TabIndex = 1;
      this.lblParmTitle.Text = "<T> = Title";
      this.lblParmTitle.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // lblParmArtist
      // 
      this.lblParmArtist.Localisation = "Artist";
      this.lblParmArtist.LocalisationContext = "TagAndRename";
      this.lblParmArtist.Location = new System.Drawing.Point(6, 17);
      this.lblParmArtist.Name = "lblParmArtist";
      this.lblParmArtist.Size = new System.Drawing.Size(61, 13);
      this.lblParmArtist.TabIndex = 0;
      this.lblParmArtist.Text = "<A> = Artist";
      this.lblParmArtist.Click += new System.EventHandler(this.lblParm_Click);
      // 
      // ckOverwriteFiles
      // 
      this.ckOverwriteFiles.AutoSize = true;
      this.ckOverwriteFiles.Checked = true;
      this.ckOverwriteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ckOverwriteFiles.Localisation = "OverwriteFiles";
      this.ckOverwriteFiles.LocalisationContext = "Organise";
      this.ckOverwriteFiles.Location = new System.Drawing.Point(9, 28);
      this.ckOverwriteFiles.Name = "ckOverwriteFiles";
      this.ckOverwriteFiles.Size = new System.Drawing.Size(130, 17);
      this.ckOverwriteFiles.TabIndex = 26;
      this.ckOverwriteFiles.Text = "Overwrite existing files";
      // 
      // ckCopyFiles
      // 
      this.ckCopyFiles.AutoSize = true;
      this.ckCopyFiles.Localisation = "CopyFiles";
      this.ckCopyFiles.LocalisationContext = "Organise";
      this.ckCopyFiles.Location = new System.Drawing.Point(9, 65);
      this.ckCopyFiles.Name = "ckCopyFiles";
      this.ckCopyFiles.Size = new System.Drawing.Size(183, 17);
      this.ckCopyFiles.TabIndex = 27;
      this.ckCopyFiles.Text = "Copy files instead of moving them";
      // 
      // ckCopyNonMusicFiles
      // 
      this.ckCopyNonMusicFiles.AutoSize = true;
      this.ckCopyNonMusicFiles.Localisation = "CopyNonMusicFiles";
      this.ckCopyNonMusicFiles.LocalisationContext = "Organise";
      this.ckCopyNonMusicFiles.Location = new System.Drawing.Point(321, 65);
      this.ckCopyNonMusicFiles.Name = "ckCopyNonMusicFiles";
      this.ckCopyNonMusicFiles.Size = new System.Drawing.Size(208, 17);
      this.ckCopyNonMusicFiles.TabIndex = 28;
      this.ckCopyNonMusicFiles.Text = "Include all files (Pictures, playlists, etc.)";
      // 
      // groupBoxOptions
      // 
      this.groupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxOptions.Controls.Add(this.cbScripts);
      this.groupBoxOptions.Controls.Add(this.ckOverwriteFiles);
      this.groupBoxOptions.Controls.Add(this.lblOverrideTargetRootDir);
      this.groupBoxOptions.Controls.Add(this.ckCopyNonMusicFiles);
      this.groupBoxOptions.Controls.Add(this.ckCopyFiles);
      this.groupBoxOptions.Id = "c909303a-6f6c-45dd-b766-0fab714f3139";
      this.groupBoxOptions.Localisation = "GroupBoxOptions";
      this.groupBoxOptions.LocalisationContext = "Organise";
      this.groupBoxOptions.Location = new System.Drawing.Point(14, 214);
      this.groupBoxOptions.Name = "groupBoxOptions";
      this.groupBoxOptions.Size = new System.Drawing.Size(824, 113);
      this.groupBoxOptions.TabIndex = 29;
      this.groupBoxOptions.Text = "Options";
      // 
      // cbScripts
      // 
      this.cbScripts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbScripts.FormattingEnabled = true;
      this.cbScripts.Location = new System.Drawing.Point(610, 26);
      this.cbScripts.Name = "cbScripts";
      this.cbScripts.Size = new System.Drawing.Size(157, 21);
      this.cbScripts.TabIndex = 36;
      // 
      // lblOverrideTargetRootDir
      // 
      this.lblOverrideTargetRootDir.Localisation = "TargetRootDrectoryOverride";
      this.lblOverrideTargetRootDir.LocalisationContext = "Organise";
      this.lblOverrideTargetRootDir.Location = new System.Drawing.Point(318, 32);
      this.lblOverrideTargetRootDir.Name = "lblOverrideTargetRootDir";
      this.lblOverrideTargetRootDir.Size = new System.Drawing.Size(213, 13);
      this.lblOverrideTargetRootDir.TabIndex = 35;
      this.lblOverrideTargetRootDir.Text = "Override Target Root Directory using Script:";
      // 
      // labelHeader
      // 
      this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelHeader.ForeColor = System.Drawing.Color.White;
      this.labelHeader.Localisation = "labelHeader";
      this.labelHeader.LocalisationContext = "ShapedForm";
      this.labelHeader.Location = new System.Drawing.Point(12, 13);
      this.labelHeader.Name = "labelHeader";
      this.labelHeader.Size = new System.Drawing.Size(62, 20);
      this.labelHeader.TabIndex = 30;
      this.labelHeader.Text = "Header";
      // 
      // groupBoxSelection
      // 
      this.groupBoxSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxSelection.Controls.Add(this.btReview);
      this.groupBoxSelection.Controls.Add(this.cbRootDir);
      this.groupBoxSelection.Controls.Add(this.buttonBrowseRootDir);
      this.groupBoxSelection.Controls.Add(this.lblTargetRootDrectory);
      this.groupBoxSelection.Controls.Add(this.btRemoveFormat);
      this.groupBoxSelection.Controls.Add(this.btAddFormat);
      this.groupBoxSelection.Controls.Add(this.cbFormat);
      this.groupBoxSelection.Controls.Add(this.lblFormat);
      this.groupBoxSelection.Id = "f65ee2a4-97f3-4da8-a46f-deffb1bcdd24";
      this.groupBoxSelection.Localisation = "GroupBoxSelection";
      this.groupBoxSelection.LocalisationContext = "Organise";
      this.groupBoxSelection.Location = new System.Drawing.Point(16, 45);
      this.groupBoxSelection.Name = "groupBoxSelection";
      this.groupBoxSelection.Size = new System.Drawing.Size(858, 115);
      this.groupBoxSelection.TabIndex = 31;
      this.groupBoxSelection.Text = "Selection";
      // 
      // btReview
      // 
      this.btReview.Id = "95fa18a4-9b7f-4ebe-a42f-1e582d581e34";
      this.btReview.Localisation = "Preview";
      this.btReview.LocalisationContext = "TagAndRename";
      this.btReview.Location = new System.Drawing.Point(551, 81);
      this.btReview.Name = "btReview";
      this.btReview.Size = new System.Drawing.Size(200, 23);
      this.btReview.TabIndex = 34;
      this.btReview.Text = "Preview Changes";
      this.btReview.UseVisualStyleBackColor = true;
      this.btReview.Click += new System.EventHandler(this.btReview_Click);
      // 
      // cbRootDir
      // 
      this.cbRootDir.FormattingEnabled = true;
      this.cbRootDir.Location = new System.Drawing.Point(133, 22);
      this.cbRootDir.Name = "cbRootDir";
      this.cbRootDir.Size = new System.Drawing.Size(544, 21);
      this.cbRootDir.TabIndex = 33;
      this.cbRootDir.SelectedIndexChanged += new System.EventHandler(this.cbRootDir_SelectedIndexChanged);
      this.cbRootDir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbRootDir_KeyDown);
      this.cbRootDir.Leave += new System.EventHandler(this.cbRootDir_Leave);
      // 
      // buttonBrowseRootDir
      // 
      this.buttonBrowseRootDir.Id = "e0ee169c-599e-4e59-a060-ec2621a6c491";
      this.buttonBrowseRootDir.Localisation = "BrowseRootDir";
      this.buttonBrowseRootDir.LocalisationContext = "TagAndRename";
      this.buttonBrowseRootDir.Location = new System.Drawing.Point(683, 22);
      this.buttonBrowseRootDir.Name = "buttonBrowseRootDir";
      this.buttonBrowseRootDir.Size = new System.Drawing.Size(68, 23);
      this.buttonBrowseRootDir.TabIndex = 32;
      this.buttonBrowseRootDir.Text = "Browse";
      this.buttonBrowseRootDir.UseVisualStyleBackColor = true;
      this.buttonBrowseRootDir.Click += new System.EventHandler(this.buttonBrowseRootDir_Click);
      // 
      // lblTargetRootDrectory
      // 
      this.lblTargetRootDrectory.Localisation = "TargetRootDrectory";
      this.lblTargetRootDrectory.LocalisationContext = "Organise";
      this.lblTargetRootDrectory.Location = new System.Drawing.Point(15, 22);
      this.lblTargetRootDrectory.Name = "lblTargetRootDrectory";
      this.lblTargetRootDrectory.Size = new System.Drawing.Size(112, 13);
      this.lblTargetRootDrectory.TabIndex = 30;
      this.lblTargetRootDrectory.Text = "Target Root Directory:";
      // 
      // btRemoveFormat
      // 
      this.btRemoveFormat.Id = "5a641d3f-238a-4f4e-b43b-370e751e28f1";
      this.btRemoveFormat.Localisation = "RemoveFormat";
      this.btRemoveFormat.LocalisationContext = "TagAndRename";
      this.btRemoveFormat.Location = new System.Drawing.Point(343, 81);
      this.btRemoveFormat.Name = "btRemoveFormat";
      this.btRemoveFormat.Size = new System.Drawing.Size(200, 23);
      this.btRemoveFormat.TabIndex = 28;
      this.btRemoveFormat.Text = "Remove Format From List";
      this.btRemoveFormat.UseVisualStyleBackColor = true;
      this.btRemoveFormat.Click += new System.EventHandler(this.btRemoveFormat_Click);
      // 
      // btAddFormat
      // 
      this.btAddFormat.Id = "69575510-993e-4c39-a2cd-72101e44d07c";
      this.btAddFormat.Localisation = "AddFormat";
      this.btAddFormat.LocalisationContext = "TagAndRename";
      this.btAddFormat.Location = new System.Drawing.Point(133, 81);
      this.btAddFormat.Name = "btAddFormat";
      this.btAddFormat.Size = new System.Drawing.Size(200, 23);
      this.btAddFormat.TabIndex = 27;
      this.btAddFormat.Text = "Add Format To List";
      this.btAddFormat.UseVisualStyleBackColor = true;
      this.btAddFormat.Click += new System.EventHandler(this.btAddFormat_Click);
      // 
      // cbFormat
      // 
      this.cbFormat.FormattingEnabled = true;
      this.cbFormat.Location = new System.Drawing.Point(133, 54);
      this.cbFormat.Name = "cbFormat";
      this.cbFormat.Size = new System.Drawing.Size(544, 21);
      this.cbFormat.TabIndex = 26;
      this.cbFormat.TextChanged += new System.EventHandler(this.cbFormat_TextChanged);
      this.cbFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFormat_Keypress);
      // 
      // lblFormat
      // 
      this.lblFormat.Localisation = "Format";
      this.lblFormat.LocalisationContext = "TagAndRename";
      this.lblFormat.Location = new System.Drawing.Point(15, 57);
      this.lblFormat.Name = "lblFormat";
      this.lblFormat.Size = new System.Drawing.Size(42, 13);
      this.lblFormat.TabIndex = 29;
      this.lblFormat.Text = "Format:";
      // 
      // tabControl1
      // 
      this.tabControl1.Location = new System.Drawing.Point(16, 173);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedTabPage = this.tabPageParameter;
      this.tabControl1.Size = new System.Drawing.Size(858, 361);
      this.tabControl1.TabIndex = 22;
      this.tabControl1.TabPages.AddRange(new Elegant.Ui.TabPage[] {
            this.tabPageParameter,
            this.tabPagePreview});
      this.tabControl1.Tag = "Preview";
      this.tabControl1.Text = "tabControl1";
      this.tabControl1.SelectedTabPageChanged += new Elegant.Ui.TabPageChangedEventHandler(this.tabControl1_SelectedTabPageChanged);
      // 
      // tabPageParameter
      // 
      this.tabPageParameter.ActiveControl = null;
      this.tabPageParameter.Controls.Add(this.groupBoxParm);
      this.tabPageParameter.Controls.Add(this.groupBoxOptions);
      this.tabPageParameter.KeyTip = null;
      this.tabPageParameter.Localisation = "Parameters";
      this.tabPageParameter.LocalisationContext = "TagAndRename";
      this.tabPageParameter.Name = "tabPageParameter";
      this.tabPageParameter.Size = new System.Drawing.Size(856, 340);
      this.tabPageParameter.TabIndex = 0;
      this.tabPageParameter.Tag = "Parameter";
      this.tabPageParameter.Text = "Parameters";
      // 
      // tabPagePreview
      // 
      this.tabPagePreview.ActiveControl = null;
      this.tabPagePreview.KeyTip = null;
      this.tabPagePreview.Localisation = "Preview";
      this.tabPagePreview.LocalisationContext = "TagAndRename";
      this.tabPagePreview.Name = "tabPagePreview";
      this.tabPagePreview.Size = new System.Drawing.Size(742, 225);
      this.tabPagePreview.TabIndex = 1;
      this.tabPagePreview.Text = "Preview";
      // 
      // mptPanel1
      // 
      this.mptPanel1.Controls.Add(this.tabControl1);
      this.mptPanel1.Controls.Add(this.btCancel);
      this.mptPanel1.Controls.Add(this.btApply);
      this.mptPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mptPanel1.Location = new System.Drawing.Point(0, 0);
      this.mptPanel1.Name = "mptPanel1";
      this.mptPanel1.Size = new System.Drawing.Size(894, 554);
      this.mptPanel1.TabIndex = 25;
      // 
      // OrganiseFiles
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.groupBoxSelection);
      this.Controls.Add(this.labelHeader);
      this.Controls.Add(this.mptPanel1);
      this.Name = "OrganiseFiles";
      this.Size = new System.Drawing.Size(894, 554);
      this.groupBoxParm.ResumeLayout(false);
      this.groupBoxParm.PerformLayout();
      this.groupBoxOptions.ResumeLayout(false);
      this.groupBoxOptions.PerformLayout();
      this.groupBoxSelection.ResumeLayout(false);
      this.groupBoxSelection.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
      this.tabPageParameter.ResumeLayout(false);
      this.mptPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MPTagThat.Core.WinControls.MPTButton btApply;
    private MPTagThat.Core.WinControls.MPTButton btCancel;
    private MPTagThat.Core.WinControls.MPTGroupBox groupBoxParm;
    private MPTagThat.Core.WinControls.MPTLabel lblModifiedBy;
    private MPTagThat.Core.WinControls.MPTLabel lblBPM;
    private MPTagThat.Core.WinControls.MPTLabel lblSubTitle;
    private MPTagThat.Core.WinControls.MPTLabel lblContentGroup;
    private MPTagThat.Core.WinControls.MPTLabel lblComposer;
    private MPTagThat.Core.WinControls.MPTLabel lblConductor;
    private MPTagThat.Core.WinControls.MPTLabel lblParmBitRate;
    private MPTagThat.Core.WinControls.MPTLabel lblParmComment;
    private MPTagThat.Core.WinControls.MPTLabel lblAlbumArtist;
    private MPTagThat.Core.WinControls.MPTLabel lblParmGenre;
    private MPTagThat.Core.WinControls.MPTLabel lblParmDiscTotal;
    private MPTagThat.Core.WinControls.MPTLabel lblParmDisc;
    private MPTagThat.Core.WinControls.MPTLabel lblParmTrackTotal;
    private MPTagThat.Core.WinControls.MPTLabel lblParmTrack;
    private MPTagThat.Core.WinControls.MPTLabel lblParmYear;
    private MPTagThat.Core.WinControls.MPTLabel lblParmAlbum;
    private MPTagThat.Core.WinControls.MPTLabel lblParmTitle;
    private MPTagThat.Core.WinControls.MPTLabel lblParmArtist;
    private MPTagThat.Core.WinControls.MPTLabel lblParmFirstArtist;
    private MPTagThat.Core.WinControls.MPTLabel lblParmFirstAlbumArtist;
    private MPTagThat.Core.WinControls.MPTLabel lblParmFolder;
    private MPTagThat.Core.WinControls.MPTCheckBox ckOverwriteFiles;
    private MPTagThat.Core.WinControls.MPTCheckBox ckCopyFiles;
    private MPTagThat.Core.WinControls.MPTCheckBox ckCopyNonMusicFiles;
    private MPTagThat.Core.WinControls.MPTGroupBox groupBoxOptions;
    private MPTagThat.Core.WinControls.MPTLabel labelHeader;
    private MPTagThat.Core.WinControls.MPTGroupBox groupBoxSelection;
    private MPTagThat.Core.WinControls.MPTButton buttonBrowseRootDir;
    private MPTagThat.Core.WinControls.MPTLabel lblTargetRootDrectory;
    private MPTagThat.Core.WinControls.MPTButton btRemoveFormat;
    private MPTagThat.Core.WinControls.MPTButton btAddFormat;
    private System.Windows.Forms.ComboBox cbFormat;
    private MPTagThat.Core.WinControls.MPTLabel lblFormat;
    private System.Windows.Forms.ComboBox cbRootDir;
    private MPTagThat.Core.WinControls.MPTButton btReview;
    private MPTagThat.Core.WinControls.MPTLabel lblOverrideTargetRootDir;
    private System.Windows.Forms.ComboBox cbScripts;
    private Elegant.Ui.TabControl tabControl1;
    private MPTagThat.Core.WinControls.MPTTabPage tabPageParameter;
    private MPTagThat.Core.WinControls.MPTTabPage tabPagePreview;
    private Core.WinControls.MPTPanel mptPanel1;
  }
}