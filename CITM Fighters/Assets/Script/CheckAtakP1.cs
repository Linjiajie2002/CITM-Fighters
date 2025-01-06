using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAtakP1 : MonoBehaviour
{
    // Start is called before the first frame update

    public string targetTag = "attack";
    public CharacterController Enemy = null;
    CharacterController Myself = null;
    void Start()
    {
        Myself = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag(targetTag) && Enemy.isHit)
        {
            Myself.dieAnimation();
            Enemy.winAnimation();
        }
    }
}
