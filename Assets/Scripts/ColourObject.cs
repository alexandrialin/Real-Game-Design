using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourObject : MonoBehaviour
{
    // The RGB value of this color object
    public Color colorValue;

    // The capsule object that will display the mixed color
    public GameObject capsule;

    public GoalColourObject goalObject;

    // Whether or not this color object is currently added to the capsule
    private bool addedToCapsule;

    // The outline color to indicate if this color is in the capsule
    private Color outlineColor;
    private Color goalColorWithAlpha;

    void Start()
    {
        // Assign the outline color to be white
        outlineColor = Color.white;
        GetComponent<Renderer>().material.color = colorValue;
        goalColorWithAlpha = new Color(goalObject.goalColor.r, goalObject.goalColor.g, goalObject.goalColor.b, 5.0f);

    }

    void OnTriggerEnter(Collider other)
    {
        // If this color is already added to the capsule, remove it
        if (addedToCapsule)
        {
            capsule.GetComponent<Renderer>().material.color -= colorValue;
            GetComponent<Renderer>().material.SetColor("_OutlineColor", Color.clear);
            addedToCapsule = false;
            Debug.Log(capsule.GetComponent<Renderer>().material.color);
        }
        // If this color is not added to the capsule, add it
        else
        {
            capsule.GetComponent<Renderer>().material.color += colorValue;
            GetComponent<Renderer>().material.SetColor("_OutlineColor", outlineColor);
            addedToCapsule = true;
        }

        // Debug.Log(capsule.GetComponent<Renderer>().material.color);
        // Debug.Log(goalColorWithAlpha);

        if (capsule.GetComponent<Renderer>().material.color == goalColorWithAlpha)
        {
            // Trigger the event for matching the goal color
            OnGoalColorMatched();
        }
    }

    void OnGoalColorMatched()
    {
        Debug.Log("Goal color matched!");
    }
}
