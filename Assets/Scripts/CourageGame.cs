using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourageGame : MonoBehaviour
{

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;

    public static int enemies1;
    public static int enemies2;
    public static int enemies3;

    public static bool done;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static void ResetLevel()
    {
        enemies1 = 0;
        enemies2 = 0;  
        enemies3 = 0;
        McHp.hp = McHp.full;
    }
    // Update is called once per frame
    void Update()
    {
        if(enemies1 == 3)
        {
            wall1.SetActive(false);
        }
        if (enemies2 == 2)
        {
            wall2.SetActive(false);
        }
        if (enemies3 == 1 && done == false)
        {
            wall3.transform.Rotate(0, -90, 0);
            done = true;
        }

    }
}
