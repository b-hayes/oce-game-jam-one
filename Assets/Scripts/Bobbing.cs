using System;
using UnityEngine;
using Random = UnityEngine.Random;


[RequireComponent(typeof(AudioSource))]
public class Bobbing : MonoBehaviour
{
    public float bobAmount = 1f;
    public float bobSpeed = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * (Mathf.Sin (Time.time * bobSpeed) * bobAmount);
       
    }

}
