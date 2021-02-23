using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalpull : MonoBehaviour
{
   // bool isPool = false;
    public Transform cube;
    public Transform chilboy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (isPool)
        //{
            if(Input.GetKey(KeyCode.X))
            {
                cube.transform.parent = chilboy.transform;
                Debug.Log("its done");

            }
        //       else
          if (Input.GetKeyDown(KeyCode.V))

        {
            cube.transform.parent = null;
            Debug.Log("it is up");
        }
    }
}
    //public void DoPull()
    //{
    //    isPool = true;
    //}

