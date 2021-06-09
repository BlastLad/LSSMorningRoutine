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
    [SerializeField]
    Image[] BracketImages;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void SetAttachedObject(GameObject val)
    {
        attachedObjects = val;
    }

    public void SelectSection()
    {
        foreach (Image spriteThing in BracketImages)
        {
            spriteThing.enabled = true;
        }
        //Make sure one section is correct
        DressMiniGameManager.instance.EnableASection(attachedObjects, AttachedArrows);
    
        
    }

    public void OnSelect(BaseEventData eventData)
    {
        SelectSection();
    }

    public void OnDeselect(BaseEventData eventData)
    {
        foreach (Image spriteThing in BracketImages)
        {
            spriteThing.enabled = false;
        }

        attachedObjects.GetComponent<ClothingCatalogData>().EndEarly();
    }
}
