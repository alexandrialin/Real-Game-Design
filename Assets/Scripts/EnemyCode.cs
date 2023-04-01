using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCode : MonoBehaviour
{

    public float attackSpeed = 4;
    public float attackDistance;
    public float bufferDistance;
    public GameObject player;
    public Animator anim;
    public float distance;
    public Text hpText;
    public int hp = 100;
    public Text dmgText;
    public int dmg;
  
    public float lag = 0;
    public float enemyLag = 0;
    public float cooldown = 0;
    public float dmgTime = 0;
    public float deathTime = 2f;
    public bool alive = true;

    Transform playerTransform;

    void GetPlayerTransform()
    {
        if (player != null)
        {
            playerTransform = player.transform;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GetPlayerTransform();

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(playerTransform.position, transform.position);
        if (Mathf.Abs(distance) <= attackDistance && anim.GetInteger("attack") != 3)
        {
            if (Mathf.Abs(distance) >= bufferDistance)
            {
                transform.LookAt(player.transform);
                transform.position += transform.forward * attackSpeed * Time.deltaTime;
                anim.SetInteger("attack", 1);
            }

        }
        else
        {
            anim.SetInteger("attack", 0);
        }
        if (Input.GetMouseButton(0) && lag <= 0f)
        {
            EnemyStun(1);
            lag = 0.5f;
        }
        if (lag > 0)
        {
            lag -= Time.deltaTime;
        }
        if (dmgTime > 0)
        {
            dmgText.text = "" + dmg;
            dmgTime -= Time.deltaTime;
        }
        else
        {
            dmgText.text = "";
        }
        if (hp <= 0)
        {
            hp = 0;
            hpText.text = "0/100";
            anim.SetInteger("attack", 4);
            alive = false;
        }
        if (deathTime > 0 && alive == false)
        {
            deathTime -= Time.deltaTime;
        }
        else if (deathTime <= 0)
        {
            Destroy(gameObject);
        }
        GetPlayerTransform();
    }

    public void EnemyStun(int abilityDistance)
    {
        if (Mathf.Abs(distance) < abilityDistance)
        {
            anim.SetInteger("attack", 3);
            dmg = Random.Range(10, 20);
            hpText.text = hp - dmg + "/100";
            hp -= dmg;
            dmgTime = 1f;
        }
    }
}
