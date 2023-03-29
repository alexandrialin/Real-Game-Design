using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueRedo : MonoBehaviour
{
    public TMP_Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject dialogueBox;
    public GameObject cam1;
    public GameObject cam2;



    public GameObject continueButton;

    private void Start()
    {

        StartCoroutine(Type());
    }


    // Only display the continue button if the given sentence is complete
    private void Update()
    {
            if (textDisplay.text == sentences[index])
            {
                continueButton.SetActive(true);

            }
        
    }

    // Give the text the "typed" appearance
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    // Set a reference to the next sentence / determine if the previous sentence has completed
    public void NextSentence()
    {
        if (gameObject.CompareTag("narration") && index == 4)
        {
            SceneManager.LoadScene("Hub");
        }

            continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            dialogueBox.SetActive(false);

        }
    }

}
