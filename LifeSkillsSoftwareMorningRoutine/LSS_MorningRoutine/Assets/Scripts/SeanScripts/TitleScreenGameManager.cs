using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGirl()
    {
        PlayerStats.isBoy = false;
    }

    public void SetBoy()
    {
        PlayerStats.isBoy = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(5);
    }
}
