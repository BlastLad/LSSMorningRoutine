using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DressMiniGameManager : MonoBehaviour
{
    public static DressMiniGameManager instance { get; private set;}

    [SerializeField]
    GameObject firstButton;
    [SerializeField]
    GameObject[] DressSections;


    [SerializeField]
    GameObject currentSection;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoLeft()
    {
        if (currentSection.activeInHierarchy == true)
        {
            currentSection.GetComponent<ClothingCatalogData>().GoLeft();
        }
    }

    public void GoRight()
    {
        if (currentSection.activeInHierarchy == true)
        {
            currentSection.GetComponent<ClothingCatalogData>().GoRight();
        }
    }
    public void EnableASection(GameObject passedSection)
    {

        currentSection.SetActive(false);

        currentSection = passedSection;

        currentSection.SetActive(true);

    }
}
