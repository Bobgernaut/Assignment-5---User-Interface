using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEngine : MonoBehaviour
{
    public Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        GameObject mainCanvas = GameObject.Find("CanvasMain");
        if (mainCanvas != null)
        {
            Transform myDemoTextTransform = mainCanvas.transform.Find("MyDemoText");
            if (myDemoTextTransform != null) {
                textComponent = myDemoTextTransform.gameObject.GetComponent<Text>();
                //- - - - Long form - - - - - UnityEngine.UI.Text textComponent = myDemoTextTransform.gameObject.GetComponent<UnityEngine.UI.Text>();
            }
        }

        //textComponent.text = "This is the new text";
        //textComponent.fontStyle = FontStyle.Italic;
        //textComponent.fontSize = 25;
    }

    // Update is called once per frame
    void Update()
    {

        if (textComponent != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                textComponent.text = "This is the new text";
                textComponent.fontStyle = FontStyle.Italic;
                textComponent.fontSize = 25;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                textComponent.text = "WWWWWWWWWWWWWWW";
                textComponent.fontStyle = FontStyle.Bold;
                textComponent.fontSize = 30;
            }
        }
    }
}
