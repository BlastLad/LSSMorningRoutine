using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressSectionData : MonoBehaviour
{
    [SerializeField]
    GameObject attachedObjects;
    
    
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
        DressMiniGameManager.instance.EnableASection(attachedObjects);
    }
}
