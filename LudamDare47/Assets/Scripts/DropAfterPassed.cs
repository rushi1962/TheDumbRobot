using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAfterPassed : MonoBehaviour
{
    public Rigidbody rb;
    public Transform Player;
    //[Serializable]
    public float _minDist, _maxDist;
    // Start is called before the first frame update
    void Start()
    {
        _minDist = -3.6f;
        _maxDist = -2.6f;
    }

    // Update is called once per frame
    void Update()
    {
        if((Player.position.z-transform.position.z)>_minDist&& (Player.position.z - transform.position.z)<_maxDist)
        {
            rb.useGravity = true;
        }
    }
}
