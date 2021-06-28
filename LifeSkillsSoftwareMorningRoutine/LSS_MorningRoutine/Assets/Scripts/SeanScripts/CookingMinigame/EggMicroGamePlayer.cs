using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class EggMicroGamePlayer : MonoBehaviour
{
    //any thing for dropping or grabbing things


    public PlayerControls mixingControls;

    GameObject selectedObject;

    Vector3 mOffset;

    float mZCoord;
    [SerializeField]
    float counterY;

    [SerializeField]
    float eggSpeed = 4;
    Vector3 startPos;
    public Vector3 direction;
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
        Debug.Log("Fired");
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Fired and hit" + hit.transform.name);

            var selection = hit.transform;
            if (selection.GetComponent<Egg>() != null)
            {

                selectedObject = selection.gameObject;
                mZCoord = Camera.main.WorldToScreenPoint(selectedObject.transform.position).z;
                mOffset = selectedObject.transform.position - GetMouseWorldPos();
                //Put things that happen when your grab an object here
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
        //selectedObject.GetComponent<Egg>().ResetPosition();
        selectedObject = null;
    }

    public void OnMovement()
    {
        startPos = selectedObject.transform.position;//the startingPosition of the player before the mov

        direction = GetMouseWorldPos() - startPos;

        float deadZone = .3f;
        bool directionChosen = true;

        if (((Vector2)direction).magnitude < deadZone)
        {
            directionChosen = false;

        }
        else
        {
            directionChosen = true;
        }

        if (directionChosen)
        {

            Vector3 oldPosition = selectedObject.transform.position;
            Vector3 pos;


            pos = (Vector2)oldPosition + (Vector2)direction.normalized * (eggSpeed + 3) * Time.fixedDeltaTime;//updated position area
                                                                                                              //rigidbody2d.MovePosition(pos);//actual movement of player
            //selectedObject.GetComponent<Rigidbody>().MovePosition(pos + mOffset);//smooths it out for non-mobile
            selectedObject.transform.position = pos + mOffset;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedObject != null)
        {
             selectedObject.GetComponent<Rigidbody>().MovePosition(GetMouseWorldPos() + mOffset);
            Debug.Log(selectedObject.GetComponent<Rigidbody>().velocity);

            //OnMovement();
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
