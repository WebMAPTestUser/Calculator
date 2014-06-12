using Microsoft.VisualBasic;
using System;
using System.Media;
using System.Windows.Forms;
using VB6 = Microsoft.VisualBasic.Compatibility.VB6.Support;

namespace prjCalculator
{
	internal partial class frmCalculator
		: System.Windows.Forms.Form
	{


		private double mdblResult = 0;
		private double mdblSavedNumber = 0;
		private string mstrDot = String.Empty;
		private string mstrOp = String.Empty;
		private string mstrDisplay = String.Empty;
		private bool mblnDecEntered = false;
		private bool mblnOpPending = false;
		private bool mblnNewEquals = false;
		private bool mblnEqualsPressed = false;
		private int mintCurrKeyIndex = 0;

		public frmCalculator()
			: base()
		{
			if (m_vb6FormDefInstance == null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			ReLoadForm(false);
		}


		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load event and has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2080.aspx
		private void frmCalculator_Load(Object eventSender, EventArgs eventArgs)
		{

			Top = (int) ((Screen.PrimaryScreen.Bounds.Height - (Height)) / 2);
			Left = (int) ((Screen.PrimaryScreen.Bounds.Width - (Width)) / 2);

		}


		private void frmCalculator_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = (eventArgs.Shift) ? 1 : 0;

			int intIndex = 0;

			//UPGRADE_WARNING: (6021) Casting 'int' to Enum may cause different behaviour. More Information: http://www.vbtonet.com/ewis/ewi6021.aspx
			switch((Keys) KeyCode)
			{
				case Keys.Back :  
					intIndex = 0; 
					break;
				case Keys.Delete :  
					intIndex = 1; 
					break;
				case Keys.Escape :  
					intIndex = 2; 
					break;
				case Keys.D0 : case Keys.NumPad0 :  
					intIndex = 18; 
					break;
				case Keys.D1 : case Keys.NumPad1 :  
					intIndex = 13; 
					break;
				case Keys.D2 : case Keys.NumPad2 :  
					intIndex = 14; 
					break;
				case Keys.D3 : case Keys.NumPad3 :  
					intIndex = 15; 
					break;
				case Keys.D4 : case Keys.NumPad4 :  
					intIndex = 8; 
					break;
				case Keys.D5 : case Keys.NumPad5 :  
					intIndex = 9; 
					break;
				case Keys.D6 : case Keys.NumPad6 :  
					intIndex = 10; 
					break;
				case Keys.D7 : case Keys.NumPad7 :  
					intIndex = 3; 
					break;
				case Keys.D8 : case Keys.NumPad8 :  
					intIndex = 4; 
					break;
				case Keys.D9 : case Keys.NumPad9 :  
					intIndex = 5; 
					break;
				case Keys.Decimal :  
					intIndex = 20; 
					break;
				case Keys.Add :  
					intIndex = 21; 
					break;
				case Keys.Subtract :  
					intIndex = 16; 
					break;
				case Keys.Multiply :  
					intIndex = 11; 
					break;
				case Keys.Divide :  
					intIndex = 6; 
					break;
				default: 
					return;
			}

			cmdCalc[intIndex].Focus();
			cmdCalc_Click(cmdCalc[intIndex], new EventArgs());

		}


		private void frmCalculator_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Strings.Asc(eventArgs.KeyChar);

			int intIndex = 0;

			switch(Strings.Chr(KeyAscii).ToString())
			{
				case "S" : case "s" :  
					intIndex = 7; 
					break;
				case "P" : case "p" :  
					intIndex = 12; 
					break;
				case "R" : case "r" :  
					intIndex = 17; 
					break;
				case "X" : case "x" :  
					intIndex = 11; 
					break;
				case "=" :  
					intIndex = 22; 
					break;
				default: 
					if (KeyAscii == 0)
					{
						eventArgs.Handled = true;
					} 
					return;
			}

			cmdCalc[intIndex].Focus();
			cmdCalc_Click(cmdCalc[intIndex], new EventArgs());

			if (KeyAscii == 0)
			{
				eventArgs.Handled = true;
			}
			eventArgs.KeyChar = Convert.ToChar(KeyAscii);
		}

