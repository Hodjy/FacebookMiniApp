using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    internal static class FacebookFilters
    {
        private static DateFilter sm_FilterByDate = new DateFilter();
        private static LikesFilter sm_FilterByLikesCount = new LikesFilter();

        public static DateFilter FilterByDate
        {
            get
            {
                return sm_FilterByDate;
            }
        }

        public static LikesFilter FilterByLikesCount
        {
            get
            {
                return sm_FilterByLikesCount;
            }
        }

        public static FacebookObjectCollection<Post> FilterPostsByDate(FacebookObjectCollection<Post> i_PostsToFilter, DateTime i_Threshold)
        {
            FacebookObjectCollection<Post> filteredPosts = new FacebookObjectCollection<Post>();

            foreach (Post currentPost in i_PostsToFilter)
            {
                if (sm_FilterByDate.FilterBy(currentPost, i_Threshold))
                {
                    filteredPosts.Add(currentPost);
                }
            }

            return filteredPosts;
        }

        public static FacebookObjectCollection<Post> FilterPostsByLikesCount(FacebookObjectCollection<Post> i_PostsToFilter, int i_Threshold)
        {
            FacebookObjectCollection<Post> filteredPosts = new FacebookObjectCollection<Post>();

            foreach (Post currentPost in i_PostsToFilter)
            {
                if (sm_FilterByLikesCount.FilterBy(currentPost, i_Threshold))
                {
                    filteredPosts.Add(currentPost);
                }
            }

            return filteredPosts;
        }

        public enum eFilterComparisonType
        {
            Equal = 1,
            Greater,
            Lower,
        }

    }
}