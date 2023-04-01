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




    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(type))
        {
            Destroy(collision.gameObject);
            
        }

        if (dmgCooldown <= 0)
        {
            if (collision.gameObject.CompareTag("body") || collision.gameObject.CompareTag("3fires"))
            {
                OverallHP.hp -= 20;
                if (squealCooldown <= 0)
                {
                    Instantiate(squeal);
                }
                squealCooldown = 1f;
            }
            if (collision.gameObject.CompareTag("hit"))
            {
                OverallHP.hp -= 5;
                if (squealCooldown <= 0)
                {
                    Instantiate(squeal);
                }
                squealCooldown = 1f;
            }
            if (collision.gameObject.CompareTag("water"))
            {
                print("working");
                OverallHP.hp = 0;
                if (squealCooldown <= 0)
                {
                    Instantiate(squeal);
                }
                squealCooldown = 1f;

            }
            if (collision.gameObject.CompareTag("boss"))
            {
                OverallHP.hp -= Random.Range(10, 30);
                if (squealCooldown <= 0)
                {
                    Instantiate(squeal);
                }
                squealCooldown = 1f;
            }
            if(collision.gameObject.CompareTag("cutscene"))
            {
                SceneManager.LoadScene("BossLevel2");
            }

        }
        dmgCooldown = 1f;
    }
    void Update()
    {
        if(squealCooldown > 0)
        {
            squealCooldown -= Time.deltaTime;
        }
        if(dmgCooldown >= 0)
        {
            dmgCooldown -= Time.deltaTime;
        }

    }
    
}
