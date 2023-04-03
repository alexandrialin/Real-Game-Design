using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateItem : MonoBehaviour
{

    public bool isCorrect;

    public DatePuzzleManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            manager.ResetItems();
        }
    }
}
