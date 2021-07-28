using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    int sceneIndexToMoveTo;

    [SerializeField]
    public int preReq = -1;
    [SerializeField]
    string preReqText;

    public bool canInteract = true;
    
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
            mesh.material = insideMaterial;
            PlayerCore.instance.GetComponent<PlayerMovement>().SetCurrentInteractable(this);

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playerString))
        {
            mesh.material = defaultMaterial;
            PlayerCore.instance.GetComponent<PlayerMovement>().SetCurrentInteractable(null);
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
}
