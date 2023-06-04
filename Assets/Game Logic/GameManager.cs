using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class GameManager : MonoBehaviour
{
    public static GameManager currentManager;
    public int2 eventsRange;

    private int lastFrameTime;

    private void Start()
    {
        currentManager = this;
        GameTime.currentTime = 0;
        GameEventsManager.LoadEvents();
        GameEventsManager.StartTimeEvents();
    }

    private void Update()
    {
        GameEventsUpdate();
    }

    private void GameEventsUpdate()
    {
        int currentTime = GameTime.GetInt();

        if (currentTime > lastFrameTime) GameEventsManager.CheckEvents();

        lastFrameTime = currentTime;
    }

    private void FixedUpdate()
    {
        GameTime.FixedUpdate();
    }
}
