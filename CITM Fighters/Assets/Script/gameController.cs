//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Script/gameController.inputactions
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

public partial class @GameController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""gameController"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""d8bd8262-d221-4268-b15b-f2e47214aa8b"",
            ""actions"": [
                {
                    ""name"": ""walkFront"",
                    ""type"": ""Button"",
                    ""id"": ""7f2c22aa-3f56-4a9f-b0fd-263958a31049"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""walkBack"",
                    ""type"": ""Button"",
                    ""id"": ""dbfa22c3-ff74-4056-9c3d-4f9b7228fe5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DodgeHigh"",
                    ""type"": ""Button"",
                    ""id"": ""22e36514-b89f-4e69-9d48-b53478099ee9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DodgeLow"",
                    ""type"": ""Button"",
                    ""id"": ""db777140-5d93-4772-8890-1501be23065e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""QuickAtk"",
                    ""type"": ""Button"",
                    ""id"": ""81f30535-13c1-45ec-a89b-6353bc75b152"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SlowAtk"",
                    ""type"": ""Button"",
                    ""id"": ""9e54f500-dae3-46a4-ac1d-d27d05628826"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Low_quick_atk"",
                    ""type"": ""Button"",
                    ""id"": ""aa68faf1-8337-460c-bcb6-9f04cde2fb27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Low_Slow_atk"",
                    ""type"": ""Button"",
                    ""id"": ""46c17cae-9d3c-4141-abba-c7801e7c7000"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1abba63a-90b6-4105-83be-c20906e2c106"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walkFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2c70dda-9f76-412f-ad73-f3b227c76a95"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walkFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0266cf97-54b6-4e1a-b0e8-f99356d29be4"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/hat/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walkFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""DodgeLow"",
                    ""id"": ""faade8be-d1e4-4d2f-aed4-1efb4201ccb2"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeLow"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""e2788ed5-6a12-47f2-b485-f1fcec754f8f"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeLow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""91188e4a-25ce-47ba-a956-97aa0daba7d5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeLow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""742b25d0-a7d0-400d-b10c-257b4ccb9424"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeLow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""SwitchDodgeLow"",
                    ""id"": ""e605ebca-bd35-46c9-8114-907ac071a421"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeLow"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""d31f2f20-d84d-4c36-8850-5126ebe1062a"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/hat/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeLow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""95704731-96fd-497d-9e71-38583fcc28c6"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeLow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b4eac63f-ada3-4a92-9828-d6a22e99ea98"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuickAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3ebb741-a3d3-48eb-a12f-09d4818d2b26"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuickAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bf9cb7d-6c51-4dcf-a090-5b4eec9bc680"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuickAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f76512a-786e-4adc-8ceb-aef5847d1073"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walkBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5780aa51-0d00-4304-843e-3363e6378395"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walkBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80dcccea-9656-4bd7-a590-df79806a8fcf"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/hat/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""walkBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""quickAtk"",
                    ""id"": ""699d60b2-7da4-4b2e-8b11-44fa36017e31"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_quick_atk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""8bd641eb-07ff-498f-830a-f300837a9f62"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_quick_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""aac94b01-3feb-4273-9ad8-a32cb42983dd"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_quick_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""92502044-be13-409f-ad9b-04f8d32916ba"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_quick_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""SwitchLowQA"",
                    ""id"": ""d20b7283-6866-42f0-bdf7-31077622b106"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_quick_atk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""37ddc5b4-45c6-4d3a-bdb3-c7ec89ab68a0"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_quick_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""de2beafd-ab80-48e4-9553-c859c6977008"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_quick_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3b5074db-d359-48aa-8463-45d997b7e665"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27fc44f9-bae5-45f4-97c2-6fc4e11405d9"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7597663a-8e50-4b19-aa7f-4d805f5b0a93"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Low_Slow_atk"",
                    ""id"": ""b0800a11-81a4-4b63-9a9b-d13163ac8136"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_Slow_atk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""80291bcc-a63d-44c4-a53f-382029f23c86"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_Slow_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""29cd4b19-3e5d-4279-9668-a35cf11f6146"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_Slow_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6248f421-edb7-42b0-940a-b3a14e8408a2"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_Slow_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""SwitchLA"",
                    ""id"": ""f98faa6a-61dd-40c1-b9bf-5f293cecdfcf"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_Slow_atk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""364557a1-8cd8-44d2-bcea-090cd69b9707"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_Slow_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""ab173a3d-ccfd-4fb1-a479-3e8529cf4401"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Low_Slow_atk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DodgeHigh"",
                    ""id"": ""2dfc7e15-548a-47ed-aebd-9cfaaa464ef6"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeHigh"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""300f82c3-9573-43c8-b4ba-f6eca0c08255"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeHigh"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""031e9a99-fb0c-40c4-8fe6-cd5c01014072"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeHigh"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""81d0e224-b7f8-422b-aa60-7cf0672652f3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeHigh"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""SwitchDogeHigh"",
                    ""id"": ""cf360a77-5f73-47c5-ae77-7ecc725d4d32"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeHigh"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""abb2ffe0-6787-4bca-80db-08c3fbc8c7f2"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/hat/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeHigh"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""59ee507e-cfbb-4088-b13e-02f8073c8cac"",
                    ""path"": ""<HID::Nintendo Wireless Gamepad>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeHigh"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_walkFront = m_Player1.FindAction("walkFront", throwIfNotFound: true);
        m_Player1_walkBack = m_Player1.FindAction("walkBack", throwIfNotFound: true);
        m_Player1_DodgeHigh = m_Player1.FindAction("DodgeHigh", throwIfNotFound: true);
        m_Player1_DodgeLow = m_Player1.FindAction("DodgeLow", throwIfNotFound: true);
        m_Player1_QuickAtk = m_Player1.FindAction("QuickAtk", throwIfNotFound: true);
        m_Player1_SlowAtk = m_Player1.FindAction("SlowAtk", throwIfNotFound: true);
        m_Player1_Low_quick_atk = m_Player1.FindAction("Low_quick_atk", throwIfNotFound: true);
        m_Player1_Low_Slow_atk = m_Player1.FindAction("Low_Slow_atk", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private List<IPlayer1Actions> m_Player1ActionsCallbackInterfaces = new List<IPlayer1Actions>();
    private readonly InputAction m_Player1_walkFront;
    private readonly InputAction m_Player1_walkBack;
    private readonly InputAction m_Player1_DodgeHigh;
    private readonly InputAction m_Player1_DodgeLow;
    private readonly InputAction m_Player1_QuickAtk;
    private readonly InputAction m_Player1_SlowAtk;
    private readonly InputAction m_Player1_Low_quick_atk;
    private readonly InputAction m_Player1_Low_Slow_atk;
    public struct Player1Actions
    {
        private @GameController m_Wrapper;
        public Player1Actions(@GameController wrapper) { m_Wrapper = wrapper; }
        public InputAction @walkFront => m_Wrapper.m_Player1_walkFront;
        public InputAction @walkBack => m_Wrapper.m_Player1_walkBack;
        public InputAction @DodgeHigh => m_Wrapper.m_Player1_DodgeHigh;
        public InputAction @DodgeLow => m_Wrapper.m_Player1_DodgeLow;
        public InputAction @QuickAtk => m_Wrapper.m_Player1_QuickAtk;
        public InputAction @SlowAtk => m_Wrapper.m_Player1_SlowAtk;
        public InputAction @Low_quick_atk => m_Wrapper.m_Player1_Low_quick_atk;
        public InputAction @Low_Slow_atk => m_Wrapper.m_Player1_Low_Slow_atk;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer1Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player1ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player1ActionsCallbackInterfaces.Add(instance);
            @walkFront.started += instance.OnWalkFront;
            @walkFront.performed += instance.OnWalkFront;
            @walkFront.canceled += instance.OnWalkFront;
            @walkBack.started += instance.OnWalkBack;
            @walkBack.performed += instance.OnWalkBack;
            @walkBack.canceled += instance.OnWalkBack;
            @DodgeHigh.started += instance.OnDodgeHigh;
            @DodgeHigh.performed += instance.OnDodgeHigh;
            @DodgeHigh.canceled += instance.OnDodgeHigh;
            @DodgeLow.started += instance.OnDodgeLow;
            @DodgeLow.performed += instance.OnDodgeLow;
            @DodgeLow.canceled += instance.OnDodgeLow;
            @QuickAtk.started += instance.OnQuickAtk;
            @QuickAtk.performed += instance.OnQuickAtk;
            @QuickAtk.canceled += instance.OnQuickAtk;
            @SlowAtk.started += instance.OnSlowAtk;
            @SlowAtk.performed += instance.OnSlowAtk;
            @SlowAtk.canceled += instance.OnSlowAtk;
            @Low_quick_atk.started += instance.OnLow_quick_atk;
            @Low_quick_atk.performed += instance.OnLow_quick_atk;
            @Low_quick_atk.canceled += instance.OnLow_quick_atk;
            @Low_Slow_atk.started += instance.OnLow_Slow_atk;
            @Low_Slow_atk.performed += instance.OnLow_Slow_atk;
            @Low_Slow_atk.canceled += instance.OnLow_Slow_atk;
        }

        private void UnregisterCallbacks(IPlayer1Actions instance)
        {
            @walkFront.started -= instance.OnWalkFront;
            @walkFront.performed -= instance.OnWalkFront;
            @walkFront.canceled -= instance.OnWalkFront;
            @walkBack.started -= instance.OnWalkBack;
            @walkBack.performed -= instance.OnWalkBack;
            @walkBack.canceled -= instance.OnWalkBack;
            @DodgeHigh.started -= instance.OnDodgeHigh;
            @DodgeHigh.performed -= instance.OnDodgeHigh;
            @DodgeHigh.canceled -= instance.OnDodgeHigh;
            @DodgeLow.started -= instance.OnDodgeLow;
            @DodgeLow.performed -= instance.OnDodgeLow;
            @DodgeLow.canceled -= instance.OnDodgeLow;
            @QuickAtk.started -= instance.OnQuickAtk;
            @QuickAtk.performed -= instance.OnQuickAtk;
            @QuickAtk.canceled -= instance.OnQuickAtk;
            @SlowAtk.started -= instance.OnSlowAtk;
            @SlowAtk.performed -= instance.OnSlowAtk;
            @SlowAtk.canceled -= instance.OnSlowAtk;
            @Low_quick_atk.started -= instance.OnLow_quick_atk;
            @Low_quick_atk.performed -= instance.OnLow_quick_atk;
            @Low_quick_atk.canceled -= instance.OnLow_quick_atk;
            @Low_Slow_atk.started -= instance.OnLow_Slow_atk;
            @Low_Slow_atk.performed -= instance.OnLow_Slow_atk;
            @Low_Slow_atk.canceled -= instance.OnLow_Slow_atk;
        }

        public void RemoveCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer1Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player1ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player1ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    public interface IPlayer1Actions
    {
        void OnWalkFront(InputAction.CallbackContext context);
        void OnWalkBack(InputAction.CallbackContext context);
        void OnDodgeHigh(InputAction.CallbackContext context);
        void OnDodgeLow(InputAction.CallbackContext context);
        void OnQuickAtk(InputAction.CallbackContext context);
        void OnSlowAtk(InputAction.CallbackContext context);
        void OnLow_quick_atk(InputAction.CallbackContext context);
        void OnLow_Slow_atk(InputAction.CallbackContext context);
    }
}
