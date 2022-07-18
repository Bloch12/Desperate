using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataformas2 : MonoBehaviour
{
    public Transform Target;
    public float speed;
    private Vector3 Begin, End;

    // Start is called before the first frame update
    void Start()
    {

        if (Target != null)
        {
            Target.parent = null;
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
 

    }
}
