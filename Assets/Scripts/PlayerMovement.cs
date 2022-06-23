using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    private bool playerActive;
    public Animator animator; // Componente Animator
    [SerializeField] private float moveSpeed = 2.5f;

    QuestionController question;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Instancia del objeto Rigidbody2D
        question = GameObject.FindGameObjectWithTag("Player").GetComponent<QuestionController>();
    }
 
    // Update is called once per frame
    void Update()
    {
        //Desactivar movimiento de jugador
        if (Input.GetKey(KeyCode.O))
        {
            disableMove();
        }

        //Activar jugador
        if (Input.GetKey(KeyCode.P))
        {
            enableMove();
        }
        moveV = Input.GetAxisRaw("Vertical") * moveSpeed; // Capturar las teclas de adelante y atras
        moveH = Input.GetAxisRaw("Horizontal") * moveSpeed; // Capturar las teclas de izquierda derecha
        if (moveV != 0 || moveH != 0) { // Si se presiona cualquier tecla direccional
            animator.SetFloat("Speed", 1); // Realizar animacion run
        } else {
            animator.SetFloat("Speed", 0); // Realizar animacion walk
        }
    }
 
    private void FixedUpdate() {
        rb.velocity = new Vector2(moveH, moveV); // Realizar el movimiento con la fuerza velocity
    }

    public void enableMove()
    {
        playerActive = true;
        moveSpeed = 2.5f;
    }

    public void disableMove()
    {
        playerActive = false;
        moveSpeed = 0.0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy01")
        {
            disableMove();
            question.enableQuestion("Pregunta Enemy 01",
                "a) Answer Enemy 01", 
                "b) Answer Enemy 01", 
                "c) Answer Enemy 01", 
                2);
        }
    }
}