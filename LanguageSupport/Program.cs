using System;
using System.Globalization;

namespace LanguageSupport {
	internal class Program {
		static void Main(string[] args) {
			Language lang = new Language();

			//CultureInfo[] resources = CultureInfo.GetCultures(CultureTypes.AllCultures);

			//foreach (CultureInfo item in resources) {
			//	Console.WriteLine(item.Name);
			//}

			lang.setLanguage("de-DE");
			Console.WriteLine(lang.getTranslation("insert").capitalizeString());
		}
	}
}
