using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DressMiniGameManager : MonoBehaviour
{
    public static DressMiniGameManager instance { get; private set;}

    [SerializeField]
    GameObject firstButton;
    [SerializeField]
    ClothingCatalogData[] DressSections;
    [SerializeField]
    public int desiredOutfitNum = 1;//0 Beach, 1 Work, 2 Casual, 3 School

    bool isBoy;
    [SerializeField]
    GameObject boyObject;
    [SerializeField]
    GameObject girlObject;
    [SerializeField]
    GameObject[] buttons;


    [SerializeField]
    GameObject currentSection;
    [SerializeField]
    GameObject[] currentArrows;

    [SerializeField]
    Text outFitText;
    public Sound Fail;
    private void Awake()
    {
        instance = this;
        isBoy = PlayerStats.isBoy;
        if (isBoy)
        {
            SetBoy();
        }
        else
        {
            SetGirl();
        }


        outFitText.text = DetermineOutFit();
    }

    public string DetermineOutFit()
    {
        string outFitname = "null";

        if (desiredOutfitNum == 0)
        {
            outFitname = "Beach";
        }
        else if (desiredOutfitNum == 1)
        {
            outFitname = "Work";
        }
        else if (desiredOutfitNum == 2)
        {
            outFitname = "Storm";
        }
        else if (desiredOutfitNum == 3)
        {
            outFitname = "School";
        }

        return outFitname;
    }

    public void SetBoy()
    {
      
        PlayerBodyData boyData = boyObject.GetComponent<PlayerBodyData>();
        boyData.coreBodyModel.SetActive(true);
        for (int i = 0; i < DressSections.Length; i++)
        {
            DressSections[i] = boyData.clothingSections[i].GetComponent<ClothingCatalogData>();
            buttons[i].GetComponent<DressSectionData>().SetAttachedObject(boyData.clothingSections[i]);
        }


      
    }

    public void SetGirl()
    {
        PlayerBodyData girlData = girlObject.GetComponent<PlayerBodyData>();
        girlData.coreBodyModel.SetActive(true);

        for (int i = 0; i < DressSections.Length; i++)
        {
            DressSections[i] = girlData.clothingSections[i].GetComponent<ClothingCatalogData>();
            buttons[i].GetComponent<DressSectionData>().SetAttachedObject(girlData.clothingSections[i]);

        }
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
        AudioManager.instance.Play("UI Click 1");



        foreach (GameObject arrow in currentArrows)
        {
            arrow.GetComponent<RectTransform>().localScale = new Vector2(1.25f, 1.25f);
            arrow.GetComponent<Image>().color = Color.white;
            arrow.GetComponent<Button>().enabled = true;
        }

    }

    public void CompleteOutfit()
    {

        int[] outfitData = new int[3];
        bool successfulOutfit = true;

        foreach (ClothingCatalogData section in DressSections)
        {
            outfitData[section.GetCurrentSecionNum()] = section.GetCurrentOutfitNum();
            Debug.Log(section.GetCurrentOutfitNum() + " " + section.name + outfitData[section.GetCurrentSecionNum()]);
        }

        Debug.Log(desiredOutfitNum);

        if (desiredOutfitNum == 1)//work
        {
            for (int i = 0; i < outfitData.Length; i++)
            {
                Debug.Log(outfitData[i] + "hallo");
                if (outfitData[i] != desiredOutfitNum)//can only be work for all objects
                {
                    successfulOutfit = false;
                    AudioManager.instance.Play("Fail");
                }
            }
        }
        else if (desiredOutfitNum == 0)//beach
        {
            for (int i = 0; i < outfitData.Length; i++)
            {
                if (i == 0)//head 
                {
                    if (outfitData[i] == 2)//glasses, nothing, hat, and bow are all ok in addition to the normal beach attire
                    {
                        successfulOutfit = false;
                        AudioManager.instance.Play("Fail");
                    }
                }
                else if (i == 1)//body
                {
                    if (outfitData[i] != 0)//can only be beach body
                    {
                        successfulOutfit = false;
                        AudioManager.instance.Play("Fail");
                    }
                }
                else if (i == 2)//can only be beach bottoms
                {
                    if (outfitData[i] != 0)
                    {
                        successfulOutfit = false;
                        AudioManager.instance.Play("Fail");
                    }
                }
            }
        }
        else if (desiredOutfitNum == 2)//rain
        {
            for (int i = 0; i < outfitData.Length; i++)
            {
                if (i==0)//head
                {
                    if(outfitData[0] != 2)//can only be umbrella
                    {
                        successfulOutfit = false;
                        AudioManager.instance.Play("Fail");
                    }
                }
                else if (i == 1)//torso
                {
                    if (outfitData[1] != 2)//can only be rain jacket
                    {
                        successfulOutfit = false;
                        AudioManager.instance.Play("Fail");
                    }
                }
                else if (i == 2)
                {
                    if (outfitData[2] != 2 || outfitData[2] != 3)// can be rain bottoms or school bottoms
                    {
                        successfulOutfit = false;
                    }
                }
            }
        }
        else if (desiredOutfitNum == 3)//school
        {
            for (int i = 0; i < outfitData.Length; i++)
            {
                if (i == 0)
                {
                    if (outfitData[0] != 3 || outfitData[0] != 1)//can only be normal school or nothing/ glasses
                    {
                        successfulOutfit = false;
                        AudioManager.instance.Play("Fail");
                    }
                }
                else if (i == 1)//torso
                {
                    if (outfitData[1] != 3)// can only be normal school (POSSIBLY RAIN IDK THO NEED FEED BACK!!!!)
                    {
                        successfulOutfit = false;
                        AudioManager.instance.Play("Fail");
                    }
                }
                else if (i == 2)
                {
                    if (outfitData[2] !=3)// can only be normal school
                    {
                        successfulOutfit = false;
                        AudioManager.instance.Play("Fail");
                    }
                }
            }
        }

        if (successfulOutfit)
        {
            Debug.Log("YOU DRESSED CORRECTLY");

            if(desiredOutfitNum == 0)
                AudioManager.instance.Play("BeachWin");

            else if (desiredOutfitNum == 1)
                AudioManager.instance.Play("WorkWin");

            else if (desiredOutfitNum == 2)
                AudioManager.instance.Play("RainWin");

            else AudioManager.instance.Play("SchoolWin");
            PlayerStats.isDressed = true;

        }
        else
        {
            Debug.Log("YOU DID NOT DRESS CORRECTLY");
            PlayerStats.isDressed = false;

        }

        StartCoroutine(ReturnToMain());

    }


    private IEnumerator ReturnToMain()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(0);

    }
}
