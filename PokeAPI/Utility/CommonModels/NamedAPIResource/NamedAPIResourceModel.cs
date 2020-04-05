using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
    /// <summary>
    /// 名前付きAPIリソースモデル
    /// </summary>
    internal class NamedAPIResourceModel
	{

		// プロパティ

		#region 名称
		/// <summary>名称</summary>
		public string Name { get; set; } = string.Empty;
		#endregion

		#region URL
		/// <summary>URL</summary>
		public string URL { get; set; } = string.Empty;
		#endregion
	}
}
