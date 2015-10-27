using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Assets.Scripts
{
    public class BackgroundController : MonoBehaviour
    {
        void FixedUpdate()
        {
            Vector2 movement = new Vector2(10, 10);
            GetComponent<Rigidbody2D>().velocity = movement;

            GetComponent<Rigidbody2D>().position = new Vector2
        (
                Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, 0, 0),
                Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, 0, 0)
        );
        }
    }
}
