using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour
{
    public FigurasPosibles figura;
    public Vector3 velocidad;

    public void Inicializar(FigurasPosibles fig)
	{
        figura = fig;
	}
    void Update()
    {
        transform.Translate(velocidad * Time.deltaTime);
    }
}
