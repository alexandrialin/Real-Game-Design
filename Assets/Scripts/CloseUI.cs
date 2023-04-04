using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseUI : MonoBehaviour
{
    public Button yourButton;
    public GameObject box;
    public GameObject box2;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        if(box2 != null)
        {
            box2.SetActive(true);
        }
        if(gameObject.CompareTag("love"))
        {
            GameProgression.loveLevel = true;
        }
        if (gameObject.CompareTag("courage"))
        {
            GameProgression.courageLevel = true;
        }
        if (gameObject.CompareTag("wisdom"))
        {
            GameProgression.wisdomLevel = true;
        }
        box.SetActive(false);

    }
}
