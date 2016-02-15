using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeiroGenerator
{
	/// <summary>
	/// Cell の集合を表します。
	/// </summary>
	public class CellMap
	{
		/// <summary>
		/// インスタンスを初期化します。
		/// </summary>
		public CellMap(Size mapSize, Random r, bool initValue = false)
		{
			_Items = new Cell[mapSize.Width, mapSize.Height];

			for (var x = 0; x < mapSize.Width; x++)
				for (var y = 0; y < mapSize.Height; y++)
					_Items[x, y] = new Cell(new Point(x, y), initValue, this);

			Height = mapSize.Height;
			Width = mapSize.Width;

			_Random = r;
		}

		private Cell[,] _Items { get; set; }
		private Random _Random { get; set; }

		/// <summary>
		/// 全ての項目を取得します。
		/// </summary>
		public List<Cell> Items
		{
			get
			{
				return Filter(i => true);
			}
		}

		/// <summary>
		/// マップの高さを取得します。
		/// </summary>
		public int Height { get; private set; }

		/// <summary>
		/// マップの幅を取得します。
		/// </summary>
		public int Width { get; private set; }

		/// <summary>
		/// フィルターを通して項目を取得します。
		/// </summary>
		/// <param name="match"></param>
		/// <returns></returns>
		public List<Cell> Filter(Predicate<Cell> match)
		{
			var items = new List<Cell>();

			foreach (var x in Enumerable.Range(0, Width))
				foreach (var y in Enumerable.Range(0, Height))
					if (match(_Items[x, y]))
						items.Add(_Items[x, y]);

			return items;
		}

		/// <summary>
		/// 指定した座標のセルを取得します。
		/// </summary>
		/// <returns>存在しなければ Null を返します。</returns>
		public Cell Get(int x, int y)
		{
			return (x >= 0 && x < Width && y >= 0 && y < Height) ? _Items[x, y] : null;
		}

		/// <summary>
		/// 起点セルを取得します。
		/// </summary>
		/// <returns>存在しなければ Null を返します。</returns>
		public Cell GetBaseCell()
		{
			// 壁セル & 偶数セル & 1つ以上の方向に空きがある
			var freeWalls = Filter(i => i.IsWall && i.Location.X % 2 == 0 && i.Location.Y % 2 == 0 && i.GetFree2StepDirections() != null);

			return (freeWalls.Count != 0) ? freeWalls[_Random.Next(freeWalls.Count)] : null;
		}

		/// <summary>
		/// 外側の壁を生成します。
		/// </summary>
		public void GenerateOutsideWall()
		{
			Filter(i => i.Location.X == 0 || i.Location.Y == 0 || i.Location.X == Width - 1 || i.Location.Y == Height - 1)
				.ForEach(i => i.IsWall = true);
		}

		/// <summary>
		/// 対象とする TextBox にセル情報を描画します。
		/// </summary>
		public void Draw(TextBox target, string WallChar)
		{
			var sb = new StringBuilder();
			foreach (var x in Enumerable.Range(0, Width))
			{
				foreach (var y in Enumerable.Range(0, Height))
					if (Get(x, y).IsWall)
						sb.Append(WallChar);
					else
						sb.Append("　");

				sb.Append("\r\n");
			}

			target.Text = sb.ToString();
		}
	}
}
