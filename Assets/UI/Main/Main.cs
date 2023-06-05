using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Main : MonoBehaviour
{
    [SerializeField] VisualTreeAsset Building;
    VisualElement Root;

    Dictionary<string, TextElement> Stats;
    Label Days;

    VisualElement BW;
    bool BWIsVisible = false;

    string[] statNames =
    {
         "Intelligence",
         "MentalHealth",
         "PhysicalHealth",
         "Finance",
         "Socialization",
         "Creativity",
    };

    private void Start()
    {
        Stats = new Dictionary<string, TextElement>();
        Root = GetComponent<UIDocument>().rootVisualElement;

        foreach (string statName in statNames)
            Stats.Add(statName, Root.Q(statName).Q<TextElement>());

        Root.Q<Button>("Pause").clicked += GameTime.TimePause;
        Root.Q<Button>("x1").clicked += () => GameTime.TimeBoost(1);
        Root.Q<Button>("x2").clicked += () => GameTime.TimeBoost(2);
        Root.Q<Button>("x4").clicked += () => GameTime.TimeBoost(4);

        BW = Root.Q("Hide");
        Root.Q<Button>("BW").clicked += Switch;

        Days = Root.Q<Label>("Days");
    }

    private void Update()
    {
        Stats["Intelligence"].text = PlayerProperty.PlayerStats.Intelligence.ToString();
        Stats["MentalHealth"].text = PlayerProperty.PlayerStats.MentalHealth.ToString();
        Stats["PhysicalHealth"].text = PlayerProperty.PlayerStats.PhysicalHealth.ToString();
        Stats["Finance"].text = PlayerProperty.PlayerStats.Finance.ToString();
        Stats["Socialization"].text = PlayerProperty.PlayerStats.Socialization.ToString();
        Stats["Creativity"].text = PlayerProperty.PlayerStats.Creativity.ToString();

        Days.text = GameTime.currentTime.ToString() + " days";
    }

    void Switch()
    {
        BWIsVisible = !BWIsVisible;
        GridManager.Instance.InBuildingMode = BWIsVisible;
        if (BWIsVisible)
            BW.style.display = DisplayStyle.Flex;
        else
            BW.style.display = DisplayStyle.None;
    }
}
