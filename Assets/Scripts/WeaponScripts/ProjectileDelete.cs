﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDelete : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Projectile")
        {
            Destroy(col.gameObject);
        }
    }
}
