using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using System.Threading;
using System.Globalization;

namespace Jiuyong
{
	public partial class RegexTesterForm : Form
	{
		bool contentChanged = false;
		ToolStripButton[] languageButtons = new ToolStripButton[3];

		public RegexTesterForm()
		{
			InitializeComponent();
			SetAnchor();
			//语言按钮数据初始化。
			toolStripButtonNative.Tag = CultureInfo.InstalledUICulture;
			toolStripButtonNative.Text = CultureInfo.InstalledUICulture.NativeName;

			var chinese = CultureInfo.GetCultureInfo("zh-Hans");
			toolStripButtonChinese.Tag = chinese;
			toolStripButtonChinese.Text = chinese.NativeName;

			languageButtons[0] = toolStripButtonNative;
			languageButtons[1] = toolStripButtonEnglish;
			languageButtons[2] = toolStripButtonChinese;

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private RegexOptions GetSelectedRegexOptions()
		{
			RegexOptions none = RegexOptions.None;
			if (this.IgnoreCaseChkBox.Checked)
			{
				none |= RegexOptions.IgnoreCase;
			}
			if (this.ExplicitCaptureChkBox.Checked)
			{
				none |= RegexOptions.ExplicitCapture;
			}
			if (this.ECMAScriptChkBox.Checked)
			{
				none |= RegexOptions.ECMAScript;
			}
			if (this.IgnorePatternWhitespaceChkBox.Checked)
			{
				none |= RegexOptions.IgnorePatternWhitespace;
			}
			if (this.MultiLineChkBox.Checked)
			{
				none |= RegexOptions.Multiline;
			}
			if (this.RightToLeftChkBox.Checked)
			{
				none |= RegexOptions.RightToLeft;
			}
			if (this.SingleLineChkBox.Checked)
			{
				none |= RegexOptions.Singleline;
			}
			return none;
		}

		private void MatchesButton_Click(object sender, EventArgs e)
		{
			try
			{
				RegexOptions selectedRegexOptions = this.GetSelectedRegexOptions();
				MatchCollection matchs = new Regex(this.RegexTextBox.Text, selectedRegexOptions).Matches(this.InputTextBox.Text);
				string str = NextMatchLabel.Text + Environment.NewLine;
				StringBuilder builder = new StringBuilder(0x40);
				foreach (Match match in matchs)
				{
					builder.Append(match.Value + Environment.NewLine + str);
				}

				ShowMatch(null);

				this.ResultsTextBox.ForeColor = Color.Black;
				this.ResultsTextBox.Text = builder.ToString();
			}
			catch (ArgumentException exception)
			{
				this.ResultsTextBox.ForeColor = Color.Red;
				this.ResultsTextBox.Text = "There was an error in your regular expressions:\r\n" + exception.Message;
			}
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			StreamReader reader = File.OpenText(this.openFileDialog.FileName);
			this.RegexTextBox.Text = reader.ReadToEnd();
			reader.Close();
		}

		private void OpenRegexButton_Click(object sender, EventArgs e)
		{
			this.openFileDialog.ShowDialog();
		}

		private void ReplaceButton_Click(object sender, EventArgs e)
		{
			try
			{
				RegexOptions selectedRegexOptions = this.GetSelectedRegexOptions();
				Regex regex = new Regex(this.RegexTextBox.Text, selectedRegexOptions);

				ShowMatch(null);

				this.ResultsTextBox.ForeColor = Color.Black;
				this.ResultsTextBox.Text = regex.Replace(this.InputTextBox.Text, this.ReplacementTextBox.Text);
			}
			catch (ArgumentException exception)
			{
				this.ResultsTextBox.ForeColor = Color.Red;
				this.ResultsTextBox.Text = "There was an error in your regular expression:" + Environment.NewLine + exception.Message;
			}
		}

		private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			StreamWriter writer = File.CreateText(this.saveFileDialog.FileName);
			writer.Write(this.RegexTextBox.Text);
			writer.Close();
		}

		private void SaveRegexButton_Click(object sender, EventArgs e)
		{
			this.saveFileDialog.ShowDialog();
		}

		private void SplitButton_Click(object sender, EventArgs e)
		{
			try
			{
				RegexOptions selectedRegexOptions = this.GetSelectedRegexOptions();
				string[] strArray = new Regex(this.RegexTextBox.Text, selectedRegexOptions).Split(this.InputTextBox.Text);
				StringBuilder builder = new StringBuilder(this.InputTextBox.Text.Length);
				foreach (string str in strArray)
				{
					builder.Append(str + Environment.NewLine);
				}
				ShowMatch(null);
				this.ResultsTextBox.ForeColor = Color.Black;
				this.ResultsTextBox.Text = builder.ToString();
			}
			catch (ArgumentException exception)
			{
				this.ResultsTextBox.ForeColor = Color.Red;
				this.ResultsTextBox.Text = "There was an error in your regular expression:" + Environment.NewLine + exception.Message;
			}
		}

