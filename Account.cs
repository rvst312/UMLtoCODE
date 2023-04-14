using System;

public class Account {
    public String IBAN;
    protected float Amount;

    public bool Transaction(string valeu) {
        return false;
    }
}

public class Investing : Account {
    public float Interest;
    public  void ApplyInterest(){
        return null;
    }
}

public class Savings : Account {
    
}