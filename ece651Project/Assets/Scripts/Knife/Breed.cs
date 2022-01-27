using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Breed
{
    // Start is called before the first frame update
    public void move(Enemy enemy, Vector3 startpos, float dist);
}
