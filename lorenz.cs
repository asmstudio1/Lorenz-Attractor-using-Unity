using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lorenz : MonoBehaviour
{
    // Start is called before the first frame update

    public float sigma,roh,beta;
    public float dt = 0.01f;
    float dx, dy, dz;
    float x, y, z;

    private void Start()
    {
        x = 0.01f;
        y = 0f;
        z=0f;
        
        
    }

    // Update is called once per frame
    void Update(){

        dx = (sigma * (y - x))*dt;
        dy = (x * (roh - z) - y)*dt;
        dz = (x * y - beta * z)*dt;

        x += dx;
        y += dy;
        z += dz;


        transform.Translate(dx, dy, dz);

    
    }
}
