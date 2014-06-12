using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace prjCalculator
{
	partial class frmCalculator
	{

		#region "Upgrade Support "
		private static frmCalculator m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCalculator DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmCalculator();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		private string[] visualControls = new string[]{"components", "ToolTipMain", "_cmdCalc_22", "_cmdCalc_21", "_cmdCalc_20", "_cmdCalc_19", "_cmdCalc_18", "_cmdCalc_17", "_cmdCalc_16", "_cmdCalc_15", "_cmdCalc_14", "_cmdCalc_13", "_cmdCalc_12", "_cmdCalc_11", "_cmdCalc_10", "_cmdCalc_9", "_cmdCalc_8", "_cmdCalc_7", "_cmdCalc_6", "_cmdCalc_5", "_cmdCalc_4", "_cmdCalc_3", "_cmdCalc_2", "_cmdCalc_1", "_cmdCalc_0", "lblDisplay", "cmdCalc"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		private System.Windows.Forms.Button _cmdCalc_22;
		private System.Windows.Forms.Button _cmdCalc_21;
		private System.Windows.Forms.Button _cmdCalc_20;
		private System.Windows.Forms.Button _cmdCalc_19;
		private System.Windows.Forms.Button _cmdCalc_18;
		private System.Windows.Forms.Button _cmdCalc_17;
		private System.Windows.Forms.Button _cmdCalc_16;
		private System.Windows.Forms.Button _cmdCalc_15;
		private System.Windows.Forms.Button _cmdCalc_14;
		private System.Windows.Forms.Button _cmdCalc_13;
		private System.Windows.Forms.Button _cmdCalc_12;
		private System.Windows.Forms.Button _cmdCalc_11;
		private System.Windows.Forms.Button _cmdCalc_10;
		private System.Windows.Forms.Button _cmdCalc_9;
		private System.Windows.Forms.Button _cmdCalc_8;
		private System.Windows.Forms.Button _cmdCalc_7;
		private System.Windows.Forms.Button _cmdCalc_6;
		private System.Windows.Forms.Button _cmdCalc_5;
		private System.Windows.Forms.Button _cmdCalc_4;
		private System.Windows.Forms.Button _cmdCalc_3;
		private System.Windows.Forms.Button _cmdCalc_2;
		private System.Windows.Forms.Button _cmdCalc_1;
		private System.Windows.Forms.Button _cmdCalc_0;
		public System.Windows.Forms.Label lblDisplay;
		public System.Windows.Forms.Button[] cmdCalc = new System.Windows.Forms.Button[23];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this._cmdCalc_22 = new System.Windows.Forms.Button();
            this._cmdCalc_21 = new System.Windows.Forms.Button();
            this._cmdCalc_20 = new System.Windows.Forms.Button();
            this._cmdCalc_19 = new System.Windows.Forms.Button();
            this._cmdCalc_18 = new System.Windows.Forms.Button();
            this._cmdCalc_17 = new System.Windows.Forms.Button();
            this._cmdCalc_16 = new System.Windows.Forms.Button();
            this._cmdCalc_15 = new System.Windows.Forms.Button();
            this._cmdCalc_14 = new System.Windows.Forms.Button();
            this._cmdCalc_13 = new System.Windows.Forms.Button();
            this._cmdCalc_12 = new System.Windows.Forms.Button();
            this._cmdCalc_11 = new System.Windows.Forms.Button();
            this._cmdCalc_10 = new System.Windows.Forms.Button();
            this._cmdCalc_9 = new System.Windows.Forms.Button();
            this._cmdCalc_8 = new System.Windows.Forms.Button();
            this._cmdCalc_7 = new System.Windows.Forms.Button();
            this._cmdCalc_6 = new System.Windows.Forms.Button();
            this._cmdCalc_5 = new System.Windows.Forms.Button();
            this._cmdCalc_4 = new System.Windows.Forms.Button();
            this._cmdCalc_3 = new System.Windows.Forms.Button();
            this._cmdCalc_2 = new System.Windows.Forms.Button();
            this._cmdCalc_1 = new System.Windows.Forms.Button();
            this._cmdCalc_0 = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cmdCalc_22
            // 
            this._cmdCalc_22.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_22.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_22.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_22.Location = new System.Drawing.Point(268, 196);
            this._cmdCalc_22.Name = "_cmdCalc_22";
            this._cmdCalc_22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_22.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_22.TabIndex = 23;
            this._cmdCalc_22.Text = "=";
            this._cmdCalc_22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_22.UseVisualStyleBackColor = false;
            this._cmdCalc_22.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_21
            // 
            this._cmdCalc_21.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_21.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_21.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_21.Location = new System.Drawing.Point(204, 196);
            this._cmdCalc_21.Name = "_cmdCalc_21";
            this._cmdCalc_21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_21.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_21.TabIndex = 22;
            this._cmdCalc_21.Text = "+";
            this._cmdCalc_21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_21.UseVisualStyleBackColor = false;
            this._cmdCalc_21.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_20
            // 
            this._cmdCalc_20.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_20.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_20.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_20.Location = new System.Drawing.Point(140, 196);
            this._cmdCalc_20.Name = "_cmdCalc_20";
            this._cmdCalc_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_20.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_20.TabIndex = 21;
            this._cmdCalc_20.Text = ".";
            this._cmdCalc_20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_20.UseVisualStyleBackColor = false;
            this._cmdCalc_20.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_19
            // 
            this._cmdCalc_19.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_19.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_19.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_19.Location = new System.Drawing.Point(76, 196);
            this._cmdCalc_19.Name = "_cmdCalc_19";
            this._cmdCalc_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_19.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_19.TabIndex = 20;
            this._cmdCalc_19.Text = "+/-";
            this._cmdCalc_19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_19.UseVisualStyleBackColor = false;
            this._cmdCalc_19.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_18
            // 
            this._cmdCalc_18.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_18.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_18.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_18.Location = new System.Drawing.Point(12, 196);
            this._cmdCalc_18.Name = "_cmdCalc_18";
            this._cmdCalc_18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_18.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_18.TabIndex = 19;
            this._cmdCalc_18.Text = "0";
            this._cmdCalc_18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_18.UseVisualStyleBackColor = false;
            this._cmdCalc_18.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_17
            // 
            this._cmdCalc_17.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_17.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_17.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_17.Location = new System.Drawing.Point(268, 160);
            this._cmdCalc_17.Name = "_cmdCalc_17";
            this._cmdCalc_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_17.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_17.TabIndex = 18;
            this._cmdCalc_17.Text = "1/x";
            this._cmdCalc_17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_17.UseVisualStyleBackColor = false;
            this._cmdCalc_17.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_16
            // 
            this._cmdCalc_16.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_16.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_16.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_16.Location = new System.Drawing.Point(204, 160);
            this._cmdCalc_16.Name = "_cmdCalc_16";
            this._cmdCalc_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_16.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_16.TabIndex = 17;
            this._cmdCalc_16.Text = "-";
            this._cmdCalc_16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_16.UseVisualStyleBackColor = false;
            this._cmdCalc_16.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_15
            // 
            this._cmdCalc_15.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_15.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_15.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_15.Location = new System.Drawing.Point(140, 160);
            this._cmdCalc_15.Name = "_cmdCalc_15";
            this._cmdCalc_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_15.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_15.TabIndex = 16;
            this._cmdCalc_15.Text = "3";
            this._cmdCalc_15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_15.UseVisualStyleBackColor = false;
            this._cmdCalc_15.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_14
            // 
            this._cmdCalc_14.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_14.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_14.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_14.Location = new System.Drawing.Point(76, 160);
            this._cmdCalc_14.Name = "_cmdCalc_14";
            this._cmdCalc_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_14.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_14.TabIndex = 15;
            this._cmdCalc_14.Text = "2";
            this._cmdCalc_14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_14.UseVisualStyleBackColor = false;
            this._cmdCalc_14.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_13
            // 
            this._cmdCalc_13.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_13.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_13.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_13.Location = new System.Drawing.Point(12, 160);
            this._cmdCalc_13.Name = "_cmdCalc_13";
            this._cmdCalc_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_13.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_13.TabIndex = 14;
            this._cmdCalc_13.Text = "1";
            this._cmdCalc_13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_13.UseVisualStyleBackColor = false;
            this._cmdCalc_13.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_12
            // 
            this._cmdCalc_12.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_12.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_12.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_12.Location = new System.Drawing.Point(268, 124);
            this._cmdCalc_12.Name = "_cmdCalc_12";
            this._cmdCalc_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_12.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_12.TabIndex = 13;
            this._cmdCalc_12.Text = "%";
            this._cmdCalc_12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_12.UseVisualStyleBackColor = false;
            this._cmdCalc_12.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_11
            // 
            this._cmdCalc_11.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_11.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_11.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_11.Location = new System.Drawing.Point(204, 124);
            this._cmdCalc_11.Name = "_cmdCalc_11";
            this._cmdCalc_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_11.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_11.TabIndex = 12;
            this._cmdCalc_11.Text = "X";
            this._cmdCalc_11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_11.UseVisualStyleBackColor = false;
            this._cmdCalc_11.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_10
            // 
            this._cmdCalc_10.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_10.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_10.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_10.Location = new System.Drawing.Point(140, 124);
            this._cmdCalc_10.Name = "_cmdCalc_10";
            this._cmdCalc_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_10.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_10.TabIndex = 11;
            this._cmdCalc_10.Text = "6";
            this._cmdCalc_10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_10.UseVisualStyleBackColor = false;
            this._cmdCalc_10.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_9
            // 
            this._cmdCalc_9.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_9.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_9.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_9.Location = new System.Drawing.Point(76, 124);
            this._cmdCalc_9.Name = "_cmdCalc_9";
            this._cmdCalc_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_9.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_9.TabIndex = 10;
            this._cmdCalc_9.Text = "5";
            this._cmdCalc_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_9.UseVisualStyleBackColor = false;
            this._cmdCalc_9.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_8
            // 
            this._cmdCalc_8.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_8.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_8.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_8.Location = new System.Drawing.Point(12, 124);
            this._cmdCalc_8.Name = "_cmdCalc_8";
            this._cmdCalc_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_8.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_8.TabIndex = 9;
            this._cmdCalc_8.Text = "4";
            this._cmdCalc_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_8.UseVisualStyleBackColor = false;
            this._cmdCalc_8.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_7
            // 
            this._cmdCalc_7.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_7.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_7.Location = new System.Drawing.Point(268, 88);
            this._cmdCalc_7.Name = "_cmdCalc_7";
            this._cmdCalc_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_7.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_7.TabIndex = 8;
            this._cmdCalc_7.Text = "sqrt";
            this._cmdCalc_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_7.UseVisualStyleBackColor = false;
            this._cmdCalc_7.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_6
            // 
            this._cmdCalc_6.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_6.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_6.Location = new System.Drawing.Point(204, 88);
            this._cmdCalc_6.Name = "_cmdCalc_6";
            this._cmdCalc_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_6.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_6.TabIndex = 7;
            this._cmdCalc_6.Text = "/";
            this._cmdCalc_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_6.UseVisualStyleBackColor = false;
            this._cmdCalc_6.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_5
            // 
            this._cmdCalc_5.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_5.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_5.Location = new System.Drawing.Point(140, 88);
            this._cmdCalc_5.Name = "_cmdCalc_5";
            this._cmdCalc_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_5.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_5.TabIndex = 6;
            this._cmdCalc_5.Text = "9";
            this._cmdCalc_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_5.UseVisualStyleBackColor = false;
            this._cmdCalc_5.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_4
            // 
            this._cmdCalc_4.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_4.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_4.Location = new System.Drawing.Point(76, 88);
            this._cmdCalc_4.Name = "_cmdCalc_4";
            this._cmdCalc_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_4.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_4.TabIndex = 5;
            this._cmdCalc_4.Text = "8";
            this._cmdCalc_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_4.UseVisualStyleBackColor = false;
            this._cmdCalc_4.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_3
            // 
            this._cmdCalc_3.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_3.Location = new System.Drawing.Point(12, 88);
            this._cmdCalc_3.Name = "_cmdCalc_3";
            this._cmdCalc_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_3.Size = new System.Drawing.Size(61, 33);
            this._cmdCalc_3.TabIndex = 4;
            this._cmdCalc_3.Text = "7";
            this._cmdCalc_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_3.UseVisualStyleBackColor = false;
            this._cmdCalc_3.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_2
            // 
            this._cmdCalc_2.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_2.Location = new System.Drawing.Point(232, 48);
            this._cmdCalc_2.Name = "_cmdCalc_2";
            this._cmdCalc_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_2.Size = new System.Drawing.Size(97, 33);
            this._cmdCalc_2.TabIndex = 3;
            this._cmdCalc_2.Text = "C";
            this._cmdCalc_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_2.UseVisualStyleBackColor = false;
            this._cmdCalc_2.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_1
            // 
            this._cmdCalc_1.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_1.Location = new System.Drawing.Point(124, 48);
            this._cmdCalc_1.Name = "_cmdCalc_1";
            this._cmdCalc_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_1.Size = new System.Drawing.Size(101, 33);
            this._cmdCalc_1.TabIndex = 2;
            this._cmdCalc_1.Text = "CE";
            this._cmdCalc_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_1.UseVisualStyleBackColor = false;
            this._cmdCalc_1.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // _cmdCalc_0
            // 
            this._cmdCalc_0.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalc_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalc_0.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdCalc_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalc_0.Location = new System.Drawing.Point(12, 48);
            this._cmdCalc_0.Name = "_cmdCalc_0";
            this._cmdCalc_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalc_0.Size = new System.Drawing.Size(101, 33);
            this._cmdCalc_0.TabIndex = 1;
            this._cmdCalc_0.Text = "Backspace";
            this._cmdCalc_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._cmdCalc_0.UseVisualStyleBackColor = false;
            this._cmdCalc_0.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Black;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDisplay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(12, 12);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDisplay.Size = new System.Drawing.Size(317, 25);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0.";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(342, 241);
            this.Controls.Add(this._cmdCalc_22);
            this.Controls.Add(this._cmdCalc_21);
            this.Controls.Add(this._cmdCalc_20);
            this.Controls.Add(this._cmdCalc_19);
            this.Controls.Add(this._cmdCalc_18);
            this.Controls.Add(this._cmdCalc_17);
            this.Controls.Add(this._cmdCalc_16);
            this.Controls.Add(this._cmdCalc_15);
            this.Controls.Add(this._cmdCalc_14);
            this.Controls.Add(this._cmdCalc_13);
            this.Controls.Add(this._cmdCalc_12);
            this.Controls.Add(this._cmdCalc_11);
            this.Controls.Add(this._cmdCalc_10);
            this.Controls.Add(this._cmdCalc_9);
            this.Controls.Add(this._cmdCalc_8);
            this.Controls.Add(this._cmdCalc_7);
            this.Controls.Add(this._cmdCalc_6);
            this.Controls.Add(this._cmdCalc_5);
            this.Controls.Add(this._cmdCalc_4);
            this.Controls.Add(this._cmdCalc_3);
            this.Controls.Add(this._cmdCalc_2);
            this.Controls.Add(this._cmdCalc_1);
            this.Controls.Add(this._cmdCalc_0);
            this.Controls.Add(this.lblDisplay);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(529, 218);
            this.MaximizeBox = false;
            this.Name = "frmCalculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCalculator_FormClosed);
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculator_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculator_KeyPress);
            this.ResumeLayout(false);

		}
		void ReLoadForm(bool addEvents)
		{
			InitializecmdCalc();
		}
		void InitializecmdCalc()
		{
			this.cmdCalc = new System.Windows.Forms.Button[23];
			this.cmdCalc[22] = _cmdCalc_22;
			this.cmdCalc[21] = _cmdCalc_21;
			this.cmdCalc[20] = _cmdCalc_20;
			this.cmdCalc[19] = _cmdCalc_19;
			this.cmdCalc[18] = _cmdCalc_18;
			this.cmdCalc[17] = _cmdCalc_17;
			this.cmdCalc[16] = _cmdCalc_16;
			this.cmdCalc[15] = _cmdCalc_15;
			this.cmdCalc[14] = _cmdCalc_14;
			this.cmdCalc[13] = _cmdCalc_13;
			this.cmdCalc[12] = _cmdCalc_12;
			this.cmdCalc[11] = _cmdCalc_11;
			this.cmdCalc[10] = _cmdCalc_10;
			this.cmdCalc[9] = _cmdCalc_9;
			this.cmdCalc[8] = _cmdCalc_8;
			this.cmdCalc[7] = _cmdCalc_7;
			this.cmdCalc[6] = _cmdCalc_6;
			this.cmdCalc[5] = _cmdCalc_5;
			this.cmdCalc[4] = _cmdCalc_4;
			this.cmdCalc[3] = _cmdCalc_3;
			this.cmdCalc[2] = _cmdCalc_2;
			this.cmdCalc[1] = _cmdCalc_1;
			this.cmdCalc[0] = _cmdCalc_0;
		}
		#endregion
	}
}