using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour
{

    Animation animation1;

    public float hitForce;

    void Start()
    {
        animation1 = GameObject.Find("anim").GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(ray.direction * hitForce);
                    animation1.Play("anim");
                }
        }
    }
}