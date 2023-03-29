using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualToggle : MonoBehaviour
{
    Transform playerTransform;
    public GameObject player;
    public float distance;
    public int switchNo;
    public FloorToggle floorToggle;
    public bool isOn;
    public GameObject off;
    public GameObject on;

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

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("mc"))
        {
            print("mc collision");
            floorToggle.WhenToggled(switchNo);
            if (isOn)
            {
                isOn = false;
                on.SetActive(false);
                off.SetActive(true);
            }
            else
            {
                isOn = true;

                on.SetActive(true);
                off.SetActive(false);
            }
        }
    }


        // Update is called once per frame
        void Update()
    {



    }
}
