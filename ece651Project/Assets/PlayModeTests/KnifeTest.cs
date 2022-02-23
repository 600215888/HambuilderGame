using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class KnifeTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void KnifeTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator KnifeAlwaysGoDown()
    {
        GameObject knife = GameObject.Instantiate(Resources.Load("Prefabs/Knife_prefab/Knife") as GameObject);
        var originalPosition = knife.transform.position.y;
        yield return new WaitForFixedUpdate();
        // Assert
        Assert.That(originalPosition, Is.GreaterThan(knife.transform.position.y));
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
    }
}
