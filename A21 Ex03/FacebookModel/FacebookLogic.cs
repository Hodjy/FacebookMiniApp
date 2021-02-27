using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03
{
    public static class FacebookLogic
    {
        private static LoggedInUser sm_LoggedInUser = new LoggedInUser();
        private static readonly string sr_AppID = "3925570110805927";
        private static bool sm_IsUserLoggedIn = false;

        public static LoggedInUser LoggedInUser
        {
            get
            {
                return sm_LoggedInUser;
            }
        }

        public static string LogInUser()
        {
            string loginError = string.Empty;

            loginError = ConnectionManager.LogInUser(sr_AppID);
            sm_LoggedInUser.User = new UserToLoggedInUser(ConnectionManager.LoggedInUser);

            if(loginError == string.Empty)
            {
                sm_IsUserLoggedIn = true;
            }

            return loginError;
        }

        public static void LogOutUser()
        {
            ConnectionManager.LogOutUser();
            sm_IsUserLoggedIn = false;
        }

        public static bool IsUserLoggedIn
        {
            get
            {
                return sm_IsUserLoggedIn;
            }
        }

        public static ISelectedItem ConvertItemToSelectedItem(PostedItem i_PostedItem)
        {
            ISelectedItem selectedItemToReturn = null;

            if (i_PostedItem is Post)
            {
                selectedItemToReturn = new SelectedPost(i_PostedItem as Post);
            }
            else if (i_PostedItem is Photo)
            {
                selectedItemToReturn = new SelectedPhoto(i_PostedItem as Photo);
            }

            return selectedItemToReturn;
        }

        public static bool IsSelectedItemLikedByUser(ISelectedItem i_PostToCheck)
        {
            bool isLiked = false;

            isLiked = i_PostToCheck.isLikedByUser(ConnectionManager.LoggedInUser);

            return isLiked;
        }

        public static FacebookObjectCollection<Post> FilterPostsByDate(FacebookObjectCollection<Post> i_PostsToFilter, DateTime i_DateToFilterBy)
        {
            FacebookObjectCollection<Post> filteredPosts;

            filteredPosts = FacebookFilters.FilterByDate.Filter(i_PostsToFilter, i_DateToFilterBy);

            return filteredPosts;
        }

        public static FacebookObjectCollection<Post> FilterPostsByLikesCount(FacebookObjectCollection<Post> i_PostsToFilter, int i_LikesCount)
        {
            FacebookObjectCollection<Post> filteredPosts;

            filteredPosts = FacebookFilters.FilterByLikesCount.Filter(i_PostsToFilter, i_LikesCount);

            return filteredPosts;
        }

        public static void setLikesFilterComparison(string i_FilterComparisonString)
        {
            switch(i_FilterComparisonString)
            {
                case "<":
                    FacebookFilters.FilterByLikesCount.FilterLogic.FilterStrategy = (num1, num2) => num1 < num2;
                    break;
                case ">":
                    FacebookFilters.FilterByLikesCount.FilterLogic.FilterStrategy = (num1, num2) => num1 > num2;
                    break;
                case "=":
                    FacebookFilters.FilterByLikesCount.FilterLogic.FilterStrategy = (num1, num2) => num1 == num2;
                    break;
            }
        }

        public static void setDateFilterComparison(string i_FilterComparisonString)
        {
            switch (i_FilterComparisonString)
            {
                case "<":
                    FacebookFilters.FilterByDate.FilterLogic.FilterStrategy = (date1, date2) => date1 < date2;
                    break;
                case ">":
                    FacebookFilters.FilterByDate.FilterLogic.FilterStrategy = (date1, date2) => date1 > date2;
                    break;
                case "=":
                    FacebookFilters.FilterByDate.FilterLogic.FilterStrategy = (date1, date2) => date1 == date2;
                    break;
            }
        }
    }
}