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

    public static bool BrushedTeeth;

    public static bool brushedTeeth
    {
        get
        {
            return BrushedTeeth;
        }

        set
        {
            BrushedTeeth = value;
        }
    }

    public static bool IsShowered;

    public static bool isShowered
    {
        get
        {
            return IsShowered;
        }

        set
        {
            IsShowered = value;
        }
    }

    public static float PlayerXCoord;

    public static float playerXCoord
    {
        get
        {
            return PlayerXCoord;
        }

        set
        {
            PlayerXCoord = value;
        }
    }

    public static float PlayerZCoord;

    public static float playerZCoord
    {
        get
        {
            return PlayerZCoord;
        }

        set
        {
            PlayerZCoord = value;
        }
    }

    public static float PlayerYCoord;

    public static float playerYCoord
    {
        get
        {
            return PlayerYCoord;
        }

        set
        {
            PlayerYCoord = value;
        }
    }

}
