using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
   
{
public ParticleSystem Light;
// Start is called before the first frame update
void Start()
    {
        
    }
    private void OnMouseDown()
    {
        Light.Play();
        var vec = gameObject.transform.position - Light.transform.position;
        var distance = vec.magnitude;
        Light.GetComponent<ParticleSystemRenderer>().lengthScale = distance;
        Light.transform.LookAt(gameObject.transform);
        Light.transform.Rotate(new Vector3(0, 180, 0));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
