using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSlime : MonoBehaviour
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
            Begin = transform.position;
            End = Target.position;
        }
    }

    // Update is called once per frame
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
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
    }