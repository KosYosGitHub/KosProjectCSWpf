using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	internal class DescriptionParser
	{
		#region 説明リストの取得
		/// <summary>
		/// 説明リストの取得
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="list">取得先の説明リスト</param>
		internal void ParseDescriptionList(JToken token, ObservableCollection<DescriptionViewModel> list)
		{
			if(!token.HasValues) {
				return;
			}

			JArray datas = token as JArray;
			NamedAPIResourceParser namedAPIResourceParser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				DescriptionViewModel item = new DescriptionViewModel {
					Description = (data["description"] as JValue).ToString()
				};
				namedAPIResourceParser.ParseNamedAPIResource(data["language"], item.Language.Model);
				list.Add(item);
			}
		}
		#endregion
	}
}
