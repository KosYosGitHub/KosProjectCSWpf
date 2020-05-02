using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	internal class APIResourceParser
	{
		// internal メソッド

		#region APIリソースの取得
		/// <summary>
		/// APIリソースの取得
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="apiResource">取得先のAPIリソース</param>
		internal void ParseAPIResource(JToken token, APIResourceModel apiResource)
		{
			if(!token.HasValues) {
				return;
			}

			apiResource.URL = (token["url"] as JValue).ToString();
		}
		#endregion
	}
}
