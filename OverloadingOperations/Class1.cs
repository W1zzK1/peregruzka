using System;

class Fraction
{
    private:
    long first;
    unsigned short second;

    public:
    Fraction()
    {
        first = 0;
        second = 0;
    }

    Fraction(long f,
        unsigned short s)
    {
        first = f;
        second = s;
    }

    void read()
    {
        cout << "First part: ";
        cin >> first;
        cout << "Second part: ";
        cin >> second;
    }

    void display()
    {
        cout << "Number: " << first << "." << second << endl;
    }

    string toString()
    {
        string s = to_string(first) + "." + to_string(second);
        return s;
    }

    static void Sum(Fraction a, Fraction b)
    {
        double one, two;
        one = a.second;
        while (one > 1)
            one /= 10;
        one += a.first;
        two = b.second;
        while (two > 1)
            two /= 10;
        two += b.first;
        cout << "Sum: " << one + two << endl;
    }

    static void Sub(Fraction a, Fraction b)
    {
        double one, two;
        one = a.second;
        while (one > 1)
            one /= 10;
        one += a.first;
        two = b.second;
        while (two > 1)
            two /= 10;
        two += b.first;
        cout << "Sub: " << one - two << endl;
    }

    static void Mul(Fraction a, Fraction b)
    {
        double one, two;
        one = a.second;
        while (one > 1)
            one /= 10;
        one += a.first;
        two = b.second;
        while (two > 1)
            two /= 10;
        two += b.first;
        cout << "Mul: " << one * two << endl;
    }

    static void Equal(Fraction a, Fraction b)
    {
        double one, two;
        one = a.second;
        while (one > 1)
            one /= 10;
        one += a.first;
        two = b.second;
        while (two > 1)
            two /= 10;
        two += b.first;

        if (one == two)
            cout << "Numbers are equal." << endl;
        else if (one > two)
            cout << "Number 1 is bigger than number 2." << endl;
        else
            cout << "Number 2 is bigger than number 1." << endl;
    }
};
