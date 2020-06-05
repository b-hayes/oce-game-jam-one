using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float bobAmount = 0.002f;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * (Mathf.Sin (Time.time * speed) * bobAmount);
    }
}
