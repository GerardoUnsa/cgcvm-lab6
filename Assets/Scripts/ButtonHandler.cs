using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    QuestionController question;

    private void Start()
    {
        question = GameObject.FindGameObjectWithTag("Player").GetComponent<QuestionController>();
    }
    private void Update()
    {
        
    }
    public void selectAnswer(int option)
    {
        Debug.Log("Button activado " + option);
        question.requestAnswer(option);
    }
}
