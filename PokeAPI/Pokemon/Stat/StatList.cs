namespace PokeAPI
{
	/// <summary>
	/// ステータスリスト
	/// </summary>
	public class StatList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public StatList() : base("stat")
		{
		}
		#endregion
	}
}
