using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRed : MonoBehaviour
{
    //When the mouse hovers over the GameObject, it turns to this color (red)
    Color m_MouseOverColor = Color.red;

    //This stores the GameObject’s original color
    Color m_OriginalColor;

    //Get the GameObject’s mesh renderer to access the GameObject’s material and color
    MeshRenderer m_Renderer;

    bool red;

    void Start()
    {
        //Fetch the mesh renderer component from the GameObject
        m_Renderer = GetComponent<MeshRenderer>();
        //Fetch the original color of the GameObject
        m_OriginalColor = m_Renderer.material.color;
        red = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!red)
        {
            m_Renderer.material.color = m_MouseOverColor;
            red = true;
        } else
        {
            m_Renderer.material.color = m_OriginalColor;
            red = false;
        }
    }
}
