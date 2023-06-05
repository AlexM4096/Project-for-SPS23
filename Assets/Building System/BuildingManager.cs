using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    static public BuildingManager Instance;
    public Queue<BuildingData> Buildings;

    BuildingData CurrentBuild;
    int StartTime;

    private void Awake()
    {
        Instance = this;
        Buildings = new Queue<BuildingData>();
    }

    private void FixedUpdate()
    {
        if (CurrentBuild != null)
        {
            if (GameTime.currentTime - StartTime >= CurrentBuild.price)
            {
                PlayerProperty.PlayerStats += CurrentBuild.Stats;
                Debug.Log("Finish " + CurrentBuild.Name);
                NextBuilding();
            }                        
        }
        else
        {
            NextBuilding();   
        }
    }

    void NextBuilding()
    {
        CurrentBuild = null;
        if (Buildings.TryDequeue(out BuildingData data))
        {
            CurrentBuild = data;
            StartTime = GameTime.currentTime;
        }
    }
}
