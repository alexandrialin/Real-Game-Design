using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgression : MonoBehaviour
{
    public static bool courageLevel;
    public static bool loveLevel;
    public static bool wisdomLevel;
    public static bool gameComplete;

    public GameObject finalBook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(courageLevel && loveLevel && wisdomLevel)
        {
            gameComplete = true;
        }
        if(gameComplete && finalBook != null)
        {
            finalBook.SetActive(true);
        }
    }
}
