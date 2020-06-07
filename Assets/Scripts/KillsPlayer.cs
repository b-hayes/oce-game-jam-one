using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsPlayer : MonoBehaviour
{
    public GameObject deathEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Player is dead"); 
            Instantiate(deathEffect, other.transform.position, Quaternion.identity);
            GameManager.Lose();
        }
    }
}
