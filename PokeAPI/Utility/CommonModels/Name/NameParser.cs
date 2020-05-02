using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	internal class NameParser
	{
		// internal メソッド

		#region 名称リストの取得
		/// <summary>
		/// 名称リストの取得
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="name">要素名</param>
		/// <param name="names">取得先名称リスト</param>
		internal void ParseNameList(JToken token, string name, ObservableCollection<NameViewModel> names)
		{
			JArray fields = token[name] as JArray;
			if(fields == null) {
				throw new ArgumentException("要素が見つかりません。", name);
			}

			NamedAPIResourceParser parser = new NamedAPIResourceParser();
			foreach(JObject field in fields) {
				NameViewModel data = new NameViewModel();

				data.NameText = (field["name"] as JValue).ToString();
				parser.ParseNamedAPIResource(field["language"], data.Language);
				names.Add(data);
			}
		}
		#endregion
	}
}
