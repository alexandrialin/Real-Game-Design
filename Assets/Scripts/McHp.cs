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
    public float dmgCooldown = 0f;
    public static int full = 200;
    public static int hp = full;
    public Text hpText;
    public GameObject deathScreen;
    public Animator anim;
    public float lag = 0;



    void OnTriggerEnter(Collider other)
    {

        if (dmgCooldown <= 0)
        {
            if (other.gameObject.CompareTag("body"))
            {
                print("hello collision");

                hp -= 20;
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
        if (Input.GetMouseButton(0) && lag <= 0f)
        {
            anim.SetInteger("attack", 1);
            lag = 0.5f;
        }
        else
        {
            anim.SetInteger("attack", 0);
        }
        if (lag > 0)
        {
            lag -= Time.deltaTime;
        }
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
