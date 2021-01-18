using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    internal class LikesFilter : IFilterType<int>
    {
        public LikesFilter()
        {
        }

        public Func<int, int, bool> FilterStrategy
        {
            get;
            set;
        }

        public bool FilterBy(Post i_PostsToFilter, int i_FilterThreshold)
        {
            return FilterStrategy.Invoke(i_PostsToFilter.LikedBy.Count, i_FilterThreshold);
        }
    }
}
