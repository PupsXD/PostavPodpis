
using System;
using System.Collections.Generic;
using CharachterDirectory;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private RandomizeCharachter _randomize;

    private void Start()
    {
        _randomize = FindObjectOfType<RandomizeCharachter>().GetComponent<RandomizeCharachter>();
        _randomize.RandomisePoilitic();
        
        
            
           
        
    }
}
