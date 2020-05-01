namespace PokeAPI
{
	/// <summary>
	/// 場所リスト
	/// </summary>
	public class LocationList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LocationList() : base("location")
		{
		}
		#endregion
	}
}
