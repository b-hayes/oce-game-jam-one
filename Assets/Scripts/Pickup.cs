using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float bobAmount = 1f;
    public float speed = 1f;

    private Vector3 startPosition;
    private Vector3 endPosition;
    private float bobDirection = 1f;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startPosition = new Vector3(startPosition.x, startPosition.y + bobAmount, startPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.y - startPosition.y) > bobAmount)
        {
            bobDirection *= -1f;
        }
        transform.Translate(Vector3.up * (Time.deltaTime * speed * bobDirection) );
    }
}
