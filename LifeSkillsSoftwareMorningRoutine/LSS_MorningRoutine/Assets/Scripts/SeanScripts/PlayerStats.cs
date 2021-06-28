using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{


   public static bool IsBoy;
   public static bool isBoy
    {
        get
        {
            return IsBoy;
        }

        set
        {
            IsBoy = value;
        }
    }


    public static bool IsDressed;

    public static bool isDressed
    {
        get
        {
            return IsDressed;
        }

        set
        {
            IsDressed = value;
        }
    }

    public static bool MadeBreakfast;

    public static bool madeBreakfast
    {
        get
        {
            return MadeBreakfast;
        }

        set
        {
            MadeBreakfast = value;
        }
    }
}
