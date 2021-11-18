using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSupport {
    public static class ExtensionMethods {
        public static string capitalizeString(this string input) {
			StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < input.Length; i++) {
                if (i == 0) {
                    sb.Append(char.ToUpper(input[i]));
				} else {
                    sb.Append(input[i]);
				}
			}

            return sb.ToString();
        }
    }
}