		private void TestRegexButton_Click(object sender, EventArgs e)
		{
			try
			{
				RegexOptions selectedRegexOptions = this.GetSelectedRegexOptions();
				Regex regex = new Regex(this.RegexTextBox.Text, selectedRegexOptions);
				if (regex.IsMatch(this.InputTextBox.Text))
				{
					//this.ResultsTextBox.Text = "MATCH FOUND";
					//this.ResultsTextBox.ForeColor = Color.Black;
					ShowMatch(true);
				}
				else
				{
					//this.ResultsTextBox.Text = "NO MATCH FOUND";
					//this.ResultsTextBox.ForeColor = Color.Red;
					ShowMatch(false);
				}
			}
			catch (ArgumentException exception)
			{
				this.ResultsTextBox.ForeColor = Color.Red;
				this.ResultsTextBox.Text = "There was an error in your regular expression:" + Environment.NewLine + exception.Message;
			}
		}

		private void ShowMatch(bool? matchFound)
		{
			if (null == matchFound)
			{
				NextMatchLabel.Visible = false;
				MatchFoundLabel.Visible = false;
				NoMatchFoundLabel.Visible = false;
			}
			else
			{
				if (matchFound.Value)
				{
					MatchFoundLabel.Visible = true;
					NoMatchFoundLabel.Visible = false;
				}
				else
				{
					MatchFoundLabel.Visible = false;
					NoMatchFoundLabel.Visible = true;
				}
			}
		}

		private void buttonSaveSetting_Click(object sender, EventArgs e)
		{
			SaveContent();
		}

		private void ContentTextBox_TextChanged(object sender, EventArgs e)
		{
			textBox = sender as RichTextBox;
			if (textBox != null)
			{
				onContentChanged();
				CheckEditerCanDo();
			}
		}

		const string contentChangedTag = " *";
		private void SaveContent()
		{

			if (contentChanged && this.Text.EndsWith(contentChangedTag))
			{
				this.Text = this.Text.Substring(0, this.Text.Length - 2);
				Jiuyong.Properties.Settings.Default.Save();
			}
			contentChanged = false;
		}

		private void onContentChanged()
		{
			if (!contentChanged)
			{
				contentChanged = true;
				this.Text += contentChangedTag;
			}
		}

		private void Form_Load(object sender, EventArgs e)
		{
			//this.InputTextBox.TextChanged += new System.EventHandler(this.ContentTextBox_TextChanged);
			//this.RegexTextBox.TextChanged += new System.EventHandler(this.ContentTextBox_TextChanged);
			//this.ReplacementTextBox.TextChanged += new System.EventHandler(this.ContentTextBox_TextChanged);
			textBox = this.ActiveControl as RichTextBox;

			//SetAnchor();

			ShowMatch(null);
		}

		private void SetAnchor()
		{
			//自动适合窗体大小更改。
			OptionsGroup.Anchor =
				RegexTextBox.Anchor =
				ReplacementTextBox.Anchor =
				InputTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;//靠上边
			ResultsTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;//填充

			TestRegexButton.Anchor
				= ReplaceButton.Anchor
				= MatchesButton.Anchor
				= SplitButton.Anchor
				= AnchorStyles.Left | AnchorStyles.Bottom;//左下角

			buttonExit.Anchor
				= AnchorStyles.Right | AnchorStyles.Bottom;//右下角
		}

		private void LockToolStripButton_Click(object sender, EventArgs e)
		{
			if (LockToolStripButton.Checked)
			{
				toolStripApplication.GripStyle = ToolStripGripStyle.Hidden;
			}
			else
			{
				toolStripApplication.GripStyle = ToolStripGripStyle.Visible;
			}
		}

		RichTextBox textBox = null;
		private void undoToolStripButton_Click(object sender, EventArgs e)
		{
			if (textBox != null && textBox.ReadOnly == false)
			{
				textBox.Undo();
			}
		}

		private void redoToolStripButton_Click(object sender, EventArgs e)
		{
			if (textBox != null && textBox.ReadOnly == false)
			{
				textBox.Redo();
			}
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			textBox = sender as RichTextBox;
			if (textBox != null)
			{
				textBox.TextChanged += ContentTextBox_TextChanged;
				CheckEditerCanDo();
			}
		}

		private void CheckEditerCanDo()
		{
			undoToolStripButton.Enabled = textBox.CanUndo;
			redoToolStripButton.Enabled = textBox.CanRedo;
		}

		private void Form_Closing(object sender, FormClosingEventArgs e)
		{
			if (contentChanged)
			{
				DialogResult dr = MessageBox.Show("内容已发生更改，是否保存？", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

				switch (dr)
				{
					case DialogResult.Abort:
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
					case DialogResult.Ignore:
						break;
					case DialogResult.No:
						return;
					//break;
					case DialogResult.None:
						break;
					case DialogResult.OK:
						break;
					case DialogResult.Retry:
						break;
					case DialogResult.Yes:
						SaveContent();
						break;
					default:
						break;
				}
			}
		}

		private void TextBox_Leave(object sender, EventArgs e)
		{
			if (textBox != null)
			{
				textBox.TextChanged -= ContentTextBox_TextChanged;
			}
		}

		private void toolStripButtonLanguage_Click(object sender, EventArgs e)
		{
			ToolStripButton tsb = sender as ToolStripButton;
			if (tsb != null && !tsb.Checked)
			{
				CultureInfo lan = tsb.Tag as CultureInfo;
				if (lan == null)
					lan = CultureInfo.InvariantCulture;
				this.WindowState = FormWindowState.Normal;
				Core.SetLanguage(this, lan);
				foreach (var btn in languageButtons)
				{
					if (tsb == btn)
					{
						btn.Checked = true;
					}
					else
					{
						btn.Checked = false;
					}
				}
				//SetAnchor();
			}
		}
	}
}
