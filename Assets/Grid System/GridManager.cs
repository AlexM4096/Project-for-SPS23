using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    public TileBase HighlightTile;
    public Tilemap MainTilemap;
    public Tilemap EffectTilemap;

    ControlManager Controls;

    Vector3Int PointerGridPos;
    Vector3Int HighlightedTilePos;

    public bool InBuildingMode;
    [SerializeField] private BuildingData Data;

    Dictionary<Vector3Int, BuildingData> PlacedTiles;

    private void Awake()
    {
        Controls = ControlManager.Instance;
        PlacedTiles = new Dictionary<Vector3Int, BuildingData>();
    }

    private void OnEnable()
    {
        Controls.OnPointerClick += Click;
    }

    private void OnDisable()
    {
        Controls.OnPointerClick -= Click;
    }

    private void Update()
    {
        if (InBuildingMode)
        {
            SetPointerPosOnGrid();
            SetHighlightedTile();
        }      
    }

    void Click()
    {
        if (InBuildingMode)
            Build(Data);
    }

    void SetPointerPosOnGrid()
    {
        Vector3 WorldPointerPos = ControlManager.Instance.PointerPos;
        WorldPointerPos.z = 0;
        PointerGridPos = MainTilemap.WorldToCell(WorldPointerPos);
    }

    void SetHighlightedTile()
    {
        if (HighlightedTilePos == PointerGridPos) return;

        EffectTilemap.SetTile(HighlightedTilePos, null);

        TileBase Tile = EffectTilemap.GetTile(PointerGridPos);
        if (Tile != null) return;

        EffectTilemap.SetTile(PointerGridPos, HighlightTile);
        HighlightedTilePos = PointerGridPos;
    }

    void Build(BuildingData Data)
    {
        if (PlacedTiles.ContainsKey(PointerGridPos)) return;

        PlacedTiles.Add(PointerGridPos, Data);

        GameObject go = Instantiate(Data.Prefab);
        go.transform.position = MainTilemap.CellToWorld(PointerGridPos);
    }
}
