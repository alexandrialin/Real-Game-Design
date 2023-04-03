using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoveQuiz : MonoBehaviour
{
    public TextDisplay textDisplay;
    public string[] questions;
    public string[] correctAnswers;
    public string[] wrongAnswers;
    public Button AdvanceTextButton;
    public GameObject wall;

    private int currentQuestionIndex = 0;

    void OnTriggerEnter(Collider other)
    {
        AdvanceTextButton.gameObject.SetActive(false);
        SetQuestion(currentQuestionIndex);
        
    }

    void SetQuestion(int questionIndex)
    {
        textDisplay.DisplayCustomText(questions[questionIndex]);
        List<string> answers = new List<string>();
        answers.Add(correctAnswers[questionIndex]);
        for (int i = 0; i < 2; i++)
        {
            answers.Add(wrongAnswers[2*questionIndex + i]);
        }
        ShuffleList<string>(answers);
        textDisplay.ShowChoices(answers[0], answers[1], answers[2]);
    }

    void ShuffleList<T>(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = Random.Range(i, list.Count);
            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    public void CheckAnswer(int choiceIndex)
    {
        if (textDisplay.GetChoice(choiceIndex) == correctAnswers[currentQuestionIndex])
        {
            currentQuestionIndex++;
            if (currentQuestionIndex == questions.Length)
            {
                // Quiz is over, do something
                textDisplay.HideChoices();
                textDisplay.HideText();
                wall.transform.Rotate(0, -90, 0);
            }
            else
            {
                SetQuestion(currentQuestionIndex);
            }
        }
        else
        {
            currentQuestionIndex = 0;
            SetQuestion(currentQuestionIndex);
        }
    }

    public void AdvanceText()
    {
        if (currentQuestionIndex == questions.Length - 1)
        {
            // Quiz is over, do something
        }
        else
        {
            currentQuestionIndex++;
            SetQuestion(currentQuestionIndex);
        }
    }
}
