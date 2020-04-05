using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosGeneric
{
	/// <summary>
	/// singleton デザインパターンクラス
	/// </summary>
	/// <typeparam name="T">singletonにする型</typeparam>
	public static class Singleton<T> where T : class, new()
	{
		// private 静的メンバ変数

		#region 唯一のインスタンス
		/// <summary>
		/// 唯一のインスタンス
		/// </summary>
		private static readonly T instance = new T();
		#endregion

		// public 静的プロパティ

		#region インスタンスへのgetter
		/// <summary>
		/// インスタンスへのgetter
		/// </summary>
		public static T Instance
		{
			get => instance;
		}
		#endregion
	}
}
