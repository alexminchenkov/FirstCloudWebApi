using System;
using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class InsertionSort
    {
        public void Sort(List<int> source)
        {
            for (int i = 1; i < source.Count; i++)
            {
                int currentValue = source[i];

                var j = i - 1;
                for (; j >= 0 && source[j] > currentValue; j--)
                {
                    source[j + 1] = source[j];
                }

                source[j + 1] = currentValue;
            }
        }

        public void SortGeneric<T>(List<T> entries)
            where T : IComparable<T>
        {
            SortGeneric(entries, 0, entries.Count - 1);
        }

        private void SortGeneric<T>(List<T> entries, Int32 first, Int32 last)
            where T : IComparable<T>
        {
            for (var i = first + 1; i <= last; i++)
            {
                var entry = entries[i];
                var j = i;

                while (j > first && entries[j - 1].CompareTo(entry) > 0)
                    entries[j] = entries[--j];

                entries[j] = entry;
            }
        }

        public void SortDesc(List<int> source)
        {
        }
    }
}