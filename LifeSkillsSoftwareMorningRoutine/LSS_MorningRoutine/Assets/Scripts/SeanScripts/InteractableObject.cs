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
    
    // Start is called before the first frame update
    void Start()
    {
        
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
        SceneManager.LoadScene(sceneIndexToMoveTo);
    }
}
