using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Intro");
    }

   
}
