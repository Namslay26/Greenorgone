using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cac : MonoBehaviour
{
    // Start is called before the first frame update
    public int i;
    private static float ka;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ka = newCac.k;
        transform.position -= new Vector3 (ka*Time.deltaTime,0,0);
    }
}