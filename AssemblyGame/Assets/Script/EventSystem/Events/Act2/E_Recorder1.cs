﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Recorder1 : EventAbstract
{
    public override void DoAction()
    {
        // Trigger Dialog 
        actor.GetComponent<DialogTrigger>().TriggerDialogue(1);
    }
}
