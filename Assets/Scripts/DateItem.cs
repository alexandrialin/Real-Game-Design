using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateItem : MonoBehaviour
{

    public bool isCorrect;

    public DatePuzzleManager manager;

    public TextDisplay textDisplay;

    void OnTriggerEnter(Collider other)
    {
        if (isCorrect)
        {
            Debug.Log("Correct");
            manager.CollectItem();
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Incorrect");
            textDisplay.DisplayTextIndex(2);
            manager.ResetItems();
        }
    }
}
