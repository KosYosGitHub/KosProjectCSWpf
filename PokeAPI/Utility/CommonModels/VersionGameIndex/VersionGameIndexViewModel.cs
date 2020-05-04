using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// バージョンゲームインデックスビューモデル
	/// </summary>
	public class VersionGameIndexViewModel : KosViewModel
	{
		// internal プロパティ

		#region バージョンゲームインデックスモデル
		/// <summary>
		/// バージョンゲームインデックスモデル
		/// </summary>
		internal VersionGameIndexModel Model { get; } = new VersionGameIndexModel();
		#endregion

		// public プロパティ

		#region ゲームインデックス
		/// <summary>
		/// ゲームインデックス
		/// </summary>
		public int GameIndex
		{
			get => Model.GameIndex;
			set {
				Model.GameIndex = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region バージョン
		/// <summary>
		/// バージョン
		/// </summary>
		public NamedAPIResourceViewModel Version => Model.Version;
		#endregion
	}
}
