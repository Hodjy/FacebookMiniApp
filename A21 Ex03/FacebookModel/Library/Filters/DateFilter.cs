using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03
{
    internal class DateFilter
    {
        private IFilterStrategy<DateTime?, DateTime> m_FilterLogic = new DateFilterLogic();

        internal DateFilter()
        {

        }

        internal IFilterStrategy<DateTime?, DateTime> FilterLogic
        {
            get
            {
                return m_FilterLogic;
            }
        }

        public FacebookObjectCollection<Post> Filter(FacebookObjectCollection<Post> i_PostsToFilter, DateTime i_Threshold)
        {
            FacebookObjectCollection<Post> filteredPosts = new FacebookObjectCollection<Post>();

            foreach (Post currentPost in i_PostsToFilter)
            {
                if (m_FilterLogic.CalculateIsApprovedByThreshold(currentPost.CreatedTime, i_Threshold))
                {
                    filteredPosts.Add(currentPost);
                }
            }

            return filteredPosts;
        }
    }
}
