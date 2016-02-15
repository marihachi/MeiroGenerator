using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeiroGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private CellMap _Map { get; set; }
		private Random _Random { get; } = new Random();

		private void GenerateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_Map = new CellMap(new Size((int)numericUpDownX.Value, (int)numericUpDownY.Value), _Random);

			_Map.GenerateOutsideWall();

			var baseCell = _Map.GetBaseCell();

			do
			{
				var directions = baseCell.GetFree2StepDirections();

				do
				{
					switch (directions[_Random.Next(directions.Count)])
					{
						case Direction.Up:
							baseCell.Up.IsWall = true;
							baseCell.Up.Up.IsWall = true;
							baseCell = baseCell.Up.Up;

							break;
						case Direction.Down:
							baseCell.Down.IsWall = true;
							baseCell.Down.Down.IsWall = true;
							baseCell = baseCell.Down.Down;

							break;
						case Direction.Left:
							baseCell.Left.IsWall = true;
							baseCell.Left.Left.IsWall = true;
							baseCell = baseCell.Left.Left;

							break;
						case Direction.Right:
							baseCell.Right.IsWall = true;
							baseCell.Right.Right.IsWall = true;
							baseCell = baseCell.Right.Right;

							break;
					}

					directions = baseCell.GetFree2StepDirections();
				}
				while (directions != null);

				baseCell = _Map.GetBaseCell();
			}
			while (baseCell != null);

			_Map.Draw(textBox1, "■");
		}
	}
}
