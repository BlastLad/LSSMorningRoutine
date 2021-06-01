using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{

    public static PlayerCore instance { get; private set; }

    [SerializeField]
    bool isBoy;



    private void Awake()
    {
      if (instance != null)
        {
            Debug.Log("UH OH TWO INSTACNES ON PLAYER CORE!");
        }
      else
        {
            instance = this;
        }
            
    }
    // Start is called before the first frame update
    void Start()
    {
        isBoy = GameManager.instance.boy;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetGender(bool val)
    {
        isBoy = val;
        PlayerStats.isBoy = isBoy;

    }

    public bool GetGender()
    {
        return PlayerStats.isBoy;
    }
    

}
