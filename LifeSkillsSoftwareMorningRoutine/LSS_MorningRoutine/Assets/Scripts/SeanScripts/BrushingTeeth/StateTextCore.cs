using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StateTextCore : MonoBehaviour
{

    [SerializeField]
    Text stateText;

    float alpha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alpha = stateText.color.a - 0.23f * Time.deltaTime;
        stateText.color = new Color(stateText.color.r, stateText.color.g, stateText.color.b, alpha);

        if (transform.localPosition.y < 13.8f)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetStateText(string text, int fontSize)
    {
        stateText.text = text;
        stateText.fontSize = fontSize;
    }
}
