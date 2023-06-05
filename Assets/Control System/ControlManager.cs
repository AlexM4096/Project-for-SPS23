using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    static public ControlManager Instance;

    Camera MainCamera;

    ControlAction InputActions;
    public Vector2 PointerPos { get; private set; }
    public Action OnPointerClick;


    private void Awake()
    {
        Instance = this;

        MainCamera = Camera.main;
        InputActions = new();
    }

    private void Start()
    {
        InputActions.Enable();
        InputActions.Pointer.Click.started += _ => OnPointerClick?.Invoke();
    }

    private void Update()
    {
        SetPointerPosition();
    }

    void SetPointerPosition()
    {
        Vector2 LocalPointerPos = InputActions.Pointer.Position.ReadValue<Vector2>();
        PointerPos = MainCamera.ScreenToWorldPoint(LocalPointerPos);
    }
}
