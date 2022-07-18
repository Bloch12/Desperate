using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlatafromas : MonoBehaviour
{
    public Transform Target;
    public float speed;
    public Vector3 Begin, End;

    // Start is called before the first frame update
    void Start()
    {
        
        if (Target != null)
        {
            Target.parent = null;
            Begin = transform.position;
            End = Target.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    void FixedUpdate()
    {
        if (Target != null)
        {

            float fixedspeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target.position, fixedspeed);
        }
        if (transform.position == Target.position)
        {
            Target.position = (Target.position == Begin) ? End : Begin;
        }
        
    }
}
  
