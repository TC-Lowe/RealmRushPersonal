using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{    
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaceable = true;
    [SerializeField] int placeCost = 50;
    //Bank bank;

    public bool IsPlaceable { get { return isPlaceable; } }

    //private void Start()
    //{
    //    bank = FindObjectOfType<Bank>();
    //}

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
        //bank.Withdraw(placeCost);
    }

}
