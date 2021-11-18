using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LanguageSupport {
	public class Language {

		private string selectedLanguage;
		private JsonDocument languageFormattedFile;

		public Language() {
			this.selectedLanguage = CultureInfo.CurrentCulture.Name;

			this.loadFile();
		}

		public string getLanguage() {
			return this.selectedLanguage;
		}

		public void setLanguage(string country) {
			this.selectedLanguage = new CultureInfo(country).Name;
			this.loadFile();
		}

		public string getTranslation(string keyWord) {
			JsonElement root = this.languageFormattedFile.RootElement;

			string result = root.GetProperty(keyWord).GetString();

			return result;
		}

		private void loadFile() {
			string fileContent = this.getFileContent(this.selectedLanguage);

			this.languageFormattedFile = this.formatFileContent(fileContent);
		}

		private string getFileContent(string countryCode) {
			var assembly = Assembly.GetExecutingAssembly();

			using (Stream stream = assembly.GetManifestResourceStream("LanguageSupport.Language." + countryCode + ".json"))
			using (StreamReader reader = new StreamReader(stream)) {
				string result = reader.ReadToEnd();

				return result;
			}
		}

		private JsonDocument formatFileContent(string fileContent) {
			JsonDocument doc = JsonDocument.Parse(fileContent);

			return doc;
		}
	}
}
