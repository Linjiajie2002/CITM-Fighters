using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetToTarget : MonoBehaviour
{
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.position;
        transform.rotation = Target.rotation;
    }
}
