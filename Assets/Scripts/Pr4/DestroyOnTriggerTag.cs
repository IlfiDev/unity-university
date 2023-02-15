using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTriggerTag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.transform.tag == "Cube"){
            Destroy(other.gameObject);
        }
    }
}
