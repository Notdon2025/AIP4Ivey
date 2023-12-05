using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGoal : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform goal;
    public float accuracy = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.LookAt(goal.position);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.red);
        if(direction.magnitude > accuracy)
        this.transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
