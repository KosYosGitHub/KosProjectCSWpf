using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KosGeneric;

namespace PokeAPI
{
	internal class PokeAPIClient
	{
		// internal メソッド

		#region APIリソースリストのJSON文字列取得(エンドポイント指定)
		/// <summary>
		/// APIリソースリストのJSON文字列取得(エンドポイント指定)
		/// </summary>
		/// <param name="endPoint">エンドポイント</param>
		/// <returns>JSON文字列</returns>
		internal string GetAPIResourceListEndPoint(string endPoint)
		{
			return Singleton<HttpClient>.Instance.GetStringAsync($"https://pokeapi.co/api/v2/{endPoint}/").Result;
		}
		#endregion

		#region JSON文字列の取得
		/// <summary>
		/// JSON文字列の取得
		/// </summary>
		/// <param name="url">URL</param>
		/// <returns>JSON文字列</returns>
		internal string GetJson(string url)
		{
			// PokeAPIではないURLの場合はGETしない
			if(!url.Contains("pokeapi")) {
				throw new ArgumentException("PokeAPIのURLではありません。", url);
			}

			return Singleton<HttpClient>.Instance.GetStringAsync(url).Result;
		}
		#endregion
	}
}
