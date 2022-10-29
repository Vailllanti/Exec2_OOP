using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B_遊戲
{
	public partial class Form1 : Form
	{
		private Guess1A2B game;
		public Form1()
		{
			InitializeComponent();
			game = new Guess1A2B();
			game.NewGame();
		}

		private void newGameButton_Click(object sender, EventArgs e)
		{
			//開新遊戲
			game.NewGame();
			resultTextBox.Text = String.Empty;
		}

		private void guessButton_Click(object sender, EventArgs e)
		{
			//接收答案
			string guessNumber = GetGuessNumber();
			
			if (guessNumber == null) 
			{  
				MessageBox.Show( "請輸入一個四位正整數" );
				return;
			}

			//比對
			GuessResult result = game.Comparison( guessNumber );
			
			//成功
			if ( result.IsSuccess == true )
			{
				resultTextBox.AppendText(result.OutputHint);
				
			}
			//失敗
			else
			{
				resultTextBox.AppendText(result.OutputHint);
			}

		}
		private string GetGuessNumber()
		{
			string input = guessTextBox.Text;
			bool isInt = int.TryParse(input, out int value);
			if (string.IsNullOrWhiteSpace(input)|| isInt == false || value < 0 || input.Length !=4)
			{
				return null;
			}
			 
			return input;
		}
	}
	class Guess1A2B
	{
		private string guessNumber { get; set; }
		private string answer { get; set; }
		public int aValue = 0;
		public int bValue = 0;

		public void NewGame()
		{
			int seed = Guid.NewGuid().GetHashCode();
			var random = new Random(seed);
			answer = random.Next(0,9999).ToString("0000");
		}

		public GuessResult Comparison(string input)
		{
			guessNumber = input ;
			aValue = 0;
			bValue = 0;
			if (input == this.answer)
			{
				return GuessResult.Success(answer); 
			}

			string answerNum ,inputNum;
			string cmpAnswer = answer;
			//先取A值
			for ( int i = 0; i <= input.Length - 1 ; i++ )
			{
				inputNum = input.Substring(i, 1);
				answerNum = cmpAnswer.Substring(i, 1);
				if (inputNum == answerNum)
				{
					aValue++;
					input = input.Remove(i,1);
					cmpAnswer = cmpAnswer.Remove(i,1);
					i--;
				}
			}
			
			//取B值
			for (int i = 0; i <  input.Length  ; i++)
			{
				inputNum = input.Substring(i, 1);
				for (int j = 0; j < input.Length ; j++) 
				{
					answerNum = cmpAnswer.Substring(j, 1);
					if (inputNum == answerNum)
					{
						bValue++;
						break;
					}
				}
				
			}


			return GuessResult.Failed(Hint);
		}

		public string Hint 
		{ 
			get
			{
				return $"{guessNumber} {aValue}A{bValue}B \r\n";
			}
		}
	}
	public class GuessResult
	{
		public static GuessResult Success(string answer)
		{
			return new GuessResult { IsSuccess = true, OutputHint = $"恭喜答案為:{answer}"};
		}
		
		public static GuessResult Failed(string Hint)
		{
			return new GuessResult { IsSuccess = false, OutputHint = Hint }; ;
		}
		
		public bool IsSuccess { get; set; }
		public bool IsFailed { get { return !IsSuccess; } }
		public string OutputHint { get; set; }
	}
}
