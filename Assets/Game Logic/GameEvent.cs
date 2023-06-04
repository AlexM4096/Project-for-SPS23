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
    //ƒл€ проверки навыков. 0 - значит, что навык не провер€етс€
    public int intelligence = 0;
    public int mentality = 0;
    public int physique = 0;
    public int finance = 0;

    public string title;
    public GameEventBuffs[] buffs;
}

[System.Serializable]
public class GameEventBuffs
{
    public Buff buff;
    public int chance;
}
