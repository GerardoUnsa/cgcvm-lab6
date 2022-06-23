using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] Material baseMaterial;
    [SerializeField] Material estructuraMaterial;
    // Start is called before the first frame update
    void Start()
    {
        baseMaterial.SetColor("_Color",Color.white);
        estructuraMaterial.SetColor("_Color", Color.white);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeColorDanger()
    {
        baseMaterial.SetColor("_Color", Color.red);
        estructuraMaterial.SetColor("_Color", Color.red);
    }

    public void changeColorNormal()
    {
        baseMaterial.SetColor("_Color", Color.white);
        estructuraMaterial.SetColor("_Color", Color.white);
    }


}
