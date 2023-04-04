using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoHub : MonoBehaviour
{

    // Update is called once per frame
    public void TeleportHub()
    {
        CourageGame.ResetLevel();
        SceneManager.LoadScene("Hub");
    }
}
