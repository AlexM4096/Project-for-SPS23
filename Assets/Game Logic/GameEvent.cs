using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

[CreateAssetMenu(fileName = "New Game Event", menuName = "Scriptable Object/GameEvent", order = 1)]
public class GameEvent : ScriptableObject
{
    public string title;
    public string description;

    [Header("")]
    public bool randomEvent = true;
    public int2 range;

    [Header("")]
    public Consequence[] choices;
}