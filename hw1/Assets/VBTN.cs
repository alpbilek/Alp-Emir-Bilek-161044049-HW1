using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VBTN : MonoBehaviour
{
    public GameObject Cylinder;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        Cylinder.SetActive(false);
    }

    // Update is called once per frame

    public void OnButtonPressed(VirtualButtonBehaviour virtualButton) 
    {
        Cylinder.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour virtualButton)
    {
        Cylinder.SetActive(false);
    }

}
