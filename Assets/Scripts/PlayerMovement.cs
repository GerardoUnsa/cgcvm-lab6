using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    public Animator animator; // Componente Animator
    [SerializeField] private float moveSpeed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Instancia del objeto Rigidbody2D
    }
 
    // Update is called once per frame
    void Update()
    {
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
}