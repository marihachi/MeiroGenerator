using System.Collections.Generic;
using System.Drawing;

namespace MeiroGenerator
{
	/// <summary>
	/// 迷路を構成するセルを表します。
	/// </summary>
	public class Cell
	{
		/// <summary>
		/// インスタンスを初期化します。
		/// </summary>
		public Cell(Point location, bool isWall, CellMap container)
		{
			Location = location;
			IsWall = isWall;
			Container = container;
		}

		/// <summary>
		/// このセルが属するセルマップを取得します。
		/// </summary>
		public CellMap Container { get; private set; }

		/// <summary>
		/// このセルの座標を取得します。
		/// </summary>
		public Point Location { get; private set; }

		/// <summary>
		/// このセルが壁であるかどうかを取得または設定します。
		/// </summary>
		public bool IsWall { get; set; }

		/// <summary>
		/// ひとつ上のセルを取得します。
		/// </summary>
		public Cell Up
		{
			get
			{
				return (Location.Y > 0) ? Container.Get(Location.X, Location.Y - 1) : null;
			}
		}

		/// <summary>
		/// ひとつ下のセルを取得します。
		/// </summary>
		public Cell Down
		{
			get
			{
				return (Location.Y < Container.Height - 1) ? Container.Get(Location.X, Location.Y + 1) : null;
			}
		}

		/// <summary>
		/// ひとつ左のセルを取得します。
		/// </summary>
		public Cell Left
		{
			get
			{
				return (Location.X > 0) ? Container.Get(Location.X - 1, Location.Y) : null;
			}
		}

		/// <summary>
		/// ひとつ右のセルを取得します。
		/// </summary>
		public Cell Right
		{
			get
			{
				return (Location.X < Container.Width - 1) ? Container.Get(Location.X + 1, Location.Y) : null;
			}
		}

		/// <summary>
		/// 基準のセルから2マスの空きがある方向を全て取得します。
		/// </summary>
		/// <returns>存在しなければ Null を返します。</returns>
		public List<Direction> GetFree2StepDirections()
		{
			var ds = new List<Direction>();

			if (Up?.Up != null && !Up.Up.IsWall)
				ds.Add(Direction.Up);

			if (Down?.Down != null && !Down.Down.IsWall)
				ds.Add(Direction.Down);

			if (Left?.Left != null && !Left.Left.IsWall)
				ds.Add(Direction.Left);

			if (Right?.Right != null && !Right.Right.IsWall)
				ds.Add(Direction.Right);

			return (ds.Count != 0) ? ds : null;
		}
	}
}
