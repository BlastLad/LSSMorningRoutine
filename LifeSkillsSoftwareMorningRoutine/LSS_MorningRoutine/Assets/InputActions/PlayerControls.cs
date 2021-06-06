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
}
