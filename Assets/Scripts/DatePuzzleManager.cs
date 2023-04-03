using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatePuzzleManager : MonoBehaviour
{

    public List<DateItem> items;

    public GameObject wall;

    public TextDisplay textDisplay;

    private int correctItems;

    public void CollectItem()
    {
        correctItems++;
        if (correctItems == 3)
        {
            textDisplay.DisplayCustomText("You have collected all the items! You can now leave the room.");
            wall.SetActive(false);
        }
    }

    public void ResetItems() 
    {
        Debug.Log("Resetting items");
        foreach (DateItem item in items)
        {
            item.gameObject.SetActive(true);
        }
        correctItems = 0;
    }

}
