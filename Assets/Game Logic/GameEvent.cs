using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event", menuName = "GameFiles/GameEvent", order = 1)]
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
