namespace PokeAPI
{
	/// <summary>
	/// 技カテゴリリスト
	/// </summary>
	public class MoveCategoryList : NamedAPIResourceList
	{
		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MoveCategoryList() : base("move-category")
		{
		}
		#endregion
	}
}
