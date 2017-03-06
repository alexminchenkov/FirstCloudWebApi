using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstCloudWebApi.Services
{
    public class TowersOfHanoi
    {
        private StringBuilder actions;
        private List<string> actions2;

        public string MoveDisks(int disksCount)
        {
            this.actions = new StringBuilder();
            this.actions2 = new List<string>();
            this.MoveDisks(disksCount, "1", "3", "2");

            return this.actions2.Count.ToString();
            //return string.Join(", ", this.actions2);
            //return this.actions.ToString();
        }

        private void MoveDisks(int disksCount, string from, string to, string temp)
        {
            if (disksCount > 0)
            {
                this.MoveDisks(disksCount - 1, from, temp, to);
                this.MoveOneDisk(from, to);
                this.MoveDisks(disksCount - 1, temp, to, from);
            }
        }

        private void MoveOneDisk(string from, string to)
        {
            if (this.actions.Length > 0)
            {
                this.actions.Append(", ");
            }

            var action = $"({from}-{to})";
            this.actions.Append(action);
            this.actions2.Add(action);
        }
    }
}