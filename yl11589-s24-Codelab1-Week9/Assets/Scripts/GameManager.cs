using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI titleUI;
    public TextMeshProUGUI descriptionUI;

    public LocationScriptableObject currentLocation;

    public Button buttonUp;
    public Button buttonDown;
    
    // Start is called before the first frame update
    void Start()
    {
        currentLocation.PrintLocation();
        currentLocation.UpdateCurrentLocation(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveDir(string dirChar)
    {
        switch (dirChar)
        {
           case "U":
               currentLocation = currentLocation.up;
               break;
           case "D":
               currentLocation = currentLocation.down;
               break;
          default:
               Debug.Log("WTF? That's a valid dir");
               break;
        }
        
        currentLocation.UpdateCurrentLocation(this);
    }
}
