using System;

namespace A21_Ex03
{
    internal class DateFilterLogic : IFilterStrategy<DateTime?, DateTime>
    {
        internal DateFilterLogic()
        {
        }

        public Func<DateTime?, DateTime, bool> FilterStrategy // Recieved Date must be nullable, therefore we expect one.
        {
            get;
            set;
        }

        public bool CalculateIsApprovedByThreshold(DateTime? i_PostDateToCheck, DateTime i_FilterThreshhold)
        {
            return FilterStrategy.Invoke(i_PostDateToCheck, i_FilterThreshhold);
        }
    }
}
