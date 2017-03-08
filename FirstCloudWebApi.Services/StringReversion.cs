namespace FirstCloudWebApi.Services
{
    public class StringReversion
    {
        public string RunIteractively(string source)
        {
            var chars = source.ToCharArray();
            for (int i = 0; i < chars.Length/2; i++)
            {
                var temp = chars[i];
                chars[i] = chars[source.Length - i - 1];
                chars[source.Length - 1] = temp;
            }

            var result = new string(chars);
            return result;
        }

        public string RunRecursively(string source)
        {
            if (string.IsNullOrEmpty(source) || source.Length == 1)
            {
                return source;
            }

            var lastSymbol = source[source.Length - 1];
            var sourceWithoutLast = source.Substring(0, source.Length - 1);
            var resultOfWithoutLast = this.RunRecursively(sourceWithoutLast);
            var result = lastSymbol + resultOfWithoutLast;
            return result;
        }

        public string RunIteractivelyByBuildingNewString(string source)
        {
            var result = string.Empty;
            for(int i = source.Length - 1; i >=0; i--)
            {
                result += source[i];
            }

            return result;
        }
    }
}