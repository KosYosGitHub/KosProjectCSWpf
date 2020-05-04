using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	internal class PokemonParser
	{
		// internal メソッド

		#region PokemonAbilityリスト解析
		/// <summary>
		/// PokemonAbilityリスト解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="list">取得先</param>
		internal void ParsePokemonAbilityList(JToken token, ObservableCollection<PokemonAbilityViewModel> list)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				PokemonAbilityViewModel item = new PokemonAbilityViewModel {
					IsHidden = (bool)data["is_hidden"],
					Slot = (int)data["slot"],
				};
				parser.ParseNamedAPIResource(data["ability"], item.Ability.Model);
				list.Add(item);
			}
		}
		#endregion
	}
}
