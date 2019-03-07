using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {
    Rigidbody rb;
    public float pushForce;
    public bool isMoving;
    Vector3 prevLocation;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        prevLocation = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void FixedUpdate()
    {
        if (prevLocation != transform.position)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        prevLocation = transform.position;
    }

    public void Push()
    {
		// can be improve by better way
		//Vector3 force = Random.insideUnitSphere * pushForce;

		Vector3 force = Random.insideUnitSphere * pushForce;
		force.y = transform.position.y;
		Debug.Log (force);
		rb.AddForce(force, ForceMode.Impulse);
		Debug.DrawLine (transform.position, transform.right, Color.red, 2f);
       
        isMoving = true;
    }

    public void Place(int c, string o)
    {
        //cuboid 108 scene
        if (o == "milo" || o == "pocky")
        {
            //face 6
            if ((c % 36) / 6 == 0)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 1)
                transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 0);//Debug.Log("eulerAngles 1 = " + transform.eulerAngles);
            else if ((c % 36) / 6 == 2)
                transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, 0); //transform.rotation = Quaternion.Euler(180, transform.rotation.y, 0);
            else if ((c % 36) / 6 == 3)
                transform.eulerAngles = new Vector3(270, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 4)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 90);
            else
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 270);

            //rotation 6
            if (c % 6 == 0)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
            else if (c % 6 == 1)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 60, transform.eulerAngles.z);
            else if (c % 6 == 2)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 120, transform.eulerAngles.z);
            else if (c % 6 == 3)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            else if (c % 6 == 4)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 240, transform.eulerAngles.z);
            else
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 300, transform.eulerAngles.z);

            //position 3
            if (c >= 36 && c < 72) //(c == 36) //if (c >= 36 && c < 72)
                transform.position = new Vector3(0, 0.92f, 0.11f); //36~71
            else if (c >= 72) //(c == 72)
                transform.position = new Vector3(-0.11f, 0.92f, 0.11f); //72~107
            else
                transform.position = new Vector3(0, 0.92f, 0);  //0~35

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        else if (o == "crayola" || o == "andes")
        {
            //face 6
            if ((c % 36) / 6 == 0)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 1)
                transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 0);//Debug.Log("eulerAngles 1 = " + transform.eulerAngles);
            else if ((c % 36) / 6 == 2)
                transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, 0); //transform.rotation = Quaternion.Euler(180, transform.rotation.y, 0);
            else if ((c % 36) / 6 == 3)
                transform.eulerAngles = new Vector3(270, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 4)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 90);
            else
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 270);

            //rotation 6
            if (c % 6 == 0)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
            else if (c % 6 == 1)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 60, transform.eulerAngles.z);
            else if (c % 6 == 2)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 120, transform.eulerAngles.z);
            else if (c % 6 == 3)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            else if (c % 6 == 4)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 240, transform.eulerAngles.z);
            else
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 300, transform.eulerAngles.z);

            //position 3
            if (c >= 36 && c < 72) //(c == 36) //if (c >= 36 && c < 72)
                transform.position = new Vector3(0, 0.9f, 0.12f); //36~71
            else if (c >= 72) //(c == 72)
                transform.position = new Vector3(-0.11f, 0.92f, 0.11f); //72~107
            else
                transform.position = new Vector3(0, 0.9f, 0);  //0~35

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        else if (o == "kotex" ||o == "kleenex" || o == "raisins")
        {
            //face 6
            if ((c % 36) / 6 == 0)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 1)
                transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 2)
                transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 3)
                transform.eulerAngles = new Vector3(270, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 4)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 90);
            else
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 270);

            //rotation 6
            if (c % 6 == 0)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
            else if (c % 6 == 1)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 60, transform.eulerAngles.z);
            else if (c % 6 == 2)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 120, transform.eulerAngles.z);
            else if (c % 6 == 3)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            else if (c % 6 == 4)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 240, transform.eulerAngles.z);
            else
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 300, transform.eulerAngles.z);

            //position 3
            if (c >= 36 && c < 72) //(c == 36) //if (c >= 36 && c < 72)
                transform.position = new Vector3(0, 0.92f, 0.12f); //36~71
            else if (c >= 72) //(c == 72)
                transform.position = new Vector3(-0.11f, 0.94f, 0.11f); //72~107
            else
                transform.position = new Vector3(0, 0.92f, 0);  //0~35

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        else if (o == "macadamia")
        {
            //face 6
            if ((c % 36) / 6 == 0)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 1)
                transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 2)
                transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 3)
                transform.eulerAngles = new Vector3(270, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 4)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 90);
            else
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 270);

            //rotation 6
            if (c % 6 == 0)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
            else if (c % 6 == 1)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 60, transform.eulerAngles.z);
            else if (c % 6 == 2)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 120, transform.eulerAngles.z);
            else if (c % 6 == 3)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            else if (c % 6 == 4)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 240, transform.eulerAngles.z);
            else
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 300, transform.eulerAngles.z);

            //position 3
            if (c >= 36 && c < 72) //(c == 36) //if (c >= 36 && c < 72)
                transform.position = new Vector3(0, 0.95f, 0.1f); //36~71
            else if (c >= 72) //(c == 72)
                transform.position = new Vector3(-0.08f, 0.96f, 0.12f); //72~107
            else
                transform.position = new Vector3(0, 0.95f, 0);  //0~35

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        else if (o == "swiss_miss")
        {
            //face 6
            if ((c % 36) / 6 == 0)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 1)
                transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 2)
                transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 3)
                transform.eulerAngles = new Vector3(270, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 4)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 90);
            else
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 270);

            //rotation 6
            if (c % 6 == 0)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
            else if (c % 6 == 1)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 60, transform.eulerAngles.z);
            else if (c % 6 == 2)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 120, transform.eulerAngles.z);
            else if (c % 6 == 3)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            else if (c % 6 == 4)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 240, transform.eulerAngles.z);
            else
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 300, transform.eulerAngles.z);

            //position 3
            if (c >= 36 && c < 72) //(c == 36) //if (c >= 36 && c < 72)
                transform.position = new Vector3(0, 0.93f, 0.07f); //36~71
            else if (c >= 72) //(c == 72)
                transform.position = new Vector3(-0.05f, 0.93f, 0.08f); //72~107
            else
                transform.position = new Vector3(0, 0.93f, 0);  //0~35

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        else if (o == "kellogg")
        {
            //position 3
            if (c >= 36 && c < 72) //(c == 36) //if (c >= 36 && c < 72)
                transform.position = new Vector3(0, 0.9f, 0.07f); //36~71
            else if (c >= 72) //(c == 72)
                transform.position = new Vector3(-0.033f, 0.9f, 0.033f); //72~107
            else
                transform.position = new Vector3(0, 0.9f, 0);  //0~35
            //face 6
            if ((c % 36) / 6 == 0)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 1)
            {
                transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 0);
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
            }
            else if ((c % 36) / 6 == 2)
                transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 3)
            {
                transform.eulerAngles = new Vector3(270, transform.eulerAngles.y, 0);
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
            }
            else if ((c % 36) / 6 == 4)
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 90);
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.02f, transform.position.z);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 270);
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.02f, transform.position.z);
            }
            //rotation 6
            if (c % 6 == 0)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
            else if (c % 6 == 1)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 60, transform.eulerAngles.z);
            else if (c % 6 == 2)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 120, transform.eulerAngles.z);
            else if (c % 6 == 3)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            else if (c % 6 == 4)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 240, transform.eulerAngles.z);
            else
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 300, transform.eulerAngles.z);
            
            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        else if (o == "ziploc")
        {
            //face 6
            if ((c % 36) / 6 == 0)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 1)
                transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 2)
                transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 3)
                transform.eulerAngles = new Vector3(270, transform.eulerAngles.y, 0);
            else if ((c % 36) / 6 == 4)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 90);
            else
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 270);

            //rotation 6
            if (c % 6 == 0)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
            else if (c % 6 == 1)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 60, transform.eulerAngles.z);
            else if (c % 6 == 2)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 120, transform.eulerAngles.z);
            else if (c % 6 == 3)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            else if (c % 6 == 4)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 240, transform.eulerAngles.z);
            else
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 300, transform.eulerAngles.z);

            //position 3
            if (c >= 36 && c < 72) //(c == 36) //if (c >= 36 && c < 72)
                transform.position = new Vector3(0, 0.93f, 0.07f); //36~71
            else if (c >= 72) //(c == 72)
                transform.position = new Vector3(-0.05f, 0.93f, 0.08f); //72~107
            else
                transform.position = new Vector3(0, 0.93f, 0);  //0~35

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        //Cylinder 114 scene
        else if (o == "viva")
        {
            //rotation  6 / 1 (6 * 6 + 2 * 1)
            if (c < 108)
            {
                if ((c % 36) / 6 == 0)//(c == 0 || c ==36 || c == 72) //0~5 36~41 72~77
                    transform.eulerAngles = new Vector3(0, 270, 270);
                else if ((c % 36) / 6 == 1) //(c == 6 || c == 42 || c == 78) 
                    transform.eulerAngles = new Vector3(0, 330, 270);//Debug.Log("eulerAngles 1 = " + transform.eulerAngles);
                else if ((c % 36) / 6 == 2) //(c == 12 || c == 48 || c == 84)
                    transform.eulerAngles = new Vector3(0, 30, 270); //transform.rotation = Quaternion.Euler(180, transform.rotation.y, 0);
                else if ((c % 36) / 6 == 3) //(c == 18 || c == 54 || c == 90)
                    transform.eulerAngles = new Vector3(0, 90, 270);
                else if ((c % 36) / 6 == 4) //(c == 24 || c == 60 || c == 96)
                    transform.eulerAngles = new Vector3(0, 150, 270);
                else if ((c % 36) / 6 == 5) //(c == 30 || c == 66 || c == 102) //102~107
                    transform.eulerAngles = new Vector3(0, 210, -90);
            }
            else
            {
                if (c < 111)
                    transform.eulerAngles = new Vector3(0, 0, 0);
                else
                    transform.eulerAngles = new Vector3(180, 0, 0);
            }

            //face 6 + 2
            if (c < 108)
            {
                if (c % 6 == 0)
                    transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
                else if (c % 6 == 1)
                    transform.eulerAngles = new Vector3(60, transform.eulerAngles.y, transform.eulerAngles.z);
                else if (c % 6 == 2)
                    transform.eulerAngles = new Vector3(120, transform.eulerAngles.y, transform.eulerAngles.z);
                else if (c % 6 == 3)
                    transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, transform.eulerAngles.z);
                else if (c % 6 == 4)
                    transform.eulerAngles = new Vector3(240, transform.eulerAngles.y, transform.eulerAngles.z);
                else
                    transform.eulerAngles = new Vector3(300, transform.eulerAngles.y, transform.eulerAngles.z);
            }


            //position 3
            if (c < 108)
            {
                if (c >= 36 && c < 72)
                    transform.position = new Vector3(0, 0.89f, 0.07f); //36~71
                else if (c >= 72)
                    transform.position = new Vector3(0.033f, 0.9f, 0.033f); //72~107
                else
                    transform.position = new Vector3(0, 0.89f, 0);  //0~35
            }
            else if (c == 108)
                transform.position = new Vector3(0, 0.97f, 0);
            else if (c == 109)
                transform.position = new Vector3(0.1f, 0.97f, 0);
            else if (c == 110)
                transform.position = new Vector3(0.1f, 0.97f, 0.1f);
            else if (c == 111)
                transform.position = new Vector3(0, 0.97f, 0);
            else if (c == 112)
                transform.position = new Vector3(0.1f, 0.97f, 0);
            else if (c == 113)
                transform.position = new Vector3(0.1f, 0.97f, 0.1f);

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        else if (o == "3m" || o == "heineken" || o == "cocacola" || o == "stax")
        {
            //rotation  6 / 1 (6 * 6 + 2 * 1)
            if (c < 108)
            {
                if ((c % 36) / 6 == 0)
                    transform.eulerAngles = new Vector3(0, 0, 0);
                else if ((c % 36) / 6 == 1) 
                    transform.eulerAngles = new Vector3(0, 60, 0);
                else if ((c % 36) / 6 == 2) 
                    transform.eulerAngles = new Vector3(0, 120, 0);
                else if ((c % 36) / 6 == 3)
                    transform.eulerAngles = new Vector3(0, 180, 0);
                else if ((c % 36) / 6 == 4)
                    transform.eulerAngles = new Vector3(0, 240, 0);
                else if ((c % 36) / 6 == 5) 
                    transform.eulerAngles = new Vector3(0, 300, 0);
            }
            else
            {
                if (c < 111)
                    transform.eulerAngles = new Vector3(270, 0, 0);
                else
                    transform.eulerAngles = new Vector3(90, 0, 0);
            }
            //face 6 + 2
            if (c < 108)
            {
                if (c % 6 == 0)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
                else if (c % 6 == 1)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60);
                else if (c % 6 == 2)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 120);
                else if (c % 6 == 3)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 180);
                else if (c % 6 == 4)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 240);
                else
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 300);
            }
            //position 3
            if (c < 108)
            {
                if (c >= 36 && c < 72)
                    transform.position = new Vector3(0, 0.9f, 0.07f); //36~71
                else if (c >= 72)
                    transform.position = new Vector3(0.033f, 0.9f, 0.033f); //72~107
                else
                    transform.position = new Vector3(0, 0.9f, 0);  //0~35
            }
            else if (c == 108)
                transform.position = new Vector3(0, 0.97f, 0);
            else if (c == 109)
                transform.position = new Vector3(0.1f, 0.97f, 0);
            else if (c == 110)
                transform.position = new Vector3(0.1f, 0.97f, 0.1f);
            else if (c == 111)
                transform.position = new Vector3(0, 0.97f, 0);
            else if (c == 112)
                transform.position = new Vector3(0.1f, 0.97f, 0);
            else if (c == 113)
                transform.position = new Vector3(0.1f, 0.97f, 0.1f);

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        else if (o == "folgers" || o == "hunts" || o == "vanish")
        {
            //rotation  6 / 1 (6 * 6 + 2 * 1)
            if (c < 108)
            {
                if ((c % 36) / 6 == 0)
                    transform.eulerAngles = new Vector3(0, 0, 0);
                else if ((c % 36) / 6 == 1)
                    transform.eulerAngles = new Vector3(0, 60, 0);
                else if ((c % 36) / 6 == 2)
                    transform.eulerAngles = new Vector3(0, 120, 0);
                else if ((c % 36) / 6 == 3)
                    transform.eulerAngles = new Vector3(0, 180, 0);
                else if ((c % 36) / 6 == 4)
                    transform.eulerAngles = new Vector3(0, 240, 0);
                else if ((c % 36) / 6 == 5)
                    transform.eulerAngles = new Vector3(0, 300, 0);
            }
            else
            {
                if (c < 111)
                    transform.eulerAngles = new Vector3(270, 0, 0);
                else
                    transform.eulerAngles = new Vector3(90, 0, 0);
            }
            //face 6 + 2
            if (c < 108)
            {
                if (c % 6 == 0)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
                else if (c % 6 == 1)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60);
                else if (c % 6 == 2)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 120);
                else if (c % 6 == 3)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 180);
                else if (c % 6 == 4)
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 240);
                else
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 300);
            }

            //position 3
            if (c < 108)
            {
                if (c >= 36 && c < 72)
                    transform.position = new Vector3(0, 0.9f, 0.12f); //36~71
                else if (c >= 72)
                    transform.position = new Vector3(0.1f, 0.91f, 0.1f); //72~107
                else
                    transform.position = new Vector3(0, 0.9f, 0);  //0~35
            }
            else if (c == 108)
                transform.position = new Vector3(0, 0.91f, 0);
            else if (c == 109)
                transform.position = new Vector3(0.12f, 0.91f, 0);
            else if (c == 110)
                transform.position = new Vector3(0.1f, 0.91f, 0.11f);
            else if (c == 111)
                transform.position = new Vector3(0, 0.91f, 0);
            else if (c == 112)
                transform.position = new Vector3(0.12f, 0.91f, 0);
            else if (c == 113)
                transform.position = new Vector3(0.1f, 0.91f, 0.11f);

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
        //Rounded cuboid 72 scene
        else if (o == "mm" || o == "libava")
        {
            //face 6
            if ((c % 24) / 4 == 0)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            else if ((c % 24) / 4 == 1)
                transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, 0);
            else if ((c % 24) / 4 == 2)
                transform.eulerAngles = new Vector3(180, transform.eulerAngles.y, 0);
            else if ((c % 24) / 4 == 3)
                transform.eulerAngles = new Vector3(270, transform.eulerAngles.y, 0);
            /*else if ((c % 36) / 6 == 4)
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 90);
            else
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 270);*/

            //rotation 6
            if (c % 6 == 0)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
            else if (c % 6 == 1)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 60, transform.eulerAngles.z);
            else if (c % 6 == 2)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 120, transform.eulerAngles.z);
            else if (c % 6 == 3)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            else if (c % 6 == 4)
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 240, transform.eulerAngles.z);
            else
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 300, transform.eulerAngles.z);

            //position 3
            if (c >= 24 && c < 48) 
                transform.position = new Vector3(0, 0.92f, 0.11f); //24 ~ 47
            else if (c >= 48) 
                transform.position = new Vector3(-0.09f, 0.92f, 0.1f); //48 ~ 71
            else
                transform.position = new Vector3(0, 0.92f, 0);  //0 ~ 23

            Debug.Log("eulerAngles = " + transform.eulerAngles);
            isMoving = true;
        }
    }

    public void Reset()
	{
		//transform.position = new Vector3 (0, 0.9f, 0);
        isMoving = true;
        //Debug.Log("transform.position = " + transform.position);
    }
}
