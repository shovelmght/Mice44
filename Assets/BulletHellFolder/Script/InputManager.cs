// GENERATED AUTOMATICALLY FROM 'Assets/BulletHellFolder/Script/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlaneActionControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlaneActionControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Fly"",
            ""id"": ""d2d8af79-88e7-45ee-9dba-45eb947ac5e1"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4ccb8970-824a-4376-8d6d-27432f8d6dbe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e4bf2e93-8c39-411c-a9f7-4d2597ebb369"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""482de8f7-0bba-4630-8923-7e75385bbfb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""30defb36-295d-417b-babf-0f7847a94ed7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b37588e7-4f55-45e6-92c9-4c7cb55ffb20"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""43d3cc48-0695-4aae-ac79-ecde2a75b404"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5e913f31-1423-458c-b47a-a1282ad4e37e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""299a796f-b34c-4c3a-ba88-588583be8067"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""013b4e8d-7c05-4fe7-b700-3acbba4bc710"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dd55817a-5aef-4415-891e-c740d127b9a6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Fly
        m_Fly = asset.FindActionMap("Fly", throwIfNotFound: true);
        m_Fly_Move = m_Fly.FindAction("Move", throwIfNotFound: true);
        m_Fly_MoveY = m_Fly.FindAction("MoveY", throwIfNotFound: true);
        m_Fly_Fire = m_Fly.FindAction("Fire", throwIfNotFound: true);
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

    // Fly
    private readonly InputActionMap m_Fly;
    private IFlyActions m_FlyActionsCallbackInterface;
    private readonly InputAction m_Fly_Move;
    private readonly InputAction m_Fly_MoveY;
    private readonly InputAction m_Fly_Fire;
    public struct FlyActions
    {
        private @PlaneActionControl m_Wrapper;
        public FlyActions(@PlaneActionControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Fly_Move;
        public InputAction @MoveY => m_Wrapper.m_Fly_MoveY;
        public InputAction @Fire => m_Wrapper.m_Fly_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Fly; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlyActions set) { return set.Get(); }
        public void SetCallbacks(IFlyActions instance)
        {
            if (m_Wrapper.m_FlyActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnMove;
                @MoveY.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnMoveY;
                @Fire.started -= m_Wrapper.m_FlyActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_FlyActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_FlyActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_FlyActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public FlyActions @Fly => new FlyActions(this);
    public interface IFlyActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
