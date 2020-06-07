using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGamePickup : MonoBehaviour
{
    bool EndGame  = false;
    float endTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Game Ending");
            EndGame = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
         if (EndGame)
        {
            print(endTime.ToString());
            endTime += Time.deltaTime;
            if (endTime > 1)
            {

                 print("Won Game!");
                GameManager.Win();
            }
        }

    }
}
