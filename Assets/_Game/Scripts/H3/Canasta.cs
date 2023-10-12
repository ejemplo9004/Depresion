using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Canasta : MonoBehaviour
{
    public static Canasta canasta;
    public int cantidadBuenos;
    public int cantidadMalos;
    public Text cantidadMalosTexto;
    public Text cantidadBuenosTexto;
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
                cantidadMalosTexto.text = cantidadMalos.ToString();
                break;
            case TipoAlimentos.mediterraneo:
                cantidadBuenos++;
                cantidadBuenosTexto.text = cantidadBuenos.ToString();
                break;
            default:
                break;
        }

    }

}
