using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OneFourth : MonoBehaviour
{
	public GameObject Positions_2;
	public GameObject Pawn_2;
	public GameObject Pawn_3;
	public GameObject Queen_2;
	public GameObject Queen_3;
	public GameObject win_text;
    public TextMeshProUGUI Score;
    public GameObject Score_object;
    public GameObject Restart;

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

                if (hitObject.name == "Position_2"){
                	//Hide Pawn_2
                	Pawn_2.SetActive(false);
                	//Show Pawn_3
                	Pawn_3.SetActive(true);
                	//Hide Queen_2
                	Queen_2.SetActive(false);
                	//Show Queen_3
                	Queen_3.SetActive(true);
                	//Show win text
                	win_text.SetActive(true);
                    //Show score
                    float t = Time.time - DefaultTrackableEventHandler.startTime;
                    string minutes = ((int) t/60).ToString();
                    string seconds = (t % 60).ToString("f0");
                    Score.text = minutes + ":" + seconds;
                    Score_object.SetActive(true);
                    //Show restart
                    Restart.SetActive(true);
                    //Hide Positions
                    Positions_2.SetActive(false);
                }

            }

    	}
        
    }
}