using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    private bool _isInTrigger = false;
    private Renderer _renderer;

    private void Start(){
        _renderer = _object.GetComponent<Renderer>();
    }
    // Update is called once per frame
     
    private void OnTriggerStay(Collider other){
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            _renderer.material.SetColor("_Color", Color.red);
        }
    }

    private void OnTriggerExit(Collider other){
        _renderer.material.SetColor("_Color", Color.white);
    }
}
