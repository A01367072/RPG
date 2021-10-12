// GENERATED AUTOMATICALLY FROM 'Assets/Midnight Sky by Ivana Carrizalez/Animation/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""TheaMain"",
            ""id"": ""32632bbd-6bf3-4fc5-b40c-cdcd2cd45be0"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""74c55c99-f362-4374-9aa9-7c5c59e14e98"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cd707127-60ac-44e8-b3df-f9dfae904f23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""49145a33-6a2e-421e-85b3-5842f7dfc89e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""594a7f13-85cf-480c-bc88-83403e758d23"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f11de41e-d5aa-4029-b89b-d16bfe685374"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a2b1694c-bc13-4987-a046-7ac8275f0266"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f2807549-9345-48f6-8534-1eea3f09b595"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2eebeb8f-36d7-4a5f-b987-ca4f1bf7b176"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""de70110a-1d15-44ed-b74e-62f38a2bd09e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6a6afd91-505f-42ca-9084-497d19839e91"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""384319fb-17ab-483f-ac82-b965c9b9f26e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae07ece8-04a2-4850-a704-22671fed8170"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TheaMain
        m_TheaMain = asset.FindActionMap("TheaMain", throwIfNotFound: true);
        m_TheaMain_Run = m_TheaMain.FindAction("Run", throwIfNotFound: true);
        m_TheaMain_Jump = m_TheaMain.FindAction("Jump", throwIfNotFound: true);
        m_TheaMain_Camera = m_TheaMain.FindAction("Camera", throwIfNotFound: true);
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

    // TheaMain
    private readonly InputActionMap m_TheaMain;
    private ITheaMainActions m_TheaMainActionsCallbackInterface;
    private readonly InputAction m_TheaMain_Run;
    private readonly InputAction m_TheaMain_Jump;
    private readonly InputAction m_TheaMain_Camera;
    public struct TheaMainActions
    {
        private @PlayerActions m_Wrapper;
        public TheaMainActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_TheaMain_Run;
        public InputAction @Jump => m_Wrapper.m_TheaMain_Jump;
        public InputAction @Camera => m_Wrapper.m_TheaMain_Camera;
        public InputActionMap Get() { return m_Wrapper.m_TheaMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TheaMainActions set) { return set.Get(); }
        public void SetCallbacks(ITheaMainActions instance)
        {
            if (m_Wrapper.m_TheaMainActionsCallbackInterface != null)
            {
                @Run.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Camera.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_TheaMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public TheaMainActions @TheaMain => new TheaMainActions(this);
    public interface ITheaMainActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
}
