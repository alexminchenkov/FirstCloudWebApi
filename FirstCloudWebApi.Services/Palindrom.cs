namespace FirstCloudWebApi.Services
{
    public class Palindrom
    {
        public bool CheckInteractiverly(string checking)
        {
            checking = checking.Replace(" ", string.Empty).ToLower();
            var n = checking.Length / 2;

            for (int i = 0; i < n; i++)
            {
                var str1 = checking.Substring(i, 1); 
                var str2 = checking.Substring(checking.Length - i - 1, 1);
                if (str1 != str2)
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckRecursively(string checking)
        {
            checking = checking.Replace(" ", string.Empty).ToLower();

            return CheckRecursivelyCore(checking);
        }

        private bool CheckRecursivelyCore(string checking)
        {
            if (string.IsNullOrEmpty(checking) || checking.Length == 1)
            {
                return true;
            }

            var first = checking.Substring(0, 1);
            var last = checking.Substring(checking.Length - 1, 1);

            if (first != last)
            {
                return false;
            }

            return this.CheckRecursivelyCore(checking.Substring(1, checking.Length - 2));
        }
    }
}