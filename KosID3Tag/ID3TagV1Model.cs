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

		#region バージョン
		/// <summary>
		/// バージョン
		/// </summary>
		internal ID3TagV1Version Version { get; set; } = ID3TagV1Version.ID3v1;
		#endregion

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

		// internal メソッド

		#region ファイルの読込
		/// <summary>
		/// ファイルの読込
		/// </summary>
		/// <param name="path">読込ファイルパス</param>
		internal void ReadFile(string path)
		{
			byte[] data = new byte[LengthTotal];

			// ファイルの末尾128byte分を読込
			using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				long startPos = fs.Length - LengthTotal;

				fs.Seek(startPos, SeekOrigin.Begin);
				fs.Read(data, 0, LengthTotal);
			}

			Encoding shiftJIS = Encoding.GetEncoding("Shift-JIS");

			// 先頭3byteが"TAG"
			if(shiftJIS.GetString(data, OffsetHeader, LengthHeader) == "TAG") {
				IsExists = true;
				SongTitle = shiftJIS.GetString(data, OffsetSongTitle, LengthSongTitle).TrimEnd('\0');		// 曲名
				Artist = shiftJIS.GetString(data, OffsetArtist, LengthArtist).TrimEnd('\0');				// アーティスト
				Album = shiftJIS.GetString(data, OffsetAlbum, LengthAlbum).TrimEnd('\0');					// アルバム
				Year = shiftJIS.GetString(data, OffsetYear, LengthYear).TrimEnd('\0');						// 西暦
				if(data[125] != 0) {
					// ID3 v1
					Version = ID3TagV1Version.ID3v1;
					Comment = shiftJIS.GetString(data, OffsetComment, LengthCommentV1).TrimEnd('\0');		// コメント
				}
				else {
					// ID3 v1.1
					Version = ID3TagV1Version.ID3v1_1;
					Comment = shiftJIS.GetString(data, OffsetComment, LengthCommentV1_1).TrimEnd('\0');		// コメント
					TrackNo = data[OffsetTrackNo];
				}
				GenreNo = data[OffsetGenreNo];																// ジャンル番号
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

		// private 定数

		#region ヘッダ位置
		/// <summary>
		/// ヘッダ位置
		/// </summary>
		private const int OffsetHeader = 0;
		#endregion

		#region 曲名位置
		/// <summary>
		/// 曲名位置
		/// </summary>
		private const int OffsetSongTitle = 3;
		#endregion

		#region アーティスト位置
		/// <summary>
		/// アーティスト位置
		/// </summary>
		private const int OffsetArtist = 33;
		#endregion

		#region アルバム位置
		/// <summary>
		/// アルバム位置
		/// </summary>
		private const int OffsetAlbum = 63;
		#endregion

		#region 西暦位置
		/// <summary>
		/// 西暦位置
		/// </summary>
		private const int OffsetYear = 93;
		#endregion

		#region コメント位置
		/// <summary>
		/// コメント位置
		/// </summary>
		private const int OffsetComment = 97;
		#endregion

		#region トラック番号
		/// <summary>
		/// トラック番号
		/// </summary>
		private const int OffsetTrackNo = 126;
		#endregion

		#region ジャンル番号
		/// <summary>
		/// ジャンル番号
		/// </summary>
		private const int OffsetGenreNo = 127;
		#endregion

		#region 総サイズ
		/// <summary>
		/// 総サイズ
		/// </summary>
		private const int LengthTotal = 128;
		#endregion

		#region ヘッダサイズ
		/// <summary>
		/// ヘッダサイズ
		/// </summary>
		private const int LengthHeader = 3;
		#endregion

		#region 曲名サイズ
		/// <summary>
		/// 曲名サイズ
		/// </summary>
		private const int LengthSongTitle = 30;
		#endregion

		#region アーティストサイズ
		/// <summary>
		/// アーティストサイズ
		/// </summary>
		private const int LengthArtist = 30;
		#endregion

		#region アルバムサイズ
		/// <summary>
		/// アルバムサイズ
		/// </summary>
		private const int LengthAlbum = 30;
		#endregion

		#region 西暦サイズ
		/// <summary>
		/// 西暦サイズ
		/// </summary>
		private const int LengthYear = 4;
		#endregion

		#region コメント(v1)サイズ
		/// <summary>
		/// コメント(v1)サイズ
		/// </summary>
		private const int LengthCommentV1 = 30;
		#endregion

		#region コメント(v1.1)サイズ
		/// <summary>
		/// コメント(v1.1)サイズ
		/// </summary>
		private const int LengthCommentV1_1 = 28;
		#endregion
	}
}
