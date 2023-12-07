using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Corte : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("dentro"+other.tag);
        if (other.CompareTag("cuchillo"))
        {
            transform.SetParent(null);
            print("separo");
            Rigidbody rb = gameObject.AddComponent<Rigidbody>();
            XRGrabInteractable gameObjectInteractuable= gameObject.AddComponent<XRGrabInteractable>();
            //rb.isKinematic = true;
            gameObjectInteractuable.colliders.Add(GetComponent<MeshCollider>());
            Destroy(this);
            

        }
    }
}
