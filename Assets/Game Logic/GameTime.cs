using System.Collections;
using UnityEngine;

public static class GameTime
{
    public static int currentTime = 0; //В днях
    public static int multiplyTime = 1;

    public static int DaysPerSecond = 1;

    static float Delta = 0;

    public static void Start()
    {
        currentTime = 0;
    }

    public static void FixedUpdate()
    {
        Delta += Time.fixedDeltaTime * multiplyTime * DaysPerSecond;

        if (Delta > 1)
        {
            currentTime += Mathf.FloorToInt(Delta);
            Delta--;
            //Debug.Log(currentTime);
        }
    }

    public static void TimePause()
    {
        multiplyTime = 0;
    }

    public static void TimeBoost(int value)
    {
        multiplyTime = value;
    }

    public static int GetYears => currentTime / 365;
}
