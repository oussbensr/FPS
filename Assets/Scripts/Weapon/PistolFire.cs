using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject blackPistol;
    public bool isFiring = false;
    public GameObject MuzzleFlash;
    public AudioSource pistolShot;

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FireThePistol());
            }
        }
    }
    IEnumerator FireThePistol()
    {
        isFiring = true;
        blackPistol.GetComponent<Animator>().Play("FirePistol");
        pistolShot.Play();
        MuzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        MuzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        blackPistol.GetComponent<Animator>().Play("New State");
        isFiring=false;



    }








}
