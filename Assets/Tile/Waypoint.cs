﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{    
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaceable = true;

    public bool IsPlaceable { get { return isPlaceable; } }

    void OnMouseDown()
    {
        if(isPlaceable)
        {
            PlaceTower();
            isPlaceable = false;
        }
        
        
    }

    void PlaceTower()
    {
        Instantiate(towerPrefab, transform.position, Quaternion.identity);
    }

}
