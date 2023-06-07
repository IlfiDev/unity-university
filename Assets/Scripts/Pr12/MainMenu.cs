using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _optionsPanel;
    [SerializeField] private GameObject _prPanel;
    private void Awake(){
    }

    public void Quit(){
        Application.Quit();
    }

    public void StartLevel(){
        Application.LoadLevel("Pract9-");
    }

    public void OpenOptions(){
        _optionsPanel.SetActive(true);
    }


    public void OpenPr10(){
        _prPanel.SetActive(true);
    }
}
