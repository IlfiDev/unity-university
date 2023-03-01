using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    [SerializeField] private GameObject _object;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T)){
            Instantiate(_object, transform.position, Quaternion.identity);
        }
    }
}
