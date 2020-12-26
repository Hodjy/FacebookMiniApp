using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    internal static class FacebookFilters
    {
        public static FacebookObjectCollection<Post> FilterPostsByDate(FacebookObjectCollection<Post> i_PostsToFilter, DateTime i_DateToFilterBy)
        {
            FacebookObjectCollection<Post> filteredPosts = new FacebookObjectCollection<Post>();

            foreach (Post currentPost in i_PostsToFilter)
            {
                if (currentPost.CreatedTime >= i_DateToFilterBy)
                {
                    filteredPosts.Add(currentPost);
                }
            }

            return filteredPosts;
        }

        public static FacebookObjectCollection<Post> FilterPostsByLikesCount(FacebookObjectCollection<Post> i_PostsToFilter, int i_MinLikesCount)
        {
            FacebookObjectCollection<Post> filteredPosts = new FacebookObjectCollection<Post>();

            foreach (Post currentPost in i_PostsToFilter)
            {
                if (currentPost.LikedBy.Count >= i_MinLikesCount)
                {
                    filteredPosts.Add(currentPost);
                }
            }

            return filteredPosts;
        }
    }
}