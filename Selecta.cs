using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecta : MonoBehaviour
{

    public GameObject[] casitas;
    GameObject casitaActual;
    int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        casitas[indice].SetActive(true);
    }

    private void ocultarTodas()
    {
        foreach(GameObject casita in casitas)
        {
            casita.SetActive(false);
        }
    }

    public void adelante()
    {
        ocultarTodas();
        if (indice >= casitas.Length) indice = 0;
        
    
        casitas[indice].SetActive(true);

        indice++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
