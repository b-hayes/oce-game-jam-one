using System;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float bobAmount = 0.002f;
    public float bobSpeed = 2f;
    public float rotationSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * (Mathf.Sin (Time.time * bobSpeed) * bobAmount);
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("PLayer has picked up an item.");
            Destroy(gameObject);
        }
    }
}
