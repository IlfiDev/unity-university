using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _speed = Vector3.forward;

    private void Start(){
       Rigidbody rb = gameObject.AddComponent<Rigidbody>() as Rigidbody;
    }

    private void Update(){
        GetComponent<Rigidbody>().velocity = _speed * Time.deltaTime;
    }
}
