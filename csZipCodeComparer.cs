using System;
using System.Collections.Generic;

public class clsZipCodeComparer : IComparer<clsZipCode>
{
    private bool mIsAscending = false;
    private bool mFilterByState = false;

    public clsZipCodeComparer(bool isAscending, bool filterByState)
    {
        mIsAscending = isAscending;
        mFilterByState = filterByState;
    }

    int IComparer<clsZipCode>.Compare(clsZipCode zc1, clsZipCode zc2)
    {
        // When filtering by state
        if (mFilterByState == true)
        {
            if (String.Compare(zc1.State, zc2.State) < 0)
            {
                return -1;
            }
            else if (String.Compare(zc1.State, zc2.State) > 0)
            {
                return 1;
            }
        }

        // When filtering by zipcode
        if (String.Compare(zc1.ZipCode, zc2.ZipCode) < 0)
        {
            if (mIsAscending == true)
            {
                return -1;
            }
            return 1;
        }
        else if (String.Compare(zc1.ZipCode, zc2.ZipCode) > 0)
        {
            if (mIsAscending == true)
            {
                return 1;
            }
            return -1;
        }
        return 0;
    }
}