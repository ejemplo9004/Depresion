using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlH1 : MonoBehaviour
{
    public static ControlH1 singeton;
	public int puntos;
	
	private void Awake()
	{
		if (singeton == null)
		{
			singeton = this;
		}
		else
		{
			DestroyImmediate(gameObject);
		}
	}
	public void SumarPuntos()
	{
		puntos++;
	}
	public void RestarPuntos()
	{
		if (puntos > 0)
		{
			puntos--;

		}
	}
}
