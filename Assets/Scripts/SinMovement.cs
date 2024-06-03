using UnityEngine;

public class SinMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float distance = 1.0f;
    public bool vertical = true;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float timer = 0.0f;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition;
    }

    void Update()
    {
        timer += Time.deltaTime * speed;

        float offset = Mathf.Sin(timer) * distance;
        if (vertical)
        {
            targetPosition = startPosition + new Vector3(0, offset, 0);
        }
        else
        {
            targetPosition = startPosition + new Vector3(offset, 0, 0);
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
    }
}