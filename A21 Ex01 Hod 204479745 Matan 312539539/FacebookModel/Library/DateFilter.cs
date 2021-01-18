using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    internal class DateFilter : IFilterType<DateTime>
    {
        public DateFilter()
        {
        }

        public Func<DateTime?, DateTime, bool> FilterStrategy
        {
            get;
            set;
        }

        public bool FilterBy(Post i_PostsToFilter, DateTime i_FilterThreshhold)
        {
            return FilterStrategy.Invoke(i_PostsToFilter.CreatedTime, i_FilterThreshhold);
        }
    }
}
