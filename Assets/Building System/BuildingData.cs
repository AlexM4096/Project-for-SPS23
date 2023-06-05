using UnityEngine;

[CreateAssetMenu(fileName = "New Building", menuName = "Scriptable Object/Building")]
public class BuildingData : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    public GameObject Prefab;
    public int price;
    public Stats Stats;
}
