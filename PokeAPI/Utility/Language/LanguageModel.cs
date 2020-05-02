using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	/// <summary>
	/// 言語モデル
	/// </summary>
	internal class LanguageModel
	{
		// プロパティ

		#region ID
		/// <summary>
		/// ID
		/// </summary>
		internal int ID { get; set; } = 0;
		#endregion

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		internal string Name { get; set; } = string.Empty;
		#endregion

		#region オフィシャル
		/// <summary>
		/// オフィシャル
		/// </summary>
		internal bool Official { get; set; } = false;
		#endregion

		#region ISO639の国と言語
		/// <summary>
		/// ISO639の国と言語
		/// </summary>
		internal string Iso639 { get; set; } = string.Empty;
		#endregion

		#region ISO3166の言語
		/// <summary>
		/// ISO3166の言語
		/// </summary>
		internal string Iso3166 { get; set; } = string.Empty;
		#endregion

		#region 名称リスト
		/// <summary>
		/// 名称リスト
		/// </summary>
		internal ObservableCollection<NameViewModel> Names { get; } = new ObservableCollection<NameViewModel>();
		#endregion

		#region 取得済フラグ
		/// <summary>
		/// 取得済フラグ
		/// </summary>
		internal bool IsGeted { get; set; } = false;
		#endregion

		// internal メソッド

		#region  言語のJSON解析
		/// <summary>
		/// 言語のJSON解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		internal void GetLanguageJson(string json)
		{
			JObject obj = JObject.Parse(json);

			ID = (int)obj["id"];
			Name = (obj["name"] as JValue).ToString();
			Official = (bool)obj["official"];
			Iso639 = (obj["iso639"] as JValue).ToString();
			Iso3166 = (obj["iso3166"] as JValue).ToString();

			// 言語名称
			NameParser parser = new NameParser();
			parser.ParseNameList(obj, "names", Names);
		}
		#endregion
	}
}
