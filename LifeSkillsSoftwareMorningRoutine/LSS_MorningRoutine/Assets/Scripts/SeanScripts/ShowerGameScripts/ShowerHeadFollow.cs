using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShowerHeadFollow : MonoBehaviour
{
    public Transform pos;
    [SerializeField]
    private LayerMask layermask;
    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, layermask))
        {
            transform.position = hit.point;
            pos.position = hit.point;
        }
    }

}