		private void cmdCalc_Click(Object eventSender, EventArgs eventArgs)
		{
			int Index = Array.IndexOf(cmdCalc, eventSender);


			mintCurrKeyIndex = Index;

			if (mstrDisplay == "ERROR")
			{
				mstrDisplay = "";
			}

			string strPressedKey = cmdCalc[Index].Text;

			switch(strPressedKey)
			{
				case "0" : case "1" : case "2" : case "3" : case "4" : case "5" : case "6" : case "7" : case "8" : case "9" : 
					if (mblnOpPending)
					{
						mstrDisplay = "";
						mblnOpPending = false;
					} 
					if (mblnEqualsPressed)
					{
						mstrDisplay = "";
						mblnEqualsPressed = false;
					} 
					mstrDisplay = mstrDisplay + strPressedKey; 
					break;
				case "." : 
					if (mblnOpPending)
					{
						mstrDisplay = "";
						mblnOpPending = false;
					} 
					if (mblnEqualsPressed)
					{
						mstrDisplay = "";
						mblnEqualsPressed = false;
					} 
					if (mstrDisplay.IndexOf('.') >= 0)
					{
						SystemSounds.Beep.Play();
					}
					else
					{
						mstrDisplay = mstrDisplay + strPressedKey;
					} 
					break;
				case "+" : case "-" : case "X" : case "/" : 
					mdblResult = Conversion.Val(mstrDisplay); 
					mstrOp = strPressedKey; 
					mblnOpPending = true; 
					mblnDecEntered = false; 
					mblnNewEquals = true; 
					break;
				case "%" : 
					mdblSavedNumber = (Conversion.Val(mstrDisplay) / 100) * mdblResult; 
					mstrDisplay = mdblSavedNumber.ToString(); 
					break;
				case "=" : 
					if (mblnNewEquals)
					{
						mdblSavedNumber = Conversion.Val(mstrDisplay);
						mblnNewEquals = false;
					} 
					switch(mstrOp)
					{
						case "+" : 
							mdblResult += mdblSavedNumber; 
							break;
						case "-" : 
							mdblResult -= mdblSavedNumber; 
							break;
						case "X" : 
							mdblResult *= mdblSavedNumber; 
							break;
						case "/" : 
							if (mdblSavedNumber == 0)
							{
								mstrDisplay = "ERROR";
							}
							else
							{
								mdblResult /= mdblSavedNumber;
							} 
							break;
						default:
							mdblResult = Conversion.Val(mstrDisplay); 
							break;
					} 
					if (mstrDisplay != "ERROR")
					{
						mstrDisplay = mdblResult.ToString();
					} 
					mblnEqualsPressed = true; 
					break;
				case "+/-" : 
					if (mstrDisplay != "")
					{
						if (Strings.Left(mstrDisplay, 1) == "-")
						{
							mstrDisplay = Strings.Right(mstrDisplay, 2);
						}
						else
						{
							mstrDisplay = "-" + mstrDisplay;
						}
					} 
					break;
				case "Backspace" : 
					if (Conversion.Val(mstrDisplay) != 0)
					{
						mstrDisplay = Strings.Left(mstrDisplay, mstrDisplay.Length - 1);
						mdblResult = Conversion.Val(mstrDisplay);
					} 
					break;
				case "CE" : 
					mstrDisplay = ""; 
					break;
				case "C" : 
					mstrDisplay = ""; 
					mdblResult = 0; 
					mdblSavedNumber = 0; 
					break;
				case "1/x" : 
					if (Conversion.Val(mstrDisplay) == 0)
					{
						mstrDisplay = "ERROR";
					}
					else
					{
						mdblResult = Conversion.Val(mstrDisplay);
						mdblResult = 1 / mdblResult;
						mstrDisplay = mdblResult.ToString();
					} 
					break;
				case "sqrt" : 
					if (Conversion.Val(mstrDisplay) < 0)
					{
						mstrDisplay = "ERROR";
					}
					else
					{
						mdblResult = Conversion.Val(mstrDisplay);
						mdblResult = Math.Sqrt(mdblResult);
						mstrDisplay = mdblResult.ToString();
					} 
					break;
			}

			if (mstrDisplay == "")
			{
				lblDisplay.Text = "0.";
			}
			else
			{
				mstrDot = (mstrDisplay.IndexOf('.') >= 0) ? "" : ".";
				lblDisplay.Text = mstrDisplay + mstrDot;
				if (Strings.Left(lblDisplay.Text, 1) == "0")
				{
					lblDisplay.Text = Strings.Mid(lblDisplay.Text, 2);
				}
			}

			if (lblDisplay.Text == ".")
			{
				lblDisplay.Text = "0.";
			}

		}
		[STAThread]
		static void Main()
		{
			//UpgradeHelpers.VB6.Activex.ComponentServerFactory.RegisterClientIPCChannel();
			Application.Run(new frmCalculator());
		}

        private void frmCalculator_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
	}
}