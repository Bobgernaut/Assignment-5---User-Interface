using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEditor;


public class HideCursor : MonoBehaviour
{
    private string v01;
    
    public bool HideCursorBool;
    public string HideKey = "backspace";
    public float delay = 1f;

    
    // Start
    void Start()
    {
        TurnOff();
    }

    // Update
    void Update()
    {
        HideCursorCheck();
    }
    
    IEnumerator LateCall()
    {
        yield return new WaitForSeconds(delay * Time.deltaTime);
    }

    void HideCursorCheck()
    {
        if (Input.GetKeyDown(HideKey) && !HideCursorBool)
        {
            TurnOff();
        }
        
        else if (Input.GetKeyDown(HideKey) && HideCursorBool)
        {
            TurnOn();
        }
        
    }

    void TurnOff()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        HideCursorBool = true;
        StartCoroutine(LateCall());
    }

    void TurnOn()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        HideCursorBool = false;
        StartCoroutine(LateCall());
    }
    
}
