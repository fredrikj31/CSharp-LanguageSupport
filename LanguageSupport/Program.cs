using System;

namespace LanguageSupport {
	internal class Program {
		static void Main(string[] args) {
			Language lang = new Language();

			//string[] resources = lang.getResources();

			//foreach (string item in resources) {
			//	Console.WriteLine(item);
			//}

			Console.WriteLine(lang.getLanguage());
		}
	}
}
