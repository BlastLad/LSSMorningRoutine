using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingCatalogData : MonoBehaviour
{

    [SerializeField]
    GameObject ProBuilderBlock;

    [SerializeField]
    Material[] itemsInCatalog;//FOR NOW WILL CHANGE ONCE THE MODELS ARE IN
    [SerializeField]
    int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoLeft()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            ProBuilderBlock.GetComponent<MeshRenderer>().material = itemsInCatalog[currentIndex];
        }
    }

    public void GoRight()
    {
        if (currentIndex <= itemsInCatalog.Length)
        {
            currentIndex++;
            ProBuilderBlock.GetComponent<MeshRenderer>().material = itemsInCatalog[currentIndex];
        }
    }


}
