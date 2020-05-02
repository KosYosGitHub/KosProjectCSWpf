using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	internal class PokemonSpeciesParser
	{
		// internal メソッド

		#region Genusの解析
		/// <summary>
		/// Genusの解析
		/// </summary>
		/// <param name="token">genusトークン</param>
		/// <param name="genusModels">取得先Genusリスト</param>
		internal void ParseGenusList(JToken token, List<GenusModel> genusModels)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				GenusModel genus = new GenusModel();
				genus.Genus = (data["genus"] as JValue).ToString();
				parser.ParseNamedAPIResource(data["language"], genus.Language);
				genus.IsGeted = true;
				genusModels.Add(genus);
			}
		}
		#endregion

		#region PokemonSpeciesDexEntryの解析
		/// <summary>
		/// PokemonSpeciesDexEntryの解析
		/// </summary>
		/// <param name="token">PokemonSpeciesDexEntryのトークン</param>
		/// <param name="dexEntries">取得先PokemonSpeciesDexEntryリスト</param>
		internal void ParsePokemonSpeciesDexEntryList(JToken token, List<PokemonSpeciesDexEntry> dexEntries)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				PokemonSpeciesDexEntry dexEntry = new PokemonSpeciesDexEntry();
				dexEntry.EntryNumber = (int)data["entry_number"];
				parser.ParseNamedAPIResource(data["pokedex"], dexEntry.Pokedex.Model);
				dexEntries.Add(dexEntry);
			}
		}
		#endregion
	}
}
