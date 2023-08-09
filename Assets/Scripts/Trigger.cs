using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public GameObject[] trigger; 
    public GameObject cubos;      
    public int puntosSumados = 10;     
    public int puntosRestados = 5; 

    public bool accionEjecutada = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cubos)
        {
            EjecutarAccion();
            
        }
    }

    private void EjecutarAccion()
    {
        
        foreach (GameObject cylinder in trigger)
        {
            cylinder.GetComponent<Renderer>().material.color = Color.green;
        }

        accionEjecutada = true;
    }

    private void VerifyAction()
    {
        if (accionEjecutada)
        {
            // Acción ejecutada correctamente, suma puntos
            ScoreManager.Instance.AddPoints(puntosSumados);
        }
        else
        {
            // Acción no ejecutada correctamente, resta puntos
            ScoreManager.Instance.SubtractPoints(puntosRestados);
        }

        // Reinicia el estado de la acción
        accionEjecutada = false;
    }



}
