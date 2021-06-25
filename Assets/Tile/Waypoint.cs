using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlacable = true;
    [SerializeField] GameObject towerPrefab;

    void OnMouseDown()
    {
        if(isPlacable)
        {
            PlaceTower();
            isPlacable = false;
        }
        
        
    }

    void PlaceTower()
    {
        Instantiate(towerPrefab, transform.position, Quaternion.identity);
    }

}
