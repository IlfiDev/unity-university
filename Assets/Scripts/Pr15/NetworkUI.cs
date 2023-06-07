using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Netcode;

public class NetworkUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button _host;
    [SerializeField] private Button _client;

    private void Awake(){
        _host.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();
                });
    }
}
