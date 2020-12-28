using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(0,9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
