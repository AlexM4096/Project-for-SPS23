using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Event : MonoBehaviour
{
    VisualElement Root;
    VisualElement Choices;

    private void Awake()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;
        Choices = Root.Q("Choices");
    }
}
