using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	internal class VersionGameIndexParser
	{
		#region バージョンゲームインデックスリストの取得
		/// <summary>
		/// 説明リストの取得
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="list">取得先のゲームインデックスリスト</param>
		internal void ParseVersionGameIndexList(JToken token, ObservableCollection<VersionGameIndexViewModel> list)
		{
			if(!token.HasValues) {
				return;
			}

			JArray datas = token as JArray;
			NamedAPIResourceParser namedAPIResourceParser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				VersionGameIndexViewModel item = new VersionGameIndexViewModel {
					GameIndex = (int)data["game_index"]
				};
				namedAPIResourceParser.ParseNamedAPIResource(data["version"], item.Version.Model);
				list.Add(item);
			}
		}
		#endregion
	}
}
