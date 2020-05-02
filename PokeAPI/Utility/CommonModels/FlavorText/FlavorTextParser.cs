using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	internal class FlavorTextParser
	{
		#region フレーバーテキストリストの取得
		/// <summary>
		/// フレーバーテキストリストの取得
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="list">取得先のフレーバーテキストリスト</param>
		internal void ParseFlavorTextList(JToken token, ObservableCollection<FlavorText> list)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser namedAPIResourceParser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				FlavorText item = new FlavorText {
					Text = (data["flavor_text"] as JValue).ToString()
				};
				namedAPIResourceParser.ParseNamedAPIResource(data["language"], item.Language.Model);
				namedAPIResourceParser.ParseNamedAPIResource(data["version"], item.Version.Model);
				list.Add(item);
			}
		}
		#endregion
	}
}
