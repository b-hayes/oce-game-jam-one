using System;
using UnityEngine;
using Random = UnityEngine.Random;


[RequireComponent(typeof(AudioSource))]
public class Pickup : MonoBehaviour
{
    public float bobAmount = 0.002f;
    public float bobSpeed = 2f;
    public float rotationSpeed = 50f;

    public AudioClip[] pickUpSounds;
    public GameObject pickUpEffect;

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
            PlayPickUpSound();
            Instantiate(pickUpEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void PlayPickUpSound()
    {
        int length = pickUpSounds.Length;
        if (length < 1) return;
        AudioClip clip = pickUpSounds[Random.Range(0,length)];
        AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
    }
}
