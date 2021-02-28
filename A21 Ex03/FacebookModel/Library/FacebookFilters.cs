namespace A21_Ex03
{
    internal static class FacebookFilters
    {
        private static DateFilter sm_FilterByDate = new DateFilter();
        private static LikesFilter sm_FilterByLikesCount = new LikesFilter();

        internal static DateFilter FilterByDate
        {
            get
            {
                return sm_FilterByDate;
            }
        }

        internal static LikesFilter FilterByLikesCount
        {
            get
            {
                return sm_FilterByLikesCount;
            }
        }
    }
}