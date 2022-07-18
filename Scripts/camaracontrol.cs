using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaracontrol : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject Target;
    private Vector3 Targetpos;
    public float smoothig;
    public float haciaadelante;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        Targetpos = new Vector3(Target.transform.position.x + haciaadelante, transform.position.y, transform.position.z);

        if (Target.transform.position.y > 14f)
        {
            Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 14.5f, transform.position.z);

        }
        else
        {
            if (Target.transform.position.y > 13f)
            {
                Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 13.5f, transform.position.z);

            }
            else
            {
                if (Target.transform.position.y > 12f)
                {
                    Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 12.5f, transform.position.z);

                }
                else
                {
                    if (Target.transform.position.y > 11f)
                    {
                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 11.5f, transform.position.z);

                    }
                    else
                    {
                        if (Target.transform.position.y > 10f)
                        {
                            Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 10.5f, transform.position.z);

                        }
                        else
                        {
                            if (Target.transform.position.y > 9f)
                            {
                                Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 9.5f, transform.position.z);

                            }
                            else
                            {
                                if (Target.transform.position.y > 8f)
                                {
                                    Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 8.5f, transform.position.z);

                                }
                                else
                                {
                                    if (Target.transform.position.y > 7f)
                                    {
                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 7.5f, transform.position.z);

                                    }
                                    else
                                    {
                                        if (Target.transform.position.y > 6f)
                                        {
                                            Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 6.5f, transform.position.z);

                                        }
                                        else
                                        {
                                            if (Target.transform.position.y > 5f)
                                            {
                                                Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 5.5f, transform.position.z);

                                            }
                                            else
                                            {
                                                if (Target.transform.position.y > 4f)
                                                {
                                                    Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 4.5f, transform.position.z);

                                                }
                                                else
                                                {
                                                    if (Target.transform.position.y > 3f)
                                                    {
                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 3.5f, transform.position.z);

                                                    }
                                                    else
                                                    {
                                                        if (Target.transform.position.y > 2f)
                                                        {
                                                            Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 2.5f, transform.position.z);

                                                        }
                                                        else
                                                        {
                                                            if (Target.transform.position.y > 1f)
                                                            {
                                                                Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, 0, transform.position.z);
                                                            }
                                                            else
                                                            {
                                                                if (Target.transform.position.y > -1f)
                                                                {
                                                                    Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -0.5f, transform.position.z);
                                                                }
                                                                else
                                                                {
                                                                    if (Target.transform.position.y > -2f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -1.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -3f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -2.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -4f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -3.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -5f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -4.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -6f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -5.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -7f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -6.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -8f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -7.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -9f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -8.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -10f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -9.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -11f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -10.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -12f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -11.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -13f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -12.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -14f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -13.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -15f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -14.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -16f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -15.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -17f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -16.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -18f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -17.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -19f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -18.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -20f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -19.5f, transform.position.z);
                                                                    }
                                                                    else if (Target.transform.position.y > -21f)
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -20.5f, transform.position.z);
                                                                    }
                                                                    else
                                                                    {
                                                                        Targetpos = new Vector3(Target.transform.position.x + haciaadelante * h, -21.5f, transform.position.z);
                                                                    }





                                                                }

                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        transform.position = Vector3.Lerp(transform.position, Targetpos,smoothig * Time.deltaTime);
    }
}
