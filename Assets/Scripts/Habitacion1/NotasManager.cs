using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotasManager : MonoBehaviour
{
    public Notificacion[] notificaciones;
    public int indice = 0;

    void Update()
    {
		if (Time.time > notificaciones[indice].tiempo)
		{

		}
    }
}

public enum FigurasPosibles
{
    semiCorchea = 0,
    corchea = 1,
    negra = 2,
    blanca = 3,
    redonda = 4
}

[System.Serializable]
public class Notificacion
{
    public float tiempo;
    public FigurasPosibles figura;
}