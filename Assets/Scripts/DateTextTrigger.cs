using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTextTrigger : MonoBehaviour
{

    public TextDisplay textDisplay;

    void OnTriggerEnter(Collider other)
    {
        textDisplay.DisplayText();
    }

}
