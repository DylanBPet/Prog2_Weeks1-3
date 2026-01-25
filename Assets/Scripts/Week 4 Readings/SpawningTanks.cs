using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawningTanks : MonoBehaviour
{
    public List<GameObject> tanks;
    public GameObject spawnedTank;

    public Transform barrel;
    
    public GameObject tankPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            spawnedTank = Instantiate(tankPrefab, transform.position, Quaternion.identity);
            tanks.Add(spawnedTank);
        }

        for (int i = tanks.Count-1; i >= 0; i--)
        {
            float distance = Vector2.Distance(tanks[i].transform.position, barrel.position);
            if(distance < 1)
            {
                GameObject tank = tanks[i];
                tanks.Remove(tank);
                Destroy(tank);
               
            }

        }
    }
}
