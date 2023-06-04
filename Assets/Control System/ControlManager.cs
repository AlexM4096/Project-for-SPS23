using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    static public ControlManager Instance;

    private void Awake()
    {
        Instance = this;
    }
}
