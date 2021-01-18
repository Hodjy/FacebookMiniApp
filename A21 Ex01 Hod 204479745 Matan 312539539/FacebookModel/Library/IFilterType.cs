using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public interface IFilterType<T>
    {
        bool FilterBy(Post i_PostsToFilter, T i_FilterThreshold);
    }
}
