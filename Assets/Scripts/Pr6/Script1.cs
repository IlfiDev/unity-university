using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    [SerializeField] private GameObject _object;

    void Update()
    {
        checkJump();    
    }

    private void checkJump(){
        if (Input.GetButtonDown("Jump")){
            Rigidbody rb = _object.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0f, 100f, 0f));
        }
    }

}
