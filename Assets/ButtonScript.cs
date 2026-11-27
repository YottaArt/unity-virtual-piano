using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{
    public UnityEvent unityEvents = new UnityEvent();
    public GameObject buton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buton = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                    {
                unityEvents.Invoke();
            }
        }
    }
}
