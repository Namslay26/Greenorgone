using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCac : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject Cactus;
    public int i;
    public static float k;
    public float randomTime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("a",1,randomTime);
        i=0;
        k=(float)3;
    }

    // Update is called once per frame
    void Update()
    {
        i+=1;
        if(i<=100){
            i+=1;
        }
        else{
            i=0;
            k+=(float)0.1;
            //Invoke("a",randomTime);
        }
        
    }

    void a(){
        Spawn = Instantiate(Cactus, transform.position, Quaternion.identity) as GameObject;
    }

}
