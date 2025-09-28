using Unity.VisualScripting;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime,
            Input.GetAxis("Vertical") * Time.deltaTime,
            0);
        transform.Translate(vec);
    }
} 
