namespace PokeAPI
{
	/// <summary>
	/// 技リスト
	/// </summary>
	public class MoveList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MoveList() : base("move")
		{
		}
		#endregion
	}
}
