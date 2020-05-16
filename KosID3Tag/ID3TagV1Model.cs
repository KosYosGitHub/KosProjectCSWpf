using System.IO;
using System.Text;

namespace KosID3Tag
{
	internal class ID3TagV1Model
	{
		// internal プロパティ

		#region 存在フラグ
		/// <summary>
		/// 存在フラグ
		/// </summary>
		internal bool IsExists { get; private set; } = false;
		#endregion

		internal ID3TagV1Version Version { get; set; } = ID3TagV1Version.ID3v1;

		#region 曲名
		/// <summary>
		/// 曲名
		/// </summary>
		internal string SongTitle { get; set; } = string.Empty;
		#endregion

		#region アーティスト
		/// <summary>
		/// アーティスト
		/// </summary>
		internal string Artist { get; set; } = string.Empty;
		#endregion

		#region アルバム
		/// <summary>
		/// アルバム
		/// </summary>
		internal string Album { get; set; } = string.Empty;
		#endregion

		#region 西暦
		/// <summary>
		/// 西暦
		/// </summary>
		internal string Year { get; set; } = string.Empty;
		#endregion

		#region コメント
		/// <summary>
		/// コメント
		/// </summary>
		internal string Comment { get; set; } = string.Empty;
		#endregion

		#region トラック番号
		/// <summary>
		/// トラック番号
		/// </summary>
		internal byte TrackNo { get; set; } = 0;
		#endregion

		#region ジャンル番号
		/// <summary>
		/// ジャンル番号
		/// </summary>
		internal byte GenreNo { get; set; } = 0;
		#endregion

		#region ジャンル
		/// <summary>
		/// ジャンル
		/// </summary>
		internal string Genre
		{
			get {
				if(ID3TagV1.GenreDictionary.TryGetValue(GenreNo, out string genre)) {
					return genre;
				}
				else {
					return "Unknown";
				}
			}
		}
		#endregion

		// public メソッド

		#region ファイルの読込
		/// <summary>
		/// ファイルの読込
		/// </summary>
		/// <param name="path">読込ファイルパス</param>
		public void ReadFile(string path)
		{
			const int id3TagLength = 128;
			byte[] data = new byte[id3TagLength];

			// ファイルの末尾128byte分を読込
			using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				long startPos = fs.Length - id3TagLength;

				fs.Seek(startPos, SeekOrigin.Begin);
				fs.Read(data, 0, id3TagLength);
			}

			Encoding shiftJIS = Encoding.GetEncoding("Shift-JIS");

			// 先頭3byteが"TAG"
			if(shiftJIS.GetString(data, 0, 3) == "TAG") {
				IsExists = true;
				SongTitle = shiftJIS.GetString(data, 3, 30).TrimEnd('\0');		// 曲名
				Artist = shiftJIS.GetString(data, 33, 30).TrimEnd('\0');        // タイトル
				Album = shiftJIS.GetString(data, 63, 30).TrimEnd('\0');         // アルバム
				Year = shiftJIS.GetString(data, 93, 4).TrimEnd('\0');           // 西暦
				if(data[125] != 0) {
					// ID3 v1
					Version = ID3TagV1Version.ID3v1;
					Comment = shiftJIS.GetString(data, 97, 30).TrimEnd('\0');	// コメント
				}
				else {
					// ID3 v1.1
					Version = ID3TagV1Version.ID3v1_1;
					Comment = shiftJIS.GetString(data, 97, 27).TrimEnd('\0');   // コメント
					TrackNo = data[126];
				}
				GenreNo = data[127];
			}
			else {
				IsExists = false;
				Version = ID3TagV1Version.ID3v1;
				SongTitle = string.Empty;
				Artist = string.Empty;
				Album = string.Empty;
				Year = string.Empty;
				Comment = string.Empty;
				TrackNo = 0;
				GenreNo = 0;
			}
		}
		#endregion
	}
}
