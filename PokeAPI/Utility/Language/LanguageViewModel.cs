using System.Windows.Data;
using KosGeneric;
using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// 言語ビューモデル
	/// </summary>
	public class LanguageViewModel : KosViewModel
	{
		// メンバ変数

		#region 言語モデル
		/// <summary>
		/// 言語モデル
		/// </summary>
		private LanguageModel model = new LanguageModel();
		#endregion

		// プロパティ

		#region ID
		/// <summary>
		/// ID
		/// </summary>
		public int ID
		{
			get => model.ID;
			set {
				model.ID = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get => model.Name;
			set {
				model.Name = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region オフィシャル
		/// <summary>
		/// オフィシャル
		/// </summary>
		public bool Official
		{
			get => model.Official;
			set {
				model.Official = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region ISO639
		/// <summary>
		/// ISO639
		/// </summary>
		public string Iso639
		{
			get => model.Iso639;
			set {
				model.Iso639 = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region ISO3166
		/// <summary>
		/// ISO3166
		/// </summary>
		public string Iso3166
		{
			get => model.Iso3166;
			set {
				model.Iso3166 = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 名称リスト
		/// <summary>
		/// 名称リスト
		/// </summary>
		public ListCollectionView Names { get; }
		#endregion

		// コンストラクタ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public LanguageViewModel()
		{
			Names = new ListCollectionView(model.Names);
		}
		#endregion

		// public メソッド

		#region 言語情報の取得
		/// <summary>
		/// 言語情報の取得
		/// </summary>
		/// <param name="url">URL</param>
		public void GetLanguage(string url)
		{
			// 取得済
			if(model.IsGeted) {
				return;
			}

			// JSON文字列の取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// 解析
			model.GetLanguageJson(json);
			model.IsGeted = true;

			// プロパティ更新
			RaisePropertyChanged(nameof(ID));
			RaisePropertyChanged(nameof(Name));
			RaisePropertyChanged(nameof(Official));
			RaisePropertyChanged(nameof(Iso639));
			RaisePropertyChanged(nameof(Iso3166));
		}
		#endregion
	}
}
