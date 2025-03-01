#include <iostream>
#include <string>
using namespace std;

class Citizen
{
protected:
    string name;
    int age;

public:
    Citizen(string user_name, int user_age)
    {
        name = user_name;
        age = user_age;
    }
    void ShowUserInformation()
    {
        cout << "Name: " << name << endl;
        cout << "Age: " << age << endl; 
    }
};

class Student: public Citizen 
{
private:

public:
    using Citizen::Citizen;
};
class Employee: public Citizen {};
class Entrepreneur: public Citizen {};

int main()
{
    cout << "You're welcome to our e-Government" << endl << endl << "Choose an option to continue: " << endl;
    cout << "1. Register \n 2. "; 
    while (true)
    {
        break;
    }
    Student ct("f", 3);
    ct.ShowUserInformation();
    return 0;
}