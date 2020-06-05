using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Pickup : MonoBehaviour
{
    public float bobAmount = 0.002f;
    public float bobSpeed = 2f;
    public float rotationSpeed = 50f;

    public AudioClip[] pickUpSounds;

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
            // Destroy(gameObject); //todo: stops sound on destroy so..
        }
    }

    private void PlayPickUpSound()
    {
        int length = pickUpSounds.Length;
        if (length < 1)
        {
            print("No pickUp sound to play");
            return;
        }
        AudioClip clip = pickUpSounds[Random.Range(0,length)];
        AudioSource audioSource = GetComponent<AudioSource>();
        if (! audioSource)
        {
            print("Pickup has no audio source");
            return;
        }
        audioSource.clip = clip;
        audioSource.loop = false;
        audioSource.Play();
        print("Pickup sound played");
    }
}
