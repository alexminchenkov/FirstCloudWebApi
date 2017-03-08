using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class SelectionSort
    {
        public void Sort(List<int> source)
        {
            for (int i = 0; i < source.Count - 1; i++)
            {
                int minimumIndex = i;
                // find minimum
                for (int j = i + 1; j < source.Count; j++)
                {
                    if (source[j] < source[minimumIndex])
                    {
                        minimumIndex = j;
                    }
                }

                this.Swap(source, i, minimumIndex);
            }
        }

        public void SortDesc(List<int> source)
        {
            for (int i = 0; i < source.Count - 1; i++)
            {
                int maximumIndex = i;
                // find minimum
                for (int j = i + 1; j < source.Count; j++)
                {
                    if (source[j] > source[maximumIndex])
                    {
                        maximumIndex = j;
                    }
                }

                this.Swap(source, i, maximumIndex);
            }
        }

        private void Swap(List<int> source, int i, int j)
        {
            int temp = source[i];
            source[i] = source[j];
            source[j] = temp;
        }
    }
}