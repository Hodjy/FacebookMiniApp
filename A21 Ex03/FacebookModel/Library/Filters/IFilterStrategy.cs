using System;

namespace A21_Ex03
{
    internal interface IFilterStrategy<T1,T2>
    {
        Func<T1, T2, bool> FilterStrategy
        {
            get;
            set;
        }

        bool CalculateIsApprovedByThreshold(T1 i_DataToCheck, T2 i_Threshold);
    }
}
