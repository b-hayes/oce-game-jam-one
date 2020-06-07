using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsPlayer : MonoBehaviour
{
    public GameObject deathEffect;
    public float delayToGameOver = 1f;

    private bool playerIsDead = false;
    private float timeSinceDeath = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsDead)
        {
            timeSinceDeath += Time.deltaTime;
        }

        if (timeSinceDeath > delayToGameOver)
        {
            GameManager.Lose();
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Player is dead"); 
            Instantiate(deathEffect, other.transform.position, Quaternion.identity);
            playerIsDead = true;
        }
    }
}
