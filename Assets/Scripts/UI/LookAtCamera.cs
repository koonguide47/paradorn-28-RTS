using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LookAtCamera : MonoBehaviour
{
    private Camera cam;
    
    void Awake()
    {
        cam = Camera.main;    
    }
    
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = cam.transform.eulerAngles;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
