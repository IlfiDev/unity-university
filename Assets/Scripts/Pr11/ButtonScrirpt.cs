using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScrirpt : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectPanel;
    [SerializeField] private GameObject _gameObjectImage;

    [SerializeField] private Sprite _newSprite;

    public void Close(){
        _gameObjectPanel.SetActive(false);
    }


    public void ChangeSprite(){
        _gameObjectImage.GetComponent<UnityEngine.UI.Image>().sprite = _newSprite;
    }

}
