using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PcGaze : MonoBehaviour
{
    
    public GameObject markPrefab; // Assign a small sphere prefab to simulate the mark
    
    
    void Update()
    {
       
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray intersects any object
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.layer == 12)
            {
                // Instantiate the mark at the intersection point
                PhotonNetwork.Instantiate("TeacherGazeDot", hit.point, Quaternion.identity);
            }
        
    }

   
}
