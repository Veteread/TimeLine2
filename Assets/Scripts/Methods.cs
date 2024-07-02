using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public void ScaleMethod()
    {
        transform.localScale = Vector3.one;
    }

    public void PowerMethod()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 20);
    }
    
    public void DestroyMethod()
    {
        Destroy(this.gameObject);
    }
}
