using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InteractableObject : MonoBehaviour
{
    string playerString = "Player";
    [SerializeField]
    MeshRenderer mesh;
    [SerializeField]
    Material defaultMaterial;
    [SerializeField]
    Material insideMaterial;

    [SerializeField]
    Outline outlineObj;


    [SerializeField]
    int sceneIndexToMoveTo;

    [SerializeField]
    public int preReq = -1;
    [SerializeField]
    string preReqText;

    [SerializeField]
    GameObject spaceButton;

    public bool canInteract = true;
    public bool isExit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (preReq != -1)
        {
            if (GameManager.instance.GetCheckedObjects()[preReq].activeSelf)
            {
                canInteract = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerString))
        {
            outlineObj.enabled = true;
            mesh.material = insideMaterial;
            if (!isExit)
            {
                PlayerCore.instance.GetComponent<PlayerMovement>().SetCurrentInteractable(this);
            }
            else
            {
                PlayerCore.instance.GetComponent<PlayerMovement>().SetInteractableExit(this, true);
            }
            spaceButton.SetActive(true);

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playerString))
        {
            mesh.material = defaultMaterial;
            outlineObj.enabled = false;
            if (!isExit)
            {
                PlayerCore.instance.GetComponent<PlayerMovement>().SetCurrentInteractable(null);
            }
            else
            {
                PlayerCore.instance.GetComponent<PlayerMovement>().SetInteractableExit(null, false);
            }
            spaceButton.SetActive(false);
        }
    }



    public void moveScene()
    {
        if (canInteract)
        {
            SceneManager.LoadScene(sceneIndexToMoveTo);
        }
        else
        {
            GameManager.instance.SetPreReqText(preReqText);
        }
    }


    public void enableEndScreen()
    {
        if (GameManager.instance.isDressed && GameManager.instance.brushedTeeth && GameManager.instance.madeBreakfast && GameManager.instance.isShowered)
        {
            GameManager.instance.ShowResults();
        }
        else
        {
            GameManager.instance.SetPreReqText("You still have some more tasks to do before you leave!");
        }
      
    }
}
