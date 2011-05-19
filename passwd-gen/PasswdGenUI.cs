using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PasswdGen
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FormPassGen : System.Windows.Forms.Form
	{
		private PasswdGen pwdGen;
		private Point mouseOffset;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button btnGen;
		private System.Windows.Forms.CheckBox chkCon;
		private System.Windows.Forms.TextBox edtPass;
		private System.Windows.Forms.Button btnCopyClip;
		private System.Windows.Forms.CheckBox chkRepeat;
		private System.Windows.Forms.CheckBox chkSymbol;
		private System.Windows.Forms.CheckBox chkNum;
		private System.Windows.Forms.NumericUpDown numUpDownPass;
		private System.Windows.Forms.Label lblPassLen;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox picExit;
		private System.Windows.Forms.CheckBox chkUpperCase;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtExclude;
		private System.Windows.Forms.GroupBox groupBox1;

		public FormPassGen()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}



		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormPassGen));
			this.btnGen = new System.Windows.Forms.Button();
			this.chkCon = new System.Windows.Forms.CheckBox();
			this.edtPass = new System.Windows.Forms.TextBox();
			this.btnCopyClip = new System.Windows.Forms.Button();
			this.chkRepeat = new System.Windows.Forms.CheckBox();
			this.chkSymbol = new System.Windows.Forms.CheckBox();
			this.chkNum = new System.Windows.Forms.CheckBox();
			this.numUpDownPass = new System.Windows.Forms.NumericUpDown();
			this.lblPassLen = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.picExit = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkUpperCase = new System.Windows.Forms.CheckBox();
			this.edtExclude = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPass)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGen
			// 
			this.btnGen.BackColor = System.Drawing.Color.DimGray;
			this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnGen.Location = new System.Drawing.Point(192, 210);
			this.btnGen.Name = "btnGen";
			this.btnGen.TabIndex = 0;
			this.btnGen.Text = "Generate";
			this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
			// 
			// chkCon
			// 
			this.chkCon.BackColor = System.Drawing.Color.Transparent;
			this.chkCon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkCon.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkCon.Location = new System.Drawing.Point(153, 18);
			this.chkCon.Name = "chkCon";
			this.chkCon.Size = new System.Drawing.Size(160, 24);
			this.chkCon.TabIndex = 1;
			this.chkCon.Text = "Consecutive characters";
			// 
			// edtPass
			// 
			this.edtPass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.edtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.edtPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.edtPass.Location = new System.Drawing.Point(19, 171);
			this.edtPass.Name = "edtPass";
			this.edtPass.Size = new System.Drawing.Size(336, 23);
			this.edtPass.TabIndex = 2;
			this.edtPass.Text = "Click \"Generate\" to create pass";
			// 
			// btnCopyClip
			// 
			this.btnCopyClip.BackColor = System.Drawing.Color.DimGray;
			this.btnCopyClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopyClip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCopyClip.Location = new System.Drawing.Point(280, 210);
			this.btnCopyClip.Name = "btnCopyClip";
			this.btnCopyClip.TabIndex = 3;
			this.btnCopyClip.Text = "Copy";
			this.btnCopyClip.Click += new System.EventHandler(this.btnCopyClip_Click);
			// 
			// chkRepeat
			// 
			this.chkRepeat.BackColor = System.Drawing.Color.Transparent;
			this.chkRepeat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkRepeat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkRepeat.Location = new System.Drawing.Point(153, 42);
			this.chkRepeat.Name = "chkRepeat";
			this.chkRepeat.Size = new System.Drawing.Size(160, 24);
			this.chkRepeat.TabIndex = 4;
			this.chkRepeat.Text = "Repeating characters";
			// 
			// chkSymbol
			// 
			this.chkSymbol.BackColor = System.Drawing.Color.Transparent;
			this.chkSymbol.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkSymbol.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkSymbol.Location = new System.Drawing.Point(12, 18);
			this.chkSymbol.Name = "chkSymbol";
			this.chkSymbol.Size = new System.Drawing.Size(75, 24);
			this.chkSymbol.TabIndex = 5;
			this.chkSymbol.Text = "Symbols";
			// 
			// chkNum
			// 
			this.chkNum.BackColor = System.Drawing.Color.Transparent;
			this.chkNum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkNum.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkNum.Location = new System.Drawing.Point(12, 39);
			this.chkNum.Name = "chkNum";
			this.chkNum.Size = new System.Drawing.Size(75, 24);
			this.chkNum.TabIndex = 6;
			this.chkNum.Text = "Numbers";
			// 
			// numUpDownPass
			// 
			this.numUpDownPass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.numUpDownPass.Location = new System.Drawing.Point(12, 66);
			this.numUpDownPass.Maximum = new System.Decimal(new int[] {
																		  40,
																		  0,
																		  0,
																		  0});
			this.numUpDownPass.Minimum = new System.Decimal(new int[] {
																		  1,
																		  0,
																		  0,
																		  0});
			this.numUpDownPass.Name = "numUpDownPass";
			this.numUpDownPass.ReadOnly = true;
			this.numUpDownPass.Size = new System.Drawing.Size(48, 20);
			this.numUpDownPass.TabIndex = 7;
			this.numUpDownPass.Value = new System.Decimal(new int[] {
																		8,
																		0,
																		0,
																		0});
			// 
			// lblPassLen
			// 
			this.lblPassLen.BackColor = System.Drawing.Color.Transparent;
			this.lblPassLen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPassLen.Location = new System.Drawing.Point(60, 69);
			this.lblPassLen.Name = "lblPassLen";
			this.lblPassLen.Size = new System.Drawing.Size(78, 16);
			this.lblPassLen.TabIndex = 8;
			this.lblPassLen.Text = "Max Length";
			this.lblPassLen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(165, 18);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(175, 16);
			this.lblTitle.TabIndex = 9;
			this.lblTitle.Text = "- Password Generator v1.0.0 -";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picExit
			// 
			this.picExit.BackColor = System.Drawing.Color.Transparent;
			this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
			this.picExit.Location = new System.Drawing.Point(345, 0);
			this.picExit.Name = "picExit";
			this.picExit.Size = new System.Drawing.Size(25, 25);
			this.picExit.TabIndex = 10;
			this.picExit.TabStop = false;
			this.picExit.Click += new System.EventHandler(this.close);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.chkUpperCase);
			this.groupBox1.Controls.Add(this.chkSymbol);
			this.groupBox1.Controls.Add(this.chkNum);
			this.groupBox1.Controls.Add(this.numUpDownPass);
			this.groupBox1.Controls.Add(this.lblPassLen);
			this.groupBox1.Controls.Add(this.chkRepeat);
			this.groupBox1.Controls.Add(this.chkCon);
			this.groupBox1.Location = new System.Drawing.Point(19, 60);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(336, 96);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Include:";
			// 
			// chkUpperCase
			// 
			this.chkUpperCase.BackColor = System.Drawing.Color.Transparent;
			this.chkUpperCase.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkUpperCase.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkUpperCase.Location = new System.Drawing.Point(153, 66);
			this.chkUpperCase.Name = "chkUpperCase";
			this.chkUpperCase.Size = new System.Drawing.Size(113, 24);
			this.chkUpperCase.TabIndex = 7;
			this.chkUpperCase.Text = "UpperCase Text";
			// 
			// edtExclude
			// 
			this.edtExclude.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.edtExclude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.edtExclude.Location = new System.Drawing.Point(21, 222);
			this.edtExclude.Name = "edtExclude";
			this.edtExclude.Size = new System.Drawing.Size(113, 20);
			this.edtExclude.TabIndex = 12;
			this.edtExclude.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Exclude Chars:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormPassGen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(372, 252);
			this.Controls.Add(this.edtExclude);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.picExit);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnCopyClip);
			this.Controls.Add(this.edtPass);
			this.Controls.Add(this.btnGen);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPassGen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Passwd Generator v1.0.0";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
			this.Load += new System.EventHandler(this.PasswdGenUI_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.numUpDownPass)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormPassGen());
		}

        
		//mouse events to drag entire window when clicking canvas

		private void titleBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			mouseOffset = new Point(-e.X, -e.Y);
		}

		private void titleBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) 
			{
				Point mousePos = Control.MousePosition;
				mousePos.Offset(mouseOffset.X, mouseOffset.Y);
				Location = mousePos;
			}
		}

		private void close(object sender, System.EventArgs e)
		{
			Dispose(true);
			//FormPassGen.ActiveForm.Close();
		}
		
		private void PasswdGenUI_Load(object sender, System.EventArgs e)
		{
			pwdGen = new PasswdGen();
			this.chkNum.Checked = true;
			this.chkRepeat.Checked = true;
		}

		private void btnGen_Click(object sender, System.EventArgs e)
		{
			if ( null != pwdGen)
			{
				if ( ( null != this.edtExclude.Text ) || ( String.Empty != this.edtExclude.Text ) )
				{
					pwdGen.Exclusions = this.edtExclude.Text;
				}
				//pwdGen.Minimum = (int)this.numUpDownPass.Value;
				pwdGen.Maximum = (int)this.numUpDownPass.Value;
				pwdGen.ConsecutiveCharacters = this.chkCon.Checked;
				pwdGen.RepeatCharacters = this.chkRepeat.Checked;
				pwdGen.IncludeSymbols = this.chkSymbol.Checked;
				pwdGen.IncludeNumbers = this.chkNum.Checked;
				pwdGen.IncludeUpperCase = this.chkUpperCase.Checked;
				edtPass.Text = pwdGen.Generate();
			}
		}

		private void CopyObject(string format, object data)
		{
			IDataObject od = new DataObject();
			od.SetData(format, true, data);

			Clipboard.SetDataObject(od, true);
		}

		private void btnCopyClip_Click(object sender, System.EventArgs e)
		{
			CopyObject(DataFormats.Text, edtPass.Text);
		}
	}
}
