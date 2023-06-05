using UnityEngine;

[CreateAssetMenu(fileName = "New Buff", menuName = "Scriptable Object/Buff", order = 1)]
public class Buff : Consequence
{
    [Header("Player Property")] 
    public Stats Stats;
}