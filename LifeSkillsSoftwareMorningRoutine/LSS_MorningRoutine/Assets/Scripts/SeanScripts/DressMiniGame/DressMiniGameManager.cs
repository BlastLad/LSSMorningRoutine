using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DressMiniGameManager : MonoBehaviour
{
    public static DressMiniGameManager instance { get; private set;}

    [SerializeField]
    GameObject firstButton;
    [SerializeField]
    GameObject[] DressSections;
    [SerializeField]
    public int desiredOutfitNum = 1;


    [SerializeField]
    GameObject currentSection;
    [SerializeField]
    GameObject[] currentArrows;
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
    public void EnableASection(GameObject passedSection, GameObject[] arrows)
    {

        currentSection.SetActive(false);

        foreach (GameObject arrow in currentArrows)
        {
            arrow.GetComponent<RectTransform>().localScale = new Vector2(1f, 1f);
            arrow.GetComponent<Image>().color = Color.gray;
            arrow.GetComponent<Button>().enabled = false;
        }

        currentSection = passedSection;

        currentArrows = arrows;

        currentSection.SetActive(true);



        foreach (GameObject arrow in currentArrows)
        {
            arrow.GetComponent<RectTransform>().localScale = new Vector2(1.25f, 1.25f);
            arrow.GetComponent<Image>().color = Color.white;
            arrow.GetComponent<Button>().enabled = true;
        }






    }
}
