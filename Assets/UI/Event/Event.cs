using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Event : MonoBehaviour
{
    public VisualTreeAsset ChoiceBlank;

    VisualElement Root;
    VisualElement Choices;

    private void Awake()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        Debug.Log(Root != null);
        Choices = Root.Q("Choices");

        Choices.Add(ChoiceBlank.CloneTree());
        Choices.Add(ChoiceBlank.CloneTree());
    }
}
