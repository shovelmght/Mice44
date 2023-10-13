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
            ""name"": ""ArcadeMain1"",
            ""id"": ""0a2ea68e-f3bc-4baf-916e-323818e89547"",
            ""actions"": [
                {
                    ""name"": ""MoveY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""df22dd6c-372d-4f98-9d5e-4fbff4c58ada"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1829f59f-e7b1-4cab-8dc1-a8b6f120c9fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectControllerXbox"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3b1c87bd-ca80-41fd-8eac-3e98b03fbd47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectKeyboardMouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a304fd85-8fed-4bb1-9409-2c782636550f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""af469319-566c-4808-8acc-2898812db34e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Option"",
                    ""type"": ""Button"",
                    ""id"": ""cb6437ca-2680-4131-8472-85dbf9da4383"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""a3c9a21f-9d5c-45a9-a1f0-66cc039570ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Value"",
                    ""id"": ""fccbe447-d196-485b-94f1-b1d0bd6200cf"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControlXbox"",
                    ""type"": ""Value"",
                    ""id"": ""6deccba1-5479-4629-87ac-191ecb4543cc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectControllerXboxLeftStick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5c3c7239-54ad-4cf4-ad6d-fcad7a13dea7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectKeyboadAD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""252a97fa-210a-4b58-90a7-917808320dd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""4b5bfbda-0f60-47d8-8cc1-213a7ad307d1"",
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
                    ""id"": ""73eb787e-5d03-4466-b074-2a88ce5e09c2"",
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
                    ""id"": ""b2ba26d2-32a8-4544-8d5a-ea6817549c2a"",
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
                    ""id"": ""7119420c-73ca-48d5-bd5f-9e843304c04e"",
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
                    ""id"": ""87cebc88-3cf8-440b-ada1-50d5004d04c2"",
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
                    ""id"": ""50d70418-d477-4423-80b5-64cefd4adb6c"",
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
                    ""id"": ""b547201c-ec12-4335-b4bf-145fafb06661"",
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
                    ""id"": ""b0bb2b64-84d1-4d23-a7f7-4bac66d71c25"",
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
                    ""id"": ""ddc41463-129f-42a2-8c28-ff2b9582c62f"",
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
                    ""id"": ""0904505a-f158-4e85-8d64-359230b4c7a1"",
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
                    ""id"": ""64ca71c4-ab89-4636-9348-4f263cdb7231"",
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
                    ""id"": ""30b7e653-3876-4297-90f9-5995c33986c4"",
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
                    ""id"": ""352b84c9-b67d-4442-afa5-a8e679db4b97"",
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
                    ""id"": ""d62a2fd9-0f1c-4ac5-b1e3-87ed618a6f04"",
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
                    ""id"": ""d1b1432d-9475-46e3-b1d9-c7a02f1a70b0"",
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
                    ""id"": ""7263cd9e-f9c3-40be-9553-720c78eba792"",
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
                    ""id"": ""c8ef5445-714f-42bc-a774-25a2cbd6987e"",
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
                    ""id"": ""ee961a76-793e-4cec-9813-c92b39a1c8a9"",
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
                    ""id"": ""4b1d576c-0bb8-49e2-842b-ce55e0646db9"",
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
                    ""id"": ""8b8f7868-531b-4ae3-8233-4a3eb7619899"",
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
                    ""id"": ""c59b7415-1e2f-429e-9c75-97ce4422447e"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControlXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6e5c111e-3056-44eb-ba6a-5abb1ff748eb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXboxLeftStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""69dbd7f8-aef9-43f3-987f-ec3faef4fe85"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXboxLeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""be601705-c942-4a27-8c8d-29f085397612"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXboxLeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""091b3816-b0d0-4ed9-9903-64fe266da7c1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboadAD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""519bc1bc-6bdd-4bc6-b70b-68dca0ead188"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboadAD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""11012752-00e6-416a-8415-64fa40012916"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectKeyboadAD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""3ac8ea45-7dcd-437c-8350-888239d5c4e1"",
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
                    ""id"": ""d1bb030f-42a2-4fac-bb29-314c00c71572"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0863648a-3082-4a32-bb07-48f5233648b8"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""eff23dd8-9086-436f-997e-2b9beef62457"",
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
                    ""id"": ""6c5986f4-c628-4f8c-a66b-67062fc3ba5c"",
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
                    ""id"": ""f254fb0d-56cd-4f7b-a416-c89326fc65cb"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
            ""name"": ""SoulRunner"",
            ""id"": ""3bbc5657-1594-4f63-9d57-9fe7b277bd0a"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e86b9835-e550-4f94-9b09-2c16ef13a09c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""42e5622e-741b-42db-82f4-eac4cfe4b9ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectControllerXbox"",
                    ""type"": ""PassThrough"",
                    ""id"": ""237be617-d9b8-414c-b173-60bfdb39f777"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectKeyboardMouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5cdc904e-8fce-4c7e-af70-3072239d45ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Punch"",
                    ""type"": ""Button"",
                    ""id"": ""e06426df-1b9c-4821-a938-2750100719f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""c3679df7-7551-4639-a892-3402dc71ef84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap"",
                    ""type"": ""Button"",
                    ""id"": ""261a35b8-f1d3-47d3-9dbe-cf947e181abc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""3a088044-ccbd-45a5-a14d-55b065ae76cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7aa5e562-f05a-4747-9315-383795ea1bfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Value"",
                    ""id"": ""39616993-59a7-4187-a1c1-9c3820328702"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControlXbox"",
                    ""type"": ""Value"",
                    ""id"": ""f5422841-2528-4c6c-ab90-3b06d387e6b1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""bbf2bf8e-b44e-4ab8-8754-9f93ce33767d"",
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
                    ""id"": ""4931ccb9-e32e-4aee-bd19-48073f0fcbac"",
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
                    ""id"": ""edbe8fa1-51c4-4045-8dbb-c46b01a18200"",
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
                    ""id"": ""acd5ffc7-a97a-4320-972f-8e1c08470138"",
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
                    ""id"": ""aa4725c3-94f6-408f-acbf-74275f86b0cc"",
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
                    ""id"": ""d436a161-a977-4540-8e99-3cfc04507fff"",
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
                    ""id"": ""d97d952f-4281-4344-9c67-be1250f89971"",
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
                    ""id"": ""0ff9577e-3c57-449f-bdcc-7dddfdde4435"",
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
                    ""id"": ""d8ade5af-efd1-4a59-b5c9-f3f3403cd60d"",
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
                    ""id"": ""9c41372c-e7b1-46f2-bbf9-1dc79e195503"",
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
                    ""id"": ""7ef367a5-d36a-43b8-a1f7-6cccb10ae73a"",
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
                    ""id"": ""eba06951-f188-4352-b335-11b434dbd183"",
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
                    ""id"": ""0e8d4f03-70ba-42ad-8765-9039b1587374"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""685a6bca-a9bc-44a4-ab01-8fb181b8ff5c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e2523d0-f831-47be-a38d-592a77bc118d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f380d2d-d7b8-41ee-81f8-3176668a7ee4"",
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
                    ""id"": ""50ef194e-7d5c-46c0-9ed8-c37eb8827af2"",
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
                    ""id"": ""61eccbc4-ac6f-45ca-8666-1dabcf8f4551"",
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
                    ""id"": ""83f20bc2-8543-4890-b0db-e4e8c444b7d2"",
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
                    ""id"": ""800cb600-cf42-4385-a6fd-ba3e76aa0a53"",
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
                    ""id"": ""4ed3a2b8-3065-495c-822c-17364111b92f"",
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
                    ""id"": ""3a404123-1d7e-4cff-8700-07a38440bb8c"",
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
                    ""id"": ""dc93621e-96d5-44e9-945f-1adc60bfab8b"",
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
                    ""id"": ""eb5f3fbd-a800-416b-a6ce-beeb579850ef"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControlXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""790e77b9-b36d-467d-b16a-3de8ba763f71"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffc4259b-146c-4240-a067-40d2f7a25cc4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6a6c733-4028-4d06-88dd-c31c83b1ff9e"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8a08b30-5b89-4855-8614-a183e3726240"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2312b7d-4085-4bd2-a6af-052c6035f1db"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23d9e575-a377-4ee4-9285-7f749c32947b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
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
        },
        {
            ""name"": ""Mice"",
            ""id"": ""b3a6acdf-05bc-44c4-8eda-0a49b07bd883"",
            ""actions"": [
                {
                    ""name"": ""MoveY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3c4b19bd-cebd-4b48-8d7a-18476f08957b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Button"",
                    ""id"": ""d0f6d92f-0c46-4e79-8f11-4217c8095643"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetectControllerXbox"",
                    ""type"": ""Button"",
                    ""id"": ""1740a339-e272-4d2b-a2d8-8c7e333580ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DetecectKeyborad"",
                    ""type"": ""Button"",
                    ""id"": ""1b5f4cad-1ce5-479d-b4f7-b5bd182c4394"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""516bd01f-8231-42d8-8501-892850b111c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Value"",
                    ""id"": ""a219b26e-5290-4b27-9df0-314b7a344708"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraControlXbox"",
                    ""type"": ""Value"",
                    ""id"": ""83a263d1-069c-4a14-83c9-229a40e7b2ad"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""da8e5bda-2a31-4957-9af3-a9ed25dfa0a2"",
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
                    ""id"": ""a7214ac2-3113-45b8-8942-0cdbe501ff2e"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e48958de-53a9-4fc5-91ff-7071b74fe44b"",
                    ""path"": ""<Keyboard>/#(Y)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c586df42-237b-4df6-baea-5f323b029a58"",
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
                    ""id"": ""281cb426-a8b6-4294-a75c-e616bde4c7be"",
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
                    ""id"": ""58239edd-e957-4652-bac2-e6006a662ff0"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""72b7f059-db86-4545-a5de-ca004f8edc3a"",
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
                    ""id"": ""582e256d-a537-4f60-b362-8d80b38bb24a"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2c8dd82c-1500-40d6-83ae-422b3080e334"",
                    ""path"": ""<Keyboard>/#(C)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""56c875dd-0311-49ab-b6ce-3e3773401e04"",
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
                    ""id"": ""da7dee3b-308e-498e-97c2-dee6feeb5ab7"",
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
                    ""id"": ""142e1c34-b11d-45fa-8be8-567ab342ddd1"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d64a8f02-e647-4061-8755-fb83ba4971fe"",
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
                    ""id"": ""bc596708-76e5-4a70-a6e0-ea842072a088"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bf9e3647-1e56-4707-abc4-fdda6ade4c76"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetectControllerXbox"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""06b8f782-d764-4408-9593-809295390d3b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetecectKeyborad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4c51dad6-e2cb-49f5-afbc-cd9bbf98c325"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetecectKeyborad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""80af0d48-b16a-482e-9b25-d216868a4f4f"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DetecectKeyborad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""410343dd-73f2-4039-8ee6-b604c0c44020"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc4dcc70-67cd-4656-a193-f4b60de55c1b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""896012cf-9a20-4ca3-905d-4a60e1fbcf10"",
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
                    ""id"": ""7d49bcf0-91b0-499e-9b50-193a5e4934f9"",
                    ""path"": ""<XInputController>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraControlXbox"",
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
        // ArcadeMain1
        m_ArcadeMain1 = asset.FindActionMap("ArcadeMain1", throwIfNotFound: true);
        m_ArcadeMain1_MoveY = m_ArcadeMain1.FindAction("MoveY", throwIfNotFound: true);
        m_ArcadeMain1_MoveX = m_ArcadeMain1.FindAction("MoveX", throwIfNotFound: true);
        m_ArcadeMain1_DetectControllerXbox = m_ArcadeMain1.FindAction("DetectControllerXbox", throwIfNotFound: true);
        m_ArcadeMain1_DetectKeyboardMouse = m_ArcadeMain1.FindAction("DetectKeyboardMouse", throwIfNotFound: true);
        m_ArcadeMain1_Fire = m_ArcadeMain1.FindAction("Fire", throwIfNotFound: true);
        m_ArcadeMain1_Option = m_ArcadeMain1.FindAction("Option", throwIfNotFound: true);
        m_ArcadeMain1_Action = m_ArcadeMain1.FindAction("Action", throwIfNotFound: true);
        m_ArcadeMain1_CameraControl = m_ArcadeMain1.FindAction("CameraControl", throwIfNotFound: true);
        m_ArcadeMain1_CameraControlXbox = m_ArcadeMain1.FindAction("CameraControlXbox", throwIfNotFound: true);
        m_ArcadeMain1_DetectControllerXboxLeftStick = m_ArcadeMain1.FindAction("DetectControllerXboxLeftStick", throwIfNotFound: true);
        m_ArcadeMain1_DetectKeyboadAD = m_ArcadeMain1.FindAction("DetectKeyboadAD", throwIfNotFound: true);
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
        // SoulRunner
        m_SoulRunner = asset.FindActionMap("SoulRunner", throwIfNotFound: true);
        m_SoulRunner_MoveX = m_SoulRunner.FindAction("MoveX", throwIfNotFound: true);
        m_SoulRunner_MoveY = m_SoulRunner.FindAction("MoveY", throwIfNotFound: true);
        m_SoulRunner_DetectControllerXbox = m_SoulRunner.FindAction("DetectControllerXbox", throwIfNotFound: true);
        m_SoulRunner_DetectKeyboardMouse = m_SoulRunner.FindAction("DetectKeyboardMouse", throwIfNotFound: true);
        m_SoulRunner_Punch = m_SoulRunner.FindAction("Punch", throwIfNotFound: true);
        m_SoulRunner_Slide = m_SoulRunner.FindAction("Slide", throwIfNotFound: true);
        m_SoulRunner_Swap = m_SoulRunner.FindAction("Swap", throwIfNotFound: true);
        m_SoulRunner_Start = m_SoulRunner.FindAction("Start", throwIfNotFound: true);
        m_SoulRunner_Jump = m_SoulRunner.FindAction("Jump", throwIfNotFound: true);
        m_SoulRunner_CameraControl = m_SoulRunner.FindAction("CameraControl", throwIfNotFound: true);
        m_SoulRunner_CameraControlXbox = m_SoulRunner.FindAction("CameraControlXbox", throwIfNotFound: true);
        // FlappyBird
        m_FlappyBird = asset.FindActionMap("FlappyBird", throwIfNotFound: true);
        m_FlappyBird_Fly = m_FlappyBird.FindAction("Fly", throwIfNotFound: true);
        // Asteroid
        m_Asteroid = asset.FindActionMap("Asteroid", throwIfNotFound: true);
        m_Asteroid_Movement = m_Asteroid.FindAction("Movement", throwIfNotFound: true);
        m_Asteroid_Fire = m_Asteroid.FindAction("Fire", throwIfNotFound: true);
        // Mice
        m_Mice = asset.FindActionMap("Mice", throwIfNotFound: true);
        m_Mice_MoveY = m_Mice.FindAction("MoveY", throwIfNotFound: true);
        m_Mice_MoveX = m_Mice.FindAction("MoveX", throwIfNotFound: true);
        m_Mice_DetectControllerXbox = m_Mice.FindAction("DetectControllerXbox", throwIfNotFound: true);
        m_Mice_DetecectKeyborad = m_Mice.FindAction("DetecectKeyborad", throwIfNotFound: true);
        m_Mice_Action = m_Mice.FindAction("Action", throwIfNotFound: true);
        m_Mice_CameraControl = m_Mice.FindAction("CameraControl", throwIfNotFound: true);
        m_Mice_CameraControlXbox = m_Mice.FindAction("CameraControlXbox", throwIfNotFound: true);
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

    // ArcadeMain1
    private readonly InputActionMap m_ArcadeMain1;
    private IArcadeMain1Actions m_ArcadeMain1ActionsCallbackInterface;
    private readonly InputAction m_ArcadeMain1_MoveY;
    private readonly InputAction m_ArcadeMain1_MoveX;
    private readonly InputAction m_ArcadeMain1_DetectControllerXbox;
    private readonly InputAction m_ArcadeMain1_DetectKeyboardMouse;
    private readonly InputAction m_ArcadeMain1_Fire;
    private readonly InputAction m_ArcadeMain1_Option;
    private readonly InputAction m_ArcadeMain1_Action;
    private readonly InputAction m_ArcadeMain1_CameraControl;
    private readonly InputAction m_ArcadeMain1_CameraControlXbox;
    private readonly InputAction m_ArcadeMain1_DetectControllerXboxLeftStick;
    private readonly InputAction m_ArcadeMain1_DetectKeyboadAD;
    public struct ArcadeMain1Actions
    {
        private @NewActionInputManager m_Wrapper;
        public ArcadeMain1Actions(@NewActionInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveY => m_Wrapper.m_ArcadeMain1_MoveY;
        public InputAction @MoveX => m_Wrapper.m_ArcadeMain1_MoveX;
        public InputAction @DetectControllerXbox => m_Wrapper.m_ArcadeMain1_DetectControllerXbox;
        public InputAction @DetectKeyboardMouse => m_Wrapper.m_ArcadeMain1_DetectKeyboardMouse;
        public InputAction @Fire => m_Wrapper.m_ArcadeMain1_Fire;
        public InputAction @Option => m_Wrapper.m_ArcadeMain1_Option;
        public InputAction @Action => m_Wrapper.m_ArcadeMain1_Action;
        public InputAction @CameraControl => m_Wrapper.m_ArcadeMain1_CameraControl;
        public InputAction @CameraControlXbox => m_Wrapper.m_ArcadeMain1_CameraControlXbox;
        public InputAction @DetectControllerXboxLeftStick => m_Wrapper.m_ArcadeMain1_DetectControllerXboxLeftStick;
        public InputAction @DetectKeyboadAD => m_Wrapper.m_ArcadeMain1_DetectKeyboadAD;
        public InputActionMap Get() { return m_Wrapper.m_ArcadeMain1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ArcadeMain1Actions set) { return set.Get(); }
        public void SetCallbacks(IArcadeMain1Actions instance)
        {
            if (m_Wrapper.m_ArcadeMain1ActionsCallbackInterface != null)
            {
                @MoveY.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnMoveY;
                @MoveX.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnMoveX;
                @DetectControllerXbox.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectControllerXbox;
                @DetectKeyboardMouse.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectKeyboardMouse;
                @Fire.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnFire;
                @Option.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnOption;
                @Option.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnOption;
                @Option.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnOption;
                @Action.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnAction;
                @CameraControl.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnCameraControl;
                @CameraControlXbox.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnCameraControlXbox;
                @DetectControllerXboxLeftStick.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectControllerXboxLeftStick;
                @DetectControllerXboxLeftStick.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectControllerXboxLeftStick;
                @DetectControllerXboxLeftStick.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectControllerXboxLeftStick;
                @DetectKeyboadAD.started -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectKeyboadAD;
                @DetectKeyboadAD.performed -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectKeyboadAD;
                @DetectKeyboadAD.canceled -= m_Wrapper.m_ArcadeMain1ActionsCallbackInterface.OnDetectKeyboadAD;
            }
            m_Wrapper.m_ArcadeMain1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
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
                @DetectControllerXboxLeftStick.started += instance.OnDetectControllerXboxLeftStick;
                @DetectControllerXboxLeftStick.performed += instance.OnDetectControllerXboxLeftStick;
                @DetectControllerXboxLeftStick.canceled += instance.OnDetectControllerXboxLeftStick;
                @DetectKeyboadAD.started += instance.OnDetectKeyboadAD;
                @DetectKeyboadAD.performed += instance.OnDetectKeyboadAD;
                @DetectKeyboadAD.canceled += instance.OnDetectKeyboadAD;
            }
        }
    }
    public ArcadeMain1Actions @ArcadeMain1 => new ArcadeMain1Actions(this);

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

    // SoulRunner
    private readonly InputActionMap m_SoulRunner;
    private ISoulRunnerActions m_SoulRunnerActionsCallbackInterface;
    private readonly InputAction m_SoulRunner_MoveX;
    private readonly InputAction m_SoulRunner_MoveY;
    private readonly InputAction m_SoulRunner_DetectControllerXbox;
    private readonly InputAction m_SoulRunner_DetectKeyboardMouse;
    private readonly InputAction m_SoulRunner_Punch;
    private readonly InputAction m_SoulRunner_Slide;
    private readonly InputAction m_SoulRunner_Swap;
    private readonly InputAction m_SoulRunner_Start;
    private readonly InputAction m_SoulRunner_Jump;
    private readonly InputAction m_SoulRunner_CameraControl;
    private readonly InputAction m_SoulRunner_CameraControlXbox;
    public struct SoulRunnerActions
    {
        private @NewActionInputManager m_Wrapper;
        public SoulRunnerActions(@NewActionInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_SoulRunner_MoveX;
        public InputAction @MoveY => m_Wrapper.m_SoulRunner_MoveY;
        public InputAction @DetectControllerXbox => m_Wrapper.m_SoulRunner_DetectControllerXbox;
        public InputAction @DetectKeyboardMouse => m_Wrapper.m_SoulRunner_DetectKeyboardMouse;
        public InputAction @Punch => m_Wrapper.m_SoulRunner_Punch;
        public InputAction @Slide => m_Wrapper.m_SoulRunner_Slide;
        public InputAction @Swap => m_Wrapper.m_SoulRunner_Swap;
        public InputAction @Start => m_Wrapper.m_SoulRunner_Start;
        public InputAction @Jump => m_Wrapper.m_SoulRunner_Jump;
        public InputAction @CameraControl => m_Wrapper.m_SoulRunner_CameraControl;
        public InputAction @CameraControlXbox => m_Wrapper.m_SoulRunner_CameraControlXbox;
        public InputActionMap Get() { return m_Wrapper.m_SoulRunner; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SoulRunnerActions set) { return set.Get(); }
        public void SetCallbacks(ISoulRunnerActions instance)
        {
            if (m_Wrapper.m_SoulRunnerActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnMoveY;
                @DetectControllerXbox.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnDetectControllerXbox;
                @DetectKeyboardMouse.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnDetectKeyboardMouse;
                @DetectKeyboardMouse.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnDetectKeyboardMouse;
                @Punch.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnPunch;
                @Punch.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnPunch;
                @Punch.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnPunch;
                @Slide.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnSlide;
                @Slide.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnSlide;
                @Slide.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnSlide;
                @Swap.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnSwap;
                @Swap.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnSwap;
                @Swap.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnSwap;
                @Start.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnStart;
                @Jump.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnJump;
                @CameraControl.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnCameraControl;
                @CameraControlXbox.started -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.performed -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.canceled -= m_Wrapper.m_SoulRunnerActionsCallbackInterface.OnCameraControlXbox;
            }
            m_Wrapper.m_SoulRunnerActionsCallbackInterface = instance;
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
                @Punch.started += instance.OnPunch;
                @Punch.performed += instance.OnPunch;
                @Punch.canceled += instance.OnPunch;
                @Slide.started += instance.OnSlide;
                @Slide.performed += instance.OnSlide;
                @Slide.canceled += instance.OnSlide;
                @Swap.started += instance.OnSwap;
                @Swap.performed += instance.OnSwap;
                @Swap.canceled += instance.OnSwap;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
                @CameraControlXbox.started += instance.OnCameraControlXbox;
                @CameraControlXbox.performed += instance.OnCameraControlXbox;
                @CameraControlXbox.canceled += instance.OnCameraControlXbox;
            }
        }
    }
    public SoulRunnerActions @SoulRunner => new SoulRunnerActions(this);

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

    // Mice
    private readonly InputActionMap m_Mice;
    private IMiceActions m_MiceActionsCallbackInterface;
    private readonly InputAction m_Mice_MoveY;
    private readonly InputAction m_Mice_MoveX;
    private readonly InputAction m_Mice_DetectControllerXbox;
    private readonly InputAction m_Mice_DetecectKeyborad;
    private readonly InputAction m_Mice_Action;
    private readonly InputAction m_Mice_CameraControl;
    private readonly InputAction m_Mice_CameraControlXbox;
    public struct MiceActions
    {
        private @NewActionInputManager m_Wrapper;
        public MiceActions(@NewActionInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveY => m_Wrapper.m_Mice_MoveY;
        public InputAction @MoveX => m_Wrapper.m_Mice_MoveX;
        public InputAction @DetectControllerXbox => m_Wrapper.m_Mice_DetectControllerXbox;
        public InputAction @DetecectKeyborad => m_Wrapper.m_Mice_DetecectKeyborad;
        public InputAction @Action => m_Wrapper.m_Mice_Action;
        public InputAction @CameraControl => m_Wrapper.m_Mice_CameraControl;
        public InputAction @CameraControlXbox => m_Wrapper.m_Mice_CameraControlXbox;
        public InputActionMap Get() { return m_Wrapper.m_Mice; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MiceActions set) { return set.Get(); }
        public void SetCallbacks(IMiceActions instance)
        {
            if (m_Wrapper.m_MiceActionsCallbackInterface != null)
            {
                @MoveY.started -= m_Wrapper.m_MiceActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_MiceActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_MiceActionsCallbackInterface.OnMoveY;
                @MoveX.started -= m_Wrapper.m_MiceActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_MiceActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_MiceActionsCallbackInterface.OnMoveX;
                @DetectControllerXbox.started -= m_Wrapper.m_MiceActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.performed -= m_Wrapper.m_MiceActionsCallbackInterface.OnDetectControllerXbox;
                @DetectControllerXbox.canceled -= m_Wrapper.m_MiceActionsCallbackInterface.OnDetectControllerXbox;
                @DetecectKeyborad.started -= m_Wrapper.m_MiceActionsCallbackInterface.OnDetecectKeyborad;
                @DetecectKeyborad.performed -= m_Wrapper.m_MiceActionsCallbackInterface.OnDetecectKeyborad;
                @DetecectKeyborad.canceled -= m_Wrapper.m_MiceActionsCallbackInterface.OnDetecectKeyborad;
                @Action.started -= m_Wrapper.m_MiceActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_MiceActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_MiceActionsCallbackInterface.OnAction;
                @CameraControl.started -= m_Wrapper.m_MiceActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_MiceActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_MiceActionsCallbackInterface.OnCameraControl;
                @CameraControlXbox.started -= m_Wrapper.m_MiceActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.performed -= m_Wrapper.m_MiceActionsCallbackInterface.OnCameraControlXbox;
                @CameraControlXbox.canceled -= m_Wrapper.m_MiceActionsCallbackInterface.OnCameraControlXbox;
            }
            m_Wrapper.m_MiceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @DetectControllerXbox.started += instance.OnDetectControllerXbox;
                @DetectControllerXbox.performed += instance.OnDetectControllerXbox;
                @DetectControllerXbox.canceled += instance.OnDetectControllerXbox;
                @DetecectKeyborad.started += instance.OnDetecectKeyborad;
                @DetecectKeyborad.performed += instance.OnDetecectKeyborad;
                @DetecectKeyborad.canceled += instance.OnDetecectKeyborad;
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
    public MiceActions @Mice => new MiceActions(this);
    public interface IBulletHellActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnOption(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
    }
    public interface IArcadeMain1Actions
    {
        void OnMoveY(InputAction.CallbackContext context);
        void OnMoveX(InputAction.CallbackContext context);
        void OnDetectControllerXbox(InputAction.CallbackContext context);
        void OnDetectKeyboardMouse(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnOption(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
        void OnCameraControlXbox(InputAction.CallbackContext context);
        void OnDetectControllerXboxLeftStick(InputAction.CallbackContext context);
        void OnDetectKeyboadAD(InputAction.CallbackContext context);
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
    public interface ISoulRunnerActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnDetectControllerXbox(InputAction.CallbackContext context);
        void OnDetectKeyboardMouse(InputAction.CallbackContext context);
        void OnPunch(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
        void OnSwap(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
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
    public interface IMiceActions
    {
        void OnMoveY(InputAction.CallbackContext context);
        void OnMoveX(InputAction.CallbackContext context);
        void OnDetectControllerXbox(InputAction.CallbackContext context);
        void OnDetecectKeyborad(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
        void OnCameraControlXbox(InputAction.CallbackContext context);
    }
}
