//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Pawn"",
            ""id"": ""9971846d-79b8-4698-9092-2fe0fb37a6b4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3a62b3ce-ff48-4c90-8e80-c594c5ebcb0d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseDown"",
                    ""type"": ""Button"",
                    ""id"": ""4b6255f9-1c2e-496a-a245-052284662591"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""30675410-af86-4644-abec-6e7911c03321"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Pawn
        m_Pawn = asset.FindActionMap("Pawn", throwIfNotFound: true);
        m_Pawn_Move = m_Pawn.FindAction("Move", throwIfNotFound: true);
        m_Pawn_MouseDown = m_Pawn.FindAction("MouseDown", throwIfNotFound: true);
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

    // Pawn
    private readonly InputActionMap m_Pawn;
    private List<IPawnActions> m_PawnActionsCallbackInterfaces = new List<IPawnActions>();
    private readonly InputAction m_Pawn_Move;
    private readonly InputAction m_Pawn_MouseDown;
    public struct PawnActions
    {
        private @PlayerInputActions m_Wrapper;
        public PawnActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Pawn_Move;
        public InputAction @MouseDown => m_Wrapper.m_Pawn_MouseDown;
        public InputActionMap Get() { return m_Wrapper.m_Pawn; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PawnActions set) { return set.Get(); }
        public void AddCallbacks(IPawnActions instance)
        {
            if (instance == null || m_Wrapper.m_PawnActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PawnActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @MouseDown.started += instance.OnMouseDown;
            @MouseDown.performed += instance.OnMouseDown;
            @MouseDown.canceled += instance.OnMouseDown;
        }

        private void UnregisterCallbacks(IPawnActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @MouseDown.started -= instance.OnMouseDown;
            @MouseDown.performed -= instance.OnMouseDown;
            @MouseDown.canceled -= instance.OnMouseDown;
        }

        public void RemoveCallbacks(IPawnActions instance)
        {
            if (m_Wrapper.m_PawnActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPawnActions instance)
        {
            foreach (var item in m_Wrapper.m_PawnActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PawnActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PawnActions @Pawn => new PawnActions(this);
    public interface IPawnActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMouseDown(InputAction.CallbackContext context);
    }
}
