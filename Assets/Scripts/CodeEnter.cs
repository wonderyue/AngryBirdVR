using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeEnter : MonoBehaviour
{
    public Text codeText;
    string codeTextValue = "";
    public string key = "1234";
    bool open = false;
    public GameObject leftDoor, rightDoor;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;
    }

    public void AddDigit(string digit)
    {
        if (!open)
        {
            if (codeTextValue.Length >= 4)
            {
                codeTextValue = "";
            }
            codeTextValue += digit;
        }
    }

    public void DelDigit()
    {
        if(!open)
        {
            codeTextValue = codeTextValue.Substring(0, codeTextValue.Length - 1);
        }
    }

    public void Clear()
    {
        if (!open)
        {
            codeTextValue = "";
        }
    }

    public void Enter()
    {
        if (!open)
        {
            if (codeTextValue == key)
            {
                codeTextValue = "Unlocked!";
                open = true;
                rightDoor.transform.rotation = Quaternion.Euler(0f, 120f, 0f);
                leftDoor.transform.rotation = Quaternion.Euler(0f, -120f, 0f);
                GameObject.Find("Time Text").SendMessage("Finish");
            }
  
            else
            {
                codeTextValue = "";
            }
        }
    }
}
