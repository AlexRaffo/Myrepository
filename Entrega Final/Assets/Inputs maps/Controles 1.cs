//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Kawaii Slimes/Inputs maps/Controles 1.inputactions
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

public partial class @Controles1 : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controles1()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controles 1"",
    ""maps"": [
        {
            ""name"": ""ControlesJugador"",
            ""id"": ""a847e328-c4d5-4150-a3f6-e05f85fb083b"",
            ""actions"": [
                {
                    ""name"": ""Disparar"",
                    ""type"": ""Button"",
                    ""id"": ""813f5fda-ef7c-47a9-9875-cad9a7f57638"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Seleccionar bola"",
                    ""type"": ""Button"",
                    ""id"": ""94bb7578-729c-44d3-a7d8-3de435efa9ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Seleccionar bala"",
                    ""type"": ""Button"",
                    ""id"": ""da952873-693b-40c3-9b49-ce3ad9e5ff94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Seleccionar slime"",
                    ""type"": ""Button"",
                    ""id"": ""aaec8b59-1bc0-4f15-9d2e-509a4bbc8550"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Seleccionar imanP"",
                    ""type"": ""Button"",
                    ""id"": ""8078fc08-225f-4aca-a28e-8f581f79d3c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Seleccionar imanN"",
                    ""type"": ""Button"",
                    ""id"": ""ffd9edc8-5c24-42b4-a99f-abc8ac8c5e57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mirar"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8f3ab38a-911c-4179-9d0f-f378ea19b664"",
                    ""expectedControlType"": ""Delta"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""19b42be8-009a-42f2-ad28-f2b813eb8b0e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea36ea93-e7a0-4381-aed5-4a5773ced81f"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar bola"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf963165-57f0-4c78-b088-0d1a78f2639d"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar bola"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9051dc30-53eb-4e56-8e4c-c015cbe5a1cb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar bala"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f11ccb8-7c2f-4b62-94d2-954e9e9fb9e8"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar bala"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ea9e727-556b-487a-9390-16a28103bf51"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar slime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1637f5de-7357-42ab-831f-538f83d6ef60"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar slime"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""399fe6fd-7083-4158-b3e0-af285512e3c7"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar imanP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cb17ae9-4fac-4756-b030-1789631b7350"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar imanP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8372ca87-34d6-44d1-97ab-96eb68c43d6a"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar imanN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a4fccbe-3fa2-4cc6-bd81-d509b6a9d699"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Seleccionar imanN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13fcc495-da8c-4806-8679-3bee6d8446e1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mirar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Controles Proyectil"",
            ""id"": ""49e06e09-547d-4635-aa6c-2d2384867637"",
            ""actions"": [
                {
                    ""name"": ""Borrar"",
                    ""type"": ""Button"",
                    ""id"": ""5b3cdd5b-1cd9-4f23-a923-298b574a78f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1e8bedcf-9e74-4687-a95e-f96d7f82f235"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Borrar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12672a5e-daee-47a1-a63c-a0c73bae69e3"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Borrar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ControlesJugador
        m_ControlesJugador = asset.FindActionMap("ControlesJugador", throwIfNotFound: true);
        m_ControlesJugador_Disparar = m_ControlesJugador.FindAction("Disparar", throwIfNotFound: true);
        m_ControlesJugador_Seleccionarbola = m_ControlesJugador.FindAction("Seleccionar bola", throwIfNotFound: true);
        m_ControlesJugador_Seleccionarbala = m_ControlesJugador.FindAction("Seleccionar bala", throwIfNotFound: true);
        m_ControlesJugador_Seleccionarslime = m_ControlesJugador.FindAction("Seleccionar slime", throwIfNotFound: true);
        m_ControlesJugador_SeleccionarimanP = m_ControlesJugador.FindAction("Seleccionar imanP", throwIfNotFound: true);
        m_ControlesJugador_SeleccionarimanN = m_ControlesJugador.FindAction("Seleccionar imanN", throwIfNotFound: true);
        m_ControlesJugador_Mirar = m_ControlesJugador.FindAction("Mirar", throwIfNotFound: true);
        // Controles Proyectil
        m_ControlesProyectil = asset.FindActionMap("Controles Proyectil", throwIfNotFound: true);
        m_ControlesProyectil_Borrar = m_ControlesProyectil.FindAction("Borrar", throwIfNotFound: true);
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

    // ControlesJugador
    private readonly InputActionMap m_ControlesJugador;
    private IControlesJugadorActions m_ControlesJugadorActionsCallbackInterface;
    private readonly InputAction m_ControlesJugador_Disparar;
    private readonly InputAction m_ControlesJugador_Seleccionarbola;
    private readonly InputAction m_ControlesJugador_Seleccionarbala;
    private readonly InputAction m_ControlesJugador_Seleccionarslime;
    private readonly InputAction m_ControlesJugador_SeleccionarimanP;
    private readonly InputAction m_ControlesJugador_SeleccionarimanN;
    private readonly InputAction m_ControlesJugador_Mirar;
    public struct ControlesJugadorActions
    {
        private @Controles1 m_Wrapper;
        public ControlesJugadorActions(@Controles1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Disparar => m_Wrapper.m_ControlesJugador_Disparar;
        public InputAction @Seleccionarbola => m_Wrapper.m_ControlesJugador_Seleccionarbola;
        public InputAction @Seleccionarbala => m_Wrapper.m_ControlesJugador_Seleccionarbala;
        public InputAction @Seleccionarslime => m_Wrapper.m_ControlesJugador_Seleccionarslime;
        public InputAction @SeleccionarimanP => m_Wrapper.m_ControlesJugador_SeleccionarimanP;
        public InputAction @SeleccionarimanN => m_Wrapper.m_ControlesJugador_SeleccionarimanN;
        public InputAction @Mirar => m_Wrapper.m_ControlesJugador_Mirar;
        public InputActionMap Get() { return m_Wrapper.m_ControlesJugador; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlesJugadorActions set) { return set.Get(); }
        public void SetCallbacks(IControlesJugadorActions instance)
        {
            if (m_Wrapper.m_ControlesJugadorActionsCallbackInterface != null)
            {
                @Disparar.started -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnDisparar;
                @Disparar.performed -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnDisparar;
                @Disparar.canceled -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnDisparar;
                @Seleccionarbola.started -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarbola;
                @Seleccionarbola.performed -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarbola;
                @Seleccionarbola.canceled -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarbola;
                @Seleccionarbala.started -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarbala;
                @Seleccionarbala.performed -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarbala;
                @Seleccionarbala.canceled -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarbala;
                @Seleccionarslime.started -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarslime;
                @Seleccionarslime.performed -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarslime;
                @Seleccionarslime.canceled -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarslime;
                @SeleccionarimanP.started -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarimanP;
                @SeleccionarimanP.performed -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarimanP;
                @SeleccionarimanP.canceled -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarimanP;
                @SeleccionarimanN.started -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarimanN;
                @SeleccionarimanN.performed -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarimanN;
                @SeleccionarimanN.canceled -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnSeleccionarimanN;
                @Mirar.started -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnMirar;
                @Mirar.performed -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnMirar;
                @Mirar.canceled -= m_Wrapper.m_ControlesJugadorActionsCallbackInterface.OnMirar;
            }
            m_Wrapper.m_ControlesJugadorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Disparar.started += instance.OnDisparar;
                @Disparar.performed += instance.OnDisparar;
                @Disparar.canceled += instance.OnDisparar;
                @Seleccionarbola.started += instance.OnSeleccionarbola;
                @Seleccionarbola.performed += instance.OnSeleccionarbola;
                @Seleccionarbola.canceled += instance.OnSeleccionarbola;
                @Seleccionarbala.started += instance.OnSeleccionarbala;
                @Seleccionarbala.performed += instance.OnSeleccionarbala;
                @Seleccionarbala.canceled += instance.OnSeleccionarbala;
                @Seleccionarslime.started += instance.OnSeleccionarslime;
                @Seleccionarslime.performed += instance.OnSeleccionarslime;
                @Seleccionarslime.canceled += instance.OnSeleccionarslime;
                @SeleccionarimanP.started += instance.OnSeleccionarimanP;
                @SeleccionarimanP.performed += instance.OnSeleccionarimanP;
                @SeleccionarimanP.canceled += instance.OnSeleccionarimanP;
                @SeleccionarimanN.started += instance.OnSeleccionarimanN;
                @SeleccionarimanN.performed += instance.OnSeleccionarimanN;
                @SeleccionarimanN.canceled += instance.OnSeleccionarimanN;
                @Mirar.started += instance.OnMirar;
                @Mirar.performed += instance.OnMirar;
                @Mirar.canceled += instance.OnMirar;
            }
        }
    }
    public ControlesJugadorActions @ControlesJugador => new ControlesJugadorActions(this);

    // Controles Proyectil
    private readonly InputActionMap m_ControlesProyectil;
    private IControlesProyectilActions m_ControlesProyectilActionsCallbackInterface;
    private readonly InputAction m_ControlesProyectil_Borrar;
    public struct ControlesProyectilActions
    {
        private @Controles1 m_Wrapper;
        public ControlesProyectilActions(@Controles1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Borrar => m_Wrapper.m_ControlesProyectil_Borrar;
        public InputActionMap Get() { return m_Wrapper.m_ControlesProyectil; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlesProyectilActions set) { return set.Get(); }
        public void SetCallbacks(IControlesProyectilActions instance)
        {
            if (m_Wrapper.m_ControlesProyectilActionsCallbackInterface != null)
            {
                @Borrar.started -= m_Wrapper.m_ControlesProyectilActionsCallbackInterface.OnBorrar;
                @Borrar.performed -= m_Wrapper.m_ControlesProyectilActionsCallbackInterface.OnBorrar;
                @Borrar.canceled -= m_Wrapper.m_ControlesProyectilActionsCallbackInterface.OnBorrar;
            }
            m_Wrapper.m_ControlesProyectilActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Borrar.started += instance.OnBorrar;
                @Borrar.performed += instance.OnBorrar;
                @Borrar.canceled += instance.OnBorrar;
            }
        }
    }
    public ControlesProyectilActions @ControlesProyectil => new ControlesProyectilActions(this);
    public interface IControlesJugadorActions
    {
        void OnDisparar(InputAction.CallbackContext context);
        void OnSeleccionarbola(InputAction.CallbackContext context);
        void OnSeleccionarbala(InputAction.CallbackContext context);
        void OnSeleccionarslime(InputAction.CallbackContext context);
        void OnSeleccionarimanP(InputAction.CallbackContext context);
        void OnSeleccionarimanN(InputAction.CallbackContext context);
        void OnMirar(InputAction.CallbackContext context);
    }
    public interface IControlesProyectilActions
    {
        void OnBorrar(InputAction.CallbackContext context);
    }
}