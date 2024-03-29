using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesCounterVisual : MonoBehaviour
{
    
    [SerializeField] private PlatesCounter platesCounter;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private Transform plateVisualPrefab;

    private List<GameObject> plateVisualGameObjectList;

    private void Awake()
    {
        plateVisualGameObjectList = new List<GameObject>();
    }

    private void Start()
    {
        platesCounter.OnPlateSpawned += PlatesCounter_OnPlateSpawned;
        platesCounter.OnPlateRemoved += PlatesCounter_OnPlatesRemoved;
    }

    private void PlatesCounter_OnPlateSpawned(object sender, System.EventArgs e)
    {
        Transform plateGameObject = Instantiate(plateVisualPrefab, counterTopPoint);

        float plateOffsetY = 0.1f;
        plateGameObject.localPosition = new Vector3(0, plateOffsetY * plateVisualGameObjectList.Count, 0);

        plateVisualGameObjectList.Add(plateGameObject.gameObject);
        
    }

    private void PlatesCounter_OnPlatesRemoved(object sender, System.EventArgs e)
    {
      GameObject plateGameObject = plateVisualGameObjectList[plateVisualGameObjectList.Count - 1];
        plateVisualGameObjectList.Remove(plateGameObject);
        Destroy(plateGameObject);
    }
}
