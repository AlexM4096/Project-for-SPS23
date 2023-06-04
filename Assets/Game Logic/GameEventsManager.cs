using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public static class GameEventsManager
{
    public static List<GameEvent> events;
    public static int timeEvents;

    public static void LoadEvents()
    {
        events = new List<GameEvent>(Resources.FindObjectsOfTypeAll<GameEvent>());
    }

    public static void StartTimeEvents()
    {
        int2 eventsRange = GameManager.currentManager.eventsRange;
        timeEvents = UnityEngine.Random.Range(eventsRange.x, eventsRange.y + 1);
    }

    public static void CheckEvents()
    {
        int cTime = GameTime.GetInt();

        //Проверка обязательных событий
        for (int i = 0; i < events.Count; i++)
        {
            if(cTime == events[i].range.x && !events[i].randomEvent)
            {
                StartEvent(events[i]);
                events.Remove(events[i]);
            }
        }

        //Проверка необязательных событий
        if (cTime == timeEvents)
        {
            List<GameEvent> currentEvents = new List<GameEvent>();

            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].randomEvent && events[i].range.x <= cTime && events[i].range.y >= cTime)
                {
                    currentEvents.Add(events[i]);
                }
            }

            if(currentEvents.Count != 0) StartEvent(currentEvents[UnityEngine.Random.Range(0, currentEvents.Count)]);

            int2 eventsRange = GameManager.currentManager.eventsRange;
            timeEvents += UnityEngine.Random.Range(eventsRange.x, eventsRange.y + 1);
        }
    }

    private static void StartEvent(GameEvent _event)
    {
        GameTime.TimePause();
        //Передать событие в UI систему
    }
}
