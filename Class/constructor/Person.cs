﻿namespace constructor;

public class Person
{
    public string FirstName;
    public string LastName;
    public int Age; 

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        this.Age = age;
    }
}