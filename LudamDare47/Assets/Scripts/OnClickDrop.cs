using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDrop : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        rb.useGravity=true;
    }
}
