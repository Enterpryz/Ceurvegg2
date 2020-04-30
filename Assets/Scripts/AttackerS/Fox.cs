using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject GOotherObject = otherCollider.gameObject;

        if (GOotherObject.GetComponent<Gravestone>())
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }

        else if (GOotherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(GOotherObject);
        }
    }


    




}
