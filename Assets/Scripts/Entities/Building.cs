using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject testUnit;
    public Transform SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            Instantiate(testUnit, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    private void OnGUI()
    {
        //Event e = Event.current;
        //if (e.button == 0 && e.isMouse)
        //{
        //    Instantiate(testUnit, new Vector3(0, 0, 0), Quaternion.identity);

        //}
        //if (Input.GetMouseButtonUp(1))
        //{
        //    Instantiate(testUnit, new Vector3(0, 0, 0), Quaternion.identity);
        //}
    }
}
