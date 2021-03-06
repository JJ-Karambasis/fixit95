﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZZD.UnityExtensions;

public class UIInteraction : MonoBehaviour
{   
    void OnMouseDown() {
        var anim = GetComponent<Animator>();

        ResetOtherIcons();

        if (anim.GetBool("Clicked")) {
            anim.SetBool("Clicked", false);
        } else {
            anim.SetBool("Clicked", true);
        }
    }

    void ResetOtherIcons() {
        var briefcase = GameObject.Find("Briefcase");
        var trash = GameObject.Find("Recycle");
        var mycomp = GameObject.Find("MyComp");
        var start = GameObject.Find("Start");
        var menu = this.transform.parent.gameObject.FindObject("StartMenu"); // hacky bs

        if (briefcase == this.gameObject) {
            trash.GetComponent<Animator>().SetBool("Clicked", false);
            mycomp.GetComponent<Animator>().SetBool("Clicked", false);
            start.GetComponent<Animator>().SetBool("Clicked", false);
        }

        if (trash == this.gameObject) {
            briefcase.GetComponent<Animator>().SetBool("Clicked", false);
            mycomp.GetComponent<Animator>().SetBool("Clicked", false);
            start.GetComponent<Animator>().SetBool("Clicked", false);
        }

        if (mycomp == this.gameObject) {
            trash.GetComponent<Animator>().SetBool("Clicked", false);
            briefcase.GetComponent<Animator>().SetBool("Clicked", false);
            start.GetComponent<Animator>().SetBool("Clicked", false);
        }

        if (start == this.gameObject) {
            trash.GetComponent<Animator>().SetBool("Clicked", false);
            briefcase.GetComponent<Animator>().SetBool("Clicked", false);
            mycomp.GetComponent<Animator>().SetBool("Clicked", false);
            if (!menu.active) {menu.SetActive(true);} else {menu.SetActive(false);}
        }
    }
}
