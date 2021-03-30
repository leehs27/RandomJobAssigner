using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Person : Data
{
    public string name;
    public bool isActive;

    public Person()
    {
        name = "�̸�";
        isActive = true;
    }

    public Person(string name, bool isActive)
    {
        this.name = name ?? throw new ArgumentNullException(nameof(name));
        this.isActive = isActive;
    }
}
