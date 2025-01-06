using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerPos : MonoBehaviour
{
    // Start is called before the first frame update

    private Material _mat;
    private GameObject _player;
    void Start()
    {
        _mat = GetComponent<MeshRenderer>().materials[0];
        _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _mat.SetVector("_PlayerPos", _player.transform.position);
    }
}
