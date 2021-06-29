using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMixingController : MonoBehaviour
{
    //any thing for dropping or grabbing things


    public PlayerControls mixingControls;

    GameObject selectedObject;

    Vector3 mOffset;

    float mZCoord;
    [SerializeField]
    float counterY;
    private void Awake()
    {
        mixingControls = new PlayerControls();


        mixingControls.MixingMicroGame.Grab.started += ctx => GrabObject();
        mixingControls.MixingMicroGame.Grab.canceled += ctx => DropObject();
    }


    public void GrabObject()
    {

        var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.GetComponent<IngredientBowlData>() != null)
            {

                selectedObject = selection.gameObject;
                mZCoord = Camera.main.WorldToScreenPoint(selectedObject.transform.position).z;
                mOffset = selectedObject.transform.position - GetMouseWorldPos();
                //Put things that happen when your grab an object here
                AudioManager.instance.Play("Bowl");
            }
        }
    }

    public Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Mouse.current.position.ReadValue();

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    public void DropObject()
    {
        if (MixingMicroGameController.instance.GetCurrentIngredientData() != null)
        {
            MixingMicroGameController.instance.AddToMixingBowl();
        }


        //put things for dropping items here
        selectedObject.GetComponent<IngredientBowlData>().ResetPosition();
        selectedObject = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedObject != null)
        {
            selectedObject.transform.position = GetMouseWorldPos() + mOffset;
        }
    }

    private void OnEnable()
    {
        mixingControls.Enable();
    }

    private void OnDisable()
    {
        mixingControls.Disable();
    }
}
