﻿using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex03
{
    internal class LikesFilterLogic : IFilterStrategy<int,int>
    {
        internal LikesFilterLogic()
        {
        }

        public Func<int, int, bool> FilterStrategy
        {
            get;
            set;
        }

        public bool CalculateIsApprovedByThreshold(int i_PostLikesCount, int i_FilterThreshold)
        {
            return FilterStrategy.Invoke(i_PostLikesCount, i_FilterThreshold);
        }
    }
}
