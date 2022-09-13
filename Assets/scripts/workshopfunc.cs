using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class workshopfunc : MonoBehaviour
{

   
    private float x;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(Sum_Ab(5, 5));
        Debug.Log(Prod_ab(5, 5));
        Debug.Log(Divab(5, 5));
       
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public  float Sum_Ab(float a, float b)
    {
        return (a + b);


    }

    public float Prod_ab(float a , float b)
    {

        return (a * b);

    }


    public float Divab(float a , float b)
    {
        if (b == 0 ) return 0;

        return (a / b);

    }
    
}
