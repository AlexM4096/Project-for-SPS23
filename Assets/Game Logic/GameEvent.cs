using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : ScriptableObject
{
    public string title;
    public string description;
    public GameEventChoice[] choices;
}

[System.Serializable]
public class GameEventChoice
{
    public string title;
    public GameEventBuffs[] buffs;
}

[System.Serializable]
public class GameEventBuffs
{
    public Buff buff;
    public int chance;
}
