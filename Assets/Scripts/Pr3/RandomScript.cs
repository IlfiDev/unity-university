using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _randomRange;
    private Vector2 _destination;
    void Start()
    {
        _randomRange = Random.Range(-10, 10);
        Debug.Log(_randomRange);
        if(_randomRange < 0) {
            Debug.Log("Отрицательное значение");
        }
    }

    // Update is called once per frame
    void Update()
    {
       moveToRandomDestination(); 
    }


    private void moveToRandomDestination(){
        _destination = new Vector2(Random.Range(-_randomRange, _randomRange),
                Random.Range(-_randomRange, _randomRange));

        transform.position = new Vector3 (_destination.x, 0, _destination.y);
    }
}
