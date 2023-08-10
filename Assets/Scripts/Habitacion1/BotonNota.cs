using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonNota : MonoBehaviour
{
    public bool accionable;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("mano"))
		{
			if (accionable)
			{
				ControlH1.singeton.SumarPuntos();
			}
			else
			{
				ControlH1.singeton.RestarPuntos();
			}
			accionable = false;
		}

	}
}
