// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/PlayerControls.inputactions'

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
            ""name"": ""Base"",
            ""id"": ""e1b917ab-4f81-4234-a131-dd0f8fff5623"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""e20e9bb9-d435-4ae2-8e1d-46f9b3c6e62e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""2d0e9f01-ad5c-4126-bf09-ce63c02f2b39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""219f9f0f-bd55-4228-924b-dd8df50e24e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5526f0a2-3e8b-43b7-ab73-70fbcf96e69d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""034e07d3-b967-4ec2-93b6-76dcffc09b46"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c51476d3-f2ae-4d27-a075-1e9cdc37f618"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""423ea8bc-2074-43e5-81a3-ab4bfa37b357"",
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
                    ""id"": ""bb20c935-e217-4ffb-9e5a-737d7ba37460"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""20984890-f543-4f17-837e-30b99b718047"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bbe75476-7655-4ae4-ab68-86c42390a42e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a5ea308b-27af-4b84-9230-12cd50159403"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector(Xbox)"",
                    ""id"": ""49318e26-def1-4749-993b-deba00e77a46"",
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
                    ""id"": ""4f5399e6-f186-4243-84b3-f4a793182bdf"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ae53917b-4782-48ae-bf64-c88e654635d2"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ce4419cf-ea57-494b-87f9-d1d916ae9bf1"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b3a45f57-f7bf-4c8d-8179-142d626c3dc1"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector(Keyboard)"",
                    ""id"": ""283db936-533d-4482-b1b6-5ed8d76ecc22"",
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
                    ""id"": ""a6cb394d-946f-4137-9494-9e43e1cef630"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7bf9c6bd-581f-4b4a-9786-bf66e478067d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9378afaf-5771-4752-ac52-2bd911328d61"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""351cda4f-b878-44cb-85cd-e3406cd9f3e9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""12742a04-36a2-4369-bc36-964a87d718a8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6ad23f7c-3cee-4458-a4f4-0720bc225e13"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1d499706-61e3-47f8-a51f-c6e818dbabe3"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f0e24e68-8bd8-4e10-9ab5-d0cc413aef1c"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7df2b5fc-871f-4a71-b695-1acc3da24533"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector(Xbox)"",
                    ""id"": ""ee106222-9bc2-4f9f-b3fa-2669ad1ff0aa"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8add35d8-1333-4f87-b77d-e6b264d421b4"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e1a0783a-037b-4eee-b193-2eb0448a2a6a"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""645afbe9-fa97-4542-8ec6-d125e452c211"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fb642f64-3c93-4802-a2a4-9fb44ede2e09"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ceaf7abd-308d-4c43-a8b2-422b2ae4d0f1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DressMinigame"",
            ""id"": ""c826b736-2295-48cf-b398-478c5d66b1ae"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""aaee5848-19a9-4462-94a4-11c492de13e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""8400694b-dde3-40d4-b05c-07e5ff274d47"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c3fe6350-e399-4978-bba8-df3d4cd1789e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""1708aebd-5931-4bee-a778-372b51983a36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f41d8460-c569-4a50-b05c-c9962a552c4d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00864df1-a0e2-4a19-9d39-f0f5538d5488"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""400b7f93-ca2e-4892-972a-fb6289a408dc"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""860973f8-9b1b-40e9-bd61-778264bfe09e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8c824a8-9ac0-4a87-ad50-eab7a177f394"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1edca0e-fad6-4efd-baf4-0d43403cf009"",
                    ""path"": ""<XInputController>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f5153a12-c4a9-4084-b33d-44f6b658ab9b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7d1536a6-05c2-491c-bf5d-a8716745f190"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""31b89da3-137c-402b-b5cc-4cabda77bbb1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""08e5dbf4-52ca-4633-9cd4-6d1c05b76f60"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f74d49b5-d6f9-48bf-af92-c728b557795c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fad2848a-f592-4b70-8aa3-aee7b87ab86d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b1f280e-e83b-472a-aba5-0fb5a6ea0b67"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector(keys)"",
                    ""id"": ""9feed35c-89bb-4ee9-aaa1-bfe8606ee6e3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8395f89b-e79f-4199-9f24-15bc5f3ef80c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""68e077b7-b13c-47d6-afdf-4c86fa4a67e2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b93ce392-3e26-44a8-8059-58f245701d25"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""767ec8d5-96d3-459d-be77-85ccff2a270f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""38abbaca-3c12-4035-9dd5-e807c692d0cc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f8524b4-7c71-483d-9231-cd52dd5f5cce"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22d9e1ae-da3e-4aa3-8163-bd2d9761f12e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""caaac041-7f83-4e10-9821-7f89cd2b4699"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32d26295-bb24-4004-a7bf-50740e91c12f"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb9a080e-8d2a-4039-b360-e2129dfbc926"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96c5705a-73b5-437a-bdc5-91582170bb57"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e7dfc7b-08d1-46bc-aa8b-dcff4ee0105e"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39516d03-ddcd-42ac-8ee3-e187000bd25a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f468b2a-c6d2-4c30-9ed9-7b4233941d00"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CuttingMicroGame"",
            ""id"": ""28193d8b-967d-4b11-a786-74dc11a5c23b"",
            ""actions"": [
                {
                    ""name"": ""CutForward"",
                    ""type"": ""Button"",
                    ""id"": ""85b920fa-9856-4ba0-8d89-6d446b531b83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CutBackward"",
                    ""type"": ""Button"",
                    ""id"": ""11b6fdff-6f4e-48cd-90ed-27667d6c6a6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CutLeft"",
                    ""type"": ""Button"",
                    ""id"": ""6f5b2e29-2055-47dc-8bdd-f82025c4737f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CutRight"",
                    ""type"": ""Button"",
                    ""id"": ""f22ca751-c720-4fdb-b318-79beba63601c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fdfed386-4940-491f-b1f9-c91303cd59c8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""735c77cc-3dca-4e4c-a01e-1d33058c5c68"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbddfbce-d320-43d5-b5ed-665facaa8aa7"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99241a6b-7164-4094-a3fb-4fa6e663f7ef"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63c56bf9-f0d8-481d-adb0-323800c2c3f3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a9e59fc-df58-475a-8b6c-15cfb3cc58bf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eccc4b7-3422-4e26-88e0-45b0320f5df2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa5900bf-4a67-429f-b1c3-64eb098576bb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79dd4e83-a0b1-4f65-af5c-c9dfeeee2c51"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c55806b9-3cee-4003-b606-e5babb1311b9"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da1ae197-00c3-4868-b06b-522b88f330e2"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea655e5c-fa54-4f76-918f-bceaa35a71ca"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e3a6c00-38c4-4471-b9c8-9ac4274aeaa2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f1bf000-5821-4a62-90f1-1934ab5c91ef"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dce3f611-30f6-46e1-80c2-3bcbdf9f863b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95758513-e77a-49ec-9979-ac53face14cd"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6f02810-4ff3-49a5-969c-6550c2c9ccd2"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c38e1999-78a5-4224-bbd3-f8a322908e55"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89567ed5-8313-412c-8738-40016a756b19"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""292a85fa-d62f-4ff1-82e6-2d6ef0a9ff38"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa00ff93-5d09-40d0-9bff-88dab82af9b2"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9934d36-23a1-47b8-8276-3fb63255da5f"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5da8f16a-2410-47ea-ba4a-e40e27a34307"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5108f0d8-58c6-4442-a47d-8d807169e075"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CutRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HeatMicroGame"",
            ""id"": ""91c9c0a9-86cc-43d4-afbf-e494cd8d4557"",
            ""actions"": [
                {
                    ""name"": ""HeatUp"",
                    ""type"": ""Button"",
                    ""id"": ""71dec3f6-5635-4cf3-879a-2468908d63a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09643507-b34e-49bd-ad7c-2f875ed04868"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""HeatUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41c5b7ff-774b-425e-a1a9-1d3671c66302"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HeatUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98cf0014-5eec-488c-a948-0d5f2ac87452"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""HeatUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MixingMicroGame"",
            ""id"": ""6751db76-17dc-46ce-bc3c-e58292243fa4"",
            ""actions"": [
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""d1079c18-bd1f-44ce-8b10-3a676c1cd0ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spin"",
                    ""type"": ""Button"",
                    ""id"": ""4731c518-239d-43b9-9a72-ec33339aa825"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crack"",
                    ""type"": ""Button"",
                    ""id"": ""c4584cfa-6e27-4b13-a578-0b52c1ffa9f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2f241664-6fcd-423c-9ed7-44be8529ea00"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0e23030-c25b-4f2c-9c30-2df0496683d9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f036901-b332-4d35-b610-de98332aafde"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Spin"",
                    ""id"": ""af93c98e-e542-444e-a698-6e2563f24c23"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f4f18806-798c-45ed-b815-20cd9e136754"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""80b937fe-a07b-4a1e-98a8-4b88eb449c86"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2945c3d8-b17e-4c69-8eb9-1796f2d6d759"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e5d3798b-2843-4dbd-85d6-a72e9c9ab6b2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""SpinArrows"",
                    ""id"": ""8f212507-c00e-4731-ba73-ae43734815ff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7b570189-07b7-47a9-b3b6-3d5537b8a6f8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f427cb33-9db6-4a1f-be23-60f7cacd2c54"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""372afe13-5958-4fdc-b6cb-d09c6addb330"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ec135194-7b98-451f-a996-7cd010abfc5a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D VectorGamePad"",
                    ""id"": ""5b2e3417-e1bb-48e4-a92f-e56902fedb51"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0b00631a-07aa-457b-929f-ed476cd6ff07"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6f4b9ee7-51d9-4310-a1c2-4ab4a02dca43"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""020cd50b-f6fc-4e20-9f22-e496e1b3c9a7"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""54b3a571-9aef-4344-8c63-bc529f6f4a2e"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector LeftStick"",
                    ""id"": ""cafbadd5-151b-438d-a16c-fc41405f8e2c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""528f47a8-6e6f-4e4d-a26d-b32f856d2d0a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fe5c2326-22b7-4a39-9b56-bee355dea793"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b6aa583c-aa85-41e4-8589-0c2fe172f62a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8403b5bf-7b79-4c2c-a060-88cb01199138"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D VectorXbox"",
                    ""id"": ""4ccb6394-6727-4915-94e9-728c5e632fa2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""94d65305-59b3-490e-8677-a2617383a1c9"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8aa00cc5-3ed6-431a-badd-7d206c155557"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8949006b-4419-459e-b287-ea6cabc2e1a4"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a6cfab65-d8bd-40dc-9a3e-8bbc462ca621"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e88f2c15-9799-485c-929d-5c7c3c898b61"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0e3a138b-acfc-469a-b7b5-fbba25d1b41b"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""060384e1-1a8f-43dc-9641-277c27e31b32"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c0d578f6-ac9b-4054-9b5f-b9b8f575597c"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9e810299-e697-4e8f-8663-9e2d965b6a05"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6c398508-d10d-4b7e-a2c7-1bde981f249f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Crack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""041a03cf-3474-48b9-96a8-a3f05b27f1fb"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Crack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8783c63-3dd4-427b-b45e-46c498c0be2a"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Crack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BrushingTeethGame"",
            ""id"": ""7759a182-ac8c-48ac-9f5e-814ae391851b"",
            ""actions"": [
                {
                    ""name"": ""LeftMouse"",
                    ""type"": ""Button"",
                    ""id"": ""436ad169-96e4-43df-a36e-41d60ccb2410"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMouse"",
                    ""type"": ""Button"",
                    ""id"": ""2fe7d937-7349-4100-88d2-23a7630f2208"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""223847ef-7059-4376-8327-3baab447a5cd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""LeftMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f4b005e-08ab-4f85-b1f7-ae1342356e7e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeftMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""178c9e1f-fd5e-439a-901a-fe63d8d31bab"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RightMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ShowerGame"",
            ""id"": ""cbd337bb-6684-42f0-ad0a-6484753259a3"",
            ""actions"": [
                {
                    ""name"": ""SelectionTool"",
                    ""type"": ""Button"",
                    ""id"": ""2bfaeab2-77a7-4732-87d4-87f01f471054"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SoapTool"",
                    ""type"": ""Button"",
                    ""id"": ""ee9947ee-7955-4682-8bf3-2d9f65b834cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BodyWashTool"",
                    ""type"": ""Button"",
                    ""id"": ""70a06070-2e78-4962-907e-1d8081d9a38e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShowerTool"",
                    ""type"": ""Button"",
                    ""id"": ""b6575265-999e-4ce6-8d2b-0587c3bc2397"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActivateTool"",
                    ""type"": ""Button"",
                    ""id"": ""abd99fbe-ba75-4f71-abab-feebfe3f3cc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryActivation"",
                    ""type"": ""Button"",
                    ""id"": ""acc3c7d7-44dc-4096-ab17-9f45fb9ff2ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c46d88c4-f9da-4b6d-8e83-c44972792426"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SelectionTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a47ca35d-86a3-4abc-b4e8-68603bd48074"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SelectionTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""810c3620-9052-4810-9704-1c6e3bbbb46e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SoapTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""455d7e3a-5a0a-4feb-8df7-9a4b57b84f7c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SoapTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12971b26-5b49-41f4-8127-dc1bebb7fd08"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BodyWashTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc1af716-a0db-428f-b0c2-d1308334986d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BodyWashTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43b3d1f6-f31f-4144-be82-bd8335379321"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShowerTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c29eb33-9044-4963-b50e-aafd3588b5d4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ShowerTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b161c7fc-828e-467c-80a1-eafc0f454fb6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ActivateTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c720e87-186e-4b21-b103-511808ded521"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SecondaryActivation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Title"",
            ""id"": ""915d9412-d2bf-48bc-9be1-b1c6e8e3143c"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""cbdf2b24-44b6-4535-aae5-e9c3962ffebc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20dcb025-4ce2-4e15-9f2a-f4c27a63ca59"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Controller"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
        }
    ]
}");
        // Base
        m_Base = asset.FindActionMap("Base", throwIfNotFound: true);
        m_Base_Interact = m_Base.FindAction("Interact", throwIfNotFound: true);
        m_Base_Movement = m_Base.FindAction("Movement", throwIfNotFound: true);
        m_Base_CameraMovement = m_Base.FindAction("CameraMovement", throwIfNotFound: true);
        // DressMinigame
        m_DressMinigame = asset.FindActionMap("DressMinigame", throwIfNotFound: true);
        m_DressMinigame_Select = m_DressMinigame.FindAction("Select", throwIfNotFound: true);
        m_DressMinigame_Navigate = m_DressMinigame.FindAction("Navigate", throwIfNotFound: true);
        m_DressMinigame_MoveLeft = m_DressMinigame.FindAction("MoveLeft", throwIfNotFound: true);
        m_DressMinigame_MoveRight = m_DressMinigame.FindAction("MoveRight", throwIfNotFound: true);
        // CuttingMicroGame
        m_CuttingMicroGame = asset.FindActionMap("CuttingMicroGame", throwIfNotFound: true);
        m_CuttingMicroGame_CutForward = m_CuttingMicroGame.FindAction("CutForward", throwIfNotFound: true);
        m_CuttingMicroGame_CutBackward = m_CuttingMicroGame.FindAction("CutBackward", throwIfNotFound: true);
        m_CuttingMicroGame_CutLeft = m_CuttingMicroGame.FindAction("CutLeft", throwIfNotFound: true);
        m_CuttingMicroGame_CutRight = m_CuttingMicroGame.FindAction("CutRight", throwIfNotFound: true);
        // HeatMicroGame
        m_HeatMicroGame = asset.FindActionMap("HeatMicroGame", throwIfNotFound: true);
        m_HeatMicroGame_HeatUp = m_HeatMicroGame.FindAction("HeatUp", throwIfNotFound: true);
        // MixingMicroGame
        m_MixingMicroGame = asset.FindActionMap("MixingMicroGame", throwIfNotFound: true);
        m_MixingMicroGame_Grab = m_MixingMicroGame.FindAction("Grab", throwIfNotFound: true);
        m_MixingMicroGame_Spin = m_MixingMicroGame.FindAction("Spin", throwIfNotFound: true);
        m_MixingMicroGame_Crack = m_MixingMicroGame.FindAction("Crack", throwIfNotFound: true);
        // BrushingTeethGame
        m_BrushingTeethGame = asset.FindActionMap("BrushingTeethGame", throwIfNotFound: true);
        m_BrushingTeethGame_LeftMouse = m_BrushingTeethGame.FindAction("LeftMouse", throwIfNotFound: true);
        m_BrushingTeethGame_RightMouse = m_BrushingTeethGame.FindAction("RightMouse", throwIfNotFound: true);
        // ShowerGame
        m_ShowerGame = asset.FindActionMap("ShowerGame", throwIfNotFound: true);
        m_ShowerGame_SelectionTool = m_ShowerGame.FindAction("SelectionTool", throwIfNotFound: true);
        m_ShowerGame_SoapTool = m_ShowerGame.FindAction("SoapTool", throwIfNotFound: true);
        m_ShowerGame_BodyWashTool = m_ShowerGame.FindAction("BodyWashTool", throwIfNotFound: true);
        m_ShowerGame_ShowerTool = m_ShowerGame.FindAction("ShowerTool", throwIfNotFound: true);
        m_ShowerGame_ActivateTool = m_ShowerGame.FindAction("ActivateTool", throwIfNotFound: true);
        m_ShowerGame_SecondaryActivation = m_ShowerGame.FindAction("SecondaryActivation", throwIfNotFound: true);
        // Title
        m_Title = asset.FindActionMap("Title", throwIfNotFound: true);
        m_Title_Select = m_Title.FindAction("Select", throwIfNotFound: true);
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

    // Base
    private readonly InputActionMap m_Base;
    private IBaseActions m_BaseActionsCallbackInterface;
    private readonly InputAction m_Base_Interact;
    private readonly InputAction m_Base_Movement;
    private readonly InputAction m_Base_CameraMovement;
    public struct BaseActions
    {
        private @PlayerControls m_Wrapper;
        public BaseActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Base_Interact;
        public InputAction @Movement => m_Wrapper.m_Base_Movement;
        public InputAction @CameraMovement => m_Wrapper.m_Base_CameraMovement;
        public InputActionMap Get() { return m_Wrapper.m_Base; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseActions set) { return set.Get(); }
        public void SetCallbacks(IBaseActions instance)
        {
            if (m_Wrapper.m_BaseActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_BaseActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_BaseActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_BaseActionsCallbackInterface.OnInteract;
                @Movement.started -= m_Wrapper.m_BaseActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BaseActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BaseActionsCallbackInterface.OnMovement;
                @CameraMovement.started -= m_Wrapper.m_BaseActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_BaseActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_BaseActionsCallbackInterface.OnCameraMovement;
            }
            m_Wrapper.m_BaseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
            }
        }
    }
    public BaseActions @Base => new BaseActions(this);

    // DressMinigame
    private readonly InputActionMap m_DressMinigame;
    private IDressMinigameActions m_DressMinigameActionsCallbackInterface;
    private readonly InputAction m_DressMinigame_Select;
    private readonly InputAction m_DressMinigame_Navigate;
    private readonly InputAction m_DressMinigame_MoveLeft;
    private readonly InputAction m_DressMinigame_MoveRight;
    public struct DressMinigameActions
    {
        private @PlayerControls m_Wrapper;
        public DressMinigameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_DressMinigame_Select;
        public InputAction @Navigate => m_Wrapper.m_DressMinigame_Navigate;
        public InputAction @MoveLeft => m_Wrapper.m_DressMinigame_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_DressMinigame_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_DressMinigame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DressMinigameActions set) { return set.Get(); }
        public void SetCallbacks(IDressMinigameActions instance)
        {
            if (m_Wrapper.m_DressMinigameActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnSelect;
                @Navigate.started -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnNavigate;
                @MoveLeft.started -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_DressMinigameActionsCallbackInterface.OnMoveRight;
            }
            m_Wrapper.m_DressMinigameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
            }
        }
    }
    public DressMinigameActions @DressMinigame => new DressMinigameActions(this);

    // CuttingMicroGame
    private readonly InputActionMap m_CuttingMicroGame;
    private ICuttingMicroGameActions m_CuttingMicroGameActionsCallbackInterface;
    private readonly InputAction m_CuttingMicroGame_CutForward;
    private readonly InputAction m_CuttingMicroGame_CutBackward;
    private readonly InputAction m_CuttingMicroGame_CutLeft;
    private readonly InputAction m_CuttingMicroGame_CutRight;
    public struct CuttingMicroGameActions
    {
        private @PlayerControls m_Wrapper;
        public CuttingMicroGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CutForward => m_Wrapper.m_CuttingMicroGame_CutForward;
        public InputAction @CutBackward => m_Wrapper.m_CuttingMicroGame_CutBackward;
        public InputAction @CutLeft => m_Wrapper.m_CuttingMicroGame_CutLeft;
        public InputAction @CutRight => m_Wrapper.m_CuttingMicroGame_CutRight;
        public InputActionMap Get() { return m_Wrapper.m_CuttingMicroGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CuttingMicroGameActions set) { return set.Get(); }
        public void SetCallbacks(ICuttingMicroGameActions instance)
        {
            if (m_Wrapper.m_CuttingMicroGameActionsCallbackInterface != null)
            {
                @CutForward.started -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutForward;
                @CutForward.performed -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutForward;
                @CutForward.canceled -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutForward;
                @CutBackward.started -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutBackward;
                @CutBackward.performed -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutBackward;
                @CutBackward.canceled -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutBackward;
                @CutLeft.started -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutLeft;
                @CutLeft.performed -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutLeft;
                @CutLeft.canceled -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutLeft;
                @CutRight.started -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutRight;
                @CutRight.performed -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutRight;
                @CutRight.canceled -= m_Wrapper.m_CuttingMicroGameActionsCallbackInterface.OnCutRight;
            }
            m_Wrapper.m_CuttingMicroGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CutForward.started += instance.OnCutForward;
                @CutForward.performed += instance.OnCutForward;
                @CutForward.canceled += instance.OnCutForward;
                @CutBackward.started += instance.OnCutBackward;
                @CutBackward.performed += instance.OnCutBackward;
                @CutBackward.canceled += instance.OnCutBackward;
                @CutLeft.started += instance.OnCutLeft;
                @CutLeft.performed += instance.OnCutLeft;
                @CutLeft.canceled += instance.OnCutLeft;
                @CutRight.started += instance.OnCutRight;
                @CutRight.performed += instance.OnCutRight;
                @CutRight.canceled += instance.OnCutRight;
            }
        }
    }
    public CuttingMicroGameActions @CuttingMicroGame => new CuttingMicroGameActions(this);

    // HeatMicroGame
    private readonly InputActionMap m_HeatMicroGame;
    private IHeatMicroGameActions m_HeatMicroGameActionsCallbackInterface;
    private readonly InputAction m_HeatMicroGame_HeatUp;
    public struct HeatMicroGameActions
    {
        private @PlayerControls m_Wrapper;
        public HeatMicroGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HeatUp => m_Wrapper.m_HeatMicroGame_HeatUp;
        public InputActionMap Get() { return m_Wrapper.m_HeatMicroGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeatMicroGameActions set) { return set.Get(); }
        public void SetCallbacks(IHeatMicroGameActions instance)
        {
            if (m_Wrapper.m_HeatMicroGameActionsCallbackInterface != null)
            {
                @HeatUp.started -= m_Wrapper.m_HeatMicroGameActionsCallbackInterface.OnHeatUp;
                @HeatUp.performed -= m_Wrapper.m_HeatMicroGameActionsCallbackInterface.OnHeatUp;
                @HeatUp.canceled -= m_Wrapper.m_HeatMicroGameActionsCallbackInterface.OnHeatUp;
            }
            m_Wrapper.m_HeatMicroGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HeatUp.started += instance.OnHeatUp;
                @HeatUp.performed += instance.OnHeatUp;
                @HeatUp.canceled += instance.OnHeatUp;
            }
        }
    }
    public HeatMicroGameActions @HeatMicroGame => new HeatMicroGameActions(this);

    // MixingMicroGame
    private readonly InputActionMap m_MixingMicroGame;
    private IMixingMicroGameActions m_MixingMicroGameActionsCallbackInterface;
    private readonly InputAction m_MixingMicroGame_Grab;
    private readonly InputAction m_MixingMicroGame_Spin;
    private readonly InputAction m_MixingMicroGame_Crack;
    public struct MixingMicroGameActions
    {
        private @PlayerControls m_Wrapper;
        public MixingMicroGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grab => m_Wrapper.m_MixingMicroGame_Grab;
        public InputAction @Spin => m_Wrapper.m_MixingMicroGame_Spin;
        public InputAction @Crack => m_Wrapper.m_MixingMicroGame_Crack;
        public InputActionMap Get() { return m_Wrapper.m_MixingMicroGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MixingMicroGameActions set) { return set.Get(); }
        public void SetCallbacks(IMixingMicroGameActions instance)
        {
            if (m_Wrapper.m_MixingMicroGameActionsCallbackInterface != null)
            {
                @Grab.started -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnGrab;
                @Spin.started -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnSpin;
                @Spin.performed -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnSpin;
                @Spin.canceled -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnSpin;
                @Crack.started -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnCrack;
                @Crack.performed -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnCrack;
                @Crack.canceled -= m_Wrapper.m_MixingMicroGameActionsCallbackInterface.OnCrack;
            }
            m_Wrapper.m_MixingMicroGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Spin.started += instance.OnSpin;
                @Spin.performed += instance.OnSpin;
                @Spin.canceled += instance.OnSpin;
                @Crack.started += instance.OnCrack;
                @Crack.performed += instance.OnCrack;
                @Crack.canceled += instance.OnCrack;
            }
        }
    }
    public MixingMicroGameActions @MixingMicroGame => new MixingMicroGameActions(this);

    // BrushingTeethGame
    private readonly InputActionMap m_BrushingTeethGame;
    private IBrushingTeethGameActions m_BrushingTeethGameActionsCallbackInterface;
    private readonly InputAction m_BrushingTeethGame_LeftMouse;
    private readonly InputAction m_BrushingTeethGame_RightMouse;
    public struct BrushingTeethGameActions
    {
        private @PlayerControls m_Wrapper;
        public BrushingTeethGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftMouse => m_Wrapper.m_BrushingTeethGame_LeftMouse;
        public InputAction @RightMouse => m_Wrapper.m_BrushingTeethGame_RightMouse;
        public InputActionMap Get() { return m_Wrapper.m_BrushingTeethGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BrushingTeethGameActions set) { return set.Get(); }
        public void SetCallbacks(IBrushingTeethGameActions instance)
        {
            if (m_Wrapper.m_BrushingTeethGameActionsCallbackInterface != null)
            {
                @LeftMouse.started -= m_Wrapper.m_BrushingTeethGameActionsCallbackInterface.OnLeftMouse;
                @LeftMouse.performed -= m_Wrapper.m_BrushingTeethGameActionsCallbackInterface.OnLeftMouse;
                @LeftMouse.canceled -= m_Wrapper.m_BrushingTeethGameActionsCallbackInterface.OnLeftMouse;
                @RightMouse.started -= m_Wrapper.m_BrushingTeethGameActionsCallbackInterface.OnRightMouse;
                @RightMouse.performed -= m_Wrapper.m_BrushingTeethGameActionsCallbackInterface.OnRightMouse;
                @RightMouse.canceled -= m_Wrapper.m_BrushingTeethGameActionsCallbackInterface.OnRightMouse;
            }
            m_Wrapper.m_BrushingTeethGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftMouse.started += instance.OnLeftMouse;
                @LeftMouse.performed += instance.OnLeftMouse;
                @LeftMouse.canceled += instance.OnLeftMouse;
                @RightMouse.started += instance.OnRightMouse;
                @RightMouse.performed += instance.OnRightMouse;
                @RightMouse.canceled += instance.OnRightMouse;
            }
        }
    }
    public BrushingTeethGameActions @BrushingTeethGame => new BrushingTeethGameActions(this);

    // ShowerGame
    private readonly InputActionMap m_ShowerGame;
    private IShowerGameActions m_ShowerGameActionsCallbackInterface;
    private readonly InputAction m_ShowerGame_SelectionTool;
    private readonly InputAction m_ShowerGame_SoapTool;
    private readonly InputAction m_ShowerGame_BodyWashTool;
    private readonly InputAction m_ShowerGame_ShowerTool;
    private readonly InputAction m_ShowerGame_ActivateTool;
    private readonly InputAction m_ShowerGame_SecondaryActivation;
    public struct ShowerGameActions
    {
        private @PlayerControls m_Wrapper;
        public ShowerGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SelectionTool => m_Wrapper.m_ShowerGame_SelectionTool;
        public InputAction @SoapTool => m_Wrapper.m_ShowerGame_SoapTool;
        public InputAction @BodyWashTool => m_Wrapper.m_ShowerGame_BodyWashTool;
        public InputAction @ShowerTool => m_Wrapper.m_ShowerGame_ShowerTool;
        public InputAction @ActivateTool => m_Wrapper.m_ShowerGame_ActivateTool;
        public InputAction @SecondaryActivation => m_Wrapper.m_ShowerGame_SecondaryActivation;
        public InputActionMap Get() { return m_Wrapper.m_ShowerGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShowerGameActions set) { return set.Get(); }
        public void SetCallbacks(IShowerGameActions instance)
        {
            if (m_Wrapper.m_ShowerGameActionsCallbackInterface != null)
            {
                @SelectionTool.started -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSelectionTool;
                @SelectionTool.performed -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSelectionTool;
                @SelectionTool.canceled -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSelectionTool;
                @SoapTool.started -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSoapTool;
                @SoapTool.performed -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSoapTool;
                @SoapTool.canceled -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSoapTool;
                @BodyWashTool.started -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnBodyWashTool;
                @BodyWashTool.performed -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnBodyWashTool;
                @BodyWashTool.canceled -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnBodyWashTool;
                @ShowerTool.started -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnShowerTool;
                @ShowerTool.performed -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnShowerTool;
                @ShowerTool.canceled -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnShowerTool;
                @ActivateTool.started -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnActivateTool;
                @ActivateTool.performed -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnActivateTool;
                @ActivateTool.canceled -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnActivateTool;
                @SecondaryActivation.started -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSecondaryActivation;
                @SecondaryActivation.performed -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSecondaryActivation;
                @SecondaryActivation.canceled -= m_Wrapper.m_ShowerGameActionsCallbackInterface.OnSecondaryActivation;
            }
            m_Wrapper.m_ShowerGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SelectionTool.started += instance.OnSelectionTool;
                @SelectionTool.performed += instance.OnSelectionTool;
                @SelectionTool.canceled += instance.OnSelectionTool;
                @SoapTool.started += instance.OnSoapTool;
                @SoapTool.performed += instance.OnSoapTool;
                @SoapTool.canceled += instance.OnSoapTool;
                @BodyWashTool.started += instance.OnBodyWashTool;
                @BodyWashTool.performed += instance.OnBodyWashTool;
                @BodyWashTool.canceled += instance.OnBodyWashTool;
                @ShowerTool.started += instance.OnShowerTool;
                @ShowerTool.performed += instance.OnShowerTool;
                @ShowerTool.canceled += instance.OnShowerTool;
                @ActivateTool.started += instance.OnActivateTool;
                @ActivateTool.performed += instance.OnActivateTool;
                @ActivateTool.canceled += instance.OnActivateTool;
                @SecondaryActivation.started += instance.OnSecondaryActivation;
                @SecondaryActivation.performed += instance.OnSecondaryActivation;
                @SecondaryActivation.canceled += instance.OnSecondaryActivation;
            }
        }
    }
    public ShowerGameActions @ShowerGame => new ShowerGameActions(this);

    // Title
    private readonly InputActionMap m_Title;
    private ITitleActions m_TitleActionsCallbackInterface;
    private readonly InputAction m_Title_Select;
    public struct TitleActions
    {
        private @PlayerControls m_Wrapper;
        public TitleActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Title_Select;
        public InputActionMap Get() { return m_Wrapper.m_Title; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TitleActions set) { return set.Get(); }
        public void SetCallbacks(ITitleActions instance)
        {
            if (m_Wrapper.m_TitleActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_TitleActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_TitleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public TitleActions @Title => new TitleActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IBaseActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
    }
    public interface IDressMinigameActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
    public interface ICuttingMicroGameActions
    {
        void OnCutForward(InputAction.CallbackContext context);
        void OnCutBackward(InputAction.CallbackContext context);
        void OnCutLeft(InputAction.CallbackContext context);
        void OnCutRight(InputAction.CallbackContext context);
    }
    public interface IHeatMicroGameActions
    {
        void OnHeatUp(InputAction.CallbackContext context);
    }
    public interface IMixingMicroGameActions
    {
        void OnGrab(InputAction.CallbackContext context);
        void OnSpin(InputAction.CallbackContext context);
        void OnCrack(InputAction.CallbackContext context);
    }
    public interface IBrushingTeethGameActions
    {
        void OnLeftMouse(InputAction.CallbackContext context);
        void OnRightMouse(InputAction.CallbackContext context);
    }
    public interface IShowerGameActions
    {
        void OnSelectionTool(InputAction.CallbackContext context);
        void OnSoapTool(InputAction.CallbackContext context);
        void OnBodyWashTool(InputAction.CallbackContext context);
        void OnShowerTool(InputAction.CallbackContext context);
        void OnActivateTool(InputAction.CallbackContext context);
        void OnSecondaryActivation(InputAction.CallbackContext context);
    }
    public interface ITitleActions
    {
        void OnSelect(InputAction.CallbackContext context);
    }
}
