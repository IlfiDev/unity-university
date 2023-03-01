using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script345 : MonoBehaviour
{
    private Renderer _renderer;
    private Vector3 _mouseOffset;
    private float _mouseZCoord;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnMouseEnter(){
        _renderer.material.color = Color.green;
    }

    private void OnMouseExit(){
        _renderer.material.color = Color.white;
    }


    private void OnMouseDown(){
        _mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        _mouseOffset = gameObject.transform.position - getMousePosition();

        Debug.Log(transform.position);
        Debug.Log(_renderer.material.color);
    }

    private Vector3 getMousePosition(){
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = _mouseZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag(){
        transform.position = getMousePosition() + _mouseOffset;
    }

}
