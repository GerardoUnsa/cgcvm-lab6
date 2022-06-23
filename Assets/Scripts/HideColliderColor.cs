using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
 
public class HideColliderColor : MonoBehaviour
{
    private TilemapRenderer tilemapRender; // Objeto Tilemap
   
    void Awake()
    {
        tilemapRender = GetComponent<TilemapRenderer>(); // Instancia de Tilemap
    }
 
    // Start is called before the first frame update
    void Start()
    {
        tilemapRender.enabled = false; // Deshabilitar la visualizacion de los elementos del Tilemap
    }
}