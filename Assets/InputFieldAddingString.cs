using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldAddingString : MonoBehaviour
{

    [SerializeField]
    Text targetText;

    void Start()
    {

    }


    void Update()
    {

    }

    public void SetEnhancedText(string value)
    {
        targetText.text = "Entered string : " + value;
    }
}
