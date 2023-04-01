using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class McHp : MonoBehaviour
{

    public AudioSource squeal;
    // to make sure the squeals don't get too annoying
    public float squealCooldown;
    public string type;
    public float dmgCooldown = 0f;
    public static int full = 200;
    public static int hp = full;
    public Text hpText;
    public GameObject deathScreen;



    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(type))
        {
            Destroy(collision.gameObject);
            
        }

        if (dmgCooldown <= 0)
        {
            if (collision.gameObject.CompareTag("body"))
            {
                OverallHP.hp -= 20;
                if (squealCooldown <= 0)
                {
                    Instantiate(squeal);
                }
                squealCooldown = 1f;
            }

        }
        dmgCooldown = 1f;
    }
    void Update()
    {
        hpText.text = hp + "/" + full;
        if (hp <= 0)
        {
            deathScreen.SetActive(true);

        }
        if (squealCooldown > 0)
        {
            squealCooldown -= Time.deltaTime;
        }
        if(dmgCooldown >= 0)
        {
            dmgCooldown -= Time.deltaTime;
        }

    }
    
}
