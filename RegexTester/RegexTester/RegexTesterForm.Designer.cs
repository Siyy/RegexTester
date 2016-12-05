using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System;
namespace Jiuyong
{
	partial class RegexTesterForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexTesterForm));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.NextMatchLabel = new System.Windows.Forms.Label();
			this.MatchFoundLabel = new System.Windows.Forms.Label();
			this.RegexTextBox = new System.Windows.Forms.RichTextBox();
			this.buttonExit = new System.Windows.Forms.Button();
			this.MatchesButton = new System.Windows.Forms.Button();
			this.SplitButton = new System.Windows.Forms.Button();
			this.ReplaceButton = new System.Windows.Forms.Button();
			this.TestRegexButton = new System.Windows.Forms.Button();
			this.ResultsTextBox = new System.Windows.Forms.RichTextBox();
			this.OptionsGroup = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.ExplicitCaptureChkBox = new System.Windows.Forms.CheckBox();
			this.IgnorePatternWhitespaceChkBox = new System.Windows.Forms.CheckBox();
			this.IgnoreCaseChkBox = new System.Windows.Forms.CheckBox();
			this.SingleLineChkBox = new System.Windows.Forms.CheckBox();
			this.ECMAScriptChkBox = new System.Windows.Forms.CheckBox();
			this.MultiLineChkBox = new System.Windows.Forms.CheckBox();
			this.RightToLeftChkBox = new System.Windows.Forms.CheckBox();
			this.ReplacementTextBox = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.RegularExpressionLabel = new System.Windows.Forms.Label();
			this.InputTextBox = new System.Windows.Forms.RichTextBox();
			this.NoMatchFoundLabel = new System.Windows.Forms.Label();
			this.toolStripApplication = new System.Windows.Forms.ToolStrip();
			this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.SaveAllToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.redoToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.粘贴PToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.LockToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonEnglish = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonChinese = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonNative = new System.Windows.Forms.ToolStripButton();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.OptionsGroup.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.toolStripApplication.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
			this.toolStripContainer1.ContentPanel.Controls.Add(this.NextMatchLabel);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.MatchFoundLabel);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.RegexTextBox);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonExit);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.MatchesButton);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.SplitButton);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.ReplaceButton);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.TestRegexButton);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.ResultsTextBox);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.OptionsGroup);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.ReplacementTextBox);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.RegularExpressionLabel);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.InputTextBox);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.NoMatchFoundLabel);
			resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
			this.toolStripContainer1.Name = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripApplication);
			// 
			// NextMatchLabel
			// 
			resources.ApplyResources(this.NextMatchLabel, "NextMatchLabel");
			this.NextMatchLabel.BackColor = System.Drawing.Color.Transparent;
			this.NextMatchLabel.Name = "NextMatchLabel";
			// 
			// MatchFoundLabel
			// 
			resources.ApplyResources(this.MatchFoundLabel, "MatchFoundLabel");
			this.MatchFoundLabel.BackColor = System.Drawing.Color.Transparent;
			this.MatchFoundLabel.ForeColor = System.Drawing.Color.Green;
			this.MatchFoundLabel.Name = "MatchFoundLabel";
			// 
			// RegexTextBox
			// 
			this.RegexTextBox.AcceptsTab = true;
			this.RegexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Jiuyong.Properties.Settings.Default, "RegexText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.RegexTextBox.EnableAutoDragDrop = true;
			this.RegexTextBox.HideSelection = false;
			resources.ApplyResources(this.RegexTextBox, "RegexTextBox");
			this.RegexTextBox.Name = "RegexTextBox";
			this.RegexTextBox.Text = global::Jiuyong.Properties.Settings.Default.RegexText;
			this.RegexTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
			this.RegexTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// buttonExit
			// 
			resources.ApplyResources(this.buttonExit, "buttonExit");
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// MatchesButton
			// 
			resources.ApplyResources(this.MatchesButton, "MatchesButton");
			this.MatchesButton.Name = "MatchesButton";
			this.MatchesButton.Click += new System.EventHandler(this.MatchesButton_Click);
			// 
			// SplitButton
			// 
			resources.ApplyResources(this.SplitButton, "SplitButton");
			this.SplitButton.Name = "SplitButton";
			this.SplitButton.Click += new System.EventHandler(this.SplitButton_Click);
			// 
			// ReplaceButton
			// 
			resources.ApplyResources(this.ReplaceButton, "ReplaceButton");
			this.ReplaceButton.Name = "ReplaceButton";
			this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
			// 
			// TestRegexButton
			// 
			resources.ApplyResources(this.TestRegexButton, "TestRegexButton");
			this.TestRegexButton.Name = "TestRegexButton";
			this.TestRegexButton.Click += new System.EventHandler(this.TestRegexButton_Click);
			// 
			// ResultsTextBox
			// 
			this.ResultsTextBox.BackColor = System.Drawing.SystemColors.Window;
			resources.ApplyResources(this.ResultsTextBox, "ResultsTextBox");
			this.ResultsTextBox.Name = "ResultsTextBox";
			this.ResultsTextBox.ReadOnly = true;
			// 
			// OptionsGroup
			// 
			resources.ApplyResources(this.OptionsGroup, "OptionsGroup");
			this.OptionsGroup.Controls.Add(this.flowLayoutPanel1);
			this.OptionsGroup.Name = "OptionsGroup";
			this.OptionsGroup.TabStop = false;
			this.toolTip.SetToolTip(this.OptionsGroup, resources.GetString("OptionsGroup.ToolTip"));
			// 
			// flowLayoutPanel1
			// 
			resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
			this.flowLayoutPanel1.Controls.Add(this.ExplicitCaptureChkBox);
			this.flowLayoutPanel1.Controls.Add(this.IgnorePatternWhitespaceChkBox);
			this.flowLayoutPanel1.Controls.Add(this.IgnoreCaseChkBox);
			this.flowLayoutPanel1.Controls.Add(this.SingleLineChkBox);
			this.flowLayoutPanel1.Controls.Add(this.ECMAScriptChkBox);
			this.flowLayoutPanel1.Controls.Add(this.MultiLineChkBox);
			this.flowLayoutPanel1.Controls.Add(this.RightToLeftChkBox);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// ExplicitCaptureChkBox
			// 
			resources.ApplyResources(this.ExplicitCaptureChkBox, "ExplicitCaptureChkBox");
			this.ExplicitCaptureChkBox.Name = "ExplicitCaptureChkBox";
			this.toolTip.SetToolTip(this.ExplicitCaptureChkBox, resources.GetString("ExplicitCaptureChkBox.ToolTip"));
			// 
			// IgnorePatternWhitespaceChkBox
			// 
			resources.ApplyResources(this.IgnorePatternWhitespaceChkBox, "IgnorePatternWhitespaceChkBox");
			this.IgnorePatternWhitespaceChkBox.Name = "IgnorePatternWhitespaceChkBox";
			this.toolTip.SetToolTip(this.IgnorePatternWhitespaceChkBox, resources.GetString("IgnorePatternWhitespaceChkBox.ToolTip"));
			// 
			// IgnoreCaseChkBox
			// 
			resources.ApplyResources(this.IgnoreCaseChkBox, "IgnoreCaseChkBox");
			this.IgnoreCaseChkBox.Name = "IgnoreCaseChkBox";
			this.toolTip.SetToolTip(this.IgnoreCaseChkBox, resources.GetString("IgnoreCaseChkBox.ToolTip"));
			// 
			// SingleLineChkBox
			// 
			resources.ApplyResources(this.SingleLineChkBox, "SingleLineChkBox");
			this.SingleLineChkBox.Name = "SingleLineChkBox";
			this.toolTip.SetToolTip(this.SingleLineChkBox, resources.GetString("SingleLineChkBox.ToolTip"));
			// 
			// ECMAScriptChkBox
			// 
			resources.ApplyResources(this.ECMAScriptChkBox, "ECMAScriptChkBox");
			this.ECMAScriptChkBox.Name = "ECMAScriptChkBox";
			this.toolTip.SetToolTip(this.ECMAScriptChkBox, resources.GetString("ECMAScriptChkBox.ToolTip"));
			// 
			// MultiLineChkBox
			// 
			resources.ApplyResources(this.MultiLineChkBox, "MultiLineChkBox");
			this.MultiLineChkBox.Name = "MultiLineChkBox";
			this.toolTip.SetToolTip(this.MultiLineChkBox, resources.GetString("MultiLineChkBox.ToolTip"));
			// 
			// RightToLeftChkBox
			// 
			resources.ApplyResources(this.RightToLeftChkBox, "RightToLeftChkBox");
			this.RightToLeftChkBox.Name = "RightToLeftChkBox";
			this.toolTip.SetToolTip(this.RightToLeftChkBox, resources.GetString("RightToLeftChkBox.ToolTip"));
			// 
			// ReplacementTextBox
			// 
			this.ReplacementTextBox.AcceptsTab = true;
			this.ReplacementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Jiuyong.Properties.Settings.Default, "ReplacementText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.ReplacementTextBox.EnableAutoDragDrop = true;
			this.ReplacementTextBox.HideSelection = false;
			resources.ApplyResources(this.ReplacementTextBox, "ReplacementTextBox");
			this.ReplacementTextBox.Name = "ReplacementTextBox";
			this.ReplacementTextBox.Text = global::Jiuyong.Properties.Settings.Default.ReplacementText;
			this.ReplacementTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
			this.ReplacementTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// RegularExpressionLabel
			// 
			resources.ApplyResources(this.RegularExpressionLabel, "RegularExpressionLabel");
			this.RegularExpressionLabel.Name = "RegularExpressionLabel";
			// 
			// InputTextBox
			// 
			this.InputTextBox.AcceptsTab = true;
			this.InputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Jiuyong.Properties.Settings.Default, "InputText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.InputTextBox.EnableAutoDragDrop = true;
			this.InputTextBox.HideSelection = false;
			resources.ApplyResources(this.InputTextBox, "InputTextBox");
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Text = global::Jiuyong.Properties.Settings.Default.InputText;
			this.InputTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
			this.InputTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// NoMatchFoundLabel
			// 
			resources.ApplyResources(this.NoMatchFoundLabel, "NoMatchFoundLabel");
			this.NoMatchFoundLabel.BackColor = System.Drawing.Color.Transparent;
			this.NoMatchFoundLabel.ForeColor = System.Drawing.Color.Red;
			this.NoMatchFoundLabel.Name = "NoMatchFoundLabel";
			// 
			// toolStripApplication
			// 
			resources.ApplyResources(this.toolStripApplication, "toolStripApplication");
			this.toolStripApplication.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.SaveAllToolStripButton,
            this.PrintToolStripButton,
            this.toolStripSeparator2,
            this.undoToolStripButton,
            this.redoToolStripButton,
            this.toolStripSeparator,
            this.CutToolStripButton,
            this.CopyToolStripButton,
            this.粘贴PToolStripButton,
            this.toolStripSeparator1,
            this.HelpToolStripButton,
            this.LockToolStripButton,
            this.toolStripSeparator3,
            this.toolStripButtonEnglish,
            this.toolStripButtonChinese,
            this.toolStripButtonNative});
			this.toolStripApplication.Name = "toolStripApplication";
			// 
			// NewToolStripButton
			// 
			this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.NewToolStripButton, "NewToolStripButton");
			this.NewToolStripButton.Image = global::Jiuyong.Properties.Resources.新建NToolStripButton;
			this.NewToolStripButton.Name = "NewToolStripButton";
			this.NewToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			// 
			// OpenToolStripButton
			// 
			this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenToolStripButton.Image = global::Jiuyong.Properties.Resources.OpenToolStripButton;
			resources.ApplyResources(this.OpenToolStripButton, "OpenToolStripButton");
			this.OpenToolStripButton.Name = "OpenToolStripButton";
			this.OpenToolStripButton.Click += new System.EventHandler(this.OpenRegexButton_Click);
			// 
			// SaveToolStripButton
			// 
			this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveToolStripButton.Image = global::Jiuyong.Properties.Resources.SaveToolStripButton;
			resources.ApplyResources(this.SaveToolStripButton, "SaveToolStripButton");
			this.SaveToolStripButton.Name = "SaveToolStripButton";
			this.SaveToolStripButton.Click += new System.EventHandler(this.SaveRegexButton_Click);
			// 
			// SaveAllToolStripButton
			// 
			this.SaveAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveAllToolStripButton.Image = global::Jiuyong.Properties.Resources.SaveAllHS;
			resources.ApplyResources(this.SaveAllToolStripButton, "SaveAllToolStripButton");
			this.SaveAllToolStripButton.Name = "SaveAllToolStripButton";
			this.SaveAllToolStripButton.Click += new System.EventHandler(this.buttonSaveSetting_Click);
			// 
			// PrintToolStripButton
			// 
			this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.PrintToolStripButton, "PrintToolStripButton");
			this.PrintToolStripButton.Image = global::Jiuyong.Properties.Resources.打印PToolStripButton;
			this.PrintToolStripButton.Name = "PrintToolStripButton";
			this.PrintToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// undoToolStripButton
			// 
			this.undoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.undoToolStripButton.Image = global::Jiuyong.Properties.Resources.Edit_UndoHS;
			resources.ApplyResources(this.undoToolStripButton, "undoToolStripButton");
			this.undoToolStripButton.Name = "undoToolStripButton";
			this.undoToolStripButton.Click += new System.EventHandler(this.undoToolStripButton_Click);
			// 
			// redoToolStripButton
			// 
			this.redoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.redoToolStripButton.Image = global::Jiuyong.Properties.Resources.Edit_RedoHS;
			resources.ApplyResources(this.redoToolStripButton, "redoToolStripButton");
			this.redoToolStripButton.Name = "redoToolStripButton";
			this.redoToolStripButton.Click += new System.EventHandler(this.redoToolStripButton_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
			// 
			// CutToolStripButton
			// 
			this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.CutToolStripButton, "CutToolStripButton");
			this.CutToolStripButton.Image = global::Jiuyong.Properties.Resources.剪切UToolStripButton;
			this.CutToolStripButton.Name = "CutToolStripButton";
			this.CutToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			// 
			// CopyToolStripButton
			// 
			this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.CopyToolStripButton, "CopyToolStripButton");
			this.CopyToolStripButton.Image = global::Jiuyong.Properties.Resources.复制CToolStripButton;
			this.CopyToolStripButton.Name = "CopyToolStripButton";
			this.CopyToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			// 
			// 粘贴PToolStripButton
			// 
			this.粘贴PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.粘贴PToolStripButton, "粘贴PToolStripButton");
			this.粘贴PToolStripButton.Image = global::Jiuyong.Properties.Resources.粘贴PToolStripButton;
			this.粘贴PToolStripButton.Name = "粘贴PToolStripButton";
			this.粘贴PToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// HelpToolStripButton
			// 
			this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.HelpToolStripButton, "HelpToolStripButton");
			this.HelpToolStripButton.Image = global::Jiuyong.Properties.Resources.HelpToolStripButton;
			this.HelpToolStripButton.Name = "HelpToolStripButton";
			this.HelpToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			// 
			// LockToolStripButton
			// 
			this.LockToolStripButton.Checked = true;
			this.LockToolStripButton.CheckOnClick = true;
			this.LockToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.LockToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.LockToolStripButton.Image = global::Jiuyong.Properties.Resources.PushpinHS;
			resources.ApplyResources(this.LockToolStripButton, "LockToolStripButton");
			this.LockToolStripButton.Name = "LockToolStripButton";
			this.LockToolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
			this.LockToolStripButton.Click += new System.EventHandler(this.LockToolStripButton_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			// 
			// toolStripButtonEnglish
			// 
			this.toolStripButtonEnglish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			resources.ApplyResources(this.toolStripButtonEnglish, "toolStripButtonEnglish");
			this.toolStripButtonEnglish.Name = "toolStripButtonEnglish";
			this.toolStripButtonEnglish.Click += new System.EventHandler(this.toolStripButtonLanguage_Click);
			// 
			// toolStripButtonChinese
			// 
			this.toolStripButtonChinese.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonChinese.Name = "toolStripButtonChinese";
			resources.ApplyResources(this.toolStripButtonChinese, "toolStripButtonChinese");
			this.toolStripButtonChinese.Click += new System.EventHandler(this.toolStripButtonLanguage_Click);
			// 
			// toolStripButtonNative
			// 
			this.toolStripButtonNative.Checked = true;
			this.toolStripButtonNative.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButtonNative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonNative.Name = "toolStripButtonNative";
			resources.ApplyResources(this.toolStripButtonNative, "toolStripButtonNative");
			this.toolStripButtonNative.Click += new System.EventHandler(this.toolStripButtonLanguage_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.FileName = "doc1";
			this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
			// 
			// RegexTesterForm
			// 
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "RegexTesterForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
			this.Load += new System.EventHandler(this.Form_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.OptionsGroup.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.toolStripApplication.ResumeLayout(false);
			this.toolStripApplication.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		// Fields
		private Button buttonExit;
		private CheckBox ECMAScriptChkBox;
		private CheckBox ExplicitCaptureChkBox;
		private CheckBox IgnoreCaseChkBox;
		private CheckBox IgnorePatternWhitespaceChkBox;
		private RichTextBox InputTextBox;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button MatchesButton;
		private CheckBox MultiLineChkBox;
		private OpenFileDialog openFileDialog;
		private GroupBox OptionsGroup;
		private Label RegularExpressionLabel;
		private Button ReplaceButton;
		private RichTextBox ReplacementTextBox;
		private RichTextBox ResultsTextBox;
		private CheckBox RightToLeftChkBox;
		private SaveFileDialog saveFileDialog;
		private CheckBox SingleLineChkBox;
		private Button SplitButton;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button TestRegexButton;
		private RichTextBox RegexTextBox;
		private ToolTip toolTip;
		private ToolStrip toolStripApplication;
		private ToolStripButton NewToolStripButton;
		private ToolStripButton OpenToolStripButton;
		private ToolStripButton SaveToolStripButton;
		private ToolStripButton PrintToolStripButton;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripButton CutToolStripButton;
		private ToolStripButton CopyToolStripButton;
		private ToolStripButton 粘贴PToolStripButton;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton HelpToolStripButton;
		private ToolStripContainer toolStripContainer1;
		private ToolStripButton undoToolStripButton;
		private ToolStripButton redoToolStripButton;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton LockToolStripButton;
		private ToolStripButton SaveAllToolStripButton;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton toolStripButtonNative;
		private ToolStripButton toolStripButtonEnglish;
		private ToolStripButton toolStripButtonChinese;
        private Label NoMatchFoundLabel;
        private Label MatchFoundLabel;
		private Label NextMatchLabel;
	}
}

