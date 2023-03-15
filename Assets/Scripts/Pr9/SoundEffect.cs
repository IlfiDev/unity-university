using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    [SerializeField] private AudioSource _effect;

    private void OnCollisionEnter(Collision collision){
        _effect.Play();

    }
}
