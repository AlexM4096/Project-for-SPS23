using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "Building", menuName = "Scriptable Object/Building")]
public class BuildingData : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    [TextArea] public string Description;
    public GameObject Prefab;
}
