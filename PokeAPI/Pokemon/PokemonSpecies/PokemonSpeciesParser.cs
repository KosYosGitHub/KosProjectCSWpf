using System.Collections.ObjectModel;
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
		internal void ParseGenusList(JToken token, ObservableCollection<Genus> list)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				Genus genus = new Genus {
					Name = (data["genus"] as JValue).ToString()
				};
				parser.ParseNamedAPIResource(data["language"], genus.Language.Model);
				list.Add(genus);
			}
		}
		#endregion

		#region PokemonSpeciesDexEntryの解析
		/// <summary>
		/// PokemonSpeciesDexEntryの解析
		/// </summary>
		/// <param name="token">PokemonSpeciesDexEntryのトークン</param>
		/// <param name="dexEntries">取得先PokemonSpeciesDexEntryリスト</param>
		internal void ParsePokemonSpeciesDexEntryList(JToken token, ObservableCollection<PokemonSpeciesDexEntry> dexEntries)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				PokemonSpeciesDexEntry dexEntry = new PokemonSpeciesDexEntry {
					EntryNumber = (int)data["entry_number"]
				};
				parser.ParseNamedAPIResource(data["pokedex"], dexEntry.Pokedex.Model);
				dexEntries.Add(dexEntry);
			}
		}
		#endregion

		#region PalParkENcounterAreaの解析
		/// <summary>
		/// PalParkENcounterAreaの解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="palParkEncounters">取得先PalParkEncounterAreaリスト</param>
		internal void ParsePalParkEncounterAreaList(JToken token, ObservableCollection<PalParkEncounterArea> palParkEncounters)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				PalParkEncounterArea area = new PalParkEncounterArea {
					BaseScore = (int)data["base_score"],
					Rate = (int)data["rate"],
				};
				parser.ParseNamedAPIResource(data["area"], area.Area.Model);
				palParkEncounters.Add(area);
			}
		}
		#endregion

		#region PokemonSpeciesVarietyの解析
		/// <summary>
		/// PokemonSpeciesVarietyの解析
		/// </summary>
		/// <param name="token">JSONトークン</param>
		/// <param name="list">取得先リスト</param>
		internal void ParsePokemonSpeciesVarietyList(JToken token, ObservableCollection<PokemonSpeciesVariety> list)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				PokemonSpeciesVariety item = new PokemonSpeciesVariety {
					IsDefault = (bool)data["is_default"],
				};
				parser.ParseNamedAPIResource(data["pokemon"], item.Pokemon.Model);
				list.Add(item);
			}
		}
		#endregion
	}
}
