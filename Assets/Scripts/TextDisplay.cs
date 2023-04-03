using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public TextMeshProUGUI choiceText1;
    public TextMeshProUGUI choiceText2;
    public TextMeshProUGUI choiceText3;

    public GameObject textBox;
    public GameObject choiceBox;

    public string[] textLines;
    public string[] choiceLines;

    public int currentLine;

    void Start()
    {
        currentLine = 0;
        textBox.SetActive(false);
        choiceBox.SetActive(false);
    }

    
    // This method will be called when a choice is needed.
    public void ShowChoices(string choice1, string choice2, string choice3)
    {
        choiceText1.text = choice1;
        choiceText2.text = choice2;
        choiceText3.text = choice3;
        
        // Set the choice objects to active so they will be visible.
        choiceBox.gameObject.SetActive(true);
    }

    public string GetChoice(int choiceIndex)
    {
        if (choiceIndex == 0)
        {
            return choiceText1.text;
        }
        else if (choiceIndex == 1)
        {
            return choiceText2.text;
        }
        else if (choiceIndex == 2)
        {
            return choiceText3.text;
        }
        else
        {
            return "";
        }
    }
    
    // This method will be called when a choice is made.
    public void HideChoices()
    {
        // Set the choice objects to inactive so they will be hidden.
        choiceBox.gameObject.SetActive(false);
    }
    
    // This method will be called to update the display text.
    public void UpdateDisplayText()
    {   
        if (currentLine < textLines.Length - 1)
        {
            displayText.text = textLines[currentLine];
            currentLine++;
        }
        else
        {
            HideText();
        }
    }

    public void DisplayText()
    {
        textBox.SetActive(true);
        UpdateDisplayText();
    }

    public void HideText()
    {
        textBox.SetActive(false);
    }

    public void DisplayTextIndex(int index)
    {
        textBox.SetActive(true);

        if (index < textLines.Length)
        {
            displayText.text = textLines[index];
        }
        else
        {
            HideText();
        }
    }

    public void DisplayCustomText(string text)
    {
        textBox.SetActive(true);
        displayText.text = text;
    }
}
