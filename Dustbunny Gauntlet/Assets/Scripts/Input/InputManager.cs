// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Keyboard"",
            ""id"": ""c9de2304-057e-4624-964f-9b3837d89fda"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""f1419179-d327-42ed-bda4-2898603a47b9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""1f6f5703-04b4-4136-ac4e-5c38db0b4cb7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""94f075b1-4007-409c-bbae-0a23392a2186"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""d04df3ff-a01d-4740-ac84-2ff4594bd9fd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Click"",
                    ""type"": ""Button"",
                    ""id"": ""7f380f2f-7e38-4b95-88c5-2994fadfefd5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Click"",
                    ""type"": ""Button"",
                    ""id"": ""37af04d8-7e15-4303-aaee-4592351b708e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0fdcfd9b-4e75-4916-bfd6-778fd6f8cef4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""466f4306-0f3d-4e10-ace7-ca99d060097c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4eb2448e-31c0-4ed1-beb1-a62ccad65c52"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cc54397-85ce-4ba6-be84-aa0dc4d65b4e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1621d8e7-4319-4527-a783-9045a456db2d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1a72144-7927-435a-8c27-7230c67cc3e6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_Up = m_Keyboard.FindAction("Up", throwIfNotFound: true);
        m_Keyboard_Down = m_Keyboard.FindAction("Down", throwIfNotFound: true);
        m_Keyboard_Left = m_Keyboard.FindAction("Left", throwIfNotFound: true);
        m_Keyboard_Right = m_Keyboard.FindAction("Right", throwIfNotFound: true);
        m_Keyboard_LeftClick = m_Keyboard.FindAction("Left Click", throwIfNotFound: true);
        m_Keyboard_RightClick = m_Keyboard.FindAction("Right Click", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_Up;
    private readonly InputAction m_Keyboard_Down;
    private readonly InputAction m_Keyboard_Left;
    private readonly InputAction m_Keyboard_Right;
    private readonly InputAction m_Keyboard_LeftClick;
    private readonly InputAction m_Keyboard_RightClick;
    public struct KeyboardActions
    {
        private @InputManager m_Wrapper;
        public KeyboardActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Keyboard_Up;
        public InputAction @Down => m_Wrapper.m_Keyboard_Down;
        public InputAction @Left => m_Wrapper.m_Keyboard_Left;
        public InputAction @Right => m_Wrapper.m_Keyboard_Right;
        public InputAction @LeftClick => m_Wrapper.m_Keyboard_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_Keyboard_RightClick;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @LeftClick.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightClick;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IKeyboardActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
    }
}
