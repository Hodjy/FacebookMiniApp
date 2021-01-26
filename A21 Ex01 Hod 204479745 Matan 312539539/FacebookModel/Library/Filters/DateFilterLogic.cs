using System;

namespace A21_Ex01_Hod_204479745_Matan_312539539
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
