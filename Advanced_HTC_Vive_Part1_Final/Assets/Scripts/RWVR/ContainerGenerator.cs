﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerGenerator : MonoBehaviour {

    public GameObject container;
    public GameObject parentContainer;
    public int length = 0;
    private int count = 0;
    //private SendInputString Obj;
    string inputChild;
    string myTag;

    public GameObject A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z;

    void SetContainerPhysics() {
        this.gameObject.transform.RotateAround(transform.position, Vector3.up, -180);

    }
    public void Start()
    {
        GameObject Parent = GameObject.Find("Parent");

        SendInputString ParentInputObject = Parent.GetComponent<SendInputString>();
        inputChild = ParentInputObject.input;
        Parent.SetActive(false);
        //SendInputString.input = "";

        length = inputChild.Length;
        SetContainerPhysics();
        Debug.Log("message recieved is"+inputChild);

        CreateContainers();
    }
    

    /// <summary>
    /// creates container boxes
    /// </summary>
    public void CreateContainers () {
        //update value of y for multiple words on the "space" letter
       while (length > count)
        {
            Vector3 temp = transform.position;
           
            Vector3 temp2 = transform.position;

            Quaternion rotat = transform.rotation;

            temp.z -= 0.25f*(count+1);
            temp2 = temp;

            myTag = inputChild[count].ToString();

            container.tag = this.myTag;
            //Debug.Log("NAmE:" + container.name);
           // container.transform.parent = this.gameObject.transform;// position;

            GameObject foo = Instantiate(container, temp, rotat);
            foo.transform.parent = this.gameObject.transform;

           GameObject tempObj = null;
            int flag = 0;
            if (myTag == "A")
            {
                tempObj = A;
                flag = 1;
            }
            else if (myTag == "B")
            {
                tempObj = B;
                flag = 1;
            }
            else if (myTag == "C")
            {
                tempObj = C;
                flag = 1;
            }
            else if (myTag == "D")
            {
                tempObj = D;
                flag = 1;
            }
            else if (myTag == "E")
            {
                tempObj = E;
                flag = 1;
            }
            else if (myTag == "F")
            {
                tempObj = F;
                flag = 1;
            }
            else if (myTag == "G")
            {
                tempObj = G;
                flag = 1;
            }
            else if (myTag == "H")
            {
                tempObj = H;
                flag = 1;
            }
            else if (myTag == "I")
            {
                tempObj = I;
                flag = 1;
            }
            else if (myTag == "J")
            {
                tempObj = J;
                flag = 1;
            }
            else if (myTag == "K")
            {
                tempObj = K;
                flag = 1;
            }
            else if (myTag == "L")
            {
                tempObj = L;
                flag = 1;
            }
            else if (myTag == "M")
            {
                tempObj = M;
                flag = 1;
            }
            else if (myTag == "N")
            {
                tempObj = N;
                flag = 1;
            }
            else if (myTag == "O")
            {
                tempObj = O;
                flag = 1;
            }
            else if (myTag == "P")
            {
                tempObj = P;
                flag = 1;
            }
            else if (myTag == "Q")
            {
                tempObj = Q;
                flag = 1;
            }
            else if (myTag == "R")
            {
                tempObj = R;
                flag = 1;
            }
            else if (myTag == "S")
            {
                tempObj = S;
                flag = 1;
            }
            else if (myTag == "T")
            {
                tempObj = T;
                flag = 1;
            }
            else if (myTag == "U")
            {
                tempObj = U;
                flag = 1;
            }
            else if (myTag == "V")
            {
                tempObj = V;
                flag = 1;
            }
            else if (myTag == "W")
            {
                tempObj = W;
                flag = 1;
            }
            else if (myTag == "X")
            {
                tempObj = X;
                flag = 1;
            }
            else if (myTag == "Y")
            {
                tempObj = Y;
                flag = 1;
            }
            else if (myTag == "Z")
            {
                tempObj = Z;
                flag = 1;
            }



            if (flag == 1)
            {
                tempObj.tag = myTag;
                tempObj.SetActive(true);

                //temp2.x+= 0.198f+0.092f-0.413f;
                //temp2.y+= -0.121f+0.055f-0.062f;
                //temp2.z+= 0.242f-0.125f+0.109f;
                temp2.x += 0.033F;
                temp2.y += -0.09F;
                temp2.z += 0.164F;

                //tempObj.transform.parent = container.transform;
                // tempObj.transform.position = container.transform.position;




                GameObject childObj = Instantiate(tempObj, temp2, rotat);
                
                childObj.transform.SetParent(foo.transform, true);
                childObj.transform.position = temp2;


                // childObJ.transform.parent = container.transform;
                childObj.SetActive(false);

                //  Instantiate(tempObj, temp2, rotat);

                //  container.transform.GetChild(0).gameObject.SetActive(true);
                //Debug.Log("Child"+container.transform.GetChild(0));



                tempObj = null;
            }
            count++;
        }
    }
}
