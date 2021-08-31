using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombi : MonoBehaviour
{
    //bool saldiriyor;
    //Animator zombiAnim;
    
    GameObject hedefOyuncu;
    public float kovalamaMesafesi;
    //public float saldirmaMesafesi;
    NavMeshAgent zombiNavMesh;
    float mesafe;

    void Start()
    {
        //zombiAnim = this.GetComponent<Animator>();
        hedefOyuncu =  GameObject.Find("Player");
        zombiNavMesh = this.GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
            mesafe = Vector3.Distance(this.transform.position, hedefOyuncu.transform.position);
            if(mesafe < kovalamaMesafesi)
            {
                //zombiNavMesh.isStopped = false;
                zombiNavMesh.SetDestination(hedefOyuncu.transform.position);
                
            }
            else
            {
                zombiNavMesh.isStopped = true;
                
            }
            /*if(mesafe < saldirmaMesafesi);
            {
                zombiNavMesh.isStopped = true;//zıplama animasyonu
                zombiAnim.SetBool("saldiriyor", true);
            }*/
    }
}
