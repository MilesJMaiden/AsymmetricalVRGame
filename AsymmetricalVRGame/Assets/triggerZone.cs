using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerZone : MonoBehaviour
{

    public UnityEvent OnTriggerZoneEntered;

    public LayerMask layerMask;


    public void OnTriggerEnter(Collider other)
    {
        //if a layer is in the mask
        if (layerMask == (layerMask | (1 << other.gameObject.layer))) {

            OnTriggerZoneEntered.Invoke();

        }
    }

}
