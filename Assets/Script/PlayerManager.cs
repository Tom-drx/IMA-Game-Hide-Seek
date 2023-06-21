using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private CharacterController controller;
    public static bool isGameStarted;






    // Start is called before the first frame update
    void Start()
    {
        Thread.Sleep(3000);
        isGameStarted = true;

        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
 


    }
}