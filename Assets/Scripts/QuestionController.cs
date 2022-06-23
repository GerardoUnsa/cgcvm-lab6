using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionController : MonoBehaviour
{
    public GameObject camara01;
    public GameObject camara02;
    public GameObject enemy;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Activar vista con preguntas
        if (Input.GetKey(KeyCode.O))
        {
            question.text = sQuestion;
            ans1.text = sAns1;
            ans2.text = sAns2;
            ans3.text = sAns3;

            camara01.SetActive(false);
            camara02.SetActive(true);
            enemy.SetActive(true);
            pizarra.SetActive(true);
        }

        //Activar vista normal
        if (Input.GetKey(KeyCode.P))
        {
            camara01.SetActive(true);
            camara02.SetActive(false);
            enemy.SetActive(false);
            pizarra.SetActive(false);
        }
    }
}
