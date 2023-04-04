using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public TextDisplay textDisplay;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Player entered NPC's trigger");
        textDisplay.DisplayText();
    }

}
