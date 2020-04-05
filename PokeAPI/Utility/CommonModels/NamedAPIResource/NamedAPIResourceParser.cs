using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using KosGeneric;

namespace PokeAPI
{
	internal class NamedAPIResourceParser
	{
		// internal メソッド

		#region 名前付きAPIリソースリストの取得
		/// <summary>
		/// 名前付きAPIリソースリストの取得
		/// </summary>
		/// <param name="json">名前リソースリストのJSON文字列</param>
		/// <param name="list">取得先名前付きリソースリスト</param>
		/// <param name="firstCall">初回呼出時のみtrue</param>
		internal void ParseNamedAPIResourceList(string json, NamedAPIResourceList list, bool firstCall = true)
		{
			JObject obj = JObject.Parse(json);

			// 初回呼出時
			if(firstCall) {
				list.Count = (int)obj["count"];
			}

			// 次ページへのURL
			string next = (obj["next"] as JValue).ToString();

			// 要素の存在確認
			JArray results = obj["results"] as JArray;
			if(results == null) {
				throw new ArgumentOutOfRangeException(list.EndPoint, "要素が見つかりません");
			}

			// 要素の解析
			foreach(JObject result in results) {
				NamedAPIResource res = new NamedAPIResource();
				res.Name = (result["name"] as JValue).ToString();
				res.URL = (result["url"] as JValue).ToString();
				list.NamedAPIResources.Add(res);
			}

			// 次ページが存在すれば再起呼出
			if(!string.IsNullOrEmpty(next)) {
				string nextJson = Singleton<PokeAPIClient>.Instance.GetJson(next);
				ParseNamedAPIResourceList(nextJson, list, false);
			}
		}
		#endregion
	}
}
