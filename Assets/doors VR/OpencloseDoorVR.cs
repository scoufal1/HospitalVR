using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpencloseDoorVR : MonoBehaviour
{
    public Animator openandclose1;
    public bool open;
    public Transform Player;
    RaycastHit hit;

    void Start()
    {
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player)
        {
            float dist = Vector3.Distance(Player.position, transform.position);
            if (dist < 15)
            {
                hit = CustomLaserPointer.instance.getHit();
                if (CustomLaserPointer.instance.LaserHit() && hit.collider.gameObject == gameObject)
                {
                    if (open == false)
                    {
                        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                        {
                            StartCoroutine(opening());
                        }
                    }
                    else
                    {
                        if (open == true)
                        {
                            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                            {
                                StartCoroutine(closing());
                            }
                        }

                    }
                }

            }
        }
    }

    IEnumerator opening()
    {
        print("you are opening the door");
        openandclose1.Play("Opening 1");
        open = true;
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator closing()
    {
        print("you are closing the door");
        openandclose1.Play("Closing 1");
        open = false;
        yield return new WaitForSeconds(0.5f);
    }
}
