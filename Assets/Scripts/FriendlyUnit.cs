﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FriendlyUnit : MonoBehaviour
{
    /// <summary>
    /// Chui's follower!
    /// 
    /// The Idea is like dungeon defender followers.
    /// </summary>
    public GameObject follower;

    void Follower()
    {
        follower.gameObject.transform.position = follower.transform.forward;
        follower.gameObject.transform.position = new Vector3(0, 5, 0);
    }
}