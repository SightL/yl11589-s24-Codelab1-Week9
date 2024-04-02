using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu
    (
        fileName = "New Location",
        menuName = "New Location",
        order = 0)
]

public class LocationScriptableObject : ScriptableObject
{
    public string locationName;
    public string locationDesc;

    public LocationScriptableObject up;
    public LocationScriptableObject down;

    
    public void PrintLocation()
    {
        string printStr =
            "\nLocation Name: " + locationName +
            "\nLocation Description: " + locationDesc;
        
        Debug.Log(printStr);
    }

    public void UpdateCurrentLocation(GameManager gm)
    {
        gm.titleUI.text = locationName;
        gm.descriptionUI.text = locationDesc;

        if (up == null)
        {
            gm.buttonUp.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonUp.gameObject.SetActive(true);
            up.down = this;
        }

        if (down == null)
        {
            gm.buttonDown.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonDown.gameObject.SetActive(true);
            down.up = this;
        }
    }
}
