using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace FirstCloudWebApi.Services
{
    public class BubbleSort
    {
        public List<int> Sort(List<int> source)
        {
            for (int i = 0; i < source.Count - 1; i++)
            {
                for (int j = i + 1; j < source.Count; j ++)
                {
                    if (source[i] > source[j])
                    {
                        var temp = source[i];
                        source[i] = source[j];
                        source[j] = temp;
                    }
                }
            }

            return source;
        }

        public void SortWithImprovement(List<int> source)
        {
            bool madeChanges;
            var itemsCount = source.Count;

            do
            {
                madeChanges = false;
                itemsCount--;
                for (int i = 0; i < itemsCount; i++)
                {
                    if (source[i] > source[i + 1])
                    {
                        var temp = source[i];
                        source[i] = source[i + 1];
                        source[i + 1] = temp;

                        madeChanges = true;
                    }    
                }

            } while (madeChanges);
        }

        public void SortGeneric<T>(List<T> source) where T : IComparable<T>
        {
            bool madeChanges;
            var itemsCount = source.Count;

            do
            {
                madeChanges = false;
                itemsCount--;
                for (int i = 0; i < itemsCount; i++)
                {
                    if (source[i].CompareTo(source[i + 1]) > 0)
                    {
                        var temp = source[i];
                        source[i] = source[i + 1];
                        source[i + 1] = temp;

                        madeChanges = true;
                    }
                }

            } while (madeChanges);
        }
    }
}