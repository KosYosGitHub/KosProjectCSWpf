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
		internal void ParseGenusList(JToken token, ObservableCollection<GenusViewModel> list)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				GenusViewModel genus = new GenusViewModel {
					Genus = (data["genus"] as JValue).ToString()
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
		internal void ParsePokemonSpeciesDexEntryList(JToken token, ObservableCollection<PokemonSpeciesDexEntryViewModel> dexEntries)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				PokemonSpeciesDexEntryViewModel dexEntry = new PokemonSpeciesDexEntryViewModel {
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
		internal void ParsePalParkEncounterAreaList(JToken token, ObservableCollection<PalParkEncounterAreaViewModel> palParkEncounters)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				PalParkEncounterAreaViewModel area = new PalParkEncounterAreaViewModel {
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
		internal void ParsePokemonSpeciesVarietyList(JToken token, ObservableCollection<PokemonSpeciesVarietyViewModel> list)
		{
			JArray datas = token as JArray;
			NamedAPIResourceParser parser = new NamedAPIResourceParser();

			foreach(JObject data in datas) {
				PokemonSpeciesVarietyViewModel item = new PokemonSpeciesVarietyViewModel {
					IsDefault = (bool)data["is_default"],
				};
				parser.ParseNamedAPIResource(data["pokemon"], item.Pokemon.Model);
				list.Add(item);
			}
		}
		#endregion
	}
}
