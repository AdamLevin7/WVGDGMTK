using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBomb : MonoBehaviour
{

    public float speed;
    public float direction;
    private float endY;
    private float nextY;
    
    void Start()
    {
        endY = transform.position.y + direction;
    }

    // Update is called once per frame
    void Update()
    {
        nextY = Mathf.MoveTowards(transform.position.y, endY, speed * Time.deltaTime);
        Vector2 movePosition = new Vector3(transform.position.x, nextY, transform.position.z);
        transform.position = movePosition;
        Destroy(gameObject, 1);
    }
}
