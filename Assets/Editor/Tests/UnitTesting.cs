using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class UnitTesting
{
    [Test]
    public void testing()
    {
        Assert.AreEqual(1, 1);
    }

    [Test]
    public void secondTest()
    {        
        Health health = new Health();
        health.NetworkedHealth++;

        Assert.AreEqual(102, health.NetworkedHealth);
    }
}