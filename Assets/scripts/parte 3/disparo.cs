using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disparo : MonoBehaviour
{
public GameObject gameObject;
public GameObject gameObject1;
public GameObject gameObject2;

public float y=0;

private bool cambio=true;

public Text texto;
public Transform firePoint;
private float _initialVelocity=15;
private int x;
    // Start is called before the first frame update
    void Start()
    {
        x=1;

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(1))
      {
if(x==1)
{
x=2;

texto.text="2";
}
else if(x==2)
{
x=3;
texto.text="3";
}
else if(x==3)
{
x=1;
texto.text="1";
}
}  

if (Input.GetMouseButtonDown(0))
{
if(x==1)
{
Fire();
}
if(x==2 && cambio==true)
{
Fire2();
cambio=false;
y= 200;
}
if(x==3)
{
Fire3();
}
}

if(cambio==false && y>0)
{


y--;
if(y==1)
{
cambio=true;
}
}
    }

 private void Fire()
    {

        GameObject cannonBall = Instantiate(
            gameObject,
            firePoint.position,
            Quaternion.identity);

Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
        rb.velocity= firePoint.right * _initialVelocity;



}

private void Fire2()
    {

        GameObject cannonBall = Instantiate(
            gameObject1,
            firePoint.position,
            Quaternion.identity);

Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
        rb.velocity= firePoint.right * _initialVelocity;



}

private void Fire3()
    {

        GameObject cannonBall = Instantiate(
            gameObject2,
            firePoint.position,
            Quaternion.identity);

Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
        rb.velocity= firePoint.right * _initialVelocity;



}

}
