using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaEscena : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag=="Flecha")
		{
            SceneManager.LoadScene("SampleScene");
		}
	}
}
