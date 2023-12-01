using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 direction = goal.position - this.transform.position;
        if(direction.magnitude > 5)
        this.transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
