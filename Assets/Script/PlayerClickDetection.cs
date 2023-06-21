using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClickDetection : MonoBehaviour
{
    public Timer Timer;
    [SerializeField] private GameObject specificObject;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                if (clickedObject == specificObject)
                {
                    Timer.ChasseurWin();
                    Debug.Log("Clicked on the specific GameObject!");
                    // Perform the desired action for clicking on the specific GameObject
                }
            }
        }
    }
}
