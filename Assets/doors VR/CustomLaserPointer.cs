using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLaserPointer : MonoBehaviour
{
    public static CustomLaserPointer instance;

    public Transform handTransform;

    RaycastHit hit;

    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool LaserHit()
    {
        if(Physics.Raycast(handTransform.transform.position, handTransform.forward, out hit))
        {
            if(hit.collider.gameObject.tag == "door")
            {
                return true;
            }
        }
        return false;
    }

    public RaycastHit getHit()
    {
        return hit;
    }
}
