// GENERATED AUTOMATICALLY FROM 'Assets/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""groundmovement"",
            ""id"": ""1b5f62af-5ad1-4fac-a61f-2c44a5a5b838"",
            ""actions"": [
                {
                    ""name"": ""horizontalmovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""32172487-ec5b-4553-951b-659cb2535f16"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""6490b6ec-603a-4495-809e-d2ff2f39402d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5eb7493d-ecc9-440c-b6ba-7ffda3529d42"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c905fb11-5e5e-49b0-9b6d-c4760e956ee4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6834e0ad-63a0-4d87-b546-b546fd2ec4ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9c225bdc-30e1-4ecc-9f18-fa15dc0a410f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e0f4a85e-cf41-4fd6-9d9c-ce6bd6d0e2fe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""525baf13-6ff5-4684-97da-768a24b6b116"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4b8ac5d5-50ab-4adc-98c3-533e33f68254"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c0fe7cd2-f78b-40f3-ba1d-1c9842ca6b5c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""21ddcc51-2778-47de-aca7-8381a4c5876a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c9b2a93c-4304-4c8d-b476-9b0d07431e3d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b3c4a24d-670b-40e8-8ddb-87edd6fbf1da"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1645dba2-fd3a-4536-b96f-1b5b8820414b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""horizontalmovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""448538bd-5d64-4055-a4bd-5ac002235532"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49009f6f-d72a-4c02-9c62-d9241805d5db"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8f9550f-c3cd-49d1-8a44-6a80751cb7f6"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // groundmovement
        m_groundmovement = asset.FindActionMap("groundmovement", throwIfNotFound: true);
        m_groundmovement_horizontalmovement = m_groundmovement.FindAction("horizontalmovement", throwIfNotFound: true);
        m_groundmovement_jump = m_groundmovement.FindAction("jump", throwIfNotFound: true);
        m_groundmovement_MouseX = m_groundmovement.FindAction("MouseX", throwIfNotFound: true);
        m_groundmovement_MouseY = m_groundmovement.FindAction("MouseY", throwIfNotFound: true);
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

    // groundmovement
    private readonly InputActionMap m_groundmovement;
    private IGroundmovementActions m_GroundmovementActionsCallbackInterface;
    private readonly InputAction m_groundmovement_horizontalmovement;
    private readonly InputAction m_groundmovement_jump;
    private readonly InputAction m_groundmovement_MouseX;
    private readonly InputAction m_groundmovement_MouseY;
    public struct GroundmovementActions
    {
        private @PlayerControls m_Wrapper;
        public GroundmovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @horizontalmovement => m_Wrapper.m_groundmovement_horizontalmovement;
        public InputAction @jump => m_Wrapper.m_groundmovement_jump;
        public InputAction @MouseX => m_Wrapper.m_groundmovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_groundmovement_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_groundmovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundmovementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundmovementActions instance)
        {
            if (m_Wrapper.m_GroundmovementActionsCallbackInterface != null)
            {
                @horizontalmovement.started -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnHorizontalmovement;
                @horizontalmovement.performed -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnHorizontalmovement;
                @horizontalmovement.canceled -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnHorizontalmovement;
                @jump.started -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnJump;
                @MouseX.started -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_GroundmovementActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_GroundmovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @horizontalmovement.started += instance.OnHorizontalmovement;
                @horizontalmovement.performed += instance.OnHorizontalmovement;
                @horizontalmovement.canceled += instance.OnHorizontalmovement;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
            }
        }
    }
    public GroundmovementActions @groundmovement => new GroundmovementActions(this);
    public interface IGroundmovementActions
    {
        void OnHorizontalmovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
}
