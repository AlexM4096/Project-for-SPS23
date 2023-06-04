using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Buff", menuName = "GameFiles/Buff", order = 1)]
public class Buff : ScriptableObject
{
    public string title;
    public string description;

    [Header("Player Property")] 
    public byte intelligence;
    public byte mentality;
    public byte physique;
    public byte finance;
}
