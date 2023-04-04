using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoHub : MonoBehaviour
{

    // Update is called once per frame
    public static void TeleportHub()
    {
        CourageGame.ResetLevel();
        if(GameProgression.gameComplete)
        {
            SceneManager.LoadScene("HubRestored");
        }
        else
        {
            SceneManager.LoadScene("Hub");
        }
    }
        
}
