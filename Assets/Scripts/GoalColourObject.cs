using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalColourObject : MonoBehaviour
{
    public Color goalColor = new Color(2.892157f, 0.8921568f, 2.519608f, 5.0f);

    void Start()
    {
        GetComponent<Renderer>().material.color = goalColor;
    }
}
