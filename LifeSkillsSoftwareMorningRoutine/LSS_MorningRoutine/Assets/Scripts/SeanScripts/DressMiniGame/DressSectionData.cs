using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DressSectionData : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    [SerializeField]
    GameObject attachedObjects;
    [SerializeField]
    GameObject[] AttachedArrows;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void SelectSection()
    {
        //Make sure one section is correct
        DressMiniGameManager.instance.EnableASection(attachedObjects, AttachedArrows);
        
    }

    public void OnSelect(BaseEventData eventData)
    {
        SelectSection();
    }

    public void OnDeselect(BaseEventData eventData)
    {
        attachedObjects.GetComponent<ClothingCatalogData>().EndEarly();
    }
}
