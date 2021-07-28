using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAway : MonoBehaviour
{
    [SerializeField]
    Image image;
    [SerializeField]
    Text text;

    float alpha = 1;

    bool isFading = false;
    bool isCalled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        if (!isFading)
        {
            StartCoroutine(beginFade());
        }
    }

    private IEnumerator beginFade()
    {
        yield return new WaitForSeconds(3f);
        isFading = true;
    }

    private void OnDisable()
    {

        alpha = 1;
        image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
        text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
        isFading = false;
        isCalled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFading)
        {
            alpha -= 0.15f * Time.deltaTime;
            image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
            text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);

            if (alpha <= 0.15f)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
