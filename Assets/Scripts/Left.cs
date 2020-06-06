using System;
using UnityEngine;
using Random = UnityEngine.Random;


[RequireComponent(typeof(AudioSource))]
public class Left : MonoBehaviour
{
    public float bobAmount = 0.05f;
    public float bobSpeed = 0.25f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward* (Mathf.Sin (Time.time * bobSpeed) * bobAmount);
       
    }

}
