using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleComplete : MonoBehaviour
{
    public GameObject [] puzzle;
    public int[] count= new int[9];
    public GameObject wall;
    void Update()
    {
        for(int i=0;i<9; i++)
        {
            if(puzzle[i].transform.rotation.eulerAngles.z == 0||puzzle[i].transform.rotation.eulerAngles.z == 360)
            {
                count[i] = 1;

            }
            else
            {
                count[i] = 0;
            }
        }
        if(count[0]==1&& count[1] == 1 && count[2] == 1 && count[3] == 1 && count[4] == 1 && count[5] == 1 && count[6] == 1 && count[7] == 1 && count[8] == 1)
        {
            wall.SetActive(false);

        }
        }

}
