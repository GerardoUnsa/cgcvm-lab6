using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraController : MonoBehaviour
{
    private Transform target; // Capturar posicion del Personaje
    [SerializeField] private float smoothSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        // El personaje tiene como etiqueta "Player"
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
 
    // Update is called once per frame
    void Update()
    {
        // Movimiento de la camara de acuerdo a la posicion del target
        transform.position = Vector3.Lerp(transform.position,
                            new Vector3(target.position.x, target.position.y, transform.position.z), smoothSpeed * Time.deltaTime);
    }
}