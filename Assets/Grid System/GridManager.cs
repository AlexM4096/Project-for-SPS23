using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    static public GridManager Instance;

    public Tilemap MainTilemap;
    public Tilemap EffectTilemap;

    public TileBase HighlightTile;
    public TileBase SelectTile;

    ControlManager Controls;

    Vector3Int PointerGridPos;
    Vector3Int HighlightedTilePos;
    Vector3Int SelectedTilePos;

    public bool InBuildingMode;
    [SerializeField] private BuildingData Data;

    Dictionary<Vector3Int, BuildingData> PlacedTiles;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Controls = ControlManager.Instance;
        Controls.OnPointerClick += Click;

        PlacedTiles = new Dictionary<Vector3Int, BuildingData>();
    }

    private void Update()
    {
        SetPointerPosOnGrid();

        if (InBuildingMode)        
            SetSelectedTile();
        else
            SetHighlightedTile();
    }

    void Click()
    {
        if (InBuildingMode)
            AddBuilding(Data);
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

    void SetSelectedTile()
    {
        if (SelectedTilePos == PointerGridPos) return;

        EffectTilemap.SetTile(SelectedTilePos, null);

        TileBase Tile = EffectTilemap.GetTile(PointerGridPos);
        if (Tile != null) return;

        EffectTilemap.SetTile(PointerGridPos, SelectTile);
        SelectedTilePos = PointerGridPos;
    }

    void AddBuilding(BuildingData Data)
    {
        if (Data == null) return;
        if (PlacedTiles.ContainsKey(PointerGridPos)) return;

        PlacedTiles.Add(PointerGridPos, Data);

        GameObject go = Instantiate(Data.Prefab);
        Vector3 goPos = MainTilemap.CellToWorld(PointerGridPos);
        goPos.z = goPos.y;
        go.transform.position = goPos;

        BuildingManager.Instance.Buildings.Enqueue(Data);
    }
}
