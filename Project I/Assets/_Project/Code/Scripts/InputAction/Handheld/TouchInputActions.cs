//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/_Project/Code/Scripts/InputAction/TouchControls/TouchInputActions.inputactions
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

namespace Wonderland.InputActions
{
    public partial class @TouchInputActions : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TouchInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchInputActions"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""60ecc5fd-9206-4171-90c7-7f4e63649209"",
            ""actions"": [
                {
                    ""name"": ""PrimaryFingerValue"",
                    ""type"": ""Value"",
                    ""id"": ""74bdae08-4852-4f17-a157-fe9512549f7b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryFingerValue"",
                    ""type"": ""Value"",
                    ""id"": ""23654dae-687d-4fef-8fc1-353f253429b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryTouchButton"",
                    ""type"": ""Button"",
                    ""id"": ""9bf22dd6-e07f-4a5f-a50f-d277775c0a2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7bb492c-f41a-43b8-bd64-382b7d9d0b1d"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFingerValue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a11d5643-0b90-4b4d-9817-d3111c0529d9"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1aa6bd9b-38cf-4b37-b19e-a8bb7cabe060"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerValue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Touch
            m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
            m_Touch_PrimaryFingerValue = m_Touch.FindAction("PrimaryFingerValue", throwIfNotFound: true);
            m_Touch_SecondaryFingerValue = m_Touch.FindAction("SecondaryFingerValue", throwIfNotFound: true);
            m_Touch_SecondaryTouchButton = m_Touch.FindAction("SecondaryTouchButton", throwIfNotFound: true);
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

        // Touch
        private readonly InputActionMap m_Touch;
        private ITouchActions m_TouchActionsCallbackInterface;
        private readonly InputAction m_Touch_PrimaryFingerValue;
        private readonly InputAction m_Touch_SecondaryFingerValue;
        private readonly InputAction m_Touch_SecondaryTouchButton;
        public struct TouchActions
        {
            private @TouchInputActions m_Wrapper;
            public TouchActions(@TouchInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @PrimaryFingerValue => m_Wrapper.m_Touch_PrimaryFingerValue;
            public InputAction @SecondaryFingerValue => m_Wrapper.m_Touch_SecondaryFingerValue;
            public InputAction @SecondaryTouchButton => m_Wrapper.m_Touch_SecondaryTouchButton;
            public InputActionMap Get() { return m_Wrapper.m_Touch; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
            public void SetCallbacks(ITouchActions instance)
            {
                if (m_Wrapper.m_TouchActionsCallbackInterface != null)
                {
                    @PrimaryFingerValue.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerValue;
                    @PrimaryFingerValue.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerValue;
                    @PrimaryFingerValue.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerValue;
                    @SecondaryFingerValue.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerValue;
                    @SecondaryFingerValue.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerValue;
                    @SecondaryFingerValue.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerValue;
                    @SecondaryTouchButton.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchButton;
                    @SecondaryTouchButton.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchButton;
                    @SecondaryTouchButton.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchButton;
                }
                m_Wrapper.m_TouchActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PrimaryFingerValue.started += instance.OnPrimaryFingerValue;
                    @PrimaryFingerValue.performed += instance.OnPrimaryFingerValue;
                    @PrimaryFingerValue.canceled += instance.OnPrimaryFingerValue;
                    @SecondaryFingerValue.started += instance.OnSecondaryFingerValue;
                    @SecondaryFingerValue.performed += instance.OnSecondaryFingerValue;
                    @SecondaryFingerValue.canceled += instance.OnSecondaryFingerValue;
                    @SecondaryTouchButton.started += instance.OnSecondaryTouchButton;
                    @SecondaryTouchButton.performed += instance.OnSecondaryTouchButton;
                    @SecondaryTouchButton.canceled += instance.OnSecondaryTouchButton;
                }
            }
        }
        public TouchActions @Touch => new TouchActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_TouchSchemeIndex = -1;
        public InputControlScheme TouchScheme
        {
            get
            {
                if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
                return asset.controlSchemes[m_TouchSchemeIndex];
            }
        }
        private int m_JoystickSchemeIndex = -1;
        public InputControlScheme JoystickScheme
        {
            get
            {
                if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
                return asset.controlSchemes[m_JoystickSchemeIndex];
            }
        }
        private int m_XRSchemeIndex = -1;
        public InputControlScheme XRScheme
        {
            get
            {
                if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
                return asset.controlSchemes[m_XRSchemeIndex];
            }
        }
        public interface ITouchActions
        {
            void OnPrimaryFingerValue(InputAction.CallbackContext context);
            void OnSecondaryFingerValue(InputAction.CallbackContext context);
            void OnSecondaryTouchButton(InputAction.CallbackContext context);
        }
    }
}
