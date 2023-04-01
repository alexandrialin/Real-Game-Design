using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OverallHP : MonoBehaviour
{
    public static int full = 200;
    public static int hp = full;
    public Text hpText;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = hp + "/" + full;
        if (hp <= 0)
        {
            deathScreen.SetActive(true);
            
        }
    }

    public void MoreHP()
    {
        full += 50;
    }
    public static void ResetHP()
    {
        full = 200;
        hp = 200;
    }
}
