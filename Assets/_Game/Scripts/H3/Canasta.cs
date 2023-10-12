using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canasta : MonoBehaviour
{
    public static Canasta canasta;
    public int cantidadBuenos;
    public int cantidadMalos;
    private void Awake()
    {
        canasta = this;
    }

    public void ContadorAlimento(TipoAlimentos tipo)
    {
        switch (tipo)
        {
            case TipoAlimentos.ultraprocesado:
                cantidadMalos++;
                break;
            case TipoAlimentos.mediterraneo:
                cantidadBuenos++;
                break;
            default:
                break;
        }

    }

}
