namespace Regex_Prime_Numbers
{
    partial class RPN
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPN));
            tscToolsContainer = new ToolStripContainer();
            ssStatus = new StatusStrip();
            slStatus = new ToolStripStatusLabel();
            fctbPrimes = new FastColoredTextBoxNS.FastColoredTextBox();
            fctbOnes = new FastColoredTextBoxNS.FastColoredTextBox();
            fctbNumbers = new FastColoredTextBoxNS.FastColoredTextBox();
            lblEnd = new Label();
            lblStart = new Label();
            nudEnd = new NumericUpDown();
            nudStart = new NumericUpDown();
            msMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            miArticle = new ToolStripMenuItem();
            miVideo = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tsTools = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            mlRegex = new ToolStripLabel();
            txtRegex = new ToolStripTextBox();
            tsbStart = new ToolStripButton();
            tsbStop = new ToolStripButton();
            tmrNumberUpdateTimer = new System.Windows.Forms.Timer(components);
            tscToolsContainer.BottomToolStripPanel.SuspendLayout();
            tscToolsContainer.ContentPanel.SuspendLayout();
            tscToolsContainer.TopToolStripPanel.SuspendLayout();
            tscToolsContainer.SuspendLayout();
            ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fctbPrimes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fctbOnes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fctbNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStart).BeginInit();
            msMenu.SuspendLayout();
            tsTools.SuspendLayout();
            SuspendLayout();
            // 
            // tscToolsContainer
            // 
            // 
            // tscToolsContainer.BottomToolStripPanel
            // 
            tscToolsContainer.BottomToolStripPanel.Controls.Add(ssStatus);
            // 
            // tscToolsContainer.ContentPanel
            // 
            tscToolsContainer.ContentPanel.Controls.Add(fctbPrimes);
            tscToolsContainer.ContentPanel.Controls.Add(fctbOnes);
            tscToolsContainer.ContentPanel.Controls.Add(fctbNumbers);
            tscToolsContainer.ContentPanel.Controls.Add(lblEnd);
            tscToolsContainer.ContentPanel.Controls.Add(lblStart);
            tscToolsContainer.ContentPanel.Controls.Add(nudEnd);
            tscToolsContainer.ContentPanel.Controls.Add(nudStart);
            tscToolsContainer.ContentPanel.Size = new Size(800, 379);
            tscToolsContainer.Dock = DockStyle.Fill;
            tscToolsContainer.Location = new Point(0, 0);
            tscToolsContainer.Name = "tscToolsContainer";
            tscToolsContainer.Size = new Size(800, 450);
            tscToolsContainer.TabIndex = 0;
            tscToolsContainer.Text = "toolStripContainer1";
            // 
            // tscToolsContainer.TopToolStripPanel
            // 
            tscToolsContainer.TopToolStripPanel.Controls.Add(msMenu);
            tscToolsContainer.TopToolStripPanel.Controls.Add(tsTools);
            // 
            // ssStatus
            // 
            ssStatus.Dock = DockStyle.None;
            ssStatus.Items.AddRange(new ToolStripItem[] { slStatus });
            ssStatus.Location = new Point(0, 0);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(800, 22);
            ssStatus.TabIndex = 0;
            // 
            // slStatus
            // 
            slStatus.Name = "slStatus";
            slStatus.Size = new Size(39, 17);
            slStatus.Text = "Ready";
            // 
            // fctbPrimes
            // 
            fctbPrimes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            fctbPrimes.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            fctbPrimes.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            fctbPrimes.AutoScrollMinSize = new Size(27, 14);
            fctbPrimes.BackBrush = null;
            fctbPrimes.CharHeight = 14;
            fctbPrimes.CharWidth = 8;
            fctbPrimes.DefaultMarkerSize = 8;
            fctbPrimes.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctbPrimes.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fctbPrimes.IsReplaceMode = false;
            fctbPrimes.Location = new Point(609, 68);
            fctbPrimes.Name = "fctbPrimes";
            fctbPrimes.Paddings = new Padding(0);
            fctbPrimes.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fctbPrimes.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctbPrimes.ServiceColors");
            fctbPrimes.ShowFoldingLines = true;
            fctbPrimes.Size = new Size(179, 286);
            fctbPrimes.TabIndex = 6;
            fctbPrimes.TabLength = 2;
            fctbPrimes.TextAreaBorder = FastColoredTextBoxNS.TextAreaBorderType.Single;
            fctbPrimes.Zoom = 100;
            // 
            // fctbOnes
            // 
            fctbOnes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fctbOnes.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            fctbOnes.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            fctbOnes.AutoScrollMinSize = new Size(27, 14);
            fctbOnes.BackBrush = null;
            fctbOnes.CharHeight = 14;
            fctbOnes.CharWidth = 8;
            fctbOnes.DefaultMarkerSize = 8;
            fctbOnes.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctbOnes.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fctbOnes.IsReplaceMode = false;
            fctbOnes.Location = new Point(197, 68);
            fctbOnes.Name = "fctbOnes";
            fctbOnes.Paddings = new Padding(0);
            fctbOnes.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fctbOnes.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctbOnes.ServiceColors");
            fctbOnes.ShowFoldingLines = true;
            fctbOnes.Size = new Size(406, 286);
            fctbOnes.TabIndex = 5;
            fctbOnes.TabLength = 2;
            fctbOnes.TextAreaBorder = FastColoredTextBoxNS.TextAreaBorderType.Single;
            fctbOnes.Zoom = 100;
            // 
            // fctbNumbers
            // 
            fctbNumbers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            fctbNumbers.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            fctbNumbers.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            fctbNumbers.AutoScrollMinSize = new Size(27, 14);
            fctbNumbers.BackBrush = null;
            fctbNumbers.CharHeight = 14;
            fctbNumbers.CharWidth = 8;
            fctbNumbers.DefaultMarkerSize = 8;
            fctbNumbers.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctbNumbers.IsReplaceMode = false;
            fctbNumbers.Location = new Point(12, 68);
            fctbNumbers.Name = "fctbNumbers";
            fctbNumbers.Paddings = new Padding(0);
            fctbNumbers.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fctbNumbers.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctbNumbers.ServiceColors");
            fctbNumbers.ShowFoldingLines = true;
            fctbNumbers.Size = new Size(179, 286);
            fctbNumbers.TabIndex = 4;
            fctbNumbers.TabLength = 2;
            fctbNumbers.TextAreaBorder = FastColoredTextBoxNS.TextAreaBorderType.Single;
            fctbNumbers.Zoom = 100;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(12, 41);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(37, 15);
            lblEnd.TabIndex = 3;
            lblEnd.Text = "End #";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(12, 12);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(41, 15);
            lblStart.TabIndex = 2;
            lblStart.Text = "Start #";
            // 
            // nudEnd
            // 
            nudEnd.Location = new Point(71, 39);
            nudEnd.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudEnd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudEnd.Name = "nudEnd";
            nudEnd.Size = new Size(120, 23);
            nudEnd.TabIndex = 1;
            nudEnd.TextAlign = HorizontalAlignment.Right;
            nudEnd.ThousandsSeparator = true;
            nudEnd.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudEnd.ValueChanged += nudEnd_ValueChanged;
            // 
            // nudStart
            // 
            nudStart.Location = new Point(71, 10);
            nudStart.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudStart.Name = "nudStart";
            nudStart.Size = new Size(120, 23);
            nudStart.TabIndex = 0;
            nudStart.TextAlign = HorizontalAlignment.Right;
            nudStart.ThousandsSeparator = true;
            nudStart.ValueChanged += nudStart_ValueChanged;
            // 
            // msMenu
            // 
            msMenu.Dock = DockStyle.None;
            msMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(800, 24);
            msMenu.TabIndex = 0;
            msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(180, 22);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(180, 22);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(144, 22);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(144, 22);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(144, 22);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(144, 22);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(144, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(144, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(130, 22);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(130, 22);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miArticle, miVideo, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // miArticle
            // 
            miArticle.Name = "miArticle";
            miArticle.Size = new Size(170, 22);
            miArticle.Text = "&Article";
            miArticle.Click += miArticle_Click;
            // 
            // miVideo
            // 
            miVideo.Name = "miVideo";
            miVideo.Size = new Size(170, 22);
            miVideo.Text = "&Video on YouTube";
            miVideo.Click += miVideo_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(167, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(170, 22);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // tsTools
            // 
            tsTools.Dock = DockStyle.None;
            tsTools.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, printToolStripButton, toolStripSeparator6, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator7, helpToolStripButton, mlRegex, txtRegex, tsbStart, tsbStop });
            tsTools.Location = new Point(3, 24);
            tsTools.Name = "tsTools";
            tsTools.Size = new Size(501, 25);
            tsTools.TabIndex = 1;
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += newToolStripButton_Click;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "&Save";
            saveToolStripButton.Click += saveToolStripButton_Click;
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(23, 22);
            printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = (Image)resources.GetObject("cutToolStripButton.Image");
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(23, 22);
            cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(23, 22);
            copyToolStripButton.Text = "&Copy";
            copyToolStripButton.Click += copyToolStripButton_Click;
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = (Image)resources.GetObject("pasteToolStripButton.Image");
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(23, 22);
            pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "He&lp";
            helpToolStripButton.Click += helpToolStripButton_Click;
            // 
            // mlRegex
            // 
            mlRegex.Name = "mlRegex";
            mlRegex.Size = new Size(39, 22);
            mlRegex.Text = "Regex";
            // 
            // txtRegex
            // 
            txtRegex.AutoSize = false;
            txtRegex.Name = "txtRegex";
            txtRegex.ReadOnly = true;
            txtRegex.Size = new Size(150, 25);
            txtRegex.Text = "/^1?$|^(11+?)\\1+$/";
            txtRegex.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // tsbStart
            // 
            tsbStart.Image = Properties.Resources.RO_Mx1_24_circle_white_arrow_green;
            tsbStart.ImageTransparentColor = Color.Magenta;
            tsbStart.Name = "tsbStart";
            tsbStart.Size = new Size(51, 22);
            tsbStart.Text = "Start";
            tsbStart.Click += tsbStart_Click;
            // 
            // tsbStop
            // 
            tsbStop.Image = Properties.Resources.RO_Mx1_24_circle_red_cancel;
            tsbStop.ImageTransparentColor = Color.Magenta;
            tsbStop.Name = "tsbStop";
            tsbStop.Size = new Size(51, 22);
            tsbStop.Text = "Stop";
            tsbStop.Click += tsbStop_Click;
            // 
            // tmrNumberUpdateTimer
            // 
            tmrNumberUpdateTimer.Interval = 1000;
            // 
            // RPN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tscToolsContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msMenu;
            Name = "RPN";
            Text = "Regex Prime Numbers";
            Load += RPN_Load;
            tscToolsContainer.BottomToolStripPanel.ResumeLayout(false);
            tscToolsContainer.BottomToolStripPanel.PerformLayout();
            tscToolsContainer.ContentPanel.ResumeLayout(false);
            tscToolsContainer.ContentPanel.PerformLayout();
            tscToolsContainer.TopToolStripPanel.ResumeLayout(false);
            tscToolsContainer.TopToolStripPanel.PerformLayout();
            tscToolsContainer.ResumeLayout(false);
            tscToolsContainer.PerformLayout();
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fctbPrimes).EndInit();
            ((System.ComponentModel.ISupportInitialize)fctbOnes).EndInit();
            ((System.ComponentModel.ISupportInitialize)fctbNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStart).EndInit();
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            tsTools.ResumeLayout(false);
            tsTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tscToolsContainer;
        private MenuStrip msMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem miArticle;
        private ToolStripMenuItem miVideo;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip ssStatus;
        private ToolStripStatusLabel slStatus;
        private FastColoredTextBoxNS.FastColoredTextBox fctbOnes;
        private FastColoredTextBoxNS.FastColoredTextBox fctbNumbers;
        private Label lblEnd;
        private Label lblStart;
        private NumericUpDown nudEnd;
        private NumericUpDown nudStart;
        private ToolStrip tsTools;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton helpToolStripButton;
        private ToolStripLabel mlRegex;
        private ToolStripTextBox txtRegex;
        private System.Windows.Forms.Timer tmrNumberUpdateTimer;
        private FastColoredTextBoxNS.FastColoredTextBox fctbPrimes;
        private ToolStripButton tsbStart;
        private ToolStripButton tsbStop;
    }
}