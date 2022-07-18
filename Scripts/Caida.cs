using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour
{
    public Transform Target;
    public float speed;
    public Vector3 Begin, End;
    public bool cae;

    // Start is called before the first frame update
    void Start()
    {

        if (Target != null)
        {
            Target.parent = null;
            Begin = transform.position;
            End = Target.position;
            cae = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null && cae)
        {
            float fixedspeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target.position, fixedspeed);
        }
        if (transform.position == Target.position)
        {
            cae = false;
            transform.position = Begin;
        }



    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        cae = true;
    }


}
    
