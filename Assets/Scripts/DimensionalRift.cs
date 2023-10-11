using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DimensionalRift : MonoBehaviour
{
    public Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider col)
    {
        if(col.name!="Main Camera")
        {
            return;
        }
        //We are outside the dimension
        if(transform.position.z > col.transform.position.z)
        {
            foreach(var mat in materials)
            {
                mat.SetInt("stest", (int)CompareFunction.NotEqual);
            }
            Debug.Log("Entered");
        }
        //Inside the dimension
        else
        {
            foreach (var mat in materials)
            {
                mat.SetInt("stest", (int)CompareFunction.Equal);
            }
            Debug.Log("Exited");
        }
    }

}
