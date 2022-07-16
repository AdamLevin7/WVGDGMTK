using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalBomb : MonoBehaviour
{

    public float speed;
    public float direction;
    private float endX;
    private float nextX;

    void Start()
    {
        endX = transform.position.x + direction;
    }

    // Update is called once per frame
    void Update()
    {
        nextX = Mathf.MoveTowards(transform.position.x, endX, speed * Time.deltaTime);
        Vector2 movePosition = new Vector3(nextX, transform.position.y, transform.position.z);
        transform.position = movePosition;
        Destroy(gameObject, 1);
    }

}
