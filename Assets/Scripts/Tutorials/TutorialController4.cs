using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController4 : MonoBehaviour
{
    public GameObject[] b = new GameObject[4];
    public GameObject[] bUse = new GameObject[4];

    Vector3[] bUsePos = new Vector3[4];

    private float secondCounter = 0;


    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            bUsePos[i] = bUse[i].transform.position;
        }
    }









    void Update()
    {
        secondCounter += Time.deltaTime;
 
        if (secondCounter < 4 && secondCounter > 3)
        {
            bUse[0].transform.position = b[0].transform.position;
        }
        else if (secondCounter < 5 && secondCounter > 4)
        {
            bUse[1].transform.position = b[1].transform.position;
        }
        else if (secondCounter < 6 && secondCounter > 5)
        {
            bUse[2].transform.position = b[2].transform.position;
        }
        else if (secondCounter < 7 && secondCounter > 6)
        {
            bUse[3].transform.position = b[3].transform.position;
        }
    }

}
