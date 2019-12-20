using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float LastDist;
    public GameObject Moving;
    // Start is called before the first frame update
    void Start()
    {
        LastDist = 0;
    }
    void ScaleObj()
    {
        float CurrDist = (Input.touches[0].position - Input.touches[1].position).magnitude;
        if (LastDist != 0)
        {
            Moving.transform.localScale += Vector3.one * (LastDist - CurrDist) * Time.deltaTime * 1f;
        }
        LastDist = CurrDist;
        foreach (Touch touc in Input.touches)
        {
            if (touc.phase == TouchPhase.Ended)
            {
                LastDist = 0;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touches.Length == 2)
        {
            ScaleObj();
        }
        foreach (Touch touch in Input.touches)
            if (touch.phase == TouchPhase.Moved)
        {
            transform.Rotate(new Vector3(0,-touch.deltaPosition.x,0));
        }
   
    }
}
