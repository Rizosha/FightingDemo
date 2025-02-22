//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Controls/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""79d94439-52b9-4183-a524-bf354dc40ede"",
            ""actions"": [
                {
                    ""name"": ""SidestepUp"",
                    ""type"": ""Button"",
                    ""id"": ""644d9b02-e24d-4d26-8e42-eefb7f5b25b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SidestepDown"",
                    ""type"": ""Button"",
                    ""id"": ""f7650f0a-d273-4030-9ec6-32f14ca4de7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""09af9269-87e0-4cd4-8c26-add1461f54f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Backward"",
                    ""type"": ""Button"",
                    ""id"": ""6a05dd4e-f837-44bf-bf3d-88740a356a21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7f65144f-539d-475c-9551-6bc6d7f42462"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""SidestepUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a97a08ec-fdcb-4d2c-bb1b-32cc14659e58"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""SidestepDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9d46fb7-63e9-49bd-a76a-9120870f551f"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef22da8b-6b3f-4cfe-94fa-1eb5e7b74f83"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AttackButton"",
            ""id"": ""3987e3ef-79bb-475b-b627-0ea16351b56c"",
            ""actions"": [
                {
                    ""name"": ""LeftPunch"",
                    ""type"": ""Button"",
                    ""id"": ""f4c6947d-8d43-4db1-9633-99db1edae00f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightPunch"",
                    ""type"": ""Button"",
                    ""id"": ""cc33627d-3597-4a44-81cc-16e77cca9b4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftKick"",
                    ""type"": ""Button"",
                    ""id"": ""890aaec3-2fd5-474f-b67f-46c27afbe6e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightKick"",
                    ""type"": ""Button"",
                    ""id"": ""5723a8b1-c8df-4952-a418-31158fe0d379"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0b9157dc-58cb-47a0-a955-c00a3d0e50fb"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerControls"",
                    ""action"": ""LeftPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3927f657-eee3-40c2-9a5e-3fafce114076"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa4e2086-327d-4723-9a36-b967371affc4"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5eef256-723d-40e4-9fb8-7cddd46fb172"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PlayerControls"",
            ""bindingGroup"": ""PlayerControls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_SidestepUp = m_Movement.FindAction("SidestepUp", throwIfNotFound: true);
        m_Movement_SidestepDown = m_Movement.FindAction("SidestepDown", throwIfNotFound: true);
        m_Movement_Forward = m_Movement.FindAction("Forward", throwIfNotFound: true);
        m_Movement_Backward = m_Movement.FindAction("Backward", throwIfNotFound: true);
        // AttackButton
        m_AttackButton = asset.FindActionMap("AttackButton", throwIfNotFound: true);
        m_AttackButton_LeftPunch = m_AttackButton.FindAction("LeftPunch", throwIfNotFound: true);
        m_AttackButton_RightPunch = m_AttackButton.FindAction("RightPunch", throwIfNotFound: true);
        m_AttackButton_LeftKick = m_AttackButton.FindAction("LeftKick", throwIfNotFound: true);
        m_AttackButton_RightKick = m_AttackButton.FindAction("RightKick", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_SidestepUp;
    private readonly InputAction m_Movement_SidestepDown;
    private readonly InputAction m_Movement_Forward;
    private readonly InputAction m_Movement_Backward;
    public struct MovementActions
    {
        private @PlayerControls m_Wrapper;
        public MovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SidestepUp => m_Wrapper.m_Movement_SidestepUp;
        public InputAction @SidestepDown => m_Wrapper.m_Movement_SidestepDown;
        public InputAction @Forward => m_Wrapper.m_Movement_Forward;
        public InputAction @Backward => m_Wrapper.m_Movement_Backward;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @SidestepUp.started += instance.OnSidestepUp;
            @SidestepUp.performed += instance.OnSidestepUp;
            @SidestepUp.canceled += instance.OnSidestepUp;
            @SidestepDown.started += instance.OnSidestepDown;
            @SidestepDown.performed += instance.OnSidestepDown;
            @SidestepDown.canceled += instance.OnSidestepDown;
            @Forward.started += instance.OnForward;
            @Forward.performed += instance.OnForward;
            @Forward.canceled += instance.OnForward;
            @Backward.started += instance.OnBackward;
            @Backward.performed += instance.OnBackward;
            @Backward.canceled += instance.OnBackward;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @SidestepUp.started -= instance.OnSidestepUp;
            @SidestepUp.performed -= instance.OnSidestepUp;
            @SidestepUp.canceled -= instance.OnSidestepUp;
            @SidestepDown.started -= instance.OnSidestepDown;
            @SidestepDown.performed -= instance.OnSidestepDown;
            @SidestepDown.canceled -= instance.OnSidestepDown;
            @Forward.started -= instance.OnForward;
            @Forward.performed -= instance.OnForward;
            @Forward.canceled -= instance.OnForward;
            @Backward.started -= instance.OnBackward;
            @Backward.performed -= instance.OnBackward;
            @Backward.canceled -= instance.OnBackward;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // AttackButton
    private readonly InputActionMap m_AttackButton;
    private List<IAttackButtonActions> m_AttackButtonActionsCallbackInterfaces = new List<IAttackButtonActions>();
    private readonly InputAction m_AttackButton_LeftPunch;
    private readonly InputAction m_AttackButton_RightPunch;
    private readonly InputAction m_AttackButton_LeftKick;
    private readonly InputAction m_AttackButton_RightKick;
    public struct AttackButtonActions
    {
        private @PlayerControls m_Wrapper;
        public AttackButtonActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftPunch => m_Wrapper.m_AttackButton_LeftPunch;
        public InputAction @RightPunch => m_Wrapper.m_AttackButton_RightPunch;
        public InputAction @LeftKick => m_Wrapper.m_AttackButton_LeftKick;
        public InputAction @RightKick => m_Wrapper.m_AttackButton_RightKick;
        public InputActionMap Get() { return m_Wrapper.m_AttackButton; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackButtonActions set) { return set.Get(); }
        public void AddCallbacks(IAttackButtonActions instance)
        {
            if (instance == null || m_Wrapper.m_AttackButtonActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_AttackButtonActionsCallbackInterfaces.Add(instance);
            @LeftPunch.started += instance.OnLeftPunch;
            @LeftPunch.performed += instance.OnLeftPunch;
            @LeftPunch.canceled += instance.OnLeftPunch;
            @RightPunch.started += instance.OnRightPunch;
            @RightPunch.performed += instance.OnRightPunch;
            @RightPunch.canceled += instance.OnRightPunch;
            @LeftKick.started += instance.OnLeftKick;
            @LeftKick.performed += instance.OnLeftKick;
            @LeftKick.canceled += instance.OnLeftKick;
            @RightKick.started += instance.OnRightKick;
            @RightKick.performed += instance.OnRightKick;
            @RightKick.canceled += instance.OnRightKick;
        }

        private void UnregisterCallbacks(IAttackButtonActions instance)
        {
            @LeftPunch.started -= instance.OnLeftPunch;
            @LeftPunch.performed -= instance.OnLeftPunch;
            @LeftPunch.canceled -= instance.OnLeftPunch;
            @RightPunch.started -= instance.OnRightPunch;
            @RightPunch.performed -= instance.OnRightPunch;
            @RightPunch.canceled -= instance.OnRightPunch;
            @LeftKick.started -= instance.OnLeftKick;
            @LeftKick.performed -= instance.OnLeftKick;
            @LeftKick.canceled -= instance.OnLeftKick;
            @RightKick.started -= instance.OnRightKick;
            @RightKick.performed -= instance.OnRightKick;
            @RightKick.canceled -= instance.OnRightKick;
        }

        public void RemoveCallbacks(IAttackButtonActions instance)
        {
            if (m_Wrapper.m_AttackButtonActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IAttackButtonActions instance)
        {
            foreach (var item in m_Wrapper.m_AttackButtonActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_AttackButtonActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public AttackButtonActions @AttackButton => new AttackButtonActions(this);
    private int m_PlayerControlsSchemeIndex = -1;
    public InputControlScheme PlayerControlsScheme
    {
        get
        {
            if (m_PlayerControlsSchemeIndex == -1) m_PlayerControlsSchemeIndex = asset.FindControlSchemeIndex("PlayerControls");
            return asset.controlSchemes[m_PlayerControlsSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnSidestepUp(InputAction.CallbackContext context);
        void OnSidestepDown(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnBackward(InputAction.CallbackContext context);
    }
    public interface IAttackButtonActions
    {
        void OnLeftPunch(InputAction.CallbackContext context);
        void OnRightPunch(InputAction.CallbackContext context);
        void OnLeftKick(InputAction.CallbackContext context);
        void OnRightKick(InputAction.CallbackContext context);
    }
}
