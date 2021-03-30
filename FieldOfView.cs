using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject ParentGameObject;
    public LayerMask notIgnore;

    public static string saveListDataChampisInView;

    private string test;

    void Start(){
        saveListDataChampisInView = "\"Champignons dans champ de vision\":[";
    }
    void FixedUpdate()
    {
        if (!GameManager.gameIsPaused)
        {
            test = "{";

            foreach(Transform child in ParentGameObject.transform)
            {
                Vector3 screenPoint = mainCamera.WorldToViewportPoint(child.position);
                if((transform.position-child.position).magnitude < 20f && (screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1) && !Physics.Linecast(transform.position, child.position + 0.1f*Vector3.up)){
                    test += JsonUtility.ToJson(child.position) + ",";
                }
            }

            if(test == "{"){
                saveListDataChampisInView += "{},";
            }else{
                saveListDataChampisInView += test.Remove(test.Length - 1) + "},";
            }
        }
    }
}
