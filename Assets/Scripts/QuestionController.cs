using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionController : MonoBehaviour
{
    public GameObject camara01;
    public GameObject camara02;
    public GameObject pizarra;

    public TMP_Text question;
    public TMP_Text ans1;
    public TMP_Text ans2;
    public TMP_Text ans3;

    //Variables para programar cada pregunta
    private string sQuestion = " ¿Pregunta prueba?";
    private string sAns1 = " a) Opcion 1 prueba";
    private string sAns2 = " b) Opcion 2 prueba";
    private string sAns3 = " c) Opcion 3 prueba";
    private int correctAns = 1; //Respuesta correcta entre sAns1 2 3

    MapController map;
    PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        map = GameObject.FindGameObjectWithTag("MapGrid").GetComponent<MapController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //Activar vista con preguntas
        if (Input.GetKey(KeyCode.O))
        {
            enableQuestion();
        }

        //Activar vista normal
        if (Input.GetKey(KeyCode.P))
        {
            disableQuestion();
        }

        if (pizarra.activeSelf && Input.GetKey(KeyCode.Alpha1))
        {
            requestAnswer(1);
        }

        if (pizarra.activeSelf && Input.GetKey(KeyCode.Alpha2))
        {
            requestAnswer(2);
        }
        if (pizarra.activeSelf && Input.GetKey(KeyCode.Alpha3))
        {
            requestAnswer(3);
        }
    }

    public void requestAnswer(int option)
    {
        if (option == correctAns)
        {
            question.text = "CORRECTO";
            map.changeColorNormal();
            disableQuestion();
            player.enableMove();
        }
        else{
            question.text = "INCORRECTO";
            map.changeColorDanger();
            disableQuestion();
            player.enableMove();
        }
    }

    public void enableQuestion()
    {
        question.text = sQuestion;
        ans1.text = sAns1;
        ans2.text = sAns2;
        ans3.text = sAns3;

        camara01.SetActive(false);
        camara02.SetActive(true);
        pizarra.SetActive(true);
    }

    public void enableQuestion(string q, string a1, string a2, string a3, int correct)
    {
        sQuestion = q;
        sAns1 = a1;
        sAns2 = a2;
        sAns3 = a3;
        correctAns = correct;

        question.text = sQuestion;
        ans1.text = sAns1;
        ans2.text = sAns2;
        ans3.text = sAns3;

        camara01.SetActive(false);
        camara02.SetActive(true);
        pizarra.SetActive(true);
    }

    public void disableQuestion()
    {
        camara01.SetActive(true);
        camara02.SetActive(false);
        pizarra.SetActive(false);
    }
}
