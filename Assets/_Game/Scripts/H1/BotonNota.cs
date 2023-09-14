using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonNota : MonoBehaviour
{
    public bool accionable;
	public Material material;

	private void Start()
	{
		material = GetComponent<Renderer>().material;
		Desactivar();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("mano"))
		{
			
			if (accionable)
			{
				ControlH1.singleton.SumarPuntos();
				material.color = Color.green;
				ControlH1.singleton.ActualizarPuntosTexto();
			}
			else
			{
				ControlH1.singleton.RestarPuntos();
				material.color = Color.red;
				ControlH1.singleton.ActualizarPuntosTexto();
			}
			accionable = false;

		}

	}
	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("mano"))
		{
			material.color = Color.white;
		}

	}

	public void Activar()
	{
		accionable = true;
		material.color = Color.green;
	}

	public void Desactivar()
	{
		accionable = false;
		material.color = Color.red;
	}
}
