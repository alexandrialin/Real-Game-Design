using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FloorToggle : MonoBehaviour
{
    public bool [] toggle = new bool[16];
    public GameObject wall;
    public bool doorOpen = false;
    void Start()
    {
        print("hi");

    }
    
    public void WhenToggled(int toggleNo)
    {
        if (toggle[toggleNo-1] == true)
            toggle[toggleNo-1] = false;
        else
            toggle[toggleNo - 1] = true;

            
        }

    


    public void Update()
    {
        if (doorOpen == false && toggle[0] == false && toggle[1] == false && toggle[2] && toggle[3] && toggle[4] == false && toggle[5] && toggle[6] && toggle[7] && toggle[8] == false && toggle[9] && toggle[10] && toggle[11] == false && toggle[12] && toggle[13] && toggle[14] && toggle[15] == false)
        {
            doorOpen = true;
            wall.transform.Rotate(0, -90, 0);
        }
    }
}
        
        
    


