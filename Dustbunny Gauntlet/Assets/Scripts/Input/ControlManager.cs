using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{

    InputManager manager;

    public bool Up
    {
        get;
        protected set;
    }

    public bool Down
    {
        get;
        protected set;
    }

    public bool Left
    {
        get;
        protected set;
    }

    public bool Right
    {
        get;
        protected set;
    }

    public bool LeftMouse
    {
        get;
        protected set;
    }

    public bool RightMouse
    {
        get;
        protected set;
    }

    private void Awake()
    {
        manager = new InputManager();

        manager.Keyboard.Up.performed += ctx => Up = true;
        manager.Keyboard.Up.canceled += ctx => Up = false;

        manager.Keyboard.Down.performed += ctx => Down = true;
        manager.Keyboard.Down.canceled += ctx =>  Down = false;

        manager.Keyboard.Right.performed += ctx => Right = true;
        manager.Keyboard.Right.canceled += ctx =>  Right = false;

        manager.Keyboard.Left.performed += ctx => Left = true;
        manager.Keyboard.Left.canceled += ctx =>  Left = false;

        manager.Keyboard.LeftClick.performed += ctx => LeftMouse = true;
        manager.Keyboard.LeftClick.canceled += ctx => LeftMouse = false;

        manager.Keyboard.RightClick.performed += ctx => RightMouse = true;
        manager.Keyboard.RightClick.canceled += ctx =>  RightMouse = false;
    }

    private void OnEnable()
    {
        manager.Keyboard.Enable();
    }

    private void OnDisable()
    {
        manager.Keyboard.Disable();
    }

}
