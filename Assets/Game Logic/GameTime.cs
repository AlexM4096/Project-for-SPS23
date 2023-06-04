using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    public float currentTime = 0;
    public float multiplyTime = 1;

    private void Update()
    {
        currentTime += Time.deltaTime * multiplyTime;
    }

    public void TimePause()
    {
        multiplyTime = 0;
    }

    public void TimeBoost(float value)
    {
        multiplyTime = value;
    }

    public void TimeNormalize()
    {
        multiplyTime = 1;
    }
}
