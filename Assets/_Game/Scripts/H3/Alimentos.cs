using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alimentos : MonoBehaviour
{
    
    public TipoAlimentos alimento;
    public bool enMano;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTRANDO");
        Debug.Log(enMano );
        if (enMano == true && other.CompareTag("Canasta"))
        {
            Debug.Log("DENTRO");
            Canasta.canasta.ContadorAlimento(alimento);

        }
    }
}

public enum TipoAlimentos
{
    ultraprocesado = 0,
    mediterraneo = 1,


}
