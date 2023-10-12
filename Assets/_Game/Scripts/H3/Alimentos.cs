using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Alimentos : MonoBehaviour
{
    
    public TipoAlimentos alimento;
    public bool enMano;
    private XRGrabInteractable grabInteractable;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(OnGrabbed);
        grabInteractable.onSelectExited.AddListener(OnReleased);
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        enMano = true;
    }

    private void OnReleased(XRBaseInteractor interactor)
    {
        enMano = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTRANDO");
        Debug.Log(enMano );

        if (enMano == true && other.CompareTag("Canasta"))
        {
            Debug.Log("DENTRO");
            Canasta.canasta.ContadorAlimento(alimento);
            Destroy(gameObject);

        }
    }
}

public enum TipoAlimentos
{
    ultraprocesado = 0,
    mediterraneo = 1,


}
