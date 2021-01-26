using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    internal class LikesFilter
    {
        private IFilterStrategy<int, int>  m_FilterLogic = new LikesFilterLogic();

        internal LikesFilter()
        {

        }

        public IFilterStrategy<int, int> FilterLogic
        {
            get
            {
                return m_FilterLogic;
            }
        }

        public FacebookObjectCollection<Post> Filter(FacebookObjectCollection<Post> i_PostsToFilter, int i_Threshold)
        {
            FacebookObjectCollection<Post> filteredPosts = new FacebookObjectCollection<Post>();

            foreach (Post currentPost in i_PostsToFilter)
            {
                if (m_FilterLogic.CalculateIsApprovedByThreshold(currentPost.LikedBy.Count, i_Threshold))
                {
                    filteredPosts.Add(currentPost);
                }
            }

            return filteredPosts;
        }
    }
}
