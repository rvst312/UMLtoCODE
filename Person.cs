using System;

public abstract class Person {
    public abstract int ID;
    public abstract string Name;
    protected abstract string Phone;
    public abstract int Email;
    public Address Address;
}

public class Customer : Person {
    public DateTime registration;
    private int CreditScore;
    public Account Account;
}

public class Employee : Person {
    public Enum Departament;
    private float Salary;
}
