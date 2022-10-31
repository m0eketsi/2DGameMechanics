using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionFX : MonoBehaviour
{
    public float explodeTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, explodeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
