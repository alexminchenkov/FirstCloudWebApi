using System;
using System.Collections.Generic;

namespace FirstCloudWebApi.Services
{
    public class QuickSort
    {
        public void Sort(List<int> source)
        {
            this.Sort(source, 0, source.Count - 1);
        }

        private void Sort(List<int> source, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivot = source[(left + right)/2];
            var index = this.Partition(source, left, right, pivot);
            this.Sort(source, left, index - 1);
            this.Sort(source, index, right);
        }

        private int Partition(List<int> source, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (source[left] < pivot) left++;

                while (source[right] > pivot) right--;

                if (left <= right)
                {
                    this.Swap(source, left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        private void Swap(List<int> source, int a, int b)
        {
            var temp = source[a];
            source[a] = source[b];
            source[b] = temp;
        }
    }
}