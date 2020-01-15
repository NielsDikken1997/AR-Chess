using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoThird : MonoBehaviour
{
	public GameObject Positions_2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit rayhit = new RaycastHit();

            if (Physics.Raycast(ray, out rayhit)){

                GameObject hitObject = rayhit.collider.gameObject;

                Debug.Log(hitObject.name);

                if (hitObject.name == "Queen_White_2"){
                    //Fetch the Renderer from the GameObject
                    Renderer rend = hitObject.GetComponent<Renderer>();

                    //Create a new Material
                    Material material = new Material(Shader.Find("Standard"));
                    material.color = Color.red;

                    //Switch to new material
                    rend.material = material;

                    //View Positions
                    Positions_2.SetActive(true);
                }

            }

    	}
        
    }
}
