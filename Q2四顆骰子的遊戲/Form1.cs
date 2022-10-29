using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2四顆骰子的遊戲
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = string.Empty;
		}

		private void diceDutton_Click(object sender, EventArgs e)
		{
			Dice game = new Dice();
			game.GetDicePoint();
			game.DicePointCalc();
			resultLabel.Text = game.Result;

		}
	}
	class Dice
	{
		private int[] DicePoint { get; set; }
		const int numberOfDice = 4;
		private string answer { get; set; }
		private string diceResult { get; set; }

		public void GetDicePoint()
		{
			int seed = Guid.NewGuid().GetHashCode();
			var random = new Random(seed);

			int[] dice = new int[numberOfDice];

			for (int i = 0; i < numberOfDice; i++)
			{
				dice[i] = random.Next(1, 7);
			}
			DicePoint = dice;

			foreach (int i in DicePoint)
			{
				diceResult += ( " " + i);
			}
		}

		public void DicePointCalc()
		{

			Array.Sort(DicePoint);

			if ( DicePoint[0] == DicePoint[1])
			{
				int sum = DicePoint[2] + DicePoint[3];
				answer = $" 中獎!點數為 {sum}";
			}
			else
			{
				answer = " 沒中";
			}
		}

		public string Result 
		{
			get
			{
				return $"骰出的點數為: {diceResult} {answer}";
			}
		}

	}
}
