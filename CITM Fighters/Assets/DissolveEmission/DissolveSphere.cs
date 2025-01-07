using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DissolveSphere : MonoBehaviour
{

    Material[] mats;
    public float dissolveSpeed = 0.5f; 
    private float dissolveAmount = 0f;
    private bool isDissolving = true;  
    private bool isWidthSet = false;

    public CharacterController _playerController;
    private void Start()
    {

        mats = GetComponent<Renderer>().materials;
        _playerController = FindObjectOfType<CharacterController>();
    }

    private void Update()
    {

        if (_playerController.gameFinish && _playerController.isDie && _playerController.isDieFinish)
        {
            foreach (Material mat in mats)
            {
                mat.SetFloat("_DissolveWidth", 0.05f);
            }
            isWidthSet = true; // 确保只执行一次


            if (isDissolving)
            {
               
                dissolveAmount += Time.deltaTime * dissolveSpeed;
                dissolveAmount = Mathf.Clamp01(dissolveAmount);

                
                foreach (Material mat in mats)
                {
                    mat.SetFloat("_DissolveAmount", dissolveAmount);
                }

                
                if (dissolveAmount >= 1f)
                {
                    isDissolving = false;
                    OnDissolveComplete();
                }
            }
        }
    }

    private void OnDissolveComplete()
    {
        
        Debug.Log("Dissolve completed!");
        Destroy(gameObject); 
    }
}
