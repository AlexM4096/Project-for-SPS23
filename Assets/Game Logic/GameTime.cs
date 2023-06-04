using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameTime
{
    public static float currentTime = 0; //В днях
    public static float multiplyTime = 1;

    public static void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime * multiplyTime;
    }

    public static void TimePause()
    {
        multiplyTime = 0;
    }

    public static void TimeBoost(float value)
    {
        multiplyTime = value;
    }

    public static void TimeNormalize()
    {
        multiplyTime = 1;
    }

    public static int GetInt()
    {
        return Mathf.RoundToInt(currentTime);
    }
}
