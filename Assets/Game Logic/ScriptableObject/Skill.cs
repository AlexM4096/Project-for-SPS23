using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Scriptable Object/Skill", order = 1)]
public class Skill: Consequence
{
    [Header("Build")]
    public BuildingData Data;
}
