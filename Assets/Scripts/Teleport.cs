using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    Transform playerTransform;
    public GameObject player;
    public float distance;
    public GameObject popup;
    public GameObject perm;
    public bool complete;

    // Start is called before the first frame update
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
        if (Mathf.Abs(distance) < 3)
        {
            if(popup != null)
            {
                popup.SetActive(true);
               

            }
               
            if(perm != null && !complete)
            {
                complete = true;
                perm.SetActive(true);
            }
                
            if (Input.GetKey(KeyCode.F))
            {
                if(gameObject.CompareTag("wisdom"))
                {
                    SceneManager.LoadScene("Wisdom");
                }
                if (gameObject.CompareTag("love"))
                {
                    SceneManager.LoadScene("Love");
                }
                if (gameObject.CompareTag("courage"))
                {
                    SceneManager.LoadScene("Courage");
                }
                if(gameObject.CompareTag("restored"))
                {
                    SceneManager.LoadScene("HubRestored");
                }
         
            }
        }
        else
        {
            if (popup != null)
                popup.SetActive(false);
        }


    }

}
