using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSecond : MonoBehaviour
{
	public GameObject Positions_1;
	public GameObject B_1;
	public GameObject B_2;
	public GameObject K_1;
	public GameObject K_2;
	public GameObject Queen_1;
	public GameObject Queen_2;

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

                if (hitObject.name == "Position_1"){
                	//Hide Rook_1
                	B_1.SetActive(false);
                	//Show Rook_2
                	B_2.SetActive(true);
                	//Hide Pawn_1
                	K_1.SetActive(false);
                	//Show Pawn_2
                	K_2.SetActive(true);
                	//Hide Queen_1
                	Queen_1.SetActive(false);
                	//Show Queen_2
                	Queen_2.SetActive(true);
                    //Hide Positions
                    Positions_1.SetActive(false);
                }

            }

    	}
        
    }
}