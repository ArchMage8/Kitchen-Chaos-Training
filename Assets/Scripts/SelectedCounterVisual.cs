using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] visualGameObject;


    private void Start()
    {
        PlayerInteractions.Instance.OnSelectedCounterChanged += PlayerInteractions_OnSelectedCounterChanged;
    }


    
    private void PlayerInteractions_OnSelectedCounterChanged(object sender, PlayerInteractions.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == baseCounter)
        {
            Show();
        }
        else 
        {
            Hide();
        }
    }

    private void Show()
    {
        foreach (GameObject visualGameObject in visualGameObject)
        {
            visualGameObject.SetActive(true);

        }
    }

        private void Hide()
    {
        foreach (GameObject visualGameObject in visualGameObject)
        {
            visualGameObject.SetActive(false);
        }
    }
}
