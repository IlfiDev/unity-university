using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMovement : MonoBehaviour
{
   [SerializeField] private float _speed;

   private void Update(){
        transform.Translate(transform.forward * Time.deltaTime * _speed);
   }
}
