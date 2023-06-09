// GENERATED AUTOMATICALLY FROM 'Assets/NewActionInputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewActionInputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewActionInputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewActionInputManager"",
    ""maps"": [
        {
            ""name"": ""BulletHell"",
            ""id"": ""90434ee0-e2fd-46cd-b17c-d0255212f1da"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8060da1e-6952-4925-a3df-2ac00d1b31d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9a595830-3a17-4d5d-9359-41a047aa32b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""7ec80023-da8a-4e27-bb37-2a724584496e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Option"",
                    ""type"": ""Button"",
                    ""id"": ""a54d4792-e4c2-425e-8d0e-b81dd97b83fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""030c8f38-275e-48d0-b24c-1e2bd1748b25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Value"",
                    ""id"": ""3e54a2f0-70be-4be8-a235-28d548b3fa9b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""be0d8bbc-96b1-462e-b848-b9041d8a9d40"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7ad73c27-92b5-4468-b279-61c52adaa29f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cef6fc9d-23ef-4c73-adeb-e696eabec94c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""69825d80-c023-4d21-8035-bc8ef1fdacae"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8de20b16-d0ca-4b26-97be-7aa610b24975"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d964f715-9e7f-4a5f-9a5e-230a4800dcf9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""3230df51-a81e-46a0-bff6-9494612a6672"",
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
                    ""id"": ""1d7bb4db-38ee-4701-93c9-3f3042e97db4"",
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
                    ""id"": ""bbdc5ccb-33e9-4341-a31b-8ecde9b1b966"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""f89b8250-2399-48bf-9bbe-8316983e22e8"",
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
                    ""id"": ""e272fb41-70f7-4bec-bb97-de61431eb2b2"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""60c8d391-39db-406a-8e67-7f8adf9d024f"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a517734-9610-4d40-8fd3-c817cbbc5305"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d234ddd-761e-4d23-ae5d-11fbae668c29"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb3e8ad7-cb8c-45fa-adb1-1c1f2168f79f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12ab7841-ae05-4450-b8e5-fe9055d7dc65"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12801794-1ff6-4ba2-98fc-612c758e48a4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""268c5eb1-55b1-44d4-a3be-150c14caebb7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4d32947-406e-45cb-bafe-84f36c99b1ac"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59cb875d-1e67-4e12-b093-1eac96e40584"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ArcadeMain"",
            ""id"": ""e64d5cb6-8068-4fd7-a97a-0d4e6cc3e226"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""233f20aa-440c-467c-b959-499d09faa050"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9f6ff6e6-6ad6-4242-93a8-2888e0bb3705"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectControllerXbox"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2010cc29-b2d0-4428-bc7c-46d15f011f5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectKeyboardMouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4d345986-0216-446e-8d81-5f971df07322"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""cce25d01-2bbb-486e-bf62-b6644b433427"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Option"",
                    ""type"": ""Button"",
                    ""id"": ""7750c2c8-f2e1-4300-ba05-1745c82b5f41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""d927a60a-304c-4323-a9ba-4d3ee0214894"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Value"",
                    ""id"": ""4d64ab44-861d-4c36-af54-bd507428a78b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControlXbox"",
                    ""type"": ""Value"",
                    ""id"": ""d1edad31-48a7-4280-9100-7d61d597361e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""c50dfdc5-7e78-495a-8665-c0761ffeb1a0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a9c4c33f-ffe0-4403-984b-f3cfcd70f3c5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""62f81d0e-5e10-4714-8c9f-fbd39be59b77"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""0e787740-8643-4c9f-9ef0-0c722c2613c5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e0238eaa-3feb-48f7-9a53-b8ddd2500f95"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2531c1d4-cdeb-4ef6-9a68-adb6c3c51e28"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""acace691-97e3-4d8d-91a7-a1eda552db22"",
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
                    ""id"": ""affa00f7-32ea-446e-888a-85636a9aa5ca"",
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
                    ""id"": ""b0b57ea4-b230-4c3b-bb56-7bfcc9ab4c15"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""f4ed5193-d95a-428e-aa51-edb07867e63e"",
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
                    ""id"": ""39388512-c4fd-4a84-be44-24b5d3fafd27"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2d9eeaae-b486-4787-8d05-e9dfd8c2fd2c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1ec491b2-635a-435a-86a0-93ceabe2c102"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""952a7392-bde1-4643-aec9-73e32c8f3ca8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8f1a925-6cb2-4f7a-a53a-353331e1faf8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39133d16-8368-4a88-8514-d797b288cbdc"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27c405d8-2959-4360-9b03-b4ce8a08f1d2"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a5eab3b-0c48-4f8d-98b0-60d006868797"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d156e0a3-d44d-4f51-873a-a24f7e7fe91e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdbd8e25-9788-4b75-bfac-5e6fe2fdeea6"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""b85d5db8-1fc2-420c-86e5-97ffe787300d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXbox"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a2edd7f8-db5b-4826-ad78-749786bf8317"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""742cc763-a56a-4ddd-a39e-ccb08d81ca50"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""21efa51a-9302-4c8a-ac01-991532c9b106"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboardMouse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dd8e4d47-ac6e-4097-84d4-b8795e391275"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboardMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e719756f-62a0-4361-a693-55c9a77d175a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboardMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42c70b26-b598-4118-b27c-3917b4c70f09"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControlXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""WizardAndKnight"",
            ""id"": ""bcbd33d6-876b-4396-8e40-6fc150188364"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a76a31de-ba82-4702-9f99-3cb7ff1327f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""646e80f4-5c38-4f00-a0f2-350cf7c5998c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectControllerXbox"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cbaa26f5-6d6d-4a2b-ab8c-ac6d6f613fd4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectKeyboardMouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5d2c6dc1-881e-48e9-bca2-c0be68690f9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""2eeaaff7-3757-420b-ab39-b2f831eb4c4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Option"",
                    ""type"": ""Button"",
                    ""id"": ""644f6668-3927-420c-8bab-e60d8783cca6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""0f353444-7bd1-4386-9278-c466896340ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Value"",
                    ""id"": ""5ef59b3f-cd21-449f-8188-73b62414e9bd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControlXbox"",
                    ""type"": ""Value"",
                    ""id"": ""a2b2c602-67a5-4402-90b5-90339bf570b3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""b7773a51-5e13-4282-8655-02d5c25e9a29"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cd3a053b-ff93-4c09-94d9-52682c70ea38"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7a63068f-4640-41bc-beaf-d6ebc2eb55c4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""c1e53afa-a3c6-455b-a9ca-45ed980d6929"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""91e6cac2-be49-4b0e-a8bc-a9f5ba242a39"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""74bae302-fdad-4202-8cac-e27bedc78f7c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""9ed05f51-64c5-4f5c-9f12-47a1a1788b89"",
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
                    ""id"": ""479e2f42-b21f-4eb1-bf8d-1be1d2e1ce96"",
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
                    ""id"": ""f852f801-a02f-4f42-9c10-0cd09a52bd62"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""f6ed9df1-89d0-4da0-b62f-3ebd534355f9"",
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
                    ""id"": ""77fa0b3c-c4f5-4fa1-b8ec-2d15d562ce2b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c542a46f-94fc-4793-b886-d6b153d36b1a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""06c8a0b0-f837-4755-8f78-a655713bf970"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cbfe42b-f91a-41af-a8b1-bd1483734208"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13ac7c14-a391-495f-950a-f0ecb872a514"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Option"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba6bd334-db58-423d-b5ce-7233a4fe1abd"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60654d31-ebb7-456f-94d8-503984debba7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40ad14ef-f216-4284-95c6-cbcee8aeab32"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""8815f73b-7eea-41fd-84ea-522c181a0958"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXbox"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2a5c85fa-9851-4ec3-8cc6-9419282b9576"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""47c4cd19-fa57-4d23-be10-0d04c31eb487"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""2014fe2c-de92-45c5-8a76-96ebeac2bca7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboardMouse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""659f8e04-ac4a-45fe-92ec-bd7b0cf7044d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboardMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2254fa47-e45a-4fac-bb5e-363e2d6b7101"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboardMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e2d29160-9f31-4005-9e53-ee25d2ab18e2"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControlXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FlappyBird"",
            ""id"": ""3c1eee93-1095-4bca-b19a-a8c8d2be460a"",
            ""actions"": [
                {
                    ""name"": ""Fly"",
                    ""type"": ""Button"",
                    ""id"": ""f485894f-9de0-463f-a734-d617e3a86d40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6be1e3e-286d-46ac-be7c-0fa2dcee83b5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26f5bdfc-6b69-44dd-9b2e-513f2674f292"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Asteroid"",
            ""id"": ""efaa8626-9eba-41f1-a6e4-d6bdbf4faccf"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9fc7ef99-b587-4745-9aa8-c75aa504a615"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""f35590aa-8c4c-42eb-a933-13be2c0b04a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""284b89ed-4d73-422a-9f11-4eeef53f0bdd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3497371c-2ada-4d61-b8c9-da78c3e03024"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0310eee6-66be-4600-b5aa-7b3d952c2e7a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7bef0a38-f63e-46d0-8243-1a5a576bb82d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""232c7313-63fc-48a5-b3bd-2d44549419a1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D VectorArrow"",
                    ""id"": ""bc276abb-7005-4554-9ab5-1430a7eda7b4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""555823ea-65f1-4f0b-b534-fbfc3cf2d5b0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5508c27-4731-4ca0-9a44-e9082e8f2566"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""849d7f1f-392a-4e6d-a9af-17d6476f906b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c78817b7-24c2-4aa0-b553-4220e6ef38b9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""267a77a1-ab96-4c0a-903f-cc5d90364964"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5273c4e0-a9ea-4ee9-983e-53afb3568528"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BulletHell
        m_BulletHell = asset.FindActionMap("BulletHell", throwIfNotFound: true);
        m_BulletHell_MoveX = m_BulletHell.FindAction("MoveX", throwIfNotFound: true);
        m_BulletHell_MoveY = m_BulletHell.FindAction("MoveY", throwIfNotFound: true);
        m_BulletHell_Fire = m_BulletHell.FindAction("Fire", throwIfNotFound: true);
        m_BulletHell_Option = m_BulletHell.FindAction("Option", throwIfNotFound: true);
        m_BulletHell_Action = m_BulletHell.FindAction("Action", throwIfNotFound: true);
        m_BulletHell_CameraControl = m_BulletHell.FindAction("CameraControl", throwIfNotFound: true);
        // ArcadeMain
        m_ArcadeMain = asset.FindActionMap("ArcadeMain", throwIfNotFound: true);
        m_ArcadeMain_MoveX = m_ArcadeMain.FindAction("MoveX", throwIfNotFound: true);
        m_ArcadeMain_MoveY = m_ArcadeMain.FindAction("MoveY", throwIfNotFound: true);
        m_ArcadeMain_DetectControllerXbox = m_ArcadeMain.FindAction("DetectControllerXbox", throwIfNotFound: true);
        m_ArcadeMain_DetectKeyboardMouse = m_ArcadeMain.FindAction("DetectKeyboardMouse", throwIfNotFound: true);
        m_ArcadeMain_Fire = m_ArcadeMain.FindAction("Fire", throwIfNotFound: true);
        m_ArcadeMain_Option = m_ArcadeMain.FindAction("Option", throwIfNotFound: true);
        m_ArcadeMain_Action = m_ArcadeMain.FindAction("Action", throwIfNotFound: true);
        m_ArcadeMain_CameraControl = m_ArcadeMain.FindAction("CameraControl", throwIfNotFound: true);
        m_ArcadeMain_CameraControlXbox = m_ArcadeMain.FindAction("CameraControlXbox", throwIfNotFound: true);
        // WizardAndKnight
        m_WizardAndKnight = asset.FindActionMap("WizardAndKnight", throwIfNotFound: true);
        m_WizardAndKnight_MoveX = m_WizardAndKnight.FindAction("MoveX", throwIfNotFound: true);
        m_WizardAndKnight_MoveY = m_WizardAndKnight.FindAction("MoveY", throwIfNotFound: true);
        m_WizardAndKnight_DetectControllerXbox = m_WizardAndKnight.FindAction("DetectControllerXbox", throwIfNotFound: true);
        m_WizardAndKnight_DetectKeyboardMouse = m_WizardAndKnight.FindAction("DetectKeyboardMouse", throwIfNotFound: true);
        m_WizardAndKnight_Fire = m_WizardAndKnight.FindAction("Fire", throwIfNotFound: true);
        m_WizardAndKnight_Option = m_WizardAndKnight.FindAction("Option", throwIfNotFound: true);
        m_WizardAndKnight_Action = m_WizardAndKnight.FindAction("Action", throwIfNotFound: true);
        m_WizardAndKnight_CameraControl = m_WizardAndKnight.FindAction("CameraControl", throwIfNotFound: true);
        m_WizardAndKnight_CameraControlXbox = m_WizardAndKnight.FindAction("CameraControlXbox", throwIfNotFound: true);
        // FlappyBird
        m_FlappyBird = asset.FindActionMap("FlappyBird", throwIfNotFound: true);
        m_FlappyBird_Fly = m_FlappyBird.FindAction("Fly", throwIfNotFound: true);
        // Asteroid
        m_Asteroid = asset.FindActionMap("Asteroid", throwIfNotFound: true);
        m_Asteroid_Movement = m_Asteroid.FindAction("Movement", throwIfNotFound: true);
        m_Asteroid_Fire = m_Asteroid.FindAction("Fire", throwIfNotFound: true);
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

    // BulletHell
    private readonly InputActionMap m_BulletHell;
    private IBulletHellActions m_BulletHellActionsCallbackInterface;
    private readonly InputAction m_BulletHell_MoveX;
    private readonly InputAction m_BulletHell_MoveY;
    private readonly InputAction m_BulletHell_Fire;
    private readonly InputAction m_BulletHell_Option;
    private readonly InputAction m_BulletHell_Action;
    private readonly InputAction m_BulletHell_CameraControl;
    public struct BulletHellActions
    {
        private @NewActionInputManager m_Wrapper;
        public BulletHellActions(@NewActionInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_BulletHell_MoveX;
        public InputAction @MoveY => m_Wrapper.m_BulletHell_MoveY;
        public InputAction @Fire => m_Wrapper.m_BulletHell_Fire;
        public InputAction @Option => m_Wrapper.m_BulletHell_Option;
        public InputAction @Action => m_Wrapper.m_BulletHell_Action;
        public InputAction @CameraControl => m_Wrapper.m_BulletHell_CameraControl;
        public InputActionMap Get() { return m_Wrapper.m_BulletHell; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BulletHellActions set) { return set.Get(); }
        public void SetCallbacks(IBulletHellActions instance)
        {
            if (m_Wrapper.m_BulletHellActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnMoveY;
                @Fire.started -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnFire;
                @Option.started -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnOption;
                @Option.performed -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnOption;
                @Option.canceled -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnOption;
                @Action.started -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnAction;
                @CameraControl.started -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_BulletHellActionsCallbackInterface.OnCameraControl;
            }
            m_Wrapper.m_BulletHellActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Option.started += instance.OnOption;
                @Option.performed += instance.OnOption;
                @Option.canceled += instance.OnOption;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
            }
        }
    }
    public BulletHellActions @BulletHell => new BulletHellActions(this);

    // ArcadeMain
    private readonly InputActionMap m_ArcadeMain;
    private IArcadeMainActions m_ArcadeMainActionsCallbackInterface;
    private readonly InputAction m_ArcadeMain_MoveX;
    private readonly InputAction m_ArcadeMain_MoveY;
    private readonly InputAction m_ArcadeMain_DetectControllerXbox;
    private readonly InputAction m_ArcadeMain_DetectKeyboardMouse;
    private readonly InputAction m_ArcadeMain_Fire;
    private readonly InputAction m_ArcadeMain_Option;
    private readonly InputAction m_ArcadeMain_Action;
    private readonly InputAction m_ArcadeMain_CameraControl;
    private readonly InputAction m_ArcadeMain_CameraControlXbox;
    public struct ArcadeMainActions
    {
        private @NewActionInputManager m_Wrapper;
        public ArcadeMainActions(@NewActionInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_ArcadeMain_MoveX;
        public InputAction @MoveY => m_Wrapper.m_ArcadeMain_MoveY;
        public InputAction @DetectControllerXbox => m_Wrapper.m_ArcadeMain_DetectControllerXbox;
        public InputAction @DetectKeyboardMouse => m_Wrapper.m_ArcadeMain_DetectKeyboardMouse;
        public InputAction @Fire => m_Wrapper.m_ArcadeMain_Fire;
        public InputAction @Option => m_Wrapper.m_ArcadeMain_Option;
        public InputAction @Action => m_Wrapper.m_ArcadeMain_Action;
        public InputAction @CameraControl => m_Wrapper.m_ArcadeMain_CameraControl;
        public InputAction @CameraControlXbox => m_Wrapper.m_ArcadeMain_CameraControlXbox;
        public InputActionMap Get() { return m_Wrapper.m_ArcadeMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ArcadeMainActions set) { return set.Get(); }
        public void SetCallbacks(IArcadeMainActions instance)
        {
            if (m_Wrapper.m_ArcadeMainActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnMoveY;
                @DetectControllerXbox.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnDetectControllerXbox;
                @DetectKeyboardMouse.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnDetectKeyboardMouse;
                @Fire.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnFire;
                @Option.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnOption;
                @Option.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnOption;
                @Option.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnOption;
                @Action.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnAction;
                @CameraControl.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnCameraControl;
                @CameraControlXbox.started -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.performed -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.canceled -= m_Wrapper.m_ArcadeMainActionsCallbackInterface.OnCameraControlXbox;
            }
            m_Wrapper.m_ArcadeMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @DetectControllerXbox.started += instance.OnDetectControllerXbox;
                @DetectControllerXbox.performed += instance.OnDetectControllerXbox;
                @DetectControllerXbox.canceled += instance.OnDetectControllerXbox;
                @DetectKeyboardMouse.started += instance.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.performed += instance.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.canceled += instance.OnDetectKeyboardMouse;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Option.started += instance.OnOption;
                @Option.performed += instance.OnOption;
                @Option.canceled += instance.OnOption;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
                @CameraControlXbox.started += instance.OnCameraControlXbox;
                @CameraControlXbox.performed += instance.OnCameraControlXbox;
                @CameraControlXbox.canceled += instance.OnCameraControlXbox;
            }
        }
    }
    public ArcadeMainActions @ArcadeMain => new ArcadeMainActions(this);

    // WizardAndKnight
    private readonly InputActionMap m_WizardAndKnight;
    private IWizardAndKnightActions m_WizardAndKnightActionsCallbackInterface;
    private readonly InputAction m_WizardAndKnight_MoveX;
    private readonly InputAction m_WizardAndKnight_MoveY;
    private readonly InputAction m_WizardAndKnight_DetectControllerXbox;
    private readonly InputAction m_WizardAndKnight_DetectKeyboardMouse;
    private readonly InputAction m_WizardAndKnight_Fire;
    private readonly InputAction m_WizardAndKnight_Option;
    private readonly InputAction m_WizardAndKnight_Action;
    private readonly InputAction m_WizardAndKnight_CameraControl;
    private readonly InputAction m_WizardAndKnight_CameraControlXbox;
    public struct WizardAndKnightActions
    {
        private @NewActionInputManager m_Wrapper;
        public WizardAndKnightActions(@NewActionInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_WizardAndKnight_MoveX;
        public InputAction @MoveY => m_Wrapper.m_WizardAndKnight_MoveY;
        public InputAction @DetectControllerXbox => m_Wrapper.m_WizardAndKnight_DetectControllerXbox;
        public InputAction @DetectKeyboardMouse => m_Wrapper.m_WizardAndKnight_DetectKeyboardMouse;
        public InputAction @Fire => m_Wrapper.m_WizardAndKnight_Fire;
        public InputAction @Option => m_Wrapper.m_WizardAndKnight_Option;
        public InputAction @Action => m_Wrapper.m_WizardAndKnight_Action;
        public InputAction @CameraControl => m_Wrapper.m_WizardAndKnight_CameraControl;
        public InputAction @CameraControlXbox => m_Wrapper.m_WizardAndKnight_CameraControlXbox;
        public InputActionMap Get() { return m_Wrapper.m_WizardAndKnight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WizardAndKnightActions set) { return set.Get(); }
        public void SetCallbacks(IWizardAndKnightActions instance)
        {
            if (m_Wrapper.m_WizardAndKnightActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnMoveY;
                @DetectControllerXbox.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnDetectControllerXbox;
                @DetectKeyboardMouse.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnDetectKeyboardMouse;
                @Fire.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnFire;
                @Option.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnOption;
                @Option.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnOption;
                @Option.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnOption;
                @Action.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnAction;
                @CameraControl.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnCameraControl;
                @CameraControlXbox.started -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.performed -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.canceled -= m_Wrapper.m_WizardAndKnightActionsCallbackInterface.OnCameraControlXbox;
            }
            m_Wrapper.m_WizardAndKnightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @DetectControllerXbox.started += instance.OnDetectControllerXbox;
                @DetectControllerXbox.performed += instance.OnDetectControllerXbox;
                @DetectControllerXbox.canceled += instance.OnDetectControllerXbox;
                @DetectKeyboardMouse.started += instance.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.performed += instance.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.canceled += instance.OnDetectKeyboardMouse;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Option.started += instance.OnOption;
                @Option.performed += instance.OnOption;
                @Option.canceled += instance.OnOption;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
                @CameraControlXbox.started += instance.OnCameraControlXbox;
                @CameraControlXbox.performed += instance.OnCameraControlXbox;
                @CameraControlXbox.canceled += instance.OnCameraControlXbox;
            }
        }
    }
    public WizardAndKnightActions @WizardAndKnight => new WizardAndKnightActions(this);

    // FlappyBird
    private readonly InputActionMap m_FlappyBird;
    private IFlappyBirdActions m_FlappyBirdActionsCallbackInterface;
    private readonly InputAction m_FlappyBird_Fly;
    public struct FlappyBirdActions
    {
        private @NewActionInputManager m_Wrapper;
        public FlappyBirdActions(@NewActionInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fly => m_Wrapper.m_FlappyBird_Fly;
        public InputActionMap Get() { return m_Wrapper.m_FlappyBird; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlappyBirdActions set) { return set.Get(); }
        public void SetCallbacks(IFlappyBirdActions instance)
        {
            if (m_Wrapper.m_FlappyBirdActionsCallbackInterface != null)
            {
                @Fly.started -= m_Wrapper.m_FlappyBirdActionsCallbackInterface.OnFly;
                @Fly.performed -= m_Wrapper.m_FlappyBirdActionsCallbackInterface.OnFly;
                @Fly.canceled -= m_Wrapper.m_FlappyBirdActionsCallbackInterface.OnFly;
            }
            m_Wrapper.m_FlappyBirdActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fly.started += instance.OnFly;
                @Fly.performed += instance.OnFly;
                @Fly.canceled += instance.OnFly;
            }
        }
    }
    public FlappyBirdActions @FlappyBird => new FlappyBirdActions(this);

    // Asteroid
    private readonly InputActionMap m_Asteroid;
    private IAsteroidActions m_AsteroidActionsCallbackInterface;
    private readonly InputAction m_Asteroid_Movement;
    private readonly InputAction m_Asteroid_Fire;
    public struct AsteroidActions
    {
        private @NewActionInputManager m_Wrapper;
        public AsteroidActions(@NewActionInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Asteroid_Movement;
        public InputAction @Fire => m_Wrapper.m_Asteroid_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Asteroid; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AsteroidActions set) { return set.Get(); }
        public void SetCallbacks(IAsteroidActions instance)
        {
            if (m_Wrapper.m_AsteroidActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_AsteroidActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_AsteroidActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_AsteroidActionsCallbackInterface.OnMovement;
                @Fire.started -= m_Wrapper.m_AsteroidActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_AsteroidActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_AsteroidActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_AsteroidActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public AsteroidActions @Asteroid => new AsteroidActions(this);
    public interface IBulletHellActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnOption(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
    }
    public interface IArcadeMainActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnDetectControllerXbox(InputAction.CallbackContext context);
        void OnDetectKeyboardMouse(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnOption(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
        void OnCameraControlXbox(InputAction.CallbackContext context);
    }
    public interface IWizardAndKnightActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnDetectControllerXbox(InputAction.CallbackContext context);
        void OnDetectKeyboardMouse(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnOption(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
        void OnCameraControlXbox(InputAction.CallbackContext context);
    }
    public interface IFlappyBirdActions
    {
        void OnFly(InputAction.CallbackContext context);
    }
    public interface IAsteroidActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
